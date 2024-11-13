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
        public UChistorySwap()
        {
            InitializeComponent();
        }
        public Image ProfilePic
        {
            get { return PicBox.Image; }
            set { PicBox.Image = value; }
        }
        public Image MyProfilePic
        {
            get { return guna2PictureBox1.Image; }
            set { guna2PictureBox1.Image = value; }
        }
        public string txtName
        {
            get { return labelNama.Text; }
            set { labelNama.Text = value; }
        }

        public string txtTanggal
        {
            get { return labelTanggal.Text; }
            set { labelTanggal.Text = value; }  // Fixed line
        }
        public string txtOwner
        {
            get { return labelOwner.Text; }
            set { labelOwner.Text = value; }  // Fixed line
        }
        public string txtBarangKita
        {
            get { return labelBarangKita.Text; }
            set { labelBarangKita.Text = value; }  // Fixed line
        }
        public string txtSatus
        {
            get { return labelStatus.Text; }
            set { labelStatus.Text = value; }  // Fixed line
        }
        private void UCactivity_Load(object sender, EventArgs e)
        {

        }
    }
}
