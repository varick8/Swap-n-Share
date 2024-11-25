﻿using Npgsql;
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
    public partial class FrmProductSwap : Form
    {
        Datalayer dl;
        public FrmProductSwap()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            FrmProductShare sd = new FrmProductShare();
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

        private void AddItems(string id, string name, string cat, string loc, string Desc, Image img)
        {
            var p = new UCproductswap()
            {
                eName = name,
                eCategory = cat,
                eImage = img,
                eDesc = Desc,
                eLocation = loc,
                id = id // No conversion needed, keep id as string
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
            string qry = "SELECT * FROM public.\"Item\" WHERE name ILIKE @name AND user_id != @userId AND swap = True AND availability = True AND category ILIKE @category"; ;

            string selectedCategory = cbFilter.SelectedItem != null ? cbFilter.SelectedItem.ToString() : "";

            // Define parameters for the search term and user_id
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Text) { Value = "%" + txtSearch.Text + "%" },
        new NpgsqlParameter("@category", NpgsqlTypes.NpgsqlDbType.Text) { Value = "%" + selectedCategory + "%" },
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
                                row["item_id"].ToString(),    // UUID as a string
                                row["name"].ToString(),
                                row["description"].ToString(),
                                row["category"].ToString(),
                                row["address"].ToString(),
                                Image.FromStream(new MemoryStream(imageArray))
                            );
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFilter.SelectedItem = null;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}