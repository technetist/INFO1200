using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTestAverage
{
    public partial class TestAverageForm : Form
    {
        public TestAverageForm()
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
        /// click event to clear user input and results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear textboxes
            txtBoxTest1.Clear();
            txtBoxTest2.Clear();
            txtBoxTest3.Clear();

            //clear results label
            lblAvgResult.Text = "Result";
        }

        /// <summary>
        /// click event to calculate average test score based on user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcAvg_Click(object sender, EventArgs e)
        {
            //declare variables for test1, test2, test3, and average
            double test1, test2, test3, average;
            //validate user's input for all textboxes
            try {
                //set test 1 score
                test1 = double.Parse(txtBoxTest1.Text);

                //set test 2 score
                test2 = double.Parse(txtBoxTest2.Text);

                //set test 3 score
                test3 = double.Parse(txtBoxTest3.Text);

                //calculate average test score
                average = (test1 + test2 + test3) / 3;
                average = average / 100;

                //display average
                lblAvgResult.Text = average.ToString("p2");
            }
            catch {
                //display error if input is invalid
                MessageBox.Show("Invalid input, please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
