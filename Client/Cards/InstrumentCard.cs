using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Cards
{
    public partial class InstrumentCard : UserControl
    {
        Instrument instrument { get; set; }
        public InstrumentCard(Instrument instrument)
        {
            this.instrument = instrument;
            InitializeComponent();
        }

        private void InstrumentCard_Load(object sender, EventArgs e)
        {
            if (instrument.Picture != null)
            {
                MemoryStream ms = new MemoryStream(instrument.Picture);
                Image imageData = Image.FromStream(ms);
                image.Image = imageData;
            }
            labelName.Text = instrument.Name;
            labelCode.Text = instrument.Code;
            labelGost.Text = instrument.Gost.Name;
            labelPrice.Text = instrument.Price.ToString();
            labelDimensions.Text = instrument.Dimensions;
        }
    }
}
