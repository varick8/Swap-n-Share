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

namespace Swap_n_Share
{
    public partial class FrmChangePassword : Form
    {
        Datalayer dl;

        public FrmChangePassword()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAccountSetting sd = new FrmAccountSetting();
            this.Hide();
            sd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductSwap sd = new FrmProductSwap();
            sd.Show();
            this.Hide();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            FrmCommunity frm = new FrmCommunity();
            frm.Show();
            this.Hide();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            sd.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCurrent.Text) || string.IsNullOrWhiteSpace(tbNew.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbCurrent.Text == Datalayer.PW)
            {
                string updateQuery = "UPDATE public.\"User\" SET password = @new WHERE user_id = @userid AND password = @current";
                // Define the parameter for user_id
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
     new NpgsqlParameter("@userid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID },
     new NpgsqlParameter("@current", tbCurrent.Text),
     new NpgsqlParameter("@new", tbNew.Text)
                };
                // Execute the insert query
                string result = dl.InsertUpdateDeleteCreate(updateQuery, parameters);

                if (result.Contains("Failed") || result.Contains("failed"))
                {
                    MessageBox.Show("Update failed: " + result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAccountSetting frm = new FrmAccountSetting();
                    frm.Show();
                    this.Close();
                }
            }else
            {
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
