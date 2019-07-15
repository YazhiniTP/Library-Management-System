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
    public partial class BookBrowse : Form
    {
        public string BookID = "";
        public string BookTitle = "";

        public BookBrowse()
        {
            InitializeComponent();
        }

        private void BookBrowse_Load(object sender, EventArgs e)
        {
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();
            SA47_Team12bDataSetTableAdapters.BooksTableAdapter booksTableAdapter = new SA47_Team12bDataSetTableAdapters.BooksTableAdapter();
            booksTableAdapter.Fill(ds.Books);

            dataGridViewBookBrowse.DataSource = ds.Tables["Books"];
        }

        private void buttonBBOk_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewBookBrowse.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewBookBrowse.Rows[selectedRowIndex];

            int totalstock = Convert.ToInt16(selectedRow.Cells["TotalStock"].Value);
            int numrented = Convert.ToInt16(selectedRow.Cells["NumberRented"].Value);
            //if(totalstock <= numrented)
            //{
            //    MessageBox.Show("Book not available to rent");
            //}
            //else
            {

                BookID = Convert.ToString(selectedRow.Cells["BookID"].Value);
                BookTitle = Convert.ToString(selectedRow.Cells["BookTitle"].Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonBBReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
