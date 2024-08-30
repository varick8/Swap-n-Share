namespace Swap_n_Share
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordTxt = new Guna.UI.WinForms.GunaLabel();
            this.UsernameTxt = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowPassCB = new System.Windows.Forms.CheckBox();
            this.UsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginTitleTxt1 = new System.Windows.Forms.Label();
            this.LoginTitleTxt2 = new System.Windows.Forms.Label();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.SignUpLinkLabel);
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Controls.Add(this.LoginTitleTxt2);
            this.panel2.Controls.Add(this.LoginTitleTxt1);
            this.panel2.Controls.Add(this.PasswordTB);
            this.panel2.Controls.Add(this.UsernameTB);
            this.panel2.Controls.Add(this.ShowPassCB);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.UsernameTxt);
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 673);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.AutoSize = true;
            this.PasswordTxt.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(91, 362);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(96, 24);
            this.PasswordTxt.TabIndex = 4;
            this.PasswordTxt.Text = "Password";
            this.PasswordTxt.Click += new System.EventHandler(this.PasswordTxt_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(91, 261);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(101, 24);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.Text = "Username";
            this.UsernameTxt.Click += new System.EventHandler(this.UsernameTxt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Swap_n_Share.Properties.Resources.SnS_LogoB_HR;
            this.pictureBox1.Location = new System.Drawing.Point(85, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 728);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 673);
            this.panel1.TabIndex = 0;
            // 
            // ShowPassCB
            // 
            this.ShowPassCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShowPassCB.AutoSize = true;
            this.ShowPassCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPassCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassCB.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowPassCB.Location = new System.Drawing.Point(424, 451);
            this.ShowPassCB.Name = "ShowPassCB";
            this.ShowPassCB.Size = new System.Drawing.Size(135, 22);
            this.ShowPassCB.TabIndex = 9;
            this.ShowPassCB.Text = "Show Password";
            this.ShowPassCB.UseVisualStyleBackColor = true;
            this.ShowPassCB.CheckedChanged += new System.EventHandler(this.ShowPassCB_CheckedChanged_1);
            // 
            // UsernameTB
            // 
            this.UsernameTB.AcceptsReturn = true;
            this.UsernameTB.BorderColor = System.Drawing.Color.Silver;
            this.UsernameTB.BorderRadius = 20;
            this.UsernameTB.BorderThickness = 2;
            this.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTB.DefaultText = "";
            this.UsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.Location = new System.Drawing.Point(95, 294);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PasswordChar = '\0';
            this.UsernameTB.PlaceholderText = "";
            this.UsernameTB.SelectedText = "";
            this.UsernameTB.Size = new System.Drawing.Size(464, 48);
            this.UsernameTB.TabIndex = 10;
            this.UsernameTB.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // PasswordTB
            // 
            this.PasswordTB.AcceptsReturn = true;
            this.PasswordTB.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTB.BorderRadius = 20;
            this.PasswordTB.BorderThickness = 2;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.DefaultText = "";
            this.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.Location = new System.Drawing.Point(95, 395);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.PlaceholderText = "";
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.Size = new System.Drawing.Size(464, 48);
            this.PasswordTB.TabIndex = 11;
            this.PasswordTB.TextOffset = new System.Drawing.Point(20, 0);
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged_1);
            // 
            // LoginTitleTxt1
            // 
            this.LoginTitleTxt1.AutoSize = true;
            this.LoginTitleTxt1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleTxt1.Location = new System.Drawing.Point(81, 99);
            this.LoginTitleTxt1.Name = "LoginTitleTxt1";
            this.LoginTitleTxt1.Size = new System.Drawing.Size(556, 83);
            this.LoginTitleTxt1.TabIndex = 12;
            this.LoginTitleTxt1.Text = "No cash needed,";
            // 
            // LoginTitleTxt2
            // 
            this.LoginTitleTxt2.AutoSize = true;
            this.LoginTitleTxt2.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleTxt2.Location = new System.Drawing.Point(84, 162);
            this.LoginTitleTxt2.Name = "LoginTitleTxt2";
            this.LoginTitleTxt2.Size = new System.Drawing.Size(450, 61);
            this.LoginTitleTxt2.TabIndex = 13;
            this.LoginTitleTxt2.Text = "just fair exchange!";
            // 
            // LoginButton
            // 
            this.LoginButton.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 20;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.LoginButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(115)))));
            this.LoginButton.Location = new System.Drawing.Point(345, 515);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(214, 45);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Login";
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLinkLabel.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.SignUpLinkLabel.Location = new System.Drawing.Point(490, 566);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(69, 21);
            this.SignUpLinkLabel.TabIndex = 15;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Sign Up";
            this.SignUpLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Swap & Share";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel PasswordTxt;
        private Guna.UI.WinForms.GunaLabel UsernameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ShowPassCB;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTB;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB;
        private System.Windows.Forms.Label LoginTitleTxt1;
        private System.Windows.Forms.Label LoginTitleTxt2;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
    }
}

