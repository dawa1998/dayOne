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
    public partial class menuScript : Form
    {
        public menuScript()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void howToFillTheFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for to fill the form", "to joing the mungpoo foodball team"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* addTeacher ad = new addTeacher();
             ad.Show();*/
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the image";
            ofd.Filter = "jped(*.jpg;*.png*.bmp;)|*.jpg;*.png*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFemale.Image = new Bitmap(ofd.FileName);
                pbFemale.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pbMale.Image = null;
        }

        private void btmMale_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the image";
            ofd.Filter = "jped(*.jpg;*.png*.bmp;)|*.jpg;*.png*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
              MessageBox.Show("Are you sure you want to add" + ofd.FileName,"choose the file", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
               

                pbMale.Image = new Bitmap(ofd.FileName);
                pbMale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            pbFemale.Image = null;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the image";
            ofd.Filter = "jped(*.jpg;*.png*.bmp;)|*.jpg;*.png*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbMale.Image = new Bitmap(ofd.FileName);
                pbMale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pbMale.Image = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the image";
            ofd.Filter = "jped(*.jpg;*.png*.bmp;)|*.jpg;*.png*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pbMale.Image = new Bitmap(ofd.FileName);
                pbMale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the image";
            ofd.Filter = "jped(*.jpg;*.png*.bmp;)|*.jpg;*.png*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbMale.Image = new Bitmap(ofd.FileName);
                pbMale.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            player_recor pc = new player_recor();
            pc.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
