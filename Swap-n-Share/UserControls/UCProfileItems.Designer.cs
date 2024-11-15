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
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            label12.Size = new System.Drawing.Size(353, 32);
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
            label13.Size = new System.Drawing.Size(235, 40);
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
            label1.Size = new System.Drawing.Size(467, 86);
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
            panel2.Location = new System.Drawing.Point(3, 20);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(520, 143);
            panel2.TabIndex = 26;
            // 
            // UCProfileItems
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            Controls.Add(panel2);
            Name = "UCProfileItems";
            Size = new System.Drawing.Size(1296, 185);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
