using Domain.Entities;
using Domain.Enums;

namespace Client.Cards
{
    public partial class InstrumentCard : UserControl
    {

        public event Action<InstrumentCard> InstrumentDeleted;
        public event Action InstumentUpdated;
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
            else
            {
                setInstrumentImageDefault();
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
                InstrumentDeleted?.Invoke(this);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editInstrumentForm = new EditInstrumentForm(Enums.ActionType.Update, Instrument.Id);
            editInstrumentForm.Text = "Обновление инструмента";
            var result = editInstrumentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                InstumentUpdated?.Invoke();
            }
        }

        public void setInstrumentImageDefault()
        {
            switch (InstrumentType)
            {
                case InstrumentTypeEnum.Rezci:
                    image.Image = Properties.Resources.rezec;
                    break;
                case InstrumentTypeEnum.Razvertki:
                    image.Image = Properties.Resources.razvertki;
                    break;
                case InstrumentTypeEnum.RolikiRezb:
                    image.Image = Properties.Resources.roliki;
                    break;
                case InstrumentTypeEnum.Metchiki:
                    image.Image = Properties.Resources.metchiki;
                    break;
                case InstrumentTypeEnum.Frezi:
                    image.Image = Properties.Resources.frezi;
                    break;
                case InstrumentTypeEnum.InstrumentMechKreplenie:
                    image.Image = Properties.Resources.mechkrepl;
                    break;
                case InstrumentTypeEnum.Zenkeri:
                    image.Image = Properties.Resources.zenkeri;
                    break;
            }
        }
    }
}
