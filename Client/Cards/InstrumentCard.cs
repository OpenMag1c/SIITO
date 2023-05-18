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
            labelCode.Text = Instrument.Code;
            labelGost.Text = Instrument.Gost.Name;
            labelPrice.Text = Instrument.Price.ToString();
            labelDimensions.Text = Instrument.Dimensions;
            textDescription.Text = Instrument.Description;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите удалить инструмент {Instrument.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                DeleteInstrument?.Invoke(this);
            }
        }
    }
}
