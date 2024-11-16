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
    public partial class UCproductswap : UserControl
    {
        public event EventHandler onSelect = null;
        Datalayer dl;

        public UCproductswap()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        public string id { get; set; }

        public string eName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string eCategory
        {
            get { return lblCat.Text; }
            set { lblCat.Text = value; }
        }

        public string eLocation
        {
            get { return lblLoc.Text; }
            set { lblLoc.Text = value; }
        }

        public Image eImage
        {
            get { return txtPic.Image; }
            set { txtPic.Image = value; }
        }

        public string eDesc
        {
            get { return labelDeskripsi.Text; }
            set { labelDeskripsi.Text = value; }
        }

        private void btn_click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            // Check if there are items associated with the current user
            string qry = "SELECT COUNT(*) FROM public.\"Item\" WHERE user_id = @user_id";
            int itemCount = 0;

            using (var command = new NpgsqlCommand(qry))
            {
                command.Parameters.Add(new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = Datalayer.ID });

                DataTable dt = dl.GetData(command);

                if (dt.Rows.Count > 0 && int.TryParse(dt.Rows[0][0].ToString(), out itemCount))
                {
                    if (itemCount > 0)
                    {
                        // Open the frmSwap form if items exist
                        AddRequestSwap frm = new AddRequestSwap();
                        frm.id = id;
                        frm.ShowDialog();

                        // Trigger any additional button click behavior
                        btn_click(sender, e);
                    }
                    else
                    {
                        // Display a message if no items are found
                        MessageBox.Show("Please add an item first before swapping.", "No Items Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
