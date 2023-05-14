namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                if (instrumentContainer.Height <= 43)
                {
                    osnastkaTransition.Stop();
                    osnasktaExpand = false;
                }
            }
        }

        private void buttonOsnastka_Click(object sender, EventArgs e)
        {
            osnastkaTransition.Start();
        }
    }
}