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
    public partial class MemberBrowse : Form
    {
        public string MemberID = "";
        public string MemberName = "";

        public MemberBrowse()
        {
            InitializeComponent();
        }
        private void MemberBrowse_Load(object sender, EventArgs e)
        {
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();

            SA47_Team12bDataSetTableAdapters.MembersTableAdapter membersTableAdapter = new SA47_Team12bDataSetTableAdapters.MembersTableAdapter();
            membersTableAdapter.Fill(ds.Members);

            dataGridViewMemBrowse.DataSource = ds.Tables["Members"];
        }

        private void buttonMBOk_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewMemBrowse.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewMemBrowse.Rows[selectedRowIndex];
            MemberID = Convert.ToString(selectedRow.Cells["MemberID"].Value);
            MemberName = Convert.ToString(selectedRow.Cells["MemberName"].Value);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonMBReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
