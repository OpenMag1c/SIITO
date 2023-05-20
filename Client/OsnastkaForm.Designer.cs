namespace Client
{
    partial class OsnastkaForm
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
            labelType = new Label();
            label1 = new Label();
            osnastkaContainer = new FlowLayoutPanel();
            pictureButtonAdd = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureButtonAdd).BeginInit();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(108, 9);
            labelType.Name = "labelType";
            labelType.Size = new Size(60, 30);
            labelType.TabIndex = 4;
            labelType.Text = "/ тип";
            labelType.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 3;
            label1.Text = "Оснастка";
            // 
            // osnastkaContainer
            // 
            osnastkaContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            osnastkaContainer.AutoScroll = true;
            osnastkaContainer.Location = new Point(12, 42);
            osnastkaContainer.Name = "osnastkaContainer";
            osnastkaContainer.Size = new Size(776, 386);
            osnastkaContainer.TabIndex = 5;
            // 
            // pictureButtonAdd
            // 
            pictureButtonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureButtonAdd.BackColor = Color.Transparent;
            pictureButtonAdd.Cursor = Cursors.Hand;
            pictureButtonAdd.Image = Properties.Resources.plus_circle;
            pictureButtonAdd.Location = new Point(689, 350);
            pictureButtonAdd.Name = "pictureButtonAdd";
            pictureButtonAdd.Size = new Size(70, 70);
            pictureButtonAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureButtonAdd.TabIndex = 6;
            pictureButtonAdd.TabStop = false;
            pictureButtonAdd.Click += pictureButtonAdd_Click;
            // 
            // OsnastkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureButtonAdd);
            Controls.Add(osnastkaContainer);
            Controls.Add(labelType);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OsnastkaForm";
            Text = "OsnastkaForm";
            Load += OsnastkaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureButtonAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType;
        private Label label1;
        private FlowLayoutPanel osnastkaContainer;
        private PictureBox pictureButtonAdd;
    }
}