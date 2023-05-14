namespace Client
{
    partial class CatalogForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(40, 40);
            flowLayoutPanel1.Margin = new Padding(30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(732, 380);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(30, 30);
            panel1.Margin = new Padding(30);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 180);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.osnastka;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(-14, -8);
            button1.Name = "button1";
            button1.Size = new Size(309, 160);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 153);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 3;
            label1.Text = "Оснастка";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(375, 30);
            panel2.Margin = new Padding(30);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 180);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 233);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 3;
            label2.Text = "Оснастка";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.instrument;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(-14, -8);
            button2.Name = "button2";
            button2.Size = new Size(309, 160);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 153);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Инструмент";
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CatalogForm";
            Text = "CatalogForm";
            Load += CatalogForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button button2;
    }
}