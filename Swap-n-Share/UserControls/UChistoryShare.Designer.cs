namespace Swap_n_Share.UserControls
{
    partial class UChistoryShare
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
            panel1 = new System.Windows.Forms.Panel();
            picPinjam = new Guna.UI2.WinForms.Guna2PictureBox();
            lblPinjam = new System.Windows.Forms.Label();
            lblTanggal = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label = new System.Windows.Forms.Label();
            lblOwner = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPinjam).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(picPinjam);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(147, 135);
            panel1.TabIndex = 0;
            // 
            // picPinjam
            // 
            picPinjam.CustomizableEdges = customizableEdges1;
            picPinjam.ImageRotate = 0F;
            picPinjam.Location = new System.Drawing.Point(29, 24);
            picPinjam.Name = "picPinjam";
            picPinjam.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picPinjam.Size = new System.Drawing.Size(90, 90);
            picPinjam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPinjam.TabIndex = 0;
            picPinjam.TabStop = false;
            // 
            // lblPinjam
            // 
            lblPinjam.AutoSize = true;
            lblPinjam.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            lblPinjam.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPinjam.ForeColor = System.Drawing.Color.White;
            lblPinjam.Location = new System.Drawing.Point(6, 24);
            lblPinjam.Name = "lblPinjam";
            lblPinjam.Size = new System.Drawing.Size(55, 21);
            lblPinjam.TabIndex = 1;
            lblPinjam.Text = "label1";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            lblTanggal.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = System.Drawing.Color.White;
            lblTanggal.Location = new System.Drawing.Point(6, 69);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new System.Drawing.Size(62, 21);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "tanggal";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTanggal);
            panel2.Controls.Add(lblPinjam);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(147, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(228, 135);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label);
            panel3.Controls.Add(lblOwner);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(375, 74);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(756, 61);
            panel3.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            label.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(363, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(70, 21);
            label.TabIndex = 4;
            label.Text = "Owner :";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            lblOwner.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOwner.ForeColor = System.Drawing.Color.White;
            lblOwner.Location = new System.Drawing.Point(508, 0);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new System.Drawing.Size(103, 21);
            lblOwner.TabIndex = 3;
            lblOwner.Text = "Nama Owner";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            lblStatus.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(738, 24);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(57, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // UChistoryShare
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(lblStatus);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(1131, 135);
            Name = "UChistoryShare";
            Size = new System.Drawing.Size(1131, 135);
            Load += UChistory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPinjam).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picPinjam;
        private System.Windows.Forms.Label lblPinjam;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblStatus;
    }
}
