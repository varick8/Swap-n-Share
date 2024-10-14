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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


        }

        private void PasswordTxt_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ShowPassCB_CheckedChange(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTB_TextChange(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Clicks(object sender, EventArgs e)
        {
            string s_id;
            // Using parameterized query to prevent SQL injection
            string qry = "SELECT user_id FROM public.\"User\" WHERE username = @username AND password = @password";

            // Updating the method call to use parameterized query
            s_id = dl.GetSingleColumnValueByIndexParameterized(qry, UsernameTB.Text, PasswordTB.Text, 0);

            if (!string.IsNullOrEmpty(s_id))
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

    }
}
