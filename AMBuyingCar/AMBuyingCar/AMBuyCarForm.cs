using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for send message to use placeholder text
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AMBuyingCar
{
    public partial class AMBuyCarForm : Form
    {
        //for send message to add placeholder text
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32
            SendMessage(
                            IntPtr hWnd,
                            int msg,
                            int wParam,
                            [MarshalAs(UnmanagedType.LPWStr)]string lParam
                        );

        private const int EM_SETCUEBANNER = 0x1501;

        public AMBuyCarForm()
        {
            InitializeComponent();

            // set the placeholder text to the user name and password field.
            SendMessage(txtBoxMaxPrice.Handle, EM_SETCUEBANNER, 0, "10,000");
        }

        /// <summary>
        /// load event to set default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AMBuyCarForm_Load(object sender, EventArgs e)
        {
            //set make to default value
            lstBoxMake.SelectedIndex = 0;

            //set color to default value
            lstBoxColor.SelectedIndex = 0;
        }

        /// <summary>
        /// click event to validate user input and display designed car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesignCar_Click(object sender, EventArgs e)
        {
            //variables for make, color, price, result, and condition
            string make = "", color = "", condition = "";
            decimal price = 0m;

            //validate user input for make
            if (ValidateMake(ref make))
            {
                //validate user input for color
                if (ValidateCarColor(ref color))
                {
                    //validate user input price
                    if (ValidateCarPrice(ref price))
                    {
                        //get and set condition
                        SetCondition(ref condition);

                        //display results
                        DisplayResults(make, color, price, condition);
                    }
                }
            }
        }

        private void DisplayResults(string make, string color, decimal price, string condition)
        {
            throw new NotImplementedException();
        }

        private void SetCondition(ref string condition)
        {

        }

        /// <summary>
        /// method to get and set user input if valid for price.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private bool ValidateCarPrice(ref decimal price)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// method to get and set user input if valid for color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private bool ValidateCarColor(ref string color)
        {
            if (lstBoxColor.SelectedIndex > -1)
            {
                //set color to user input
                color = lstBoxColor.SelectedItem.ToString();
                //return true if user input valid
                return true;
            }
            else
            {
                //error message for unselected color
                MessageBox.Show("Please select a color.", "Color Error");
                //return false if user input invalid
                return false;
            }
        }

        /// <summary>
        /// method to get and set user input if valid for make
        /// </summary>
        /// <returns></returns>
        private bool ValidateMake(ref string make)
        {
            //validate make of car
            if (lstBoxMake.SelectedIndex > -1)
            {
                //set make to user input
                make = lstBoxMake.SelectedItem.ToString();
                //return true if user input valid
                return true;
            }
            else
            {
                //error message for unselected make
                MessageBox.Show("Please select a car make.","Car Make Error");
                //return false if user input invalid
                return false;
            }

        }
    }
}
