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
    public partial class addTeacher : Form
    {
        public addTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select your fateher photo";
            ofd.Filter = "jpeg(*.jpg;*.png;*.bmp;)|*.jpg;*.png;*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fatherimage.Image = new Bitmap(ofd.FileName);
                fatherimage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select your fateher photo";
            ofd.Filter = "jpeg(*.jpg;*.png;*.bmp;)|*.jpg;*.png;*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                motherImage.Image = new Bitmap(ofd.FileName);
                motherImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fatherimage.Image = null;
        }

        private void fatherimage_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            motherImage.Image = null;
        }
    }
}
