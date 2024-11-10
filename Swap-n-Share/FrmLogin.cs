/*using Npgsql;
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
    }
}*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Swap_n_Share
{
    public partial class LoginForm : Form
    {
        // In-memory dictionary to store user credentials
        private Dictionary<string, string> users;

        public LoginForm()
        {
            InitializeComponent();
            users = new Dictionary<string, string>();

            // Optionally, pre-populate with a default user (e.g., "admin", "password")
            users.Add("admin", "password");
        }

        private void LoginButton_Clicks(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;

            // Check if the user exists and the password matches
            if (users.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                MessageBox.Show("Login successful! Welcome to the system.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmCommunity sd = new FrmCommunity();
                sd.Show();
            }
            else
            {
                MessageBox.Show("Username or password doesn't match. Please try again!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;

            // Check if username already exists
            if (users.ContainsKey(username))
            {
                MessageBox.Show("Username already exists. Please choose another one.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add new user to the dictionary
            users.Add(username, password);
            MessageBox.Show("Sign-up successful! You can now log in.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = ShowPassCB.Checked ? '\0' : '●';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
