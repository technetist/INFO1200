using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhone
{
    class CellPhone
    {
        //backing fields
        private string _model;
        private string _brand;
        private decimal _price;

        /// <summary>
        /// create public constructor method for CellPhone class
        /// </summary>
        public CellPhone()
        {
            //set default values
            _model = "";
            _brand = "";
            _price = 0m;
        }

        public string Model
        {
            get { return _model; } //returns value of _model
            set { _model = value; } //sets the value of _model to string input
        }
        public string Brand
        {
            get { return _brand; } //returns value of _brand
            set { _brand = value; } //sets value of _brand to string input
        }
        public decimal Price
        {
            get { return _price; } //returns value of _price
            set { _price = value; } //sets value of _price to decimal input
        }
    }
}
