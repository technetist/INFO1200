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
//needed to save file
using System.IO;

namespace AMMyFitnessApp
{
    public partial class MyFoodItemForm : Form
    {
        //public string field for file name
        string foodFileName = "fooditems.txt";

        public MyFoodItemForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method to validate user input
        /// </summary>
        /// <param name="myFood"></param>
        /// <returns></returns>
        private bool CheckFood(FoodItem myFood)
        {
            //create local variables for validation
            int calorie;
            double serving;
            double sugar;
            double protein;
            double fiber;
            double sodium;

            //ensure a name has been input
            if (txtBoxFoodName.Text != "")
            {
                //store food name in FoodItem class
                myFood.FoodName = txtBoxFoodName.Text;

                //ensure calories is a valid number and between a set value
                if (int.TryParse(txtBoxCalories.Text, out calorie) && (calorie <= 1000 && calorie >= 0))
                {
                    //store calories in FoodItem class
                    myFood.Calories = calorie;

                    //ensure servings is a valid number and between a set value
                    if (double.TryParse(txtBoxServings.Text, out serving) && (serving <= 5 && serving > 0))
                    {
                        //store servings in FoodItem class
                        myFood.Servings = serving;

                        //ensure sugars is a valid number and between a set value
                        if (double.TryParse(txtBoxSugars.Text, out sugar) && (sugar <= 100 && sugar >= 0))
                        {
                            //store sugars in FoodItem class
                            myFood.Sugars = sugar;

                            //ensure protein is a valid number and between a set value
                            if (double.TryParse(txtBoxProtein.Text, out protein) && (protein <= 60 && protein >= 0))
                            {
                                //store protein in FoodItem class
                                myFood.Protein = protein;

                                //ensure fiber is a valid number and between a set value
                                if (double.TryParse(txtBoxFiber.Text, out fiber) && (fiber <= 10 && fiber > 0))
                                {
                                    //store fiber in FoodItem class
                                    myFood.Fiber = fiber;

                                    //ensure sodium is a valid number and between a set value
                                    if (double.TryParse(txtBoxSodium.Text, out sodium) && (sodium <= 5 && sodium > 0))
                                    {
                                        //store sodium in FoodItem class and return true if all fields are valid
                                        myFood.Sodium = sodium;
                                        return true;
                                    }
                                    //display error if sodium is incorrect
                                    else
                                    {
                                        //display error message, clear field, set focus, and return false
                                        MessageBox.Show("Enter a valid value for sodium, between 0 and 5 grams");
                                        txtBoxSodium.Clear();
                                        txtBoxSodium.Focus();
                                        return false;
                                    }
                                }
                                //display error if fiber is incorrect
                                else
                                {
                                    //display error message, clear field, set focus, and return false
                                    MessageBox.Show("Enter a valid value for fiber, between 0 and 10 grams");
                                    txtBoxFiber.Clear();
                                    txtBoxFiber.Focus();
                                    return false;
                                }
                            }
                            //display error if protein is incorrect
                            else
                            {
                                //display error message, clear field, set focus, and return false
                                MessageBox.Show("Enter a valid value for protein, between 0 and 60 grams");
                                txtBoxProtein.Clear();
                                txtBoxProtein.Focus();
                                return false;
                            }
                        }
                        //display error if sugars is incorrect
                        else
                        {
                            //display error message, clear field, set focus, and return false
                            MessageBox.Show("Enter a valid value for sugar, between 0 and 100 grams");
                            txtBoxSugars.Clear();
                            txtBoxSugars.Focus();
                            return false;
                        }
                    }
                    //display error if serving size is incorrect
                    else
                    {
                        //display error message, clear field, set focus, and return false
                        MessageBox.Show("Enter a valid value for serving size, between 0 and 5");
                        txtBoxServings.Clear();
                        txtBoxServings.Focus();
                        return false;
                    }

                }
                //display error if calories is incorrect
                else
                {
                    //display error message, clear field, set focus, and return false
                    MessageBox.Show("Enter a valid value for calories, between 0 and 1000");
                    txtBoxCalories.Clear();
                    txtBoxCalories.Focus();
                    return false;
                }
            }
            //display error if food name is left blank
            else
            {
                //display error message, clear field, set focus, and return false
                MessageBox.Show("Enter a food name");
                txtBoxFoodName.Clear();
                txtBoxFoodName.Focus();
                return false;
            }
        }

        /// <summary>
        /// click event for the add food button, adds food item to list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //create new instance of FoodItem class
            FoodItem myFood = new FoodItem();

            //call validation method
            if (CheckFood(myFood))
            {
                //adds items if valid, using ToString method from FoodItem class
                lstBoxNutrition.Items.Add(myFood.ToString());

                //clear textboxes
                txtBoxCalories.Clear();
                txtBoxFiber.Clear();
                txtBoxFoodName.Clear();
                txtBoxProtein.Clear();
                txtBoxServings.Clear();
                txtBoxSugars.Clear();
                txtBoxSodium.Clear();
            }
        }

        /// <summary>
        /// click event for save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate
            try
            {
                //create instance of stream writer
                StreamWriter outputFile;

                //create text file on hard drive
                outputFile = File.CreateText(foodFileName);

                //loop through food items from list box and save to text file
                for (int i = 0; i < lstBoxNutrition.Items.Count; i++)
                {
                    //write each item from list box to text file
                    outputFile.WriteLine(lstBoxNutrition.Items[i]);
                }

                //close the text file
                outputFile.Close();
            }
            catch (Exception ex)
            {
                //display error message for write error
                MessageBox.Show("Sorry, couldn't write to the file. \n\nCode: " + ex.Message, "Writing Error");
            }

            //close the form
            this.Close();
        }

        //load event handler for form
        private void MyFoodItemForm_Load(object sender, EventArgs e)
        {
            //validate
            try
            {
                //create instance of stream reader
                StreamReader inputFile;

                //clear list box
                lstBoxNutrition.Items.Clear();

                //open saved text file
                inputFile = File.OpenText(foodFileName);

                //loop through each item in saved file to load results in list box
                while (!inputFile.EndOfStream)
                {
                    //display countries from file in list box
                    lstBoxNutrition.Items.Add(inputFile.ReadLine());
                }

                //close file
                inputFile.Close();
            }
            catch (Exception)
            {
                //display reading file error message
                MessageBox.Show("Couldn't find a previously saved food log. \n\n Starting a new file.", "No Previous File");
            }
        }
    }
}
