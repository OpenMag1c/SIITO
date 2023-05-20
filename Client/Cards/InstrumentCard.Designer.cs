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
            labelCode = new Label();
            labelDimensions = new Label();
            label1 = new Label();
            labelPrice = new Label();
            labelMeasure = new Label();
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
            image.Location = new Point(11, 13);
            image.Margin = new Padding(11, 13, 11, 13);
            image.Name = "image";
            image.Size = new Size(184, 301);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(181, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Наименование";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(209, 17);
            labelType.Name = "labelType";
            labelType.Size = new Size(51, 20);
            labelType.TabIndex = 2;
            labelType.Text = "Резец";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(206, 167);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(128, 28);
            labelCode.TabIndex = 4;
            labelCode.Text = "23412342 BK";
            // 
            // labelDimensions
            // 
            labelDimensions.AutoSize = true;
            labelDimensions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDimensions.Location = new Point(206, 195);
            labelDimensions.Name = "labelDimensions";
            labelDimensions.Size = new Size(96, 28);
            labelDimensions.TabIndex = 5;
            labelDimensions.Text = "20x30x20";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 232);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 6;
            label1.Text = "Цена:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.White;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(270, 232);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(49, 28);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "4.59";
            // 
            // labelMeasure
            // 
            labelMeasure.AutoSize = true;
            labelMeasure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMeasure.Location = new Point(310, 195);
            labelMeasure.Name = "labelMeasure";
            labelMeasure.Size = new Size(36, 28);
            labelMeasure.TabIndex = 8;
            labelMeasure.Text = "шт";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelName);
            flowLayoutPanel1.Location = new Point(206, 59);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(311, 77);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(321, 275);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(99, 39);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(206, 275);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(99, 39);
            buttonEdit.TabIndex = 24;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDesc
            // 
            buttonDesc.Location = new Point(399, 16);
            buttonDesc.Name = "buttonDesc";
            buttonDesc.Size = new Size(102, 39);
            buttonDesc.TabIndex = 26;
            buttonDesc.Text = "Описание";
            buttonDesc.UseVisualStyleBackColor = true;
            buttonDesc.Click += buttonDesc_Click;
            // 
            // linkTextGost
            // 
            linkTextGost.AutoSize = true;
            linkTextGost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkTextGost.Location = new Point(206, 140);
            linkTextGost.Name = "linkTextGost";
            linkTextGost.Size = new Size(127, 28);
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
            description.Location = new Point(1, -1);
            description.Margin = new Padding(3, 4, 3, 4);
            description.Name = "description";
            description.Size = new Size(531, 329);
            description.TabIndex = 28;
            description.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(buttonDesc2);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 81);
            panel1.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(labelName2);
            flowLayoutPanel2.Location = new Point(3, 7);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(381, 75);
            flowLayoutPanel2.TabIndex = 28;
            // 
            // labelName2
            // 
            labelName2.AutoSize = true;
            labelName2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName2.Location = new Point(3, 0);
            labelName2.Name = "labelName2";
            labelName2.Size = new Size(181, 32);
            labelName2.TabIndex = 1;
            labelName2.Text = "Наименование";
            // 
            // buttonDesc2
            // 
            buttonDesc2.Location = new Point(390, 13);
            buttonDesc2.Name = "buttonDesc2";
            buttonDesc2.Size = new Size(102, 39);
            buttonDesc2.TabIndex = 27;
            buttonDesc2.Text = "Описание";
            buttonDesc2.UseVisualStyleBackColor = true;
            buttonDesc2.Click += buttonDesc2_Click;
            // 
            // textDescription
            // 
            textDescription.AutoSize = true;
            textDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(11, 102);
            textDescription.Margin = new Padding(11, 13, 11, 13);
            textDescription.MaximumSize = new Size(480, 0);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(475, 1204);
            textDescription.TabIndex = 0;
            textDescription.Text = resources.GetString("textDescription.Text");
            // 
            // InstrumentCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(description);
            Controls.Add(linkTextGost);
            Controls.Add(buttonDesc);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelMeasure);
            Controls.Add(labelPrice);
            Controls.Add(label1);
            Controls.Add(labelDimensions);
            Controls.Add(labelCode);
            Controls.Add(labelType);
            Controls.Add(image);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InstrumentCard";
            Padding = new Padding(11, 13, 11, 13);
            Size = new Size(531, 327);
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
        private Label labelCode;
        private Label labelDimensions;
        private Label label1;
        private Label labelPrice;
        private Label labelMeasure;
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
