using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA47_Team12aCAProject
{
    public partial class LibraryLogin : Form
    {
        public LibraryLogin()
        {
            InitializeComponent();
        }

        string login;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login = "a";
            string cnS = "data source=(local);initial catalog=SA47_Team12aCADatabase;integrated security=SSPI";
            SqlConnection cn = new SqlConnection(cnS);
            string sql = "Select Login,Password from EmployeeMaster";
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            SA47_Team12bDataSet ds = new SA47_Team12bDataSet();
            da.Fill(ds, "EmployeeMaster");
            DataRow dr = ds.Tables["EmployeeMaster"].NewRow();
            int a, b = 0;
            for (a = 0; a < ds.Tables["EmployeeMaster"].Rows.Count; a++)
            {
                if (ds.Tables["EmployeeMaster"].Rows[a]["Login"].ToString() == textBoxUsername.Text.Trim())
                {
                    break;
                }
                if (a == ds.Tables["EmployeeMaster"].Rows.Count)
                {
                    a = 109;
                }
            }
            if (a < ds.Tables["EmployeeMaster"].Rows.Count)
            {

            }

            else
                MessageBox.Show("User not found!!");
            for (b = 0; b < ds.Tables["EmployeeMaster"].Rows.Count; b++)
            {
                if (ds.Tables["EmployeeMaster"].Rows[b]["Password"].ToString() == textBoxPassword.Text.Trim())
                {
                    break;
                }
            }
            if (b < ds.Tables["EmployeeMaster"].Rows.Count)
            {

            }

            else
                MessageBox.Show("Password not correct!!");
            if (a == b && textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                LibraryScreen menus = new LibraryScreen();
                menus.Showname = textBoxUsername.Text;
                menus.Show();
                this.Hide();
            }
            else if (b < ds.Tables["EmployeeMaster"].Rows.Count)
                MessageBox.Show("Password not correct!!");
        }

        private void buttonGuestLogin_Click(object sender, EventArgs e)
        {
            login = "b";
            LibraryScreen menuGuest = new LibraryScreen();
            menuGuest.Login = login;
            menuGuest.Show();
        }
    }
}
