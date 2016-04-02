using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhone
{
    public partial class AMCellPhoneForm : Form
    {
        public AMCellPhoneForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event for the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        /// <summary>
        /// click event for create phone button to get and set cellphone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreatePhone_Click(object sender, EventArgs e)
        {
            //create new instance of CellPhone class
            CellPhone myphone = new CellPhone();

            //validate and set cellphone values
            if (ValidateSetCellPhone(myphone))
            {
                //display cellphone values in results labels
                DisplayCellPhone(myphone);
            }
        }

        /// <summary>
        /// takes the values given below and displays them in the text boxes
        /// </summary>
        /// <param name="myphone"></param>
        private void DisplayCellPhone(CellPhone myphone)
        {
            //display input in text boxes
            lblResultBrand.Text = myphone.Brand;
            lblResultModel.Text = myphone.Model;
            lblResultPrice.Text = myphone.Price.ToString("c");
        }

        /// <summary>
        /// validates user input and sets values for CellPhone class
        /// </summary>
        /// <param name="myphone"></param>
        /// <returns></returns>
        private bool ValidateSetCellPhone(CellPhone myphone)
        {
            //declare local decimal variable for price
            decimal price;

            //validate Model, Brand and Price; and set Model, Brand, and Price
            if (decimal.TryParse(txtBoxPrice.Text, out price) && price > 0 && txtBoxModel.Text != "" && txtBoxBrand.Text != "")
            {
                myphone.Model = txtBoxModel.Text;
                myphone.Brand = txtBoxBrand.Text;
                myphone.Price = price;
                //return true if valid
                return true;
            }

            //error if one or more field is incorrect
            MessageBox.Show("Please enter a valid model, brand, and price.");
            //return false if not valid
            return false;
        }
    }
}
