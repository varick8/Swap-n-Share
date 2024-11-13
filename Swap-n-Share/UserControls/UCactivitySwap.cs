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
    public partial class UCactivitySwap : UserControl
    {
        public UCactivitySwap()
        {
            InitializeComponent();
        }
        public Image ProfilePic
        {
            get { return PicBox.Image; }
            set { PicBox.Image = value; }
        }
        public Image ProfileBaru
        {
            get { return guna2PictureBox1.Image; }
            set { guna2PictureBox1.Image = value; }
        }

        public string txtName
        {
            get { return labelNama.Text; }
            set { labelNama.Text = value; }
        }
        public string txtHandphone
        {
            get { return labelNomor.Text; }
            set { labelNomor.Text = value; }
        }

        public string txtTanggal
        {
            get { return labelTanggal.Text; }
            set { labelTanggal.Text = value; }  // Fixed line
        }
        public string txtKomen
        {
            get { return labelKomen.Text; }
            set { labelKomen.Text = value; }  // Fixed line
        }
        public string txtUser
        {
            get { return labelUser.Text; }
            set { labelUser.Text = value; }  // Fixed line
        }
        public string txtBarangBAru
        {
            get { return labelBarangBaru.Text; }
            set { labelBarangBaru.Text = value; }  // Fixed line
        }
        public string txtDes
        {
            get { return labelDes.Text; }
            set { labelDes.Text = value; }  // Fixed line
        }
        private void labelKomen_Click(object sender, EventArgs e)
        {

        }
    }
}
