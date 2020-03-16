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
    public partial class nullEmptyvalueswithDataandTimepicker : Form
    {
        public nullEmptyvalueswithDataandTimepicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtmDateofbirth.CustomFormat = "dd.MMMM.yyyy";
        }

        private void dtmDateofbirth_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode==Keys.Escape || e.KeyCode==Keys.Return)
                //keydown even( this code is to delete if pressed down)
            {
                dtmDateofbirth.CustomFormat = " ";
            }
        }

        private void dateTimePicker1_MouseUp(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm:ss";
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "hh:mm:ss";
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }
    }
}
