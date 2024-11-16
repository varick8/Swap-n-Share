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
    public partial class FrmEditProfile : Form
    {
        public FrmEditProfile()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void btnEditBio_Click(object sender, EventArgs e)
        {
            FrmEditBio sd = new FrmEditBio();
            this.Hide();
            sd.Show();
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            FrmEditUsername sd = new FrmEditUsername();
            this.Hide();
            sd.Show();
        }

        private void btnEditPict_Click(object sender, EventArgs e)
        {
            FrmEditProfilePicture sd = new FrmEditProfilePicture();
            this.Hide();
            sd.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductSwap sd = new FrmProductSwap();
            this.Hide();
            sd.Show();
        }

        private void btnCommunnity_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
