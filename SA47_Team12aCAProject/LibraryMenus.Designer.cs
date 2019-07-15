namespace SA47_Team12aCAProject
{
    partial class LibraryScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryScreen));
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sA47_Team12bDataSet = new SA47_Team12aCAProject.SA47_Team12bDataSet();
            this.issueTransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.progressBarLib = new System.Windows.Forms.ProgressBar();
            this.helpProviderLib = new System.Windows.Forms.HelpProvider();
            this.maskedTextBoxMMPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonBMAuthorBrowse = new System.Windows.Forms.Button();
            this.ReturnBook = new System.Windows.Forms.TabPage();
            this.dataGridViewReturnBook = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRBRenew = new System.Windows.Forms.Button();
            this.buttonRBReturn = new System.Windows.Forms.Button();
            this.buttonRBSearchTrans = new System.Windows.Forms.Button();
            this.buttonRBBookBrowse = new System.Windows.Forms.Button();
            this.buttonRBMemBrowse = new System.Windows.Forms.Button();
            this.textBoxRBBookID = new System.Windows.Forms.TextBox();
            this.textBoxRBMemName = new System.Windows.Forms.TextBox();
            this.textBoxRBBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxRBMemID = new System.Windows.Forms.TextBox();
            this.labelRBBookID = new System.Windows.Forms.Label();
            this.labelRBMemID = new System.Windows.Forms.Label();
            this.textBoxIBDueDate = new System.Windows.Forms.TextBox();
            this.buttonIBMemBrowse = new System.Windows.Forms.Button();
            this.buttonIBBookBrowse = new System.Windows.Forms.Button();
            this.buttonIBReset = new System.Windows.Forms.Button();
            this.buttonASSearch = new System.Windows.Forms.Button();
            this.buttonASReset = new System.Windows.Forms.Button();
            this.buttonASProceed = new System.Windows.Forms.Button();
            this.tabControlMenus = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.buttonSProceed = new System.Windows.Forms.Button();
            this.buttonSReset = new System.Windows.Forms.Button();
            this.dataGridViewSSearch = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSSearch = new System.Windows.Forms.Button();
            this.comboBoxSSearchFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSSearchValue = new System.Windows.Forms.TextBox();
            this.labelSSearchValue = new System.Windows.Forms.Label();
            this.AdvancedSearch = new System.Windows.Forms.TabPage();
            this.comboBoxBookID = new System.Windows.Forms.ComboBox();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.comboBoxBookType = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthorName = new System.Windows.Forms.ComboBox();
            this.comboBoxBookTitle = new System.Windows.Forms.ComboBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueBook = new System.Windows.Forms.TabPage();
            this.buttonIBIssue = new System.Windows.Forms.Button();
            this.textBoxIBBookID = new System.Windows.Forms.TextBox();
            this.textBoxIBBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxIBRemarks = new System.Windows.Forms.TextBox();
            this.textBoxIBIssueDate = new System.Windows.Forms.TextBox();
            this.textBoxIBMemName = new System.Windows.Forms.TextBox();
            this.textBoxIBMemID = new System.Windows.Forms.TextBox();
            this.labelIBRemarks = new System.Windows.Forms.Label();
            this.labelIBDueDate = new System.Windows.Forms.Label();
            this.labelIBIssueDate = new System.Windows.Forms.Label();
            this.labelIBBookID = new System.Windows.Forms.Label();
            this.labelIBMemID = new System.Windows.Forms.Label();
            this.BookMaintain = new System.Windows.Forms.TabPage();
            this.buttonBMAdd = new System.Windows.Forms.Button();
            this.buttonBMUpdate = new System.Windows.Forms.Button();
            this.buttonBMRemove = new System.Windows.Forms.Button();
            this.buttonBMNext = new System.Windows.Forms.Button();
            this.buttonBMFirst = new System.Windows.Forms.Button();
            this.buttonBMLast = new System.Windows.Forms.Button();
            this.buttonBMLoad = new System.Windows.Forms.Button();
            this.buttonBMReset = new System.Windows.Forms.Button();
            this.buttonBMPrevious = new System.Windows.Forms.Button();
            this.textBoxBMBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxBMAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxBMPublisher = new System.Windows.Forms.TextBox();
            this.textBoxBMTotalStock = new System.Windows.Forms.TextBox();
            this.textBoxBMBookID = new System.Windows.Forms.TextBox();
            this.labelBMTotalStock = new System.Windows.Forms.Label();
            this.labelBMPublisher = new System.Windows.Forms.Label();
            this.labelBMAuthorName = new System.Windows.Forms.Label();
            this.labelBMBookTitle = new System.Windows.Forms.Label();
            this.labelBMBookID = new System.Windows.Forms.Label();
            this.MemberMaintain = new System.Windows.Forms.TabPage();
            this.groupBoxMMFind = new System.Windows.Forms.GroupBox();
            this.buttonMMFind = new System.Windows.Forms.Button();
            this.textBoxMMFind = new System.Windows.Forms.TextBox();
            this.buttonMMReset = new System.Windows.Forms.Button();
            this.buttonMMLast = new System.Windows.Forms.Button();
            this.buttonMMNext = new System.Windows.Forms.Button();
            this.buttonMMDelete = new System.Windows.Forms.Button();
            this.buttonMMAdd = new System.Windows.Forms.Button();
            this.buttonMMUpdate = new System.Windows.Forms.Button();
            this.buttonMMFirst = new System.Windows.Forms.Button();
            this.buttonMMPrevious = new System.Windows.Forms.Button();
            this.dateTimePickerMMDob = new System.Windows.Forms.DateTimePicker();
            this.textBoxMMCountry = new System.Windows.Forms.TextBox();
            this.textBoxMMEmail = new System.Windows.Forms.TextBox();
            this.textBoxMMConTitle = new System.Windows.Forms.TextBox();
            this.textBoxMMMemName = new System.Windows.Forms.TextBox();
            this.textBoxMMMemID = new System.Windows.Forms.TextBox();
            this.labelMMCountry = new System.Windows.Forms.Label();
            this.labelMMEmail = new System.Windows.Forms.Label();
            this.labelMMPhone = new System.Windows.Forms.Label();
            this.labelMMDob = new System.Windows.Forms.Label();
            this.labelMMConTitle = new System.Windows.Forms.Label();
            this.labelMMMemName = new System.Windows.Forms.Label();
            this.labelMMMemID = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.TabPage();
            this.buttonRTransactionHistory = new System.Windows.Forms.Button();
            this.buttonRMonthlyStats = new System.Windows.Forms.Button();
            this.buttonBorrowersdemographics = new System.Windows.Forms.Button();
            this.buttonRBooksStockDetails = new System.Windows.Forms.Button();
            this.booksTableAdapter = new SA47_Team12aCAProject.SA47_Team12bDataSetTableAdapters.BooksTableAdapter();
            this.toolTipLib = new System.Windows.Forms.ToolTip(this.components);
            this.issueTransTableAdapter = new SA47_Team12aCAProject.SA47_Team12bDataSetTableAdapters.IssueTransTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA47_Team12bDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueTransBindingSource)).BeginInit();
            this.ReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBook)).BeginInit();
            this.tabControlMenus.SuspendLayout();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSearch)).BeginInit();
            this.AdvancedSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.IssueBook.SuspendLayout();
            this.BookMaintain.SuspendLayout();
            this.MemberMaintain.SuspendLayout();
            this.groupBoxMMFind.SuspendLayout();
            this.Reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.sA47_Team12bDataSet;
            // 
            // sA47_Team12bDataSet
            // 
            this.sA47_Team12bDataSet.DataSetName = "SA47_Team12bDataSet";
            this.sA47_Team12bDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueTransBindingSource
            // 
            this.issueTransBindingSource.DataMember = "IssueTrans";
            this.issueTransBindingSource.DataSource = this.sA47_Team12bDataSet;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelTitle.Location = new System.Drawing.Point(204, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(526, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Lets get lost in the world of books !";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogout.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(1019, 555);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(73, 23);
            this.linkLabelLogout.TabIndex = 5;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout !";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(913, 27);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(59, 23);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "label1";
            // 
            // progressBarLib
            // 
            this.progressBarLib.Location = new System.Drawing.Point(7, 560);
            this.progressBarLib.Name = "progressBarLib";
            this.progressBarLib.Size = new System.Drawing.Size(285, 18);
            this.progressBarLib.Step = 100;
            this.progressBarLib.TabIndex = 7;
            this.progressBarLib.Visible = false;
            // 
            // maskedTextBoxMMPhone
            // 
            this.helpProviderLib.SetHelpString(this.maskedTextBoxMMPhone, "Accept only numbers");
            this.maskedTextBoxMMPhone.Location = new System.Drawing.Point(374, 193);
            this.maskedTextBoxMMPhone.Mask = "000-0000";
            this.maskedTextBoxMMPhone.Name = "maskedTextBoxMMPhone";
            this.helpProviderLib.SetShowHelp(this.maskedTextBoxMMPhone, true);
            this.maskedTextBoxMMPhone.Size = new System.Drawing.Size(199, 26);
            this.maskedTextBoxMMPhone.TabIndex = 25;
            this.toolTipLib.SetToolTip(this.maskedTextBoxMMPhone, "Accepts only numbers in format \"000-0000\"");
            // 
            // buttonBMAuthorBrowse
            // 
            this.helpProviderLib.SetHelpString(this.buttonBMAuthorBrowse, "Click the button to browse the authors list");
            this.buttonBMAuthorBrowse.Location = new System.Drawing.Point(642, 127);
            this.buttonBMAuthorBrowse.Name = "buttonBMAuthorBrowse";
            this.helpProviderLib.SetShowHelp(this.buttonBMAuthorBrowse, true);
            this.buttonBMAuthorBrowse.Size = new System.Drawing.Size(46, 23);
            this.buttonBMAuthorBrowse.TabIndex = 19;
            this.buttonBMAuthorBrowse.Text = "...";
            this.buttonBMAuthorBrowse.UseVisualStyleBackColor = true;
            this.buttonBMAuthorBrowse.Click += new System.EventHandler(this.buttonBMAuthorBrowse_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnBook.BackgroundImage")));
            this.ReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnBook.Controls.Add(this.dataGridViewReturnBook);
            this.ReturnBook.Controls.Add(this.buttonRBRenew);
            this.ReturnBook.Controls.Add(this.buttonRBReturn);
            this.ReturnBook.Controls.Add(this.buttonRBSearchTrans);
            this.ReturnBook.Controls.Add(this.buttonRBBookBrowse);
            this.ReturnBook.Controls.Add(this.buttonRBMemBrowse);
            this.ReturnBook.Controls.Add(this.textBoxRBBookID);
            this.ReturnBook.Controls.Add(this.textBoxRBMemName);
            this.ReturnBook.Controls.Add(this.textBoxRBBookTitle);
            this.ReturnBook.Controls.Add(this.textBoxRBMemID);
            this.ReturnBook.Controls.Add(this.labelRBBookID);
            this.ReturnBook.Controls.Add(this.labelRBMemID);
            this.helpProviderLib.SetHelpString(this.ReturnBook, "Fill either Member ID or Book ID and select Search to view the Transaction made");
            this.ReturnBook.Location = new System.Drawing.Point(4, 27);
            this.ReturnBook.Name = "ReturnBook";
            this.helpProviderLib.SetShowHelp(this.ReturnBook, true);
            this.ReturnBook.Size = new System.Drawing.Size(942, 449);
            this.ReturnBook.TabIndex = 2;
            this.ReturnBook.Text = "Return Book";
            this.toolTipLib.SetToolTip(this.ReturnBook, "use ALT + T for shortcut");
            this.ReturnBook.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReturnBook
            // 
            this.dataGridViewReturnBook.AutoGenerateColumns = false;
            this.dataGridViewReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn2,
            this.issueDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.actualReturnDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.fineAmountDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridViewReturnBook.DataSource = this.issueTransBindingSource;
            this.dataGridViewReturnBook.Location = new System.Drawing.Point(12, 144);
            this.dataGridViewReturnBook.Name = "dataGridViewReturnBook";
            this.dataGridViewReturnBook.RowTemplate.Height = 24;
            this.dataGridViewReturnBook.Size = new System.Drawing.Size(918, 245);
            this.dataGridViewReturnBook.TabIndex = 11;
            this.dataGridViewReturnBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewReturnBook_MouseClick);
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // bookIDDataGridViewTextBoxColumn2
            // 
            this.bookIDDataGridViewTextBoxColumn2.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn2.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn2.Name = "bookIDDataGridViewTextBoxColumn2";
            this.bookIDDataGridViewTextBoxColumn2.Width = 80;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // actualReturnDateDataGridViewTextBoxColumn
            // 
            this.actualReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ActualReturnDate";
            this.actualReturnDateDataGridViewTextBoxColumn.HeaderText = "ActualReturnDate";
            this.actualReturnDateDataGridViewTextBoxColumn.Name = "actualReturnDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 70;
            // 
            // fineAmountDataGridViewTextBoxColumn
            // 
            this.fineAmountDataGridViewTextBoxColumn.DataPropertyName = "FineAmount";
            this.fineAmountDataGridViewTextBoxColumn.HeaderText = "FineAmount";
            this.fineAmountDataGridViewTextBoxColumn.Name = "fineAmountDataGridViewTextBoxColumn";
            this.fineAmountDataGridViewTextBoxColumn.Width = 50;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // buttonRBRenew
            // 
            this.buttonRBRenew.Location = new System.Drawing.Point(247, 398);
            this.buttonRBRenew.Name = "buttonRBRenew";
            this.buttonRBRenew.Size = new System.Drawing.Size(152, 45);
            this.buttonRBRenew.TabIndex = 10;
            this.buttonRBRenew.Text = "Renew Book";
            this.toolTipLib.SetToolTip(this.buttonRBRenew, "Renew can be done only when Status of transaction is \'OUT\' and haven\'t crossed th" +
        "e due date yet");
            this.buttonRBRenew.UseVisualStyleBackColor = true;
            this.buttonRBRenew.Click += new System.EventHandler(this.buttonRBRenew_Click);
            // 
            // buttonRBReturn
            // 
            this.buttonRBReturn.Location = new System.Drawing.Point(592, 398);
            this.buttonRBReturn.Name = "buttonRBReturn";
            this.buttonRBReturn.Size = new System.Drawing.Size(151, 45);
            this.buttonRBReturn.TabIndex = 9;
            this.buttonRBReturn.Text = "Return Book";
            this.toolTipLib.SetToolTip(this.buttonRBReturn, "Return only when transaction status is \'OUT\'");
            this.buttonRBReturn.UseVisualStyleBackColor = true;
            this.buttonRBReturn.Click += new System.EventHandler(this.buttonRBReturn_Click);
            // 
            // buttonRBSearchTrans
            // 
            this.buttonRBSearchTrans.Location = new System.Drawing.Point(404, 89);
            this.buttonRBSearchTrans.Name = "buttonRBSearchTrans";
            this.buttonRBSearchTrans.Size = new System.Drawing.Size(188, 47);
            this.buttonRBSearchTrans.TabIndex = 8;
            this.buttonRBSearchTrans.Text = "Search Transaction";
            this.toolTipLib.SetToolTip(this.buttonRBSearchTrans, "Click here to find transaction details after filling either Member or book detail" +
        "s or both");
            this.buttonRBSearchTrans.UseVisualStyleBackColor = true;
            this.buttonRBSearchTrans.Click += new System.EventHandler(this.buttonRBSearchTrans_Click);
            // 
            // buttonRBBookBrowse
            // 
            this.helpProviderLib.SetHelpString(this.buttonRBBookBrowse, "Click the button to browse the book list");
            this.buttonRBBookBrowse.Location = new System.Drawing.Point(840, 15);
            this.buttonRBBookBrowse.Name = "buttonRBBookBrowse";
            this.helpProviderLib.SetShowHelp(this.buttonRBBookBrowse, true);
            this.buttonRBBookBrowse.Size = new System.Drawing.Size(46, 28);
            this.buttonRBBookBrowse.TabIndex = 7;
            this.buttonRBBookBrowse.Text = "...";
            this.buttonRBBookBrowse.UseVisualStyleBackColor = true;
            this.buttonRBBookBrowse.Click += new System.EventHandler(this.buttonRBBookBrowse_Click);
            // 
            // buttonRBMemBrowse
            // 
            this.helpProviderLib.SetHelpString(this.buttonRBMemBrowse, "Click the button to browse the member list");
            this.buttonRBMemBrowse.Location = new System.Drawing.Point(335, 17);
            this.buttonRBMemBrowse.Name = "buttonRBMemBrowse";
            this.helpProviderLib.SetShowHelp(this.buttonRBMemBrowse, true);
            this.buttonRBMemBrowse.Size = new System.Drawing.Size(54, 28);
            this.buttonRBMemBrowse.TabIndex = 6;
            this.buttonRBMemBrowse.Text = "...";
            this.buttonRBMemBrowse.UseVisualStyleBackColor = true;
            this.buttonRBMemBrowse.Click += new System.EventHandler(this.buttonRBMemBrowse_Click);
            // 
            // textBoxRBBookID
            // 
            this.textBoxRBBookID.Location = new System.Drawing.Point(638, 17);
            this.textBoxRBBookID.Name = "textBoxRBBookID";
            this.textBoxRBBookID.Size = new System.Drawing.Size(171, 26);
            this.textBoxRBBookID.TabIndex = 5;
            // 
            // textBoxRBMemName
            // 
            this.textBoxRBMemName.Location = new System.Drawing.Point(144, 64);
            this.textBoxRBMemName.Name = "textBoxRBMemName";
            this.textBoxRBMemName.Size = new System.Drawing.Size(245, 26);
            this.textBoxRBMemName.TabIndex = 4;
            // 
            // textBoxRBBookTitle
            // 
            this.textBoxRBBookTitle.Location = new System.Drawing.Point(638, 62);
            this.textBoxRBBookTitle.Name = "textBoxRBBookTitle";
            this.textBoxRBBookTitle.Size = new System.Drawing.Size(278, 26);
            this.textBoxRBBookTitle.TabIndex = 3;
            // 
            // textBoxRBMemID
            // 
            this.textBoxRBMemID.Location = new System.Drawing.Point(144, 19);
            this.textBoxRBMemID.Name = "textBoxRBMemID";
            this.textBoxRBMemID.Size = new System.Drawing.Size(152, 26);
            this.textBoxRBMemID.TabIndex = 2;
            // 
            // labelRBBookID
            // 
            this.labelRBBookID.AutoSize = true;
            this.labelRBBookID.Location = new System.Drawing.Point(534, 22);
            this.labelRBBookID.Name = "labelRBBookID";
            this.labelRBBookID.Size = new System.Drawing.Size(68, 18);
            this.labelRBBookID.TabIndex = 1;
            this.labelRBBookID.Text = "Book ID";
            // 
            // labelRBMemID
            // 
            this.labelRBMemID.AutoSize = true;
            this.labelRBMemID.Location = new System.Drawing.Point(29, 22);
            this.labelRBMemID.Name = "labelRBMemID";
            this.labelRBMemID.Size = new System.Drawing.Size(90, 18);
            this.labelRBMemID.TabIndex = 0;
            this.labelRBMemID.Text = "Member ID";
            // 
            // textBoxIBDueDate
            // 
            this.helpProviderLib.SetHelpString(this.textBoxIBDueDate, "Auto generated with value 10 days from Issue date (Today\'s date)");
            this.textBoxIBDueDate.Location = new System.Drawing.Point(290, 259);
            this.textBoxIBDueDate.Name = "textBoxIBDueDate";
            this.textBoxIBDueDate.ReadOnly = true;
            this.helpProviderLib.SetShowHelp(this.textBoxIBDueDate, true);
            this.textBoxIBDueDate.Size = new System.Drawing.Size(264, 26);
            this.textBoxIBDueDate.TabIndex = 9;
            // 
            // buttonIBMemBrowse
            // 
            this.helpProviderLib.SetHelpString(this.buttonIBMemBrowse, "Click the button to browse the member list");
            this.buttonIBMemBrowse.Location = new System.Drawing.Point(500, 18);
            this.buttonIBMemBrowse.Name = "buttonIBMemBrowse";
            this.helpProviderLib.SetShowHelp(this.buttonIBMemBrowse, true);
            this.buttonIBMemBrowse.Size = new System.Drawing.Size(54, 23);
            this.buttonIBMemBrowse.TabIndex = 12;
            this.buttonIBMemBrowse.Text = "...";
            this.toolTipLib.SetToolTip(this.buttonIBMemBrowse, "Click the button to browse the member list");
            this.buttonIBMemBrowse.UseVisualStyleBackColor = true;
            this.buttonIBMemBrowse.Click += new System.EventHandler(this.buttonIBMemBrowse_Click);
            // 
            // buttonIBBookBrowse
            // 
            this.helpProviderLib.SetHelpString(this.buttonIBBookBrowse, "Click the button to browse the books list");
            this.buttonIBBookBrowse.Location = new System.Drawing.Point(500, 116);
            this.buttonIBBookBrowse.Name = "buttonIBBookBrowse";
            this.helpProviderLib.SetShowHelp(this.buttonIBBookBrowse, true);
            this.buttonIBBookBrowse.Size = new System.Drawing.Size(54, 23);
            this.buttonIBBookBrowse.TabIndex = 13;
            this.buttonIBBookBrowse.Text = "...";
            this.toolTipLib.SetToolTip(this.buttonIBBookBrowse, "Click the button to browse the books list");
            this.buttonIBBookBrowse.UseVisualStyleBackColor = true;
            this.buttonIBBookBrowse.Click += new System.EventHandler(this.buttonIBBookBrowse_Click);
            // 
            // buttonIBReset
            // 
            this.helpProviderLib.SetHelpString(this.buttonIBReset, "Click the button after every book issue");
            this.buttonIBReset.Location = new System.Drawing.Point(500, 369);
            this.buttonIBReset.Name = "buttonIBReset";
            this.helpProviderLib.SetShowHelp(this.buttonIBReset, true);
            this.buttonIBReset.Size = new System.Drawing.Size(102, 43);
            this.buttonIBReset.TabIndex = 14;
            this.buttonIBReset.Text = "Reset";
            this.toolTipLib.SetToolTip(this.buttonIBReset, "Click here to clear the issue form");
            this.buttonIBReset.UseVisualStyleBackColor = true;
            this.buttonIBReset.Click += new System.EventHandler(this.buttonIBReset_Click);
            // 
            // buttonASSearch
            // 
            this.helpProviderLib.SetHelpKeyword(this.buttonASSearch, "Choose any one value or a combination of book deatils from the filters to know ab" +
        "out the book available to loan");
            this.buttonASSearch.Location = new System.Drawing.Point(172, 59);
            this.buttonASSearch.Name = "buttonASSearch";
            this.helpProviderLib.SetShowHelp(this.buttonASSearch, true);
            this.buttonASSearch.Size = new System.Drawing.Size(108, 39);
            this.buttonASSearch.TabIndex = 28;
            this.buttonASSearch.Text = "Search";
            this.buttonASSearch.UseVisualStyleBackColor = true;
            this.buttonASSearch.Click += new System.EventHandler(this.buttonASearch_Click);
            // 
            // buttonASReset
            // 
            this.helpProviderLib.SetHelpString(this.buttonASReset, "Click Reset button to clear the filtered search results");
            this.buttonASReset.Location = new System.Drawing.Point(625, 59);
            this.buttonASReset.Name = "buttonASReset";
            this.helpProviderLib.SetShowHelp(this.buttonASReset, true);
            this.buttonASReset.Size = new System.Drawing.Size(86, 39);
            this.buttonASReset.TabIndex = 29;
            this.buttonASReset.Text = "Reset";
            this.toolTipLib.SetToolTip(this.buttonASReset, "Click Reset to clear the previously selected filter values ");
            this.buttonASReset.UseVisualStyleBackColor = true;
            this.buttonASReset.Click += new System.EventHandler(this.buttonASReset_Click);
            // 
            // buttonASProceed
            // 
            this.helpProviderLib.SetHelpString(this.buttonASProceed, "Click Proceed, once a row is selected to populate the data in Issue book page");
            this.buttonASProceed.Location = new System.Drawing.Point(397, 397);
            this.buttonASProceed.Name = "buttonASProceed";
            this.helpProviderLib.SetShowHelp(this.buttonASProceed, true);
            this.buttonASProceed.Size = new System.Drawing.Size(229, 46);
            this.buttonASProceed.TabIndex = 30;
            this.buttonASProceed.Text = "Proceed to Issue Book";
            this.toolTipLib.SetToolTip(this.buttonASProceed, "Select the book row to be loaned and click this button to populate the value in I" +
        "ssue book tab");
            this.buttonASProceed.UseVisualStyleBackColor = true;
            this.buttonASProceed.Click += new System.EventHandler(this.buttonASProceed_Click);
            // 
            // tabControlMenus
            // 
            this.tabControlMenus.Controls.Add(this.Search);
            this.tabControlMenus.Controls.Add(this.AdvancedSearch);
            this.tabControlMenus.Controls.Add(this.IssueBook);
            this.tabControlMenus.Controls.Add(this.ReturnBook);
            this.tabControlMenus.Controls.Add(this.BookMaintain);
            this.tabControlMenus.Controls.Add(this.MemberMaintain);
            this.tabControlMenus.Controls.Add(this.Reports);
            this.tabControlMenus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProviderLib.SetHelpString(this.tabControlMenus, "Click the respective button to view reports");
            this.tabControlMenus.Location = new System.Drawing.Point(153, 70);
            this.tabControlMenus.Name = "tabControlMenus";
            this.tabControlMenus.SelectedIndex = 0;
            this.helpProviderLib.SetShowHelp(this.tabControlMenus, true);
            this.tabControlMenus.Size = new System.Drawing.Size(950, 480);
            this.tabControlMenus.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search.Controls.Add(this.buttonSProceed);
            this.Search.Controls.Add(this.buttonSReset);
            this.Search.Controls.Add(this.dataGridViewSSearch);
            this.Search.Controls.Add(this.buttonSSearch);
            this.Search.Controls.Add(this.comboBoxSSearchFilter);
            this.Search.Controls.Add(this.textBoxSSearchValue);
            this.Search.Controls.Add(this.labelSSearchValue);
            this.Search.Location = new System.Drawing.Point(4, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(942, 449);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.toolTipLib.SetToolTip(this.Search, "use ALT + S for shortcut ");
            this.Search.UseVisualStyleBackColor = true;
            // 
            // buttonSProceed
            // 
            this.buttonSProceed.Location = new System.Drawing.Point(399, 389);
            this.buttonSProceed.Name = "buttonSProceed";
            this.buttonSProceed.Size = new System.Drawing.Size(223, 46);
            this.buttonSProceed.TabIndex = 28;
            this.buttonSProceed.Text = "Proceed to Issue Book";
            this.toolTipLib.SetToolTip(this.buttonSProceed, "Select the book row to be loaned and click this button to populate the value in I" +
        "ssue book tab");
            this.buttonSProceed.UseVisualStyleBackColor = true;
            this.buttonSProceed.Click += new System.EventHandler(this.buttonSProceed_Click);
            // 
            // buttonSReset
            // 
            this.buttonSReset.Location = new System.Drawing.Point(615, 50);
            this.buttonSReset.Name = "buttonSReset";
            this.buttonSReset.Size = new System.Drawing.Size(100, 35);
            this.buttonSReset.TabIndex = 27;
            this.buttonSReset.Text = "Reset";
            this.buttonSReset.UseVisualStyleBackColor = true;
            this.buttonSReset.Click += new System.EventHandler(this.buttonSReset_Click);
            // 
            // dataGridViewSSearch
            // 
            this.dataGridViewSSearch.AutoGenerateColumns = false;
            this.dataGridViewSSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn1,
            this.bookTitleDataGridViewTextBoxColumn1,
            this.bookTypeDataGridViewTextBoxColumn1,
            this.authorNameDataGridViewTextBoxColumn1,
            this.publisherDataGridViewTextBoxColumn1});
            this.dataGridViewSSearch.DataSource = this.booksBindingSource;
            this.dataGridViewSSearch.Location = new System.Drawing.Point(21, 102);
            this.dataGridViewSSearch.Name = "dataGridViewSSearch";
            this.dataGridViewSSearch.RowTemplate.Height = 24;
            this.dataGridViewSSearch.Size = new System.Drawing.Size(914, 281);
            this.dataGridViewSSearch.TabIndex = 26;
            // 
            // bookIDDataGridViewTextBoxColumn1
            // 
            this.bookIDDataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.Name = "bookIDDataGridViewTextBoxColumn1";
            this.bookIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookTitleDataGridViewTextBoxColumn1
            // 
            this.bookTitleDataGridViewTextBoxColumn1.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn1.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn1.Name = "bookTitleDataGridViewTextBoxColumn1";
            this.bookTitleDataGridViewTextBoxColumn1.Width = 200;
            // 
            // bookTypeDataGridViewTextBoxColumn1
            // 
            this.bookTypeDataGridViewTextBoxColumn1.DataPropertyName = "BookType";
            this.bookTypeDataGridViewTextBoxColumn1.HeaderText = "BookType";
            this.bookTypeDataGridViewTextBoxColumn1.Name = "bookTypeDataGridViewTextBoxColumn1";
            this.bookTypeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // authorNameDataGridViewTextBoxColumn1
            // 
            this.authorNameDataGridViewTextBoxColumn1.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn1.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn1.Name = "authorNameDataGridViewTextBoxColumn1";
            this.authorNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // publisherDataGridViewTextBoxColumn1
            // 
            this.publisherDataGridViewTextBoxColumn1.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.Name = "publisherDataGridViewTextBoxColumn1";
            this.publisherDataGridViewTextBoxColumn1.Width = 150;
            // 
            // buttonSSearch
            // 
            this.buttonSSearch.Location = new System.Drawing.Point(240, 53);
            this.buttonSSearch.Name = "buttonSSearch";
            this.buttonSSearch.Size = new System.Drawing.Size(89, 35);
            this.buttonSSearch.TabIndex = 25;
            this.buttonSSearch.Text = "Search";
            this.toolTipLib.SetToolTip(this.buttonSSearch, "Choose a filter and enter value to be searched");
            this.buttonSSearch.UseVisualStyleBackColor = true;
            this.buttonSSearch.Click += new System.EventHandler(this.buttonSSearch_Click);
            // 
            // comboBoxSSearchFilter
            // 
            this.comboBoxSSearchFilter.FormattingEnabled = true;
            this.comboBoxSSearchFilter.Items.AddRange(new object[] {
            "Book ID",
            "Book Title",
            "Book Type",
            "Author Name",
            "Publisher"});
            this.comboBoxSSearchFilter.Location = new System.Drawing.Point(21, 13);
            this.comboBoxSSearchFilter.Name = "comboBoxSSearchFilter";
            this.comboBoxSSearchFilter.Size = new System.Drawing.Size(364, 26);
            this.comboBoxSSearchFilter.TabIndex = 24;
            this.comboBoxSSearchFilter.Text = "Search Filter";
            // 
            // textBoxSSearchValue
            // 
            this.textBoxSSearchValue.Location = new System.Drawing.Point(711, 10);
            this.textBoxSSearchValue.Name = "textBoxSSearchValue";
            this.textBoxSSearchValue.Size = new System.Drawing.Size(194, 26);
            this.textBoxSSearchValue.TabIndex = 23;
            // 
            // labelSSearchValue
            // 
            this.labelSSearchValue.AutoSize = true;
            this.labelSSearchValue.Location = new System.Drawing.Point(584, 13);
            this.labelSSearchValue.Name = "labelSSearchValue";
            this.labelSSearchValue.Size = new System.Drawing.Size(103, 18);
            this.labelSSearchValue.TabIndex = 22;
            this.labelSSearchValue.Text = "Search Value";
            // 
            // AdvancedSearch
            // 
            this.AdvancedSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdvancedSearch.BackgroundImage")));
            this.AdvancedSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdvancedSearch.Controls.Add(this.buttonASProceed);
            this.AdvancedSearch.Controls.Add(this.buttonASReset);
            this.AdvancedSearch.Controls.Add(this.buttonASSearch);
            this.AdvancedSearch.Controls.Add(this.comboBoxBookID);
            this.AdvancedSearch.Controls.Add(this.comboBoxPublisher);
            this.AdvancedSearch.Controls.Add(this.comboBoxBookType);
            this.AdvancedSearch.Controls.Add(this.comboBoxAuthorName);
            this.AdvancedSearch.Controls.Add(this.comboBoxBookTitle);
            this.AdvancedSearch.Controls.Add(this.dataGridViewSearch);
            this.AdvancedSearch.Location = new System.Drawing.Point(4, 27);
            this.AdvancedSearch.Name = "AdvancedSearch";
            this.AdvancedSearch.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedSearch.Size = new System.Drawing.Size(942, 449);
            this.AdvancedSearch.TabIndex = 0;
            this.AdvancedSearch.Text = "Advanced Search";
            this.toolTipLib.SetToolTip(this.AdvancedSearch, "use ALT + A for shortcut");
            this.AdvancedSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxBookID
            // 
            this.comboBoxBookID.FormattingEnabled = true;
            this.comboBoxBookID.Location = new System.Drawing.Point(17, 20);
            this.comboBoxBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBookID.Name = "comboBoxBookID";
            this.comboBoxBookID.Size = new System.Drawing.Size(95, 26);
            this.comboBoxBookID.TabIndex = 27;
            this.comboBoxBookID.Text = "Book ID";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(765, 19);
            this.comboBoxPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(158, 26);
            this.comboBoxPublisher.TabIndex = 25;
            this.comboBoxPublisher.Text = "Publisher";
            // 
            // comboBoxBookType
            // 
            this.comboBoxBookType.FormattingEnabled = true;
            this.comboBoxBookType.Location = new System.Drawing.Point(418, 19);
            this.comboBoxBookType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBookType.Name = "comboBoxBookType";
            this.comboBoxBookType.Size = new System.Drawing.Size(162, 26);
            this.comboBoxBookType.TabIndex = 24;
            this.comboBoxBookType.Text = "Book Type";
            // 
            // comboBoxAuthorName
            // 
            this.comboBoxAuthorName.FormattingEnabled = true;
            this.comboBoxAuthorName.Location = new System.Drawing.Point(586, 19);
            this.comboBoxAuthorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAuthorName.Name = "comboBoxAuthorName";
            this.comboBoxAuthorName.Size = new System.Drawing.Size(173, 26);
            this.comboBoxAuthorName.TabIndex = 23;
            this.comboBoxAuthorName.Text = "Author Name";
            // 
            // comboBoxBookTitle
            // 
            this.comboBoxBookTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBookTitle.FormattingEnabled = true;
            this.comboBoxBookTitle.Location = new System.Drawing.Point(118, 20);
            this.comboBoxBookTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBookTitle.Name = "comboBoxBookTitle";
            this.comboBoxBookTitle.Size = new System.Drawing.Size(294, 26);
            this.comboBoxBookTitle.TabIndex = 22;
            this.comboBoxBookTitle.Text = "Book Title";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AutoGenerateColumns = false;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookTypeDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.dataGridViewSearch.DataSource = this.booksBindingSource;
            this.dataGridViewSearch.Location = new System.Drawing.Point(19, 106);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(904, 285);
            this.dataGridViewSearch.TabIndex = 21;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.Width = 220;
            // 
            // bookTypeDataGridViewTextBoxColumn
            // 
            this.bookTypeDataGridViewTextBoxColumn.DataPropertyName = "BookType";
            this.bookTypeDataGridViewTextBoxColumn.HeaderText = "BookType";
            this.bookTypeDataGridViewTextBoxColumn.Name = "bookTypeDataGridViewTextBoxColumn";
            this.bookTypeDataGridViewTextBoxColumn.Width = 110;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 150;
            // 
            // IssueBook
            // 
            this.IssueBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IssueBook.BackgroundImage")));
            this.IssueBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IssueBook.Controls.Add(this.buttonIBIssue);
            this.IssueBook.Controls.Add(this.buttonIBReset);
            this.IssueBook.Controls.Add(this.buttonIBBookBrowse);
            this.IssueBook.Controls.Add(this.buttonIBMemBrowse);
            this.IssueBook.Controls.Add(this.textBoxIBBookID);
            this.IssueBook.Controls.Add(this.textBoxIBBookTitle);
            this.IssueBook.Controls.Add(this.textBoxIBDueDate);
            this.IssueBook.Controls.Add(this.textBoxIBRemarks);
            this.IssueBook.Controls.Add(this.textBoxIBIssueDate);
            this.IssueBook.Controls.Add(this.textBoxIBMemName);
            this.IssueBook.Controls.Add(this.textBoxIBMemID);
            this.IssueBook.Controls.Add(this.labelIBRemarks);
            this.IssueBook.Controls.Add(this.labelIBDueDate);
            this.IssueBook.Controls.Add(this.labelIBIssueDate);
            this.IssueBook.Controls.Add(this.labelIBBookID);
            this.IssueBook.Controls.Add(this.labelIBMemID);
            this.IssueBook.Location = new System.Drawing.Point(4, 27);
            this.IssueBook.Name = "IssueBook";
            this.IssueBook.Padding = new System.Windows.Forms.Padding(3);
            this.IssueBook.Size = new System.Drawing.Size(942, 449);
            this.IssueBook.TabIndex = 1;
            this.IssueBook.Text = "Issue Book";
            this.toolTipLib.SetToolTip(this.IssueBook, "use ALT + I for shortcut");
            this.IssueBook.UseVisualStyleBackColor = true;
            this.IssueBook.MouseHover += new System.EventHandler(this.IssueBook_MouseHover);
            // 
            // buttonIBIssue
            // 
            this.buttonIBIssue.Location = new System.Drawing.Point(207, 369);
            this.buttonIBIssue.Name = "buttonIBIssue";
            this.buttonIBIssue.Size = new System.Drawing.Size(124, 43);
            this.buttonIBIssue.TabIndex = 15;
            this.buttonIBIssue.Text = "Issue Book";
            this.toolTipLib.SetToolTip(this.buttonIBIssue, "Click here after selecting the necessary details to update transaction in databas" +
        "e");
            this.buttonIBIssue.UseVisualStyleBackColor = true;
            this.buttonIBIssue.Click += new System.EventHandler(this.buttonIBIssue_Click);
            // 
            // textBoxIBBookID
            // 
            this.textBoxIBBookID.Location = new System.Drawing.Point(290, 116);
            this.textBoxIBBookID.Name = "textBoxIBBookID";
            this.textBoxIBBookID.ReadOnly = true;
            this.textBoxIBBookID.Size = new System.Drawing.Size(167, 26);
            this.textBoxIBBookID.TabIndex = 11;
            // 
            // textBoxIBBookTitle
            // 
            this.textBoxIBBookTitle.Location = new System.Drawing.Point(290, 159);
            this.textBoxIBBookTitle.Name = "textBoxIBBookTitle";
            this.textBoxIBBookTitle.ReadOnly = true;
            this.textBoxIBBookTitle.Size = new System.Drawing.Size(264, 26);
            this.textBoxIBBookTitle.TabIndex = 10;
            // 
            // textBoxIBRemarks
            // 
            this.textBoxIBRemarks.Location = new System.Drawing.Point(290, 307);
            this.textBoxIBRemarks.Name = "textBoxIBRemarks";
            this.textBoxIBRemarks.Size = new System.Drawing.Size(264, 26);
            this.textBoxIBRemarks.TabIndex = 8;
            // 
            // textBoxIBIssueDate
            // 
            this.textBoxIBIssueDate.Location = new System.Drawing.Point(290, 205);
            this.textBoxIBIssueDate.Name = "textBoxIBIssueDate";
            this.textBoxIBIssueDate.ReadOnly = true;
            this.textBoxIBIssueDate.Size = new System.Drawing.Size(264, 26);
            this.textBoxIBIssueDate.TabIndex = 7;
            // 
            // textBoxIBMemName
            // 
            this.textBoxIBMemName.Location = new System.Drawing.Point(290, 63);
            this.textBoxIBMemName.Name = "textBoxIBMemName";
            this.textBoxIBMemName.ReadOnly = true;
            this.textBoxIBMemName.Size = new System.Drawing.Size(264, 26);
            this.textBoxIBMemName.TabIndex = 6;
            // 
            // textBoxIBMemID
            // 
            this.textBoxIBMemID.Location = new System.Drawing.Point(290, 20);
            this.textBoxIBMemID.Name = "textBoxIBMemID";
            this.textBoxIBMemID.ReadOnly = true;
            this.textBoxIBMemID.Size = new System.Drawing.Size(167, 26);
            this.textBoxIBMemID.TabIndex = 5;
            // 
            // labelIBRemarks
            // 
            this.labelIBRemarks.AutoSize = true;
            this.labelIBRemarks.Location = new System.Drawing.Point(171, 315);
            this.labelIBRemarks.Name = "labelIBRemarks";
            this.labelIBRemarks.Size = new System.Drawing.Size(74, 18);
            this.labelIBRemarks.TabIndex = 4;
            this.labelIBRemarks.Text = "Remarks";
            // 
            // labelIBDueDate
            // 
            this.labelIBDueDate.AutoSize = true;
            this.labelIBDueDate.Location = new System.Drawing.Point(167, 267);
            this.labelIBDueDate.Name = "labelIBDueDate";
            this.labelIBDueDate.Size = new System.Drawing.Size(77, 18);
            this.labelIBDueDate.TabIndex = 3;
            this.labelIBDueDate.Text = "Due Date";
            // 
            // labelIBIssueDate
            // 
            this.labelIBIssueDate.AutoSize = true;
            this.labelIBIssueDate.Location = new System.Drawing.Point(157, 213);
            this.labelIBIssueDate.Name = "labelIBIssueDate";
            this.labelIBIssueDate.Size = new System.Drawing.Size(87, 18);
            this.labelIBIssueDate.TabIndex = 2;
            this.labelIBIssueDate.Text = "Issue Date";
            // 
            // labelIBBookID
            // 
            this.labelIBBookID.AutoSize = true;
            this.labelIBBookID.Location = new System.Drawing.Point(176, 124);
            this.labelIBBookID.Name = "labelIBBookID";
            this.labelIBBookID.Size = new System.Drawing.Size(68, 18);
            this.labelIBBookID.TabIndex = 1;
            this.labelIBBookID.Text = "Book ID";
            // 
            // labelIBMemID
            // 
            this.labelIBMemID.AutoSize = true;
            this.labelIBMemID.Location = new System.Drawing.Point(154, 23);
            this.labelIBMemID.Name = "labelIBMemID";
            this.labelIBMemID.Size = new System.Drawing.Size(90, 18);
            this.labelIBMemID.TabIndex = 0;
            this.labelIBMemID.Text = "Member ID";
            // 
            // BookMaintain
            // 
            this.BookMaintain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookMaintain.BackgroundImage")));
            this.BookMaintain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookMaintain.Controls.Add(this.buttonBMAuthorBrowse);
            this.BookMaintain.Controls.Add(this.buttonBMAdd);
            this.BookMaintain.Controls.Add(this.buttonBMUpdate);
            this.BookMaintain.Controls.Add(this.buttonBMRemove);
            this.BookMaintain.Controls.Add(this.buttonBMNext);
            this.BookMaintain.Controls.Add(this.buttonBMFirst);
            this.BookMaintain.Controls.Add(this.buttonBMLast);
            this.BookMaintain.Controls.Add(this.buttonBMLoad);
            this.BookMaintain.Controls.Add(this.buttonBMReset);
            this.BookMaintain.Controls.Add(this.buttonBMPrevious);
            this.BookMaintain.Controls.Add(this.textBoxBMBookTitle);
            this.BookMaintain.Controls.Add(this.textBoxBMAuthorName);
            this.BookMaintain.Controls.Add(this.textBoxBMPublisher);
            this.BookMaintain.Controls.Add(this.textBoxBMTotalStock);
            this.BookMaintain.Controls.Add(this.textBoxBMBookID);
            this.BookMaintain.Controls.Add(this.labelBMTotalStock);
            this.BookMaintain.Controls.Add(this.labelBMPublisher);
            this.BookMaintain.Controls.Add(this.labelBMAuthorName);
            this.BookMaintain.Controls.Add(this.labelBMBookTitle);
            this.BookMaintain.Controls.Add(this.labelBMBookID);
            this.BookMaintain.Location = new System.Drawing.Point(4, 27);
            this.BookMaintain.Name = "BookMaintain";
            this.BookMaintain.Size = new System.Drawing.Size(942, 449);
            this.BookMaintain.TabIndex = 3;
            this.BookMaintain.Text = "Book Maintanence";
            this.toolTipLib.SetToolTip(this.BookMaintain, "use ALT + B for shortcut");
            this.BookMaintain.UseVisualStyleBackColor = true;
            // 
            // buttonBMAdd
            // 
            this.buttonBMAdd.Location = new System.Drawing.Point(192, 280);
            this.buttonBMAdd.Name = "buttonBMAdd";
            this.buttonBMAdd.Size = new System.Drawing.Size(114, 53);
            this.buttonBMAdd.TabIndex = 18;
            this.buttonBMAdd.Text = "Add book";
            this.buttonBMAdd.UseVisualStyleBackColor = true;
            this.buttonBMAdd.Click += new System.EventHandler(this.buttonBMAdd_Click);
            // 
            // buttonBMUpdate
            // 
            this.buttonBMUpdate.Location = new System.Drawing.Point(361, 280);
            this.buttonBMUpdate.Name = "buttonBMUpdate";
            this.buttonBMUpdate.Size = new System.Drawing.Size(184, 53);
            this.buttonBMUpdate.TabIndex = 17;
            this.buttonBMUpdate.Text = "Update existing book";
            this.buttonBMUpdate.UseVisualStyleBackColor = true;
            this.buttonBMUpdate.Click += new System.EventHandler(this.buttonBMUpdate_Click);
            // 
            // buttonBMRemove
            // 
            this.buttonBMRemove.Location = new System.Drawing.Point(589, 280);
            this.buttonBMRemove.Name = "buttonBMRemove";
            this.buttonBMRemove.Size = new System.Drawing.Size(140, 53);
            this.buttonBMRemove.TabIndex = 16;
            this.buttonBMRemove.Text = "Remove book";
            this.buttonBMRemove.UseVisualStyleBackColor = true;
            this.buttonBMRemove.Click += new System.EventHandler(this.buttonBMRemove_Click);
            // 
            // buttonBMNext
            // 
            this.buttonBMNext.Location = new System.Drawing.Point(787, 289);
            this.buttonBMNext.Name = "buttonBMNext";
            this.buttonBMNext.Size = new System.Drawing.Size(51, 34);
            this.buttonBMNext.TabIndex = 15;
            this.buttonBMNext.Text = ">";
            this.toolTipLib.SetToolTip(this.buttonBMNext, "Fill data of the next book record");
            this.buttonBMNext.UseVisualStyleBackColor = true;
            this.buttonBMNext.Click += new System.EventHandler(this.buttonBMNext_Click);
            // 
            // buttonBMFirst
            // 
            this.buttonBMFirst.Location = new System.Drawing.Point(79, 369);
            this.buttonBMFirst.Name = "buttonBMFirst";
            this.buttonBMFirst.Size = new System.Drawing.Size(48, 32);
            this.buttonBMFirst.TabIndex = 14;
            this.buttonBMFirst.Text = "<<";
            this.toolTipLib.SetToolTip(this.buttonBMFirst, "Fill data of the first book record");
            this.buttonBMFirst.UseVisualStyleBackColor = true;
            this.buttonBMFirst.Click += new System.EventHandler(this.buttonBMFirst_Click);
            // 
            // buttonBMLast
            // 
            this.buttonBMLast.Location = new System.Drawing.Point(787, 369);
            this.buttonBMLast.Name = "buttonBMLast";
            this.buttonBMLast.Size = new System.Drawing.Size(51, 32);
            this.buttonBMLast.TabIndex = 13;
            this.buttonBMLast.Text = ">>";
            this.toolTipLib.SetToolTip(this.buttonBMLast, "Fill data of the last book record");
            this.buttonBMLast.UseVisualStyleBackColor = true;
            this.buttonBMLast.Click += new System.EventHandler(this.buttonBMLast_Click);
            // 
            // buttonBMLoad
            // 
            this.buttonBMLoad.Location = new System.Drawing.Point(285, 369);
            this.buttonBMLoad.Name = "buttonBMLoad";
            this.buttonBMLoad.Size = new System.Drawing.Size(89, 40);
            this.buttonBMLoad.TabIndex = 12;
            this.buttonBMLoad.Text = "Load";
            this.toolTipLib.SetToolTip(this.buttonBMLoad, "Click to load book details");
            this.buttonBMLoad.UseVisualStyleBackColor = true;
            this.buttonBMLoad.Click += new System.EventHandler(this.buttonBMLoad_Click);
            // 
            // buttonBMReset
            // 
            this.buttonBMReset.Location = new System.Drawing.Point(518, 369);
            this.buttonBMReset.Name = "buttonBMReset";
            this.buttonBMReset.Size = new System.Drawing.Size(102, 40);
            this.buttonBMReset.TabIndex = 11;
            this.buttonBMReset.Text = "Reset";
            this.toolTipLib.SetToolTip(this.buttonBMReset, "Reset data after every other operation");
            this.buttonBMReset.UseVisualStyleBackColor = true;
            this.buttonBMReset.Click += new System.EventHandler(this.buttonBMReset_Click);
            // 
            // buttonBMPrevious
            // 
            this.buttonBMPrevious.Location = new System.Drawing.Point(79, 289);
            this.buttonBMPrevious.Name = "buttonBMPrevious";
            this.buttonBMPrevious.Size = new System.Drawing.Size(48, 34);
            this.buttonBMPrevious.TabIndex = 10;
            this.buttonBMPrevious.Text = "<";
            this.toolTipLib.SetToolTip(this.buttonBMPrevious, "Fill data of the previous book record");
            this.buttonBMPrevious.UseVisualStyleBackColor = true;
            this.buttonBMPrevious.Click += new System.EventHandler(this.buttonBMPrevious_Click);
            // 
            // textBoxBMBookTitle
            // 
            this.textBoxBMBookTitle.Location = new System.Drawing.Point(378, 78);
            this.textBoxBMBookTitle.Name = "textBoxBMBookTitle";
            this.textBoxBMBookTitle.Size = new System.Drawing.Size(308, 26);
            this.textBoxBMBookTitle.TabIndex = 9;
            // 
            // textBoxBMAuthorName
            // 
            this.textBoxBMAuthorName.Location = new System.Drawing.Point(378, 126);
            this.textBoxBMAuthorName.Name = "textBoxBMAuthorName";
            this.textBoxBMAuthorName.Size = new System.Drawing.Size(247, 26);
            this.textBoxBMAuthorName.TabIndex = 8;
            // 
            // textBoxBMPublisher
            // 
            this.textBoxBMPublisher.Location = new System.Drawing.Point(378, 169);
            this.textBoxBMPublisher.Name = "textBoxBMPublisher";
            this.textBoxBMPublisher.Size = new System.Drawing.Size(247, 26);
            this.textBoxBMPublisher.TabIndex = 7;
            // 
            // textBoxBMTotalStock
            // 
            this.textBoxBMTotalStock.Location = new System.Drawing.Point(378, 208);
            this.textBoxBMTotalStock.Name = "textBoxBMTotalStock";
            this.textBoxBMTotalStock.Size = new System.Drawing.Size(167, 26);
            this.textBoxBMTotalStock.TabIndex = 6;
            // 
            // textBoxBMBookID
            // 
            this.textBoxBMBookID.Location = new System.Drawing.Point(378, 35);
            this.textBoxBMBookID.Name = "textBoxBMBookID";
            this.textBoxBMBookID.ReadOnly = true;
            this.textBoxBMBookID.Size = new System.Drawing.Size(158, 26);
            this.textBoxBMBookID.TabIndex = 5;
            // 
            // labelBMTotalStock
            // 
            this.labelBMTotalStock.AutoSize = true;
            this.labelBMTotalStock.Location = new System.Drawing.Point(249, 211);
            this.labelBMTotalStock.Name = "labelBMTotalStock";
            this.labelBMTotalStock.Size = new System.Drawing.Size(91, 18);
            this.labelBMTotalStock.TabIndex = 4;
            this.labelBMTotalStock.Text = "Total Stock";
            // 
            // labelBMPublisher
            // 
            this.labelBMPublisher.AutoSize = true;
            this.labelBMPublisher.Location = new System.Drawing.Point(267, 174);
            this.labelBMPublisher.Name = "labelBMPublisher";
            this.labelBMPublisher.Size = new System.Drawing.Size(73, 18);
            this.labelBMPublisher.TabIndex = 3;
            this.labelBMPublisher.Text = "Publisher";
            // 
            // labelBMAuthorName
            // 
            this.labelBMAuthorName.AutoSize = true;
            this.labelBMAuthorName.Location = new System.Drawing.Point(233, 132);
            this.labelBMAuthorName.Name = "labelBMAuthorName";
            this.labelBMAuthorName.Size = new System.Drawing.Size(107, 18);
            this.labelBMAuthorName.TabIndex = 2;
            this.labelBMAuthorName.Text = "Author Name";
            // 
            // labelBMBookTitle
            // 
            this.labelBMBookTitle.AutoSize = true;
            this.labelBMBookTitle.Location = new System.Drawing.Point(258, 86);
            this.labelBMBookTitle.Name = "labelBMBookTitle";
            this.labelBMBookTitle.Size = new System.Drawing.Size(82, 18);
            this.labelBMBookTitle.TabIndex = 1;
            this.labelBMBookTitle.Text = "Book Title";
            // 
            // labelBMBookID
            // 
            this.labelBMBookID.AutoSize = true;
            this.labelBMBookID.Location = new System.Drawing.Point(272, 38);
            this.labelBMBookID.Name = "labelBMBookID";
            this.labelBMBookID.Size = new System.Drawing.Size(68, 18);
            this.labelBMBookID.TabIndex = 0;
            this.labelBMBookID.Text = "Book ID";
            // 
            // MemberMaintain
            // 
            this.MemberMaintain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MemberMaintain.BackgroundImage")));
            this.MemberMaintain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MemberMaintain.Controls.Add(this.maskedTextBoxMMPhone);
            this.MemberMaintain.Controls.Add(this.groupBoxMMFind);
            this.MemberMaintain.Controls.Add(this.buttonMMReset);
            this.MemberMaintain.Controls.Add(this.buttonMMLast);
            this.MemberMaintain.Controls.Add(this.buttonMMNext);
            this.MemberMaintain.Controls.Add(this.buttonMMDelete);
            this.MemberMaintain.Controls.Add(this.buttonMMAdd);
            this.MemberMaintain.Controls.Add(this.buttonMMUpdate);
            this.MemberMaintain.Controls.Add(this.buttonMMFirst);
            this.MemberMaintain.Controls.Add(this.buttonMMPrevious);
            this.MemberMaintain.Controls.Add(this.dateTimePickerMMDob);
            this.MemberMaintain.Controls.Add(this.textBoxMMCountry);
            this.MemberMaintain.Controls.Add(this.textBoxMMEmail);
            this.MemberMaintain.Controls.Add(this.textBoxMMConTitle);
            this.MemberMaintain.Controls.Add(this.textBoxMMMemName);
            this.MemberMaintain.Controls.Add(this.textBoxMMMemID);
            this.MemberMaintain.Controls.Add(this.labelMMCountry);
            this.MemberMaintain.Controls.Add(this.labelMMEmail);
            this.MemberMaintain.Controls.Add(this.labelMMPhone);
            this.MemberMaintain.Controls.Add(this.labelMMDob);
            this.MemberMaintain.Controls.Add(this.labelMMConTitle);
            this.MemberMaintain.Controls.Add(this.labelMMMemName);
            this.MemberMaintain.Controls.Add(this.labelMMMemID);
            this.MemberMaintain.Location = new System.Drawing.Point(4, 27);
            this.MemberMaintain.Name = "MemberMaintain";
            this.MemberMaintain.Size = new System.Drawing.Size(942, 449);
            this.MemberMaintain.TabIndex = 4;
            this.MemberMaintain.Text = " Member Maintanence";
            this.toolTipLib.SetToolTip(this.MemberMaintain, "use ALT + M for shortcut");
            this.MemberMaintain.UseVisualStyleBackColor = true;
            // 
            // groupBoxMMFind
            // 
            this.groupBoxMMFind.Controls.Add(this.buttonMMFind);
            this.groupBoxMMFind.Controls.Add(this.textBoxMMFind);
            this.groupBoxMMFind.Location = new System.Drawing.Point(151, 368);
            this.groupBoxMMFind.Name = "groupBoxMMFind";
            this.groupBoxMMFind.Size = new System.Drawing.Size(486, 80);
            this.groupBoxMMFind.TabIndex = 24;
            this.groupBoxMMFind.TabStop = false;
            // 
            // buttonMMFind
            // 
            this.buttonMMFind.Location = new System.Drawing.Point(300, 20);
            this.buttonMMFind.Name = "buttonMMFind";
            this.buttonMMFind.Size = new System.Drawing.Size(160, 45);
            this.buttonMMFind.TabIndex = 21;
            this.buttonMMFind.Text = "Find Member";
            this.toolTipLib.SetToolTip(this.buttonMMFind, "Search any member by their Member ID");
            this.buttonMMFind.UseVisualStyleBackColor = true;
            this.buttonMMFind.Click += new System.EventHandler(this.buttonMMFind_Click);
            // 
            // textBoxMMFind
            // 
            this.textBoxMMFind.Location = new System.Drawing.Point(32, 30);
            this.textBoxMMFind.Name = "textBoxMMFind";
            this.textBoxMMFind.Size = new System.Drawing.Size(236, 26);
            this.textBoxMMFind.TabIndex = 14;
            this.toolTipLib.SetToolTip(this.textBoxMMFind, "Enter member ID to search");
            // 
            // buttonMMReset
            // 
            this.buttonMMReset.Location = new System.Drawing.Point(686, 391);
            this.buttonMMReset.Name = "buttonMMReset";
            this.buttonMMReset.Size = new System.Drawing.Size(81, 36);
            this.buttonMMReset.TabIndex = 23;
            this.buttonMMReset.Text = "Reset";
            this.toolTipLib.SetToolTip(this.buttonMMReset, "Reset after every other operation");
            this.buttonMMReset.UseVisualStyleBackColor = true;
            this.buttonMMReset.Click += new System.EventHandler(this.buttonMMReset_Click);
            // 
            // buttonMMLast
            // 
            this.buttonMMLast.Location = new System.Drawing.Point(841, 396);
            this.buttonMMLast.Name = "buttonMMLast";
            this.buttonMMLast.Size = new System.Drawing.Size(44, 31);
            this.buttonMMLast.TabIndex = 22;
            this.buttonMMLast.Text = ">>";
            this.toolTipLib.SetToolTip(this.buttonMMLast, "Fill data of the last book record");
            this.buttonMMLast.UseVisualStyleBackColor = true;
            this.buttonMMLast.Click += new System.EventHandler(this.buttonMMLast_Click);
            // 
            // buttonMMNext
            // 
            this.buttonMMNext.Location = new System.Drawing.Point(841, 325);
            this.buttonMMNext.Name = "buttonMMNext";
            this.buttonMMNext.Size = new System.Drawing.Size(44, 36);
            this.buttonMMNext.TabIndex = 20;
            this.buttonMMNext.Text = ">";
            this.toolTipLib.SetToolTip(this.buttonMMNext, "Fill data of the next book record");
            this.buttonMMNext.UseVisualStyleBackColor = true;
            this.buttonMMNext.Click += new System.EventHandler(this.buttonMMNext_Click);
            // 
            // buttonMMDelete
            // 
            this.buttonMMDelete.Location = new System.Drawing.Point(603, 318);
            this.buttonMMDelete.Name = "buttonMMDelete";
            this.buttonMMDelete.Size = new System.Drawing.Size(204, 46);
            this.buttonMMDelete.TabIndex = 19;
            this.buttonMMDelete.Text = "Delete member record";
            this.buttonMMDelete.UseVisualStyleBackColor = true;
            this.buttonMMDelete.Click += new System.EventHandler(this.buttonMMDelete_Click);
            // 
            // buttonMMAdd
            // 
            this.buttonMMAdd.Location = new System.Drawing.Point(416, 318);
            this.buttonMMAdd.Name = "buttonMMAdd";
            this.buttonMMAdd.Size = new System.Drawing.Size(143, 46);
            this.buttonMMAdd.TabIndex = 18;
            this.buttonMMAdd.Text = "Add member";
            this.buttonMMAdd.UseVisualStyleBackColor = true;
            this.buttonMMAdd.Click += new System.EventHandler(this.buttonMMAdd_Click);
            // 
            // buttonMMUpdate
            // 
            this.buttonMMUpdate.Location = new System.Drawing.Point(151, 318);
            this.buttonMMUpdate.Name = "buttonMMUpdate";
            this.buttonMMUpdate.Size = new System.Drawing.Size(216, 46);
            this.buttonMMUpdate.TabIndex = 17;
            this.buttonMMUpdate.Text = "Update member details";
            this.buttonMMUpdate.UseVisualStyleBackColor = true;
            this.buttonMMUpdate.Click += new System.EventHandler(this.buttonMMUpdate_Click);
            // 
            // buttonMMFirst
            // 
            this.buttonMMFirst.Location = new System.Drawing.Point(52, 391);
            this.buttonMMFirst.Name = "buttonMMFirst";
            this.buttonMMFirst.Size = new System.Drawing.Size(51, 32);
            this.buttonMMFirst.TabIndex = 16;
            this.buttonMMFirst.Text = "<<";
            this.toolTipLib.SetToolTip(this.buttonMMFirst, "Fill data of the first book record");
            this.buttonMMFirst.UseVisualStyleBackColor = true;
            this.buttonMMFirst.Click += new System.EventHandler(this.buttonMMFirst_Click);
            // 
            // buttonMMPrevious
            // 
            this.buttonMMPrevious.Location = new System.Drawing.Point(52, 324);
            this.buttonMMPrevious.Name = "buttonMMPrevious";
            this.buttonMMPrevious.Size = new System.Drawing.Size(51, 36);
            this.buttonMMPrevious.TabIndex = 15;
            this.buttonMMPrevious.Text = "<";
            this.toolTipLib.SetToolTip(this.buttonMMPrevious, "Fill data of the previous book record");
            this.buttonMMPrevious.UseVisualStyleBackColor = true;
            this.buttonMMPrevious.Click += new System.EventHandler(this.buttonMMPrevious_Click);
            // 
            // dateTimePickerMMDob
            // 
            this.dateTimePickerMMDob.Location = new System.Drawing.Point(373, 151);
            this.dateTimePickerMMDob.MaxDate = new System.DateTime(2018, 9, 29, 22, 0, 33, 0);
            this.dateTimePickerMMDob.Name = "dateTimePickerMMDob";
            this.dateTimePickerMMDob.Size = new System.Drawing.Size(285, 26);
            this.dateTimePickerMMDob.TabIndex = 12;
            this.dateTimePickerMMDob.Value = new System.DateTime(2018, 9, 29, 0, 0, 0, 0);
            // 
            // textBoxMMCountry
            // 
            this.textBoxMMCountry.Location = new System.Drawing.Point(374, 274);
            this.textBoxMMCountry.Name = "textBoxMMCountry";
            this.textBoxMMCountry.Size = new System.Drawing.Size(199, 26);
            this.textBoxMMCountry.TabIndex = 11;
            // 
            // textBoxMMEmail
            // 
            this.textBoxMMEmail.Location = new System.Drawing.Point(374, 232);
            this.textBoxMMEmail.Name = "textBoxMMEmail";
            this.textBoxMMEmail.Size = new System.Drawing.Size(199, 26);
            this.textBoxMMEmail.TabIndex = 10;
            // 
            // textBoxMMConTitle
            // 
            this.textBoxMMConTitle.Location = new System.Drawing.Point(374, 110);
            this.textBoxMMConTitle.Name = "textBoxMMConTitle";
            this.textBoxMMConTitle.Size = new System.Drawing.Size(120, 26);
            this.textBoxMMConTitle.TabIndex = 9;
            // 
            // textBoxMMMemName
            // 
            this.textBoxMMMemName.Location = new System.Drawing.Point(374, 66);
            this.textBoxMMMemName.Name = "textBoxMMMemName";
            this.textBoxMMMemName.Size = new System.Drawing.Size(199, 26);
            this.textBoxMMMemName.TabIndex = 8;
            // 
            // textBoxMMMemID
            // 
            this.textBoxMMMemID.Location = new System.Drawing.Point(372, 22);
            this.textBoxMMMemID.Name = "textBoxMMMemID";
            this.textBoxMMMemID.Size = new System.Drawing.Size(142, 26);
            this.textBoxMMMemID.TabIndex = 7;
            // 
            // labelMMCountry
            // 
            this.labelMMCountry.AutoSize = true;
            this.labelMMCountry.Location = new System.Drawing.Point(277, 279);
            this.labelMMCountry.Name = "labelMMCountry";
            this.labelMMCountry.Size = new System.Drawing.Size(68, 18);
            this.labelMMCountry.TabIndex = 6;
            this.labelMMCountry.Text = "Country";
            // 
            // labelMMEmail
            // 
            this.labelMMEmail.AutoSize = true;
            this.labelMMEmail.Location = new System.Drawing.Point(242, 237);
            this.labelMMEmail.Name = "labelMMEmail";
            this.labelMMEmail.Size = new System.Drawing.Size(110, 18);
            this.labelMMEmail.TabIndex = 5;
            this.labelMMEmail.Text = "Email address";
            // 
            // labelMMPhone
            // 
            this.labelMMPhone.AutoSize = true;
            this.labelMMPhone.Location = new System.Drawing.Point(236, 195);
            this.labelMMPhone.Name = "labelMMPhone";
            this.labelMMPhone.Size = new System.Drawing.Size(116, 18);
            this.labelMMPhone.TabIndex = 4;
            this.labelMMPhone.Text = "Phone number";
            // 
            // labelMMDob
            // 
            this.labelMMDob.AutoSize = true;
            this.labelMMDob.Location = new System.Drawing.Point(244, 156);
            this.labelMMDob.Name = "labelMMDob";
            this.labelMMDob.Size = new System.Drawing.Size(101, 18);
            this.labelMMDob.TabIndex = 3;
            this.labelMMDob.Text = "Date of birth";
            // 
            // labelMMConTitle
            // 
            this.labelMMConTitle.AutoSize = true;
            this.labelMMConTitle.Location = new System.Drawing.Point(244, 114);
            this.labelMMConTitle.Name = "labelMMConTitle";
            this.labelMMConTitle.Size = new System.Drawing.Size(102, 18);
            this.labelMMConTitle.TabIndex = 2;
            this.labelMMConTitle.Text = "Contact Title";
            // 
            // labelMMMemName
            // 
            this.labelMMMemName.AutoSize = true;
            this.labelMMMemName.Location = new System.Drawing.Point(230, 71);
            this.labelMMMemName.Name = "labelMMMemName";
            this.labelMMMemName.Size = new System.Drawing.Size(118, 18);
            this.labelMMMemName.TabIndex = 1;
            this.labelMMMemName.Text = "Member Name";
            // 
            // labelMMMemID
            // 
            this.labelMMMemID.AutoSize = true;
            this.labelMMMemID.Location = new System.Drawing.Point(258, 22);
            this.labelMMMemID.Name = "labelMMMemID";
            this.labelMMMemID.Size = new System.Drawing.Size(90, 18);
            this.labelMMMemID.TabIndex = 0;
            this.labelMMMemID.Text = "Member ID";
            // 
            // Reports
            // 
            this.Reports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reports.BackgroundImage")));
            this.Reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reports.Controls.Add(this.buttonRTransactionHistory);
            this.Reports.Controls.Add(this.buttonRMonthlyStats);
            this.Reports.Controls.Add(this.buttonBorrowersdemographics);
            this.Reports.Controls.Add(this.buttonRBooksStockDetails);
            this.Reports.Location = new System.Drawing.Point(4, 27);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(942, 449);
            this.Reports.TabIndex = 5;
            this.Reports.Text = "Reports";
            this.toolTipLib.SetToolTip(this.Reports, "use ALT + R for shortcut");
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // buttonRTransactionHistory
            // 
            this.buttonRTransactionHistory.Location = new System.Drawing.Point(514, 252);
            this.buttonRTransactionHistory.Name = "buttonRTransactionHistory";
            this.buttonRTransactionHistory.Size = new System.Drawing.Size(150, 59);
            this.buttonRTransactionHistory.TabIndex = 5;
            this.buttonRTransactionHistory.Text = "Transaction History";
            this.buttonRTransactionHistory.UseVisualStyleBackColor = true;
            this.buttonRTransactionHistory.Click += new System.EventHandler(this.buttonRTransactionHistory_Click);
            // 
            // buttonRMonthlyStats
            // 
            this.buttonRMonthlyStats.Location = new System.Drawing.Point(250, 251);
            this.buttonRMonthlyStats.Name = "buttonRMonthlyStats";
            this.buttonRMonthlyStats.Size = new System.Drawing.Size(157, 60);
            this.buttonRMonthlyStats.TabIndex = 4;
            this.buttonRMonthlyStats.Text = "Monthly Stats";
            this.buttonRMonthlyStats.UseVisualStyleBackColor = true;
            this.buttonRMonthlyStats.Click += new System.EventHandler(this.buttonRMonthlyStats_Click);
            // 
            // buttonBorrowersdemographics
            // 
            this.buttonBorrowersdemographics.Location = new System.Drawing.Point(514, 108);
            this.buttonBorrowersdemographics.Name = "buttonBorrowersdemographics";
            this.buttonBorrowersdemographics.Size = new System.Drawing.Size(150, 63);
            this.buttonBorrowersdemographics.TabIndex = 2;
            this.buttonBorrowersdemographics.Text = "Borrowers Demographics";
            this.buttonBorrowersdemographics.UseVisualStyleBackColor = true;
            this.buttonBorrowersdemographics.Click += new System.EventHandler(this.buttonBorrowersdemographics_Click);
            // 
            // buttonRBooksStockDetails
            // 
            this.buttonRBooksStockDetails.Location = new System.Drawing.Point(250, 108);
            this.buttonRBooksStockDetails.Name = "buttonRBooksStockDetails";
            this.buttonRBooksStockDetails.Size = new System.Drawing.Size(157, 63);
            this.buttonRBooksStockDetails.TabIndex = 0;
            this.buttonRBooksStockDetails.Text = "Books Stock Details";
            this.buttonRBooksStockDetails.UseVisualStyleBackColor = true;
            this.buttonRBooksStockDetails.Click += new System.EventHandler(this.buttonRBooksStockDetails_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // toolTipLib
            // 
            this.toolTipLib.ShowAlways = true;
            // 
            // issueTransTableAdapter
            // 
            this.issueTransTableAdapter.ClearBeforeFill = true;
            // 
            // LibraryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 586);
            this.Controls.Add(this.progressBarLib);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.tabControlMenus);
            this.Controls.Add(this.labelTitle);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryScreen";
            this.Text = "SA47_Team12aCAProject Management System";
            this.Load += new System.EventHandler(this.LibraryScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LibraryScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA47_Team12bDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueTransBindingSource)).EndInit();
            this.ReturnBook.ResumeLayout(false);
            this.ReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBook)).EndInit();
            this.tabControlMenus.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSearch)).EndInit();
            this.AdvancedSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.IssueBook.ResumeLayout(false);
            this.IssueBook.PerformLayout();
            this.BookMaintain.ResumeLayout(false);
            this.BookMaintain.PerformLayout();
            this.MemberMaintain.ResumeLayout(false);
            this.MemberMaintain.PerformLayout();
            this.groupBoxMMFind.ResumeLayout(false);
            this.groupBoxMMFind.PerformLayout();
            this.Reports.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.ProgressBar progressBarLib;
        private System.Windows.Forms.HelpProvider helpProviderLib;
        private SA47_Team12bDataSet sA47_Team12bDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private SA47_Team12bDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.ToolTip toolTipLib;
        private System.Windows.Forms.BindingSource issueTransBindingSource;
        private SA47_Team12bDataSetTableAdapters.IssueTransTableAdapter issueTransTableAdapter;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.Button buttonRTransactionHistory;
        private System.Windows.Forms.Button buttonRMonthlyStats;
        private System.Windows.Forms.Button buttonBorrowersdemographics;
        private System.Windows.Forms.Button buttonRBooksStockDetails;
        private System.Windows.Forms.TabPage MemberMaintain;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMMPhone;
        private System.Windows.Forms.GroupBox groupBoxMMFind;
        private System.Windows.Forms.Button buttonMMFind;
        private System.Windows.Forms.TextBox textBoxMMFind;
        private System.Windows.Forms.Button buttonMMReset;
        private System.Windows.Forms.Button buttonMMLast;
        private System.Windows.Forms.Button buttonMMNext;
        private System.Windows.Forms.Button buttonMMDelete;
        private System.Windows.Forms.Button buttonMMAdd;
        private System.Windows.Forms.Button buttonMMUpdate;
        private System.Windows.Forms.Button buttonMMFirst;
        private System.Windows.Forms.Button buttonMMPrevious;
        private System.Windows.Forms.DateTimePicker dateTimePickerMMDob;
        private System.Windows.Forms.TextBox textBoxMMCountry;
        private System.Windows.Forms.TextBox textBoxMMEmail;
        private System.Windows.Forms.TextBox textBoxMMConTitle;
        private System.Windows.Forms.TextBox textBoxMMMemName;
        private System.Windows.Forms.TextBox textBoxMMMemID;
        private System.Windows.Forms.Label labelMMCountry;
        private System.Windows.Forms.Label labelMMEmail;
        private System.Windows.Forms.Label labelMMPhone;
        private System.Windows.Forms.Label labelMMDob;
        private System.Windows.Forms.Label labelMMConTitle;
        private System.Windows.Forms.Label labelMMMemName;
        private System.Windows.Forms.Label labelMMMemID;
        private System.Windows.Forms.TabPage BookMaintain;
        private System.Windows.Forms.Button buttonBMAuthorBrowse;
        private System.Windows.Forms.Button buttonBMAdd;
        private System.Windows.Forms.Button buttonBMUpdate;
        private System.Windows.Forms.Button buttonBMRemove;
        private System.Windows.Forms.Button buttonBMNext;
        private System.Windows.Forms.Button buttonBMFirst;
        private System.Windows.Forms.Button buttonBMLast;
        private System.Windows.Forms.Button buttonBMLoad;
        private System.Windows.Forms.Button buttonBMReset;
        private System.Windows.Forms.Button buttonBMPrevious;
        private System.Windows.Forms.TextBox textBoxBMBookTitle;
        private System.Windows.Forms.TextBox textBoxBMAuthorName;
        private System.Windows.Forms.TextBox textBoxBMPublisher;
        private System.Windows.Forms.TextBox textBoxBMTotalStock;
        private System.Windows.Forms.TextBox textBoxBMBookID;
        private System.Windows.Forms.Label labelBMTotalStock;
        private System.Windows.Forms.Label labelBMPublisher;
        private System.Windows.Forms.Label labelBMAuthorName;
        private System.Windows.Forms.Label labelBMBookTitle;
        private System.Windows.Forms.Label labelBMBookID;
        private System.Windows.Forms.TabPage ReturnBook;
        private System.Windows.Forms.DataGridView dataGridViewReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualReturnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRBRenew;
        private System.Windows.Forms.Button buttonRBReturn;
        private System.Windows.Forms.Button buttonRBSearchTrans;
        private System.Windows.Forms.Button buttonRBBookBrowse;
        private System.Windows.Forms.Button buttonRBMemBrowse;
        private System.Windows.Forms.TextBox textBoxRBBookID;
        private System.Windows.Forms.TextBox textBoxRBMemName;
        private System.Windows.Forms.TextBox textBoxRBBookTitle;
        private System.Windows.Forms.TextBox textBoxRBMemID;
        private System.Windows.Forms.Label labelRBBookID;
        private System.Windows.Forms.Label labelRBMemID;
        private System.Windows.Forms.TabPage IssueBook;
        private System.Windows.Forms.Button buttonIBIssue;
        private System.Windows.Forms.Button buttonIBReset;
        private System.Windows.Forms.Button buttonIBBookBrowse;
        private System.Windows.Forms.Button buttonIBMemBrowse;
        private System.Windows.Forms.TextBox textBoxIBBookID;
        private System.Windows.Forms.TextBox textBoxIBBookTitle;
        private System.Windows.Forms.TextBox textBoxIBDueDate;
        private System.Windows.Forms.TextBox textBoxIBRemarks;
        private System.Windows.Forms.TextBox textBoxIBIssueDate;
        private System.Windows.Forms.TextBox textBoxIBMemName;
        private System.Windows.Forms.TextBox textBoxIBMemID;
        private System.Windows.Forms.Label labelIBRemarks;
        private System.Windows.Forms.Label labelIBDueDate;
        private System.Windows.Forms.Label labelIBIssueDate;
        private System.Windows.Forms.Label labelIBBookID;
        private System.Windows.Forms.Label labelIBMemID;
        private System.Windows.Forms.TabPage AdvancedSearch;
        private System.Windows.Forms.Button buttonASProceed;
        private System.Windows.Forms.Button buttonASReset;
        private System.Windows.Forms.Button buttonASSearch;
        private System.Windows.Forms.ComboBox comboBoxBookID;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.ComboBox comboBoxBookType;
        private System.Windows.Forms.ComboBox comboBoxAuthorName;
        private System.Windows.Forms.ComboBox comboBoxBookTitle;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.Button buttonSProceed;
        private System.Windows.Forms.Button buttonSReset;
        private System.Windows.Forms.DataGridView dataGridViewSSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonSSearch;
        private System.Windows.Forms.ComboBox comboBoxSSearchFilter;
        private System.Windows.Forms.TextBox textBoxSSearchValue;
        private System.Windows.Forms.Label labelSSearchValue;
        private System.Windows.Forms.TabControl tabControlMenus;
    }
}

