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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordTxt = new Guna.UI.WinForms.GunaLabel();
            this.UsernameTxt = new Guna.UI.WinForms.GunaLabel();
            this.PasswordTB = new Guna.UI.WinForms.GunaTextBox();
            this.UsernameTB = new Guna.UI.WinForms.GunaTextBox();
            this.LoginButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.LoginTitleTxt1 = new Guna.UI.WinForms.GunaLabel();
            this.LoginTitleTxt2 = new Guna.UI.WinForms.GunaLabel();
            this.SignUpLinkLabel = new Guna.UI.WinForms.GunaLinkLabel();
            this.ShowPassCB = new Guna.UI.WinForms.GunaCheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 673);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Swap_n_Share.Properties.Resources.SnS_LogoB_HR;
            this.pictureBox1.Location = new System.Drawing.Point(111, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ShowPassCB);
            this.panel2.Controls.Add(this.SignUpLinkLabel);
            this.panel2.Controls.Add(this.LoginTitleTxt2);
            this.panel2.Controls.Add(this.LoginTitleTxt1);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.UsernameTxt);
            this.panel2.Controls.Add(this.PasswordTB);
            this.panel2.Controls.Add(this.UsernameTB);
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(632, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 673);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PasswordTxt
            // 
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
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(91, 261);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(101, 24);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.Text = "Username";
            this.UsernameTxt.Click += new System.EventHandler(this.UsernameTxt_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.AcceptsReturn = true;
            this.PasswordTB.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTB.BaseColor = System.Drawing.Color.White;
            this.PasswordTB.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.PasswordTB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTB.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.PasswordTB.Location = new System.Drawing.Point(95, 394);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.Radius = 20;
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.Size = new System.Drawing.Size(432, 48);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.TextOffsetX = 20;
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // UsernameTB
            // 
            this.UsernameTB.AcceptsReturn = true;
            this.UsernameTB.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTB.BaseColor = System.Drawing.Color.White;
            this.UsernameTB.BorderColor = System.Drawing.Color.Silver;
            this.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTB.FocusedBaseColor = System.Drawing.Color.White;
            this.UsernameTB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.UsernameTB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameTB.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.UsernameTB.Location = new System.Drawing.Point(95, 293);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PasswordChar = '\0';
            this.UsernameTB.Radius = 20;
            this.UsernameTB.SelectedText = "";
            this.UsernameTB.Size = new System.Drawing.Size(432, 48);
            this.UsernameTB.TabIndex = 1;
            this.UsernameTB.TextOffsetX = 20;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.LoginButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.LoginButton.CheckedForeColor = System.Drawing.Color.White;
            this.LoginButton.CheckedImage = null;
            this.LoginButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(187)))));
            this.LoginButton.Location = new System.Drawing.Point(95, 505);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(115)))));
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(115)))));
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(115)))));
            this.LoginButton.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(115)))));
            this.LoginButton.Radius = 20;
            this.LoginButton.Size = new System.Drawing.Size(193, 45);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTitleTxt1
            // 
            this.LoginTitleTxt1.AutoSize = true;
            this.LoginTitleTxt1.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleTxt1.Location = new System.Drawing.Point(84, 106);
            this.LoginTitleTxt1.Name = "LoginTitleTxt1";
            this.LoginTitleTxt1.Size = new System.Drawing.Size(408, 61);
            this.LoginTitleTxt1.TabIndex = 5;
            this.LoginTitleTxt1.Text = "No cash needed,";
            // 
            // LoginTitleTxt2
            // 
            this.LoginTitleTxt2.AutoSize = true;
            this.LoginTitleTxt2.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleTxt2.Location = new System.Drawing.Point(87, 167);
            this.LoginTitleTxt2.Name = "LoginTitleTxt2";
            this.LoginTitleTxt2.Size = new System.Drawing.Size(340, 46);
            this.LoginTitleTxt2.TabIndex = 6;
            this.LoginTitleTxt2.Text = "just fair exchange!";
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(81)))));
            this.SignUpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.SignUpLinkLabel.Location = new System.Drawing.Point(453, 515);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(71, 21);
            this.SignUpLinkLabel.TabIndex = 7;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Sign Up";
            this.SignUpLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowPassCB
            // 
            this.ShowPassCB.BaseColor = System.Drawing.Color.White;
            this.ShowPassCB.CheckedOffColor = System.Drawing.Color.Gray;
            this.ShowPassCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(81)))));
            this.ShowPassCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassCB.FillColor = System.Drawing.Color.White;
            this.ShowPassCB.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowPassCB.Location = new System.Drawing.Point(387, 448);
            this.ShowPassCB.Name = "ShowPassCB";
            this.ShowPassCB.Radius = 3;
            this.ShowPassCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowPassCB.Size = new System.Drawing.Size(140, 20);
            this.ShowPassCB.TabIndex = 8;
            this.ShowPassCB.Text = "Show Password";
            this.ShowPassCB.CheckedChanged += new System.EventHandler(this.ShowPassCB_CheckedChanged);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton LoginButton;
        private Guna.UI.WinForms.GunaTextBox UsernameTB;
        private Guna.UI.WinForms.GunaLabel PasswordTxt;
        private Guna.UI.WinForms.GunaLabel UsernameTxt;
        private Guna.UI.WinForms.GunaTextBox PasswordTB;
        private Guna.UI.WinForms.GunaLabel LoginTitleTxt2;
        private Guna.UI.WinForms.GunaLabel LoginTitleTxt1;
        private Guna.UI.WinForms.GunaLinkLabel SignUpLinkLabel;
        private Guna.UI.WinForms.GunaCheckBox ShowPassCB;
    }
}

