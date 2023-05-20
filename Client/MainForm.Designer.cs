namespace Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            buttonMenu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel17 = new Panel();
            buttonHome = new Button();
            panel2 = new Panel();
            buttonСatalog = new Button();
            instrumentContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            buttonInstrument = new Button();
            panel3 = new Panel();
            buttonRezec = new Button();
            panel4 = new Panel();
            buttonProtyajki = new Button();
            panel5 = new Panel();
            buttonFreza = new Button();
            panel7 = new Panel();
            buttonRoliki = new Button();
            panel8 = new Panel();
            buttonZenkeri = new Button();
            panel9 = new Panel();
            buttonMetchiki = new Button();
            panel10 = new Panel();
            buttonRazvertki = new Button();
            panel11 = new Panel();
            buttonMechanical = new Button();
            osnastkaContainer = new FlowLayoutPanel();
            panel12 = new Panel();
            buttonOsnastka = new Button();
            panel13 = new Panel();
            buttonStampi = new Button();
            panel14 = new Panel();
            buttonPressFormi = new Button();
            panel15 = new Panel();
            buttonModel = new Button();
            panel16 = new Panel();
            buttonPrisposobleniya = new Button();
            addContainer = new FlowLayoutPanel();
            panel18 = new Panel();
            buttonAdd = new Button();
            panel19 = new Panel();
            addOsnastka = new Button();
            panel20 = new Panel();
            addInstrument = new Button();
            instrumentTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            osnastkaTransition = new System.Windows.Forms.Timer(components);
            addTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            sidebar.SuspendLayout();
            panel17.SuspendLayout();
            panel2.SuspendLayout();
            instrumentContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            osnastkaContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            addContainer.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 9, 40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(buttonMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 34);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(48, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(812, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // buttonMenu
            // 
            buttonMenu.Image = (Image)resources.GetObject("buttonMenu.Image");
            buttonMenu.Location = new Point(12, 1);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(30, 30);
            buttonMenu.SizeMode = PictureBoxSizeMode.Zoom;
            buttonMenu.TabIndex = 1;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(229, 9, 40);
            sidebar.Controls.Add(panel17);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(instrumentContainer);
            sidebar.Controls.Add(osnastkaContainer);
            sidebar.Controls.Add(addContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 34);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 5, 0, 0);
            sidebar.Size = new Size(200, 569);
            sidebar.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.BorderStyle = BorderStyle.FixedSingle;
            panel17.Controls.Add(buttonHome);
            panel17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel17.Location = new Point(3, 5);
            panel17.Margin = new Padding(3, 0, 0, 5);
            panel17.Name = "panel17";
            panel17.Size = new Size(200, 50);
            panel17.TabIndex = 9;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(229, 9, 40);
            buttonHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.White;
            buttonHome.Location = new Point(-36, -27);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(50, 0, 0, 0);
            buttonHome.Size = new Size(248, 95);
            buttonHome.TabIndex = 2;
            buttonHome.Text = "Главная";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonСatalog);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 60);
            panel2.Margin = new Padding(3, 0, 0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 50);
            panel2.TabIndex = 8;
            // 
            // buttonСatalog
            // 
            buttonСatalog.BackColor = Color.FromArgb(229, 9, 40);
            buttonСatalog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonСatalog.ForeColor = Color.White;
            buttonСatalog.Location = new Point(-36, -27);
            buttonСatalog.Name = "buttonСatalog";
            buttonСatalog.Padding = new Padding(50, 0, 0, 0);
            buttonСatalog.Size = new Size(248, 95);
            buttonСatalog.TabIndex = 2;
            buttonСatalog.Text = "Каталог";
            buttonСatalog.TextAlign = ContentAlignment.MiddleLeft;
            buttonСatalog.UseVisualStyleBackColor = false;
            buttonСatalog.Click += buttonCatalog_Click;
            // 
            // instrumentContainer
            // 
            instrumentContainer.BackColor = Color.FromArgb(229, 9, 40);
            instrumentContainer.BorderStyle = BorderStyle.FixedSingle;
            instrumentContainer.Controls.Add(panel6);
            instrumentContainer.Controls.Add(panel3);
            instrumentContainer.Controls.Add(panel4);
            instrumentContainer.Controls.Add(panel5);
            instrumentContainer.Controls.Add(panel7);
            instrumentContainer.Controls.Add(panel8);
            instrumentContainer.Controls.Add(panel9);
            instrumentContainer.Controls.Add(panel10);
            instrumentContainer.Controls.Add(panel11);
            instrumentContainer.Location = new Point(3, 115);
            instrumentContainer.Name = "instrumentContainer";
            instrumentContainer.Size = new Size(198, 50);
            instrumentContainer.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonInstrument);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 43);
            panel6.TabIndex = 5;
            // 
            // buttonInstrument
            // 
            buttonInstrument.BackColor = Color.FromArgb(229, 9, 40);
            buttonInstrument.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInstrument.ForeColor = Color.White;
            buttonInstrument.Location = new Point(-36, -27);
            buttonInstrument.Name = "buttonInstrument";
            buttonInstrument.Padding = new Padding(50, 0, 0, 0);
            buttonInstrument.Size = new Size(248, 95);
            buttonInstrument.TabIndex = 2;
            buttonInstrument.Text = "Инструмент";
            buttonInstrument.TextAlign = ContentAlignment.MiddleLeft;
            buttonInstrument.UseVisualStyleBackColor = false;
            buttonInstrument.Click += buttonInstrument_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonRezec);
            panel3.Location = new Point(0, 43);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 43);
            panel3.TabIndex = 6;
            // 
            // buttonRezec
            // 
            buttonRezec.BackColor = Color.FromArgb(229, 9, 40);
            buttonRezec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRezec.ForeColor = Color.White;
            buttonRezec.Image = (Image)resources.GetObject("buttonRezec.Image");
            buttonRezec.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRezec.Location = new Point(-32, -26);
            buttonRezec.Name = "buttonRezec";
            buttonRezec.Padding = new Padding(50, 0, 0, 0);
            buttonRezec.Size = new Size(248, 95);
            buttonRezec.TabIndex = 2;
            buttonRezec.Text = "Резцы";
            buttonRezec.TextAlign = ContentAlignment.MiddleLeft;
            buttonRezec.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRezec.UseVisualStyleBackColor = false;
            buttonRezec.Click += buttonRezec_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonProtyajki);
            panel4.Location = new Point(0, 86);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 43);
            panel4.TabIndex = 7;
            // 
            // buttonProtyajki
            // 
            buttonProtyajki.BackColor = Color.FromArgb(229, 9, 40);
            buttonProtyajki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProtyajki.ForeColor = Color.White;
            buttonProtyajki.Image = (Image)resources.GetObject("buttonProtyajki.Image");
            buttonProtyajki.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProtyajki.Location = new Point(-32, -26);
            buttonProtyajki.Name = "buttonProtyajki";
            buttonProtyajki.Padding = new Padding(50, 0, 0, 0);
            buttonProtyajki.Size = new Size(248, 95);
            buttonProtyajki.TabIndex = 2;
            buttonProtyajki.Text = "Протяжки";
            buttonProtyajki.TextAlign = ContentAlignment.MiddleLeft;
            buttonProtyajki.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProtyajki.UseVisualStyleBackColor = false;
            buttonProtyajki.Click += buttonProtyajki_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonFreza);
            panel5.Location = new Point(0, 129);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 43);
            panel5.TabIndex = 8;
            // 
            // buttonFreza
            // 
            buttonFreza.BackColor = Color.FromArgb(229, 9, 40);
            buttonFreza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFreza.ForeColor = Color.White;
            buttonFreza.Image = (Image)resources.GetObject("buttonFreza.Image");
            buttonFreza.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFreza.Location = new Point(-32, -26);
            buttonFreza.Name = "buttonFreza";
            buttonFreza.Padding = new Padding(50, 0, 0, 0);
            buttonFreza.Size = new Size(248, 95);
            buttonFreza.TabIndex = 2;
            buttonFreza.Text = "Фрезы";
            buttonFreza.TextAlign = ContentAlignment.MiddleLeft;
            buttonFreza.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFreza.UseVisualStyleBackColor = false;
            buttonFreza.Click += buttonFreza_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonRoliki);
            panel7.Location = new Point(0, 172);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(190, 43);
            panel7.TabIndex = 9;
            // 
            // buttonRoliki
            // 
            buttonRoliki.BackColor = Color.FromArgb(229, 9, 40);
            buttonRoliki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRoliki.ForeColor = Color.White;
            buttonRoliki.Image = (Image)resources.GetObject("buttonRoliki.Image");
            buttonRoliki.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRoliki.Location = new Point(-32, -26);
            buttonRoliki.Name = "buttonRoliki";
            buttonRoliki.Padding = new Padding(50, 0, 0, 0);
            buttonRoliki.Size = new Size(248, 95);
            buttonRoliki.TabIndex = 2;
            buttonRoliki.Text = "Ролики резьбонакатные";
            buttonRoliki.TextAlign = ContentAlignment.MiddleLeft;
            buttonRoliki.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoliki.UseVisualStyleBackColor = false;
            buttonRoliki.Click += buttonRoliki_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(buttonZenkeri);
            panel8.Location = new Point(0, 215);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(190, 43);
            panel8.TabIndex = 10;
            // 
            // buttonZenkeri
            // 
            buttonZenkeri.BackColor = Color.FromArgb(229, 9, 40);
            buttonZenkeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZenkeri.ForeColor = Color.White;
            buttonZenkeri.Image = (Image)resources.GetObject("buttonZenkeri.Image");
            buttonZenkeri.ImageAlign = ContentAlignment.MiddleLeft;
            buttonZenkeri.Location = new Point(-32, -26);
            buttonZenkeri.Name = "buttonZenkeri";
            buttonZenkeri.Padding = new Padding(50, 0, 0, 0);
            buttonZenkeri.Size = new Size(248, 95);
            buttonZenkeri.TabIndex = 2;
            buttonZenkeri.Text = "Зенкеры";
            buttonZenkeri.TextAlign = ContentAlignment.MiddleLeft;
            buttonZenkeri.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonZenkeri.UseVisualStyleBackColor = false;
            buttonZenkeri.Click += buttonZenkeri_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(buttonMetchiki);
            panel9.Location = new Point(0, 258);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(190, 43);
            panel9.TabIndex = 11;
            // 
            // buttonMetchiki
            // 
            buttonMetchiki.BackColor = Color.FromArgb(229, 9, 40);
            buttonMetchiki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMetchiki.ForeColor = Color.White;
            buttonMetchiki.Image = (Image)resources.GetObject("buttonMetchiki.Image");
            buttonMetchiki.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMetchiki.Location = new Point(-32, -26);
            buttonMetchiki.Name = "buttonMetchiki";
            buttonMetchiki.Padding = new Padding(50, 0, 0, 0);
            buttonMetchiki.Size = new Size(248, 95);
            buttonMetchiki.TabIndex = 2;
            buttonMetchiki.Text = "Метчики";
            buttonMetchiki.TextAlign = ContentAlignment.MiddleLeft;
            buttonMetchiki.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMetchiki.UseVisualStyleBackColor = false;
            buttonMetchiki.Click += buttonMetchiki_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(buttonRazvertki);
            panel10.Location = new Point(0, 301);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(190, 43);
            panel10.TabIndex = 12;
            // 
            // buttonRazvertki
            // 
            buttonRazvertki.BackColor = Color.FromArgb(229, 9, 40);
            buttonRazvertki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRazvertki.ForeColor = Color.White;
            buttonRazvertki.Image = (Image)resources.GetObject("buttonRazvertki.Image");
            buttonRazvertki.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRazvertki.Location = new Point(-32, -26);
            buttonRazvertki.Name = "buttonRazvertki";
            buttonRazvertki.Padding = new Padding(50, 0, 0, 0);
            buttonRazvertki.Size = new Size(248, 95);
            buttonRazvertki.TabIndex = 2;
            buttonRazvertki.Text = "Развертки";
            buttonRazvertki.TextAlign = ContentAlignment.MiddleLeft;
            buttonRazvertki.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRazvertki.UseVisualStyleBackColor = false;
            buttonRazvertki.Click += buttonRazvertki_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(buttonMechanical);
            panel11.Location = new Point(0, 344);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(190, 43);
            panel11.TabIndex = 13;
            // 
            // buttonMechanical
            // 
            buttonMechanical.BackColor = Color.FromArgb(229, 9, 40);
            buttonMechanical.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMechanical.ForeColor = Color.White;
            buttonMechanical.Image = (Image)resources.GetObject("buttonMechanical.Image");
            buttonMechanical.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMechanical.Location = new Point(-32, -26);
            buttonMechanical.Name = "buttonMechanical";
            buttonMechanical.Padding = new Padding(50, 0, 0, 0);
            buttonMechanical.Size = new Size(248, 95);
            buttonMechanical.TabIndex = 2;
            buttonMechanical.Text = "Инструмент с\r\nмеханическим\r\nкреплением\r\n";
            buttonMechanical.TextAlign = ContentAlignment.MiddleLeft;
            buttonMechanical.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMechanical.UseVisualStyleBackColor = false;
            buttonMechanical.Click += buttonMechanical_Click;
            // 
            // osnastkaContainer
            // 
            osnastkaContainer.BackColor = Color.FromArgb(229, 9, 40);
            osnastkaContainer.BorderStyle = BorderStyle.FixedSingle;
            osnastkaContainer.Controls.Add(panel12);
            osnastkaContainer.Controls.Add(panel13);
            osnastkaContainer.Controls.Add(panel14);
            osnastkaContainer.Controls.Add(panel15);
            osnastkaContainer.Controls.Add(panel16);
            osnastkaContainer.Location = new Point(3, 171);
            osnastkaContainer.Name = "osnastkaContainer";
            osnastkaContainer.Size = new Size(198, 50);
            osnastkaContainer.TabIndex = 9;
            // 
            // panel12
            // 
            panel12.Controls.Add(buttonOsnastka);
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(190, 43);
            panel12.TabIndex = 5;
            // 
            // buttonOsnastka
            // 
            buttonOsnastka.BackColor = Color.FromArgb(229, 9, 40);
            buttonOsnastka.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOsnastka.ForeColor = Color.White;
            buttonOsnastka.Location = new Point(-36, -27);
            buttonOsnastka.Name = "buttonOsnastka";
            buttonOsnastka.Padding = new Padding(50, 0, 0, 0);
            buttonOsnastka.Size = new Size(248, 95);
            buttonOsnastka.TabIndex = 2;
            buttonOsnastka.Text = "Оснастка";
            buttonOsnastka.TextAlign = ContentAlignment.MiddleLeft;
            buttonOsnastka.UseVisualStyleBackColor = false;
            buttonOsnastka.Click += buttonOsnastka_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(buttonStampi);
            panel13.Location = new Point(0, 43);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(190, 43);
            panel13.TabIndex = 6;
            // 
            // buttonStampi
            // 
            buttonStampi.BackColor = Color.FromArgb(229, 9, 40);
            buttonStampi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStampi.ForeColor = Color.White;
            buttonStampi.Image = (Image)resources.GetObject("buttonStampi.Image");
            buttonStampi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStampi.Location = new Point(-32, -26);
            buttonStampi.Name = "buttonStampi";
            buttonStampi.Padding = new Padding(50, 0, 0, 0);
            buttonStampi.Size = new Size(248, 95);
            buttonStampi.TabIndex = 2;
            buttonStampi.Text = "Штампы";
            buttonStampi.TextAlign = ContentAlignment.MiddleLeft;
            buttonStampi.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonStampi.UseVisualStyleBackColor = false;
            buttonStampi.Click += buttonStampi_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(buttonPressFormi);
            panel14.Location = new Point(0, 86);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(190, 43);
            panel14.TabIndex = 7;
            // 
            // buttonPressFormi
            // 
            buttonPressFormi.BackColor = Color.FromArgb(229, 9, 40);
            buttonPressFormi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPressFormi.ForeColor = Color.White;
            buttonPressFormi.Image = (Image)resources.GetObject("buttonPressFormi.Image");
            buttonPressFormi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPressFormi.Location = new Point(-32, -26);
            buttonPressFormi.Name = "buttonPressFormi";
            buttonPressFormi.Padding = new Padding(50, 0, 0, 0);
            buttonPressFormi.Size = new Size(248, 95);
            buttonPressFormi.TabIndex = 2;
            buttonPressFormi.Text = "Пресс-формы";
            buttonPressFormi.TextAlign = ContentAlignment.MiddleLeft;
            buttonPressFormi.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPressFormi.UseVisualStyleBackColor = false;
            buttonPressFormi.Click += buttonPressFormi_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(buttonModel);
            panel15.Location = new Point(0, 129);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(190, 43);
            panel15.TabIndex = 8;
            // 
            // buttonModel
            // 
            buttonModel.BackColor = Color.FromArgb(229, 9, 40);
            buttonModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModel.ForeColor = Color.White;
            buttonModel.Image = (Image)resources.GetObject("buttonModel.Image");
            buttonModel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModel.Location = new Point(-32, -26);
            buttonModel.Name = "buttonModel";
            buttonModel.Padding = new Padding(50, 0, 0, 0);
            buttonModel.Size = new Size(248, 95);
            buttonModel.TabIndex = 2;
            buttonModel.Text = "Модельная оснастка";
            buttonModel.TextAlign = ContentAlignment.MiddleLeft;
            buttonModel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonModel.UseVisualStyleBackColor = false;
            buttonModel.Click += buttonModel_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(buttonPrisposobleniya);
            panel16.Location = new Point(0, 172);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(190, 43);
            panel16.TabIndex = 9;
            // 
            // buttonPrisposobleniya
            // 
            buttonPrisposobleniya.BackColor = Color.FromArgb(229, 9, 40);
            buttonPrisposobleniya.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrisposobleniya.ForeColor = Color.White;
            buttonPrisposobleniya.Image = (Image)resources.GetObject("buttonPrisposobleniya.Image");
            buttonPrisposobleniya.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrisposobleniya.Location = new Point(-32, -26);
            buttonPrisposobleniya.Name = "buttonPrisposobleniya";
            buttonPrisposobleniya.Padding = new Padding(50, 0, 0, 0);
            buttonPrisposobleniya.Size = new Size(248, 95);
            buttonPrisposobleniya.TabIndex = 2;
            buttonPrisposobleniya.Text = "Приспособления";
            buttonPrisposobleniya.TextAlign = ContentAlignment.MiddleLeft;
            buttonPrisposobleniya.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPrisposobleniya.UseVisualStyleBackColor = false;
            buttonPrisposobleniya.Click += buttonPrisposobleniya_Click;
            // 
            // addContainer
            // 
            addContainer.BackColor = Color.FromArgb(229, 9, 40);
            addContainer.BorderStyle = BorderStyle.FixedSingle;
            addContainer.Controls.Add(panel18);
            addContainer.Controls.Add(panel19);
            addContainer.Controls.Add(panel20);
            addContainer.Location = new Point(3, 227);
            addContainer.Name = "addContainer";
            addContainer.Size = new Size(198, 50);
            addContainer.TabIndex = 10;
            // 
            // panel18
            // 
            panel18.Controls.Add(buttonAdd);
            panel18.Location = new Point(0, 0);
            panel18.Margin = new Padding(0);
            panel18.Name = "panel18";
            panel18.Size = new Size(190, 43);
            panel18.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(229, 9, 40);
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(-36, -27);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(50, 0, 0, 0);
            buttonAdd.Size = new Size(248, 95);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(addOsnastka);
            panel19.Location = new Point(0, 43);
            panel19.Margin = new Padding(0);
            panel19.Name = "panel19";
            panel19.Size = new Size(190, 43);
            panel19.TabIndex = 6;
            // 
            // addOsnastka
            // 
            addOsnastka.BackColor = Color.FromArgb(229, 9, 40);
            addOsnastka.ForeColor = Color.White;
            addOsnastka.Image = (Image)resources.GetObject("addOsnastka.Image");
            addOsnastka.ImageAlign = ContentAlignment.MiddleLeft;
            addOsnastka.Location = new Point(-32, -26);
            addOsnastka.Name = "addOsnastka";
            addOsnastka.Padding = new Padding(50, 0, 0, 0);
            addOsnastka.Size = new Size(248, 95);
            addOsnastka.TabIndex = 2;
            addOsnastka.Text = "Оснастка";
            addOsnastka.TextAlign = ContentAlignment.MiddleLeft;
            addOsnastka.TextImageRelation = TextImageRelation.ImageBeforeText;
            addOsnastka.UseVisualStyleBackColor = false;
            addOsnastka.Click += addOsnastka_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(addInstrument);
            panel20.Location = new Point(0, 86);
            panel20.Margin = new Padding(0);
            panel20.Name = "panel20";
            panel20.Size = new Size(190, 43);
            panel20.TabIndex = 7;
            // 
            // addInstrument
            // 
            addInstrument.BackColor = Color.FromArgb(229, 9, 40);
            addInstrument.ForeColor = Color.White;
            addInstrument.Image = (Image)resources.GetObject("addInstrument.Image");
            addInstrument.ImageAlign = ContentAlignment.MiddleLeft;
            addInstrument.Location = new Point(-32, -26);
            addInstrument.Name = "addInstrument";
            addInstrument.Padding = new Padding(50, 0, 0, 0);
            addInstrument.Size = new Size(248, 95);
            addInstrument.TabIndex = 2;
            addInstrument.Text = "Инструмент";
            addInstrument.TextAlign = ContentAlignment.MiddleLeft;
            addInstrument.TextImageRelation = TextImageRelation.ImageBeforeText;
            addInstrument.UseVisualStyleBackColor = false;
            addInstrument.Click += addInstrument_Click;
            // 
            // instrumentTransition
            // 
            instrumentTransition.Interval = 3;
            instrumentTransition.Tick += instrumentTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // osnastkaTransition
            // 
            osnastkaTransition.Interval = 3;
            osnastkaTransition.Tick += osnastkaTransition_Tick;
            // 
            // addTransition
            // 
            addTransition.Interval = 3;
            addTransition.Tick += addTransition_Tick;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(951, 603);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            sidebar.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel2.ResumeLayout(false);
            instrumentContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            osnastkaContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            addContainer.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox buttonMenu;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel instrumentContainer;
        private Panel panel6;
        private Button buttonInstrument;
        private Panel panel3;
        private Button buttonRezec;
        private Panel panel4;
        private Button buttonProtyajki;
        private Panel panel5;
        private Button buttonFreza;
        private Panel panel7;
        private Button buttonRoliki;
        private Panel panel8;
        private Button buttonZenkeri;
        private Panel panel9;
        private Button buttonMetchiki;
        private Panel panel10;
        private Button buttonRazvertki;
        private Panel panel11;
        private Button buttonMechanical;
        private Panel panel2;
        private Button buttonСatalog;
        private System.Windows.Forms.Timer instrumentTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel osnastkaContainer;
        private Panel panel12;
        private Button buttonOsnastka;
        private Panel panel13;
        private Button buttonStampi;
        private Panel panel14;
        private Button buttonPressFormi;
        private Panel panel15;
        private Button buttonModel;
        private Panel panel16;
        private Button buttonPrisposobleniya;
        private System.Windows.Forms.Timer osnastkaTransition;
        private PictureBox pictureBox1;
        private FlowLayoutPanel addContainer;
        private Panel panel18;
        private Button buttonAdd;
        private Panel panel19;
        private Button addOsnastka;
        private Panel panel20;
        private Button addInstrument;
        private System.Windows.Forms.Timer addTransition;
        private Panel panel17;
        private Button buttonHome;
    }
}