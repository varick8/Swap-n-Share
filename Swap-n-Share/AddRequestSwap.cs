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
    public partial class AddRequestSwap : Form
    {
        Datalayer dl;

        public AddRequestSwap()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        private void AddRequestSwap_Load(object sender, EventArgs e)
        {
            if (dl != null)
            {
                LoadUserItem();
                LoadMyItem();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        txtPict.Image = Image.FromStream(new MemoryStream(imageArray));
                    }
                }
            }
        }

        private void LoadMyItem()
        {
            // Prepare the query with a parameter for user_id
            string qry = "SELECT * FROM public.\"Item\" WHERE user_id = @user_id";

            // Define the parameter with the UUID `id`
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID }
            };

            // Use the modified GetData method with a parameterized command
            using (var command = new NpgsqlCommand(qry))
            {
                command.Parameters.AddRange(parameters);

                DataTable dt = dl.GetData(command);

                // Set DisplayMember and ValueMember for ComboBox
                cbMyItem.DisplayMember = "name";    // Field to display in ComboBox
                cbMyItem.ValueMember = "item_id";   // Field to use as the value

                // Bind DataTable to ComboBox
                cbMyItem.DataSource = dt;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Define the SQL query for inserting into SwapItem
            string insertQuery = "INSERT INTO \"SwapItem\" (date, comment, my_item_id, item_id) VALUES (@date, @comment, @myitemid, @itemid)";

            // Define the SQL query to update availability for both my_item_id and item_id in the Item table
            string updateQuery = "UPDATE \"Item\" SET availability = FALSE WHERE item_id = @myitemid OR item_id = @itemid";

            // Retrieve the selected item ID from the ComboBox
            Guid ItemId;
            if (Guid.TryParse(cbMyItem.SelectedValue?.ToString(), out ItemId))
            {
                // Create parameters with Npgsql for PostgreSQL
                var parameters = new NpgsqlParameter[]
                {
        new NpgsqlParameter("@date", Convert.ToDateTime(txtDate.Text)),
        new NpgsqlParameter("@comment", txtComment.Text),
        new NpgsqlParameter("@myitemid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = ItemId }, // Set the selected item ID for my_item_id
        new NpgsqlParameter("@itemid", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Guid.Parse(id) }
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
            else
            {
                MessageBox.Show("Please select a valid item from the list.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
