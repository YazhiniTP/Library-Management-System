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
    public partial class AuthorBrowse : Form
    {
        public string AutName = "";

        public AuthorBrowse()
        {
            InitializeComponent();
        }

        private void AuthorBrowse_Load(object sender, EventArgs e)
        {
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();

            SA47_Team12bDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter = new SA47_Team12bDataSetTableAdapters.AuthorsTableAdapter();
            authorsTableAdapter.Fill(ds.Authors);

            dataGridViewAutBrowse.DataSource = ds.Tables["Authors"];
        }

        private void buttonABOk_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewAutBrowse.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewAutBrowse.Rows[selectedRowIndex];
            AutName = Convert.ToString(selectedRow.Cells["AuthorName"].Value);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonABCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
