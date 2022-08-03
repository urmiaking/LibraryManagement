using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Models;
using PersianDate;

namespace LibraryManagement
{
    public partial class FormBooks : Form
    {
        private readonly AppDbContext _context;

        private readonly int _userId;
        private Member _member;

        public FormBooks(int userId)
        {
            _userId = userId;
            InitializeComponent();
            _context = new AppDbContext();
            LoadBooks(SearchTextBox.Text);
            LoadUser();
        }

        private void LoadUser()
        {
            var member = _context.Members.Include(a => a.Library).FirstOrDefault(a => a.Id == _userId);
            _member = member;

            UsernameLabel.Visible = true;
            UsernameLabel.Text = member?.Username;

            LibNameLabel.Visible = true;
            LibNameLabel.Text = member?.Library.Name;

            RegIdLabel.Visible = true;
            RegIdLabel.Text = member?.Id.ToString();

            UserFullNameLabel.Visible = true;
            UserFullNameLabel.Text = member?.Name;

            RegisterDateLabel.Visible = true;
            RegisterDateLabel.Text = member?.RegisterDate.ToFa("D");
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
                BooksDataGirdView.Rows[i].Cells[0].Value = (i+1).ToString();
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

        private void BorrowedBooksButton_Click(object sender, EventArgs e)
        {
            var form = new FormBorrowedBooks(_member);
            form.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
