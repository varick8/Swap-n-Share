﻿namespace Swap_n_Share.UserControls
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.DimGray;
            label12.Location = new System.Drawing.Point(232, 122);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(226, 20);
            label12.TabIndex = 16;
            label12.Text = "Cari mobil sepadan untuk swap";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(232, 54);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(147, 25);
            label13.TabIndex = 15;
            label13.Text = "Ready for Swap";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(208, 142);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(223, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(291, 54);
            label1.TabIndex = 21;
            label1.Text = "Toyota Crown";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Location = new System.Drawing.Point(88, 9);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(520, 143);
            panel2.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(guna2Button2);
            panel1.Location = new System.Drawing.Point(969, 106);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(244, 45);
            panel1.TabIndex = 27;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            guna2Button2.BackColor = System.Drawing.Color.Transparent;
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = System.Drawing.Color.FromArgb(93, 93, 166);
            guna2Button2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = System.Drawing.Color.White;
            guna2Button2.Location = new System.Drawing.Point(0, 0);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new System.Drawing.Size(244, 45);
            guna2Button2.TabIndex = 21;
            guna2Button2.Text = "Swap";
            // 
            // UCProfileItems
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UCProfileItems";
            Size = new System.Drawing.Size(1296, 185);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}