using Domain.Enums;

namespace Client
{
    public partial class MainForm : Form
    {
        CatalogForm catalogForm;
        InstrumentForm instrumentForm;
        OsnastkaForm osnastkaForm;
        EditForm editForm;

        public MainForm()
        {
            InitializeComponent();
            catalogForm = new CatalogForm();
            catalogForm.FormClosed += CatalogForm_FormClosed;
            catalogForm.MdiParent = this;
            catalogForm.Dock = DockStyle.Fill;
            catalogForm.Show();
        }

        bool instrumentExpand = false;

        private void instrumentTransition_Tick(object sender, EventArgs e)
        {
            if (instrumentExpand == false)
            {
                instrumentContainer.Height += 10;
                if (instrumentContainer.Height >= 395)
                {
                    instrumentTransition.Stop();
                    instrumentExpand = true;
                }
            }
            else
            {
                instrumentContainer.Height -= 10;
                if (instrumentContainer.Height <= 43)
                {
                    instrumentTransition.Stop();
                    instrumentExpand = false;
                }
            }
        }

        private void buttonInstrument_Click(object sender, EventArgs e)
        {
            instrumentTransition.Start();
            if (osnasktaExpand)
            {
                osnastkaTransition.Start();
            }
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;
                if (sidebar.Width <= 0)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 20;
                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool osnasktaExpand = false;
        private void osnastkaTransition_Tick(object sender, EventArgs e)
        {
            if (osnasktaExpand == false)
            {
                osnastkaContainer.Height += 10;
                if (osnastkaContainer.Height >= 220)
                {
                    osnastkaTransition.Stop();
                    osnasktaExpand = true;
                }
            }
            else
            {
                osnastkaContainer.Height -= 10;
                if (osnastkaContainer.Height <= 43)
                {
                    osnastkaTransition.Stop();
                    osnasktaExpand = false;
                }
            }
        }

        private void buttonOsnastka_Click(object sender, EventArgs e)
        {
            osnastkaTransition.Start();
            if (instrumentExpand)
            {
                instrumentTransition.Start();
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            if (catalogForm == null)
            {
                catalogForm = new CatalogForm();
                catalogForm.FormClosed += CatalogForm_FormClosed;
                catalogForm.MdiParent = this;
                catalogForm.Dock = DockStyle.Fill;
                catalogForm.Show();
            }
            else
            {
                catalogForm.Activate();
            }
        }

        private void CatalogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            catalogForm = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (editForm == null)
            {
                editForm = new EditForm();
                editForm.FormClosed += EditForm_FormClosed;
                editForm.MdiParent = this;
                editForm.Dock = DockStyle.Fill;
                editForm.Show();
            }
            else
            {
                editForm.Activate();
            }
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            editForm = null;
        }

        public void OpenInstrumentForm(InstrumentTypeEnum instrumentType)
        {
            if (instrumentForm == null)
            {
                instrumentForm = new InstrumentForm(instrumentType);
                instrumentForm.FormClosed += InstrumentForm_FormClosed;
                instrumentForm.MdiParent = this;
                instrumentForm.Dock = DockStyle.Fill;
                instrumentForm.Show();
            }
            else
            {
                instrumentForm.Activate();
            }
        }

        private void InstrumentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instrumentForm = null;
        }

        private void buttonRezec_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.Rezci);
        }
    }
}