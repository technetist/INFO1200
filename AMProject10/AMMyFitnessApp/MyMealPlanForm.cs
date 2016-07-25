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
//for reading and writing files
using System.IO;

namespace AMMyFitnessApp
{
    public partial class MyMealPlanForm : Form
    {
        //set max size for items in array
        const int ARRAY_MAX_SIZE = 1000;
        //create reference to food item array
        FoodItem[] myFoods = new FoodItem[ARRAY_MAX_SIZE];
        //create file name string
        private string foodFileName = "fooditems.txt";



        public MyMealPlanForm()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// method to load food items
        /// </summary>
        private void LoadFoods()
        {
            //declare food item variable and set it as a string with no text as default
            string foodItem = "";

            //string array to hold tokens as they are split
            string[] splitFoodArray;

            //local variable to assign food items from file to array index
            int index = 0;

            //declare streamreader variable
            StreamReader inputFile;

            //open file with streamreader
            inputFile = File.OpenText(foodFileName);

            //validate reading file
            try
            {
                //put file contents into array
                while (!inputFile.EndOfStream)
                {
                    //loop through file and save each food item in variable
                    foodItem = inputFile.ReadLine();
                    //split string using comma
                    splitFoodArray = foodItem.Split(',');
                    //add only the name of the food from the array
                    lstBoxFoodItems.Items.Add(splitFoodArray[0]);
                    //add the food item
                    myFoods[index] = new FoodItem(splitFoodArray);
                    //increment index
                    index++;
                }
                //close file
                inputFile.Close();
            }
            //error if reading failed
            catch(Exception ex)
            {
                //display error if reading didn't succeed
                MessageBox.Show("Sorry, couldn't read the file. \n\nCode: " + ex.Message + "\n\nPerhaps you haven't made a list of food on the Food Log page?", "Reading Error");
            }
        }

        /// <summary>
        /// load event for form, display date and call loadFoods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMealPlanForm_Load(object sender, EventArgs e)
        {
            //display date in label
            lblDisplayDate.Text = DateTime.Now.ToString();

            //call loadFoods method
            LoadFoods();
        }

        /// <summary>
        /// SelectedIndexChanged event for food items list box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxFoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validate that an item was selected
            if (lstBoxFoodItems.SelectedIndex != -1)
            {
                //declare index integer to set selected item to 
                int index = lstBoxFoodItems.SelectedIndex;

                //display calories in label
                lblItemCalories.Text = myFoods[index].Calories.ToString();
            }
        }


        /// <summary>
        /// click event for add food item button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            //validate selection from meal type and food item list boxes
            if (lstBoxFoodItems.SelectedIndex != -1 && lstBoxMealType.SelectedIndex != -1)
            {
                //counter to bring in selected item from array
                int index = lstBoxFoodItems.SelectedIndex;

                //check which meal type was selected
                switch (lstBoxMealType.SelectedIndex)
                {
                    //case for breakfast
                    case 0:
                        //display food item in breakfast list box with calories
                        lstBoxBreakfast.Items.Add(lstBoxFoodItems.SelectedItem.ToString() + " for " + myFoods[index].Calories.ToString() + " calories.");
                        break;

                    //case for lunch
                    case 1:
                        //display food item in lunch list box with calories
                        lstBoxLunch.Items.Add(lstBoxFoodItems.SelectedItem.ToString() + " for " + myFoods[index].Calories.ToString() + " calories.");
                        break;

                    //case for dinner
                    case 2:
                        //display food item in dinner list box with calories
                        lstBoxDinner.Items.Add(lstBoxFoodItems.SelectedItem.ToString() + " for " + myFoods[index].Calories.ToString() + " calories.");
                        break;

                    //default case for snack
                    default:
                        //display food item in snack list box with calories
                        lstBoxSnack.Items.Add(lstBoxFoodItems.SelectedItem.ToString() + " for " + myFoods[index].Calories.ToString() + " calories.");
                        break;
                }
                //declare sum variable
                string sum;
                //validate calories in both boxes to make sure they are integers and add them together
                try {
                    sum = (int.Parse(lblCalorieCount.Text) + int.Parse(lblItemCalories.Text)).ToString();
                    //display sum in calorie count box
                    lblCalorieCount.Text = sum;
                }
                //error if the calories aren't integers
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, there wasn't an integer saved for calories. \n\nCode: " + ex);
                }
                
            }
            //error if meal type or food item aren't selected
            else
            {
                //display error message
                MessageBox.Show("Please select a meal type and a food item");
            }
        }

        /// <summary>
        /// click event to add a new food item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFoodItem_Click(object sender, EventArgs e)
        {
            //call form's constructor and assign variable
            MyFoodItemForm addFoodItem = new MyFoodItemForm();
            //display Food Log form
            addFoodItem.ShowDialog();

            //clear list box to make room for new list
            lstBoxFoodItems.Items.Clear();

            //call loadFoods method again to refesh list box
            LoadFoods();
        }

        /// <summary>
        /// click event for clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear list boxes
            lstBoxBreakfast.Items.Clear();
            lstBoxLunch.Items.Clear();
            lstBoxDinner.Items.Clear();
            lstBoxSnack.Items.Clear();
            //clear labels
            lblItemCalories.Text = "";
            lblCalorieCount.Text = "0";
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
    }
}
