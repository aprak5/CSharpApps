/**
 * Project name: CapitalCityPhotographyOrderForm
 * Project purpose: Display/calculate the total package sales (by type and overall) and the best-selling employee and package type, by taking the package type, quantity, and employee from user (through the respective textboxes or combo boxes).
 * For design information, refer to the attached UML diagram (see ...\CapitalCityPhotographyOrderForm\docs\UML_Design.png
 * Design Note: Some code from this namespace/class/part of MVC model (VC) can be refactored into the M part of the MVC model, to reduce code repetition.
 * This might however, have a slightly higher runtime to the current design. However, the robustness/flexibility of the design will definitely be worth the change.
 * The same can be said of error-handling, which is best implemented in the model part of the MVC. 
 * Some code in here may also be refactored to the MainFormController for future expansion of the program.
 * Note: Comments use XML commenting, which can be used as Javadoc (this was approved by Dr. Fowler).
 * XML commenting can be eventually translated to HTML files like Javadoc which also converts to HTML files. 
 * Created/revised by: Dr. Fowler (slfowler), Amit Prakash (aprakas5) on 12/3/2022 in C# 
 */

#region Import in all namespaces required for the project (custom namespaces included)

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using edu.ncsu.bus442.p2.model.io;
using edu.ncsu.bus442.p2.model.order;
using edu.ncsu.bus442.p2.model.product;
using edu.ncsu.bus442.p2.model.person;

#endregion

#region Define this namespace as viewcontroller (VC part of MVC design)

namespace edu.ncsu.bus442.p2.viewcontroller
{
    #region This partial class MainForm implements the parent class Form

    public partial class MainForm : Form
    {
        #region Define/initialize global variables

        /// <summary>
        /// A list to track the photographyOrders in the program
        /// </summary>
        private List<PhotographyOrder> photographyOrders = new List<PhotographyOrder>();
        /// <summary>
        /// A list to track the packages in the program
        /// </summary>
        private List<Package> packages = new List<Package>();
        /// <summary>
        /// A list to track the employees in the program
        /// </summary>
        private List<Employee> employees = new List<Employee>();

        #endregion

        #region Constructor for MainForm

        /// <summary>
        /// Define the constructor for MainForm, needs to construct the form and populate the employees and packages and their respective combo boxes.
        /// </summary>
        public MainForm()
        {
            #region Define the constructor for MainForm, needs to construct the form and populate the employees and packages and their respective combo boxes.
            
            InitializeComponent();
           
            packageTypeComboBox.Items.Add("Birthday");
            packageTypeComboBox.Items.Add("Engagement");
            packageTypeComboBox.Items.Add("Graduation");
            packageTypeComboBox.Items.Add("Wedding");
            packageTypeComboBox.Items.Add("Anniversary");
            packageTypeComboBox.Items.Add("Family");
            packageTypeComboBox.Items.Add("Individual Portrait");
            packageTypeComboBox.Items.Add("Other");
            
            employeeComboBox.Items.Add("John Williams");
            employeeComboBox.Items.Add("Lana Conner");
            employeeComboBox.Items.Add("James P. Smith");
            employeeComboBox.Items.Add("Megan Barker");

            Package p1 = new Package("Birthday", 0);
            Package p2 = new Package("Engagement", 0);
            Package p3 = new Package("Graduation", 0);
            Package p4 = new Package("Wedding", 0);
            Package p5 = new Package("Anniversary", 0);
            Package p6 = new Package("Family", 0);
            Package p7 = new Package("Individual Portrait", 0);
            Package p8 = new Package("Other", 0);

            packages.Add(p1);
            packages.Add(p2);
            packages.Add(p3);
            packages.Add(p4);
            packages.Add(p5);
            packages.Add(p6);
            packages.Add(p7);
            packages.Add(p8);

            Employee e1 = new Employee("John", ' ', "Williams", 0);
            Employee e2 = new Employee("Lana", ' ', "Conner", 0);
            Employee e3 = new Employee("James", 'P', "Smith", 0);
            Employee e4 = new Employee("Megan", ' ', "Barker", 0);

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);

            #endregion
        }

        #endregion

        #region All Combo Box Methods

        #region All packageTypeComboBox Methods (Click, Enter, SelectedIndexChanged, TextChanged)

        /// <summary>
        /// Clear the combo box when clicked.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void packageTypeComboBox_Click(object sender, EventArgs e)
        {
            #region Clear the combo box when clicked.

            packageTypeComboBox.SelectAll();
            packageTypeComboBox.Focus();

            #endregion
        }

        /// <summary>
        /// Clear the combo box when tabbed into.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void packageTypeComboBox_Enter(object sender, EventArgs e)
        {
            #region Clear the combo box when tabbed into.

            packageTypeComboBox.SelectAll();
            packageTypeComboBox.Focus();

            #endregion
        }

        /// <summary>
        /// Clear everything displayed when the combo box value changes.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void packageTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Clear everything displayed when the combo box value changes.

            packageListView.Items.Clear();
            calcTotalSalesLabel.Text = String.Empty;
            calcTopSellingEmployeeLabel.Text = String.Empty;
            calcBestSellingPackageLabel.Text = String.Empty;

            #endregion
        }

        /// <summary>
        /// Clear everything displayed when the combo box value changes.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void packageTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            #region Clear everything displayed when the combo box value changes.

            packageListView.Items.Clear();
            calcTotalSalesLabel.Text = String.Empty;
            calcTopSellingEmployeeLabel.Text = String.Empty;
            calcBestSellingPackageLabel.Text = String.Empty;

            #endregion
        }

        #endregion

        #region All employeeComboBox Methods (Click, Enter, SelectedIndexChanged, TextChanged)

        /// <summary>
        /// Clear the combo box when clicked.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void employeeComboBox_Click(object sender, EventArgs e)
        {
            #region Clear the combo box when clicked.

            employeeComboBox.SelectAll();
            employeeComboBox.Focus();

            #endregion
        }

        /// <summary>
        /// Clear the combo box when tabbed into.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void employeeComboBox_Enter(object sender, EventArgs e)
        {
            #region Clear the combo box when tabbed into.

            employeeComboBox.SelectAll();
            employeeComboBox.Focus();

            #endregion
        }

        /// <summary>
        /// Clear everything displayed when the combo box value changes.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Clear everything displayed when the combo box value changes.

            packageListView.Items.Clear();
            calcTotalSalesLabel.Text = String.Empty;
            calcTopSellingEmployeeLabel.Text = String.Empty;
            calcBestSellingPackageLabel.Text = String.Empty;

            #endregion
        }

        /// <summary>
        /// Clear everything displayed when the combo box value changes.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void employeeComboBox_TextChanged(object sender, EventArgs e)
        {
            #region Clear everything displayed when the combo box value changes.

            packageListView.Items.Clear();
            calcTotalSalesLabel.Text = String.Empty;
            calcTopSellingEmployeeLabel.Text = String.Empty;
            calcBestSellingPackageLabel.Text = String.Empty;

            #endregion
        }

        #endregion

        #endregion

        #region All Textbox Methods

        #region All quantityTextBox Methods (Click, Enter, KeyPress, TextChanged)

        /// <summary>
        /// Clear the text box when clicked.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void quantityTextBox_Click(object sender, EventArgs e)
        {
            #region Clear the text box when clicked.

            quantityTextBox.SelectAll();
            quantityTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// Clear the text box when tabbed into.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void quantityTextBox_Enter(object sender, EventArgs e)
        {
            #region Clear the text box when tabbed into.

            quantityTextBox.SelectAll();
            quantityTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// If the key pressed is not a control key (e.g., backspace), digit, or period, set the Handled property to true to cancel the keyed input
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressArgs, all the key press data for this text box.</param>
        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region If the key pressed is not a control key (e.g., backspace), digit, or period, set the Handled property to true to cancel the keyed input

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            return;

            #endregion
        }

        /// <summary>
        /// Clears everything displayed when text changes in the text box.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            #region Clears everything displayed when text changes in the text box.

            packageListView.Items.Clear();
            calcTotalSalesLabel.Text = String.Empty;
            calcTopSellingEmployeeLabel.Text = String.Empty;
            calcBestSellingPackageLabel.Text = String.Empty;

            #endregion
        }

        #endregion

        #endregion

        #region All Button/Menu Item Methods

        #region All addSalesButton Methods (Click)

        /// <summary>
        /// Parse container inputs to objects and update them with the global lists (photographyOrders, packages, and employees)
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void addSalesButton_Click(object sender, EventArgs e)
        {
            #region Use a try...catch for error-handling for unforeseen errors

            try
            {
                #region Declare/Initialize all variables needed

                PhotographyOrder photographyOrder;
                Package package;
                Employee employee;
                int quantity = 0;
                bool isPackagePresent = false, isEmployeePresent = false;

                #endregion

                #region Parse data from input containers on form into objects using conditional logic and setters

                if (packageTypeComboBox.Items.Contains(packageTypeComboBox.Text))
                    package = new Package(packageTypeComboBox.SelectedItem.ToString(), 0);
                else
                    package = new Package(packageTypeComboBox.Text, 0);
                if (employeeComboBox.SelectedItem.ToString().Split(' ').Length == 3)
                    employee = new Employee(employeeComboBox.SelectedItem.ToString().Split(' ')[0],
                        employeeComboBox.SelectedItem.ToString().Split(' ')[1].ToCharArray()[0], employeeComboBox.SelectedItem.ToString().Split(' ')[2], 0);
                else
                    employee = new Employee(employeeComboBox.SelectedItem.ToString().Split(' ')[0], ' ', employeeComboBox.SelectedItem.ToString().Split(' ')[1], 0);
                if (!int.TryParse(quantityTextBox.Text, out quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #endregion

                #region Construct the PhotographyOrder from elements parsed above and add that order to the global list (photographyOrders) 

                employee.setNumSale(quantity);
                package.setNumSale(quantity);
                photographyOrder = new PhotographyOrder(package, quantity, employee);
                photographyOrders.Add(photographyOrder);

                #endregion

                #region Update other global lists (packages and employees) to reflect this photographyOrder

                foreach (Package p in packages)
                    if (p.getType().Equals(package.getType()))
                    {
                        p.setNumSale(p.getNumSale() + quantity);
                        isPackagePresent = true;
                    }
                if (!isPackagePresent)
                    packages.Add(package);
                foreach (Employee emp in employees)
                    if (emp.getFirstName().Equals(employee.getFirstName()) && emp.getMiddleInitial().Equals(employee.getMiddleInitial())
                        && emp.getLastName().Equals(employee.getLastName()))
                    {
                        emp.setNumSale(emp.getNumSale() + quantity);
                        isEmployeePresent = true;
                    }
                if (!isEmployeePresent)
                    employees.Add(employee);

                #endregion

            }
            catch (Exception)
            {
                MessageBox.Show("Could not add order. Please try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        #endregion

        #region All displaySalesButton Methods (Click)

        /// <summary>
        /// Calculate, parse, and display the metrics to display in their appropriate containers
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void displaySalesButton_Click(object sender, EventArgs e)
        {
            #region Use a try...catch for error-handling for unforeseen errors

            try
            {
                #region Clear the form before we do anything

                packageListView.Items.Clear();
                calcTotalSalesLabel.Text = String.Empty;
                calcTopSellingEmployeeLabel.Text = String.Empty;
                calcBestSellingPackageLabel.Text = String.Empty;
                packageTypeComboBox.Text = String.Empty;
                packageTypeComboBox.SelectedIndex = -1;
                employeeComboBox.Text = String.Empty;
                employeeComboBox.SelectedIndex = -1;
                quantityTextBox.Text = String.Empty;

                #endregion

                #region Declare/initialize variables to keep track of the metrics to display

                int totalSales = 0;
                List<Package> maxPackages = new List<Package>();
                List<Employee> maxEmployees = new List<Employee>();

                #endregion

                #region Use for/foreach loops to calculate the metrics to display

                foreach (Package package in packages)
                {
                    string[] item = new string[2];
                    item[0] = package.getType();
                    item[1] = package.getNumSale().ToString("N0");
                    ListViewItem lvi = new ListViewItem(item);
                    packageListView.Items.Add(lvi);
                    totalSales += package.getNumSale();
                }
                maxPackages.Add(packages[0]);
                foreach (Package p in packages)
                    for (int i = 0; i < maxPackages.Count; i++)
                        if (p.getNumSale() > maxPackages[i].getNumSale())
                        {
                            maxPackages = new List<Package>();
                            maxPackages.Add(p);
                        }
                        else if (p.getNumSale() == maxPackages[i].getNumSale() && !maxPackages.Contains(p))
                            maxPackages.Add(p);
                maxEmployees.Add(employees[0]);
                foreach (Employee p in employees)
                    for (int i = 0; i < maxEmployees.Count; i++)
                        if (p.getNumSale() > maxEmployees[i].getNumSale())
                        {
                            maxEmployees = new List<Employee>();
                            maxEmployees.Add(p);
                        }
                        else if (p.getNumSale() == maxEmployees[i].getNumSale() && !maxEmployees.Contains(p))
                            maxEmployees.Add(p);

                #endregion

                #region Convert/format everything to strings to display and display them in their appropriate containers

                calcTotalSalesLabel.Text = totalSales.ToString("N0");
                for (int i = 0; i < maxPackages.Count; i++)
                    if (i != maxPackages.Count - 1)
                        calcBestSellingPackageLabel.Text += (maxPackages[i].getType() + ", ");
                    else
                        calcBestSellingPackageLabel.Text += maxPackages[i].getType();
                for (int i = 0; i < maxEmployees.Count; i++)
                {
                    if (i != maxEmployees.Count - 1)
                    {
                        if (maxEmployees[i].getMiddleInitial() == '\0')
                            calcTopSellingEmployeeLabel.Text += (maxEmployees[i].getFirstName() + " " + maxEmployees[i].getLastName() + ", ");
                        else
                            calcTopSellingEmployeeLabel.Text += (maxEmployees[i].getFirstName() + " " + maxEmployees[i].getMiddleInitial() + ". " + maxEmployees[i].getLastName() + ", ");
                    }
                    else
                    {
                        if (maxEmployees[i].getMiddleInitial() == '\0')
                            calcTopSellingEmployeeLabel.Text += (maxEmployees[i].getFirstName() + " " + maxEmployees[i].getLastName());
                        else
                            calcTopSellingEmployeeLabel.Text += (maxEmployees[i].getFirstName() + " " + maxEmployees[i].getMiddleInitial() + ". " + maxEmployees[i].getLastName());
                    }
                }
                calcTopSellingEmployeeLabel.Text += " with " + maxEmployees[0].getNumSale().ToString("N0") + " sale(s).";

                #endregion

            }
            catch (Exception)
            {
                MessageBox.Show("Could not calculate results. Please try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        #endregion

        #region readFileButton Methods (Click)

        /// <summary>
        /// Opens the openFileDialog to read a file.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void readFileButton_Click(object sender, EventArgs e)
        {
            #region Opens the openFileDialog to read a file.

            openFileDialog.ShowDialog();

            #endregion
        }

        #endregion

        #region saveFileButton Methods (Click)

        /// <summary>
        /// Opens the saveFileDialog to write a file.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            #region Opens the saveFileDialog to write a file.

            saveFileDialog.ShowDialog();

            #endregion
        }

        #endregion

        #region All exitButton methods (Click)

        /// <summary>
        /// The method defines implementation for the Click event for the exitButton.
        /// It displays a dialog confirming the exit and then exits if confirmed.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            #region Generate a dialog box and confirm the user wants to clear the form. If not, do nothing.

            DialogResult dialog = MessageBox.Show("Are you sure you want to exit the form?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            #endregion

            #region If so, close this form.

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }

            #endregion
        }

        #endregion

        #endregion

        #region All FileDialog Methods

        #region All openFileDialog Methods (FileOk)

        /// <summary>
        /// Parse a given file using readPhotographyOrders and save into global lists (photographyOrders, packages, employees)
        ///  File is a comma-separated-value file or *.csv.
        ///  Reads in the format [Package Type], [Quantity], [Employee Name]
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of CancelEventArgs, all the cancel event data for this open file dialog.</param>
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            #region Use a try...catch for error-handling for unforeseen errors 

            try
            {

                #region Define/initialize the openFileStream based on the file in the openFileDialog

                Stream openFileStream = openFileDialog.OpenFile();

                #endregion

                #region Use the readPhotographyOrders to process the file

                photographyOrders = PhotographyOrderIO.readPhotographyOrders(openFileStream);

                #endregion

                #region Use the list returned to update the rest of the lists/objects

                foreach (PhotographyOrder po in photographyOrders)
                {
                    bool isPackagePresent = false;
                    foreach (Package p in packages)
                        if (p.getType().Equals(po.getPackage().getType()))
                        {
                            p.setNumSale(p.getNumSale() + po.getQuantity());
                            isPackagePresent = true;
                        }
                    if (!isPackagePresent)
                        packages.Add(po.getPackage());
                    bool isEmployeePresent = false;
                    foreach (Employee emp in employees)
                        if (emp.getFirstName().Equals(po.getEmployee().getFirstName()) && emp.getMiddleInitial().Equals(po.getEmployee().getMiddleInitial())
                            && emp.getLastName().Equals(po.getEmployee().getLastName()))
                        {
                            emp.setNumSale(emp.getNumSale() + po.getQuantity());
                            isEmployeePresent = true;
                        }
                    if (!isEmployeePresent)
                        employees.Add(po.getEmployee());
                }

                #endregion

                #region Close the openFileStream

                openFileStream.Close();

                #endregion

            } catch(Exception)
            {
                MessageBox.Show("There was a problem in processing the file. Please try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        #endregion

        #region All saveFileDialog Methods (FileOk)

        /// <summary>
        /// Write a given file using writePhotographyOrders and from the global lists (photographyOrders, packages, employees)
        /// File is a comma-separated-value file or *.csv.
        /// Writes in the format [Package Type], [Quantity], [Employee Name]
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of CancelEventArgs, all the cancel event data for this open file dialog.</param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            #region Use a try...catch for error-handling for unforeseen errors 

            try
            {

                #region Define/initialize the saveFileStream based on the file in the saveFileDialog

                Stream saveFileStream = saveFileDialog.OpenFile();

                #endregion

                #region Use the writePhotographyOrders to process the file

                PhotographyOrderIO.writePhotographyOrders(saveFileStream, photographyOrders);

                #endregion

                #region Close the saveFileStream

                saveFileStream.Close();

                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem in writing the file. Please try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        #endregion

        #endregion
    }

    #endregion
}

#endregion