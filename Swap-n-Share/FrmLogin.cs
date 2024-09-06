using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap_n_Share
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

/*        Connectionsql sql = new Connectionsql();*/


        private void Form1_Load(object sender, EventArgs e)
        {
/*            UsernameTB.Text = string.Empty;
            PasswordTB.Text = string.Empty;
            UsernameTB.Focus();*/
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

        private void ShowPassCB_CheckedChanged_1(object sender, EventArgs e)
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

        private void PasswordTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                if (string.IsNullOrWhiteSpace(UsernameTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text))
                {
                    MessageBox.Show("Invalid Username and password, please input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (NpgsqlConnection conn = new NpgsqlConnection("YourConnectionStringHere"))
                {
                    conn.Open();

                    // Assuming you have a table named 'login' with columns 'username' and 'password'
                    string query = "SELECT * FROM login WHERE username = @username AND password = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Add parameters from the table
                        cmd.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Varchar, UsernameTB.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Varchar, PasswordTB.Text.Trim());

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                this.Hide();
                                FrmHome frm = new FrmHome();
                                frm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username and password, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void UsernameTB_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
