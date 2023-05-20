using Domain.Entities;
using Domain.Enums;

namespace Client.Cards
{
    public partial class InstrumentCard : UserControl
    {

        public event Action<InstrumentCard> DeleteInstrument;
        public Instrument Instrument { get; set; }
        public InstrumentTypeEnum InstrumentType { get; set; }

        public InstrumentCard(Instrument instrument, InstrumentTypeEnum instrumentType = InstrumentTypeEnum.All)
        {
            this.Instrument = instrument;
            this.InstrumentType = instrumentType;
            InitializeComponent();
        }

        private void InstrumentCard_Load(object sender, EventArgs e)
        {
            if (Instrument.Picture != null)
            {
                MemoryStream ms = new MemoryStream(Instrument.Picture);
                Image imageData = Image.FromStream(ms);
                image.Image = imageData;
            }
            labelType.Text = InstrumentForm.GetInstrumentTypeName(InstrumentType);
            labelName.Text = Instrument.Name;
            labelName2.Text = Instrument.Name;
            labelCode.Text = Instrument.Code;
            linkTextGost.Text = Instrument.Gost.Name;
            labelPrice.Text = Instrument.Price.ToString();
            labelDimensions.Text = Instrument.Dimensions;
            textDescription.Text = Instrument.Description;
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            description.Visible = true;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите удалить инструмент {Instrument.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                DeleteInstrument?.Invoke(this);
            }
        }

        private void linkTextGost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = Instrument.Gost.Link;
            try
            {
                System.Diagnostics.Process.Start("cmd", "/c start " + url);
                //System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии ссылки: " + ex.Message);
            }
        }

        private void buttonDesc2_Click(object sender, EventArgs e)
        {
            description.Visible = false;
            buttonEdit.Visible = true;
            buttonDelete.Visible = true;
        }
    }
}
