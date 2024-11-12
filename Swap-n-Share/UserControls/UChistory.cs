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
    public partial class UChistory : UserControl
    {
        public UChistory()
        {
            InitializeComponent();
        }
        public Image ProfilePic
        {
            get { return PicBox.Image; }
            set { PicBox.Image = value; }
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
        private void UCactivity_Load(object sender, EventArgs e)
        {

        }
    }
}
