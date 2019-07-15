using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA47_Team12aCAProject
{
    public partial class ReportBorrowersDemographic : Form
    {
        public ReportBorrowersDemographic()
        {
            InitializeComponent();
        }

        private void ReportBorrowersDemographic_Load(object sender, EventArgs e)
        {
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();

            SA47_Team12bDataSetTableAdapters.MembersTableAdapter membersTableAdapter = new SA47_Team12bDataSetTableAdapters.MembersTableAdapter();
            membersTableAdapter.Fill(ds.Members);

            CRBorrowerDemographic crBorrowerDemographic = new CRBorrowerDemographic();
            crBorrowerDemographic.SetDataSource(ds);
            crystalReportViewerBD.ReportSource = crBorrowerDemographic;
        }

    }
}
