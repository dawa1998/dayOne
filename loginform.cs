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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string name = "fupulamu01@gmail.com";
            string password = "dawadawa0101";
            string ma = "@";
            if(usernametxt.Text==name && passwordtxt.Text == password)
            {

                menuScript ms = new menuScript();
                ms.Show();

            }
            else
            {
                if (usernametxt.Text != name)
                {
                    MessageBox.Show("username is incorrect");
                }
               else if (passwordtxt.Text != password)
                {
                    MessageBox.Show("password is incorrect");
                }
                else if(usernametxt.Text!=name && passwordtxt.Text != password)
                {
                    MessageBox.Show("username and password is incorrect");
                }
               
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
          
           
        }
    }
}
