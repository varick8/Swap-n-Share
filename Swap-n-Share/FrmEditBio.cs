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
    public partial class FrmEditBio : Form
    {
        Datalayer dl;

        public FrmEditBio()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmEditProfile sd = new FrmEditProfile();
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
            this.Hide();
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductSwap sd = new FrmProductSwap();
            this.Hide();
            sd.Show();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            FrmCommunity frm = new FrmCommunity();
            this.Hide();
            frm.Show();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDescription.Clear();
        }

        private void FrmEditBio_Load(object sender, EventArgs e)
        {
            lblUserUsername.Text = Datalayer.BIO;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = "UPDATE \"User\" SET bio = @bio WHERE user_id = @userid";

            // Define the parameter for user_id
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@userid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID },
        new NpgsqlParameter("@bio", tbDescription.Text)

            };

            // Execute the insert query
            string result = dl.InsertUpdateDeleteCreate(updateQuery, parameters);

            if (result.Contains("Failed") || result.Contains("failed"))
            {
                MessageBox.Show("Update failed: " + result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dl.UpdateBio(tbDescription.Text);
                FrmProfileSwap sd = new FrmProfileSwap();
                sd.Show();
                this.Close();
            }
        }
    }
}
