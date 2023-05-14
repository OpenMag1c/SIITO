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
        actionButton = new Button();
        label9 = new Label();
        label8 = new Label();
        instrumentTypeSelect = new ComboBox();
        gostsSelect = new ComboBox();
        label7 = new Label();
        instrumentPriceInput = new TextBox();
        label6 = new Label();
        instrumentPictureBox = new PictureBox();
        label5 = new Label();
        instrumentCodeInput = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        numericUpDown3 = new NumericUpDown();
        numericUpDown2 = new NumericUpDown();
        numericUpDown1 = new NumericUpDown();
        label1 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)instrumentPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
        groupBox1.Controls.Add(actionButton);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(instrumentTypeSelect);
        groupBox1.Controls.Add(gostsSelect);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(instrumentPriceInput);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(instrumentPictureBox);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(instrumentCodeInput);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(numericUpDown3);
        groupBox1.Controls.Add(numericUpDown2);
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(instrumentNameInput);
        groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox1.Location = new Point(92, 60);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(598, 497);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Instrument info";
        // 
        // actionButton
        // 
        actionButton.Location = new Point(450, 431);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(120, 39);
        actionButton.TabIndex = 19;
        actionButton.Text = "Создать";
        actionButton.UseVisualStyleBackColor = true;
        actionButton.Click += actionButton_Click;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label9.Location = new Point(22, 332);
        label9.Name = "label9";
        label9.Size = new Size(144, 23);
        label9.TabIndex = 18;
        label9.Text = "Тип инструмента";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label8.Location = new Point(22, 408);
        label8.Name = "label8";
        label8.Size = new Size(51, 23);
        label8.TabIndex = 17;
        label8.Text = "ГОСТ";
        // 
        // instrumentTypeSelect
        // 
        instrumentTypeSelect.FormattingEnabled = true;
        instrumentTypeSelect.Location = new Point(22, 358);
        instrumentTypeSelect.Name = "instrumentTypeSelect";
        instrumentTypeSelect.Size = new Size(237, 36);
        instrumentTypeSelect.TabIndex = 16;
        // 
        // gostsSelect
        // 
        gostsSelect.FormattingEnabled = true;
        gostsSelect.Location = new Point(22, 434);
        gostsSelect.Name = "gostsSelect";
        gostsSelect.Size = new Size(237, 36);
        gostsSelect.TabIndex = 15;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(22, 182);
        label7.Name = "label7";
        label7.Size = new Size(51, 23);
        label7.TabIndex = 14;
        label7.Text = "Цена";
        // 
        // instrumentPriceInput
        // 
        instrumentPriceInput.Location = new Point(22, 208);
        instrumentPriceInput.Name = "instrumentPriceInput";
        instrumentPriceInput.Size = new Size(125, 34);
        instrumentPriceInput.TabIndex = 13;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(328, 39);
        label6.Name = "label6";
        label6.Size = new Size(106, 23);
        label6.TabIndex = 12;
        label6.Text = "Фотография";
        // 
        // instrumentPictureBox
        // 
        instrumentPictureBox.BorderStyle = BorderStyle.FixedSingle;
        instrumentPictureBox.Location = new Point(333, 65);
        instrumentPictureBox.Name = "instrumentPictureBox";
        instrumentPictureBox.Size = new Size(237, 182);
        instrumentPictureBox.TabIndex = 11;
        instrumentPictureBox.TabStop = false;
        instrumentPictureBox.Click += instrumentPictureBox_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(22, 109);
        label5.Name = "label5";
        label5.Size = new Size(144, 23);
        label5.TabIndex = 10;
        label5.Text = "Код инструмента";
        // 
        // instrumentCodeInput
        // 
        instrumentCodeInput.Location = new Point(22, 135);
        instrumentCodeInput.Name = "instrumentCodeInput";
        instrumentCodeInput.Size = new Size(255, 34);
        instrumentCodeInput.TabIndex = 9;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(22, 256);
        label4.Name = "label4";
        label4.Size = new Size(100, 23);
        label4.TabIndex = 8;
        label4.Text = "Параметры";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(186, 282);
        label3.Name = "label3";
        label3.Size = new Size(21, 28);
        label3.TabIndex = 7;
        label3.Text = "x";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(92, 282);
        label2.Name = "label2";
        label2.Size = new Size(21, 28);
        label2.TabIndex = 6;
        label2.Text = "x";
        // 
        // numericUpDown3
        // 
        numericUpDown3.Location = new Point(211, 282);
        numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new Size(66, 34);
        numericUpDown3.TabIndex = 5;
        numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(116, 282);
        numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(66, 34);
        numericUpDown2.TabIndex = 4;
        numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(22, 282);
        numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(66, 34);
        numericUpDown1.TabIndex = 3;
        numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label editInstrumentMainLabel;
    private TextBox instrumentNameInput;
    private GroupBox groupBox1;
    private Label label1;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown2;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox instrumentCodeInput;
    private PictureBox instrumentPictureBox;
    private Label label7;
    private TextBox instrumentPriceInput;
    private Label label6;
    private ComboBox instrumentTypeSelect;
    private ComboBox gostsSelect;
    private Label label9;
    private Label label8;
    private Button actionButton;
}