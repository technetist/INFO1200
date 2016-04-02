using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class AMCupsToOuncesForm : Form
    {
        //create a constant for number of cups in ounces
        const double OUNCES = 8;

        public AMCupsToOuncesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event for convert button to convert cups to ounces based on input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //declare variables for cups and ounces
            double cups = 0;
            double ounces = 0;

            //method to validate, get, and set cups
            if (CupsValidation(ref cups))
            {
                //convert cups to ounces
                ounces = CupsConversion(cups);

                //display results method
                ouncesLabel.Text = ounces.ToString("n2");
            }


        }

        /// <summary>
        /// cups conversion to ounces
        /// </summary>
        /// <param name="cups"></param>
        /// <returns></returns>
        private double CupsConversion(double cups)
        {
            //convert cups to ounces using constant OUNCES;
            return cups * OUNCES;
        }

        /// <summary>
        /// validation of cups variable
        /// </summary>
        /// <param name="cups"></param>
        /// <returns></returns>
        private bool CupsValidation(ref double cups)
        {
            //validate user input for cups, must be greater than 0
            if (double.TryParse(cupsTextBox.Text, out cups) && cups > 0)
            {
                //return true if valid
                return true;
            }
            //error if invalid
            else
            {
                //display error if user input is invalid
                MessageBox.Show("Please enter a valid number for cups");
                //clear and set focus
                cupsTextBox.Clear();
                cupsTextBox.Focus();
                //return false if invalid
                return false;
            }
            
        }

        /// <summary>
        /// click event to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
