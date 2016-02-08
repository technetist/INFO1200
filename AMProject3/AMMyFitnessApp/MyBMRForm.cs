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
    public partial class MyBMRForm : Form
    {
        public MyBMRForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event for Calculate BMR button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBMRCalc_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyProfileForm profile = new MyProfileForm();
            //display MyProfile form
            profile.ShowDialog();

            //declare variables for maleBMR and femaleBMR
            double maleBMR;
            double femaleBMR;

            //calculate BMR for the genders, based on input from profile form
            maleBMR = 66 + (6.23 * profile.weight) +(12.7 * profile.height) -(6.8 * profile.age);
            femaleBMR = 655 + (4.35 * profile.weight) +(4.7 * profile.height) -(4.7 * profile.age);

            //display results of the calculation in respective lables
            lblMaleBMR.Text = maleBMR.ToString("n2");
            lblFemaleBMR.Text = femaleBMR.ToString("n2");
        }

        /// <summary>
        /// click event for the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBMRClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
