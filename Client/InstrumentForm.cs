using Client.Cards;
using DAL;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class InstrumentForm : Form
    {
        List<Instrument> instruments;
        private readonly AppDbContext context = new AppDbContext(Program.ContextOptions);
        public InstrumentTypeEnum instrumentType { get; set; }

        public InstrumentForm(InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All)
        {
            InitializeComponent();
            GetInstruments(instrumentType);
            SetPath(instrumentType);
        }

        public static string getInstrumentTypeName(InstrumentTypeEnum instrumentType)
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
            PopulateInstruments();
        }

        private void PopulateInstruments()
        {
            instruments.ForEach(instr =>
            {
                instrumentsContainer.Controls.Add(new InstrumentCard(instr));
            });
        }

        private void GetInstruments(InstrumentTypeEnum instrumentType)
        {
            var data = context.Instruments.Include(x => x.InstrumentType).Include(x => x.Gost);
            if (instrumentType == InstrumentTypeEnum.All)
            {
                this.instruments = data.ToList();
            }
            else
            {
                this.instruments = data.Where(x => x.InstrumentType.Id == (int)instrumentType).ToList();
            }
        }

        public void SetPath(InstrumentTypeEnum instrumentType)
        {
            this.instrumentType = instrumentType;
            if (instrumentType != InstrumentTypeEnum.All)
            {
                labelType.Visible = true;
                labelType.Text = "/ " + getInstrumentTypeName(instrumentType);
            }
        }
    }
}
