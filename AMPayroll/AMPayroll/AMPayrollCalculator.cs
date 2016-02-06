using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMPayroll
{
    public partial class AMPayrollCalculator : Form
    {
        //declare constants BASE_HOURS, OVERTIME_MULTIPLIER
        const int BASE_HOURS = 40;
        const double OVERTIME_MULTIPLIER = 1.5;

        public AMPayrollCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event for calculate button 
        /// calculates pay based on user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables for hours, pay, overtimeHours, overTimePay, grossPay,
            decimal pay, overtimePay, grossPay;
            double hours, overtimeHours;

            //validate user input
            try
            {
                //set hours and pay from user input
                hours = double.Parse(txtBoxHoursWorked.Text);
                pay = decimal.Parse(txtBoxHourlyPay.Text);

                //if overtime
                if (hours > BASE_HOURS)
                {
                    //calculate overtimeHours
                    overtimeHours = hours - BASE_HOURS;

                    //calculate overtimePay
                    overtimePay = (decimal)overtimeHours * pay * (decimal)OVERTIME_MULTIPLIER;

                    //calculate base pay
                    grossPay = BASE_HOURS * pay;

                    //calculate gross pay
                    grossPay += overtimePay;

                    //display results
                    lblCalcResults.Text = grossPay.ToString("c2");
                }

                
                else
                {
                    //else calculate grossPay
                    grossPay = (decimal)hours * pay;

                    //display results
                    lblCalcResults.Text = grossPay.ToString("c2");
                }
            }
            catch
            {
                //display error
                MessageBox.Show("Please enter a valid number","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// click event for clear button 
        /// clears user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all textboxes (pay, hours)
            txtBoxHourlyPay.Clear();
            txtBoxHoursWorked.Clear();

            //clear results label
            lblCalcResults.Text = "";

            //focus in hours textbox
            txtBoxHoursWorked.Focus();
        }

        /// <summary>
        /// click event for the exit button
        /// closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
