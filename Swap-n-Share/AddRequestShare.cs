using Npgsql;
using Swap_n_Share.Class;
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
using System.Xml.Linq;

namespace Swap_n_Share
{
    public partial class AddRequestShare : Form
    {
        Datalayer dl;

        public AddRequestShare()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void AddRequest_Load(object sender, EventArgs e)
        {
            if (dl != null)
            {
                LoadUserItem();
            }
        }

        public string id = "";

        private void LoadUserItem()
        {
            // Prepare the query with a parameter for item_id
            string qry = "SELECT * FROM public.\"Item\" WHERE item_id = @item_id";

            // Define the parameter with the UUID `id`
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@item_id", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Guid.Parse(id) }
            };

            // Use the modified GetData method with a parameterized command
            using (var command = new NpgsqlCommand(qry))
            {
                command.Parameters.AddRange(parameters);

                DataTable dt = dl.GetData(command);
                foreach (DataRow row in dt.Rows)
                {
                    lblItem.Text = row["name"].ToString();

                    // Get and display the image
                    if (row["image"] != DBNull.Value)
                    {
                        byte[] imageArray = (byte[])row["image"];
                        picPinjam.Image = Image.FromStream(new MemoryStream(imageArray));
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Define the SQL query for inserting into SwapItem
            string insertQuery = "INSERT INTO \"ShareItem\" (date_start, date_end, comment, user_id, item_id) VALUES (@datestart, @dateend, @comment, @userid, @itemid)";

            // Define the SQL query to update availability for both my_item_id and item_id in the Item table
            string updateQuery = "UPDATE \"Item\" SET availability = FALSE WHERE item_id = @itemid";

            var parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@datestart", Convert.ToDateTime(dateStart.Text)),
        new NpgsqlParameter("@dateend", Convert.ToDateTime(dateEnd.Text)),
        new NpgsqlParameter("@comment", tbComment.Text),
        new NpgsqlParameter("@itemid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Guid.Parse(id) }, // Set the selected item ID for my_item_id
        new NpgsqlParameter("@userId", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID }
            };

            // Execute the insert query
            string insertResult = dl.InsertUpdateDeleteCreate(insertQuery, parameters);

            if (insertResult.Contains("Failed") || insertResult.Contains("failed"))
            {
                MessageBox.Show("Request failed: " + insertResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Execute the update query to set availability to false
                string updateResult = dl.InsertUpdateDeleteCreate(updateQuery, parameters);

                if (updateResult.Contains("Failed") || updateResult.Contains("failed"))
                {
                    MessageBox.Show("Updating availability failed: " + updateResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Request Sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
