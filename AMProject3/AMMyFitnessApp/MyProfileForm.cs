//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 02/05/2016
//Project #: 3
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
        public int weight { get; set; }
        public int height { get; set; }
        public int age { get; set; }

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
            //assign weight property to text box value
            weight = int.Parse(txtBoxWeight.Text);
            //assign height property to text box value
            height = int.Parse(txtBoxHeight.Text);
            //assign age property to text box value
            age = int.Parse(txtBoxAge.Text);

            //close form
            this.Close();
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
    }
}
