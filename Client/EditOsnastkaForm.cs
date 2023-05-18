using Client.Enums;
using DAL;
using Domain.Entities;

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
            actionButton.Text = "Обновить";
            editOsnastkaMainLabel.Text = "Обновить существующую оснастку";
            FillOsnastkaData();
        }
        else if (CurrentAction == ActionType.Create)
        {
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
            this.Close();
        }
    }

    private void FillOsnastkaData()
    {

    }

    private void FillStaticData()
    {
        osnastkaTypeSelect.DisplayMember = "Text";
        osnastkaTypeSelect.ValueMember = "Value";

        osnastkaTypeSelect.DataSource = DbContext.OsnastkaTypes.Select(x => new { Text = x.Name, Value = x.Id }).ToArray();
    }

    private bool UpdateOsnastka()
    {
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
