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
    public partial class LibraryScreen : Form, Interface
    {
        SA47_Team12aCADatabaseEntities context;
        SA47_Team12bDataSet ds;

        List<Member> Mem;
        List<Book> Books;
        List<IssueTran> IssueTransaction;
        List<Author> Aut;
        List<string> pub;
        List<string> type;
        IssueTran transrecord2;

        int rowNo = 0, row = 0, rowCount;
        int check = -1;
        int memID = 0;
        int bookID = 0;

        private string showname = "";

        private string login = "";

        public string Showname
        {
            set
            {
                showname = "Welcome " + value;
            }
        }

        public string Login
        {
            set
            {
                login = value;
            }
        }

        public LibraryScreen()
        {
            InitializeComponent();
        }

        private void LibraryScreen_Load(object sender, EventArgs e)
        {
            context = new SA47_Team12aCADatabaseEntities();
            Mem = context.Members.ToList();
            Books = context.Books.ToList();
            Aut = context.Authors.ToList();
            labelWelcome.Text = showname;


            //-------------------------HIDE TABS BASED ON USER------------------------------
            if (login == "b")
            {
                this.BookMaintain.Hide();
                tabControlMenus.TabPages.Remove(IssueBook);
                this.MemberMaintain.Hide();
                tabControlMenus.TabPages.Remove(ReturnBook);
                this.BookMaintain.Hide();
                tabControlMenus.TabPages.Remove(BookMaintain);
                this.MemberMaintain.Hide();
                tabControlMenus.TabPages.Remove(MemberMaintain);
                this.Reports.Hide();
                tabControlMenus.TabPages.Remove(Reports);

                this.buttonSProceed.Hide();
                this.buttonASProceed.Hide();
            }


            //----------------------------SEARCH------------------
            pub = new List<string>();
            type = new List<string>();

            for (int i = 0; i < Books.Count; i++)
            {
                int id = Books[i].BookID;
                string title = Books[i].BookTitle;

                pub.Add(Books[i].Publisher);
                type.Add(Books[i].BookType);

                comboBoxBookID.Items.Add(id);
                comboBoxBookTitle.Items.Add(title);
            }

            var unique_pub = new HashSet<string>(pub);
            foreach (string publisher in unique_pub)
            {
                comboBoxPublisher.Items.Add(publisher);
            }

            var unique_type = new HashSet<string>(type);
            foreach (string booktype in unique_type)
            {
                comboBoxBookType.Items.Add(booktype);
            }

            for (int i = 0; i < Aut.Count; i++)
            {
                string authorName = Aut[i].AuthorName;
                comboBoxAuthorName.Items.Add(authorName);
            }
        }




        //--------------------------------------------------SEARCH------------------------------------------------------

        private void buttonSSearch_Click(object sender, EventArgs e)
        {
            string searchInput = textBoxSSearchValue.Text;
            string searchCriteria = comboBoxSSearchFilter.Text;

            if (searchCriteria == "Book ID")
            {
                int flag = 1;
                for (int i = 0; i < Books.Count; i++)
                    if (searchInput == Books[i].BookID.ToString())
                    {
                        var book = context.Books.Where(x => x.BookID.ToString() == searchInput);
                        dataGridViewSSearch.DataSource = book.ToList();
                        flag = 2;
                    }
                if (flag == 1)
                    MessageBox.Show("Sorry ! Book details not found ! Try again !");
            }

            if (searchCriteria == "Book Title")
            {
                int flag = 1;
                for (int i = 0; i < Books.Count; i++)
                    if (searchInput.ToLower() == Books[i].BookTitle.ToLower())
                    {
                        var book = context.Books.Where(x => x.BookTitle.ToLower() == searchInput.ToLower());
                        dataGridViewSSearch.DataSource = book.ToList();
                        flag = 2;
                    }
                if (flag == 1)
                    MessageBox.Show("Sorry ! Book details not found ! Try again !");
            }

            if (searchCriteria == "Book Type")
            {
                int flag = 1;
                for (int i = 0; i < Books.Count; i++)
                    if (searchInput.ToLower() == Books[i].BookType.ToLower())
                    {
                        var book = context.Books.Where(x => x.BookType.ToString().ToLower() == searchInput.ToLower());
                        dataGridViewSSearch.DataSource = book.ToList();
                        flag = 2;
                    }
                if (flag == 1)
                    MessageBox.Show("Sorry ! Book details not found ! Try again !");
            }

            if (searchCriteria == "Author Name")
            {
                int flag = 1;
                for (int i = 0; i < Books.Count; i++)
                    if (searchInput == Books[i].AuthorName.ToString())
                    {
                        var book = context.Books.Where(x => x.AuthorName.ToString().ToLower() == searchInput.ToLower());
                        dataGridViewSSearch.DataSource = book.ToList();
                        flag = 2;
                    }
                if (flag == 1)
                    MessageBox.Show("Sorry ! Book details not found ! Try again !");
            }

            if (searchCriteria == "Publisher")
            {
                int flag = 1;
                for (int i = 0; i < Books.Count; i++)
                    if (searchInput.ToLower() == Books[i].Publisher.ToLower())
                    {
                        var book = context.Books.Where(x => x.Publisher.ToLower() == searchInput.ToLower());
                        dataGridViewSSearch.DataSource = book.ToList();
                        flag = 2;
                    }
                if (flag == 1)
                    MessageBox.Show("Sorry ! Book details not found ! Try again !");
            }
        }

        private void buttonSReset_Click(object sender, EventArgs e)
        {
            comboBoxSSearchFilter.Text = "Search Filter";
            textBoxSSearchValue.Clear();
        }

        private void buttonSProceed_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewSSearch.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewSSearch.Rows[selectedRowIndex];
            string BookID = Convert.ToString(selectedRow.Cells[0].Value);
            string BookTitle = Convert.ToString(selectedRow.Cells[1].Value);

            tabControlMenus.SelectedIndex = 0;
            textBoxIBBookID.Text = BookID;
            textBoxIBBookTitle.Text = BookTitle;
        }



        //------------------------------------------------------ADVANCED SEARCH-------------------------------------------
        private void buttonASearch_Click(object sender, EventArgs e)
        {
            var transrecord1 = from x in context.Books.Where(x => ((x.AuthorName == comboBoxAuthorName.Text) || (x.BookID.ToString() == comboBoxBookID.Text) || 
                                                                    (x.BookTitle == comboBoxBookTitle.Text) || (x.Publisher == comboBoxPublisher.Text) || 
                                                                    (x.BookType == comboBoxBookType.Text)) && (x.TotalStock > x.NumberRented))
                               select (new { x.BookID, x.BookTitle, x.AuthorName, x.BookType, x.Publisher, x.TotalStock, x.NumberRented });
            dataGridViewSearch.DataSource = transrecord1.ToList();
        }

        private void buttonASReset_Click(object sender, EventArgs e)
        {
            comboBoxBookID.Text = "Book ID";
            comboBoxBookTitle.Text = "Book Title";
            comboBoxBookType.Text = "Book Type";
            comboBoxAuthorName.Text = "Author Name";
            comboBoxPublisher.Text = "Publisher";
        }

        private void buttonASProceed_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewSearch.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewSearch.Rows[selectedRowIndex];
            string BookID = Convert.ToString(selectedRow.Cells[0].Value);
            string BookTitle = Convert.ToString(selectedRow.Cells[1].Value);

            tabControlMenus.SelectedIndex = 1;
            textBoxIBBookID.Text = BookID;
            textBoxIBBookTitle.Text = BookTitle;            
        }




        //-------------------------------------ISSUE BOOK-------------------------------------

        private void IssueBook_MouseHover(object sender, EventArgs e)
        {
            textBoxIBIssueDate.Text = Convert.ToString(System.DateTime.Today.Date);
            textBoxIBDueDate.Text = Convert.ToString(System.DateTime.Today.Date.AddDays(10));
        }

        private void buttonIBMemBrowse_Click(object sender, EventArgs e)
        {
            var memBrowse = new MemberBrowse();
            if (memBrowse.ShowDialog() == DialogResult.OK)
            {
                this.textBoxIBMemID.Text = memBrowse.MemberID;
                this.textBoxIBMemName.Text = memBrowse.MemberName;
            }
        }

        private void buttonIBBookBrowse_Click(object sender, EventArgs e)
        {
            var bookBrowse = new BookBrowse();
            if (bookBrowse.ShowDialog() == DialogResult.OK)// || SearchPage.Show() == DialogResult.)
            {
                this.textBoxIBBookID.Text = bookBrowse.BookID;
                this.textBoxIBBookTitle.Text = bookBrowse.BookTitle;
            }
           
        }

        private void buttonIBIssue_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new SA47_Team12bDataSet();

                SA47_Team12bDataSetTableAdapters.IssueTransTableAdapter issueTransTableAdapter = new SA47_Team12bDataSetTableAdapters.IssueTransTableAdapter();
                issueTransTableAdapter.Fill(ds.IssueTrans);

                SA47_Team12bDataSetTableAdapters.BooksTableAdapter booksTableAdapter = new SA47_Team12bDataSetTableAdapters.BooksTableAdapter();
                booksTableAdapter.Fill(ds.Books);

                DataRow dr = ds.Tables["IssueTrans"].NewRow();

                //dr["TransactionID"] = .Text;
                dr["MemberID"] = textBoxIBMemID.Text;
                dr["BookID"] = textBoxIBBookID.Text;
                dr["IssueDate"] = textBoxIBIssueDate.Text;
                dr["DueDate"] = textBoxIBDueDate.Text;
                dr["Status"] = "OUT";
                dr["Remarks"] = textBoxIBRemarks.Text;

                ds.Tables["IssueTrans"].Rows.Add(dr);
                issueTransTableAdapter.Update(ds.IssueTrans);

                foreach (DataRow datarow in ds.Tables["Books"].Rows)
                {
                    if (datarow["BookID"].ToString() == textBoxIBBookID.Text)
                    {
                        ds.Tables["Books"].Rows[rowNo]["NumberRented"] = Convert.ToInt32(ds.Tables["Books"].Rows[rowNo]["NumberRented"]) + 1;
                    }
                    rowNo = rowNo + 1;
                }
                booksTableAdapter.Update(ds.Books);

                progressBarLib.Visible = true;
                progressBarLib.PerformStep();
                if (progressBarLib.Value == 100)
                {
                    MessageBox.Show("Record has been updated");
                    progressBarLib.Value = progressBarLib.Minimum;
                }
                progressBarLib.Visible = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIBReset_Click(object sender, EventArgs e)
        {
            textBoxIBMemID.Text = "";
            textBoxIBMemName.Text = "";
            textBoxIBBookID.Text = "";
            textBoxIBBookTitle.Text = "";
            textBoxIBRemarks.Text = "";
        }





        //-------------------------------------RETURN BOOK-----------------------------------

        private void buttonRBMemBrowse_Click(object sender, EventArgs e)
        {
            var memBrowse = new MemberBrowse();
            if (memBrowse.ShowDialog() == DialogResult.OK)
            {
                this.textBoxRBMemID.Text = memBrowse.MemberID;
                this.textBoxRBMemName.Text = memBrowse.MemberName;
            }
        }

        private void buttonRBBookBrowse_Click(object sender, EventArgs e)
        {
            var bookBrowse = new BookBrowse();
            if (bookBrowse.ShowDialog() == DialogResult.OK)
            {
                this.textBoxRBBookID.Text = bookBrowse.BookID;
                this.textBoxRBBookTitle.Text = bookBrowse.BookTitle;
            }
        }

        private void buttonRBSearchTrans_Click(object sender, EventArgs e)
        {
            try
            {
                context = new SA47_Team12aCADatabaseEntities();
                IssueTransaction = context.IssueTrans.ToList();
                Mem = context.Members.ToList();
                Books = context.Books.ToList();

                string memname = textBoxRBMemName.Text.ToLower();
                string bookname = textBoxRBBookTitle.Text.ToLower();

                bool bookstatus = true;
                bool memstatus = true;
                bool transtatus = true;

                for (int i = 0; i < Mem.Count; i++)
                {
                    if (memname == Mem[i].MemberName.ToLower())
                    {
                        //TextBoxTryMemName.Text = Mem[i].MemberID.ToString();
                        memID = Mem[i].MemberID;
                        memstatus = false;
                        break;
                    }
                }
                if (memstatus == true)
                {
                    MessageBox.Show("Member not found");
                }

                for (int j = 0; j < Books.Count; j++)
                {
                    if (bookname == Books[j].BookTitle.ToLower())
                    {
                        //TryBookNameTextBox.Text = Books[j].BookID.ToString();
                        bookID = Books[j].BookID;
                        bookstatus = false;
                        break;
                    }
                }
                if (bookstatus == true)
                {
                    MessageBox.Show("Book not found");
                }

                for (int count = 0; count < IssueTransaction.Count; count++)
                {
                    if ((bookID == IssueTransaction[count].BookID) || (memID == IssueTransaction[count].MemberID))
                    {
                        //var transrecord1 = context.IssueTrans.Where((x => (x.BookID == bookID && x.MemberID == memID)));
                        var transrecord1 = from x in context.IssueTrans.Where(x => (x.BookID == bookID || x.MemberID == memID))
                                           select (new { x.TransactionID, x.BookID, x.MemberID, x.IssueDate, x.DueDate, x.ActualReturnDate, x.FineAmount, x.Remarks, x.Status });

                        dataGridViewReturnBook.DataSource = transrecord1.ToList();
                        transtatus = false;
                    }
                }
                if (transtatus == true)
                {
                    MessageBox.Show("Transaction not found");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewReturnBook_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedRowIndex = dataGridViewReturnBook.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = dataGridViewReturnBook.Rows[selectedRowIndex];
            bookID = Convert.ToInt32(selectedrow.Cells["BookID"].Value);
            memID = Convert.ToInt32(selectedrow.Cells["MemberID"].Value);
            transrecord2 = context.IssueTrans.Where((x => (x.BookID == bookID) && (x.MemberID == memID))).First();
        }

        private void buttonRBReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                if (transrecord2.Status == "OUT")
                {
                    progressBarLib.Visible = true;
                    progressBarLib.PerformStep();
                    transrecord2.Status = "IN";
                    transrecord2.ActualReturnDate = DateTime.Today.Date;

                    int compare = DateTime.Compare(transrecord2.ActualReturnDate.Value, transrecord2.DueDate.Date);

                    DateTime duedate = transrecord2.DueDate.Date;
                    DateTime returndate = transrecord2.ActualReturnDate.Value;
                    TimeSpan ts = returndate - duedate;
                    int tsd = ts.Days;

                    if (tsd > 0)
                    {
                        transrecord2.FineAmount = Convert.ToDecimal(0.5 * (tsd));
                        string displayfine = transrecord2.FineAmount.ToString();
                        MessageBox.Show("Fine amount is $" + displayfine);
                    }

                    int? findID = transrecord2.BookID;

                    for (int i = 0; i < Books.Count; i++)
                    {
                        if (findID == Books[i].BookID)
                        {
                            Books[i].NumberRented -= 1;
                            MessageBox.Show("Return Successful!");
                            break;
                        }
                    }
                    context.SaveChanges();
                    flag = 1;
                    if (progressBarLib.Value == 100)
                    {
                        progressBarLib.Value = progressBarLib.Minimum;
                        progressBarLib.Visible = false;
                    }
                }
                else if (flag == 0)
                {
                    progressBarLib.Visible = true;
                    progressBarLib.PerformStep();
                    if (progressBarLib.Value == 100)
                    {
                        MessageBox.Show("Already returned");
                        progressBarLib.Value = progressBarLib.Minimum;
                        progressBarLib.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRBRenew_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime duedate = transrecord2.DueDate.Date;
                DateTime today = System.DateTime.Now;
                TimeSpan ts = today - duedate;
                int tsd = ts.Days;

                if (transrecord2.Status == "OUT" && tsd <= 0)
                {
                    DateTime newduedate = transrecord2.DueDate.Date.AddDays(5);
                    transrecord2.DueDate = newduedate;
                    MessageBox.Show("Renew successful");
                    context.SaveChanges();
                }
                else
                {
                    progressBarLib.Visible = true;
                    progressBarLib.PerformStep();
                    if (progressBarLib.Value == 100)
                    {
                        MessageBox.Show("Sorry ! Cannot be renewed !");
                        progressBarLib.Value = progressBarLib.Minimum;
                        progressBarLib.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                progressBarLib.Visible = true;
                progressBarLib.PerformStep();
                if (progressBarLib.Value == 100)
                {
                    MessageBox.Show(ex.Message);
                    progressBarLib.Value = progressBarLib.Minimum;
                    progressBarLib.Visible = false;
                }
            }
        }





        //---------------------------------BOOK MAINTANENCE------------------------------------
        public void DisplayBook()
        {
            try
            {
                textBoxBMBookID.Text = Books[row].BookID.ToString();
                textBoxBMBookTitle.Text = Books[row].BookTitle?.ToString();
                textBoxBMAuthorName.Text = Books[row].Author?.AuthorName.ToString();
                textBoxBMPublisher.Text = Books[row].Publisher.ToString();
                textBoxBMTotalStock.Text = Books[row].TotalStock.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.StackTrace);
            }
        }

        private void buttonBMLoad_Click(object sender, EventArgs e)
        {
            textBoxBMBookID.Text = Books[0].BookID.ToString();
            textBoxBMBookTitle.Text = Books[0].BookTitle.ToString();
            textBoxBMAuthorName.Text = Books[0].Author.AuthorName.ToString();
            textBoxBMPublisher.Text = Books[0].Publisher.ToString();
            textBoxBMTotalStock.Text = Books[0].TotalStock.ToString();
        }

        private void buttonBMReset_Click(object sender, EventArgs e)
        {
            textBoxBMBookTitle.Clear();
            textBoxBMBookID.Clear();
            textBoxBMAuthorName.Clear();
            textBoxBMPublisher.Clear();
            textBoxBMTotalStock.Clear();
            row = 0;
        }

        private void buttonBMAuthorBrowse_Click(object sender, EventArgs e)
        {
            var autbrowse = new AuthorBrowse();
            if (autbrowse.ShowDialog() == DialogResult.OK)
            {
                this.textBoxBMAuthorName.Text = autbrowse.AutName;
            }
        }

        private void buttonBMAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                Author author = new Author();

                string BkTitle = textBoxBMBookTitle.Text.ToLower();
                int j = 0;
                for (j = 0; j < Books.Count; j++)
                {

                    if (BkTitle == Books[j].BookTitle.ToString().ToLower())
                    {
                        MessageBox.Show("Book exists");
                        break;
                    }
                }
                if (j == Books.Count)

                {
                    string findAut = textBoxBMAuthorName.Text.ToString();

                    for (int i = 0; i < Aut.Count; i++)
                    {
                        if (findAut == Aut[i].AuthorName.ToString())
                        {
                            check = i;
                            //author.AuthorName = Aut[row].AuthorName.ToString();
                            break;
                        }
                    }

                    if (check == -1)
                    {
                        author.AuthorName = textBoxBMAuthorName.Text.ToString();

                        context.Authors.Add(author);
                    }
                    book.BookTitle = textBoxBMBookTitle.Text.ToString();
                    book.AuthorName = textBoxBMAuthorName.Text.ToString();
                    book.Publisher = textBoxBMPublisher.Text.ToString();
                    book.TotalStock = Convert.ToInt32(textBoxBMTotalStock.Text.ToString());

                    context.Books.Add(book);
                    MessageBox.Show("Book added");
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonBMUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int originalTotalStock = Convert.ToInt16(Books[row].TotalStock.ToString());

                Books[row].BookID = Convert.ToInt16(textBoxBMBookID.Text.ToString());
                Books[row].BookTitle = textBoxBMBookTitle.Text.ToString();
                Books[row].AuthorName = textBoxBMAuthorName.Text.ToString();
                Books[row].Publisher = textBoxBMPublisher.Text.ToString();
                Books[row].TotalStock = Convert.ToInt16(textBoxBMTotalStock.Text.ToString());
                context.SaveChanges();

                ds = new SA47_Team12bDataSet();

                SA47_Team12bDataSetTableAdapters.StockAdjustmentTableAdapter stockAdjustmentTableAdapter = new SA47_Team12bDataSetTableAdapters.StockAdjustmentTableAdapter();
                stockAdjustmentTableAdapter.Fill(ds.StockAdjustment);

                SA47_Team12bDataSetTableAdapters.BooksTableAdapter booksTableAdapter = new SA47_Team12bDataSetTableAdapters.BooksTableAdapter();
                booksTableAdapter.Fill(ds.Books);

                DataRow dr = ds.Tables["StockAdjustment"].NewRow();
                dr["BookID"] = Books[row].BookID;
                dr["Date Adjusted"] = Convert.ToString(DateTime.Now);

                ds.Tables["StockAdjustment"].Rows.Add(dr);
                stockAdjustmentTableAdapter.Update(ds.StockAdjustment);

                foreach (DataRow datarow in ds.Tables["Books"].Rows)
                {
                    if (datarow["BookID"].ToString() == textBoxBMBookID.Text)
                    {
                        if (Convert.ToInt16(textBoxBMTotalStock.Text) >= originalTotalStock)

                        {
                            /* ds.Tables["StockAdjustment2"].Rows[row]["Adjustment Quantity"]*/
                            dr["Adjustment Quantity"] = Convert.ToInt16(textBoxBMTotalStock.Text.ToString()) - originalTotalStock;
                            dr["Status"] = "ADD";
                        }
                        else
                        {
                            dr["Adjustment Quantity"] = originalTotalStock - Convert.ToInt16(textBoxBMTotalStock.Text.ToString());
                            dr["Status"] = "REMOVE";
                        }
                    }
                    row = row + 1;
                }
                stockAdjustmentTableAdapter.Update(ds.StockAdjustment);

                MessageBox.Show("Record has been updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonBMRemove_Click(object sender, EventArgs e)
        {
            context.Books.Remove(Books[row]);
            MessageBox.Show("Book removed from database");
            context.SaveChanges();
        }

        private void buttonBMPrevious_Click(object sender, EventArgs e)
        {
            row = row - 1;
            DisplayBook();
        }

        private void buttonBMNext_Click(object sender, EventArgs e)
        {
            row = row + 1;
            DisplayBook();
        }

        private void buttonBMFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            DisplayBook();
        }

        private void buttonBMLast_Click(object sender, EventArgs e)
        {
            rowCount = Books.Count;
            row = rowCount - 1;
            DisplayBook();
        }






        //-------------------------------MEMBER MAINTAINENCE-----------------------------------

        public void DisplayMem()
        {
            try
            {
                textBoxMMMemID.Text = Mem[row].MemberID.ToString();
                textBoxMMMemName.Text = Mem[row].MemberName.ToString();
                textBoxMMConTitle.Text = Mem[row].ContactTitle.ToString();
                maskedTextBoxMMPhone.Text = Mem[row].PhoneNumber.ToString();
                textBoxMMEmail.Text = Mem[row].EmailAddress.ToString();
                textBoxMMCountry.Text = Mem[row].Country.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.StackTrace);
            }
        }

        public void ClearMem()
        {
            textBoxMMMemID.Clear();
            textBoxMMMemName.Clear();
            textBoxMMConTitle.Clear();
            maskedTextBoxMMPhone.Clear();
            textBoxMMEmail.Clear();
            textBoxMMCountry.Clear();
            row = 0;
        }

        private void buttonMMFind_Click(object sender, EventArgs e)
        {
            string findMem = textBoxMMFind.Text.ToString();
            int count = 0;
            rowCount = Mem.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (findMem == Mem[i].MemberID.ToString())
                {
                    count = i;
                    break;
                }
            }
            row = count;
            DisplayMem();
        }

        private void buttonMMUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Mem[row].MemberID = Convert.ToInt16(textBoxMMMemID.Text.ToString());
                Mem[row].MemberName = textBoxMMMemName.Text.ToString();
                Mem[row].ContactTitle = textBoxMMConTitle.Text.ToString();
                Mem[row].PhoneNumber = maskedTextBoxMMPhone.Text.ToString();
                Mem[row].EmailAddress = textBoxMMEmail.Text.ToString();
                Mem[row].Country = textBoxMMCountry.Text.ToString();

                MessageBox.Show("Record updated !");
                context.SaveChanges();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearMem();
        }

        private void buttonMMAdd_Click(object sender, EventArgs e)
        {
            Mem = context.Members.ToList();
            int flag = 0;
            if (textBoxMMMemName.Text == "")
            {
                MessageBox.Show("Please provide name! ");
            }
            else
            {
                for (int i = 0; i < Mem.Count; i++)
                {
                    if ((textBoxMMMemName.Text == Mem[i].MemberName) && (maskedTextBoxMMPhone.Text == Mem[i].PhoneNumber))
                    {
                        MessageBox.Show("Member exists");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Member mem = new Member();
                    //mem.MemberID = Convert.ToInt16(textBoxVC.Text.ToString());
                    mem.MemberName = textBoxMMMemName.Text.ToString();
                    mem.ContactTitle = textBoxMMConTitle.Text.ToString();
                    mem.PhoneNumber = maskedTextBoxMMPhone.Text.ToString();
                    mem.EmailAddress = textBoxMMEmail.Text.ToString();
                    mem.Country = textBoxMMCountry.Text.ToString();

                    context.Members.Add(mem);
                    context.SaveChanges();

                    var memAdd =
                    context.Members.Where(x => (x.MemberName == textBoxMMMemName.Text)
                    && (x.ContactTitle == textBoxMMConTitle.Text)
                    && (x.PhoneNumber == maskedTextBoxMMPhone.Text)
                    && (x.EmailAddress == textBoxMMEmail.Text)
                    && (x.Country == textBoxMMCountry.Text)).First();

                    textBoxMMMemID.Text = memAdd.MemberID.ToString();

                    MessageBox.Show("Record inserted !");
                }
            }
            ClearMem();
        }

        private void buttonMMDelete_Click(object sender, EventArgs e)
        {
            Mem = context.Members.ToList();
            int flag = 0;
            if (textBoxMMMemName.Text == "")
            {
                flag = 1;
                MessageBox.Show("Please provide name! ");
            }
            else if(flag == 0)
            {
                context.Members.Remove(Mem[row]);
                MessageBox.Show("Record deleted !");
                context.SaveChanges();
                ClearMem();               
            }

        }

        private void buttonMMReset_Click(object sender, EventArgs e)
        {
            ClearMem();
        }

        private void buttonMMPrevious_Click(object sender, EventArgs e)
        {
            row = row - 1;
            DisplayMem();
        }

        private void buttonMMNext_Click(object sender, EventArgs e)
        {
            row = row + 1;
            DisplayMem();
        }

        private void buttonMMFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            DisplayMem();
        }

        private void buttonMMLast_Click(object sender, EventArgs e)
        {
            rowCount = Mem.Count;
            row = rowCount - 1;
            DisplayMem();
        }




        //------------------------------------REPORTS-------------------------------------------

        private void buttonRBooksStockDetails_Click(object sender, EventArgs e)
        {
            Form availableStocks = new ReportAvailableStocks();
            availableStocks.Show();
        }

        private void buttonBorrowersdemographics_Click(object sender, EventArgs e)
        {
            Form borrowersDemographic = new ReportBorrowersDemographic();
            borrowersDemographic.Show();
        }

        private void buttonRMonthlyStats_Click(object sender, EventArgs e)
        {
            Form monthlyStats = new ReportMonthlyStats();
            monthlyStats.Show();
        }

        private void buttonRTransactionHistory_Click(object sender, EventArgs e)
        {
            Form transactionHistory = new ReportTransactionHistory();
            transactionHistory.Show();
        }





        //-------------------------------------SHORTCUTS----------------------------------------

        private void LibraryScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.S)
            {
                tabControlMenus.SelectTab(0);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.A)
            {
                tabControlMenus.SelectTab(1);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.I)
            {
                tabControlMenus.SelectTab(2);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.T)
            {
                tabControlMenus.SelectTab(3);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.B)
            {
                tabControlMenus.SelectTab(4);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.M)
            {
                tabControlMenus.SelectTab(5);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.R)
            {
                tabControlMenus.SelectTab(6);
                e.Handled = true;
            }
        }



        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form logout = new LibraryLogout();
            logout.Show();
            this.Hide();
        }


    }
}
