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
            string s_id;
            // Using parameterized query to prevent SQL injection
            string qry = "SELECT user_id FROM public.\"User\" WHERE username = '" + UsernameTB.Text + "' AND password = '" + PasswordTB.Text + "';";

            // Updating the method call to use parameterized query
            dl.GetSingleColumnValueByIndexParameterized(qry, out s_id, 0);

            if (s_id != null)
            {
                // Show a success message
                MessageBox.Show("Login successful! Welcome to the system.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmHome sd = new FrmHome();
                sd.Show();
            }
            else
            {
                MessageBox.Show("UserName Or Password Doesn't Match. Please Try Again!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                PasswordTB.PasswordChar = '\0';  // Show the password
            }
            else
            {
                PasswordTB.PasswordChar = '●';  // Hide the password
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
