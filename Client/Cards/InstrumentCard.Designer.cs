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
            labelGost = new Label();
            labelCode = new Label();
            labelDimensions = new Label();
            label1 = new Label();
            labelPrice = new Label();
            labelMeasure = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            description = new FlowLayoutPanel();
            textDescription = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonDesc = new Button();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            description.SuspendLayout();
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
            image.Size = new Size(161, 225);
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
            labelName.Size = new Size(143, 25);
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
            // labelGost
            // 
            labelGost.AutoSize = true;
            labelGost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGost.Location = new Point(180, 104);
            labelGost.Name = "labelGost";
            labelGost.Size = new Size(98, 21);
            labelGost.TabIndex = 3;
            labelGost.Text = "ГОСТ 23359";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(180, 125);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(104, 21);
            labelCode.TabIndex = 4;
            labelCode.Text = "23412342 BK";
            // 
            // labelDimensions
            // 
            labelDimensions.AutoSize = true;
            labelDimensions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDimensions.Location = new Point(180, 146);
            labelDimensions.Name = "labelDimensions";
            labelDimensions.Size = new Size(78, 21);
            labelDimensions.TabIndex = 5;
            labelDimensions.Text = "20x30x20";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 174);
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
            labelPrice.Location = new Point(236, 174);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(40, 21);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "4.59";
            // 
            // labelMeasure
            // 
            labelMeasure.AutoSize = true;
            labelMeasure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMeasure.Location = new Point(271, 146);
            labelMeasure.Name = "labelMeasure";
            labelMeasure.Size = new Size(30, 21);
            labelMeasure.TabIndex = 8;
            labelMeasure.Text = "шт";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelName);
            flowLayoutPanel1.Location = new Point(180, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(272, 58);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            description.AutoScroll = true;
            description.Controls.Add(textDescription);
            description.Location = new Point(1, 5);
            description.Name = "description";
            description.Size = new Size(465, 241);
            description.TabIndex = 10;
            description.Visible = false;
            // 
            // textDescription
            // 
            textDescription.AutoSize = true;
            textDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(5, 5);
            textDescription.Margin = new Padding(5);
            textDescription.MaximumSize = new Size(360, 0);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(357, 1008);
            textDescription.TabIndex = 0;
            textDescription.Text = resources.GetString("textDescription.Text");
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(281, 206);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(87, 29);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(180, 206);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(87, 29);
            buttonEdit.TabIndex = 24;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDesc
            // 
            buttonDesc.Location = new Point(349, 12);
            buttonDesc.Margin = new Padding(3, 2, 3, 2);
            buttonDesc.Name = "buttonDesc";
            buttonDesc.Size = new Size(89, 29);
            buttonDesc.TabIndex = 26;
            buttonDesc.Text = "Описание";
            buttonDesc.UseVisualStyleBackColor = true;
            buttonDesc.Click += buttonDesc_Click;
            // 
            // InstrumentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonDesc);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(description);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelMeasure);
            Controls.Add(labelPrice);
            Controls.Add(label1);
            Controls.Add(labelDimensions);
            Controls.Add(labelCode);
            Controls.Add(labelGost);
            Controls.Add(labelType);
            Controls.Add(image);
            Name = "InstrumentCard";
            Padding = new Padding(10);
            Size = new Size(465, 245);
            Load += InstrumentCard_Load;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            description.ResumeLayout(false);
            description.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label labelName;
        private Label labelType;
        private Label labelGost;
        private Label labelCode;
        private Label labelDimensions;
        private Label label1;
        private Label labelPrice;
        private Label labelMeasure;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel description;
        private Label textDescription;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonDesc;
    }
}
