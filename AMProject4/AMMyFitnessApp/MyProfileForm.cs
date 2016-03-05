//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 02/20/2016
//Project #: 4
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
            try
            {
                //assign weight property to text box value
                WEIGHT = int.Parse(txtBoxWeight.Text);
                //assign height property to text box value
                HEIGHT = int.Parse(txtBoxHeight.Text);
                //assign age property to text box value
                AGE = int.Parse(txtBoxAge.Text);

                //close form
                this.Close();
            }
            catch
            {   //display error message
                MessageBox.Show("Hold up, we need valid information for weight, height, and age","Input Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //set focus on weight textbox
                txtBoxWeight.Focus();
                //clear weight, height, and age textboxes
                txtBoxWeight.Text = "";
                txtBoxHeight.Text = "";
                txtBoxAge.Text = "";
                //keep button from closing form upon error
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
            //clear textboxes to empty string
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxPreferredName.Text = "";
            txtBoxWeight.Text = "";
            txtBoxHeight.Text = "";
            txtBoxAge.Text = "";
            //reset public variables of WEIGHT, HEIGHT, and AGE
            WEIGHT = 0;
            HEIGHT = 0;
            AGE = 0;
            //Keep form from closing
            this.DialogResult = DialogResult.None;
        }
    }
}
