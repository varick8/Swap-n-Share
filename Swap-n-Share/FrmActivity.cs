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
    public partial class FrmActivity : Form
    {

        public FrmActivity()
        {
            InitializeComponent();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmCommunity sd = new FrmCommunity();
            this.Hide();
            sd.Show();
        }



        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            FrmHome sd = new FrmHome();
            this.Hide();
            sd.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FrmHistory sd = new FrmHistory();
            this.Hide();
            sd.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmProduct sd = new FrmProduct();
            this.Hide();
            sd.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmProfile sd = new FrmProfile();
            this.Hide();
            sd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmSetting sd = new FrmSetting();
            this.Hide();
            sd.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            FrmActivitySwap sd = new FrmActivitySwap();
            this.Hide();
            sd.Show();
        }
    }
}
