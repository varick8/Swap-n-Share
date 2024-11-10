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
    public partial class FrmHome : Form
    {

        public FrmHome()
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

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmProduct sd = new FrmProduct();
            this.Hide();
            sd.Show();
        }
    }
}
