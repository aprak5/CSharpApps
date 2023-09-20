namespace VehicleLoanCalculatorApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.descLabel = new System.Windows.Forms.Label();
            this.vehicleCalcLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.calcLoanButton = new System.Windows.Forms.Button();
            this.acceptLoanButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayLoansButton = new System.Windows.Forms.Button();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.annualAPRLabel = new System.Windows.Forms.Label();
            this.annualAPRComboBox = new System.Windows.Forms.ComboBox();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.loanMonthsGroupBox = new System.Windows.Forms.GroupBox();
            this.twelveMonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyFourMonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.eighteenMonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.sixMonthsRadioButton = new System.Windows.Forms.RadioButton();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.principalLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.totalsGroupBox = new System.Windows.Forms.GroupBox();
            this.calcTotalLoansLabel = new System.Windows.Forms.Label();
            this.totalLoansLabel = new System.Windows.Forms.Label();
            this.calcTotalInterestLabel = new System.Windows.Forms.Label();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.amortizationListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.loanMonthsGroupBox.SuspendLayout();
            this.totalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.descLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descLabel.Location = new System.Drawing.Point(163, 28);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(293, 23);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Academic and Industry Collaboration";
            // 
            // vehicleCalcLabel
            // 
            this.vehicleCalcLabel.AutoSize = true;
            this.vehicleCalcLabel.BackColor = System.Drawing.SystemColors.Control;
            this.vehicleCalcLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vehicleCalcLabel.Location = new System.Drawing.Point(198, 51);
            this.vehicleCalcLabel.Name = "vehicleCalcLabel";
            this.vehicleCalcLabel.Size = new System.Drawing.Size(213, 28);
            this.vehicleCalcLabel.TabIndex = 1;
            this.vehicleCalcLabel.Text = "Vehicle Loan Calculator";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(693, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(120, 124);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // calcLoanButton
            // 
            this.calcLoanButton.Location = new System.Drawing.Point(693, 129);
            this.calcLoanButton.Name = "calcLoanButton";
            this.calcLoanButton.Size = new System.Drawing.Size(120, 99);
            this.calcLoanButton.TabIndex = 17;
            this.calcLoanButton.Text = "&Calculate Loan";
            this.calcLoanButton.UseVisualStyleBackColor = true;
            this.calcLoanButton.Click += new System.EventHandler(this.calcLoanButton_Click);
            // 
            // acceptLoanButton
            // 
            this.acceptLoanButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.acceptLoanButton.Location = new System.Drawing.Point(693, 225);
            this.acceptLoanButton.Name = "acceptLoanButton";
            this.acceptLoanButton.Size = new System.Drawing.Size(120, 99);
            this.acceptLoanButton.TabIndex = 18;
            this.acceptLoanButton.Text = "&Accept Loan";
            this.acceptLoanButton.UseVisualStyleBackColor = false;
            this.acceptLoanButton.Click += new System.EventHandler(this.acceptLoanButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(693, 417);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 99);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayLoansButton
            // 
            this.displayLoansButton.Location = new System.Drawing.Point(693, 321);
            this.displayLoansButton.Name = "displayLoansButton";
            this.displayLoansButton.Size = new System.Drawing.Size(120, 99);
            this.displayLoansButton.TabIndex = 19;
            this.displayLoansButton.Text = "&Display All Loans";
            this.displayLoansButton.UseVisualStyleBackColor = true;
            this.displayLoansButton.Click += new System.EventHandler(this.displayLoansButton_Click);
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Location = new System.Drawing.Point(32, 103);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(99, 20);
            this.loanAmountLabel.TabIndex = 7;
            this.loanAmountLabel.Text = "Loan amount:";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(165, 100);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(100, 27);
            this.loanAmountTextBox.TabIndex = 8;
            this.loanAmountTextBox.Click += new System.EventHandler(this.loanAmountTextBox_Click);
            this.loanAmountTextBox.TextChanged += new System.EventHandler(this.loanAmountTextBox_TextChanged);
            this.loanAmountTextBox.Enter += new System.EventHandler(this.loanAmountTextBox_Enter);
            this.loanAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanAmountTextBox_KeyPress);
            // 
            // annualAPRLabel
            // 
            this.annualAPRLabel.AutoSize = true;
            this.annualAPRLabel.Location = new System.Drawing.Point(32, 143);
            this.annualAPRLabel.Name = "annualAPRLabel";
            this.annualAPRLabel.Size = new System.Drawing.Size(115, 20);
            this.annualAPRLabel.TabIndex = 9;
            this.annualAPRLabel.Text = "Annual APR (%):";
            // 
            // annualAPRComboBox
            // 
            this.annualAPRComboBox.FormattingEnabled = true;
            this.annualAPRComboBox.Location = new System.Drawing.Point(165, 140);
            this.annualAPRComboBox.Name = "annualAPRComboBox";
            this.annualAPRComboBox.Size = new System.Drawing.Size(121, 28);
            this.annualAPRComboBox.TabIndex = 10;
            this.annualAPRComboBox.SelectedIndexChanged += new System.EventHandler(this.annualAPRComboBox_SelectedIndexChanged);
            this.annualAPRComboBox.TextChanged += new System.EventHandler(this.annualAPRComboBox_TextChanged);
            this.annualAPRComboBox.Click += new System.EventHandler(this.annualAPRComboBox_Click);
            this.annualAPRComboBox.Enter += new System.EventHandler(this.annualAPRComboBox_Enter);
            this.annualAPRComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.annualAPRComboBox_KeyPress);
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.Location = new System.Drawing.Point(36, 182);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(85, 24);
            this.rebateCheckBox.TabIndex = 11;
            this.rebateCheckBox.Text = "Rebate?";
            this.rebateCheckBox.UseVisualStyleBackColor = true;
            this.rebateCheckBox.CheckedChanged += new System.EventHandler(this.rebateCheckBox_CheckedChanged);
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Location = new System.Drawing.Point(165, 180);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(100, 27);
            this.rebateTextBox.TabIndex = 12;
            this.rebateTextBox.Click += new System.EventHandler(this.rebateTextBox_Click);
            this.rebateTextBox.TextChanged += new System.EventHandler(this.rebateTextBox_TextChanged);
            this.rebateTextBox.Enter += new System.EventHandler(this.rebateTextBox_Enter);
            this.rebateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebateTextBox_KeyPress);
            // 
            // loanMonthsGroupBox
            // 
            this.loanMonthsGroupBox.Controls.Add(this.twelveMonthsRadioButton);
            this.loanMonthsGroupBox.Controls.Add(this.twentyFourMonthsRadioButton);
            this.loanMonthsGroupBox.Controls.Add(this.eighteenMonthsRadioButton);
            this.loanMonthsGroupBox.Controls.Add(this.sixMonthsRadioButton);
            this.loanMonthsGroupBox.Location = new System.Drawing.Point(339, 100);
            this.loanMonthsGroupBox.Name = "loanMonthsGroupBox";
            this.loanMonthsGroupBox.Size = new System.Drawing.Size(200, 100);
            this.loanMonthsGroupBox.TabIndex = 13;
            this.loanMonthsGroupBox.TabStop = false;
            this.loanMonthsGroupBox.Text = "Loan Months";
            // 
            // twelveMonthsRadioButton
            // 
            this.twelveMonthsRadioButton.AutoSize = true;
            this.twelveMonthsRadioButton.Location = new System.Drawing.Point(16, 57);
            this.twelveMonthsRadioButton.Name = "twelveMonthsRadioButton";
            this.twelveMonthsRadioButton.Size = new System.Drawing.Size(46, 24);
            this.twelveMonthsRadioButton.TabIndex = 14;
            this.twelveMonthsRadioButton.TabStop = true;
            this.twelveMonthsRadioButton.Text = "12";
            this.twelveMonthsRadioButton.UseVisualStyleBackColor = true;
            this.twelveMonthsRadioButton.CheckedChanged += new System.EventHandler(this.twelveMonthsRadioButton_CheckedChanged);
            // 
            // twentyFourMonthsRadioButton
            // 
            this.twentyFourMonthsRadioButton.AutoSize = true;
            this.twentyFourMonthsRadioButton.Location = new System.Drawing.Point(81, 57);
            this.twentyFourMonthsRadioButton.Name = "twentyFourMonthsRadioButton";
            this.twentyFourMonthsRadioButton.Size = new System.Drawing.Size(46, 24);
            this.twentyFourMonthsRadioButton.TabIndex = 16;
            this.twentyFourMonthsRadioButton.TabStop = true;
            this.twentyFourMonthsRadioButton.Text = "24";
            this.twentyFourMonthsRadioButton.UseVisualStyleBackColor = true;
            this.twentyFourMonthsRadioButton.CheckedChanged += new System.EventHandler(this.twentyFourMonthsRadioButton_CheckedChanged);
            // 
            // eighteenMonthsRadioButton
            // 
            this.eighteenMonthsRadioButton.AutoSize = true;
            this.eighteenMonthsRadioButton.Location = new System.Drawing.Point(81, 27);
            this.eighteenMonthsRadioButton.Name = "eighteenMonthsRadioButton";
            this.eighteenMonthsRadioButton.Size = new System.Drawing.Size(46, 24);
            this.eighteenMonthsRadioButton.TabIndex = 15;
            this.eighteenMonthsRadioButton.TabStop = true;
            this.eighteenMonthsRadioButton.Text = "18";
            this.eighteenMonthsRadioButton.UseVisualStyleBackColor = true;
            this.eighteenMonthsRadioButton.CheckedChanged += new System.EventHandler(this.eighteenMonthsRadioButton_CheckedChanged);
            // 
            // sixMonthsRadioButton
            // 
            this.sixMonthsRadioButton.AutoSize = true;
            this.sixMonthsRadioButton.Checked = true;
            this.sixMonthsRadioButton.Location = new System.Drawing.Point(16, 27);
            this.sixMonthsRadioButton.Name = "sixMonthsRadioButton";
            this.sixMonthsRadioButton.Size = new System.Drawing.Size(38, 24);
            this.sixMonthsRadioButton.TabIndex = 13;
            this.sixMonthsRadioButton.TabStop = true;
            this.sixMonthsRadioButton.Text = "6";
            this.sixMonthsRadioButton.UseVisualStyleBackColor = true;
            this.sixMonthsRadioButton.CheckedChanged += new System.EventHandler(this.sixMonthsRadioButton_CheckedChanged);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(549, 250);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(64, 20);
            this.balanceLabel.TabIndex = 14;
            this.balanceLabel.Text = "Balance:";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(416, 250);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(68, 20);
            this.paymentLabel.TabIndex = 15;
            this.paymentLabel.Text = "Payment:";
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(281, 250);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(69, 20);
            this.principalLabel.TabIndex = 16;
            this.principalLabel.Text = "Principal:";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(163, 250);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(61, 20);
            this.interestLabel.TabIndex = 17;
            this.interestLabel.Text = "Interest:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(32, 250);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(55, 20);
            this.monthLabel.TabIndex = 18;
            this.monthLabel.Text = "Month:";
            // 
            // totalsGroupBox
            // 
            this.totalsGroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalsGroupBox.Controls.Add(this.calcTotalLoansLabel);
            this.totalsGroupBox.Controls.Add(this.totalLoansLabel);
            this.totalsGroupBox.Controls.Add(this.calcTotalInterestLabel);
            this.totalsGroupBox.Controls.Add(this.totalInterestLabel);
            this.totalsGroupBox.Location = new System.Drawing.Point(693, 517);
            this.totalsGroupBox.Name = "totalsGroupBox";
            this.totalsGroupBox.Size = new System.Drawing.Size(120, 173);
            this.totalsGroupBox.TabIndex = 19;
            this.totalsGroupBox.TabStop = false;
            this.totalsGroupBox.Text = "Totals";
            // 
            // calcTotalLoansLabel
            // 
            this.calcTotalLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcTotalLoansLabel.Location = new System.Drawing.Point(10, 124);
            this.calcTotalLoansLabel.Name = "calcTotalLoansLabel";
            this.calcTotalLoansLabel.Size = new System.Drawing.Size(93, 27);
            this.calcTotalLoansLabel.TabIndex = 23;
            // 
            // totalLoansLabel
            // 
            this.totalLoansLabel.AutoSize = true;
            this.totalLoansLabel.Location = new System.Drawing.Point(6, 95);
            this.totalLoansLabel.Name = "totalLoansLabel";
            this.totalLoansLabel.Size = new System.Drawing.Size(54, 20);
            this.totalLoansLabel.TabIndex = 22;
            this.totalLoansLabel.Text = "Loans: ";
            // 
            // calcTotalInterestLabel
            // 
            this.calcTotalInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcTotalInterestLabel.Location = new System.Drawing.Point(10, 52);
            this.calcTotalInterestLabel.Name = "calcTotalInterestLabel";
            this.calcTotalInterestLabel.Size = new System.Drawing.Size(93, 27);
            this.calcTotalInterestLabel.TabIndex = 21;
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.AutoSize = true;
            this.totalInterestLabel.Location = new System.Drawing.Point(6, 23);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(65, 20);
            this.totalInterestLabel.TabIndex = 20;
            this.totalInterestLabel.Text = "Interest: ";
            // 
            // amortizationListBox
            // 
            this.amortizationListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amortizationListBox.FormattingEnabled = true;
            this.amortizationListBox.ItemHeight = 17;
            this.amortizationListBox.Location = new System.Drawing.Point(36, 276);
            this.amortizationListBox.Name = "amortizationListBox";
            this.amortizationListBox.Size = new System.Drawing.Size(632, 378);
            this.amortizationListBox.TabIndex = 20;
            this.amortizationListBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calcLoanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(825, 697);
            this.Controls.Add(this.amortizationListBox);
            this.Controls.Add(this.totalsGroupBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.loanMonthsGroupBox);
            this.Controls.Add(this.rebateTextBox);
            this.Controls.Add(this.rebateCheckBox);
            this.Controls.Add(this.annualAPRComboBox);
            this.Controls.Add(this.annualAPRLabel);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayLoansButton);
            this.Controls.Add(this.acceptLoanButton);
            this.Controls.Add(this.calcLoanButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.vehicleCalcLabel);
            this.Controls.Add(this.descLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Vehicle Loan Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.loanMonthsGroupBox.ResumeLayout(false);
            this.loanMonthsGroupBox.PerformLayout();
            this.totalsGroupBox.ResumeLayout(false);
            this.totalsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label vehicleCalcLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button calcLoanButton;
        private System.Windows.Forms.Button acceptLoanButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayLoansButton;
        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.Label annualAPRLabel;
        private System.Windows.Forms.ComboBox annualAPRComboBox;
        private System.Windows.Forms.CheckBox rebateCheckBox;
        private System.Windows.Forms.TextBox rebateTextBox;
        private System.Windows.Forms.GroupBox loanMonthsGroupBox;
        private System.Windows.Forms.RadioButton twelveMonthsRadioButton;
        private System.Windows.Forms.RadioButton twentyFourMonthsRadioButton;
        private System.Windows.Forms.RadioButton eighteenMonthsRadioButton;
        private System.Windows.Forms.RadioButton sixMonthsRadioButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.GroupBox totalsGroupBox;
        private System.Windows.Forms.Label calcTotalLoansLabel;
        private System.Windows.Forms.Label totalLoansLabel;
        private System.Windows.Forms.Label calcTotalInterestLabel;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.ListBox amortizationListBox;
    }
}

