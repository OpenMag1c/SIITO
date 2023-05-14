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
    public partial class OsnastkaForm : Form
    {
        public OsnastkaTypeEnum osnastkaType { get; set; }
        public OsnastkaForm(OsnastkaTypeEnum osnastkaType)
        {
            InitializeComponent();
            SetPath(osnastkaType);
        }

        private void OsnastkaForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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

        public void SetPath(OsnastkaTypeEnum osnastkaType)
        {
            this.osnastkaType = osnastkaType;
            if (osnastkaType != OsnastkaTypeEnum.All)
            {
                labelType.Visible = true;
                labelType.Text = "/ " + getOsnastkaTypeName(osnastkaType);
            }
        }
    }
}
