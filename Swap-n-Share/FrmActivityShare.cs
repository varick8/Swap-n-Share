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
    public partial class FrmActivityShare : Form
    {
        Datalayer dl;

        public FrmActivityShare()
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmHistoryShare sd = new FrmHistoryShare();
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

        private void btnActivitySwap_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }

        private void FrmActivity_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void AddItems(string Id, string ItemId, string Pinjam, string TanggalStart, string TanggalEnd, string Req, string Komen, string Telpon, Image Pictawar)
        {
            var s = new UCactivityShare(this)
            {
                pinjam = Pinjam,
                tanggalStart = TanggalStart,
                tanggalEnd = TanggalEnd,
                req = Req,
                komen = Komen,
                telpon = Telpon,
                pic = Pictawar,
                itemid = ItemId,
                id = Id // No conversion needed, keep id as string
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
                       si.shareitem_id AS id, 
                       si.date_start AS DateStart,
                       si.date_end AS DateEnd,
                        i.name AS Tawar,
                       u.username AS Req, 
                       u.phone AS Telpon, 
                       si.comment AS Komen, 
                       i.image AS picTawar, 
                        si.item_id as itemid
                   FROM public.""ShareItem"" si 
                   JOIN public.""Item"" i ON si.item_id = i.item_id 
                   JOIN public.""User"" u ON si.user_id = u.user_id 
                   WHERE i.user_id = @user_id AND si.status IS NULL";

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
                        Image picTawar = row["picTawar"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["picTawar"])) : null;

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
                            row["id"].ToString(),           // SwapItem ID
                            row["itemid"].ToString(),
                            row["Tawar"].ToString(),        // Tukar item name
                            formattedDateStart,
                            formattedDateEnd,
                            row["Req"].ToString(),          // Requested username
                            row["Komen"].ToString(),        // Comment
                            row["Telpon"].ToString(),       // Phone number
                            picTawar                        // Image for item_id
                        ); 
                    }
                }
            }
        }
    }
}
