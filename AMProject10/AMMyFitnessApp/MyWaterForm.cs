//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 03/31/2016
//Project #: 8
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
//use system.IO
using System.IO;

namespace AMMyFitnessApp
{
    public partial class MyWaterForm : Form
    {
        //constatnt for daily water goal
        const int WATER_GOAL = 8;

        //create variable for water counter
        private int CUPS;

        public MyWaterForm()
        {
            InitializeComponent();
        }

        //value returning method for file name
        public string GetFileName(out string filename)
        {
            //set string today to current date
            string today = DateTime.Now.ToString("d");
            //remove illegal characters
            today = today.Replace('/', '_');
            //concatenate filename
            filename = today + "water" + ".txt";
            //return filename
            return filename;
        }

        /// <summary>
        /// method for hiding glasses of water
        /// </summary>
        private void HideWater()
        {
            //hide picBoxes
            picBoxWater1.Hide();
            picBoxWater2.Hide();
            picBoxWater3.Hide();
            picBoxWater4.Hide();
            picBoxWater5.Hide();
            picBoxWater6.Hide();
            picBoxWater7.Hide();
            picBoxWater8.Hide();
        }

        /// <summary>
        /// method for showing glasses of water
        /// </summary>
        /// <param name="cups"></param>
        private void ShowWater(int cups)
        {
            //switch based on number of glasses consumed
            switch (cups)
            {
                //hide all cups if 0 cups drank
                case 0:
                    picBoxWater1.Hide();
                    picBoxWater2.Hide();
                    picBoxWater3.Hide();
                    picBoxWater4.Hide();
                    picBoxWater5.Hide();
                    picBoxWater6.Hide();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first cup of 1 cup drank
                case 1:
                    picBoxWater1.Show();
                    picBoxWater2.Hide();
                    picBoxWater3.Hide();
                    picBoxWater4.Hide();
                    picBoxWater5.Hide();
                    picBoxWater6.Hide();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first 2 cups if 2 cups drank
                case 2:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Hide();
                    picBoxWater4.Hide();
                    picBoxWater5.Hide();
                    picBoxWater6.Hide();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first 3 cups if 3 cups drank
                case 3:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Hide();
                    picBoxWater5.Hide();
                    picBoxWater6.Hide();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first 4 cups if 4 cups drank
                case 4:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Hide();
                    picBoxWater6.Hide();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first 5 cups if 5 cups drank
                case 5:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Hide();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first 6 cups if 6 cups drank
                case 6:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Hide();
                    picBoxWater8.Hide();
                    break;
                //show first 7 cups if 7 cups drank
                case 7:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    picBoxWater8.Hide();
                    break;
                //show 8 cups if 8 cups drank
                case 8:
                    picBoxWater1.Show();
                    picBoxWater2.Show();
                    picBoxWater3.Show();
                    picBoxWater4.Show();
                    picBoxWater5.Show();
                    picBoxWater6.Show();
                    picBoxWater7.Show();
                    picBoxWater8.Show();
                    break;
                //error if a valid number isn't used
                default:
                     MessageBox.Show("Oops! Something went wrong. There isn't a valid number here...");
                    break;
            }
        }

        /// <summary>
        /// method for reading the output file and setting the number of cups drank
        /// </summary>
        /// <param name="cups"></param>
        private void ReadWater(ref int cups)
        {
            //validate reading the file
            try
            {
                //variable for filename
                string filename;
                //get filename from GetFileName
                GetFileName(out filename);

                //create stream reader object
                StreamReader inputFile;

                //open saved text file
                inputFile = File.OpenText(filename);

                //loop through each item in saved file to load results in list box
                while (!inputFile.EndOfStream)
                {
                    //create variable that is set to what is on the line in the text file
                    string input = inputFile.ReadLine();
                    //verify that the text file is using an integer and set it to the water counter
                    int.TryParse(input, out cups);
                    //set text box to water counter
                    lblWaterCount.Text = cups.ToString();
                }
                //close file
                inputFile.Close();
            }
            //show error if reading the file failed
            catch (Exception)
            {
                //display error message for read error
                MessageBox.Show("Couldn't find a file for today. \n\nStarting new day.", "Reading file Error");
            }
        }

        /// <summary>
        /// method to write the number of cups drank to on output file
        /// </summary>
        /// <param name="cups"></param>
        private void WriteWater(int cups)
        {
            //validate reading the file
            try
            {
                //variable for filename
                string filename;
                //get filename from GetFileName
                GetFileName(out filename);

                //create instance of stream writer
                StreamWriter outputFile;

                //create text file on hard drive
                outputFile = File.CreateText(filename);
                
                //write number of cups to text file
                outputFile.WriteLine(cups);

                //close the text file
                outputFile.Close();
            }
            //show error if writing the file failed
            catch (Exception ex)
            {
                //display error message for write error
                MessageBox.Show("Sorry, couldn't write the file. \n\nCode: " + ex + ".", "Reading file Error");
            }
        }

        /// <summary>
        /// click event for add water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWater_Click(object sender, EventArgs e)
        {
            //create variable to pull value from textbox
            string waterCount = lblWaterCount.Text;
            //validate that counter is an integer and is less than the water goal constant
            if (int.TryParse(waterCount, out CUPS) && CUPS < WATER_GOAL)
            {
                //increment cups
                CUPS++;
                //display number of cups
                lblWaterCount.Text = CUPS.ToString();

                //call write method using counter
                WriteWater(CUPS);
                //call show water method using counter
                ShowWater(CUPS);
            }
            //validate if user met their goal and display message if they have
            else if (int.TryParse(waterCount, out CUPS) && CUPS == WATER_GOAL)
            {
                MessageBox.Show("Congrats! It appears you reached your water drinking goal!", "Whooo!");
            }
            //display error if something other than a number it is in the label
            else
            {
                MessageBox.Show("Oops! Looks like there is something other than a number in the water display box", "Add Water Error");
            }
        }

        /// <summary>
        /// click event for close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        /// <summary>
        /// load event handler for form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWaterForm_Load(object sender, EventArgs e)
        {
            //call hide water method to create blank canvas on load
            HideWater();
            //call read water method to get number of cups for the counter
            ReadWater(ref CUPS);
            //call show water method to show number of cups based on counter
            ShowWater(CUPS);
            //display the date in lblShowDate
            lblShowDate.Text = DateTime.Now.ToString("d");
        }
    }
}
