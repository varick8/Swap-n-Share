using Npgsql;
using Swap_n_Share.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Swap_n_Share
{
    public partial class FrmEditProfilePicture : Form
    {
        Datalayer dl;

        public FrmEditProfilePicture()
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
            frm.Show();
            this.Hide();
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
            frm.Show();
            this.Hide();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filPath = ofd.FileName;
                txtPic.Image = new Bitmap(filPath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Datalayer.PICT != null)
            {
                txtPic.Image = Datalayer.PICT;
            }
            else
            {
                txtPic.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPic.Image == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert image to byte array
            byte[] BtyArray;
            using (MemoryStream ms = new MemoryStream())
            {
                txtPic.Image.Save(ms, ImageFormat.Png);
                BtyArray = ms.ToArray();
            }

            string updateQuery = "UPDATE \"User\" SET image = @image WHERE user_id = @userid";

            // Define the parameter for user_id
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@userid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID },
        new NpgsqlParameter("@image", NpgsqlTypes.NpgsqlDbType.Bytea) { Value = BtyArray },
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
                dl.UpdatePict(txtPic.Image);
                FrmProfileSwap sd = new FrmProfileSwap();
                sd.Show();
                this.Close();
            }
        }

        private void FrmEditProfilePicture_Load(object sender, EventArgs e)
        {
            if (Datalayer.PICT != null)
            {
                txtPic.Image = Datalayer.PICT;
            }
        }
    }
}
