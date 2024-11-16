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
    public partial class FrmHistorySwap : Form
    {
        Datalayer dl;

        public FrmHistorySwap()
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

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmHistoryShare sd = new FrmHistoryShare();
            this.Hide();
            sd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductSwap sd = new FrmProductSwap();
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

        private void FrmHistorySwap_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void AddItems(string Tukar, string Tawar, string Tanggal, string Owner, Image Pictukar, Image Pictawar, string Status)
        {
            var s = new UChistorySwap()
            {
                tukar = Tukar,
                tawar = Tawar,
                tanggal = Tanggal,
                owner = Owner,
                picDitawar = Pictawar,
                picDitukar = Pictukar,
                status = Status
            };
            flowLayoutPanel1.Controls.Add(s);
            s.onSelect += (ss, ee) =>
            {
                Loaddata();
            };
        }

        private void Loaddata()
        {
            flowLayoutPanel1.Controls.Clear();

            // SQL query with unambiguous user_id reference
            string qry = @"SELECT 
                       si.date AS Date,
                       mi.name AS Tawar,
                        i.name AS Tukar,
                       u.username AS Req, 
                       i.image AS picTukar, 
                       mi.image AS picTawar,
                       si.status AS status
                   FROM public.""SwapItem"" si 
                   JOIN public.""Item"" i ON si.item_id = i.item_id 
                   JOIN public.""Item"" mi ON si.my_item_id = mi.item_id 
                   JOIN public.""User"" u ON i.user_id = u.user_id 
                   WHERE mi.user_id = @user_id";

            // Define the parameter for user_id
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID }
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
                        // Convert images if they are not null
                        Image picTukar = row["picTukar"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["picTukar"])) : null;
                        Image picTawar = row["picTawar"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["picTawar"])) : null;

                        // Parse and format the date
                        string formattedDate = string.Empty;
                        if (row["Date"] != DBNull.Value)
                        {
                            DateTime date = DateTime.Parse(row["Date"].ToString());
                            formattedDate = date.ToString("yyyy/MM/dd"); // Adjust format as needed
                        }

                        AddItems(
                            row["Tukar"].ToString(),        // Tukar item name
                            row["Tawar"].ToString(),        // Tukar item name
                            formattedDate,
                            row["Req"].ToString(),          // Requested username
                            picTukar,                       // Image for my_item_id
                            picTawar,
                            row["status"].ToString()
                        );
                    }
                }
            }
        }
    }
}
