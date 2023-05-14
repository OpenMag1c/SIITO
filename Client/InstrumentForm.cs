using Client.Cards;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Client;

public partial class InstrumentForm : Form
{
    private readonly AppDbContext context = new AppDbContext(Program.ContextOptions);

    private List<Instrument> Instruments;
    private readonly InstrumentTypeEnum InstrumentType;

    public InstrumentForm(InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All)
    {
        InstrumentType = instrumentType;
        InitializeComponent();
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
            instrumentsContainer.Controls.Add(new InstrumentCard(instrument));
        });
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
}
