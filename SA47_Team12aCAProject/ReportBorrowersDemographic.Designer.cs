namespace SA47_Team12aCAProject
{
    partial class ReportBorrowersDemographic
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
            this.crystalReportViewerBD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBD
            // 
            this.crystalReportViewerBD.ActiveViewIndex = -1;
            this.crystalReportViewerBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBD.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerBD.Name = "crystalReportViewerBD";
            this.crystalReportViewerBD.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerBD.TabIndex = 0;
            // 
            // ReportBorrowersDemographic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerBD);
            this.Name = "ReportBorrowersDemographic";
            this.Text = "ReportBorrowersDemographic";
            this.Load += new System.EventHandler(this.ReportBorrowersDemographic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBD;
    }
}