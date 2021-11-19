using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox_Placeholder(TextID, "ID");
            TextBox_Placeholder(TextPassword, "Password");
        }

        private void TextID_Enter(object sender, EventArgs e)
        {
            if (TextID.Text == "ID")
                TextID.Text = "";
        }

        private void TextID_Leave(object sender, EventArgs e)
        {
            if (TextID.Text == "")
                TextID.Text = "ID";
        }

        private void TextPassword_Enter(object sender, EventArgs e)
        {
            if (TextPassword.Text == "Password")
            {
                TextPassword.UseSystemPasswordChar = true;
                TextPassword.Text = "";
                //TextID.ForeColor = ;
            }
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            if (TextPassword.Text == "")
            {
                TextPassword.UseSystemPasswordChar = false;
                TextPassword.Text = "Password";

            }
            //if( (KeyPressEventArgs) e == Keys.Enter)

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginCreds_PressEnter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (TextID.Text == "Sex" && TextPassword.Text == "bussy")
                {
                    BankDetails BD= new BankDetails();
                    BD.Show();
                    this.Close();
                }
            }
        }
    }
}
