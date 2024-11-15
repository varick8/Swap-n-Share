using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap_n_Share
{
    public partial class FrmEditProfilePicture : Form
    {
        public FrmEditProfilePicture()
        {
            InitializeComponent();
        }

        private void lblCurrentUsername_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmEditProfile sd = new FrmEditProfile();
            this.Hide();
            sd.Show();
        }

        private void guna2ControlBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
