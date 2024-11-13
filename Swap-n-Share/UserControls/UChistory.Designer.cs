namespace Swap_n_Share.UserControls
{
    partial class UChistory
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
            PicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            labelNama = new System.Windows.Forms.Label();
            labelTanggal = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            labelOwner = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PicBox);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(147, 135);
            panel1.TabIndex = 0;
            // 
            // PicBox
            // 
            PicBox.CustomizableEdges = customizableEdges1;
            PicBox.ImageRotate = 0F;
            PicBox.Location = new System.Drawing.Point(29, 24);
            PicBox.Name = "PicBox";
            PicBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PicBox.Size = new System.Drawing.Size(90, 90);
            PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PicBox.TabIndex = 0;
            PicBox.TabStop = false;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            labelNama.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelNama.ForeColor = System.Drawing.Color.White;
            labelNama.Location = new System.Drawing.Point(6, 24);
            labelNama.Name = "labelNama";
            labelNama.Size = new System.Drawing.Size(112, 45);
            labelNama.TabIndex = 1;
            labelNama.Text = "label1";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            labelTanggal.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTanggal.ForeColor = System.Drawing.Color.White;
            labelTanggal.Location = new System.Drawing.Point(6, 69);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new System.Drawing.Size(125, 45);
            labelTanggal.TabIndex = 2;
            labelTanggal.Text = "tanggal";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTanggal);
            panel2.Controls.Add(labelNama);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(147, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(228, 135);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelOwner);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(375, 74);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(756, 61);
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(363, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 45);
            label3.TabIndex = 4;
            label3.Text = "Owner :";
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            labelOwner.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOwner.ForeColor = System.Drawing.Color.White;
            labelOwner.Location = new System.Drawing.Point(508, 0);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new System.Drawing.Size(206, 45);
            labelOwner.TabIndex = 3;
            labelOwner.Text = "Nama Owner";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            labelStatus.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelStatus.ForeColor = System.Drawing.Color.White;
            labelStatus.Location = new System.Drawing.Point(738, 24);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(113, 45);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status";
            // 
            // UChistory
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(labelStatus);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(1131, 135);
            Name = "UChistory";
            Size = new System.Drawing.Size(1131, 135);
            Load += UCactivity_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox PicBox;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelStatus;
    }
}
