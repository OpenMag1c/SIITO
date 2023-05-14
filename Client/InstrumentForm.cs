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
        public InstrumentForm()
        {
            InitializeComponent();
        }

        private void InstrumentForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
