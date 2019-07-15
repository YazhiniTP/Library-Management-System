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
    public partial class ReportTransactionHistory : Form
    {
        public ReportTransactionHistory()
        {
            InitializeComponent();
        }

        private void ReportTransactionHistory_Load(object sender, EventArgs e)
        {
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();

            //SA47_Team12bDataSetTableAdapters.BooksTableAdapter booksTableAdapter = new SA47_Team12bDataSetTableAdapters.BooksTableAdapter();
            //booksTableAdapter.Fill(ds.Books);

            //SA47_Team12bDataSetTableAdapters.IssueTransTableAdapter issueTransTableAdapter = new SA47_Team12bDataSetTableAdapters.IssueTransTableAdapter();
            //issueTransTableAdapter.Fill(ds.IssueTrans);

            SA47_Team12bDataSetTableAdapters.TransactionHistoryTableAdapter transactionHistoryTableAdapter = new SA47_Team12bDataSetTableAdapters.TransactionHistoryTableAdapter();
            transactionHistoryTableAdapter.Fill(ds.TransactionHistory);

            CRTransactionHistory crTransactionHistory = new CRTransactionHistory();
            crTransactionHistory.SetDataSource(ds);
            crystalReportViewerTH.ReportSource = crTransactionHistory;
        }
    }
}
