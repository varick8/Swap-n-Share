using Swap_n_Share.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap_n_Share.UserControls
{
    public partial class UCProfileItems : UserControl
    {
        public event EventHandler onSelect = null;
        Datalayer dl;

        public UCProfileItems()
        {
            InitializeComponent();
            dl = new Datalayer();
        }

        public string eName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string eCategory
        {
            get { return lblCat.Text; }
            set { lblCat.Text = value; }
        }

        public string eLocation
        {
            get { return lblLoc.Text; }
            set { lblLoc.Text = value; }
        }

        public Image eImage
        {
            get { return txtPic.Image; }
            set { txtPic.Image = value; }
        }

        public string eDesc
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }
        }
    }
}
