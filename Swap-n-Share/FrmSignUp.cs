using Npgsql;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Swap_n_Share
{
    public partial class FrmSignUp : Form
    {
        Datalayer dl;

        public FrmSignUp()
        {
            dl = new Datalayer();
            InitializeComponent();
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm sd = new LoginForm();
            sd.Show();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define the SQL query with parameters for PostgreSQL
            string query = "INSERT INTO \"User\" (phone, username, password) VALUES (@phone, @username, @password)";

            // Create parameters with Npgsql for PostgreSQL
            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@phone", txtPhone.Text),
        new NpgsqlParameter("@username", txtUsername.Text),
        new NpgsqlParameter("@password", txtPassword.Text),
            };

            // Call the Datalayer method to execute the command with the parameters
            string result = dl.InsertUpdateDeleteCreate(query, parameters);

            if (result.Contains("Username_Key") || result.Contains("username_key"))
            {
                MessageBox.Show("The username is already in use. Please choose another.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear(); // Clear the username textbox
            }
            else if (result.Contains("Phone_Key") || result.Contains("phone_key"))
            {
                MessageBox.Show("The phone is already in use. Please choose another.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear(); // Clear the email textbox
            }
            else if (result.Contains("Failed") || result.Contains("failed"))
            {
                MessageBox.Show("Sign-up failed: " + result, "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sign-up successful! Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm sd = new LoginForm();
                sd.Show();
            }
        }

        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCB.Checked)
            {
                txtPassword.PasswordChar = '\0';  // Show the password
            }
            else
            {
                txtPassword.PasswordChar = '●';  // Hide the password
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
