using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasher_Smasher
{
    public partial class Form1 : Form
    {
        private SecretCode mycode;

        private string inputkey;
        private string stringtoencrypt;
        private string stringtodecrypt;
        public Form1()
        {
            InitializeComponent();
            mycode = new SecretCode();
            tbkeyinput.Text = "";
        }

        public bool Comparepassword()
        {
            if (!(string.IsNullOrEmpty(tbkeyinput.Text)))
                inputkey = tbkeyinput.Text;
            else return false;

            if (mycode.Compare(inputkey) == false)
            {
                MessageBox.Show("Secret Key is incorrect");
                return false;
            }
            else return true;
        }

        private void Btencrypt_Click(object sender, EventArgs e)
        {
            if (Comparepassword() && !(string.IsNullOrEmpty(tbinput.Text)))
            {
                stringtoencrypt = tbinput.Text;
                tboutput.Text = mycode.Encrypt(stringtoencrypt, inputkey);
            }
            else
                MessageBox.Show("Password / Input String cannot be empty or wrong");

            //else
            //    MessageBox.Show("Secret Key empty, please input the secret key");

            //else if ())
            //    stringtoencrypt = tbinput.Text;

            //else if (string.IsNullOrEmpty(tbinput.Text))
            //    MessageBox.Show("Input box is empty");

            //if (!(string.IsNullOrEmpty(tbkeyinput.Text))) 
        }

        private void Btclearall_Click(object sender, EventArgs e)
        {
            tbkeyinput.Text = "";
            tbinput.Text = "Decrypt / Input";
            tboutput.Text = "Encrypt / Output";
        }

        private void Btdecrypt_Click(object sender, EventArgs e)
        {
            if (Comparepassword() && !(string.IsNullOrEmpty(tbinput.Text)))
            {
                stringtodecrypt = tboutput.Text;
                tbinput.Text = mycode.Decrypt(stringtodecrypt, inputkey);
            }

            //if (!(string.IsNullOrEmpty(tbkeyinput.Text)))
            //    inputkey = tbkeyinput.Text;

                //else
                //    MessageBox.Show("Secret Key empty, please input the secret key");

                //if (mycode.Compare(inputkey) == false)
                //    MessageBox.Show("Secret Key different from database");

                //if (!(string.IsNullOrEmpty(tboutput.Text)))
                //    stringtoencrypt = tboutput.Text;

                //else
                //    MessageBox.Show("Output box is empty");

                //if (!(string.IsNullOrEmpty(tbkeyinput.Text)))
                //    tbinput.Text = mycode.Decrypt(stringtoencrypt, inputkey);
        }

        private void Btcopyinput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbinput.Text);
        }

        private void Btcopyoutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tboutput.Text);
        }

        private void Tbinput_Click(object sender, EventArgs e)
        {
            if (tbinput.Text == "Insert String to Encrypt")
                tbinput.Text = "";
        }

        private void Tboutput_Click(object sender, EventArgs e)
        {
            if (tboutput.Text == "Insert String to Decrypt")
                tboutput.Text = "";
        }

        private void Tbinput_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbinput.Text))
                tbinput.Text = "Insert String to Encrypt";
        }

        private void Tboutput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboutput.Text))
                tboutput.Text = "Insert String to Decrypt";
        }
    }
}
