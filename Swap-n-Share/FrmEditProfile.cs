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

        private void guna2ControlBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            FrmEditBio sd = new FrmEditBio();
            this.Hide();
            sd.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FrmEditUsername sd = new FrmEditUsername();
            this.Hide();
            sd.Show();
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            FrmEditProfilePicture sd = new FrmEditProfilePicture();
            this.Hide();
            sd.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FrmProduct sd = new FrmProduct();
            this.Hide();
            sd.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmActivity sd = new FrmActivity();
            this.Hide();
            sd.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void guna2ControlBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
