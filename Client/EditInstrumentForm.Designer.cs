namespace Client;

partial class EditInstrumentForm
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
        editInstrumentMainLabel = new Label();
        instrumentNameInput = new TextBox();
        groupBox1 = new GroupBox();
        label10 = new Label();
        descInput = new TextBox();
        label9 = new Label();
        actionButton = new Button();
        gostsSelect = new ComboBox();
        label7 = new Label();
        label8 = new Label();
        instrumentPriceInput = new TextBox();
        instrumentTypeSelect = new ComboBox();
        label6 = new Label();
        instrumentPictureBox = new PictureBox();
        label1 = new Label();
        currencySelect = new ComboBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)instrumentPictureBox).BeginInit();
        SuspendLayout();
        // 
        // editInstrumentMainLabel
        // 
        editInstrumentMainLabel.AutoSize = true;
        editInstrumentMainLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        editInstrumentMainLabel.Location = new Point(92, 19);
        editInstrumentMainLabel.Name = "editInstrumentMainLabel";
        editInstrumentMainLabel.Size = new Size(363, 38);
        editInstrumentMainLabel.TabIndex = 0;
        editInstrumentMainLabel.Text = "Создать новый инструмент";
        // 
        // instrumentNameInput
        // 
        instrumentNameInput.Location = new Point(22, 65);
        instrumentNameInput.Name = "instrumentNameInput";
        instrumentNameInput.Size = new Size(255, 34);
        instrumentNameInput.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(currencySelect);
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(descInput);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(actionButton);
        groupBox1.Controls.Add(gostsSelect);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(instrumentPriceInput);
        groupBox1.Controls.Add(instrumentTypeSelect);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(instrumentPictureBox);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(instrumentNameInput);
        groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox1.Location = new Point(92, 60);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(705, 500);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Информация инструмента";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label10.Location = new Point(22, 222);
        label10.Name = "label10";
        label10.Size = new Size(89, 23);
        label10.TabIndex = 21;
        label10.Text = "Описание";
        // 
        // descInput
        // 
        descInput.BorderStyle = BorderStyle.None;
        descInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        descInput.Location = new Point(22, 248);
        descInput.Multiline = true;
        descInput.Name = "descInput";
        descInput.ScrollBars = ScrollBars.Both;
        descInput.Size = new Size(388, 235);
        descInput.TabIndex = 20;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label9.Location = new Point(451, 270);
        label9.Name = "label9";
        label9.Size = new Size(144, 23);
        label9.TabIndex = 18;
        label9.Text = "Тип инструмента";
        // 
        // actionButton
        // 
        actionButton.Location = new Point(568, 444);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(120, 39);
        actionButton.TabIndex = 19;
        actionButton.Text = "Создать";
        actionButton.UseVisualStyleBackColor = true;
        actionButton.Click += actionButton_Click;
        // 
        // gostsSelect
        // 
        gostsSelect.FormattingEnabled = true;
        gostsSelect.Location = new Point(446, 361);
        gostsSelect.Name = "gostsSelect";
        gostsSelect.Size = new Size(242, 36);
        gostsSelect.TabIndex = 15;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(22, 128);
        label7.Name = "label7";
        label7.Size = new Size(51, 23);
        label7.TabIndex = 14;
        label7.Text = "Цена";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label8.Location = new Point(451, 335);
        label8.Name = "label8";
        label8.Size = new Size(51, 23);
        label8.TabIndex = 17;
        label8.Text = "ГОСТ";
        // 
        // instrumentPriceInput
        // 
        instrumentPriceInput.Location = new Point(22, 154);
        instrumentPriceInput.Name = "instrumentPriceInput";
        instrumentPriceInput.Size = new Size(125, 34);
        instrumentPriceInput.TabIndex = 13;
        // 
        // instrumentTypeSelect
        // 
        instrumentTypeSelect.FormattingEnabled = true;
        instrumentTypeSelect.Location = new Point(446, 296);
        instrumentTypeSelect.Name = "instrumentTypeSelect";
        instrumentTypeSelect.Size = new Size(242, 36);
        instrumentTypeSelect.TabIndex = 16;
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
        // instrumentPictureBox
        // 
        instrumentPictureBox.BorderStyle = BorderStyle.FixedSingle;
        instrumentPictureBox.Location = new Point(446, 65);
        instrumentPictureBox.Name = "instrumentPictureBox";
        instrumentPictureBox.Size = new Size(242, 182);
        instrumentPictureBox.TabIndex = 11;
        instrumentPictureBox.TabStop = false;
        instrumentPictureBox.Click += instrumentPictureBox_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(22, 39);
        label1.Name = "label1";
        label1.Size = new Size(86, 23);
        label1.TabIndex = 2;
        label1.Text = "Название";
        // 
        // currencySelect
        // 
        currencySelect.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        currencySelect.FormattingEnabled = true;
        currencySelect.Location = new Point(154, 156);
        currencySelect.Name = "currencySelect";
        currencySelect.Size = new Size(62, 31);
        currencySelect.TabIndex = 22;
        // 
        // EditInstrumentForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(groupBox1);
        Controls.Add(editInstrumentMainLabel);
        FormBorderStyle = FormBorderStyle.None;
        Name = "EditInstrumentForm";
        Text = "EditInstrumentForm";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)instrumentPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label editInstrumentMainLabel;
    private TextBox instrumentNameInput;
    private GroupBox groupBox1;
    private Label label1;
    private PictureBox instrumentPictureBox;
    private Label label7;
    private TextBox instrumentPriceInput;
    private Label label6;
    private ComboBox instrumentTypeSelect;
    private ComboBox gostsSelect;
    private Label label9;
    private Label label8;
    private Button actionButton;
    private Label label10;
    private TextBox descInput;
    private ComboBox currencySelect;
}