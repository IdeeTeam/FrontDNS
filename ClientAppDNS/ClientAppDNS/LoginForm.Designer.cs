namespace ClientAppDNS
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
            this.bLogin = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbCreatePassword = new System.Windows.Forms.TextBox();
            this.tbCreateEmail = new System.Windows.Forms.TextBox();
            this.tbCreateUsername = new System.Windows.Forms.TextBox();
            this.lCreatePassword = new System.Windows.Forms.Label();
            this.lCeateEmail = new System.Windows.Forms.Label();
            this.lCreateUsername = new System.Windows.Forms.Label();
            this.bRegister = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(101, 161);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(99, 31);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "Log in";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(33, 35);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(58, 13);
            this.lUser.TabIndex = 1;
            this.lUser.Text = "Username:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 238);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.tbUsername);
            this.tabPage1.Controls.Add(this.lPassword);
            this.tabPage1.Controls.Add(this.lUser);
            this.tabPage1.Controls.Add(this.bLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log in";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(101, 89);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(223, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(101, 32);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(223, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(33, 97);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(56, 13);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Password:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbCreatePassword);
            this.tabPage2.Controls.Add(this.tbCreateEmail);
            this.tabPage2.Controls.Add(this.tbCreateUsername);
            this.tabPage2.Controls.Add(this.lCreatePassword);
            this.tabPage2.Controls.Add(this.lCeateEmail);
            this.tabPage2.Controls.Add(this.lCreateUsername);
            this.tabPage2.Controls.Add(this.bRegister);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbCreatePassword
            // 
            this.tbCreatePassword.Location = new System.Drawing.Point(121, 112);
            this.tbCreatePassword.Name = "tbCreatePassword";
            this.tbCreatePassword.Size = new System.Drawing.Size(100, 20);
            this.tbCreatePassword.TabIndex = 6;
            // 
            // tbCreateEmail
            // 
            this.tbCreateEmail.Location = new System.Drawing.Point(121, 67);
            this.tbCreateEmail.Name = "tbCreateEmail";
            this.tbCreateEmail.Size = new System.Drawing.Size(100, 20);
            this.tbCreateEmail.TabIndex = 5;
            // 
            // tbCreateUsername
            // 
            this.tbCreateUsername.Location = new System.Drawing.Point(121, 23);
            this.tbCreateUsername.Name = "tbCreateUsername";
            this.tbCreateUsername.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUsername.TabIndex = 4;
            // 
            // lCreatePassword
            // 
            this.lCreatePassword.AutoSize = true;
            this.lCreatePassword.Location = new System.Drawing.Point(29, 115);
            this.lCreatePassword.Name = "lCreatePassword";
            this.lCreatePassword.Size = new System.Drawing.Size(56, 13);
            this.lCreatePassword.TabIndex = 3;
            this.lCreatePassword.Text = "Password:";
            // 
            // lCeateEmail
            // 
            this.lCeateEmail.AutoSize = true;
            this.lCeateEmail.Location = new System.Drawing.Point(29, 70);
            this.lCeateEmail.Name = "lCeateEmail";
            this.lCeateEmail.Size = new System.Drawing.Size(35, 13);
            this.lCeateEmail.TabIndex = 2;
            this.lCeateEmail.Text = "Email:";
            // 
            // lCreateUsername
            // 
            this.lCreateUsername.AutoSize = true;
            this.lCreateUsername.Location = new System.Drawing.Point(26, 23);
            this.lCreateUsername.Name = "lCreateUsername";
            this.lCreateUsername.Size = new System.Drawing.Size(58, 13);
            this.lCreateUsername.TabIndex = 1;
            this.lCreateUsername.Text = "Username:";
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(121, 169);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(75, 23);
            this.bRegister.TabIndex = 0;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbCreatePassword;
        private System.Windows.Forms.TextBox tbCreateEmail;
        private System.Windows.Forms.TextBox tbCreateUsername;
        private System.Windows.Forms.Label lCreatePassword;
        private System.Windows.Forms.Label lCeateEmail;
        private System.Windows.Forms.Label lCreateUsername;
        private System.Windows.Forms.Button bRegister;
    }
}

