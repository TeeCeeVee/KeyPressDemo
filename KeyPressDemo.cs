using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPressApp
{
    public partial class KeyPressDemo : Form
    {
        public KeyPressDemo()
        {
            InitializeComponent();
        }

        private void TxtAnyKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar is a varibale of type char
            // takes the character to string || takes a signle char and cast to int then to string == ASCII code
            TxtBoxAnyKey.Text = Convert.ToString(e.KeyChar) + " " + Convert.ToString((int)e.KeyChar);
            TxtAnyKey.Text = "";
        }

        private void TxtOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar is a property that stores the character pressed from the keyboard
            // e is the object -- stores the character when a key is pressed 
            //to delete a char, use cursor to delete key
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                //e.Handled default is false
                e.Handled = true;
            }
            else
            {
                //locked in
                e.Handled = false;
            }
        }

        private void KeyPressDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //activates when closing the form
            DialogResult result = MessageBox.Show("Do you want to exit this window?", "You may lose some info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                //default is false
                e.Cancel = false;
            }

        }
    }
}
