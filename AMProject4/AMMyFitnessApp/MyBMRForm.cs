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
        //declare constants MALE_WEIGHT_MULTIPLIER, MALE_HEIGHT_MULTIPLIER, MALE_AGE_MULTIPLIER, MALE_ADDITION
        const double MALE_WEIGHT_MULTIPLIER = 6.23;
        const double MALE_HEIGHT_MULTIPLIER = 12.7;
        const double MALE_AGE_MULTIPLIER = 6.8;
        const int MALE_ADDITION = 66;

        //declare constants FEMALE_WEIGHT_MULTIPLIER, FEMALE_HEIGHT_MULTIPLIER, FEMALE_AGE_MULTIPLIER, FEMALE_ADDITION
        const double FEMALE_WEIGHT_MULTIPLIER = 4.45;
        const double FEMALE_HEIGHT_MULTIPLIER = 4.7;
        const double FEMALE_AGE_MULTIPLIER = 4.7;
        const int FEMALE_ADDITION = 655;

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
            maleBMR = MALE_ADDITION + (MALE_WEIGHT_MULTIPLIER * profile.WEIGHT) +(MALE_HEIGHT_MULTIPLIER * profile.HEIGHT) -(MALE_AGE_MULTIPLIER * profile.AGE);
            femaleBMR = FEMALE_ADDITION + (FEMALE_WEIGHT_MULTIPLIER * profile.WEIGHT) +(FEMALE_HEIGHT_MULTIPLIER * profile.HEIGHT) -(FEMALE_AGE_MULTIPLIER * profile.AGE);

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
