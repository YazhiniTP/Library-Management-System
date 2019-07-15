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
    public partial class LibraryLogout : Form
    {
        public LibraryLogout()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new LibraryLogin();
            login.Show();
            this.Hide();
        }
    }
}
