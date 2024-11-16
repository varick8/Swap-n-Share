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
    public partial class FrmHistoryShare : Form
    {
        Datalayer dl;

        public FrmHistoryShare()
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
            FrmActivityShare sd = new FrmActivityShare();
            this.Hide();
            sd.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmHistorySwap sd = new FrmHistorySwap();
            this.Hide();
            sd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductShare sd = new FrmProductShare();
            this.Hide();
            sd.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfileShare sd = new FrmProfileShare();
            this.Hide();
            sd.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void AddItems(string Pinjam, string dateStart, string dateEnd, string Owner, Image Pictpinjam, string Status)
        {
            var s = new UChistoryShare()
            {
                pinjam = Pinjam,
                owner = Owner,
                dateStart = dateStart,
                dateEnd = dateEnd,
                picDipinjam = Pictpinjam,
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
                       si.date_start AS DateStart,
                       si.date_end AS DateEnd,
                       i.name AS Pinjam,
                       u.username AS Owner,  
                       i.image AS picPinjam,
                       si.status AS status
                   FROM public.""ShareItem"" si 
                   JOIN public.""Item"" i ON si.item_id = i.item_id 
                   JOIN public.""User"" u ON i.user_id = u.user_id 
                   WHERE si.user_id = @user_id";

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
                        Image picPinjam = row["picPinjam"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["picPinjam"])) : null;

                        // Parse and format the date
                        string formattedDateStart = string.Empty;
                        if (row["DateStart"] != DBNull.Value)
                        {
                            DateTime date = DateTime.Parse(row["DateStart"].ToString());
                            formattedDateStart = date.ToString("yyyy/MM/dd"); // Adjust format as needed
                        }
                        string formattedDateEnd = string.Empty;
                        if (row["DateEnd"] != DBNull.Value)
                        {
                            DateTime date = DateTime.Parse(row["DateEnd"].ToString());
                            formattedDateEnd = date.ToString("yyyy/MM/dd"); // Adjust format as needed
                        }

                        AddItems(
                            row["Pinjam"].ToString(),        // Tukar item name
                            formattedDateStart,
                            formattedDateEnd,
                            row["Owner"].ToString(),          // Requested username
                            picPinjam,                       // Image for my_item_id
                            row["status"].ToString()
                        );
                    }
                }
            }
        }
    }
}
