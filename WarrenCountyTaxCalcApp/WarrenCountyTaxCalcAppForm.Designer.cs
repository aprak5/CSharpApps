namespace WarrenCountyTaxCalcApp
{
    partial class WarrenCountyTaxCalcAppForm
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
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.calcStateTaxLabel = new System.Windows.Forms.Label();
            this.calcCountyTaxLabel = new System.Windows.Forms.Label();
            this.countyTaxLabel = new System.Windows.Forms.Label();
            this.calcSchoolTaxLabel = new System.Windows.Forms.Label();
            this.schoolTaxLabel = new System.Windows.Forms.Label();
            this.calcAmbulanceTaxLabel = new System.Windows.Forms.Label();
            this.ambulanceTaxLabel = new System.Windows.Forms.Label();
            this.calcHealthTaxLabel = new System.Windows.Forms.Label();
            this.healthTaxLabel = new System.Windows.Forms.Label();
            this.calcLibraryTaxLabel = new System.Windows.Forms.Label();
            this.libraryTaxLabel = new System.Windows.Forms.Label();
            this.calcSoilTaxLabel = new System.Windows.Forms.Label();
            this.soilTaxLabel = new System.Windows.Forms.Label();
            this.propertyValLabel = new System.Windows.Forms.Label();
            this.propertyValTextBox = new System.Windows.Forms.TextBox();
            this.stateSalesTaxRatesGroupBox = new System.Windows.Forms.GroupBox();
            this.thirdTaxRateRadioButton = new System.Windows.Forms.RadioButton();
            this.secondTaxRateRadioButton = new System.Windows.Forms.RadioButton();
            this.firstTaxRateRadioButton = new System.Windows.Forms.RadioButton();
            this.percentIncreaseCheckBox = new System.Windows.Forms.CheckBox();
            this.propertyTaxesLabel = new System.Windows.Forms.Label();
            this.calcTotalPropertyTaxesListBox = new System.Windows.Forms.ListBox();
            this.stateSalesTaxRatesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(156, 493);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(81, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(294, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.Location = new System.Drawing.Point(322, 37);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(64, 16);
            this.stateTaxLabel.TabIndex = 2;
            this.stateTaxLabel.Text = "State tax: ";
            // 
            // calcStateTaxLabel
            // 
            this.calcStateTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcStateTaxLabel.Location = new System.Drawing.Point(442, 36);
            this.calcStateTaxLabel.Name = "calcStateTaxLabel";
            this.calcStateTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcStateTaxLabel.TabIndex = 3;
            // 
            // calcCountyTaxLabel
            // 
            this.calcCountyTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcCountyTaxLabel.Location = new System.Drawing.Point(442, 102);
            this.calcCountyTaxLabel.Name = "calcCountyTaxLabel";
            this.calcCountyTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcCountyTaxLabel.TabIndex = 5;
            // 
            // countyTaxLabel
            // 
            this.countyTaxLabel.AutoSize = true;
            this.countyTaxLabel.Location = new System.Drawing.Point(322, 103);
            this.countyTaxLabel.Name = "countyTaxLabel";
            this.countyTaxLabel.Size = new System.Drawing.Size(74, 16);
            this.countyTaxLabel.TabIndex = 4;
            this.countyTaxLabel.Text = "County tax: ";
            // 
            // calcSchoolTaxLabel
            // 
            this.calcSchoolTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcSchoolTaxLabel.Location = new System.Drawing.Point(442, 164);
            this.calcSchoolTaxLabel.Name = "calcSchoolTaxLabel";
            this.calcSchoolTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcSchoolTaxLabel.TabIndex = 7;
            // 
            // schoolTaxLabel
            // 
            this.schoolTaxLabel.AutoSize = true;
            this.schoolTaxLabel.Location = new System.Drawing.Point(322, 165);
            this.schoolTaxLabel.Name = "schoolTaxLabel";
            this.schoolTaxLabel.Size = new System.Drawing.Size(75, 16);
            this.schoolTaxLabel.TabIndex = 6;
            this.schoolTaxLabel.Text = "School tax: ";
            // 
            // calcAmbulanceTaxLabel
            // 
            this.calcAmbulanceTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcAmbulanceTaxLabel.Location = new System.Drawing.Point(442, 227);
            this.calcAmbulanceTaxLabel.Name = "calcAmbulanceTaxLabel";
            this.calcAmbulanceTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcAmbulanceTaxLabel.TabIndex = 9;
            // 
            // ambulanceTaxLabel
            // 
            this.ambulanceTaxLabel.AutoSize = true;
            this.ambulanceTaxLabel.Location = new System.Drawing.Point(322, 228);
            this.ambulanceTaxLabel.Name = "ambulanceTaxLabel";
            this.ambulanceTaxLabel.Size = new System.Drawing.Size(101, 16);
            this.ambulanceTaxLabel.TabIndex = 8;
            this.ambulanceTaxLabel.Text = "Ambulance tax: ";
            // 
            // calcHealthTaxLabel
            // 
            this.calcHealthTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcHealthTaxLabel.Location = new System.Drawing.Point(442, 285);
            this.calcHealthTaxLabel.Name = "calcHealthTaxLabel";
            this.calcHealthTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcHealthTaxLabel.TabIndex = 11;
            // 
            // healthTaxLabel
            // 
            this.healthTaxLabel.AutoSize = true;
            this.healthTaxLabel.Location = new System.Drawing.Point(322, 286);
            this.healthTaxLabel.Name = "healthTaxLabel";
            this.healthTaxLabel.Size = new System.Drawing.Size(72, 16);
            this.healthTaxLabel.TabIndex = 10;
            this.healthTaxLabel.Text = "Health tax: ";
            // 
            // calcLibraryTaxLabel
            // 
            this.calcLibraryTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcLibraryTaxLabel.Location = new System.Drawing.Point(442, 342);
            this.calcLibraryTaxLabel.Name = "calcLibraryTaxLabel";
            this.calcLibraryTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcLibraryTaxLabel.TabIndex = 13;
            // 
            // libraryTaxLabel
            // 
            this.libraryTaxLabel.AutoSize = true;
            this.libraryTaxLabel.Location = new System.Drawing.Point(322, 343);
            this.libraryTaxLabel.Name = "libraryTaxLabel";
            this.libraryTaxLabel.Size = new System.Drawing.Size(74, 16);
            this.libraryTaxLabel.TabIndex = 12;
            this.libraryTaxLabel.Text = "Library tax: ";
            // 
            // calcSoilTaxLabel
            // 
            this.calcSoilTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcSoilTaxLabel.Location = new System.Drawing.Point(442, 398);
            this.calcSoilTaxLabel.Name = "calcSoilTaxLabel";
            this.calcSoilTaxLabel.Size = new System.Drawing.Size(120, 30);
            this.calcSoilTaxLabel.TabIndex = 15;
            // 
            // soilTaxLabel
            // 
            this.soilTaxLabel.AutoSize = true;
            this.soilTaxLabel.Location = new System.Drawing.Point(322, 399);
            this.soilTaxLabel.Name = "soilTaxLabel";
            this.soilTaxLabel.Size = new System.Drawing.Size(56, 16);
            this.soilTaxLabel.TabIndex = 14;
            this.soilTaxLabel.Text = "Soil tax: ";
            // 
            // propertyValLabel
            // 
            this.propertyValLabel.AutoSize = true;
            this.propertyValLabel.Location = new System.Drawing.Point(34, 40);
            this.propertyValLabel.Name = "propertyValLabel";
            this.propertyValLabel.Size = new System.Drawing.Size(100, 16);
            this.propertyValLabel.TabIndex = 16;
            this.propertyValLabel.Text = "Property value: ";
            // 
            // propertyValTextBox
            // 
            this.propertyValTextBox.Location = new System.Drawing.Point(140, 37);
            this.propertyValTextBox.Name = "propertyValTextBox";
            this.propertyValTextBox.Size = new System.Drawing.Size(97, 22);
            this.propertyValTextBox.TabIndex = 17;
            this.propertyValTextBox.Click += new System.EventHandler(this.propertyValTextBox_Click);
            this.propertyValTextBox.TextChanged += new System.EventHandler(this.propertyValTextBox_TextChanged);
            this.propertyValTextBox.Enter += new System.EventHandler(this.propertyValTextBox_Enter);
            this.propertyValTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyValTextBox_KeyPress);
            // 
            // stateSalesTaxRatesGroupBox
            // 
            this.stateSalesTaxRatesGroupBox.Controls.Add(this.thirdTaxRateRadioButton);
            this.stateSalesTaxRatesGroupBox.Controls.Add(this.secondTaxRateRadioButton);
            this.stateSalesTaxRatesGroupBox.Controls.Add(this.firstTaxRateRadioButton);
            this.stateSalesTaxRatesGroupBox.Location = new System.Drawing.Point(37, 117);
            this.stateSalesTaxRatesGroupBox.Name = "stateSalesTaxRatesGroupBox";
            this.stateSalesTaxRatesGroupBox.Size = new System.Drawing.Size(200, 117);
            this.stateSalesTaxRatesGroupBox.TabIndex = 18;
            this.stateSalesTaxRatesGroupBox.TabStop = false;
            this.stateSalesTaxRatesGroupBox.Text = "State Sales Tax Rates";
            // 
            // thirdTaxRateRadioButton
            // 
            this.thirdTaxRateRadioButton.AutoSize = true;
            this.thirdTaxRateRadioButton.Location = new System.Drawing.Point(29, 80);
            this.thirdTaxRateRadioButton.Name = "thirdTaxRateRadioButton";
            this.thirdTaxRateRadioButton.Size = new System.Drawing.Size(59, 20);
            this.thirdTaxRateRadioButton.TabIndex = 25;
            this.thirdTaxRateRadioButton.TabStop = true;
            this.thirdTaxRateRadioButton.Text = "0.144";
            this.thirdTaxRateRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondTaxRateRadioButton
            // 
            this.secondTaxRateRadioButton.AutoSize = true;
            this.secondTaxRateRadioButton.Location = new System.Drawing.Point(29, 54);
            this.secondTaxRateRadioButton.Name = "secondTaxRateRadioButton";
            this.secondTaxRateRadioButton.Size = new System.Drawing.Size(59, 20);
            this.secondTaxRateRadioButton.TabIndex = 24;
            this.secondTaxRateRadioButton.TabStop = true;
            this.secondTaxRateRadioButton.Text = "0.134";
            this.secondTaxRateRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstTaxRateRadioButton
            // 
            this.firstTaxRateRadioButton.AutoSize = true;
            this.firstTaxRateRadioButton.Checked = true;
            this.firstTaxRateRadioButton.Location = new System.Drawing.Point(29, 28);
            this.firstTaxRateRadioButton.Name = "firstTaxRateRadioButton";
            this.firstTaxRateRadioButton.Size = new System.Drawing.Size(59, 20);
            this.firstTaxRateRadioButton.TabIndex = 23;
            this.firstTaxRateRadioButton.TabStop = true;
            this.firstTaxRateRadioButton.Text = "0.124";
            this.firstTaxRateRadioButton.UseVisualStyleBackColor = true;
            // 
            // percentIncreaseCheckBox
            // 
            this.percentIncreaseCheckBox.AutoSize = true;
            this.percentIncreaseCheckBox.Location = new System.Drawing.Point(37, 240);
            this.percentIncreaseCheckBox.Name = "percentIncreaseCheckBox";
            this.percentIncreaseCheckBox.Size = new System.Drawing.Size(110, 20);
            this.percentIncreaseCheckBox.TabIndex = 20;
            this.percentIncreaseCheckBox.Text = "1% increase?";
            this.percentIncreaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // propertyTaxesLabel
            // 
            this.propertyTaxesLabel.AutoSize = true;
            this.propertyTaxesLabel.Location = new System.Drawing.Point(34, 315);
            this.propertyTaxesLabel.Name = "propertyTaxesLabel";
            this.propertyTaxesLabel.Size = new System.Drawing.Size(99, 16);
            this.propertyTaxesLabel.TabIndex = 21;
            this.propertyTaxesLabel.Text = "Property taxes: ";
            // 
            // calcTotalPropertyTaxesListBox
            // 
            this.calcTotalPropertyTaxesListBox.FormattingEnabled = true;
            this.calcTotalPropertyTaxesListBox.ItemHeight = 16;
            this.calcTotalPropertyTaxesListBox.Location = new System.Drawing.Point(37, 334);
            this.calcTotalPropertyTaxesListBox.Name = "calcTotalPropertyTaxesListBox";
            this.calcTotalPropertyTaxesListBox.Size = new System.Drawing.Size(200, 100);
            this.calcTotalPropertyTaxesListBox.TabIndex = 22;
            // 
            // WarrenCountyTaxCalcAppForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(595, 546);
            this.Controls.Add(this.calcTotalPropertyTaxesListBox);
            this.Controls.Add(this.propertyTaxesLabel);
            this.Controls.Add(this.percentIncreaseCheckBox);
            this.Controls.Add(this.stateSalesTaxRatesGroupBox);
            this.Controls.Add(this.propertyValTextBox);
            this.Controls.Add(this.propertyValLabel);
            this.Controls.Add(this.calcSoilTaxLabel);
            this.Controls.Add(this.soilTaxLabel);
            this.Controls.Add(this.calcLibraryTaxLabel);
            this.Controls.Add(this.libraryTaxLabel);
            this.Controls.Add(this.calcHealthTaxLabel);
            this.Controls.Add(this.healthTaxLabel);
            this.Controls.Add(this.calcAmbulanceTaxLabel);
            this.Controls.Add(this.ambulanceTaxLabel);
            this.Controls.Add(this.calcSchoolTaxLabel);
            this.Controls.Add(this.schoolTaxLabel);
            this.Controls.Add(this.calcCountyTaxLabel);
            this.Controls.Add(this.countyTaxLabel);
            this.Controls.Add(this.calcStateTaxLabel);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Name = "WarrenCountyTaxCalcAppForm";
            this.Text = "Warren County Tax Calculator";
            this.stateSalesTaxRatesGroupBox.ResumeLayout(false);
            this.stateSalesTaxRatesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label calcStateTaxLabel;
        private System.Windows.Forms.Label calcCountyTaxLabel;
        private System.Windows.Forms.Label countyTaxLabel;
        private System.Windows.Forms.Label calcSchoolTaxLabel;
        private System.Windows.Forms.Label schoolTaxLabel;
        private System.Windows.Forms.Label calcAmbulanceTaxLabel;
        private System.Windows.Forms.Label ambulanceTaxLabel;
        private System.Windows.Forms.Label calcHealthTaxLabel;
        private System.Windows.Forms.Label healthTaxLabel;
        private System.Windows.Forms.Label calcLibraryTaxLabel;
        private System.Windows.Forms.Label libraryTaxLabel;
        private System.Windows.Forms.Label calcSoilTaxLabel;
        private System.Windows.Forms.Label soilTaxLabel;
        private System.Windows.Forms.Label propertyValLabel;
        private System.Windows.Forms.TextBox propertyValTextBox;
        private System.Windows.Forms.GroupBox stateSalesTaxRatesGroupBox;
        private System.Windows.Forms.CheckBox percentIncreaseCheckBox;
        private System.Windows.Forms.Label propertyTaxesLabel;
        private System.Windows.Forms.ListBox calcTotalPropertyTaxesListBox;
        private System.Windows.Forms.RadioButton thirdTaxRateRadioButton;
        private System.Windows.Forms.RadioButton secondTaxRateRadioButton;
        private System.Windows.Forms.RadioButton firstTaxRateRadioButton;
    }
}

