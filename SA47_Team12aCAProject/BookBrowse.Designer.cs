namespace SA47_Team12aCAProject
{
    partial class BookBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBrowse));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBBReset = new System.Windows.Forms.Button();
            this.buttonBBOk = new System.Windows.Forms.Button();
            this.dataGridViewBookBrowse = new System.Windows.Forms.DataGridView();
            this.labelBookBrowseList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBrowse)).BeginInit();
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
            // buttonBBReset
            // 
            this.buttonBBReset.Location = new System.Drawing.Point(689, 495);
            this.buttonBBReset.Name = "buttonBBReset";
            this.buttonBBReset.Size = new System.Drawing.Size(77, 40);
            this.buttonBBReset.TabIndex = 13;
            this.buttonBBReset.Text = "Reset";
            this.buttonBBReset.UseVisualStyleBackColor = true;
            this.buttonBBReset.Click += new System.EventHandler(this.buttonBBReset_Click);
            // 
            // buttonBBOk
            // 
            this.buttonBBOk.Location = new System.Drawing.Point(290, 503);
            this.buttonBBOk.Name = "buttonBBOk";
            this.buttonBBOk.Size = new System.Drawing.Size(78, 32);
            this.buttonBBOk.TabIndex = 12;
            this.buttonBBOk.Text = "Ok";
            this.buttonBBOk.UseVisualStyleBackColor = true;
            this.buttonBBOk.Click += new System.EventHandler(this.buttonBBOk_Click);
            // 
            // dataGridViewBookBrowse
            // 
            this.dataGridViewBookBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookBrowse.Location = new System.Drawing.Point(158, 158);
            this.dataGridViewBookBrowse.Name = "dataGridViewBookBrowse";
            this.dataGridViewBookBrowse.RowTemplate.Height = 24;
            this.dataGridViewBookBrowse.Size = new System.Drawing.Size(795, 316);
            this.dataGridViewBookBrowse.TabIndex = 11;
            // 
            // labelBookBrowseList
            // 
            this.labelBookBrowseList.AutoSize = true;
            this.labelBookBrowseList.BackColor = System.Drawing.Color.Transparent;
            this.labelBookBrowseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookBrowseList.Location = new System.Drawing.Point(479, 97);
            this.labelBookBrowseList.Name = "labelBookBrowseList";
            this.labelBookBrowseList.Size = new System.Drawing.Size(89, 20);
            this.labelBookBrowseList.TabIndex = 10;
            this.labelBookBrowseList.Text = "Books List";
            // 
            // BookBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.buttonBBReset);
            this.Controls.Add(this.buttonBBOk);
            this.Controls.Add(this.dataGridViewBookBrowse);
            this.Controls.Add(this.labelBookBrowseList);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookBrowse";
            this.Text = "SA47_Team12aCAProject Management System";
            this.Load += new System.EventHandler(this.BookBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBBReset;
        private System.Windows.Forms.Button buttonBBOk;
        private System.Windows.Forms.DataGridView dataGridViewBookBrowse;
        private System.Windows.Forms.Label labelBookBrowseList;
    }
}