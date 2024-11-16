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
    public partial class UChistorySwap : UserControl
    {
        public event EventHandler onSelect = null;

        public UChistorySwap()
        {
            InitializeComponent();
        }

        public string tukar
        {
            get { return lblTukar.Text; }
            set { lblTukar.Text = value; }
        }

        public string tawar
        {
            get { return lblTawar.Text; }
            set { lblTawar.Text = value; }
        }

        public string tanggal
        {
            get { return lblTanggal.Text; }
            set { lblTanggal.Text = value; }
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

        public Image picDitukar
        {
            get { return picTukar.Image; }
            set { picTukar.Image = value; }
        }

        public Image picDitawar
        {
            get { return picTawar.Image; }
            set { picTawar.Image = value; }
        }

        private void UCactivity_Load(object sender, EventArgs e)
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
        }
    }
}
