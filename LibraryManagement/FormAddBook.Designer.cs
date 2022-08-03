namespace LibraryManagement
{
    partial class FormAddBook
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
            this.BookNameTextbox = new System.Windows.Forms.TextBox();
            this.ISBNTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PublisherTextbox = new System.Windows.Forms.TextBox();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AvailableCountTextbox = new System.Windows.Forms.NumericUpDown();
            this.AddOrEditBookButton = new System.Windows.Forms.Button();
            this.BooksDataGirdView = new System.Windows.Forms.DataGridView();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIdentifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearSelectionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BothRadio = new System.Windows.Forms.RadioButton();
            this.PublisherRadio = new System.Windows.Forms.RadioButton();
            this.TitleRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCountTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1136, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "عنوان کتاب : ";
            // 
            // BookNameTextbox
            // 
            this.BookNameTextbox.Location = new System.Drawing.Point(946, 12);
            this.BookNameTextbox.Name = "BookNameTextbox";
            this.BookNameTextbox.Size = new System.Drawing.Size(171, 33);
            this.BookNameTextbox.TabIndex = 1;
            // 
            // ISBNTextbox
            // 
            this.ISBNTextbox.Location = new System.Drawing.Point(451, 15);
            this.ISBNTextbox.Name = "ISBNTextbox";
            this.ISBNTextbox.Size = new System.Drawing.Size(171, 33);
            this.ISBNTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "ISBN : ";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(946, 68);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(171, 33);
            this.PriceTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1172, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "قیمت : ";
            // 
            // PublisherTextbox
            // 
            this.PublisherTextbox.Location = new System.Drawing.Point(28, 15);
            this.PublisherTextbox.Name = "PublisherTextbox";
            this.PublisherTextbox.Size = new System.Drawing.Size(190, 33);
            this.PublisherTextbox.TabIndex = 3;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(226, 15);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(52, 26);
            this.PublisherLabel.TabIndex = 21;
            this.PublisherLabel.Text = "ناشر : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "تعداد : ";
            // 
            // AvailableCountTextbox
            // 
            this.AvailableCountTextbox.Location = new System.Drawing.Point(451, 65);
            this.AvailableCountTextbox.Name = "AvailableCountTextbox";
            this.AvailableCountTextbox.Size = new System.Drawing.Size(171, 33);
            this.AvailableCountTextbox.TabIndex = 5;
            // 
            // AddOrEditBookButton
            // 
            this.AddOrEditBookButton.Location = new System.Drawing.Point(28, 67);
            this.AddOrEditBookButton.Name = "AddOrEditBookButton";
            this.AddOrEditBookButton.Size = new System.Drawing.Size(190, 34);
            this.AddOrEditBookButton.TabIndex = 6;
            this.AddOrEditBookButton.Text = "ذخیره کتاب";
            this.AddOrEditBookButton.UseVisualStyleBackColor = true;
            this.AddOrEditBookButton.Click += new System.EventHandler(this.AddOrEditBookButton_Click);
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
            this.BooksDataGirdView.Location = new System.Drawing.Point(28, 164);
            this.BooksDataGirdView.MultiSelect = false;
            this.BooksDataGirdView.Name = "BooksDataGirdView";
            this.BooksDataGirdView.ReadOnly = true;
            this.BooksDataGirdView.RowHeadersWidth = 51;
            this.BooksDataGirdView.RowTemplate.Height = 24;
            this.BooksDataGirdView.Size = new System.Drawing.Size(1194, 500);
            this.BooksDataGirdView.TabIndex = 12;
            this.BooksDataGirdView.SelectionChanged += new System.EventHandler(this.BooksDataGirdView_SelectionChanged);
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
            // ClearSelectionButton
            // 
            this.ClearSelectionButton.Location = new System.Drawing.Point(28, 119);
            this.ClearSelectionButton.Name = "ClearSelectionButton";
            this.ClearSelectionButton.Size = new System.Drawing.Size(290, 34);
            this.ClearSelectionButton.TabIndex = 11;
            this.ClearSelectionButton.Text = "پاک سازی مقادیر";
            this.ClearSelectionButton.UseVisualStyleBackColor = true;
            this.ClearSelectionButton.Click += new System.EventHandler(this.ClearSelectionButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BothRadio);
            this.panel1.Controls.Add(this.PublisherRadio);
            this.panel1.Controls.Add(this.TitleRadio);
            this.panel1.Location = new System.Drawing.Point(334, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 39);
            this.panel1.TabIndex = 28;
            // 
            // BothRadio
            // 
            this.BothRadio.AutoSize = true;
            this.BothRadio.Checked = true;
            this.BothRadio.Location = new System.Drawing.Point(5, 3);
            this.BothRadio.Name = "BothRadio";
            this.BothRadio.Size = new System.Drawing.Size(61, 30);
            this.BothRadio.TabIndex = 10;
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
            this.PublisherRadio.TabIndex = 9;
            this.PublisherRadio.Text = "ناشر کتاب";
            this.PublisherRadio.UseVisualStyleBackColor = true;
            // 
            // TitleRadio
            // 
            this.TitleRadio.AutoSize = true;
            this.TitleRadio.Location = new System.Drawing.Point(172, 3);
            this.TitleRadio.Name = "TitleRadio";
            this.TitleRadio.Size = new System.Drawing.Size(100, 30);
            this.TitleRadio.TabIndex = 8;
            this.TitleRadio.Text = "عنوان کتاب";
            this.TitleRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1155, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "جستجو : ";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(617, 119);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(532, 33);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BooksDataGirdView);
            this.Controls.Add(this.ClearSelectionButton);
            this.Controls.Add(this.AddOrEditBookButton);
            this.Controls.Add(this.AvailableCountTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNTextbox);
            this.Controls.Add(this.PublisherTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.BookNameTextbox);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اضافه کردن کتاب";
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCountTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookNameTextbox;
        private System.Windows.Forms.TextBox ISBNTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PublisherTextbox;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AvailableCountTextbox;
        private System.Windows.Forms.Button AddOrEditBookButton;
        private System.Windows.Forms.DataGridView BooksDataGirdView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdentifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryName;
        private System.Windows.Forms.Button ClearSelectionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton BothRadio;
        private System.Windows.Forms.RadioButton PublisherRadio;
        private System.Windows.Forms.RadioButton TitleRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}