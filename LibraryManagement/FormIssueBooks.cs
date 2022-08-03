using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Extensions;
using LibraryManagement.Models;
using LibraryManagement.Models.Enums;

namespace LibraryManagement
{
    public partial class FormIssueBooks : Form
    {
        private readonly Member _member;
        private readonly AppDbContext _context;
        public FormIssueBooks(int userId)
        {
            _context = new AppDbContext();
            _member = _context.Members.Find(userId);
            InitializeComponent();
            LoadBooks(SearchTextBox.Text);
            LoadUsersComboBox();
        }

        private void LoadUsersComboBox()
        {
            UserListComboBox.Items.AddRange(_context.Members.Where(a => 
                a.LibraryId == _member.LibraryId && a.MemberType == MemberType.User).Select(a => a.Name).ToArray());
        }

        private void LoadBooks(string text)
        {
            var books = new List<Book>();

            var query = _context.Books.Include(a => a.Library).Where(a => a.AvailableCount > 0);
            if (string.IsNullOrEmpty(text))
            {
                books.AddRange(query.ToList());
            }
            else
            {
                if (PublisherRadio.Checked)
                    books.AddRange(query.Where(a => a.Publisher.Contains(text)).ToList());

                else if (TitleRadio.Checked)
                    books.AddRange(query.Where(a => a.Title.Contains(text)).ToList());

                else if (BothRadio.Checked)
                    books.AddRange(query.Where(a => a.Title.Contains(text) || a.Publisher.Contains(text))
                        .ToList());
            }

            FillDataGridView(books);
        }

        private void FillDataGridView(List<Book> books)
        {
            BooksDataGirdView.Rows.Clear();

            for (var i = 0; i < books.Count; i++)
            {
                BooksDataGirdView.Rows.Add();
                BooksDataGirdView.Rows[i].Cells[0].Value = (i + 1).ToString();
                BooksDataGirdView.Rows[i].Cells[1].Value = books[i].Id;
                BooksDataGirdView.Rows[i].Cells[2].Value = books[i].Title;
                BooksDataGirdView.Rows[i].Cells[3].Value = books[i].ISBN;
                BooksDataGirdView.Rows[i].Cells[4].Value = books[i].Price;
                BooksDataGirdView.Rows[i].Cells[5].Value = books[i].Publisher;
                BooksDataGirdView.Rows[i].Cells[6].Value = books[i].AvailableCount;
                BooksDataGirdView.Rows[i].Cells[7].Value = books[i].Library.Name;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(SearchTextBox.Text);
        }

        private void BooksDataGirdView_SelectionChanged(object sender, EventArgs e)
        {

            var rowsCount = BooksDataGirdView.SelectedRows.Count;
            if (rowsCount >= 5)
                MessageBox.Show("امکان امانت گیری بیش از 5 کتاب وجود ندارد");

            BorrowButton.Enabled = rowsCount != 0;
            ReturnDateTextBox.Enabled = rowsCount != 0;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BorrowButton_Click(object sender, EventArgs e)
        {
            var rowsCount = BooksDataGirdView.SelectedRows.Count;

            if (string.IsNullOrEmpty(UserListComboBox.Text))
            {
                MessageBox.Show("لطفا ابتدا نام عضو را انتخاب کنید");
                return;
            }

            if (rowsCount <= 0 || rowsCount > 5) return;
            var dialogResult =
                MessageBox.Show("آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult != DialogResult.Yes) 
                return;
            var rows = BooksDataGirdView.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                var bookId = Convert.ToInt32(row.Cells[nameof(BookIdentifierColumn)].Value);

                var memberId = (await _context.Members.FirstOrDefaultAsync(a => 
                    a.Name == UserListComboBox.Text))?.Id;

                var returnDate = ReturnDateTextBox.Text.ToGlobalDateTime();

                if (await _context.Borrows.AnyAsync(a => 
                        a.BookId == bookId &&
                        a.MemberId == memberId && a.ActualReturnDate == null))
                {
                    MessageBox.Show("این کاربر قبلا این کتاب را به امانت گرفته و هنوز تحویل نداده است");
                    return;
                }

                var borrow = new Borrow
                {
                    SpecifiedReturnDate = returnDate,
                    BookId = bookId,
                    MemberId = memberId ?? 0,
                    BorrowDate = DateTime.Now
                };

                _context.Borrows.Add(borrow);

                var book = await _context.Books.FindAsync(bookId);
                book.AvailableCount--;

                _context.Entry(book).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            MessageBox.Show("کتاب های منتخب با موفقیت امانت گرفته شد");
            LoadBooks(SearchTextBox.Text);
        }

        private void IssuedBooksButton_Click(object sender, EventArgs e)
        {
            var form = new FormReturnBooks(_member);
            form.ShowDialog();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var form = new FormAddBook(_member);
            form.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadBooks(SearchTextBox.Text);
        }

        private void UserManagementButton_Click(object sender, EventArgs e)
        {
            var form = new FormUserManagement(_member);
            form.ShowDialog();
        }
    }
}
