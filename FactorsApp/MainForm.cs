/**
 * Project name: FactorsApp
 * Project purpose: Calculates the factors of numbers based on a beginning and ending number (text boxes) and displays the number with the most factors and its number of factors in a label.
 * Note: Comments use XML commenting, which can be used as Javadoc (this is good practice in industry).
 * XML commenting can be eventually translated to HTML files like Javadoc which also converts to HTML files. 
 * Created by: Amit Prakash (aprakas5) on 5/1/2023 in C# 
 */

#region Importing Different Libraries for the FactorsApp namespace

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

/**
 * The namespace for the app, contains MainForm partial class.
 */
namespace FactorsApp
{
    /// <summary>
    /// Some implementation for the MainForm in a public partial class (part of Form class).
    /// </summary>
    public partial class MainForm : Form
    {
        #region MainForm Class Constructor 

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region All button methods

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
        /// This method defines the implementation for the click event for the displayButton. 
        /// It will display each number for [beginningNumber, endingNumber] and 
        /// the number with the most factors and its factors in the label.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this button.</param>
        private void displayButton_Click(object sender, EventArgs e)
        {
            #region Try...Catch for unexpected error-handling

            try
            {

                #region Initialize and define variables/constants

                int beginningNumber = 0; // must be in the range [-49, 49]
                int endingNumber = 0; // must be in the range [-50, 50] and after beginningNumber
                const int BEGINNING_NUMBER_MAX = 49;
                const int ENDING_NUMBER_MAX = 50;
                Dictionary<int, List<int>> factorValues = new Dictionary<int, List<int>>(); //Dictionary to store factors and number pairs
                Dictionary<string, int> greatestFactorNum = new Dictionary<string, int>(); //Dictionary to store max number of factors and its associated number
                greatestFactorNum.Add("Number", -51); //Should not be possible
                greatestFactorNum.Add("Factors", 0); //Should not be possible

                #endregion

                #region All error-handling/input validation

                if (!int.TryParse(beginningNumberTextBox.Text, out beginningNumber))
                {
                    MessageBox.Show("Please enter a valid integer for the beginning number.", this.Text, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(endingNumberTextBox.Text, out endingNumber))
                {
                    MessageBox.Show("Please enter a valid integer for the ending number.", this.Text, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(Math.Abs(beginningNumber) > BEGINNING_NUMBER_MAX)
                {
                    MessageBox.Show("Please enter a valid integer in the range [-49, 49] for the beginning number.", 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Math.Abs(endingNumber) > ENDING_NUMBER_MAX)
                {
                    MessageBox.Show("Please enter a valid integer in the range [-50, 50] for the ending number.", 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(beginningNumber > endingNumber)
                {
                    MessageBox.Show("Please enter a valid integer for the beginning and ending numbers " +
                        "so that the ending number is greater than the beginning number.", this.Text, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #endregion

                #region For-loop for calculations

                for (int i = beginningNumber; i <= endingNumber; i++)
                {
                    //New ListViewItem for the displayListView
                    ListViewItem listViewItem = new ListViewItem(i.ToString("N0"));

                    //Check the base cases of 0 and +1/-1
                    if (i == 0 || Math.Abs(i) == 1)
                    {
                        factorValues.Add(i, new List<int>() { i });
                    }

                    //Check the negative values
                    else if (i < 0)
                    {
                        // List numFactors initialized with -1 and the number itself
                        List<int> numFactors = new List<int>() { -1, i };

                        //Start at 2 and check every factor up to Math.Abs(i) since i will be negative
                        for (int j = 2; j < Math.Abs(i); j++)
                            if (i % j == 0) //If it evenly divides
                                numFactors.Add(j * -1); //Add the negative version into numFactors

                        numFactors.Sort(); //Sort the list least to greatest
                        factorValues.Add(i, numFactors); //Add to the dictionary
                    }

                    //Check the positive values
                    else
                    {
                        // List numFactors initialized with 1 and the number itself
                        List<int> numFactors = new List<int>() { 1, i };

                        //Start at 2 and check every factor up to i
                        for (int j = 2; j < i; j++)
                            if (i % j == 0) //If it evenly divides
                                numFactors.Add(j); //Add the negative version into numFactors

                        numFactors.Sort(); //Sort the list least to greatest
                        factorValues.Add(i, numFactors); //Add to the dictionary
                    }

                    //Update the greatestFactorNum for each iteration storing the greatest number if the same
                    if (factorValues[i].Count >= greatestFactorNum["Factors"])
                    {
                        greatestFactorNum["Number"] = i;
                        greatestFactorNum["Factors"] = factorValues[i].Count;
                    }

                    listViewItem.SubItems.Add(string.Join(", ", factorValues[i])); //Format the list for output
                    displayListView.Items.Add(listViewItem); //Add the listViewItem to displayListView
                }

                #endregion

                #region Display Number with the most factors

                greatestFactorsLabel.Text = "Number: " + greatestFactorNum["Number"].ToString("N0") + ", Factors: " + greatestFactorNum["Factors"].ToString("N0");

                #endregion
            }

            catch (Exception)
            {
                //Unexpected error message
                MessageBox.Show("There was an unexpected error, please try again later.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        #endregion

        #region All text box methods

        #region All beginningTextBox methods

        /// <summary>
        /// The method defines implementation for the Click event for the beginningNumberTextBox.
        /// It selects all text in the textbox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void beginningNumberTextBox_Click(object sender, EventArgs e)
        {
            #region Select all text in beginningNumberTextBox if clicked

            beginningNumberTextBox.SelectAll();

            #endregion

            #region  Focus on the beginningNumberTextBox

            beginningNumberTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the Enter event for the beginningNumberTextBox.
        /// It selects all text in the textbox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void beginningNumberTextBox_Enter(object sender, EventArgs e)
        {
            #region Select all text in beginningNumberTextBox if clicked

            beginningNumberTextBox.SelectAll();

            #endregion

            #region  Focus on the beginningNumberTextBox

            beginningNumberTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the beginningNumberTextBox.
        /// Only allows digits, control characters, and the negative symbol. 
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this textbox.</param>
        private void beginningNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region This conditional only allows digits, control characters, and the negative symbol. 

            // The symbol ! means “not”; the symbols && mean “and”. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            #endregion

            #region  Focus on the beginningNumberTextBox

            beginningNumberTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the TextChanged event for the beginningNumberTextBox.
        /// It clears all text in the displayListView and greatestFactorsNumLabel.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void beginningNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            #region Clear the displayListView and greatestFactorsLabel

            displayListView.Items.Clear();
            greatestFactorsLabel.Text = String.Empty;

            #endregion

            #region Focus on the beginningNumberTextBox

            beginningNumberTextBox.Focus();

            #endregion
        }

        #endregion

        #region All endingTextBox methods

        /// <summary>
        /// The method defines implementation for the Click event for the endingNumberTextBox.
        /// It selects all text in the textbox.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void endingNumberTextBox_Click(object sender, EventArgs e)
        {
            #region Select all text in endingNumberTextBox if clicked

            endingNumberTextBox.SelectAll();

            #endregion

            #region  Focus on the endingNumberTextBox

            endingNumberTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the endingNumberTextBox.
        /// Only allows digits, control characters, the negative symbol, and the period. 
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this textbox.</param>
        private void endingNumberTextBox_Enter(object sender, EventArgs e)
        {
            #region Select all text in endingNumberTextBox if clicked

            endingNumberTextBox.SelectAll();

            #endregion

            #region  Focus on the endingNumberTextBox

            endingNumberTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the KeyPress event for the endingNumberTextBox.
        /// Only allows digits, control characters, and the negative symbol. 
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of KeyPressEventArgs, all the event data for this textbox.</param>
        private void endingNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region This conditional only allows digits, control characters, and the negative symbol. 

            // The symbol ! means “not”; the symbols && mean “and”. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            #endregion

            #region  Focus on the beginningNumberTextBox

            endingNumberTextBox.Focus();

            #endregion
        }

        /// <summary>
        /// The method defines implementation for the TextChanged event for the endingNumberTextBox.
        /// It clears all text in the displayListView and greatestFactorNumLabel.
        /// </summary>
        /// <param name="sender">Of type object, invokes the Event and therefore this code.</param>
        /// <param name="e">Of type of EventArgs, all the event data for this textbox.</param>
        private void endingNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            #region Clear the displayListView and greatestFactorsLabel

            displayListView.Items.Clear();
            greatestFactorsLabel.Text = String.Empty;

            #endregion

            #region Focus on the endingNumberTextBox

            endingNumberTextBox.Focus();

            #endregion
        }

        #endregion

        #endregion
    }
}
