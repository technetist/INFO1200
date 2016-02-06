using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMLoanApplication
{
    public partial class AMLoanQualifierForm : Form
    {
        public AMLoanQualifierForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event to clear user input data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all text boxes
            txtBoxSalary.Text = "";
            txtBoxYearsWorked.Text = "";

            //clear approval images
            picBoxApprove.Visible = false;
            picBoxDeny.Visible = false;

            //focus on salary textbox
            txtBoxSalary.Focus();
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
        /// click event to verify qualification for loan 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare constant variables for MIN_YEARS and MIN_SALARY
            const decimal MIN_SALARY = 40000;
            const int MIN_YEARS = 2;

            //declare variables for salary and yearsOnJob
            decimal salary;
            int yearsOnJob;

            //validate salary and check minimum qualifications
            if (decimal.TryParse(txtBoxSalary.Text, out salary) && salary >= MIN_SALARY)
            {
                //validate year on job and check minimum qulifications
                if (int.TryParse(txtBoxYearsWorked.Text, out yearsOnJob) && yearsOnJob >= MIN_YEARS)
                {
                    //display qualified message
                    MessageBox.Show("You qualify!");

                    //display spproved picture
                    picBoxApprove.Visible = true;

                    //hide denied image
                    picBoxDeny.Visible = false;
                }
                else
                {
                    //else display error for years
                    MessageBox.Show("You do not qualify, years must be more than 2.");

                    //display denied picture
                    picBoxDeny.Visible = true;

                    //hide approved image
                    picBoxApprove.Visible = false;
                }
            }
            //else display error for salary
            else
            {
                //display error for salary
                MessageBox.Show("You do not qualify, salary must be more than $40,000.");
                
                //display denied picture
                picBoxDeny.Visible = true;

                //hide approved image
                picBoxApprove.Visible = false;
            }
            
        }
    }
}
