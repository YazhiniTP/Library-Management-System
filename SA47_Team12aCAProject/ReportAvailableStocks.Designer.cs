namespace SA47_Team12aCAProject
{
    partial class ReportAvailableStocks
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
            this.crystalReportViewerAS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerAS
            // 
            this.crystalReportViewerAS.ActiveViewIndex = -1;
            this.crystalReportViewerAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerAS.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerAS.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerAS.Name = "crystalReportViewerAS";
            this.crystalReportViewerAS.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerAS.TabIndex = 0;
            // 
            // ReportAvailableStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerAS);
            this.Name = "ReportAvailableStocks";
            this.Text = "ReportAvailableStocks";
            this.Load += new System.EventHandler(this.ReportAvailableStocks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerAS;
    }
}