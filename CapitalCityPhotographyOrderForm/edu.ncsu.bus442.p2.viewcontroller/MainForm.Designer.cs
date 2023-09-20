namespace edu.ncsu.bus442.p2.viewcontroller
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.packageTypeLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.packageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.listViewLabel = new System.Windows.Forms.Label();
            this.packageListView = new System.Windows.Forms.ListView();
            this.packageNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saleAmountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.calcTotalSalesLabel = new System.Windows.Forms.Label();
            this.calcBestSellingPackageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcTopSellingEmployeeLabel = new System.Windows.Forms.Label();
            this.topSellingEmployeeLabel = new System.Windows.Forms.Label();
            this.addSalesButton = new System.Windows.Forms.Button();
            this.displaySalesButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addSalesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.displaySalesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.readFileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addSalesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySalesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Script MT Bold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(129, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 90);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Capital City Photography Order Form";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packageTypeLabel
            // 
            this.packageTypeLabel.AutoSize = true;
            this.packageTypeLabel.Location = new System.Drawing.Point(10, 126);
            this.packageTypeLabel.Name = "packageTypeLabel";
            this.packageTypeLabel.Size = new System.Drawing.Size(157, 20);
            this.packageTypeLabel.TabIndex = 1;
            this.packageTypeLabel.Text = "Select a package type:";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(225, 126);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(142, 20);
            this.employeeLabel.TabIndex = 2;
            this.employeeLabel.Text = "Select an employee:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(446, 126);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(129, 20);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Enter the quantity:";
            // 
            // packageTypeComboBox
            // 
            this.packageTypeComboBox.FormattingEnabled = true;
            this.packageTypeComboBox.Location = new System.Drawing.Point(12, 148);
            this.packageTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.packageTypeComboBox.Name = "packageTypeComboBox";
            this.packageTypeComboBox.Size = new System.Drawing.Size(177, 28);
            this.packageTypeComboBox.TabIndex = 4;
            this.packageTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.packageTypeComboBox_SelectedIndexChanged);
            this.packageTypeComboBox.TextChanged += new System.EventHandler(this.packageTypeComboBox_TextChanged);
            this.packageTypeComboBox.Click += new System.EventHandler(this.packageTypeComboBox_Click);
            this.packageTypeComboBox.Enter += new System.EventHandler(this.packageTypeComboBox_Enter);
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(228, 148);
            this.employeeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(160, 28);
            this.employeeComboBox.TabIndex = 5;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            this.employeeComboBox.TextChanged += new System.EventHandler(this.employeeComboBox_TextChanged);
            this.employeeComboBox.Click += new System.EventHandler(this.employeeComboBox_Click);
            this.employeeComboBox.Enter += new System.EventHandler(this.employeeComboBox_Enter);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(449, 148);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 27);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.Click += new System.EventHandler(this.quantityTextBox_Click);
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            this.quantityTextBox.Enter += new System.EventHandler(this.quantityTextBox_Enter);
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // listViewLabel
            // 
            this.listViewLabel.AutoSize = true;
            this.listViewLabel.Location = new System.Drawing.Point(12, 193);
            this.listViewLabel.Name = "listViewLabel";
            this.listViewLabel.Size = new System.Drawing.Size(154, 20);
            this.listViewLabel.TabIndex = 7;
            this.listViewLabel.Text = "Total for all packages:";
            // 
            // packageListView
            // 
            this.packageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.packageNameHeader,
            this.saleAmountHeader});
            this.packageListView.HideSelection = false;
            this.packageListView.Location = new System.Drawing.Point(15, 216);
            this.packageListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.packageListView.Name = "packageListView";
            this.packageListView.Size = new System.Drawing.Size(555, 345);
            this.packageListView.TabIndex = 8;
            this.packageListView.TabStop = false;
            this.packageListView.UseCompatibleStateImageBehavior = false;
            this.packageListView.View = System.Windows.Forms.View.Details;
            // 
            // packageNameHeader
            // 
            this.packageNameHeader.Text = "Package Name";
            this.packageNameHeader.Width = 226;
            // 
            // saleAmountHeader
            // 
            this.saleAmountHeader.Text = "Sale Amount";
            this.saleAmountHeader.Width = 323;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Location = new System.Drawing.Point(12, 571);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(81, 20);
            this.totalSalesLabel.TabIndex = 9;
            this.totalSalesLabel.Text = "Total sales:";
            // 
            // calcTotalSalesLabel
            // 
            this.calcTotalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcTotalSalesLabel.Location = new System.Drawing.Point(16, 593);
            this.calcTotalSalesLabel.Name = "calcTotalSalesLabel";
            this.calcTotalSalesLabel.Size = new System.Drawing.Size(151, 37);
            this.calcTotalSalesLabel.TabIndex = 10;
            // 
            // calcBestSellingPackageLabel
            // 
            this.calcBestSellingPackageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcBestSellingPackageLabel.Location = new System.Drawing.Point(290, 593);
            this.calcBestSellingPackageLabel.Name = "calcBestSellingPackageLabel";
            this.calcBestSellingPackageLabel.Size = new System.Drawing.Size(263, 37);
            this.calcBestSellingPackageLabel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Best-selling package:";
            // 
            // calcTopSellingEmployeeLabel
            // 
            this.calcTopSellingEmployeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcTopSellingEmployeeLabel.Location = new System.Drawing.Point(16, 670);
            this.calcTopSellingEmployeeLabel.Name = "calcTopSellingEmployeeLabel";
            this.calcTopSellingEmployeeLabel.Size = new System.Drawing.Size(537, 37);
            this.calcTopSellingEmployeeLabel.TabIndex = 14;
            // 
            // topSellingEmployeeLabel
            // 
            this.topSellingEmployeeLabel.AutoSize = true;
            this.topSellingEmployeeLabel.Location = new System.Drawing.Point(12, 647);
            this.topSellingEmployeeLabel.Name = "topSellingEmployeeLabel";
            this.topSellingEmployeeLabel.Size = new System.Drawing.Size(156, 20);
            this.topSellingEmployeeLabel.TabIndex = 13;
            this.topSellingEmployeeLabel.Text = "Top-selling employee:";
            // 
            // addSalesButton
            // 
            this.addSalesButton.Location = new System.Drawing.Point(12, 726);
            this.addSalesButton.Name = "addSalesButton";
            this.addSalesButton.Size = new System.Drawing.Size(99, 43);
            this.addSalesButton.TabIndex = 15;
            this.addSalesButton.Text = "&Add Sales";
            this.addSalesToolTip.SetToolTip(this.addSalesButton, "Add Sales");
            this.addSalesButton.UseVisualStyleBackColor = true;
            this.addSalesButton.Click += new System.EventHandler(this.addSalesButton_Click);
            // 
            // displaySalesButton
            // 
            this.displaySalesButton.Location = new System.Drawing.Point(124, 726);
            this.displaySalesButton.Name = "displaySalesButton";
            this.displaySalesButton.Size = new System.Drawing.Size(114, 43);
            this.displaySalesButton.TabIndex = 16;
            this.displaySalesButton.Text = "&Display Sales";
            this.displaySalesToolTip.SetToolTip(this.displaySalesButton, "Display Sales");
            this.displaySalesButton.UseVisualStyleBackColor = true;
            this.displaySalesButton.Click += new System.EventHandler(this.displaySalesButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(364, 726);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(99, 43);
            this.saveFileButton.TabIndex = 18;
            this.saveFileButton.Text = "&Save File";
            this.saveFileToolTip.SetToolTip(this.saveFileButton, "Save File");
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(251, 726);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(99, 43);
            this.readFileButton.TabIndex = 17;
            this.readFileButton.Text = "&Read File";
            this.readFileToolTip.SetToolTip(this.readFileButton, "Read File");
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(476, 726);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 43);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "E&xit";
            this.exitToolTip.SetToolTip(this.exitButton, "Exit");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonMenuStrip
            // 
            this.buttonMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buttonMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalesMenuItem,
            this.displaySalesMenuItem,
            this.saveFileMenuItem,
            this.readFileMenuItem,
            this.exitMenuItem});
            this.buttonMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuStrip.Name = "buttonMenuStrip";
            this.buttonMenuStrip.ShowItemToolTips = true;
            this.buttonMenuStrip.Size = new System.Drawing.Size(585, 28);
            this.buttonMenuStrip.TabIndex = 20;
            // 
            // addSalesMenuItem
            // 
            this.addSalesMenuItem.Name = "addSalesMenuItem";
            this.addSalesMenuItem.Size = new System.Drawing.Size(89, 24);
            this.addSalesMenuItem.Text = "&Add Sales";
            this.addSalesMenuItem.ToolTipText = "Add Sales";
            this.addSalesMenuItem.Click += new System.EventHandler(this.addSalesButton_Click);
            // 
            // displaySalesMenuItem
            // 
            this.displaySalesMenuItem.Name = "displaySalesMenuItem";
            this.displaySalesMenuItem.Size = new System.Drawing.Size(110, 24);
            this.displaySalesMenuItem.Text = "&Display Sales";
            this.displaySalesMenuItem.ToolTipText = "Display Sales";
            this.displaySalesMenuItem.Click += new System.EventHandler(this.displaySalesButton_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(81, 24);
            this.saveFileMenuItem.Text = "&Save File";
            this.saveFileMenuItem.ToolTipText = "Save File";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // readFileMenuItem
            // 
            this.readFileMenuItem.Name = "readFileMenuItem";
            this.readFileMenuItem.Size = new System.Drawing.Size(84, 24);
            this.readFileMenuItem.Text = "&Read File";
            this.readFileMenuItem.ToolTipText = "Read File";
            this.readFileMenuItem.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.ToolTipText = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Comma Separated Value files (*.csv)|*.csv";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "photographyOrders.csv";
            this.saveFileDialog.Filter = "Comma Separated Value files (*.csv)|*.csv";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // MainForm
            // 
            this.AcceptButton = this.displaySalesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(585, 780);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.displaySalesButton);
            this.Controls.Add(this.addSalesButton);
            this.Controls.Add(this.calcTopSellingEmployeeLabel);
            this.Controls.Add(this.topSellingEmployeeLabel);
            this.Controls.Add(this.calcBestSellingPackageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcTotalSalesLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.packageListView);
            this.Controls.Add(this.listViewLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.packageTypeComboBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.packageTypeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buttonMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.buttonMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Capital City Photography, LLC";
            this.buttonMenuStrip.ResumeLayout(false);
            this.buttonMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label packageTypeLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox packageTypeComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label listViewLabel;
        private System.Windows.Forms.ListView packageListView;
        private System.Windows.Forms.ColumnHeader packageNameHeader;
        private System.Windows.Forms.ColumnHeader saleAmountHeader;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label calcTotalSalesLabel;
        private System.Windows.Forms.Label calcBestSellingPackageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label calcTopSellingEmployeeLabel;
        private System.Windows.Forms.Label topSellingEmployeeLabel;
        private System.Windows.Forms.Button addSalesButton;
        private System.Windows.Forms.Button displaySalesButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip addSalesToolTip;
        private System.Windows.Forms.ToolTip displaySalesToolTip;
        private System.Windows.Forms.ToolTip saveFileToolTip;
        private System.Windows.Forms.ToolTip readFileToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.MenuStrip buttonMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addSalesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySalesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

