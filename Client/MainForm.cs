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
            catalogForm = new CatalogForm(this);
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
            if (addExpanded)
            {
                addTransition.Start();
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

        public void OpenOsnastkaForm(OsnastkaTypeEnum osnastkaType)
        {
            if (osnastkaForm == null)
            {
                osnastkaForm = new OsnastkaForm(osnastkaType);
                osnastkaForm.FormClosed += OsnastkaForm_FormClosed;
                osnastkaForm.MdiParent = this;
                osnastkaForm.Dock = DockStyle.Fill;
                osnastkaForm.Show();
            }
            else
            {
                osnastkaForm.SetPath(osnastkaType);
                osnastkaForm.Activate();
            }
        }

        private void OsnastkaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            catalogForm = null;
        }

        private void buttonOsnastka_Click(object sender, EventArgs e)
        {
            osnastkaTransition.Start();
            if (instrumentExpand)
            {
                instrumentTransition.Start();
            }
            if (addExpanded)
            {
                addTransition.Start();
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            if (catalogForm == null)
            {
                catalogForm = new CatalogForm(this);
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

        bool addExpanded = false;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addTransition.Start();
            if (instrumentExpand)
            {
                instrumentTransition.Start();
            }
            if (osnasktaExpand)
            {
                osnastkaTransition.Start();
            }
        }

        private void OpenEditForm()
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
                instrumentForm.SetPath(instrumentType);
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

        private void addTransition_Tick(object sender, EventArgs e)
        {
            if (addExpanded == false)
            {
                addContainer.Height += 10;
                if (addContainer.Height >= 135)
                {
                    addTransition.Stop();
                    addExpanded = true;
                }
            }
            else
            {
                addContainer.Height -= 10;
                if (addContainer.Height <= 43)
                {
                    addTransition.Stop();
                    addExpanded = false;
                }
            }
        }

        private void buttonProtyajki_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.Protyazhki);
        }

        private void buttonFreza_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.Frezi);
        }

        private void buttonRoliki_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.RolikiRezb);
        }

        private void buttonZenkeri_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.Zenkeri);
        }

        private void buttonMetchiki_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.Metchiki);
        }

        private void buttonRazvertki_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.Razvertki);
        }

        private void buttonMechanical_Click(object sender, EventArgs e)
        {
            OpenInstrumentForm(InstrumentTypeEnum.InstrumentMechKreplenie);
        }

        private void buttonStampi_Click(object sender, EventArgs e)
        {
            OpenOsnastkaForm(OsnastkaTypeEnum.Shtampi);
        }

        private void buttonPressFormi_Click(object sender, EventArgs e)
        {
            OpenOsnastkaForm(OsnastkaTypeEnum.PressFormi);
        }

        private void buttonModel_Click(object sender, EventArgs e)
        {
            OpenOsnastkaForm(OsnastkaTypeEnum.ModelOsnastka);
        }

        private void buttonPrisposobleniya_Click(object sender, EventArgs e)
        {
            OpenOsnastkaForm(OsnastkaTypeEnum.Prisposoblenie);
        }
    }
}