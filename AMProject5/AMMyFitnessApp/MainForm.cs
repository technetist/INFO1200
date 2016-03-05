//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 03/03/2016
//Project #: 5
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
    }
}
