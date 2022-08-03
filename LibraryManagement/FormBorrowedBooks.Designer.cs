namespace LibraryManagement
{
    partial class FormBorrowedBooks
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
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).BeginInit();
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
            this.ActualReturnDate});
            this.BooksDataGirdView.Location = new System.Drawing.Point(12, 12);
            this.BooksDataGirdView.Name = "BooksDataGirdView";
            this.BooksDataGirdView.ReadOnly = true;
            this.BooksDataGirdView.RowHeadersWidth = 51;
            this.BooksDataGirdView.RowTemplate.Height = 24;
            this.BooksDataGirdView.Size = new System.Drawing.Size(1174, 526);
            this.BooksDataGirdView.TabIndex = 5;
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
            // FormBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 550);
            this.Controls.Add(this.BooksDataGirdView);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBorrowedBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کتاب های امانت گرفته شده";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksDataGirdView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualReturnDate;
    }
}