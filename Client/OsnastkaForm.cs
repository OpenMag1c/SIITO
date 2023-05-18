using Client.Cards;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Client;

public partial class OsnastkaForm : Form
{
    private readonly AppDbContext context = new AppDbContext(Program.ContextOptions);

    private List<Osnastka> Osnastkas;
    private readonly OsnastkaTypeEnum OsnastkaType;

    public OsnastkaForm(OsnastkaTypeEnum osnastkaType)
    {
        OsnastkaType = osnastkaType;
        InitializeComponent();
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
            osnastkaContainer.Controls.Add(new OsnastkaCard(osnastka, getOsnastkaTypeName(OsnastkaType)));
        });
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
}
