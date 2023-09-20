/**
 * Project name: WarrenCountyTaxCalcApp
 * Project purpose: Display/calculate the total property tax, by taking the tax rate from user (through the respective checkbox/radio buttons).
 * Note: Comments use XML commenting, which can be used as Javadoc (this was approved by Dr. Fowler).
 * XML commenting can be eventually translated to HTML files like Javadoc which also converts to HTML files. 
 * Created/revised by: Dr. Fowler (slfowler), Amit Prakash (aprakas5) on 9/23/2022 in C# 
 */

#region Importing Different Libraries for the WarrenCountyTaxCalcApp namespace

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

# region The Main Functionality for the WarrenCountyTaxCalcApp

/**
 * The namespace for the app, contains WarrenCountyTaxCalcAppForm partial class.
 */
namespace WarrenCountyTaxCalcApp
{
	/**
	 * Some implementation for the WarrenCountyTaxCalcAppForm in a public partial class (part of Form class).
	 */
	public partial class WarrenCountyTaxCalcAppForm : Form
	{
		#region WarrenCountyTaxCalcAppForm Class Constructor 
		/// <summary>
		/// Constructor for the main form for the design, basically initializes the components of the MainForm object.
		/// </summary>
		public WarrenCountyTaxCalcAppForm()
		{
			InitializeComponent();
		}
        #endregion

        #region All button control methods
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

        

        /// <summary>
        /// The method defines implementation for the Click event for the calculateButton.
        /// It calculates all the costs, then sums them and displays them in a formatted version in calcTotalPropertyTaxesListBox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void calcButton_Click(object sender, EventArgs e)
		{
            #region Global Constants
            //Note all constants are declared as const instead of readonly since we're confident the values won't change.
            /// <summary>
            /// This is the first state tax rate (bracket) in Warren county.
            /// </summary>
            const double FIRST_TAX_RATE = 0.00124;
            /// <summary>
            /// This is the second state tax rate (bracket) in Warren county.
            /// </summary>
            const double SECOND_TAX_RATE = 0.00134;
            /// <summary>
            /// This is the third state tax rate (bracket) in Warren county.
            /// </summary>
            const double THIRD_TAX_RATE = 0.00144;
            /// <summary>
            /// This is the county tax rate (bracket) in Warren county.
            /// </summary>
            const double COUNTY_TAX_RATE = 0.00096;
            /// <summary>
            /// This is the school tax rate (bracket) in Warren county.
            /// </summary>
            const double SCHOOL_TAX_RATE = 0.00557;
            /// <summary>
            /// This is the ambulance tax rate (bracket) in Warren county.
            /// </summary>
            const double AMBULANCE_TAX_RATE = 0.001;
            /// <summary>
            /// This is the health tax rate (bracket) in Warren county.
            /// </summary>
            const double HEALTH_TAX_RATE = 0.00038;
            /// <summary>
            /// This is the library tax rate (bracket) in Warren county.
            /// </summary>
            const double LIBRARY_TAX_RATE = 0.00093;
            /// <summary>
            /// This is the soil tax rate (bracket) in Warren county.
            /// </summary>
            const double SOIL_TAX_RATE = 0.0002;
            /// <summary>
            /// If the checkbox is checked, a percent is added.
            /// </summary>
            const double PERCENT_INCREASE = 0.01;
            #endregion

            #region Try the calculations, otherwise catch an exception and show a MessageBox with the exception/appropriate message.
            try
            {
				#region Declare/initialize all variables needed for all calculations
				double propertyVal, stateTaxRate, stateTax, countyTaxRate = COUNTY_TAX_RATE, countyTax, schoolTaxRate = SCHOOL_TAX_RATE, schoolTax, 
					ambulanceTaxRate = AMBULANCE_TAX_RATE, ambulanceTax, healthTaxRate = HEALTH_TAX_RATE, healthTax, libraryTaxRate = LIBRARY_TAX_RATE, 
					libraryTax, soilTaxRate = SOIL_TAX_RATE, soilTax, totalTax;
				#endregion

				#region Parse the text in the propertyValTextBox and store in propertyVal if valid, otherwise store 0
				if (!double.TryParse(propertyValTextBox.Text, out propertyVal))
				{
					MessageBox.Show("Enter a valid property value.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
                #endregion

                #region Use conditionals to decide stateTaxRate based on the radio buttons checked
                if (firstTaxRateRadioButton.Checked)
					stateTaxRate = FIRST_TAX_RATE;
				else if (secondTaxRateRadioButton.Checked)
					stateTaxRate = SECOND_TAX_RATE;
				else if (thirdTaxRateRadioButton.Checked)
					stateTaxRate = THIRD_TAX_RATE;
				else
					stateTaxRate = FIRST_TAX_RATE;
                #endregion

                #region Use conditionals to decide tax rates based on whether the checkbox is checked
                if (percentIncreaseCheckBox.Checked)
				{
					stateTaxRate *= (PERCENT_INCREASE + 1);
					countyTaxRate *= (PERCENT_INCREASE + 1);
					schoolTaxRate *= (PERCENT_INCREASE + 1);
					ambulanceTaxRate *= (PERCENT_INCREASE + 1);
					healthTaxRate *= (PERCENT_INCREASE + 1);
					libraryTaxRate *= (PERCENT_INCREASE + 1);
					soilTaxRate *= (PERCENT_INCREASE + 1);
				}
                #endregion

                #region Calculate each tax based on respective tax rates
                stateTax = propertyVal * stateTaxRate;
				countyTax = propertyVal * countyTaxRate;
				schoolTax = propertyVal * schoolTaxRate;
				ambulanceTax = propertyVal * ambulanceTaxRate;
				healthTax = propertyVal * healthTaxRate;
				libraryTax = propertyVal * libraryTaxRate;
				soilTax = propertyVal * soilTaxRate;
				totalTax = stateTax + countyTax + schoolTax + ambulanceTax + healthTax + libraryTax + soilTax;
                #endregion

                #region Display results in the respective labels and list box
                calcTotalPropertyTaxesListBox.Items.Add("Total Property Tax: " + totalTax.ToString("C2"));
				calcStateTaxLabel.Text = stateTax.ToString("C2");
				calcCountyTaxLabel.Text = countyTax.ToString("C2");
				calcSchoolTaxLabel.Text = schoolTax.ToString("C2");
				calcAmbulanceTaxLabel.Text = ambulanceTax.ToString("C2");
				calcHealthTaxLabel.Text = healthTax.ToString("C2");
				calcLibraryTaxLabel.Text = libraryTax.ToString("C2");
				calcSoilTaxLabel.Text = soilTax.ToString("C2");
                #endregion

            }
            catch (Exception exp)
			{
				MessageBox.Show("Encountered an error while calculating the tax. Please try again.", exp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			#endregion
		}
        #endregion

        #region All propertyValTextBox control methods
        /// <summary>
        /// The method defines implementation for the Click event for the propertyValTextBox.
        /// It selects all text in the textbox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void propertyValTextBox_Click(object sender, EventArgs e)
		{
            #region If the textbox is clicked, select all text in the textbox.
            propertyValTextBox.SelectAll();
            #endregion
        }

        /// <summary>
        /// The method defines implementation for the Enter event for the propertyValTextBox.
        /// It selects all text in the textbox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void propertyValTextBox_Enter(object sender, EventArgs e)
		{
            #region If the textbox is clicked, select all text in the textbox.
            propertyValTextBox.SelectAll();
            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the propertyValTextBox.
        /// It disallows any characters to be entered in the textbox other than a valid number (possibly decimal) or control character.
        /// </summary>
        /// <param name="sender">Of type object, invokes the KeyPressEvent and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this textbox.</param>
        private void propertyValTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			#region If the key pressed is not a control key (e.g., backspace), digit, or period, set the Handled property to true to cancel the keyed input
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;             
            return;
            #endregion
        }

        /// <summary>
        /// The method defines implementation for the TextChanged event for the propertyValTextBox.
        /// It clears any items in the list box and all smart labels.
        /// </summary>
        /// <param name="sender">Of type object, invokes the TextChangedEvent and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void propertyValTextBox_TextChanged(object sender, EventArgs e)
		{
			#region Clear all form controls associated with displaying the calculations.
			calcTotalPropertyTaxesListBox.Items.Clear();
			calcStateTaxLabel.Text = null;
			calcCountyTaxLabel.Text = null;
			calcLibraryTaxLabel.Text = null;
			calcSoilTaxLabel.Text = null;
			calcSchoolTaxLabel.Text = null;
			calcHealthTaxLabel.Text = null;
			calcAmbulanceTaxLabel.Text = null;
			#endregion
		}
		#endregion
	}
}
#endregion