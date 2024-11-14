﻿using System;
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
    public partial class UCproductshare : UserControl
    {
        public UCproductshare()
        {
            InitializeComponent();
        }

        public string txtName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        public string txtStatus
        {
            get { return labelLoc.Text; }
            set { labelLoc.Text = value; }  // Fixed line
        }
        public string txtDesc
        {
            get { return labelDeskripsi.Text; }
            set { labelDeskripsi.Text = value; }
        }
        public string txtCategory
        {
            get { return labelCategory.Text; }
            set { labelCategory.Text = value; }
        }

        public Image ProfilePic
        {
            get { return picbox.Image; }
            set { picbox.Image = value; }
        }
        private void UCcommunity_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddRequest addRequestForm = new AddRequest();
            addRequestForm.ShowDialog();
        }
    }
}
