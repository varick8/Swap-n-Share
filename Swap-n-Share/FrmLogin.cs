using Npgsql;
using NpgsqlTypes;
using Swap_n_Share.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Swap_n_Share
{
    public partial class LoginForm : Form
    {
        Datalayer dl;

        public LoginForm()
        {
            dl = new Datalayer();
            InitializeComponent();
        }

        private void LoginButton_Clicks(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill both fields!");
                return;
            }


            if (Datalayer.UserDetails(tbUsername.Text, tbPassword.Text) == true)
            {
                // Show a success message*/
                MessageBox.Show("Login successful! Welcome to the system.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmHome frm = new FrmHome();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName Or Password Doesn't Match. Please Try Again!", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Clear();
                tbPassword.Clear();
            }
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmSignUp sd = new FrmSignUp();
            sd.Show();
        }

        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCB.Checked)
            {
                tbPassword.PasswordChar = '\0';  // Show the password
            }
            else
            {
                tbPassword.PasswordChar = '●';  // Hide the password
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
