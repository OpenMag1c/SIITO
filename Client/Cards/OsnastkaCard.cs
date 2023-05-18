using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Cards
{
    public partial class OsnastkaCard : UserControl
    {
        Osnastka osnastka { get; set; }
        string OsnastkaType { get; set; }
        public OsnastkaCard(Osnastka osnastka, string osnatkaType)
        {
            this.osnastka = osnastka;
            this.OsnastkaType = osnatkaType;
            InitializeComponent();
        }

        private void OsnastkaCard_Load(object sender, EventArgs e)
        {
            if (osnastka.Picture != null)
            {
                MemoryStream ms = new MemoryStream(osnastka.Picture);
                Image imageData = Image.FromStream(ms);
                image.Image = imageData;
            }
            labelType.Text = OsnastkaType;
            labelName.Text = osnastka.Name;
            textDescription.Text = osnastka.Description;
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            if (description.Visible == true)
            {
                description.Visible = false;
            }
            else
            {
                description.Visible = true;
            }
        }
    }
}
