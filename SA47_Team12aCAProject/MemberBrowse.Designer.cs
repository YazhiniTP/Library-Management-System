namespace SA47_Team12aCAProject
{
    partial class MemberBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberBrowse));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMBOk = new System.Windows.Forms.Button();
            this.buttonMBReset = new System.Windows.Forms.Button();
            this.dataGridViewMemBrowse = new System.Windows.Forms.DataGridView();
            this.labelMemBrowseList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(844, 18);
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
            // buttonMBOk
            // 
            this.buttonMBOk.Location = new System.Drawing.Point(322, 502);
            this.buttonMBOk.Name = "buttonMBOk";
            this.buttonMBOk.Size = new System.Drawing.Size(78, 38);
            this.buttonMBOk.TabIndex = 13;
            this.buttonMBOk.Text = "Ok";
            this.buttonMBOk.UseVisualStyleBackColor = true;
            this.buttonMBOk.Click += new System.EventHandler(this.buttonMBOk_Click);
            // 
            // buttonMBReset
            // 
            this.buttonMBReset.Location = new System.Drawing.Point(686, 502);
            this.buttonMBReset.Name = "buttonMBReset";
            this.buttonMBReset.Size = new System.Drawing.Size(78, 38);
            this.buttonMBReset.TabIndex = 12;
            this.buttonMBReset.Text = "Reset";
            this.buttonMBReset.UseVisualStyleBackColor = true;
            this.buttonMBReset.Click += new System.EventHandler(this.buttonMBReset_Click);
            // 
            // dataGridViewMemBrowse
            // 
            this.dataGridViewMemBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemBrowse.Location = new System.Drawing.Point(158, 148);
            this.dataGridViewMemBrowse.Name = "dataGridViewMemBrowse";
            this.dataGridViewMemBrowse.RowTemplate.Height = 24;
            this.dataGridViewMemBrowse.Size = new System.Drawing.Size(782, 324);
            this.dataGridViewMemBrowse.TabIndex = 11;
            // 
            // labelMemBrowseList
            // 
            this.labelMemBrowseList.AutoSize = true;
            this.labelMemBrowseList.BackColor = System.Drawing.Color.Transparent;
            this.labelMemBrowseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemBrowseList.Location = new System.Drawing.Point(464, 101);
            this.labelMemBrowseList.Name = "labelMemBrowseList";
            this.labelMemBrowseList.Size = new System.Drawing.Size(112, 20);
            this.labelMemBrowseList.TabIndex = 10;
            this.labelMemBrowseList.Text = "Members List";
            // 
            // MemberBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.buttonMBOk);
            this.Controls.Add(this.buttonMBReset);
            this.Controls.Add(this.dataGridViewMemBrowse);
            this.Controls.Add(this.labelMemBrowseList);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberBrowse";
            this.Text = "SA47_Team12aCAProject Management System";
            this.Load += new System.EventHandler(this.MemberBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonMBOk;
        private System.Windows.Forms.Button buttonMBReset;
        private System.Windows.Forms.DataGridView dataGridViewMemBrowse;
        private System.Windows.Forms.Label labelMemBrowseList;
    }
}