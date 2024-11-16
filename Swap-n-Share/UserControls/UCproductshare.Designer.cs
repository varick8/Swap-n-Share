namespace Swap_n_Share.UserControls
{
    partial class UCproductshare
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCproductshare));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblName = new System.Windows.Forms.Label();
            lblLoc = new System.Windows.Forms.Label();
            btnShare = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            txtPic = new Guna.UI2.WinForms.Guna2PictureBox();
            labelDeskripsi = new System.Windows.Forms.Label();
            lblCat = new System.Windows.Forms.Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPic).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblName.ForeColor = System.Drawing.Color.White;
            lblName.Location = new System.Drawing.Point(305, 43);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(112, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Baju Jasmine";
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLoc.ForeColor = System.Drawing.Color.White;
            lblLoc.Location = new System.Drawing.Point(305, 81);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new System.Drawing.Size(61, 17);
            lblLoc.TabIndex = 2;
            lblLoc.Text = "Location";
            // 
            // btnShare
            // 
            btnShare.BorderRadius = 10;
            btnShare.CustomizableEdges = customizableEdges1;
            btnShare.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnShare.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnShare.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btnShare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btnShare.FillColor = System.Drawing.Color.FromArgb(93, 93, 166);
            btnShare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShare.ForeColor = System.Drawing.Color.White;
            btnShare.Location = new System.Drawing.Point(347, 217);
            btnShare.Name = "btnShare";
            btnShare.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnShare.Size = new System.Drawing.Size(195, 54);
            btnShare.TabIndex = 3;
            btnShare.Text = "Share";
            btnShare.Click += btnShare_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(txtPic);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            guna2Panel1.Location = new System.Drawing.Point(0, 0);
            guna2Panel1.MaximumSize = new System.Drawing.Size(287, 290);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new System.Drawing.Size(287, 290);
            guna2Panel1.TabIndex = 4;
            // 
            // txtPic
            // 
            txtPic.CustomizableEdges = customizableEdges3;
            txtPic.Image = (System.Drawing.Image)resources.GetObject("txtPic.Image");
            txtPic.ImageRotate = 0F;
            txtPic.Location = new System.Drawing.Point(21, 25);
            txtPic.Name = "txtPic";
            txtPic.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPic.Size = new System.Drawing.Size(233, 246);
            txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            txtPic.TabIndex = 0;
            txtPic.TabStop = false;
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDeskripsi.ForeColor = System.Drawing.Color.White;
            labelDeskripsi.Location = new System.Drawing.Point(305, 111);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new System.Drawing.Size(73, 17);
            labelDeskripsi.TabIndex = 5;
            labelDeskripsi.Text = "Tahun 2023";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCat.ForeColor = System.Drawing.Color.White;
            lblCat.Location = new System.Drawing.Point(305, 141);
            lblCat.Name = "lblCat";
            lblCat.Size = new System.Drawing.Size(64, 17);
            lblCat.TabIndex = 6;
            lblCat.Text = "Category";
            // 
            // UCproductshare
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(lblCat);
            Controls.Add(labelDeskripsi);
            Controls.Add(btnShare);
            Controls.Add(lblLoc);
            Controls.Add(lblName);
            Controls.Add(guna2Panel1);
            MaximumSize = new System.Drawing.Size(564, 292);
            Name = "UCproductshare";
            Size = new System.Drawing.Size(564, 292);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLoc;
        private Guna.UI2.WinForms.Guna2Button btnShare;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox txtPic;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Label lblCat;
    }
}
