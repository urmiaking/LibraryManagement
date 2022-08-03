namespace LibraryManagement
{
    partial class FormReturnBooks
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
            this.BooksDataGirdView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BothRadio = new System.Windows.Forms.RadioButton();
            this.PublisherRadio = new System.Windows.Forms.RadioButton();
            this.TitleRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDateHiddenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.BorrowedDateColumn,
            this.ReturnDateColumn,
            this.ActualReturnDate,
            this.UserFullNameColumn,
            this.ReturnDateHiddenColumn});
            this.BooksDataGirdView.Location = new System.Drawing.Point(12, 73);
            this.BooksDataGirdView.MultiSelect = false;
            this.BooksDataGirdView.Name = "BooksDataGirdView";
            this.BooksDataGirdView.ReadOnly = true;
            this.BooksDataGirdView.RowHeadersWidth = 51;
            this.BooksDataGirdView.RowTemplate.Height = 24;
            this.BooksDataGirdView.Size = new System.Drawing.Size(1403, 526);
            this.BooksDataGirdView.TabIndex = 6;
            this.BooksDataGirdView.SelectionChanged += new System.EventHandler(this.BooksDataGirdView_SelectionChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Enabled = false;
            this.ReturnButton.Location = new System.Drawing.Point(15, 615);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(167, 35);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "بازگردانی کتاب";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BothRadio);
            this.panel1.Controls.Add(this.PublisherRadio);
            this.panel1.Controls.Add(this.TitleRadio);
            this.panel1.Location = new System.Drawing.Point(524, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 39);
            this.panel1.TabIndex = 21;
            // 
            // BothRadio
            // 
            this.BothRadio.AutoSize = true;
            this.BothRadio.Checked = true;
            this.BothRadio.Location = new System.Drawing.Point(5, 3);
            this.BothRadio.Name = "BothRadio";
            this.BothRadio.Size = new System.Drawing.Size(61, 30);
            this.BothRadio.TabIndex = 4;
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
            this.PublisherRadio.TabIndex = 3;
            this.PublisherRadio.Text = "ناشر کتاب";
            this.PublisherRadio.UseVisualStyleBackColor = true;
            // 
            // TitleRadio
            // 
            this.TitleRadio.AutoSize = true;
            this.TitleRadio.Location = new System.Drawing.Point(172, 3);
            this.TitleRadio.Name = "TitleRadio";
            this.TitleRadio.Size = new System.Drawing.Size(100, 30);
            this.TitleRadio.TabIndex = 2;
            this.TitleRadio.Text = "عنوان کتاب";
            this.TitleRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1345, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "جستجو : ";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(807, 34);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(532, 33);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(15, 28);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 35);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "خروج";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
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
            // BorrowedDateColumn
            // 
            this.BorrowedDateColumn.HeaderText = "تاریخ امانت دهی";
            this.BorrowedDateColumn.MinimumWidth = 6;
            this.BorrowedDateColumn.Name = "BorrowedDateColumn";
            this.BorrowedDateColumn.ReadOnly = true;
            // 
            // ReturnDateColumn
            // 
            this.ReturnDateColumn.HeaderText = "تاریخ سررسید";
            this.ReturnDateColumn.MinimumWidth = 6;
            this.ReturnDateColumn.Name = "ReturnDateColumn";
            this.ReturnDateColumn.ReadOnly = true;
            // 
            // ActualReturnDate
            // 
            this.ActualReturnDate.HeaderText = "تاریخ تحویل";
            this.ActualReturnDate.MinimumWidth = 6;
            this.ActualReturnDate.Name = "ActualReturnDate";
            this.ActualReturnDate.ReadOnly = true;
            // 
            // UserFullNameColumn
            // 
            this.UserFullNameColumn.HeaderText = "نام کاربر";
            this.UserFullNameColumn.MinimumWidth = 6;
            this.UserFullNameColumn.Name = "UserFullNameColumn";
            this.UserFullNameColumn.ReadOnly = true;
            // 
            // ReturnDateHiddenColumn
            // 
            this.ReturnDateHiddenColumn.HeaderText = "ReturnDateHiddenColumn";
            this.ReturnDateHiddenColumn.MinimumWidth = 6;
            this.ReturnDateHiddenColumn.Name = "ReturnDateHiddenColumn";
            this.ReturnDateHiddenColumn.ReadOnly = true;
            this.ReturnDateHiddenColumn.Visible = false;
            // 
            // FormReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 661);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BooksDataGirdView);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReturnBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم بازگردانی کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksDataGirdView;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton BothRadio;
        private System.Windows.Forms.RadioButton PublisherRadio;
        private System.Windows.Forms.RadioButton TitleRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDateHiddenColumn;
    }
}