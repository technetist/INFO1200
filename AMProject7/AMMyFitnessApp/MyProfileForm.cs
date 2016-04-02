//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 03/25/2016
//Project #: 7
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMMyFitnessApp
{
    public partial class MyProfileForm : Form
    {
        //set min max values
        const int MIN_AGE = 12;
        const int MAX_AGE = 120;
        const int MIN_WEIGHT = 50;
        const int MAX_WEIGHT = 1000;
        const int MIN_HEIGHT = 48;
        const int MAX_HEIGHT = 96;

        //declare temp value variables
        int tempAge, tempHeight, tempWeight;

        //declare public variables weight, height, age
        public int WEIGHT { get; set; }
        public int HEIGHT { get; set; }
        public int AGE { get; set; }

        public MyProfileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event for the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfileExit_Click(object sender, EventArgs e)
        {
            //validate user's input
            if(int.TryParse(txtBoxWeight.Text, out tempWeight) && tempWeight <= MAX_WEIGHT && tempWeight >= MIN_WEIGHT)
            {
                if(int.TryParse(txtBoxHeight.Text, out tempHeight) && tempHeight <= MAX_HEIGHT && tempHeight >= MIN_HEIGHT)
                {
                    if(int.TryParse(txtBoxAge.Text, out tempAge) && tempAge >= MIN_AGE && tempAge <= MAX_AGE)
                    {
                        //assign weight constant to tempWeight
                        WEIGHT = tempWeight;
                        //assign age constant to tempAge
                        AGE = tempAge;
                        //assign height constant to tempHeight
                        HEIGHT = tempHeight;

                        //close form
                        this.Close();
                    }
                    //else for age
                    else
                    {
                        //display age error message
                        MessageBox.Show("Hold up, your age is not a valid integer! Keep it between 12 and 120", "Age Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //clear age box
                        txtBoxAge.Clear();
                        //set focus
                        txtBoxAge.Focus();
                        //keep button from closing form
                        this.DialogResult = DialogResult.None;
                    }
                }
                //else for height
                else
                {
                    //display height error message
                    MessageBox.Show("Hold up, your height is not a valid integer! Keep it between 48 and 96", "Height Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //clear height box
                    txtBoxHeight.Clear();
                    //set focus
                    txtBoxHeight.Focus();
                    //keep button from closing form
                    this.DialogResult = DialogResult.None;
                }
            }
            //else for weight
            else
            {
                //display weight error message
                MessageBox.Show("Hold up, your weight is not a valid integer! Keep it between 50 and 1000", "Weight Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //clear weight box
                txtBoxWeight.Clear();
                //set focus
                txtBoxWeight.Focus();
                //keep button from closing form
                this.DialogResult = DialogResult.None;
            }
            
        }

        /// <summary>
        /// click event for the before button. Shows before image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBefore_Click(object sender, EventArgs e)
        {
            //show the before image 
            picBoxBefore.Visible = true;
            //hide the after image
            picBoxAfter.Visible = false;
        }

        /// <summary>
        /// click event for the after button. Shows after image and message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfter_Click(object sender, EventArgs e)
        {
            //show the after image 
            picBoxAfter.Visible = true;
            //hide the before image
            picBoxBefore.Visible = false;
            //displays congratulatory message
            MessageBox.Show("Congratulations!","Congrats", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// click event for clear button. Clears textboxes in form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Textboxes
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxPreferredName.Text = "";
            txtBoxWeight.Text = "";
            txtBoxHeight.Text = "";
            txtBoxAge.Text = "";
            //reset Constants
            WEIGHT = 0;
            HEIGHT = 0;
            AGE = 0;
            //don't close form
            this.DialogResult = DialogResult.None;
        }
    }
}
