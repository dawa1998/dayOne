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
    public partial class player_recor : Form
    {
        public player_recor()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = "messi";
            string nameUpper = "Messi";
            if (textBox1.Text == name || textBox1.Text==nameUpper)
            {
                
            }
        }
    }
}
