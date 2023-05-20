namespace Client;

partial class EditOsnastkaForm
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
        groupBox1 = new GroupBox();
        label10 = new Label();
        descInput = new TextBox();
        label9 = new Label();
        actionButton = new Button();
        osnastkaTypeSelect = new ComboBox();
        label6 = new Label();
        OsnastkaPictureBox = new PictureBox();
        label1 = new Label();
        osnastkaNameInput = new TextBox();
        editOsnastkaMainLabel = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)OsnastkaPictureBox).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(descInput);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(actionButton);
        groupBox1.Controls.Add(osnastkaTypeSelect);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(OsnastkaPictureBox);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(osnastkaNameInput);
        groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox1.Location = new Point(94, 60);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(716, 429);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Информация оснастки";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label10.Location = new Point(22, 168);
        label10.Name = "label10";
        label10.Size = new Size(89, 23);
        label10.TabIndex = 21;
        label10.Text = "Описание";
        // 
        // descInput
        // 
        descInput.BorderStyle = BorderStyle.None;
        descInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        descInput.Location = new Point(22, 194);
        descInput.Multiline = true;
        descInput.Name = "descInput";
        descInput.ScrollBars = ScrollBars.Both;
        descInput.Size = new Size(388, 139);
        descInput.TabIndex = 20;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label9.Location = new Point(451, 271);
        label9.Name = "label9";
        label9.Size = new Size(114, 23);
        label9.TabIndex = 18;
        label9.Text = "Тип оснастки";
        // 
        // actionButton
        // 
        actionButton.Location = new Point(568, 362);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(120, 39);
        actionButton.TabIndex = 19;
        actionButton.Text = "Создать";
        actionButton.UseVisualStyleBackColor = true;
        actionButton.Click += actionButton_Click_1;
        // 
        // osnastkaTypeSelect
        // 
        osnastkaTypeSelect.FormattingEnabled = true;
        osnastkaTypeSelect.Location = new Point(446, 297);
        osnastkaTypeSelect.Name = "osnastkaTypeSelect";
        osnastkaTypeSelect.Size = new Size(242, 36);
        osnastkaTypeSelect.TabIndex = 16;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(451, 39);
        label6.Name = "label6";
        label6.Size = new Size(106, 23);
        label6.TabIndex = 12;
        label6.Text = "Фотография";
        // 
        // OsnastkaPictureBox
        // 
        OsnastkaPictureBox.BorderStyle = BorderStyle.FixedSingle;
        OsnastkaPictureBox.Location = new Point(446, 65);
        OsnastkaPictureBox.Name = "OsnastkaPictureBox";
        OsnastkaPictureBox.Size = new Size(242, 182);
        OsnastkaPictureBox.TabIndex = 11;
        OsnastkaPictureBox.TabStop = false;
        OsnastkaPictureBox.Click += OsnastkaPictureBox_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(22, 57);
        label1.Name = "label1";
        label1.Size = new Size(86, 23);
        label1.TabIndex = 2;
        label1.Text = "Название";
        // 
        // osnastkaNameInput
        // 
        osnastkaNameInput.Location = new Point(22, 83);
        osnastkaNameInput.Name = "osnastkaNameInput";
        osnastkaNameInput.Size = new Size(255, 34);
        osnastkaNameInput.TabIndex = 1;
        // 
        // editOsnastkaMainLabel
        // 
        editOsnastkaMainLabel.AutoSize = true;
        editOsnastkaMainLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        editOsnastkaMainLabel.Location = new Point(94, 19);
        editOsnastkaMainLabel.Name = "editOsnastkaMainLabel";
        editOsnastkaMainLabel.Size = new Size(327, 38);
        editOsnastkaMainLabel.TabIndex = 3;
        editOsnastkaMainLabel.Text = "Создать новую оснастку";
        // 
        // EditOsnastkaForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(groupBox1);
        Controls.Add(editOsnastkaMainLabel);
        FormBorderStyle = FormBorderStyle.None;
        Name = "EditOsnastkaForm";
        Text = "EditOsnastkaForm";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)OsnastkaPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private Label label10;
    private TextBox descInput;
    private Label label9;
    private Button actionButton;
    private ComboBox gostsSelect;
    private Label label7;
    private Label label8;
    private TextBox instrumentPriceInput;
    private ComboBox osnastkaTypeSelect;
    private Label label6;
    private PictureBox OsnastkaPictureBox;
    private Label label4;
    private Label label3;
    private Label label2;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown1;
    private Label label1;
    private TextBox osnastkaNameInput;
    private Label editOsnastkaMainLabel;
}