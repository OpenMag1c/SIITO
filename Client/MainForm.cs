using Domain.Enums;

namespace Client
{
    public partial class MainForm : Form
    {
        CatalogForm catalogForm;
        InstrumentForm instrumentForm;
        OsnastkaForm osnastkaForm;
        EditInstrumentForm editInstrumentForm;

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

        private void addOsnastka_Click(object sender, EventArgs e)
        {

        }

        private void addInstrument_Click(object sender, EventArgs e)
        {
            if (editInstrumentForm == null)
            {
                editInstrumentForm = new EditInstrumentForm(Enums.ActionType.Create);
                editInstrumentForm.FormClosed += EditInstrumentForm_FormClosed;
                editInstrumentForm.MdiParent = this;
                editInstrumentForm.Dock = DockStyle.Fill;
                editInstrumentForm.Show();
            }
            else
            {
                editInstrumentForm.Activate();
            }
        }

        private void EditInstrumentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            editInstrumentForm = null;
            OpenInstrumentForm(InstrumentTypeEnum.All);
        }
    }
}