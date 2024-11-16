using Npgsql;
using Swap_n_Share.Class;
using Swap_n_Share.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap_n_Share
{
    public partial class FrmProfileShare : Form
    {
        Datalayer dl;

        public FrmProfileShare()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductShare sd = new FrmProductShare();
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
            FrmActivityShare sd = new FrmActivityShare();
            this.Hide();
            sd.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.ShowDialog();
            Loaddata();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }

        private void FrmProfileShare_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "@" + Datalayer.USERNAME;
            lblBio.Text = Datalayer.BIO;

            if (Datalayer.PICT != null)
            {
                txtPict.Image = Datalayer.PICT;
            }
            Loaddata();
        }

        private void AddItems(string desc, string name, string cat, string loc, Image img)
        {
            var p = new UCProfileItems()
            {
                eName = name,
                eCategory = cat,
                eImage = img,
                eLocation = loc,
                eDesc = desc,
            };
            flowLayoutPanel1.Controls.Add(p);
            p.onSelect += (ss, ee) =>
            {
                Loaddata();
            };
        }

        private void Loaddata()
        {
            flowLayoutPanel1.Controls.Clear();

            // Updated query to exclude items with item_id or my_item_id in SwapItem
            string qry = "SELECT * FROM public.\"Item\" WHERE user_id = @userId AND share = True AND availability = True"; ;

            // Define parameters for the search term and user_id
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@userId", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID }
            };

            // Pass the parameterized command to the Datalayer
            using (var command = new NpgsqlCommand(qry))
            {
                command.Parameters.AddRange(parameters);
                DataTable dt = dl.GetData(command);

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // Ensure the "image" column has data before attempting to create the image
                        if (row["image"] != DBNull.Value)
                        {
                            byte[] imageArray = (byte[])row["image"];
                            AddItems(
                                row["description"].ToString(),    // UUID as a string
                                row["name"].ToString(),
                                row["category"].ToString(),
                                row["address"].ToString(),
                                Image.FromStream(new MemoryStream(imageArray))
                            );
                        }
                    }
                }
            }
        }
    }
}
