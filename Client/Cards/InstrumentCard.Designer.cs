namespace Client.Cards
{
    partial class InstrumentCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentCard));
            image = new PictureBox();
            labelName = new Label();
            labelType = new Label();
            label1 = new Label();
            labelPrice = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonDesc = new Button();
            linkTextGost = new LinkLabel();
            description = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelName2 = new Label();
            buttonDesc2 = new Button();
            textDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            description.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // image
            // 
            image.Dock = DockStyle.Left;
            image.ErrorImage = Properties.Resources.empty_image;
            image.Image = Properties.Resources.empty_image1;
            image.Location = new Point(10, 10);
            image.Margin = new Padding(10);
            image.Name = "image";
            image.Size = new Size(161, 198);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(119, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Наименование";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(183, 13);
            labelType.Name = "labelType";
            labelType.Size = new Size(42, 15);
            labelType.TabIndex = 2;
            labelType.Text = "Резец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 152);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 6;
            label1.Text = "Цена:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.White;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(238, 152);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(40, 21);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "4.59";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelName);
            flowLayoutPanel1.Location = new Point(180, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(208, 69);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(301, 179);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(87, 29);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(180, 179);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(87, 29);
            buttonEdit.TabIndex = 24;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDesc
            // 
            buttonDesc.Location = new Point(299, 10);
            buttonDesc.Margin = new Padding(3, 2, 3, 2);
            buttonDesc.Name = "buttonDesc";
            buttonDesc.Size = new Size(89, 29);
            buttonDesc.TabIndex = 26;
            buttonDesc.Text = "Описание";
            buttonDesc.UseVisualStyleBackColor = true;
            buttonDesc.Click += buttonDesc_Click;
            // 
            // linkTextGost
            // 
            linkTextGost.AutoSize = true;
            linkTextGost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkTextGost.Location = new Point(180, 126);
            linkTextGost.Name = "linkTextGost";
            linkTextGost.Size = new Size(98, 21);
            linkTextGost.TabIndex = 27;
            linkTextGost.TabStop = true;
            linkTextGost.Text = "ГОСТ 23359";
            linkTextGost.LinkClicked += linkTextGost_LinkClicked;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            description.AutoScroll = true;
            description.Controls.Add(panel1);
            description.Controls.Add(textDescription);
            description.Location = new Point(0, 0);
            description.Name = "description";
            description.Size = new Size(401, 218);
            description.TabIndex = 28;
            description.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(buttonDesc2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 61);
            panel1.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(labelName2);
            flowLayoutPanel2.Location = new Point(3, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(272, 53);
            flowLayoutPanel2.TabIndex = 28;
            // 
            // labelName2
            // 
            labelName2.AutoSize = true;
            labelName2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelName2.Location = new Point(3, 0);
            labelName2.Name = "labelName2";
            labelName2.Size = new Size(119, 21);
            labelName2.TabIndex = 1;
            labelName2.Text = "Наименование";
            // 
            // buttonDesc2
            // 
            buttonDesc2.Location = new Point(287, 10);
            buttonDesc2.Margin = new Padding(3, 2, 3, 2);
            buttonDesc2.Name = "buttonDesc2";
            buttonDesc2.Size = new Size(89, 29);
            buttonDesc2.TabIndex = 27;
            buttonDesc2.Text = "Описание";
            buttonDesc2.UseVisualStyleBackColor = true;
            buttonDesc2.Click += buttonDesc2_Click;
            // 
            // textDescription
            // 
            textDescription.AutoSize = true;
            textDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(10, 77);
            textDescription.Margin = new Padding(10);
            textDescription.MaximumSize = new Size(370, 0);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(369, 903);
            textDescription.TabIndex = 0;
            textDescription.Text = resources.GetString("textDescription.Text");
            // 
            // InstrumentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(description);
            Controls.Add(linkTextGost);
            Controls.Add(buttonDesc);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelPrice);
            Controls.Add(label1);
            Controls.Add(labelType);
            Controls.Add(image);
            Margin = new Padding(30);
            Name = "InstrumentCard";
            Padding = new Padding(10);
            Size = new Size(401, 218);
            Load += InstrumentCard_Load;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            description.ResumeLayout(false);
            description.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label labelName;
        private Label labelType;
        private Label label1;
        private Label labelPrice;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonDesc;
        private LinkLabel linkTextGost;
        private FlowLayoutPanel description;
        private Label textDescription;
        private Panel panel1;
        private Button buttonDesc2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelName2;
    }
}
