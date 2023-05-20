using Client.Cards;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace Client;

public partial class OsnastkaForm : Form
{
    private readonly AppDbContext context = new AppDbContext(Program.ContextOptions);
    MainForm mainForm;
    private List<Osnastka> Osnastkas;
    private readonly OsnastkaTypeEnum OsnastkaType;

    public OsnastkaForm(OsnastkaTypeEnum osnastkaType, MainForm mainForm)
    {
        OsnastkaType = osnastkaType;
        InitializeComponent();
        this.mainForm = mainForm;
    }

    private void OsnastkaForm_Load(object sender, EventArgs e)
    {
        this.ControlBox = false;

        SetPath(OsnastkaType);

        GetOsnastkas(OsnastkaType);
        PopulateOsnastkas();
    }

    public string getOsnastkaTypeName(OsnastkaTypeEnum osnastkaType)
    {
        switch (osnastkaType)
        {
            case OsnastkaTypeEnum.Shtampi:
                return "Штампы";
            case OsnastkaTypeEnum.PressFormi:
                return "Пресс-формы";
            case OsnastkaTypeEnum.ModelOsnastka:
                return "Модельная оснастка";
            case OsnastkaTypeEnum.Prisposoblenie:
                return "Приспособления";
            default:
                return "";
        }
    }

    private void PopulateOsnastkas()
    {
        Osnastkas.ForEach(osnastka =>
        {
            var osnastkaCard = new OsnastkaCard(osnastka, getOsnastkaTypeName(OsnastkaType));
            osnastkaCard.OsnastkaUpdated += OsnastkaCard_OsnastkaUpdated;
            osnastkaCard.OsnastkaDeleted += OsnastkaCard_DeleteOsnastka;
            osnastkaContainer.Controls.Add(osnastkaCard);
        });
    }

    private void OsnastkaCard_OsnastkaUpdated()
    {
        Osnastkas.Clear();
        osnastkaContainer.Controls.Clear();

        GetOsnastkas(OsnastkaType);
        PopulateOsnastkas();
    }

    private void OsnastkaCard_DeleteOsnastka(OsnastkaCard osnastkaCard)
    {
        var osnastka = context.Osnastkas.FirstOrDefault(x => x.Id == osnastkaCard.Osnastka.Id);
        if (osnastka != null)
        {
            try
            {
                context.Osnastkas.Remove(osnastka);
                context.SaveChanges();

                osnastkaContainer.Controls.Remove(osnastkaCard);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при удалении оснастки", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void GetOsnastkas(OsnastkaTypeEnum osnastkaType)
    {
        var data = context.Osnastkas.AsNoTracking().Include(x => x.OsnastkaType);
        if (osnastkaType == OsnastkaTypeEnum.All)
        {
            Osnastkas = data.ToList();
        }
        else
        {
            Osnastkas = data.Where(x => x.OsnastkaTypeId == (int)osnastkaType).ToList();
        }
    }

    public void SetPath(OsnastkaTypeEnum osnastkaType)
    {
        if (osnastkaType != OsnastkaTypeEnum.All)
        {
            labelType.Visible = true;
            labelType.Text = "/ " + getOsnastkaTypeName(osnastkaType);
        }
    }

    private void pictureButtonAdd_Click(object sender, EventArgs e)
    {
        mainForm.addOsnastka_Click(sender, e);
    }

    private void pictureButtonExport_Click(object sender, EventArgs e)
    {
        using (var package = new ExcelPackage())
        {
            try
            {
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells["A1"].Value = "Наименование";
                worksheet.Cells["B1"].Value = "Тип оснастки";
                var count = 2;
                Osnastkas.ForEach(x =>
                {
                    worksheet.Cells["A" + count.ToString()].Value = x.Name;
                    worksheet.Cells["B" + count.ToString()].Value = x.OsnastkaType.Name;
                    count++;
                });

                string currentDirectory = Directory.GetCurrentDirectory();
                var path = "osnastka.xlsx";
                FileInfo excelFile = new FileInfo(path);
                package.SaveAs(excelFile);
                MessageBox.Show("Данные были экспортированы в " + currentDirectory, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при экспорте", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
