using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dayOne
{
    public partial class form6chceckBox : Form
    {
        public form6chceckBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rbYes.Checked = true;

        }

        private void Button1_KeyUp(object sender, KeyEventArgs e)
        {
            rbNo.Checked = true;
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            rbYes.Checked = true;
        }
    }
}
