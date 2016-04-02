using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowOldAreYou
{
    public partial class AgeForm : Form
    {
        public AgeForm()
        {
            InitializeComponent();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am 25 years old.");
        }
    }
}
