//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 03/10/2016
//Project #: 6
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
        const double FEMALE_WEIGHT_MULTIPLIER = 4.35;
        const double FEMALE_HEIGHT_MULTIPLIER = 4.7;
        const double FEMALE_AGE_MULTIPLIER = 4.7;
        const int FEMALE_ADDITION = 655;

        //declare activity multipliers
        const double LITTLE_EXCERCISE = 1.2;
        const double LIGHT_EXCERCISE = 1.375;
        const double MODERATE_EXCERCISE = 1.55;
        const double HEAVY_EXCERCISE = 1.725;
        const double VHEAVY_EXCERCISE = 1.9;

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

            //declare variables for BMR and activity level
            double BMR;
            int activityLevel = lstBoxActivityLevel.SelectedIndex;

            if (rBtnMale.Checked)
            {
                //calculate Male BMR, based on input from profile form
                BMR = MALE_ADDITION + (MALE_WEIGHT_MULTIPLIER * profile.WEIGHT) + (MALE_HEIGHT_MULTIPLIER * profile.HEIGHT) - (MALE_AGE_MULTIPLIER * profile.AGE);
            }
            else
            {
                //calculate Female BMR, based on input from profile form
                BMR = FEMALE_ADDITION + (FEMALE_WEIGHT_MULTIPLIER * profile.WEIGHT) + (FEMALE_HEIGHT_MULTIPLIER * profile.HEIGHT) - (FEMALE_AGE_MULTIPLIER * profile.AGE);
            }

            //switch statement for activity level
            switch (activityLevel)
            {
                case 0:
                    BMR *= LITTLE_EXCERCISE;
                    break;
                case 1:
                    BMR *= LIGHT_EXCERCISE;
                    break;
                case 2:
                    BMR *= MODERATE_EXCERCISE;
                    break;
                case 3:
                    BMR *= HEAVY_EXCERCISE;
                    break;
                case 4:
                    BMR *= VHEAVY_EXCERCISE;
                    break;
                default:
                    MessageBox.Show("Don't forget to select an activity level!", "Activity Level Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //don't close form
                    this.DialogResult = DialogResult.None;
                    break;
            }

            //display results of the calculation in respective lables
            txtBoxBMR.Text = BMR.ToString("n2");
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
