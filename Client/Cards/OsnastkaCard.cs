using Domain.Entities;

namespace Client.Cards
{
    public partial class OsnastkaCard : UserControl
    {
        public event Action<OsnastkaCard> DeleteOsnastka;
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
            labelType.Text = OsnastkaType;
            labelName.Text = Osnastka.Name;
            textDescription.Text = Osnastka.Description;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите удалить оснастку {Osnastka.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                DeleteOsnastka?.Invoke(this);
            }
        }
    }
}
