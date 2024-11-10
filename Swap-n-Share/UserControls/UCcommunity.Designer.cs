namespace Swap_n_Share.UserControls
{
    partial class UCcommunity
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelName = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(15, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 70);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelName.ForeColor = System.Drawing.Color.FromArgb(17, 64, 187);
            labelName.Location = new System.Drawing.Point(91, 16);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(84, 28);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelStatus.ForeColor = System.Drawing.Color.FromArgb(17, 64, 187);
            labelStatus.Location = new System.Drawing.Point(91, 44);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(86, 30);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "label2";
            // 
            // UCcommunity
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(labelStatus);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "UCcommunity";
            Size = new System.Drawing.Size(400, 100);
            Load += UCcommunity_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStatus;
    }
}
