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
    public partial class FrmLandingPage : Form
    {
        public FrmLandingPage()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp sd = new FrmSignUp();
            sd.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm sd = new LoginForm();
            sd.Show();
        }
    }
}
