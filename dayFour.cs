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
    public partial class dayFour : Form
    {
        public dayFour()
        {
            InitializeComponent();
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
             listLanguage.Items.Add(languageBox.Text);
            //MessageBox.Show("You have selected the following /n " + listLanguage.SelectedItem);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            listLanguage.Items.Remove(txtRemove.Text);
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            listLanguage.Items.RemoveAt(Convert.ToInt32 (txtindex.Text));
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total language is " + listLanguage.Items.Count);
           
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            listLanguage.Items.Clear();
        }

        private void BtnRemovebySelected_Click(object sender, EventArgs e)
        {
            //listLanguage.ClearSelected();
            listLanguage.Items.Remove(listLanguage.SelectedItem);
        }
    }
}
