namespace SA47_Team12aCAProject
{
    partial class LibraryLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryLogin));
            this.buttonGuestLogin = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.groupBoxEmployeeLogin = new System.Windows.Forms.GroupBox();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxEmployeeLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuestLogin
            // 
            this.buttonGuestLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuestLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuestLogin.Location = new System.Drawing.Point(230, 248);
            this.buttonGuestLogin.Name = "buttonGuestLogin";
            this.buttonGuestLogin.Size = new System.Drawing.Size(211, 63);
            this.buttonGuestLogin.TabIndex = 3;
            this.buttonGuestLogin.Text = "Guest ? Click here !";
            this.toolTipLogin.SetToolTip(this.buttonGuestLogin, "Public user click here to browse about the books details");
            this.buttonGuestLogin.UseVisualStyleBackColor = false;
            this.buttonGuestLogin.Click += new System.EventHandler(this.buttonGuestLogin_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(932, 26);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(96, 23);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome !";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelTitle.Location = new System.Drawing.Point(204, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(526, 50);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Lets get lost in the world of books !";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(160, 162);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(102, 36);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Login";
            this.toolTipLogin.SetToolTip(this.buttonLogin, "Employee\'s click Login after typing respective username and password");
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(184, 104);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(180, 27);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(184, 37);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(180, 27);
            this.textBoxUsername.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(54, 106);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(51, 39);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 20);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username";
            // 
            // groupBoxEmployeeLogin
            // 
            this.groupBoxEmployeeLogin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEmployeeLogin.Controls.Add(this.buttonLogin);
            this.groupBoxEmployeeLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxEmployeeLogin.Controls.Add(this.textBoxUsername);
            this.groupBoxEmployeeLogin.Controls.Add(this.labelPassword);
            this.groupBoxEmployeeLogin.Controls.Add(this.labelUsername);
            this.groupBoxEmployeeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployeeLogin.Location = new System.Drawing.Point(582, 185);
            this.groupBoxEmployeeLogin.Name = "groupBoxEmployeeLogin";
            this.groupBoxEmployeeLogin.Size = new System.Drawing.Size(404, 215);
            this.groupBoxEmployeeLogin.TabIndex = 11;
            this.groupBoxEmployeeLogin.TabStop = false;
            this.groupBoxEmployeeLogin.Text = "Employee Login";
            // 
            // toolTipLogin
            // 
            this.toolTipLogin.ShowAlways = true;
            // 
            // LibraryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 586);
            this.Controls.Add(this.groupBoxEmployeeLogin);
            this.Controls.Add(this.buttonGuestLogin);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTitle);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryLogin";
            this.Text = "SA47_Team12aCAProject Management System";
            this.groupBoxEmployeeLogin.ResumeLayout(false);
            this.groupBoxEmployeeLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuestLogin;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.GroupBox groupBoxEmployeeLogin;
        private System.Windows.Forms.ToolTip toolTipLogin;
    }
}