using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation2
{
    public partial class TranslationForm : Form
    {
        public TranslationForm()
        {
            InitializeComponent();
        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Buongiorno";
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Buenos Dias";
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Guten Morgen";
        }
    }
}
