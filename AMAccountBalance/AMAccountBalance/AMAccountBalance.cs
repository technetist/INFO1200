using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAccountBalance
{
    public partial class AMAccountBalance : Form
    {
        //declare interest rate constant
        const decimal INTEREST_RATE = 1.005M;
        
        public AMAccountBalance()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        /// <summary>
        /// click event to clear textboxes, list box, and balance label (user input and results)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear txtBoxes NumMonths and Start
            txtBoxNumMonths.Clear();
            txtBoxStart.Clear();

            //clear lstBox
            lstBoxMonthlyBalance.Items.Clear();

            //clear final balance label
            lblEndBalance.Text = "";

            //focus to txtBoxStart
            txtBoxStart.Focus();
        }

        /// <summary>
        /// click event to calculate ending account balance based on input from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables for months and balance
            int months;
            decimal balance;

            //clear lstBox
            lstBoxMonthlyBalance.Items.Clear();

            //validate user input for startBalance and set startBalance
            if (decimal.TryParse(txtBoxStart.Text, out balance))
            {
                //validate user input for months and set months
                if (int.TryParse(txtBoxNumMonths.Text, out months))
                {
                    //loop to calculate accumulated interest
                    for (int count = 1; count <= months; count++)
                    {
                        //calculate balance
                        balance *= INTEREST_RATE;

                        //display monthly balance in lstBox
                        lstBoxMonthlyBalance.Items.Add("The ending balance for month " + count + " is " + balance.ToString("c") + ".");
                    }

                    //display results
                    lblEndBalance.Text = "Your balance would be " + balance.ToString("c") + " at the end of " + months + " months.";
                }
                //invalid month entry
                else
                {
                    MessageBox.Show("Please enter a valid number for months", "Month Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //invalid startBalance entry
            else
            {
                //display error message
                MessageBox.Show("Please enter a valid number for the balance", "Balance Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
