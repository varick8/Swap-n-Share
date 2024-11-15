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
    public partial class FrmEditBio : Form
    {
        public FrmEditBio()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmEditProfile sd = new FrmEditProfile();
            this.Hide();
            sd.Show();
        }

        private void guna2ControlBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmProfileSwap sd = new FrmProfileSwap();
            this.Hide();
            sd.Show();
        }
    }
}
