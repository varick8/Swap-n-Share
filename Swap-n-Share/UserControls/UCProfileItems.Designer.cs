namespace Swap_n_Share.UserControls
{
    partial class UCProfileItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProfileItems));
            lblDesc = new System.Windows.Forms.Label();
            lblCat = new System.Windows.Forms.Label();
            txtPic = new System.Windows.Forms.PictureBox();
            lblName = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblLoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtPic).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = System.Drawing.Color.Transparent;
            lblDesc.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDesc.ForeColor = System.Drawing.Color.DimGray;
            lblDesc.Location = new System.Drawing.Point(232, 84);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(177, 15);
            lblDesc.TabIndex = 16;
            lblDesc.Text = "Cari mobil sepadan untuk swap";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.BackColor = System.Drawing.Color.Transparent;
            lblCat.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblCat.ForeColor = System.Drawing.Color.White;
            lblCat.Location = new System.Drawing.Point(232, 54);
            lblCat.Name = "lblCat";
            lblCat.Size = new System.Drawing.Size(120, 20);
            lblCat.TabIndex = 15;
            lblCat.Text = "Ready for Swap";
            // 
            // txtPic
            // 
            txtPic.Image = (System.Drawing.Image)resources.GetObject("txtPic.Image");
            txtPic.Location = new System.Drawing.Point(0, 0);
            txtPic.Name = "txtPic";
            txtPic.Size = new System.Drawing.Size(208, 142);
            txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            txtPic.TabIndex = 21;
            txtPic.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = System.Drawing.Color.Transparent;
            lblName.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblName.ForeColor = System.Drawing.Color.White;
            lblName.Location = new System.Drawing.Point(223, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(233, 45);
            lblName.TabIndex = 21;
            lblName.Text = "Toyota Crown";
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Controls.Add(lblLoc);
            panel2.Controls.Add(txtPic);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblCat);
            panel2.Controls.Add(lblDesc);
            panel2.Location = new System.Drawing.Point(3, 20);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(520, 143);
            panel2.TabIndex = 26;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.BackColor = System.Drawing.Color.Transparent;
            lblLoc.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLoc.ForeColor = System.Drawing.Color.White;
            lblLoc.Location = new System.Drawing.Point(232, 111);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new System.Drawing.Size(120, 20);
            lblLoc.TabIndex = 22;
            lblLoc.Text = "Ready for Swap";
            // 
            // UCProfileItems
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(panel2);
            Name = "UCProfileItems";
            Size = new System.Drawing.Size(1296, 185);
            ((System.ComponentModel.ISupportInitialize)txtPic).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.PictureBox txtPic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoc;
    }
}
