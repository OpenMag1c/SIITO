namespace Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox2 = new PictureBox();
            buttonMenu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            instrumentContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            buttonInstrument = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            panel9 = new Panel();
            button8 = new Button();
            panel10 = new Panel();
            button9 = new Button();
            panel11 = new Panel();
            button10 = new Button();
            osnastkaContainer = new FlowLayoutPanel();
            panel12 = new Panel();
            buttonOsnastka = new Button();
            panel13 = new Panel();
            button11 = new Button();
            panel14 = new Panel();
            button12 = new Button();
            panel15 = new Panel();
            button13 = new Button();
            panel16 = new Panel();
            button14 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            instrumentTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            osnastkaTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            sidebar.SuspendLayout();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 9, 40);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 34);
            panel1.TabIndex = 0;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
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
            sidebar.Controls.Add(instrumentContainer);
            sidebar.Controls.Add(osnastkaContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 34);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 536);
            sidebar.TabIndex = 1;
            // 
            // instrumentContainer
            // 
            instrumentContainer.BackColor = Color.FromArgb(229, 9, 40);
            instrumentContainer.Controls.Add(panel6);
            instrumentContainer.Controls.Add(panel3);
            instrumentContainer.Controls.Add(panel4);
            instrumentContainer.Controls.Add(panel5);
            instrumentContainer.Controls.Add(panel7);
            instrumentContainer.Controls.Add(panel8);
            instrumentContainer.Controls.Add(panel9);
            instrumentContainer.Controls.Add(panel10);
            instrumentContainer.Controls.Add(panel11);
            instrumentContainer.Location = new Point(3, 3);
            instrumentContainer.Name = "instrumentContainer";
            instrumentContainer.Size = new Size(198, 43);
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
            panel3.Controls.Add(button2);
            panel3.Location = new Point(0, 43);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 43);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 9, 40);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-32, -26);
            button2.Name = "button2";
            button2.Padding = new Padding(50, 0, 0, 0);
            button2.Size = new Size(248, 95);
            button2.TabIndex = 2;
            button2.Text = "Резцы";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(0, 86);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 43);
            panel4.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(229, 9, 40);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-32, -26);
            button3.Name = "button3";
            button3.Padding = new Padding(50, 0, 0, 0);
            button3.Size = new Size(248, 95);
            button3.TabIndex = 2;
            button3.Text = "Протяжки";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(0, 129);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 43);
            panel5.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(229, 9, 40);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-32, -26);
            button4.Name = "button4";
            button4.Padding = new Padding(50, 0, 0, 0);
            button4.Size = new Size(248, 95);
            button4.TabIndex = 2;
            button4.Text = "Фрезы";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(0, 172);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(190, 43);
            panel7.TabIndex = 9;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(229, 9, 40);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-32, -26);
            button6.Name = "button6";
            button6.Padding = new Padding(50, 0, 0, 0);
            button6.Size = new Size(248, 95);
            button6.TabIndex = 2;
            button6.Text = "Ролики резьбонакатные";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button7);
            panel8.Location = new Point(0, 215);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(190, 43);
            panel8.TabIndex = 10;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(229, 9, 40);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-32, -26);
            button7.Name = "button7";
            button7.Padding = new Padding(50, 0, 0, 0);
            button7.Size = new Size(248, 95);
            button7.TabIndex = 2;
            button7.Text = "Зенкеры";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(button8);
            panel9.Location = new Point(0, 258);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(190, 43);
            panel9.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(229, 9, 40);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-32, -26);
            button8.Name = "button8";
            button8.Padding = new Padding(50, 0, 0, 0);
            button8.Size = new Size(248, 95);
            button8.TabIndex = 2;
            button8.Text = "Метчики";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(button9);
            panel10.Location = new Point(0, 301);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(190, 43);
            panel10.TabIndex = 12;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(229, 9, 40);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-32, -26);
            button9.Name = "button9";
            button9.Padding = new Padding(50, 0, 0, 0);
            button9.Size = new Size(248, 95);
            button9.TabIndex = 2;
            button9.Text = "Развертки";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(button10);
            panel11.Location = new Point(0, 344);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(190, 43);
            panel11.TabIndex = 13;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(229, 9, 40);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(-32, -26);
            button10.Name = "button10";
            button10.Padding = new Padding(50, 0, 0, 0);
            button10.Size = new Size(248, 95);
            button10.TabIndex = 2;
            button10.Text = "Инструмент с\r\nмеханическим\r\nкреплением\r\n";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            // 
            // osnastkaContainer
            // 
            osnastkaContainer.BackColor = Color.FromArgb(229, 9, 40);
            osnastkaContainer.Controls.Add(panel12);
            osnastkaContainer.Controls.Add(panel13);
            osnastkaContainer.Controls.Add(panel14);
            osnastkaContainer.Controls.Add(panel15);
            osnastkaContainer.Controls.Add(panel16);
            osnastkaContainer.Location = new Point(3, 52);
            osnastkaContainer.Name = "osnastkaContainer";
            osnastkaContainer.Size = new Size(198, 43);
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
            panel13.Controls.Add(button11);
            panel13.Location = new Point(0, 43);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(190, 43);
            panel13.TabIndex = 6;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(229, 9, 40);
            button11.ForeColor = Color.White;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(-32, -26);
            button11.Name = "button11";
            button11.Padding = new Padding(50, 0, 0, 0);
            button11.Size = new Size(248, 95);
            button11.TabIndex = 2;
            button11.Text = "Штампы";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.Controls.Add(button12);
            panel14.Location = new Point(0, 86);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(190, 43);
            panel14.TabIndex = 7;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(229, 9, 40);
            button12.ForeColor = Color.White;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(-32, -26);
            button12.Name = "button12";
            button12.Padding = new Padding(50, 0, 0, 0);
            button12.Size = new Size(248, 95);
            button12.TabIndex = 2;
            button12.Text = "Пресс-формы";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            panel15.Controls.Add(button13);
            panel15.Location = new Point(0, 129);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(190, 43);
            panel15.TabIndex = 8;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(229, 9, 40);
            button13.ForeColor = Color.White;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(-32, -26);
            button13.Name = "button13";
            button13.Padding = new Padding(50, 0, 0, 0);
            button13.Size = new Size(248, 95);
            button13.TabIndex = 2;
            button13.Text = "Модельная оснастка";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            panel16.Controls.Add(button14);
            panel16.Location = new Point(0, 172);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(190, 43);
            panel16.TabIndex = 9;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(229, 9, 40);
            button14.ForeColor = Color.White;
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(-32, -26);
            button14.Name = "button14";
            button14.Padding = new Padding(50, 0, 0, 0);
            button14.Size = new Size(248, 95);
            button14.TabIndex = 2;
            button14.Text = "Приспособления";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(729, 268);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 43);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(229, 9, 40);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-36, -27);
            button1.Name = "button1";
            button1.Padding = new Padding(50, 0, 0, 0);
            button1.Size = new Size(248, 95);
            button1.TabIndex = 2;
            button1.Text = "Оснастка";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(951, 570);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            sidebar.ResumeLayout(false);
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
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox buttonMenu;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel instrumentContainer;
        private Panel panel6;
        private Button buttonInstrument;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button7;
        private Panel panel9;
        private Button button8;
        private Panel panel10;
        private Button button9;
        private Panel panel11;
        private Button button10;
        private Panel panel2;
        private Button button1;
        private System.Windows.Forms.Timer instrumentTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel osnastkaContainer;
        private Panel panel12;
        private Button buttonOsnastka;
        private Panel panel13;
        private Button button11;
        private Panel panel14;
        private Button button12;
        private Panel panel15;
        private Button button13;
        private Panel panel16;
        private Button button14;
        private System.Windows.Forms.Timer osnastkaTransition;
    }
}