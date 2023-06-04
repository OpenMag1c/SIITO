using Client.Enums;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Client;
public partial class EditOsnastkaForm : Form
{
    private readonly AppDbContext DbContext = new AppDbContext(Program.ContextOptions);

    private readonly ActionType CurrentAction;
    private readonly int OsnastkaId;

    public EditOsnastkaForm(ActionType actionType, int osnastkaId = -1)
    {
        InitializeComponent();
        CurrentAction = actionType;
        OsnastkaId = osnastkaId;
    }

    protected override void OnLoad(EventArgs e)
    {
        FillStaticData();

        if (CurrentAction == ActionType.Update)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "Обновление оснастки";
            actionButton.Text = "Обновить";
            editOsnastkaMainLabel.Text = "Обновить существующую оснастку";
            FillOsnastkaData();
        }
        else if (CurrentAction == ActionType.Create)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Создание остастки";
            actionButton.Text = "Создать";
            editOsnastkaMainLabel.Text = "Создать новую оснастку";
        }

        base.OnLoad(e);
    }

    private void actionButton_Click_1(object sender, EventArgs e)
    {
        bool isCompleted = false;

        switch (CurrentAction)
        {
            case ActionType.Update:
                isCompleted = UpdateOsnastka();
                break;

            case ActionType.Create:
                isCompleted = CreateNewOsnastka();
                break;
        }

        if (isCompleted)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void FillOsnastkaData()
    {
        var osnastka = DbContext.Osnastkas
            .AsNoTracking()
            .Include(x => x.OsnastkaType)
            .FirstOrDefault(x => x.Id == OsnastkaId);

        osnastkaNameInput.Text = osnastka.Name;
        ostastkaPriceInput.Text = osnastka.Price.ToString();

        if (osnastka.Picture != null)
        {
            MemoryStream ms = new MemoryStream(osnastka.Picture);
            Image imageData = Image.FromStream(ms);
            OsnastkaPictureBox.Image = imageData;
            OsnastkaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        if (osnastka.Description != null)
        {
            descInput.Text = osnastka.Description;
        }

        currencySelect.SelectedValue = osnastka.Currency;
        osnastkaTypeSelect.SelectedValue = osnastka.OsnastkaType.Id;
    }

    private void FillStaticData()
    {
        currencySelect.DisplayMember = "Text";
        currencySelect.ValueMember = "Value";

        osnastkaTypeSelect.DisplayMember = "Text";
        osnastkaTypeSelect.ValueMember = "Value";

        currencySelect.DataSource = Enum.GetValues<CurrencyEnum>().Select(x => new { Text = x.ToString(), Value = x.ToString() }).ToArray();
        osnastkaTypeSelect.DataSource = DbContext.OsnastkaTypes.Select(x => new { Text = x.Name, Value = x.Id }).ToArray();
    }

    private bool UpdateOsnastka()
    {
        var osnastka = DbContext.Osnastkas
            .Include(x => x.OsnastkaType)
            .FirstOrDefault(x => x.Id == OsnastkaId);

        #region validation

        if (osnastkaNameInput.Text.Length < 5)
        {
            MessageBox.Show("Минимальная длина названия оснастки - 5 символов", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (osnastkaNameInput.Text.Length > 256)
        {
            MessageBox.Show("Превышена максимальная длина названия оснастки (256 символов)", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!decimal.TryParse(ostastkaPriceInput.Text, out decimal priceValue))
        {
            MessageBox.Show("Недопустимое значение для цены оснастки", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (priceValue <= 0)
        {
            MessageBox.Show("Недопустимое значение для цены оснастки", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        #endregion


        var img = OsnastkaPictureBox.Image;
        byte[]? imagebytes = null;
        if (img != null)
        {
            using (var mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                imagebytes = mStream.ToArray();
            }
        }

        osnastka.Name = osnastkaNameInput.Text;
        osnastka.Picture = imagebytes;
        osnastka.Price = priceValue;
        osnastka.Currency = currencySelect.SelectedValue.ToString();
        osnastka.Description = descInput.Text;
        osnastka.OsnastkaTypeId = (int)osnastkaTypeSelect.SelectedValue;

        DbContext.SaveChanges();
        return true;
    }

    private bool CreateNewOsnastka()
    {
        #region validation

        if (osnastkaNameInput.Text.Length < 5)
        {
            MessageBox.Show("Минимальная длина названия оснастки - 5 символов", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (osnastkaNameInput.Text.Length > 256)
        {
            MessageBox.Show("Превышена максимальная длина названия оснастки (256 символов)", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!decimal.TryParse(ostastkaPriceInput.Text, out decimal priceValue))
        {
            MessageBox.Show("Недопустимое значение для цены оснастки", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (priceValue <= 0)
        {
            MessageBox.Show("Недопустимое значение для цены оснастки", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        #endregion


        var img = OsnastkaPictureBox.Image;
        byte[]? imagebytes = null;
        if (img != null)
        {
            using (var mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                imagebytes = mStream.ToArray();
            }
        }

        var osnastka = new Osnastka()
        {
            Name = osnastkaNameInput.Text,
            Price = priceValue,
            Currency = currencySelect.SelectedValue.ToString(),
            Picture = imagebytes,
            Description = descInput.Text,
            OsnastkaTypeId = (int)osnastkaTypeSelect.SelectedValue
        };

        DbContext.Osnastkas.Add(osnastka);
        DbContext.SaveChanges();
        return true;
    }

    private void OsnastkaPictureBox_Click(object sender, EventArgs e)
    {
        var ofd = new OpenFileDialog();
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            Bitmap bmp = new Bitmap(ofd.FileName);
            OsnastkaPictureBox.Image = bmp;
            OsnastkaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
