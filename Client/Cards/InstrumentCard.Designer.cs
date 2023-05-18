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
            // labelGost
            // 
            labelGost.AutoSize = true;
            labelGost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGost.Location = new Point(206, 139);
            labelGost.Name = "labelGost";
            labelGost.Size = new Size(127, 28);
            labelGost.TabIndex = 3;
            labelGost.Text = "ГОСТ 23359";
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
            // description
            // 
            description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            description.AutoScroll = true;
            description.Controls.Add(textDescription);
            description.Location = new Point(1, 7);
            description.Margin = new Padding(3, 4, 3, 4);
            description.Name = "description";
            description.Size = new Size(531, 321);
            description.TabIndex = 10;
            description.Visible = false;
            // 
            // textDescription
            // 
            textDescription.AutoSize = true;
            textDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(6, 7);
            textDescription.Margin = new Padding(6, 7, 6, 7);
            textDescription.MaximumSize = new Size(411, 0);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(411, 1540);
            textDescription.TabIndex = 0;
            textDescription.Text = resources.GetString("textDescription.Text");
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
            // InstrumentCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
