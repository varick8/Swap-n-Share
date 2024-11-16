namespace Swap_n_Share.UserControls
{
    partial class UCactivityShare
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new System.Windows.Forms.Panel();
            picPinjam = new Guna.UI2.WinForms.Guna2PictureBox();
            btnReject = new Guna.UI2.WinForms.Guna2Button();
            btnAccept = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new System.Windows.Forms.Panel();
            lblTelpon = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblReq = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblKomen = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            lblTanggal = new System.Windows.Forms.Label();
            lblPinjam = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPinjam).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            panel1.Controls.Add(picPinjam);
            panel1.Controls.Add(btnReject);
            panel1.Controls.Add(btnAccept);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(175, 270);
            panel1.TabIndex = 1;
            // 
            // picPinjam
            // 
            picPinjam.CustomizableEdges = customizableEdges1;
            picPinjam.ImageRotate = 0F;
            picPinjam.Location = new System.Drawing.Point(34, 21);
            picPinjam.Name = "picPinjam";
            picPinjam.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picPinjam.Size = new System.Drawing.Size(120, 120);
            picPinjam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPinjam.TabIndex = 0;
            picPinjam.TabStop = false;
            // 
            // btnReject
            // 
            btnReject.BorderColor = System.Drawing.Color.White;
            btnReject.BorderRadius = 10;
            btnReject.CustomizableEdges = customizableEdges3;
            btnReject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnReject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnReject.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btnReject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btnReject.FillColor = System.Drawing.Color.Red;
            btnReject.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnReject.ForeColor = System.Drawing.Color.White;
            btnReject.Location = new System.Drawing.Point(34, 199);
            btnReject.Name = "btnReject";
            btnReject.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnReject.Size = new System.Drawing.Size(120, 39);
            btnReject.TabIndex = 3;
            btnReject.Text = "Reject";
            btnReject.Click += btnReject_Click;
            // 
            // btnAccept
            // 
            btnAccept.BorderColor = System.Drawing.Color.White;
            btnAccept.BorderRadius = 10;
            btnAccept.CustomizableEdges = customizableEdges5;
            btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            btnAccept.FillColor = System.Drawing.Color.Lime;
            btnAccept.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAccept.ForeColor = System.Drawing.Color.Black;
            btnAccept.Location = new System.Drawing.Point(34, 150);
            btnAccept.Name = "btnAccept";
            btnAccept.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAccept.Size = new System.Drawing.Size(120, 39);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.Click += btnAccept_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            panel2.Controls.Add(lblTelpon);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblReq);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblKomen);
            panel2.Controls.Add(label);
            panel2.Controls.Add(lblTanggal);
            panel2.Controls.Add(lblPinjam);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(181, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(379, 270);
            panel2.TabIndex = 2;
            // 
            // lblTelpon
            // 
            lblTelpon.AutoSize = true;
            lblTelpon.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTelpon.ForeColor = System.Drawing.Color.White;
            lblTelpon.Location = new System.Drawing.Point(1, 205);
            lblTelpon.Name = "lblTelpon";
            lblTelpon.Size = new System.Drawing.Size(108, 21);
            lblTelpon.TabIndex = 5;
            lblTelpon.Text = "08765544332";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(0, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 21);
            label3.TabIndex = 4;
            label3.Text = "Phone Number:";
            // 
            // lblReq
            // 
            lblReq.AutoSize = true;
            lblReq.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblReq.ForeColor = System.Drawing.Color.White;
            lblReq.Location = new System.Drawing.Point(0, 124);
            lblReq.Name = "lblReq";
            lblReq.Size = new System.Drawing.Size(83, 21);
            lblReq.TabIndex = 2;
            lblReq.Text = "Nama Req";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 21);
            label1.TabIndex = 2;
            label1.Text = "Requester:";
            // 
            // lblKomen
            // 
            lblKomen.AutoSize = true;
            lblKomen.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblKomen.ForeColor = System.Drawing.Color.White;
            lblKomen.Location = new System.Drawing.Point(237, 47);
            lblKomen.Name = "lblKomen";
            lblKomen.Size = new System.Drawing.Size(77, 21);
            lblKomen.TabIndex = 3;
            lblKomen.Text = "komentar";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(233, 15);
            label.Name = "label";
            label.Size = new System.Drawing.Size(89, 21);
            label.TabIndex = 2;
            label.Text = "Comment:";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = System.Drawing.Color.White;
            lblTanggal.Location = new System.Drawing.Point(1, 47);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new System.Drawing.Size(65, 21);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "Tanggal";
            // 
            // lblPinjam
            // 
            lblPinjam.AutoSize = true;
            lblPinjam.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPinjam.ForeColor = System.Drawing.Color.White;
            lblPinjam.Location = new System.Drawing.Point(0, 15);
            lblPinjam.Name = "lblPinjam";
            lblPinjam.Size = new System.Drawing.Size(116, 21);
            lblPinjam.TabIndex = 0;
            lblPinjam.Text = "Nama Barang";
            // 
            // UCactivityShare
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(560, 270);
            Name = "UCactivityShare";
            Size = new System.Drawing.Size(560, 270);
            Load += UCactivityShare_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPinjam).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picPinjam;
        private Guna.UI2.WinForms.Guna2Button btnReject;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTelpon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKomen;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblPinjam;
    }
}
