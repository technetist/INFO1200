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
//needed to read and write to file
using System.IO;

namespace AMMyFitnessApp
{
    public partial class MyExerciseLogForm : Form
    {
        //declare variable to hold current file
        string CURRENT_FILE;

        public MyExerciseLogForm()
        {
            InitializeComponent();
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
        private void MyExerciseLogForm_Load(object sender, EventArgs e)
        {
            //display the date in lblShowDate
            lblShowDate.Text = DateTime.Now.ToString("d");

            //streamReader for input
            StreamReader inputFile;

            //set current file to empty string
            CURRENT_FILE = "";

            //clear items in list box
            lstBoxExercise.Items.Clear();

            //set focus
            txtBoxExercise.Focus();

            //validate opening of file
            try
            {
                //validate finding file
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //set input file to user selected document
                    inputFile = File.OpenText(openFile.FileName);
                    
                    //set current file to user selected document
                    CURRENT_FILE = openFile.FileName;

                    //while loop to add items from user selected document, until end of document reached
                    while (!inputFile.EndOfStream)
                    {
                        //add items from document to list box
                        lstBoxExercise.Items.Add(inputFile.ReadLine());
                    }

                    //close file
                    inputFile.Close();
                }
                //error for cancel button
                else
                {
                    //display message for cancel button
                    MessageBox.Show("Didn't find a previous file, starting new log...");
                }
            }
            //error opening file
            catch (Exception ex)
            {
                //display error message for opening file error
                MessageBox.Show("Sorry, couldn't get that file. \n\nCode: " + ex.Message, "Open File Error");
            }
        }

        /// <summary>
        /// click event for adding exercise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            //validate user input data
            if (txtBoxExercise.Text != "" && txtBoxDuration.Text != "" && txtBoxCalorie.Text != "")
            {
                //concatenate exercise entry with date, exercise, duration, and calories
                string exerciseEntry = DateTime.Now.ToString("d") + ", " + txtBoxExercise.Text + ", " + txtBoxDuration.Text + ", " + txtBoxCalorie.Text;

                //add entry to list box
                lstBoxExercise.Items.Add(exerciseEntry);

                //clear text boxes
                txtBoxCalorie.Clear();
                txtBoxDuration.Clear();
                txtBoxExercise.Clear();

                //set focus
                txtBoxExercise.Focus();
            }
            //error for empty boxes
            else
            {
                //display error for box being empty
                MessageBox.Show("One of the boxes was left empty, please fill in all boxes.", "Empty Box Error");
                
                //clear text boxes
                txtBoxCalorie.Clear();
                txtBoxDuration.Clear();
                txtBoxExercise.Clear();

                //set focus
                txtBoxExercise.Focus();
            }
        }

        /// <summary>
        /// click event for save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            //stream writer for output file
            StreamWriter outputFile;

            //validate writing of file
            try
            {
                //validate if using previous file
                if (CURRENT_FILE != "")
                {
                    //create text file on local drive
                    outputFile = File.CreateText(CURRENT_FILE);

                    //loop through exercises from list box and save to text file
                    for (int i = 0; i < lstBoxExercise.Items.Count; i++)
                    {
                        //write each item from list box to text file
                        outputFile.WriteLine(lstBoxExercise.Items[i].ToString());
                    }

                    //close the text file
                    outputFile.Close();

                    //Message box to tell user that write succeeded
                    MessageBox.Show("File Successfully Written", "Success!");
                }
                //save new file if no previous file used
                else
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        //create document and set outputFile to it
                        outputFile = File.CreateText(openFile.FileName);

                        //set current filename to user set one
                        CURRENT_FILE = saveFile.FileName;

                        //loop through exercises from list box and save to text file
                        for (int i = 0; i < lstBoxExercise.Items.Count; i++)
                        {
                            //write each item from list box to text file
                            outputFile.WriteLine(lstBoxExercise.Items[i].ToString());
                        }

                        //close the text file
                        outputFile.Close();

                        //Message box to tell user that write succeeded
                        MessageBox.Show("File Successfully Written", "Success!");
                    }
                    else
                    {
                        //display message for cancel button
                        MessageBox.Show("Saving file operation cancelled by user.");
                    }
                }
            }
            //error saving
            catch (Exception ex)
            {
                //display error message for writing file error
                MessageBox.Show("Sorry, couldn't save that file. \n\nCode: " + ex.Message, "Save File Error");
            }
        }
    }
}
