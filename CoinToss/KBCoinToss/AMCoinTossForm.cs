using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KBCoinToss;

namespace CoinToss
{
    public partial class AMCoinTossForm : Form
    {
        //declare constant for flipping 5 times
        const int TOSSX5 = 5;

        public AMCoinTossForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click event for close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        /// <summary>
        /// click event for clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear items in list box
            lstBoxResults.Items.Clear();
        }

        /// <summary>
        /// click event for tossing the coin 5 times and set values in list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToss5_Click(object sender, EventArgs e)
        {
            //create new instance of coin class
            Coin mycoin = new Coin();

            //clear listbox
            lstBoxResults.Items.Clear();

            //loop to toss coin 5 times
            for (int i = 0; i < TOSSX5; i++)
            {
                //call coin class and toss coin
                mycoin.Toss();

                //add results to listbox
                lstBoxResults.Items.Add(mycoin.GetSideUp());
            }
        }

        /// <summary>
        /// click event for flipping the coin once and showing results in message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToss1_Click(object sender, EventArgs e)
        {
            //create a new instance of coin class
            Coin mycoin = new Coin();

            Flip(mycoin);
        }

        /// <summary>
        /// flip coin and display results
        /// </summary>
        /// <param name="mycoin"></param>
        private void Flip(Coin mycoin)
        {
            //flip coin
            mycoin.Toss();

            //display results in message box
            MessageBox.Show("Your coin landed on " + mycoin.GetSideUp() + ".");
        }
    }
}
