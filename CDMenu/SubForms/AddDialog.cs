using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMenu
{
    public partial class AddDialog : Form
    {
        public static string addName, addDescription, addPath;
        public static bool isSubmenu = false;
        public AddDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtDescription.Text) && string.IsNullOrWhiteSpace(txtPath.Text))
            {
                MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
            }
            else
            {
                addName = txtName.Text;
                addDescription = txtDescription.Text;
                addPath = txtPath.Text;
                this.Close();
            }
        }

        private void AddDialog_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All Files (*.*)|*.*";
            o.FilterIndex = 0;
            o.Multiselect = false;
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = o.FileName; 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPath.Width = txtName.Width;
                lblLocation.Text = "File Name";
                button2.Hide();
                isSubmenu = true;
            }
            else
            {
                txtPath.Width = 292;
                lblLocation.Text = "File Path";
                button2.Show();
                isSubmenu = false;
            }
        }
    }
}
