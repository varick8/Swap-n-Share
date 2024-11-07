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
    public partial class UCcommunity : UserControl
    {
        public UCcommunity()
        {
            InitializeComponent();
        }
        public Image ProfilePic
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string txtName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        public string txtStatus
        {
            get { return labelStatus.Text; }
            set { labelStatus.Text = value; }  // Fixed line
        }

        private void UCcommunity_Load(object sender, EventArgs e)
        {

        }
    }
}
