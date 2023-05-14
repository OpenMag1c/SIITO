using Client.Enums;
using DAL;
using Domain.Entities;

namespace Client;
public partial class EditInstrumentForm : Form
{
    private readonly AppDbContext DbContext = new AppDbContext(Program.ContextOptions);

    private readonly ActionType CurrentAction;
    private readonly int InstrumentId;

    public EditInstrumentForm(ActionType actionType, int instrumentId = -1)
    {
        InitializeComponent();
        CurrentAction = actionType;
        InstrumentId = instrumentId;
    }

    protected override void OnLoad(EventArgs e)
    {
        FillStaticData();

        if (CurrentAction == ActionType.Update)
        {
            actionButton.Text = "Обновить";
            editInstrumentMainLabel.Text = "Обновить существующий инструмент";
            FillInstrumentData();
        }
        else if (CurrentAction == ActionType.Create)
        {
            actionButton.Text = "Создать";
            editInstrumentMainLabel.Text = "Создать новый инструмент";
            FillInstrumentData();
        }

        base.OnLoad(e);
    }

    private void actionButton_Click(object sender, EventArgs e)
    {
        switch (CurrentAction)
        {
            case ActionType.Update:
                UpdateInstrument();
                break;

            case ActionType.Create:
                CreateNewInstrument();
                break;
        }

        this.Close();
    }

    private void FillInstrumentData()
    {

    }

    private void FillStaticData()
    {
        gostsSelect.DisplayMember = "Text";
        gostsSelect.ValueMember = "Value";

        instrumentTypeSelect.DisplayMember = "Text";
        instrumentTypeSelect.ValueMember = "Value";

        gostsSelect.DataSource = DbContext.Gosts.Select(x => new { Text = x.Name, Value = x.Id }).ToArray(); ;
        instrumentTypeSelect.DataSource = DbContext.InstrumentTypes.Select(x => new { Text = x.Name, Value = x.Id }).ToArray();
    }

    private void instrumentPictureBox_Click(object sender, EventArgs e)
    {
        var ofd = new OpenFileDialog();
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            Bitmap bmp = new Bitmap(ofd.FileName);
            instrumentPictureBox.Image = bmp;
            instrumentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

    private void UpdateInstrument()
    {

    }

    private void CreateNewInstrument()
    {
        // todo validation

        var img = instrumentPictureBox.Image;
        byte[]? imagebytes = null;
        if (img != null)
        {
            using (var mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                imagebytes = mStream.ToArray();
            }
        }

        var instrument = new Instrument()
        {
            Name = instrumentNameInput.Text,
            Code = instrumentCodeInput.Text,
            Measure = "шт",
            Dimensions = $"{numericUpDown1.Value}x{numericUpDown2.Value}x{numericUpDown3.Value}",
            Price = decimal.Parse(instrumentPriceInput.Text),
            Picture = imagebytes,
            InstrumentTypeId = (int)instrumentTypeSelect.SelectedValue,
            GostId = (int)gostsSelect.SelectedValue
        };

        DbContext.Instruments.Add(instrument);
        DbContext.SaveChanges();
    }
}
