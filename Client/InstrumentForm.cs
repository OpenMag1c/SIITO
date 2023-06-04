using Client.Cards;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Data;

namespace Client;

public partial class InstrumentForm : Form
{
    private readonly AppDbContext context = new AppDbContext(Program.ContextOptions);
    MainForm mainForm;
    private List<Instrument> Instruments;
    private readonly InstrumentTypeEnum InstrumentType;

    public InstrumentForm(InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All, MainForm mainForm = null)
    {
        InstrumentType = instrumentType;
        InitializeComponent();
        this.mainForm = mainForm;
    }

    public static string GetInstrumentTypeName(InstrumentTypeEnum instrumentType)
    {
        switch (instrumentType)
        {
            case InstrumentTypeEnum.Rezci:
                return "Резцы";
            case InstrumentTypeEnum.Protyazhki:
                return "Протяжки";
            case InstrumentTypeEnum.Frezi:
                return "Фрезы";
            case InstrumentTypeEnum.RolikiRezb:
                return "Ролики резьбонакатные";
            case InstrumentTypeEnum.Zenkeri:
                return "Зенкеры";
            case InstrumentTypeEnum.Metchiki:
                return "Метчики";
            case InstrumentTypeEnum.Razvertki:
                return "Развертки";
            case InstrumentTypeEnum.InstrumentMechKreplenie:
                return "Инструмент с механическим креплением";
            default:
                return "";
        }
    }

    private void InstrumentForm_Load(object sender, EventArgs e)
    {
        this.ControlBox = false;

        SetPath(InstrumentType);

        GetInstruments(InstrumentType);
        PopulateInstruments();
    }

    private void PopulateInstruments()
    {
        Instruments.ForEach(instrument =>
        {
            var instrumentCard = new InstrumentCard(instrument, this.InstrumentType);
            instrumentCard.InstrumentDeleted += InstrumentCard_DeleteInstrument;
            instrumentCard.InstumentUpdated += InstrumentCard_InstumentUpdated;
            instrumentsContainer.Controls.Add(instrumentCard);
        });
    }

    private void InstrumentCard_InstumentUpdated()
    {
        Instruments.Clear();
        instrumentsContainer.Controls.Clear();

        GetInstruments(InstrumentType);
        PopulateInstruments();
    }

    private void InstrumentCard_DeleteInstrument(InstrumentCard instrumentCard)
    {
        var instrument = context.Instruments.FirstOrDefault(x => x.Id == instrumentCard.Instrument.Id);
        if (instrument != null)
        {
            try
            {
                context.Instruments.Remove(instrument);
                context.SaveChanges();

                instrumentsContainer.Controls.Remove(instrumentCard);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при удалении инструмента", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void GetInstruments(InstrumentTypeEnum instrumentType)
    {
        var data = context.Instruments.AsNoTracking().Include(x => x.InstrumentType).Include(x => x.Gost);
        if (instrumentType == InstrumentTypeEnum.All)
        {
            Instruments = data.ToList();
        }
        else
        {
            Instruments = data.Where(x => x.InstrumentTypeId == (int)instrumentType).ToList();
        }
    }

    public void SetPath(InstrumentTypeEnum instrumentType)
    {
        if (instrumentType != InstrumentTypeEnum.All)
        {
            labelType.Visible = true;
            labelType.Text = "/ " + GetInstrumentTypeName(instrumentType);
        }
    }

    private void InstrumentForm_MouseLeave(object sender, EventArgs e)
    {

    }

    private void pictureButtonAdd_Click(object sender, EventArgs e)
    {
        mainForm.addInstrument_Click(sender, e);
    }

    private void pictureButtonExport_Click(object sender, EventArgs e)
    {
        try
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells["A1"].Value = "Наименование";
                worksheet.Cells["B1"].Value = "Тип инструмента";
                worksheet.Cells["C1"].Value = "ГОСТ";
                worksheet.Cells["D1"].Value = "Единицы измерения";
                worksheet.Cells["E1"].Value = "Цена";
                worksheet.Cells["F1"].Value = "Валюта";
                var count = 2;
                Instruments.ForEach(x =>
                {
                    worksheet.Cells["A" + count.ToString()].Value = x.Name;
                    worksheet.Cells["B" + count.ToString()].Value = x.InstrumentType.Name;
                    worksheet.Cells["C" + count.ToString()].Value = x.Gost.Name;
                    worksheet.Cells["D" + count.ToString()].Value = x.Measure;
                    worksheet.Cells["E" + count.ToString()].Value = x.Price;
                    worksheet.Cells["F" + count.ToString()].Value = x.Currency;
                    count++;
                });

                string currentDirectory = Directory.GetCurrentDirectory();
                var path = "instruments.xlsx";
                FileInfo excelFile = new FileInfo(path);
                package.SaveAs(excelFile);
                MessageBox.Show("Данные были экспортированы в " + currentDirectory, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Возникла ошибка при экспорте", "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
