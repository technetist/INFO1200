//Name: Adrien Maranville
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 04/08/2016
//Project #: 9
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMMyFitnessApp
{
    class FoodItem
    {
        //backing fields
        private string _foodName;
        private int _calories;
        private double _servings;
        private double _sugars;
        private double _protein;
        private double _fiber;
        private double _sodium;

        //create default value constructor for FoodItem class
        public FoodItem()
        {
            //set default values
            _foodName = "";
            _calories = 0;
            _servings = 0;
            _sugars = 0;
            _protein = 0;
            _fiber = 0;
            _sodium = 0;
        }

        //create perametized constructor for FoodItem class
        public FoodItem(string[] foodArray)
        {
            //set default values
            _foodName = foodArray[0].ToString();
            _calories = int.Parse(foodArray[1]);
            _servings = double.Parse(foodArray[2]);
            _sugars = double.Parse(foodArray[3]);
            _protein = double.Parse(foodArray[4]);
            _fiber = double.Parse(foodArray[5]);
            _sodium = double.Parse(foodArray[6]);
        }

        

        //set backing values to variable values from form
        public FoodItem(string FoodName, int Calories, double Servings, double Sugars, double Protein, double Fiber, double Sodium)
        {
            _foodName = FoodName;
            _calories = Calories;
            _servings = Servings;
            _sugars = Sugars;
            _protein = Protein;
            _fiber = Fiber;
            _sodium = Sodium;
        }
        
        //create name property
        public string FoodName
        {
            get { return _foodName; }//returns value of _foodName
            set { _foodName = value; }//sets the value of _foodName to input
        }
        
        //create calorie property
        public int Calories
        {
            get { return _calories; }//returns value of _calories
            set { _calories = value; }//sets the value of _calories to input
        }

        //create serving property
        public double Servings
        {
            get { return _servings; }//returns value of _servings
            set { _servings = value; }//sets the value of _servings to input
        }

        //create sugar property
        public double Sugars
        {
            get { return _sugars; }//returns value of _sugars
            set { _sugars = value; }//sets the value of _sugars to input
        }

        //create protein property
        public double Protein
        {
            get { return _protein; }//returns value of _protein
            set { _protein = value; }//sets the value of _protein to input
        }

        //create fiber property
        public double Fiber
        {
            get { return _fiber; }//returns value of _fiber
            set { _fiber = value; }//sets the value of _fiber to input
        }

        //create sodium property
        public double Sodium
        {
            get { return _sodium; }//returns value of _sodium
            set { _sodium = value; }//sets the value of _calories to input
        }

        //ToString method
        public override string ToString()
        {
            //creates string variable and concatenates backing variables in it
            string foodStats = _foodName + "," + _calories + "," + _servings + "," + _sugars + "," + _protein + "," + _fiber + "," + _sodium;
            //returns concatenated string
            return foodStats;
        }
    }
}