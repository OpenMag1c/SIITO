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
        InstrumentTypeEnum instrumentType;
        public InstrumentForm(InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All)
        {
            InitializeComponent();
            this.instrumentType = instrumentType;
            if (instrumentType != InstrumentTypeEnum.All)
            {
                labelType.Visible = true;
                labelType.Text = "/ " + instrumentType.ToString();
            }
        }

        private void InstrumentForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
