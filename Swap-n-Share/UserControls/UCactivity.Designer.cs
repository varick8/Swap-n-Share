namespace Swap_n_Share.UserControls
{
    partial class UCactivity
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
            PicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            labelUser = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelKomen = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            labelTanggal = new System.Windows.Forms.Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            labelNama = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PicBox);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(294, 270);
            panel1.TabIndex = 0;
            // 
            // PicBox
            // 
            PicBox.CustomizableEdges = customizableEdges1;
            PicBox.ImageRotate = 0F;
            PicBox.Location = new System.Drawing.Point(34, 21);
            PicBox.Name = "PicBox";
            PicBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PicBox.Size = new System.Drawing.Size(230, 230);
            PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelUser);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelKomen);
            panel2.Controls.Add(label);
            panel2.Controls.Add(labelTanggal);
            panel2.Controls.Add(guna2Button2);
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(labelNama);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(306, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(825, 270);
            panel2.TabIndex = 1;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUser.ForeColor = System.Drawing.Color.White;
            labelUser.Location = new System.Drawing.Point(-6, 144);
            labelUser.Name = "labelUser";
            labelUser.Size = new System.Drawing.Size(167, 45);
            labelUser.TabIndex = 2;
            labelUser.Text = "Nama Req";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(-6, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 45);
            label1.TabIndex = 2;
            label1.Text = "Requester:";
            // 
            // labelKomen
            // 
            labelKomen.AutoSize = true;
            labelKomen.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelKomen.ForeColor = System.Drawing.Color.White;
            labelKomen.Location = new System.Drawing.Point(-5, 227);
            labelKomen.Name = "labelKomen";
            labelKomen.Size = new System.Drawing.Size(153, 45);
            labelKomen.TabIndex = 3;
            labelKomen.Text = "komentar";
            labelKomen.Click += labelKomen_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(-5, 193);
            label.Name = "label";
            label.Size = new System.Drawing.Size(178, 45);
            label.TabIndex = 2;
            label.Text = "Komentar:";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTanggal.ForeColor = System.Drawing.Color.White;
            labelTanggal.Location = new System.Drawing.Point(-5, 67);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new System.Drawing.Size(132, 45);
            labelTanggal.TabIndex = 1;
            labelTanggal.Text = "Tanggal";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = System.Drawing.Color.White;
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = System.Drawing.Color.Lime;
            guna2Button2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = System.Drawing.Color.Black;
            guna2Button2.Location = new System.Drawing.Point(427, 44);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new System.Drawing.Size(167, 47);
            guna2Button2.TabIndex = 4;
            guna2Button2.Text = "Accept";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = System.Drawing.Color.White;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = System.Drawing.Color.Red;
            guna2Button1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = System.Drawing.Color.White;
            guna2Button1.Location = new System.Drawing.Point(600, 44);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new System.Drawing.Size(167, 47);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Reject";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelNama.ForeColor = System.Drawing.Color.White;
            labelNama.Location = new System.Drawing.Point(-6, 35);
            labelNama.Name = "labelNama";
            labelNama.Size = new System.Drawing.Size(227, 45);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama Barang";
            // 
            // UCactivity
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(1131, 270);
            Name = "UCactivity";
            Size = new System.Drawing.Size(1131, 270);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox PicBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelKomen;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
