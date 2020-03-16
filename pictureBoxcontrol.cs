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
    public partial class pictureBoxcontrol : Form
    {
        public pictureBoxcontrol()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select the image";
            ofd.Filter = "jpeg(*.jpg;*.png;*.bmp;)|*.jpg;*.png;*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                playerPicturebox.Image = new Bitmap(ofd.FileName);
                playerPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select the image";
            ofd.Filter = "jpeg(*.jpg; *.png; *.bmp;) | *.jpg; *.png *.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                playerPicturebox.Image = new Bitmap(ofd.FileName);
                playerPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            ofd.ShowDialog();*/

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the image";
            ofd.Filter = "jpeg(*.jpg;*.png;*.bmp;)|*.jpg;*.png;*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                playerPicturebox.Image = new Bitmap(ofd.FileName);
                playerPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            ofd.ShowDialog();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerPicturebox.Image = null;
        }
    }
}
