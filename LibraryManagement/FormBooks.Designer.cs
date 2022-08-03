namespace LibraryManagement
{
    partial class FormBooks
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TitleRadio = new System.Windows.Forms.RadioButton();
            this.PublisherRadio = new System.Windows.Forms.RadioButton();
            this.BothRadio = new System.Windows.Forms.RadioButton();
            this.BooksDataGirdView = new System.Windows.Forms.DataGridView();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterDateLabel = new System.Windows.Forms.Label();
            this.RegIdLabel = new System.Windows.Forms.Label();
            this.LibNameLabel = new System.Windows.Forms.Label();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BorrowedBooksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 117);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 35);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "خروج";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1068, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو : ";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(615, 118);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(447, 33);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // TitleRadio
            // 
            this.TitleRadio.AutoSize = true;
            this.TitleRadio.Location = new System.Drawing.Point(170, 3);
            this.TitleRadio.Name = "TitleRadio";
            this.TitleRadio.Size = new System.Drawing.Size(100, 30);
            this.TitleRadio.TabIndex = 2;
            this.TitleRadio.Text = "عنوان کتاب";
            this.TitleRadio.UseVisualStyleBackColor = true;
            // 
            // PublisherRadio
            // 
            this.PublisherRadio.AutoSize = true;
            this.PublisherRadio.Location = new System.Drawing.Point(70, 3);
            this.PublisherRadio.Name = "PublisherRadio";
            this.PublisherRadio.Size = new System.Drawing.Size(94, 30);
            this.PublisherRadio.TabIndex = 3;
            this.PublisherRadio.Text = "ناشر کتاب";
            this.PublisherRadio.UseVisualStyleBackColor = true;
            // 
            // BothRadio
            // 
            this.BothRadio.AutoSize = true;
            this.BothRadio.Checked = true;
            this.BothRadio.Location = new System.Drawing.Point(3, 3);
            this.BothRadio.Name = "BothRadio";
            this.BothRadio.Size = new System.Drawing.Size(61, 30);
            this.BothRadio.TabIndex = 4;
            this.BothRadio.TabStop = true;
            this.BothRadio.Text = "هردو";
            this.BothRadio.UseVisualStyleBackColor = true;
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
            this.BooksDataGirdView.Location = new System.Drawing.Point(12, 172);
            this.BooksDataGirdView.Name = "BooksDataGirdView";
            this.BooksDataGirdView.ReadOnly = true;
            this.BooksDataGirdView.RowHeadersWidth = 51;
            this.BooksDataGirdView.RowTemplate.Height = 24;
            this.BooksDataGirdView.Size = new System.Drawing.Size(1124, 500);
            this.BooksDataGirdView.TabIndex = 7;
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
            this.PriceColumn.HeaderText = "قمیت";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.BothRadio);
            this.panel1.Controls.Add(this.PublisherRadio);
            this.panel1.Controls.Add(this.TitleRadio);
            this.panel1.Location = new System.Drawing.Point(332, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 39);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1032, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کاربری : ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(910, 36);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(107, 26);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RegisterDateLabel);
            this.panel2.Controls.Add(this.RegIdLabel);
            this.panel2.Controls.Add(this.LibNameLabel);
            this.panel2.Controls.Add(this.UserFullNameLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 100);
            this.panel2.TabIndex = 6;
            // 
            // RegisterDateLabel
            // 
            this.RegisterDateLabel.AutoSize = true;
            this.RegisterDateLabel.Location = new System.Drawing.Point(470, 36);
            this.RegisterDateLabel.Name = "RegisterDateLabel";
            this.RegisterDateLabel.Size = new System.Drawing.Size(131, 26);
            this.RegisterDateLabel.TabIndex = 1;
            this.RegisterDateLabel.Text = "RegisterDate";
            this.RegisterDateLabel.Visible = false;
            // 
            // RegIdLabel
            // 
            this.RegIdLabel.AutoSize = true;
            this.RegIdLabel.Location = new System.Drawing.Point(91, 2);
            this.RegIdLabel.Name = "RegIdLabel";
            this.RegIdLabel.Size = new System.Drawing.Size(67, 26);
            this.RegIdLabel.TabIndex = 1;
            this.RegIdLabel.Text = "RegId";
            this.RegIdLabel.Visible = false;
            // 
            // LibNameLabel
            // 
            this.LibNameLabel.AutoSize = true;
            this.LibNameLabel.Location = new System.Drawing.Point(471, 2);
            this.LibNameLabel.Name = "LibNameLabel";
            this.LibNameLabel.Size = new System.Drawing.Size(130, 26);
            this.LibNameLabel.TabIndex = 1;
            this.LibNameLabel.Text = "LibraryName";
            this.LibNameLabel.Visible = false;
            // 
            // UserFullNameLabel
            // 
            this.UserFullNameLabel.AutoSize = true;
            this.UserFullNameLabel.Location = new System.Drawing.Point(910, 2);
            this.UserFullNameLabel.Name = "UserFullNameLabel";
            this.UserFullNameLabel.Size = new System.Drawing.Size(67, 26);
            this.UserFullNameLabel.TabIndex = 1;
            this.UserFullNameLabel.Text = "Name";
            this.UserFullNameLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "شماره عضویت : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "تاریخ عضویت : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "نام کتابخانه ی عضو شده :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1044, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام کاربر : ";
            // 
            // BorrowedBooksButton
            // 
            this.BorrowedBooksButton.Location = new System.Drawing.Point(133, 117);
            this.BorrowedBooksButton.Name = "BorrowedBooksButton";
            this.BorrowedBooksButton.Size = new System.Drawing.Size(193, 34);
            this.BorrowedBooksButton.TabIndex = 5;
            this.BorrowedBooksButton.Text = "کتاب های من";
            this.BorrowedBooksButton.UseVisualStyleBackColor = true;
            this.BorrowedBooksButton.Click += new System.EventHandler(this.BorrowedBooksButton_Click);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BooksDataGirdView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BorrowedBooksButton);
            this.Controls.Add(this.LogoutButton);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم کتاب ها";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.RadioButton TitleRadio;
        private System.Windows.Forms.RadioButton PublisherRadio;
        private System.Windows.Forms.RadioButton BothRadio;
        private System.Windows.Forms.DataGridView BooksDataGirdView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RegisterDateLabel;
        private System.Windows.Forms.Label RegIdLabel;
        private System.Windows.Forms.Label LibNameLabel;
        private System.Windows.Forms.Label UserFullNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BorrowedBooksButton;
    }
}