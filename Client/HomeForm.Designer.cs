namespace Client
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            mainContainer = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            mainContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContainer.BackColor = Color.Transparent;
            mainContainer.Controls.Add(label1);
            mainContainer.FlowDirection = FlowDirection.RightToLeft;
            mainContainer.Location = new Point(3, 3);
            mainContainer.Margin = new Padding(3, 3, 0, 3);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(680, 927);
            mainContainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(676, 588);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(mainContainer);
            panel1.Location = new Point(11, 15);
            panel1.MaximumSize = new Size(900, 1000);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 800);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(686, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 800);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.backImage;
            pictureBox1.Location = new Point(0, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 964);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Padding = new Padding(30);
            Text = "HomeForm";
            mainContainer.ResumeLayout(false);
            mainContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel mainContainer;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}