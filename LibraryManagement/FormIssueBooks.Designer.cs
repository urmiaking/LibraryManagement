namespace LibraryManagement
{
    partial class FormIssueBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.BooksDataGirdView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BothRadio = new System.Windows.Forms.RadioButton();
            this.PublisherRadio = new System.Windows.Forms.RadioButton();
            this.TitleRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.UserListComboBox = new System.Windows.Forms.ComboBox();
            this.IssuedBooksButton = new System.Windows.Forms.Button();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.UserManagementButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستجو : ";
            // 
            // BooksDataGirdView
            // 
            this.BooksDataGirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGirdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.BookIdentifierColumn,
            this.TitleColumn,
            this.ISBNColumn,
            this.PriceColumn,
            this.PublisherColumn,
            this.AvailableCount,
            this.LibraryName});
            this.BooksDataGirdView.Location = new System.Drawing.Point(12, 96);
            this.BooksDataGirdView.Name = "BooksDataGirdView";
            this.BooksDataGirdView.ReadOnly = true;
            this.BooksDataGirdView.RowHeadersWidth = 51;
            this.BooksDataGirdView.RowTemplate.Height = 24;
            this.BooksDataGirdView.Size = new System.Drawing.Size(1124, 500);
            this.BooksDataGirdView.TabIndex = 10;
            this.BooksDataGirdView.SelectionChanged += new System.EventHandler(this.BooksDataGirdView_SelectionChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(526, 52);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(532, 33);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 35);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "خروج";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BothRadio);
            this.panel1.Controls.Add(this.PublisherRadio);
            this.panel1.Controls.Add(this.TitleRadio);
            this.panel1.Location = new System.Drawing.Point(243, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 39);
            this.panel1.TabIndex = 12;
            // 
            // BothRadio
            // 
            this.BothRadio.AutoSize = true;
            this.BothRadio.Checked = true;
            this.BothRadio.Location = new System.Drawing.Point(5, 3);
            this.BothRadio.Name = "BothRadio";
            this.BothRadio.Size = new System.Drawing.Size(61, 30);
            this.BothRadio.TabIndex = 8;
            this.BothRadio.TabStop = true;
            this.BothRadio.Text = "هردو";
            this.BothRadio.UseVisualStyleBackColor = true;
            // 
            // PublisherRadio
            // 
            this.PublisherRadio.AutoSize = true;
            this.PublisherRadio.Location = new System.Drawing.Point(72, 3);
            this.PublisherRadio.Name = "PublisherRadio";
            this.PublisherRadio.Size = new System.Drawing.Size(94, 30);
            this.PublisherRadio.TabIndex = 7;
            this.PublisherRadio.Text = "ناشر کتاب";
            this.PublisherRadio.UseVisualStyleBackColor = true;
            // 
            // TitleRadio
            // 
            this.TitleRadio.AutoSize = true;
            this.TitleRadio.Location = new System.Drawing.Point(172, 3);
            this.TitleRadio.Name = "TitleRadio";
            this.TitleRadio.Size = new System.Drawing.Size(100, 30);
            this.TitleRadio.TabIndex = 6;
            this.TitleRadio.Text = "عنوان کتاب";
            this.TitleRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1027, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "مشخصات عضو : ";
            // 
            // ReturnDateTextBox
            // 
            this.ReturnDateTextBox.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.ReturnDateTextBox.Enabled = false;
            this.ReturnDateTextBox.Location = new System.Drawing.Point(306, 6);
            this.ReturnDateTextBox.Mask = "0000-00-00";
            this.ReturnDateTextBox.Name = "ReturnDateTextBox";
            this.ReturnDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReturnDateTextBox.Size = new System.Drawing.Size(214, 33);
            this.ReturnDateTextBox.TabIndex = 2;
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Location = new System.Drawing.Point(526, 10);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(221, 26);
            this.ReturnDateLabel.TabIndex = 14;
            this.ReturnDateLabel.Text = "تاریخ بازگردانی کتاب های منتخب : ";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Enabled = false;
            this.BorrowButton.Location = new System.Drawing.Point(133, 5);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(167, 35);
            this.BorrowButton.TabIndex = 3;
            this.BorrowButton.Text = "امانت دهی";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // UserListComboBox
            // 
            this.UserListComboBox.FormattingEnabled = true;
            this.UserListComboBox.Location = new System.Drawing.Point(753, 6);
            this.UserListComboBox.Name = "UserListComboBox";
            this.UserListComboBox.Size = new System.Drawing.Size(269, 34);
            this.UserListComboBox.TabIndex = 1;
            // 
            // IssuedBooksButton
            // 
            this.IssuedBooksButton.Location = new System.Drawing.Point(12, 53);
            this.IssuedBooksButton.Name = "IssuedBooksButton";
            this.IssuedBooksButton.Size = new System.Drawing.Size(225, 33);
            this.IssuedBooksButton.TabIndex = 9;
            this.IssuedBooksButton.Text = "لیست امانات";
            this.IssuedBooksButton.UseVisualStyleBackColor = true;
            this.IssuedBooksButton.Click += new System.EventHandler(this.IssuedBooksButton_Click);
            // 
            // IndexColumn
            // 
            this.IndexColumn.HeaderText = "ردیف";
            this.IndexColumn.MinimumWidth = 6;
            this.IndexColumn.Name = "IndexColumn";
            this.IndexColumn.ReadOnly = true;
            // 
            // BookIdentifierColumn
            // 
            this.BookIdentifierColumn.HeaderText = "شناسه کتاب";
            this.BookIdentifierColumn.MinimumWidth = 6;
            this.BookIdentifierColumn.Name = "BookIdentifierColumn";
            this.BookIdentifierColumn.ReadOnly = true;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "عنوان کتاب";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.HeaderText = "ISBN";
            this.ISBNColumn.MinimumWidth = 6;
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "قیمت";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // PublisherColumn
            // 
            this.PublisherColumn.HeaderText = "ناشر";
            this.PublisherColumn.MinimumWidth = 6;
            this.PublisherColumn.Name = "PublisherColumn";
            this.PublisherColumn.ReadOnly = true;
            // 
            // AvailableCount
            // 
            this.AvailableCount.HeaderText = "تعداد موجود";
            this.AvailableCount.MinimumWidth = 6;
            this.AvailableCount.Name = "AvailableCount";
            this.AvailableCount.ReadOnly = true;
            // 
            // LibraryName
            // 
            this.LibraryName.HeaderText = "نام کتابخانه";
            this.LibraryName.MinimumWidth = 6;
            this.LibraryName.Name = "LibraryName";
            this.LibraryName.ReadOnly = true;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(12, 612);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(225, 33);
            this.AddBookButton.TabIndex = 17;
            this.AddBookButton.Text = "افزودن کتاب جدید";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(243, 612);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(225, 33);
            this.RefreshButton.TabIndex = 17;
            this.RefreshButton.Text = "به روز رسانی لیست";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // UserManagementButton
            // 
            this.UserManagementButton.Location = new System.Drawing.Point(474, 612);
            this.UserManagementButton.Name = "UserManagementButton";
            this.UserManagementButton.Size = new System.Drawing.Size(225, 33);
            this.UserManagementButton.TabIndex = 17;
            this.UserManagementButton.Text = "مدیریت کاربران";
            this.UserManagementButton.UseVisualStyleBackColor = true;
            this.UserManagementButton.Click += new System.EventHandler(this.UserManagementButton_Click);
            // 
            // FormIssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 648);
            this.Controls.Add(this.UserManagementButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.IssuedBooksButton);
            this.Controls.Add(this.UserListComboBox);
            this.Controls.Add(this.ReturnDateTextBox);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BooksDataGirdView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.LogoutButton);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIssueBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم امانت دهی کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BooksDataGirdView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton BothRadio;
        private System.Windows.Forms.RadioButton PublisherRadio;
        private System.Windows.Forms.RadioButton TitleRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ReturnDateTextBox;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.ComboBox UserListComboBox;
        private System.Windows.Forms.Button IssuedBooksButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryName;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button UserManagementButton;
    }
}