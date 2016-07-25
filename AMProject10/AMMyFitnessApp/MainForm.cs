//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 04/14/2016
//Project #: 10
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //display the date in lblShowDate
            lblShowDate.Text = DateTime.Now.ToString("d");
        }

        /// <summary>
        /// click event for the profile button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfile_Click(object sender, EventArgs e)
        {   
            //call form's constructor and assign variable
            MyProfileForm profile = new MyProfileForm();
            //display MyProfile form
            profile.ShowDialog();
        }

        /// <summary>
        /// click event for the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        /// <summary>
        /// click event for the BMR button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBMR_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyBMRForm bmrForm = new MyBMRForm();
            //display MyBMR form
            bmrForm.ShowDialog();
        }

        /// <summary>
        /// click event for timer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyTimer_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyTimerForm timer = new MyTimerForm();
            //display timer form
            timer.ShowDialog();
        }

        /// <summary>
        /// click event for the exercise form button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExerciseLog_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyExerciseLogForm exerciseLog = new MyExerciseLogForm();
            //display Exercise Log form
            exerciseLog.ShowDialog();
        }

        /// <summary>
        /// click event for the water log button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWaterLog_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyWaterForm waterLog = new MyWaterForm();
            //display Water Log form
            waterLog.ShowDialog();
        }

        /// <summary>
        /// click event for food log button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoodLog_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyFoodItemForm foodLog = new MyFoodItemForm();
            //display Food Log form
            foodLog.ShowDialog();
        }

        /// <summary>
        /// click event for meal plan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyMealPlanForm mealPlan = new MyMealPlanForm();
            //display meal plan form
            mealPlan.ShowDialog();
        }
    }
}