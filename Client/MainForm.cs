using Domain.Enums;

namespace Client;

public enum Pages
{
    Home,
    Catalog,
    Instrument,
    Osnastka
}

public partial class MainForm : Form
{
    HomeForm homeForm;
    CatalogForm catalogForm;
    InstrumentForm instrumentForm;
    OsnastkaForm osnastkaForm;
    EditInstrumentForm editInstrumentForm;
    EditOsnastkaForm editOsnastkaForm;

    public MainForm()
    {
        InitializeComponent();
        homeForm = new HomeForm();
        setActivePage(Pages.Home);
        homeForm.FormClosed += HomeForm_FormClosed;
        homeForm.MdiParent = this;
        homeForm.Dock = DockStyle.Fill;
        homeForm.Show();
    }

    bool instrumentExpand = false;

    private void instrumentTransition_Tick(object sender, EventArgs e)
    {
        if (instrumentExpand == false)
        {
            instrumentContainer.Height += 10;
            if (instrumentContainer.Height >= 402)
            {
                instrumentTransition.Stop();
                instrumentExpand = true;
            }
        }
        else
        {
            instrumentContainer.Height -= 10;
            if (instrumentContainer.Height <= 50)
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
            if (osnastkaContainer.Height >= 227)
            {
                osnastkaTransition.Stop();
                osnasktaExpand = true;
            }
        }
        else
        {
            osnastkaContainer.Height -= 10;
            if (osnastkaContainer.Height <= 50)
            {
                osnastkaTransition.Stop();
                osnasktaExpand = false;
            }
        }
    }

    public void OpenOsnastkaForm(OsnastkaTypeEnum osnastkaType)
    {
        osnastkaForm = new OsnastkaForm(osnastkaType, this);
        setActivePage(Pages.Osnastka);
        osnastkaForm.FormClosed += OsnastkaFormOnClosed;
        osnastkaForm.MdiParent = this;
        osnastkaForm.Dock = DockStyle.Fill;
        osnastkaForm.Show();

        void OsnastkaFormOnClosed(object sender, FormClosedEventArgs e)
        {
            catalogForm = null;
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
        setActivePage(Pages.Catalog);
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

    private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        homeForm = null;
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
        instrumentForm = new InstrumentForm(instrumentType, this);
        instrumentForm.FormClosed += InstrumentFormOnClosed;
        setActivePage(Pages.Instrument);
        instrumentForm.MdiParent = this;
        instrumentForm.Dock = DockStyle.Fill;
        instrumentForm.Show();


        void InstrumentFormOnClosed(object sender, FormClosedEventArgs e)
        {
            instrumentForm = null;
        }
    }

    private void buttonRezec_Click(object sender, EventArgs e)
    {
        OpenInstrumentForm(InstrumentTypeEnum.Rezci);
    }

    public void addOsnastka_Click(object sender, EventArgs e)
    {
        editOsnastkaForm = new EditOsnastkaForm(Enums.ActionType.Create);
        editOsnastkaForm.FormClosed += EditOsnastkaFormOnClosed;
        editOsnastkaForm.MdiParent = this;
        editOsnastkaForm.Dock = DockStyle.Fill;
        editOsnastkaForm.Show();

        void EditOsnastkaFormOnClosed(object sender, FormClosedEventArgs e)
        {
            editOsnastkaForm = null;
            OpenOsnastkaForm(OsnastkaTypeEnum.All);
        }
    }

    public void addInstrument_Click(object sender, EventArgs e)
    {
        editInstrumentForm = new EditInstrumentForm(Enums.ActionType.Create);
        editInstrumentForm.FormClosed += EditInstrumentFormOnClosed;
        editInstrumentForm.MdiParent = this;
        editInstrumentForm.Dock = DockStyle.Fill;
        editInstrumentForm.Show();

        void EditInstrumentFormOnClosed(object sender, FormClosedEventArgs e)
        {
            editInstrumentForm = null;
            OpenInstrumentForm(InstrumentTypeEnum.All);
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

    private void buttonHome_Click(object sender, EventArgs e)
    {
        setActivePage(Pages.Home);
        if (homeForm == null)
        {
            homeForm = new HomeForm();
            homeForm.FormClosed += HomeForm_FormClosed;
            homeForm.MdiParent = this;
            homeForm.Dock = DockStyle.Fill;
            homeForm.Show();
        }
        else
        {
            homeForm.Activate();
        }
    }

    public void setActivePage(Pages page)
    {
        var redActive = 173;
        var greenActive = 11;
        var blueActive = 34;
        var red = 229;
        var green = 9;
        var blue = 40;
        buttonHome.BackColor = Color.FromArgb(red, green, blue);
        buttonInstrument.BackColor = Color.FromArgb(red, green, blue);
        buttonOsnastka.BackColor = Color.FromArgb(red, green, blue);
        buttonÑatalog.BackColor = Color.FromArgb(red, green, blue);

        switch (page)
        {
            case Pages.Home:
                buttonHome.BackColor = Color.FromArgb(redActive, greenActive, blueActive);
                break;
            case Pages.Catalog:
                buttonÑatalog.BackColor = Color.FromArgb(redActive, greenActive, blueActive);
                break;
            case Pages.Instrument:
                buttonInstrument.BackColor = Color.FromArgb(redActive, greenActive, blueActive);
                break;
            case Pages.Osnastka:
                buttonOsnastka.BackColor = Color.FromArgb(redActive, greenActive, blueActive);
                break;
            default:
                break;
        }
    }
}