namespace FactorsApp
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
            this.num1Label = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.beginningNumberTextBox = new System.Windows.Forms.TextBox();
            this.displayListView = new System.Windows.Forms.ListView();
            this.exitButton = new System.Windows.Forms.Button();
            this.endingNumberTextBox = new System.Windows.Forms.TextBox();
            this.num2Label = new System.Windows.Forms.Label();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.factors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.greatestFactorsLabel = new System.Windows.Forms.Label();
            this.greatestFactorsNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Label.Location = new System.Drawing.Point(100, 68);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(134, 20);
            this.num1Label.TabIndex = 0;
            this.num1Label.Text = "Beginning number:";
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(486, 485);
            this.displayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 40);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "&Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // beginningNumberTextBox
            // 
            this.beginningNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginningNumberTextBox.Location = new System.Drawing.Point(260, 64);
            this.beginningNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beginningNumberTextBox.Name = "beginningNumberTextBox";
            this.beginningNumberTextBox.Size = new System.Drawing.Size(100, 27);
            this.beginningNumberTextBox.TabIndex = 2;
            this.beginningNumberTextBox.Click += new System.EventHandler(this.beginningNumberTextBox_Click);
            this.beginningNumberTextBox.TextChanged += new System.EventHandler(this.beginningNumberTextBox_TextChanged);
            this.beginningNumberTextBox.Enter += new System.EventHandler(this.beginningNumberTextBox_Enter);
            this.beginningNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.beginningNumberTextBox_KeyPress);
            // 
            // displayListView
            // 
            this.displayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.factors});
            this.displayListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.displayListView.HideSelection = false;
            this.displayListView.Location = new System.Drawing.Point(44, 136);
            this.displayListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(712, 318);
            this.displayListView.TabIndex = 3;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.View = System.Windows.Forms.View.Details;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(630, 485);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // endingNumberTextBox
            // 
            this.endingNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingNumberTextBox.Location = new System.Drawing.Point(605, 64);
            this.endingNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endingNumberTextBox.Name = "endingNumberTextBox";
            this.endingNumberTextBox.Size = new System.Drawing.Size(100, 27);
            this.endingNumberTextBox.TabIndex = 3;
            this.endingNumberTextBox.Click += new System.EventHandler(this.endingNumberTextBox_Click);
            this.endingNumberTextBox.TextChanged += new System.EventHandler(this.endingNumberTextBox_TextChanged);
            this.endingNumberTextBox.Enter += new System.EventHandler(this.endingNumberTextBox_Enter);
            this.endingNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endingNumberTextBox_KeyPress);
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Label.Location = new System.Drawing.Point(457, 68);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(113, 20);
            this.num2Label.TabIndex = 5;
            this.num2Label.Text = "Ending number:";
            // 
            // number
            // 
            this.number.Text = "Number";
            this.number.Width = 175;
            // 
            // factors
            // 
            this.factors.Text = "Factors";
            this.factors.Width = 533;
            // 
            // greatestFactorsLabel
            // 
            this.greatestFactorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greatestFactorsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greatestFactorsLabel.Location = new System.Drawing.Point(260, 494);
            this.greatestFactorsLabel.Name = "greatestFactorsLabel";
            this.greatestFactorsLabel.Size = new System.Drawing.Size(157, 28);
            this.greatestFactorsLabel.TabIndex = 6;
            // 
            // greatestFactorsNumLabel
            // 
            this.greatestFactorsNumLabel.AutoSize = true;
            this.greatestFactorsNumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greatestFactorsNumLabel.Location = new System.Drawing.Point(50, 495);
            this.greatestFactorsNumLabel.Name = "greatestFactorsNumLabel";
            this.greatestFactorsNumLabel.Size = new System.Drawing.Size(184, 20);
            this.greatestFactorsNumLabel.TabIndex = 7;
            this.greatestFactorsNumLabel.Text = "Number with most factors:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.displayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.greatestFactorsNumLabel);
            this.Controls.Add(this.greatestFactorsLabel);
            this.Controls.Add(this.endingNumberTextBox);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayListView);
            this.Controls.Add(this.beginningNumberTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.num1Label);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Greatest Common Factor Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox beginningNumberTextBox;
        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox endingNumberTextBox;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader factors;
        private System.Windows.Forms.Label greatestFactorsLabel;
        private System.Windows.Forms.Label greatestFactorsNumLabel;
    }
}

