using Client.Enums;
using DAL;
using Domain.Entities;
using System.Text.RegularExpressions;

namespace Client;
public partial class EditInstrumentForm : Form
{
    private readonly AppDbContext DbContext = new AppDbContext(Program.ContextOptions);

    private readonly ActionType CurrentAction;
    private readonly int InstrumentId;

    private readonly Regex CodeRegex = new Regex(@"^\d\d\d\d-\d\d\d\d\s\S{3,}");

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
        }

        base.OnLoad(e);
    }

    private void actionButton_Click(object sender, EventArgs e)
    {
        bool isCompleted = false;

        switch (CurrentAction)
        {
            case ActionType.Update:
                isCompleted = UpdateInstrument();
                break;

            case ActionType.Create:
                isCompleted = CreateNewInstrument();
                break;
        }

        if (isCompleted)
        {
            this.Close();
        }
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

    private bool UpdateInstrument()
    {
        return true;
    }

    private bool CreateNewInstrument()
    {
        #region validation

        if (!decimal.TryParse(instrumentPriceInput.Text, out decimal priceValue))
        {
            MessageBox.Show("Недопустимое значение для цены инструмента", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (instrumentNameInput.Text.Length < 5)
        {
            MessageBox.Show("Минимальная длина названия инструмента - 5 символов", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (instrumentNameInput.Text.Length > 256)
        {
            MessageBox.Show("Превышена максимальная длина названия инструмента (256 символов)", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!CodeRegex.IsMatch(instrumentCodeInput.Text))
        {
            MessageBox.Show("Некорректный ввод кода инструмента", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        #endregion


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
            Price = priceValue,
            Picture = imagebytes,
            Description = descInput.Text,
            InstrumentTypeId = (int)instrumentTypeSelect.SelectedValue,
            GostId = (int)gostsSelect.SelectedValue
        };

        DbContext.Instruments.Add(instrument);
        DbContext.SaveChanges();
        return true;
    }
}
