using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Models;

namespace LibraryManagement
{
    public partial class FormAddBook : Form
    {
        private readonly AppDbContext _context;
        private readonly int _libraryId;
        public FormAddBook(Member member)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _libraryId = member.LibraryId;
            LoadBooks(SearchTextBox.Text);
        }

        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            BookNameTextbox.Text = null;
            BookNameTextbox.Focus();

            PriceTextbox.Text = null;
            ISBNTextbox.Text = null;
            AvailableCountTextbox.Text = null;
            PublisherTextbox.Text = null;
        }

        private async void LoadBooks(string text)
        {
            var books = new List<Book>();

            var query = _context.Books.Include(a => a.Library).Where(a => a.AvailableCount > 0);
            if (string.IsNullOrEmpty(text))
            {
                books.AddRange(await query.ToListAsync());
            }
            else
            {
                if (PublisherRadio.Checked)
                    books.AddRange(await query.Where(a => a.Publisher.Contains(text)).ToListAsync());

                else if (TitleRadio.Checked)
                    books.AddRange(await query.Where(a => a.Title.Contains(text)).ToListAsync());

                else if (BothRadio.Checked)
                    books.AddRange(await query.Where(a => a.Title.Contains(text) || a.Publisher.Contains(text))
                        .ToListAsync());
            }

            FillDataGridView(books);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(SearchTextBox.Text);
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

        private async void AddOrEditBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BookNameTextbox.Text) || string.IsNullOrEmpty(PublisherTextbox.Text) ||
                AvailableCountTextbox.Text == "0" || string.IsNullOrEmpty(ISBNTextbox.Text) || string.IsNullOrEmpty(PriceTextbox.Text))
            {
                MessageBox.Show("لطفا مقادیر اجباری را پر کنید");
                return;
            }

            var isBookSelected = BooksDataGirdView.SelectedRows.Count > 0;

            if (isBookSelected)
            {
                var currentRowIndex = BooksDataGirdView.SelectedCells[0].RowIndex;

                if (currentRowIndex == -1)
                    return;

                var row = BooksDataGirdView.Rows[currentRowIndex];

                var bookId = row.Cells[nameof(BookIdentifierColumn)].Value.ToString();

                var book = await _context.Books.FindAsync(int.Parse(bookId));

                if (book != null)
                {
                    book.Title = BookNameTextbox.Text;
                    book.AvailableCount = Convert.ToInt32(AvailableCountTextbox.Text);
                    book.ISBN = ISBNTextbox.Text;
                    book.Publisher = PublisherTextbox.Text;
                    book.Price = float.Parse(PriceTextbox.Text);

                    _context.Entry(book).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    MessageBox.Show("کتاب مورد نظر با موفقیت ویرایش شد!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                var newBook = new Book
                {
                    Title = BookNameTextbox.Text,
                    AvailableCount = Convert.ToInt32(AvailableCountTextbox.Text),
                    ISBN = ISBNTextbox.Text,
                    LibraryId = _libraryId,
                    Publisher = PublisherTextbox.Text,
                    Price = float.Parse(PriceTextbox.Text)
                };

                _context.Books.Add(newBook);
                await _context.SaveChangesAsync();

                MessageBox.Show("کتاب مورد نظر با موفقیت اضافه شد!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LoadBooks(SearchTextBox.Text);
        }

        private void BooksDataGirdView_SelectionChanged(object sender, EventArgs e)
        {
            if (BooksDataGirdView.SelectedRows.Count > 0)
            {
                var currentRowIndex = BooksDataGirdView.SelectedRows[0].Index;

                if (currentRowIndex == -1)
                    return;

                var row = BooksDataGirdView.Rows[currentRowIndex];

                BookNameTextbox.Text = row.Cells[nameof(TitleColumn)].Value.ToString();
                ISBNTextbox.Text = row.Cells[nameof(ISBNColumn)].Value.ToString();
                PublisherTextbox.Text = row.Cells[nameof(PublisherColumn)].Value.ToString();
                PriceTextbox.Text = row.Cells[nameof(PriceColumn)].Value.ToString();
                AvailableCountTextbox.Text = row.Cells[nameof(AvailableCount)].Value.ToString();
            }
        }
    }
}
