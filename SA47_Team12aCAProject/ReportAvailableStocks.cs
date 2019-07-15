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
    public partial class ReportAvailableStocks : Form
    {
        public ReportAvailableStocks()
        {
            InitializeComponent();
        }

        private void ReportAvailableStocks_Load(object sender, EventArgs e)
        {
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();

            SA47_Team12bDataSetTableAdapters.BooksTableAdapter booksTableAdapter = new SA47_Team12bDataSetTableAdapters.BooksTableAdapter();
            booksTableAdapter.Fill(ds.Books);

            CRAvailableStocks crAvailableStocks = new CRAvailableStocks();
            crAvailableStocks.SetDataSource(ds);
            crystalReportViewerAS.ReportSource = crAvailableStocks;
        }
    }
}
