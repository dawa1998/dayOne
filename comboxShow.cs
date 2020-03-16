using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace dayOne
{
    public partial class comboxShow : Form
    {
        public comboxShow()
        {
            InitializeComponent();
        }

        private void ComboxShow_Load(object sender, EventArgs e)
        {

        }

        private void BtnClassName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to save","Congrats", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
            cmdClasses.Items.Add(cmdClass.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //cmdClasses.Items.Remove(cmdClasses.SelectedItem);
            //cmdClasses.Items.RemoveAt(0);
            cmdClasses.Items.RemoveAt(cmdClasses.SelectedIndex);
            
        }

        private void CmdClass_DragEnter(object sender, DragEventArgs e)
        {
            cmdClasses.Items.Add(cmdClass.Text);
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total item is " + cmdClasses.Items.Count, " item");
        }

        private void BtnReomve_Click(object sender, EventArgs e)
        {
            cmdClasses.Items.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cmbBook.Items.Add(addLibrary.Text);
        }

        private void CmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://facebook.com");

        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("the totla number of book in the library is " + cmbBook.Items.Count);
            //cmbBook.Items.RemoveAt(cmbBook.SelectedIndex);
            cmbBook.Items.Clear();
        }
    }
}
