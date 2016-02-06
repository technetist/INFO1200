using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMFuelEconomy
{
    public partial class FuelEconForm : Form
    {
        public FuelEconForm()
        {
            InitializeComponent();
        }

        private void btnCalcMPG_Click(object sender, EventArgs e)
        {
            //declare variables
            double miles;
            double gallons;
            double mpgResults;

            //set miles variable
            miles = double.Parse(txtBoxMiles.Text);

            //set gallons variable
            gallons = double.Parse(txtBoxGallons.Text);

            //calculate MPG
            mpgResults = miles/gallons;

            //display MPG results
            lblMPGResult.Text = mpgResults.ToString("n2");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
