using Client.Enums;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

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
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            actionButton.Text = "Обновить";
            editInstrumentMainLabel.Text = "Обновить существующий инструмент";
            FillInstrumentData();
        }
        else if (CurrentAction == ActionType.Create)
        {
            this.FormBorderStyle = FormBorderStyle.None;
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void FillInstrumentData()
    {
        var instrument = DbContext.Instruments
            .AsNoTracking()
            .Include(x => x.Gost)
            .Include(x => x.InstrumentType)
            .FirstOrDefault(x => x.Id == InstrumentId);

        instrumentNameInput.Text = instrument.Name;
        instrumentPriceInput.Text = instrument.Price.ToString();

        if (instrument.Picture != null)
        {
            MemoryStream ms = new MemoryStream(instrument.Picture);
            Image imageData = Image.FromStream(ms);
            instrumentPictureBox.Image = imageData;
            instrumentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        if (instrument.Description != null)
        {
            descInput.Text = instrument.Description;
        }

        currencySelect.SelectedValue = instrument.Currency;
        instrumentTypeSelect.SelectedValue = instrument.InstrumentType.Id;
        gostsSelect.SelectedValue = instrument.Gost.Id;
    }

    private void FillStaticData()
    {
        currencySelect.DisplayMember = "Text";
        currencySelect.ValueMember = "Value";

        gostsSelect.DisplayMember = "Text";
        gostsSelect.ValueMember = "Value";

        instrumentTypeSelect.DisplayMember = "Text";
        instrumentTypeSelect.ValueMember = "Value";

        gostsSelect.DataSource = DbContext.Gosts.Select(x => new { Text = x.Name, Value = x.Id }).ToArray();
        instrumentTypeSelect.DataSource = DbContext.InstrumentTypes.Select(x => new { Text = x.Name, Value = x.Id }).ToArray();
        currencySelect.DataSource = Enum.GetValues<CurrencyEnum>().Select(x => new { Text = x.ToString(), Value = x.ToString() }).ToArray();
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
        var instrument = DbContext.Instruments
            .Include(x => x.Gost)
            .Include(x => x.InstrumentType)
            .FirstOrDefault(x => x.Id == InstrumentId);

        #region validation

        if (!decimal.TryParse(instrumentPriceInput.Text, out decimal priceValue))
        {
            MessageBox.Show("Недопустимое формат цены инструмента", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (priceValue <= 0)
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

        instrument.Name = instrumentNameInput.Text;
        instrument.Price = priceValue;
        instrument.Currency = currencySelect.SelectedValue.ToString();
        instrument.Picture = imagebytes;
        instrument.Description = descInput.Text;
        instrument.InstrumentTypeId = (int)instrumentTypeSelect.SelectedValue;
        instrument.GostId = (int)gostsSelect.SelectedValue;

        DbContext.SaveChanges();
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

        if (priceValue <= 0)
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
            Measure = "шт",
            Price = priceValue,
            Currency = currencySelect.SelectedValue.ToString(),
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
