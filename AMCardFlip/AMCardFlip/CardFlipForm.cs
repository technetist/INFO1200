using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMCardFlip
{
    public partial class CardFlipForm : Form
    {
        public CardFlipForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnCardFace_Click(object sender, EventArgs e)
        {
            //show the picBoxFace
            picBoxFace.Visible = true;
            //hide the picBoxBack
            picBoxBack.Visible = false;
        }

        private void btnCardBack_Click(object sender, EventArgs e)
        {
            //show the picBoxBack
            picBoxBack.Show();
            //hide the picBoxFace
            picBoxFace.Hide();
        }
    }
}
