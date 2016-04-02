using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMPizzaOrder
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        /// <summary>
        /// click even to clear user input and results and reset default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all check boxes
            chkBoxCheese.Checked = false;
            chkBoxPepperoni.Checked = false;
            chkBoxPineapple.Checked = false;

            //reset radio buttons
            rbtnPan.Checked = true;

            //reset city selection
            lstBoxCities.SelectedIndex = 0;

            //clear results label
            lblOrder.Text = "";
        }

        /// <summary>
        /// click event for order button to create order from input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //declare variables crust, topping, city, order
            string toppings = "", crust, city, order;

            //set crust variable
            if (rbtnPan.Checked)
            {
                crust = "Pan crust ";
            }
            else
            {
                crust = "Thin crust ";
            }

            //set city variable
            city = lstBoxCities.SelectedItem.ToString();

            //set toppings variable
            if (chkBoxCheese.Checked)
            {
                toppings += "cheese ";
            }
            if (chkBoxPepperoni.Checked)
            {
                toppings += "pepperoni ";
            }
            if (chkBoxPineapple.Checked)
            {
                toppings += "pineapple ";
            }
            if(!chkBoxCheese.Checked && !chkBoxPepperoni.Checked && !chkBoxPineapple.Checked)
            {
                lblOrder.Text = "Please select at least one topping.";
            }
            else
            {
                //combine results in order variable
                order = crust + "pizza delivered to " + city + " with " + toppings;

                //display results in the order label
                lblOrder.Text = order;
            }
            


        }

        /// <summary>
        /// load event to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {
            //set default city to first city
            lstBoxCities.SelectedIndex = 0;
        }
    }
}
