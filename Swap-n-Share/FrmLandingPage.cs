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
            //axWindowsMediaPlayer1.URL = "C:\\Users\\ASUS\\source\\repos\\Swap-n-Share\\Swap-n-Share\\Resources\\LPVideo.mp4";
            //// Enable auto-play
            //axWindowsMediaPlayer1.settings.autoStart = true;
            //// Enable looping
            //axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void LoginTitleTxt1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp sd = new FrmSignUp();
            sd.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm sd = new LoginForm();
            sd.Show();
        }
    }
}
