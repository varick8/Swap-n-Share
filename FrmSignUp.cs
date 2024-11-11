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

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO public.\"User\" (username, email, password) VALUES ('"
                + txtUsername.Text + "', '"
                + txtEmail.Text.ToLower() + "', '"
                + txtPassword.Text + "');";
            string result = dl.InsertUpdateDeleteCreate(query);

            if (result.Contains("Username_Key") || result.Contains("username_key"))
            {
                MessageBox.Show("The username is already in use. Please choose another.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear(); // Clear the username textbox
            }
            else if (result.Contains("Email_Key") || result.Contains("email_key"))
            {
                MessageBox.Show("The email is already in use. Please choose another.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear(); // Clear the email textbox
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
    }
}
