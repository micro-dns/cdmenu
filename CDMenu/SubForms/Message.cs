using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMenu.SubForms
{
    public partial class Message : Form
    {
        public Message(String title, String message)
        {
            InitializeComponent();
            this.MessageBox_Title.Text = title;
            this.MessageBox_Message.Text = message;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_button_MouseDown(object sender, MouseEventArgs e)
        {
            OK_button.BackColor = System.Drawing.SystemColors.MenuHighlight;

        }

        private void OK_button_MouseEnter(object sender, EventArgs e)
        {
            OK_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            OK_button.ForeColor = System.Drawing.SystemColors.ControlLight;
        }

        private void OK_button_MouseLeave(object sender, EventArgs e)
        {
            OK_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            OK_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void OK_button_MouseUp(object sender, MouseEventArgs e)
        {
            OK_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;

        }

        private void Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Gives the form a shadow.
        /// SOURCE: http://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
