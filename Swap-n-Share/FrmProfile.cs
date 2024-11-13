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
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmActivity sd = new FrmActivity();
            this.Hide();
            sd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.ShowDialog();
        }
    }
}
