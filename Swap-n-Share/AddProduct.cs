using Npgsql;
using Swap_n_Share.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Swap_n_Share
{
    public partial class AddProduct : Form
    {
        Datalayer dl;

        public AddProduct()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
               cbCat.SelectedItem == null ||
                txtPic.Image == null ||
                !rbShare.Checked && !rbSwap.Checked)
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

            // Define the SQL query with parameters for PostgreSQL
            string query = "INSERT INTO \"Item\" (name, category, description, swap, share, image, address, user_id) VALUES (@name, @category, @description, @swap, @share, @image, @address, @userid)";

            // Create parameters with Npgsql for PostgreSQL
            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@name", tbName.Text),
        new NpgsqlParameter("@category", cbCat.SelectedItem.ToString()),
        new NpgsqlParameter("@description", tbDesc.Text),
        new NpgsqlParameter("@address", tbAddress.Text),
        new NpgsqlParameter("@swap", rbSwap.Checked),
        new NpgsqlParameter("@share", rbShare.Checked),
        // Ensure the image parameter is of type bytea
        new NpgsqlParameter("@image", NpgsqlTypes.NpgsqlDbType.Bytea) { Value = BtyArray },
        new NpgsqlParameter("@userid", Datalayer.ID)
            };

            // Call the Datalayer method to execute the command with the parameters
            string result = dl.InsertUpdateDeleteCreate(query, parameters);

            if (result.Contains("Failed") || result.Contains("failed"))
            {
                MessageBox.Show("Add Product failed: " + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Product Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
