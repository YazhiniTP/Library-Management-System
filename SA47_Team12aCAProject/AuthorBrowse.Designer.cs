namespace SA47_Team12aCAProject
{
    partial class AuthorBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorBrowse));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewAutBrowse = new System.Windows.Forms.DataGridView();
            this.labelABAutList = new System.Windows.Forms.Label();
            this.buttonABCancel = new System.Windows.Forms.Button();
            this.buttonABOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutBrowse)).BeginInit();
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
            // dataGridViewAutBrowse
            // 
            this.dataGridViewAutBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutBrowse.Location = new System.Drawing.Point(150, 128);
            this.dataGridViewAutBrowse.Name = "dataGridViewAutBrowse";
            this.dataGridViewAutBrowse.RowTemplate.Height = 24;
            this.dataGridViewAutBrowse.Size = new System.Drawing.Size(790, 329);
            this.dataGridViewAutBrowse.TabIndex = 13;
            // 
            // labelABAutList
            // 
            this.labelABAutList.AutoSize = true;
            this.labelABAutList.BackColor = System.Drawing.Color.Transparent;
            this.labelABAutList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABAutList.Location = new System.Drawing.Point(459, 89);
            this.labelABAutList.Name = "labelABAutList";
            this.labelABAutList.Size = new System.Drawing.Size(100, 20);
            this.labelABAutList.TabIndex = 12;
            this.labelABAutList.Text = "Authors List";
            // 
            // buttonABCancel
            // 
            this.buttonABCancel.Location = new System.Drawing.Point(670, 483);
            this.buttonABCancel.Name = "buttonABCancel";
            this.buttonABCancel.Size = new System.Drawing.Size(86, 35);
            this.buttonABCancel.TabIndex = 11;
            this.buttonABCancel.Text = "Cancel";
            this.buttonABCancel.UseVisualStyleBackColor = true;
            this.buttonABCancel.Click += new System.EventHandler(this.buttonABCancel_Click);
            // 
            // buttonABOk
            // 
            this.buttonABOk.Location = new System.Drawing.Point(292, 483);
            this.buttonABOk.Name = "buttonABOk";
            this.buttonABOk.Size = new System.Drawing.Size(78, 35);
            this.buttonABOk.TabIndex = 10;
            this.buttonABOk.Text = "Ok";
            this.buttonABOk.UseVisualStyleBackColor = true;
            this.buttonABOk.Click += new System.EventHandler(this.buttonABOk_Click);
            // 
            // AuthorBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.dataGridViewAutBrowse);
            this.Controls.Add(this.labelABAutList);
            this.Controls.Add(this.buttonABCancel);
            this.Controls.Add(this.buttonABOk);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorBrowse";
            this.Text = "SA47_Team12aCAProject Management System";
            this.Load += new System.EventHandler(this.AuthorBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewAutBrowse;
        private System.Windows.Forms.Label labelABAutList;
        private System.Windows.Forms.Button buttonABCancel;
        private System.Windows.Forms.Button buttonABOk;
    }
}