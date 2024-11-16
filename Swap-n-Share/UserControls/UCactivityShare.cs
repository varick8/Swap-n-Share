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

namespace Swap_n_Share.UserControls
{
    public partial class UCactivityShare : UserControl
    {
        public event EventHandler onSelect = null;
        Datalayer dl;
        private FrmActivityShare parentForm;

        public UCactivityShare(FrmActivityShare parent)
        {
            InitializeComponent();
            dl = new Datalayer();
            parentForm = parent;
        }

        public string id { get; set; }

        public string itemid { get; set; }

        public string tanggalStart { get; set; }

        public string tanggalEnd { get; set; }

        public string pinjam
        {
            get { return lblPinjam.Text; }
            set { lblPinjam.Text = value; }
        }

        public string req
        {
            get { return lblReq.Text; }
            set { lblReq.Text = value; }
        }

        public string komen
        {
            get { return lblKomen.Text; }
            set { lblKomen.Text = value; }
        }

        public string telpon
        {
            get { return lblTelpon.Text; }
            set { lblTelpon.Text = value; }
        }

        public Image pic
        {
            get { return picPinjam.Image; }
            set { picPinjam.Image = value; }
        }

        private void UCactivityShare_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = tanggalStart + "-" + tanggalEnd;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Define the SQL query for inserting into SwapItem
            string insertQuery = "UPDATE \"ShareItem\" SET status = True WHERE shareitem_id = @swapid";

            // Create parameters with Npgsql for PostgreSQL
            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@swapid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Guid.Parse(id) }, // Set the selected item ID for my_item_id
    
            };

            // Execute the insert query
            string insertResult = dl.InsertUpdateDeleteCreate(insertQuery, parameters);

            if (insertResult.Contains("Failed") || insertResult.Contains("failed"))
            {
                MessageBox.Show("Accept Fail: " + insertResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Request Successfully Accepted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmActivityShare sd = new FrmActivityShare();
                sd.Show();
                parentForm.Hide();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            // Define the SQL query for inserting into SwapItem
            string insertQuery = "UPDATE \"ShareItem\" SET status = False WHERE shareitem_id = @swapid";

            // Define the SQL query to update availability for both my_item_id and item_id in the Item table
            string updateQuery = "UPDATE \"Item\" SET availability = True WHERE item_id = @itemid";

            // Create parameters with Npgsql for PostgreSQL
            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@swapid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Guid.Parse(id) }, // Set the selected item ID for my_item_id
        new NpgsqlParameter("@itemid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Guid.Parse(itemid) }
            };

            // Execute the insert query
            string insertResult = dl.InsertUpdateDeleteCreate(insertQuery, parameters);

            if (insertResult.Contains("Failed") || insertResult.Contains("failed"))
            {
                MessageBox.Show("Reject failed: " + insertResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Execute the update query to set availability to false
                string updateResult = dl.InsertUpdateDeleteCreate(updateQuery, parameters);

                if (updateResult.Contains("Failed") || updateResult.Contains("failed"))
                {
                    MessageBox.Show("Reject Fail!: " + updateResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Request Successfully Rejected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmActivityShare sd = new FrmActivityShare();
                    sd.Show();
                    parentForm.Hide();
                }
            }
        }
    }
}
