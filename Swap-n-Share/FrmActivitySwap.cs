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
    public partial class FrmActivitySwap : Form
    {
        Datalayer dl;

        public FrmActivitySwap()
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
            FrmHistorySwap sd = new FrmHistorySwap();
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

        private void btnActivityShare_Click(object sender, EventArgs e)
        {
            FrmActivityShare sd = new FrmActivityShare();
            this.Hide();
            sd.Show();
        }

        private void FrmActivitySwap_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void AddItems(string Id, string ItemId, string MyItemId, string Tukar, string Desc, string Tawar, string Tanggal, string Req, string Komen, string Telpon, Image Pictukar, Image Pictawar)
        {
            var s = new UCactivitySwap(this)
            {
                tukar = Tukar,
                tawar = Tawar,
                tanggal = Tanggal,
                req = Req,
                desc = Desc,
                komen = Komen,
                telpon = Telpon,
                picTawar = Pictawar,
                picTukar = Pictukar,
                itemid = ItemId,
                myitemid = MyItemId,
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
                       si.swapitem_id AS id, 
                       si.date AS Date,
                       i.name AS Tukar,
                        mi.name AS Tawar,
                        i.description AS Desc,
                       u.username AS Req, 
                       u.phone AS Telpon, 
                       si.comment AS Komen, 
                       mi.image AS picTawar, 
                       i.image AS picTukar,
                        si.item_id as itemid,
                        si.my_item_id as myitemid
                   FROM public.""SwapItem"" si 
                   JOIN public.""Item"" i ON si.item_id = i.item_id 
                   JOIN public.""Item"" mi ON si.my_item_id = mi.item_id 
                   JOIN public.""User"" u ON mi.user_id = u.user_id 
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
                            row["id"].ToString(),           // SwapItem ID
                            row["myitemid"].ToString(),
                            row["itemid"].ToString(),
                            row["Tukar"].ToString(),        // Tukar item name
                            row["Tawar"].ToString(),        // Tukar item name
                            row["Desc"].ToString(),
                            formattedDate,      
                            row["Req"].ToString(),          // Requested username
                            row["Komen"].ToString(),        // Comment
                            row["Telpon"].ToString(),       // Phone number
                            picTukar,                       // Image for my_item_id
                            picTawar                        // Image for item_id
                        ); 
                    }
                }
            }
        }
    }
}
