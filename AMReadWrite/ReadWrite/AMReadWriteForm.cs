using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadWrite
{

    public partial class writeReadForm : Form
    {

        public writeReadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event to write countries to text file on hard drive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            //validate
            try
            {
                //create instance of stream writer
                StreamWriter outputFile;

                //create text file on hard drive
                outputFile = File.CreateText("Countries.txt");

                //loop through countries from list box and save to text file
                for (int i = 0; i < lstBoxWrite.Items.Count; i++)
                {
                    //write each item from list box to text file
                    outputFile.WriteLine(lstBoxWrite.Items[i]);
                }

                //close the text file
                outputFile.Close();

                //Message box to tell user that write succeeded
                MessageBox.Show("File Successfully Written", "Success!");
            }
            catch (Exception ex)
            {
                //display error message for write error
                MessageBox.Show("Sorry, couldn't write to the file. \n\nCode: " + ex.Message, "Writing Error");
            }
        }

        /// <summary>
        /// click event to read from saved text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            //validate
            try
            {
                //create instance of stream reader
                StreamReader inputFile;

                //clear read list box
                lstBoxRead.Items.Clear();

                //open saved text file
                inputFile = File.OpenText("Countries.txt");

                //loop through each item in saved file to load results in list box
                while(!inputFile.EndOfStream)
                {
                    //display countries from file in list box
                    lstBoxRead.Items.Add(inputFile.ReadLine());
                }

                //close file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //display reading file error message
                MessageBox.Show("Sorry, couldn't read the text file. \n\nCode: " + ex.Message, "Reading Error");
            }
        }
        /// <summary>
        /// click event to let user choose file to read
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //validate
            try
            {
                //create instance of stream reader
                StreamReader inputFile;

                //clear list box
                lstBoxRead.Items.Clear();

                //check if user selected file
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //open file based on user selection
                    inputFile = File.OpenText(openFile.FileName);

                    //loop through each item in user file, add to list box
                    while(!inputFile.EndOfStream)
                    {
                        //add all text from file to list box
                        lstBoxRead.Items.Add(inputFile.ReadLine());
                    }
                    //close file
                    inputFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, There was a problem reading from your file. Code: " + ex.Message, "File Error");
            }

        }
    }
}
