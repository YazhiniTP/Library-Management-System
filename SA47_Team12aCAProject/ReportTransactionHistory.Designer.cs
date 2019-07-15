namespace SA47_Team12aCAProject
{
    partial class ReportTransactionHistory
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
            this.crystalReportViewerTH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTH
            // 
            this.crystalReportViewerTH.ActiveViewIndex = -1;
            this.crystalReportViewerTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTH.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTH.Name = "crystalReportViewerTH";
            this.crystalReportViewerTH.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerTH.TabIndex = 0;
            // 
            // ReportTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerTH);
            this.Name = "ReportTransactionHistory";
            this.Text = "ReportTransactionHistory";
            this.Load += new System.EventHandler(this.ReportTransactionHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTH;
    }
}