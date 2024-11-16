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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Swap_n_Share
{
    public partial class FrmAccountSetting : Form
    {
        Datalayer dl;

        public FrmAccountSetting()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword sd = new FrmChangePassword();
            this.Hide();
            sd.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductSwap sd = new FrmProductSwap();
            this.Hide();
            sd.Show();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void FrmAccountSetting_Load(object sender, EventArgs e)
        {
            lblUserUsername.Text = Datalayer.USERNAME;
            lblPhone.Text = Datalayer.PHONE;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
          "Are you sure you want to delete your account? This action cannot be undone.",
          "Delete Account",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
      );

            if (confirmation != DialogResult.Yes) return;

            try
            {
                NpgsqlParameter[] parameters = {
            new NpgsqlParameter("@userid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID }
        };

                // Step 1: Delete from SwapItem where the user is either the requester or owner
                string deleteSwapItemQuery = @"
            DELETE FROM ""SwapItem"" 
            WHERE item_id IN (SELECT item_id FROM ""Item"" WHERE user_id = @userid)
            OR my_item_id IN (SELECT item_id FROM ""Item"" WHERE user_id = @userid);";
                string result1 = dl.InsertUpdateDeleteCreate(deleteSwapItemQuery, parameters);
                if (result1.Contains("failed"))
                {
                    MessageBox.Show("Error deleting from SwapItem: " + result1);
                    return;
                }

                // Step 2: Delete from ShareItem
                string deleteShareItemQuery = @"
            DELETE FROM ""ShareItem"" 
            WHERE user_id = @userid 
            OR item_id IN (SELECT item_id FROM ""Item"" WHERE user_id = @userid);";
                string result2 = dl.InsertUpdateDeleteCreate(deleteShareItemQuery, parameters);
                if (result2.Contains("failed"))
                {
                    MessageBox.Show("Error deleting from ShareItem: " + result2);
                    return;
                }

                // Step 3: Delete user's items
                string deleteItemQuery = "DELETE FROM \"Item\" WHERE user_id = @userid;";
                string result3 = dl.InsertUpdateDeleteCreate(deleteItemQuery, parameters);
                if (result3.Contains("failed"))
                {
                    MessageBox.Show("Error deleting from Item: " + result3);
                    return;
                }

                // Step 4: Delete the user
                string deleteUserQuery = "DELETE FROM \"User\" WHERE user_id = @userid;";
                string result4 = dl.InsertUpdateDeleteCreate(deleteUserQuery, parameters);
                if (result4.Contains("failed"))
                {
                    MessageBox.Show("Error deleting user: " + result4);
                    return;
                }

                MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
