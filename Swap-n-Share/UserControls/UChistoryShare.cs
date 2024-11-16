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
    public partial class UChistoryShare : UserControl
    {
        public event EventHandler onSelect = null;

        public UChistoryShare()
        {
            InitializeComponent();
        }

        public string dateStart { get; set; }

        public string dateEnd { get; set; }

        public string pinjam
        {
            get { return lblPinjam.Text; }
            set { lblPinjam.Text = value; }
        }

        public string owner
        {
            get { return lblOwner.Text; }
            set { lblOwner.Text = value; }
        }

        public string status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }
        public Image picDipinjam
        {
            get { return picPinjam.Image; }
            set { picPinjam.Image = value; }
        }

        private void UChistory_Load(object sender, EventArgs e)
        {
            if (lblStatus.Text == "False")
            {
                lblStatus.Text = "Rejected";
            }
            else if (lblStatus.Text == "True")
            {
                lblStatus.Text = "Accepted";
            }
            else
            {
                lblStatus.Text = "Pending";
            }

            lblTanggal.Text = dateStart + "-" + dateEnd;
        }
    }
}
