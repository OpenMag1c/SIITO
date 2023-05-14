using Domain.Entities;
using Domain.Enums;
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
        public InstrumentTypeEnum instrumentType { get; set; }

        public InstrumentForm(InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All)
        {
            InitializeComponent();
            SetPath(instrumentType);
        }

        public string getInstrumentTypeName(InstrumentTypeEnum instrumentType)
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
