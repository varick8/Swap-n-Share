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
    public partial class UCproductshare : UserControl
    {
        public event EventHandler onSelect = null;
        Datalayer dl;

        public UCproductshare()
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

        private void btnShare_Click(object sender, EventArgs e)
        {
            // Open the frmSwap form if items exist
            AddRequestShare frm = new AddRequestShare();
            frm.id = id;
            frm.ShowDialog();

            // Trigger any additional button click behavior
            btn_click(sender, e);
        }
    }
}
