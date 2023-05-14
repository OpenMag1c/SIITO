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
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            buttonOsnastka = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            buttonInstrument = new Button();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonOsnastka);
            panel1.Location = new Point(30, 30);
            panel1.Margin = new Padding(30);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 180);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 153);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 5;
            label5.Text = "Оснастка";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 233);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 4;
            label1.Text = "Инструмент";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 313);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Оснастка";
            // 
            // buttonOsnastka
            // 
            buttonOsnastka.BackgroundImage = Properties.Resources.osnastka;
            buttonOsnastka.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOsnastka.CausesValidation = false;
            buttonOsnastka.Location = new Point(-14, -6);
            buttonOsnastka.Name = "buttonOsnastka";
            buttonOsnastka.Size = new Size(309, 160);
            buttonOsnastka.TabIndex = 2;
            buttonOsnastka.UseVisualStyleBackColor = true;
            buttonOsnastka.Click += buttonOsnastka_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(buttonInstrument);
            panel2.Location = new Point(375, 30);
            panel2.Margin = new Padding(30);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 180);
            panel2.TabIndex = 2;
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
            // buttonInstrument
            // 
            buttonInstrument.BackgroundImage = Properties.Resources.instrument;
            buttonInstrument.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInstrument.CausesValidation = false;
            buttonInstrument.Location = new Point(-14, -6);
            buttonInstrument.Name = "buttonInstrument";
            buttonInstrument.Size = new Size(309, 160);
            buttonInstrument.TabIndex = 2;
            buttonInstrument.UseVisualStyleBackColor = true;
            buttonInstrument.Click += buttonInstrument_Click;
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
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button buttonInstrument;
        private Panel panel1;
        private Label label5;
        private Label label1;
        private Label label4;
        private Button buttonOsnastka;
    }
}