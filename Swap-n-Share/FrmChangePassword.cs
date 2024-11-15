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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmAccountSetting sd = new FrmAccountSetting();
            this.Hide();
            sd.Show();
        }

        private void guna2ControlBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
