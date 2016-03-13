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
using System.Threading;
using System.Media;


namespace AMMyFitnessApp
{
    public partial class MyTimerForm : Form
    {
        //declare constant variable for seconds
        const int SECS = 1000;


        //declare variable for time
        int time;

        //declare variable for rest interval
        int restInterval;

        public MyTimerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event to add exercises and time to list boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //validate user input for exercise
            if (txtBoxExercise.Text != "")
            {
                //validate user input for time
                if (int.TryParse(txtBoxTime.Text, out time) && time > 0)
                {
                    //add exercise to exercise listbox
                    lstBoxExercise.Items.Add(txtBoxExercise.Text);
                    //add time to time list box
                    lstBoxTime.Items.Add(time);

                    //clear text boxes
                    txtBoxExercise.Clear();
                    txtBoxTime.Clear();

                    //focus to exercise
                    txtBoxExercise.Focus();
                }

                //error message for time
                else
                {
                    MessageBox.Show("Please enter a valid number for Time", "Time Error");
                    //clear and set focus
                    txtBoxTime.Clear();
                    txtBoxTime.Focus();
                }
            }

            //error message for exercise
            else
            {
                MessageBox.Show("Please enter a valid text entry for Exercise", "Exercise Error");
                //clear and set focus
                txtBoxExercise.Clear();
                txtBoxExercise.Focus();
            }
        }

        /// <summary>
        /// click event to validate all user entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSumbit_Click(object sender, EventArgs e)
        {
          

            //validate rest interval
            if (int.TryParse(txtBoxRest.Text, out restInterval) && restInterval > 0)
            {
                //check exercise list box has at least one exercise
                if (lstBoxExercise.Items.Count > 0)
                {
                    //check time list box has at least one item
                    if (lstBoxTime.Items.Count > 0)
                    {
                        //success message box
                        MessageBox.Show("Your items were added!", "Success!");

                        //enable start button
                        btnTimerStart.Enabled = true;
                    }
                    else
                    {
                        //display error for not enough times
                        MessageBox.Show("Please add at least one time", "Time Number Error");
                        //set focus
                        txtBoxTime.Focus();
                    }
                }
                else
                {
                    //display error for not enough exercises
                    MessageBox.Show("Please add at least one exercise", "Exercise Number Error");
                    //set focus
                    txtBoxExercise.Focus();
                }
            }
            else
            {
                //display error for rest interval
                MessageBox.Show("Please enter a valid number for a rest interval","Interval Error");
                //clear and set focus
                txtBoxRest.Clear();
                txtBoxRest.Focus();
            }
        }
        /// <summary>
        /// click event for start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            //loop through each exercise
            for (int i = 0; i < lstBoxExercise.Items.Count; i++)
            {
                // Display Exercise
                lblDisplayExercise.Text = lstBoxExercise.Items[i].ToString();
                time = int.Parse(lstBoxTime.Items[i].ToString());
                //loop through timer
                for (int j = time; j >= 0; j--)
                {
                    //time span for exercise time
                    TimeSpan myTime = new TimeSpan(0, 0, j);

                    //display time in label
                    lblDisplayTime.Text = myTime.ToString(@"mm\:ss");

                    //sleep for one second
                    Thread.Sleep(SECS);

                    //do events
                    Application.DoEvents();

                    //check for last three seconds and play sound
                    if (j < 3)
                    {
                        SystemSounds.Beep.Play();
                    }

                }
                //loop for rest interval
                for (int k = restInterval; k >= 0; k--)
                {
                    //time span for rest time
                    TimeSpan restTime = new TimeSpan(0, 0, k);

                    //display time and exercise
                    lblDisplayTime.Text = restTime.ToString(@"mm\:ss");
                    lblDisplayExercise.Text = "Rest";

                    //sleep for one second
                    Thread.Sleep(SECS);

                    //do events
                    Application.DoEvents();

                    //check for last three seconds and play sound
                    if ( k < 3 )
                    {
                        SystemSounds.Beep.Play();
                    }
                }
            }
            //display finished message
            MessageBox.Show("Work Out Completed! \n\n Well done!","Done");
            //clear display labels
            lblDisplayExercise.Text = "";
            lblDisplayTime.Text = "";
        }

        //click event for clear button. Clears all user input data
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxTime.Clear();
            txtBoxRest.Clear();
            txtBoxExercise.Clear();
            lstBoxExercise.Items.Clear();
            lstBoxTime.Items.Clear();
        }
    }
}
