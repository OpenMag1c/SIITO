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

namespace Client.Cards
{
    public partial class InstrumentCard : UserControl
    {
        Instrument instrument { get; set; }
        private InstrumentTypeEnum InstrumentType { get; set; }
        public InstrumentCard(Instrument instrument, InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All)
        {
            this.instrument = instrument;
            this.InstrumentType = instrumentType;
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
            labelType.Text = InstrumentForm.GetInstrumentTypeName(InstrumentType);
            labelName.Text = instrument.Name;
            labelCode.Text = instrument.Code;
            labelGost.Text = instrument.Gost.Name;
            labelPrice.Text = instrument.Price.ToString();
            labelDimensions.Text = instrument.Dimensions;
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            if (description.Visible == true)
            {
                description.Visible = false;
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                description.Visible = true;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }
        }

    }
}
