using Client.Enums;
using Domain.Entities;
using Domain.Enums;

namespace Client.Cards
{
    public partial class OsnastkaCard : UserControl
    {
        public event Action<OsnastkaCard> OsnastkaDeleted;
        public event Action OsnastkaUpdated;

        public Osnastka Osnastka { get; set; }
        public string OsnastkaType { get; set; }

        public OsnastkaCard(Osnastka osnastka, string osnatkaType)
        {
            this.Osnastka = osnastka;
            this.OsnastkaType = osnatkaType;
            InitializeComponent();
        }

        private void OsnastkaCard_Load(object sender, EventArgs e)
        {
            if (Osnastka.Picture != null)
            {
                MemoryStream ms = new MemoryStream(Osnastka.Picture);
                Image imageData = Image.FromStream(ms);
                image.Image = imageData;
            }
            else
            {
                setOsnastkaImageDefault();
            }
            labelType.Text = OsnastkaType;
            labelName.Text = Osnastka.Name;
            labelName2.Text = Osnastka.Name;
            labelPrice.Text = Osnastka.Price.ToString() + "  " + Osnastka.Currency;
            textDescription.Text = Osnastka.Description;
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            description.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите удалить оснастку {Osnastka.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                OsnastkaDeleted?.Invoke(this);
            }
        }

        private void buttonDesc2_Click(object sender, EventArgs e)
        {
            description.Visible = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editOsnastkaForm = new EditOsnastkaForm(ActionType.Update, Osnastka.Id);
            editOsnastkaForm.Text = "Обновление оснастки";
            var result = editOsnastkaForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                OsnastkaUpdated?.Invoke();
            }
        }

        public void setOsnastkaImageDefault()
        {
            switch (Osnastka.OsnastkaType.Id)
            {
                case (int)OsnastkaTypeEnum.ModelOsnastka:
                    image.Image = Properties.Resources.model;
                    break;
                case (int)OsnastkaTypeEnum.PressFormi:
                    image.Image = Properties.Resources.pressform;
                    break;
                case (int)OsnastkaTypeEnum.Shtampi:
                    image.Image = Properties.Resources.shtamp;
                    break;
                case (int)OsnastkaTypeEnum.Prisposoblenie:
                    image.Image = Properties.Resources.prisposoblenya;
                    break;
            }
        }
    }
}
