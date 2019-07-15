namespace SA47_Team12aCAProject
{
    partial class LibraryLogout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryLogout));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.pictureBoxThankyou = new System.Windows.Forms.PictureBox();
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThankyou)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(958, 33);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(96, 23);
            this.labelWelcome.TabIndex = 14;
            this.labelWelcome.Text = "Welcome !";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelTitle.Location = new System.Drawing.Point(196, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(526, 50);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Lets get lost in the world of books !";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogin.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.Location = new System.Drawing.Point(1018, 555);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(68, 24);
            this.linkLabelLogin.TabIndex = 15;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login !";
            this.toolTipLogout.SetToolTip(this.linkLabelLogin, "Click here to Login again");
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // pictureBoxThankyou
            // 
            this.pictureBoxThankyou.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThankyou.Image")));
            this.pictureBoxThankyou.Location = new System.Drawing.Point(290, 132);
            this.pictureBoxThankyou.Name = "pictureBoxThankyou";
            this.pictureBoxThankyou.Size = new System.Drawing.Size(650, 346);
            this.pictureBoxThankyou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThankyou.TabIndex = 16;
            this.pictureBoxThankyou.TabStop = false;
            // 
            // toolTipLogout
            // 
            this.toolTipLogout.ShowAlways = true;
            // 
            // LibraryLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 586);
            this.Controls.Add(this.pictureBoxThankyou);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryLogout";
            this.Text = "SA47_Team12aCAProject Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThankyou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.PictureBox pictureBoxThankyou;
        private System.Windows.Forms.ToolTip toolTipLogout;
    }
}