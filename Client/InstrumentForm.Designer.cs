﻿namespace Client
{
    partial class InstrumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentForm));
            label1 = new Label();
            labelType = new Label();
            instrumentsContainer = new FlowLayoutPanel();
            pictureButtonAdd = new PictureBox();
            pictureButtonExport = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureButtonAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureButtonExport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Инструмент";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(135, 9);
            labelType.Name = "labelType";
            labelType.Size = new Size(60, 30);
            labelType.TabIndex = 2;
            labelType.Text = "/ тип";
            labelType.Visible = false;
            // 
            // instrumentsContainer
            // 
            instrumentsContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            instrumentsContainer.AutoScroll = true;
            instrumentsContainer.Location = new Point(12, 52);
            instrumentsContainer.Name = "instrumentsContainer";
            instrumentsContainer.Size = new Size(645, 386);
            instrumentsContainer.TabIndex = 3;
            // 
            // pictureButtonAdd
            // 
            pictureButtonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureButtonAdd.BackColor = Color.Transparent;
            pictureButtonAdd.Cursor = Cursors.Hand;
            pictureButtonAdd.Image = Properties.Resources.plus_circle;
            pictureButtonAdd.Location = new Point(690, 350);
            pictureButtonAdd.Name = "pictureButtonAdd";
            pictureButtonAdd.Size = new Size(70, 70);
            pictureButtonAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureButtonAdd.TabIndex = 4;
            pictureButtonAdd.TabStop = false;
            pictureButtonAdd.Click += pictureButtonAdd_Click;
            // 
            // pictureButtonExport
            // 
            pictureButtonExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureButtonExport.BackColor = Color.Transparent;
            pictureButtonExport.Cursor = Cursors.Hand;
            pictureButtonExport.Image = (Image)resources.GetObject("pictureButtonExport.Image");
            pictureButtonExport.Location = new Point(678, 274);
            pictureButtonExport.Name = "pictureButtonExport";
            pictureButtonExport.Padding = new Padding(10);
            pictureButtonExport.Size = new Size(70, 70);
            pictureButtonExport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureButtonExport.TabIndex = 8;
            pictureButtonExport.TabStop = false;
            pictureButtonExport.Click += pictureButtonExport_Click;
            // 
            // InstrumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureButtonExport);
            Controls.Add(pictureButtonAdd);
            Controls.Add(instrumentsContainer);
            Controls.Add(labelType);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InstrumentForm";
            Text = "InstrumentForm";
            Load += InstrumentForm_Load;
            MouseLeave += InstrumentForm_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureButtonAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureButtonExport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelType;
        private FlowLayoutPanel instrumentsContainer;
        private PictureBox pictureButtonAdd;
        private PictureBox pictureButtonExport;
    }
}