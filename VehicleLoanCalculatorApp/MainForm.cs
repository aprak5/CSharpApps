/**
 * Project name: VehicleLoanCalculatorApp
 * Project purpose: Display/calculate the total loans/amortizations, by taking the loan amount, annual APR rate (%), months, and rebate from user (through the respective textboxes/checkbox/radio buttons).
 * New usecases: Error-handling for user input:
 *          1. Loan Amount > 0. Otherwise, display an appropriate error message.
 *          2. Annual APR > 0 and < 100%. Otherwise, display an appropriate error message. 
 *          3. Rebate <= Loan amount. Otherwise, display an appropriate error message.
 * Note: Comments use XML commenting, which can be used as Javadoc (this was approved by Dr. Fowler).
 * XML commenting can be eventually translated to HTML files like Javadoc which also converts to HTML files. 
 * Created/revised by: Dr. Fowler (slfowler), Amit Prakash (aprakas5) on 10/14/2022 in C# 
 */

#region Importing Different Libraries for the VehicleLoanCalculatorApp namespace

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

#region The Main Functionality for the VehicleLoanCalculatorApp

/**
 * The namespace for the app, contains the MainForm partial class.
 */
namespace VehicleLoanCalculatorApp
{
    /**
	 * Some implementation for the MainForm in a public partial class (part of Form class).
	 */
    public partial class MainForm : Form
    {
        #region MainForm Fields (global variables)

        double totalInterest = 0, 
            totalLoans = 0,
            currentLoanAmount = 0,
            currentInterestAmount = 0;

        readonly int MONTHS_IN_A_YEAR = 12; //readonly used instead of const as a stricter variable for the constant

        #endregion

        #region MainForm Class Constructor 

        /// <summary>
        /// Constructor for the main form for the design, basically initializes the components of the MainForm object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region All form methods

        #region All MainForm methods (Load)

        /// <summary>
        /// Populates annualAPRComboBox options and sets the default value as 6.5%.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this form.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Use a for-loop to add all annual APR rates from 0.5% to 15.00% (Inclusive)

            for (int i = 1; i <= 30; i++)
                annualAPRComboBox.Items.Add((i * 0.5).ToString("N1"));

            #endregion

            #region Assign a default value, which is 6.5% (which is the average annual APR rate for cars)

            annualAPRComboBox.SelectedIndex = 12;

            #endregion
        }

        #endregion

        #endregion

        #region All text box methods

        #region All loanAmountTextBox methods (Click, Enter, KeyPress, TextChanged)

        /// <summary>
        /// Focuses on/selects all text in the loanAmountTextBox when clicked.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void loanAmountTextBox_Click(object sender, EventArgs e)
        {
            #region Focuses on/selects all text in the loanAmountTextBox when clicked.

            loanAmountTextBox.Focus();
            loanAmountTextBox.SelectAll();
            return;

            #endregion
        }

        /// <summary>
        /// Focuses on/selects all text in the loanAmountTextBox when tabbed into (entered).
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void loanAmountTextBox_Enter(object sender, EventArgs e)
        {
            #region Focuses on/selects all text in the loanAmountTextBox when tabbed into (entered).

            loanAmountTextBox.Focus();
            loanAmountTextBox.SelectAll();
            return;

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the loanAmountTextBox.
        /// It disallows any characters to be entered in the textbox other than a valid number (possibly decimal) or control character.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this text box.</param>
        private void loanAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region If the key pressed is not a control key (e.g., backspace), digit, or period, set the Handled property to true to cancel the keyed input

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            return;

            #endregion
        }

        /// <summary>
        /// Clears all items in amortizationListBox when text property is changed
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void loanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when text property is changed

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #region All rebateTextBox methods (Click, Enter, KeyPress, TextChanged)

        /// <summary>
        /// Focuses on/selects all text in the rebateTextBox when clicked.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void rebateTextBox_Click(object sender, EventArgs e)
        {
            #region Focuses on/selects all text in the rebateTextBox when clicked.

            rebateTextBox.Focus();
            rebateTextBox.SelectAll();
            return;

            #endregion
        }

        /// <summary>
        /// Focuses on/selects all text in the rebateTextBox when tabbed into (entered).
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void rebateTextBox_Enter(object sender, EventArgs e)
        {
            #region Focuses on/selects all text in the rebateTextBox when tabbed into (entered).

            rebateTextBox.Focus();
            rebateTextBox.SelectAll();
            return;

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the rebateTextBox.
        /// It disallows any characters to be entered in the textbox other than a valid number (possibly decimal) or control character.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this text box.</param>
        private void rebateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region If the key pressed is not a control key (e.g., backspace), digit, or period, set the Handled property to true to cancel the keyed input

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            return;

            #endregion
        }

        /// <summary>
        /// Clears all items in amortizationListBox when text property is changed
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this text box.</param>
        private void rebateTextBox_TextChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when text property is changed

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #endregion

        #region All button methods

        #region All calcLoanButton methods (Click)

        /// <summary>
        /// Calculate/display the loan amortization in amortizationListBox. 
        /// Also, set currentLoanAmount and currentInterestAmount, as those calculated here.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void calcLoanButton_Click(object sender, EventArgs e)
        {
            #region Use a try...catch to handle any generated exceptions

            try
            {
                #region Clear the amortizationListBox when clicked

                amortizationListBox.Items.Clear();

                #endregion

                #region Declare/Initialize all variables to 0

                double loan = 0, //loan amount (from loanAmountTextBox)
                    rate = 0, //rate (from annualAPRComboBox)
                    rebate = 0, //rebate (from rebateTextBox) 
                    principalPayment = 0, //principal payment per month
                    totalPrincipalPayment = 0, //total principal payment for months
                    interest = 0, //interest per month
                    totalInterest = 0, //total interest for months
                    pmt = 0, //payment per month
                    totalPmt = 0; //payment for months

                int months = 0; //months for the loan

                string formatString = "{0,5}{1,20}{2,20}{3,20}{4,20}"; //format string for the list box

                #endregion

                #region Store value from loanAmountTextBox in loan, if unable or loan is 0 display error message

                if (!double.TryParse(loanAmountTextBox.Text, out loan) || loan <= 0)
                {
                    MessageBox.Show("Please enter a positive value for the loan amount.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #endregion

                #region Store value from annualAPRComboBox in rate, if unable or rate is 0 display error message

                rate = Convert.ToDouble(annualAPRComboBox.Text);

                if (rate <= 0)
                {
                    MessageBox.Show("Please enter a positive value for the annual APR.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #endregion

                #region Store value from rebateTextBox in rebate, if rebateCheckBox is checked, otherwise rebate remains 0. If unable, display error message.

                if (rebateCheckBox.Checked)
                    if (!double.TryParse(rebateTextBox.Text, out rebate))
                    {
                        MessageBox.Show("Please enter a valid value for the rebate.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                #endregion

                #region Store value based on appropriate radio button checked into months using conditional logic.

                if (sixMonthsRadioButton.Checked)
                    months = 6; //Since sixMonthsRadioButton.Checked is true, store 6 in months
                else if (twelveMonthsRadioButton.Checked)
                    months = MONTHS_IN_A_YEAR; //Since twelveMonthsRadioButton.Checked is true, store 12 in months
                else if (eighteenMonthsRadioButton.Checked)
                    months = 18; //Since eighteenMonthsRadioButton.Checked is true, store 18 in months
                else if (twentyFourMonthsRadioButton.Checked)
                    months = 24; //Since twentyFourMonthsRadioButton.Checked is true, store 24 in months
                else
                    months = 6; //Since the default is 6 months, store 6 in months

                #endregion

                #region Apply the rebate and convert percent rate to decimal rate

                loan -= rebate;
                rate /= 100; 

                #endregion

                #region Set the loan amount as the current loan amount

                currentLoanAmount = loan;

                #endregion

                #region Calculate the principal payment, interest, and monthly payment
                
                principalPayment = (rate / MONTHS_IN_A_YEAR) * (loan + 0 * Math.Pow(1 + rate / MONTHS_IN_A_YEAR, months)) / 
                    ((Math.Pow(1 + rate / MONTHS_IN_A_YEAR, months) - 1) * (1 + rate / MONTHS_IN_A_YEAR * 0));
                interest = loan * (rate / MONTHS_IN_A_YEAR);
                pmt = principalPayment + interest;

                #endregion

                #region For-loop to recalculate loan, display each month in the amortizationListBox, add to ongoing totals, recalculate interest and principal payment.

                for (int monthsCounter = 1; monthsCounter <= months; monthsCounter++)
                {
                    loan -= principalPayment;
                    amortizationListBox.Items.Add(String.Format(formatString, monthsCounter.ToString("N0"), 
                        interest.ToString("C2"), principalPayment.ToString("C2"), pmt.ToString("C2"), loan.ToString("C2")));
                    totalPrincipalPayment += principalPayment;
                    totalInterest += interest;
                    totalPmt += pmt;
                    interest = loan * (rate / 12);
                    principalPayment = pmt - interest;
                }

                #endregion

                #region Set totalInterest paid as currentInterestAmount for the loan

                currentInterestAmount = totalInterest;

                #endregion

                #region Display totals (with empty line before) in the amortizationListBox

                amortizationListBox.Items.Add(String.Empty);
                amortizationListBox.Items.Add(String.Format(formatString, "Total", totalInterest.ToString("C2"), totalPrincipalPayment.ToString("C2"), totalPmt.ToString("C2"), String.Empty));

                #endregion
            }
            catch (Exception exp)
            {
                #region Display error message if any Exception exp is thrown and show the Exception exp.

                MessageBox.Show("Could not calculate loan amortization. Please try again.", exp.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

                #endregion
            }
            return;

            #endregion
        }

        #endregion

        #region All acceptLoanButton methods (Click)

        /// <summary>
        /// Calculates totals for totalLoans and totalInterest, then clears every form object and focuses on loanAmountTextBox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void acceptLoanButton_Click(object sender, EventArgs e)
        {
            #region Calculate totals for totalLoans and totalInterest

            calcLoanButton_Click(sender, e); //Calculate currentLoanAmount and currentInterestAmount first by calling this method
            totalInterest += currentInterestAmount; //Add currentInterestAmount to totalInterestAmount
            totalLoans += currentLoanAmount; //Add currentLoanAmount to totalLoansAmount

            #endregion

            #region Clear every form object

            loanAmountTextBox.Clear();
            annualAPRComboBox.Text = String.Empty; //Set the combo box text to an empty string (String.Empty = "")
            annualAPRComboBox.SelectedIndex = -1; //Set the combo box to the index before 0 (which should be empty)
            rebateTextBox.Clear(); //Clear the rebate text box
            rebateTextBox.Enabled = false; //Disable the rebate text box
            rebateCheckBox.Checked = false; //Uncheck the rebate check box
            sixMonthsRadioButton.Checked = true; //Check the six months radio button since it is the default
            twelveMonthsRadioButton.Checked = false; //Uncheck the twelve months radio button
            eighteenMonthsRadioButton.Checked = false; //Uncheck the eighteen months radio button
            twentyFourMonthsRadioButton.Checked = false; //Uncheck the twenty four months radio button
            calcTotalInterestLabel.Text = String.Empty; //Clear the calcTotalInterestLabel
            calcTotalLoansLabel.Text = String.Empty; //Clear the calcTotalLoansLabel

            #endregion

            #region Focus on the loanAmountTextBox

            loanAmountTextBox.Focus();

            #endregion
        }

        #endregion

        #region All displayLoansButton methods (Click)

        /// <summary>
        /// Displays totalInterest and totalLoans in their respective labels
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void displayLoansButton_Click(object sender, EventArgs e)
        {
            #region Displays totalInterest and totalLoans in their respective labels

            calcTotalInterestLabel.Text = totalInterest.ToString("C2");
            calcTotalLoansLabel.Text = totalLoans.ToString("C2");

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

        #region All combo box methods

        #region All annualAPRComboBox methods (Click, Enter, KeyPress, SelectedIndexChanged, TextChanged)

        /// <summary>
        /// Focuses on/selects all text in the annualAPRComboBox when clicked.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void annualAPRComboBox_Click(object sender, EventArgs e)
        {
            #region Focuses on/selects all text in the annualAPRComboBox when clicked.

            annualAPRComboBox.Focus();
            annualAPRComboBox.SelectAll();
            return;

            #endregion
        }

        /// <summary>
        /// Focuses on/selects all text in the annualAPRComboBox when tabbed into (entered).
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void annualAPRComboBox_Enter(object sender, EventArgs e)
        {
            #region Focuses on/selects all text in the annualAPRComboBox when tabbed into (entered).

            annualAPRComboBox.Focus();
            annualAPRComboBox.SelectAll();
            return;

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the annualAPRComboBox.
        /// It disallows any characters to be entered in the textbox other than a valid number (possibly decimal) or control character.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this combo box.</param>
        private void annualAPRComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region If the key pressed is not a control key (e.g., backspace), digit, or period, set the Handled property to true to cancel the keyed input

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            return;

            #endregion
        }

        /// <summary>
        /// Clears all items in amortizationListBox when selected index property is changed
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void annualAPRComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when selected index property is changed

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        /// <summary>
        /// Clears all items in amortizationListBox when text property is changed
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this combo box.</param>
        private void annualAPRComboBox_TextChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when text property is changed

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #endregion

        #region All check box methods

        #region All rebateCheckBox methods (CheckedChanged)

        /// <summary>
        /// Clears all items in amortizationListBox when checked property is changed.
        /// Disables the rebateTextBox if unchecked, otherwise enables it.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this check box.</param>
        private void rebateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when checked property is changed

            amortizationListBox.Items.Clear();

            #endregion

            #region Disables the rebateTextBox if unchecked, otherwise enables it.

            rebateTextBox.Enabled = rebateCheckBox.Checked;
            return;

            #endregion


        }

        #endregion

        #endregion

        #region All radio button methods

        #region All sixMonthsRadioButton methods (CheckedChanged)

        /// <summary>
        /// Clears all items in amortizationListBox when checked property is changed.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this radio button.</param>
        private void sixMonthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when checked property is changed.

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #region All twelveMonthsRadioButton methods (CheckedChanged)

        /// <summary>
        /// Clears all items in amortizationListBox when checked property is changed.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this radio button.</param>
        private void twelveMonthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when checked property is changed.

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #region All eighteenMonthsRadioButton methods (CheckedChanged)

        /// <summary>
        /// Clears all items in amortizationListBox when checked property is changed.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this radio button.</param>
        private void eighteenMonthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when checked property is changed.

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #region All twentyFourMonthsRadioButton methods (CheckedChanged)

        /// <summary>
        /// Clears all items in amortizationListBox when checked property is changed.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this radio button.</param>
        private void twentyFourMonthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            #region Clears all items in amortizationListBox when checked property is changed.

            amortizationListBox.Items.Clear();
            return;

            #endregion
        }

        #endregion

        #endregion
    }
}

#endregion
