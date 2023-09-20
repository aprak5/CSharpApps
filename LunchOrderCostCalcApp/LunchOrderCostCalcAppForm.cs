/**
 * Project name: LunchOrderCostCalcApp
 * Project purpose: Display/calculate the total lunch cost, by taking the order from user (through the respective textboxes).
 * New Usecases: Add a tip (checkbox/textbox), add click, enter, and keypress events for all textboxes
 * Note: Comments use XML commenting, which can be used as Javadoc (this was approved by Dr. Fowler).
 * XML commenting can be eventually translated to HTML files like Javadoc which also converts to HTML files. 
 * Created/revised by: Dr. Fowler (slfowler), Amit Prakash (aprakas5) on 9/23/2022 in C# 
 */

#region Importing Different Libraries for the LunchOrderCostCalcApp namespace

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

# region The Main Functionality for the LunchOrderCostCalcApp

/**
 * The namespace for the app, contains LunchOrderCostCalcAppForm partial class.
 */
namespace LunchOrderCostCalcApp
{
    /**
	 * Some implementation for the LunchOrderCostCalcAppForm in a public partial class (part of Form class).
	 */
    public partial class LunchOrderCostCalcAppForm : Form
    {
        #region LunchOrderCostCalcAppForm Class Constructor 

        /// <summary>
        /// Constructor for the main form for the design, basically initializes the components of the MainForm object.
        /// </summary>
        /// 
        public LunchOrderCostCalcAppForm()
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
        /// The method defines implementation for the Click event for the clearButton.
        /// It clears all textboxes and smart labels when the clearButton is clicked.. 
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            #region Clear all three smart labels

            calcSubtotalLabel.Text = String.Empty;
            calcSalesTaxLabel.Text = String.Empty;
            calcTotalPriceLabel.Text = String.Empty;

            #endregion

            #region Clear all twelve textboxes

            bowlOfSoupTextBox.Text = String.Empty;
            ceasarSaladTextBox.Text = String.Empty;
            calamariTextBox.Text = String.Empty;
            italianSubTextBox.Text = String.Empty;
            meatballTextBox.Text = String.Empty;
            sausageTextBox.Text = String.Empty;
            ravioliTextBox.Text = String.Empty;
            lasagnaTextBox.Text = String.Empty;
            spumonicTextBox.Text = String.Empty;
            cheesecakeTextBox.Text = String.Empty;
            chickenFingersTextBox.Text = String.Empty;
            pizzaSliceTextBox.Text = String.Empty;

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the Click event for the calculateButton.
        /// Calculates and displays the subtotal, sales tax, and total price for the customer if the calculateButton is clicked. 
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            #region Try...Catch to handle any errors arising from the code, if an exception exists a MessageBox shows a respective message.

            try
            {
                #region Declarations for most of the variables and constants to be used to calculate the total price

                int bowlOfSoupNum, ceasarSaladNum, calamariNum, italianSubNum, meatballNum, sausageNum,
                    ravioliNum, lasagnaNum, spumonicNum, cheesecakeNum, chickenFingersNum, pizzaSliceNum;
                //New for the tip use-case
                double tip;
                const double appetizersPrice = 5; //for bowl of soup, ceasar salad, calamari
                const double sandwichesPrice = 6; //for italian sub, meatball, sausage
                const double platesPrice = 7; //ravioli, lasagna
                const double dessertsPrice = 4; //spumoni, cheesecake
                const double otherPrice = 5; //chicken fingers, pizza slice
                const double salesTaxRate = 0.08;

                #endregion

                #region Initialize the number of each menu item to the respective variables

				if (!int.TryParse(bowlOfSoupTextBox.Text, out bowlOfSoupNum))
				{
					MessageBox.Show("Please a valid quantity for the bowl(s) of soup.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
				}
				if (!int.TryParse(ceasarSaladTextBox.Text, out ceasarSaladNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the ceasar salad(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(calamariTextBox.Text, out calamariNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the calamari(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(italianSubTextBox.Text, out italianSubNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the italian sub(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(meatballTextBox.Text, out meatballNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the meatball sub(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(sausageTextBox.Text, out sausageNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the sausage sub(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(ravioliTextBox.Text, out ravioliNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the ravioli(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(lasagnaTextBox.Text, out lasagnaNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the lasagna(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(spumonicTextBox.Text, out spumonicNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the spumonic(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(cheesecakeTextBox.Text, out cheesecakeNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the cheesecake(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(chickenFingersTextBox.Text, out chickenFingersNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the chicken finger(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!int.TryParse(pizzaSliceTextBox.Text, out pizzaSliceNum))
				{ 
                    MessageBox.Show("Please a valid quantity for the pizza slice(s).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
				if (!double.TryParse(tipTextBox.Text, out tip))
				{ 
                    MessageBox.Show("Please a valid tip amount.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }

                #endregion

                #region The subtotal is calculated using all the appropriate variables

                double subtotal = bowlOfSoupNum * appetizersPrice;
                subtotal += ceasarSaladNum * appetizersPrice;
                subtotal += calamariNum * appetizersPrice;
                subtotal += italianSubNum * sandwichesPrice;
                subtotal += meatballNum * sandwichesPrice;
                subtotal += sausageNum * sandwichesPrice;
                subtotal += ravioliNum * platesPrice;
                subtotal += lasagnaNum * platesPrice;
                subtotal += spumonicNum * dessertsPrice;
                subtotal += cheesecakeNum * dessertsPrice;
                subtotal += chickenFingersNum * otherPrice;
                subtotal += pizzaSliceNum * otherPrice;
                //New for tip
                subtotal += tip;

                #endregion

                #region Calculate the subtotal and totalPrice using the appropiate variables

                double salesTax = subtotal * salesTaxRate;
                double totalPrice = subtotal + salesTax;

                #endregion

                #region Display the variables in the smart labels

                calcSubtotalLabel.Text = subtotal.ToString("C2");
                calcSalesTaxLabel.Text = salesTax.ToString("C2");
                calcTotalPriceLabel.Text = totalPrice.ToString("C2");

                #endregion

            }
            catch (Exception exp)
            {
                MessageBox.Show("There was an error in calculating the total price. Please try again.", exp.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        #endregion

        #region NEW USE CASE: Add a Tip

        //See calculateButton_Click for more related functionality

        /// <summary>
        /// This method controls the tipTextBox based on the Checked property of the tipCheckBox
        /// </summary>
        /// <param name="sender">The sender for this event (will be tipCheckBox)</param>
        /// <param name="e">The EventArgs sent from the sender (tipCheckBox)</param>
        private void tipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tipTextbox visibility depends on this checkbox
            if(tipCheckBox.Checked == true)
                tipTextBox.Visible = true;
            else
                tipTextBox.Visible = false; 
        }

        #endregion

        //Should also consider adding requirements for Click, Enter, and KeyPress events
    }
}

#endregion
