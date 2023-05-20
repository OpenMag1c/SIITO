namespace Client.Cards
{
    partial class OsnastkaCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsnastkaCard));
            image = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelName = new Label();
            labelType = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonDesc = new Button();
            description = new FlowLayoutPanel();
            panel1 = new Panel();
            buttonDesc2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelName2 = new Label();
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
            image.Dock = DockStyle.Top;
            image.Image = Properties.Resources.empty_image1;
            image.Location = new Point(23, 27);
            image.Margin = new Padding(11, 13, 11, 13);
            image.Name = "image";
            image.Size = new Size(337, 217);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelName);
            flowLayoutPanel1.Location = new Point(23, 277);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(334, 123);
            flowLayoutPanel1.TabIndex = 17;
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
            labelType.Location = new Point(24, 252);
            labelType.Name = "labelType";
            labelType.Size = new Size(74, 20);
            labelType.TabIndex = 10;
            labelType.Text = "Оснастка";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(142, 407);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(99, 39);
            buttonEdit.TabIndex = 21;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(257, 407);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(99, 39);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDesc
            // 
            buttonDesc.Location = new Point(23, 407);
            buttonDesc.Name = "buttonDesc";
            buttonDesc.Size = new Size(102, 39);
            buttonDesc.TabIndex = 24;
            buttonDesc.Text = "Описание";
            buttonDesc.UseVisualStyleBackColor = true;
            buttonDesc.Click += buttonDesc_Click;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            description.AutoScroll = true;
            description.Controls.Add(panel1);
            description.Controls.Add(textDescription);
            description.Location = new Point(1, 0);
            description.Margin = new Padding(3, 4, 3, 4);
            description.Name = "description";
            description.Padding = new Padding(11, 13, 11, 13);
            description.Size = new Size(383, 464);
            description.TabIndex = 25;
            description.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDesc2);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(14, 17);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 109);
            panel1.TabIndex = 26;
            // 
            // buttonDesc2
            // 
            buttonDesc2.Location = new Point(239, 5);
            buttonDesc2.Name = "buttonDesc2";
            buttonDesc2.Size = new Size(102, 39);
            buttonDesc2.TabIndex = 25;
            buttonDesc2.Text = "Описание";
            buttonDesc2.UseVisualStyleBackColor = true;
            buttonDesc2.Click += buttonDesc2_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(labelName2);
            flowLayoutPanel2.Location = new Point(3, 4);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(232, 101);
            flowLayoutPanel2.TabIndex = 18;
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
            // textDescription
            // 
            textDescription.AutoSize = true;
            textDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDescription.Location = new Point(17, 137);
            textDescription.Margin = new Padding(6, 7, 6, 7);
            textDescription.MaximumSize = new Size(343, 0);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(326, 1960);
            textDescription.TabIndex = 0;
            textDescription.Text = resources.GetString("textDescription.Text");
            // 
            // OsnastkaCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(description);
            Controls.Add(buttonDesc);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelType);
            Controls.Add(image);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OsnastkaCard";
            Padding = new Padding(23, 27, 23, 27);
            Size = new Size(383, 463);
            Load += OsnastkaCard_Load;
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelName;
        private Label labelType;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonDesc;
        private FlowLayoutPanel description;
        private Panel panel1;
        private Button buttonDesc2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelName2;
        private Label textDescription;
    }
}
