using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Extensions;
using LibraryManagement.Models;
using PersianDate;

namespace LibraryManagement
{
    public partial class FormReturnBooks : Form
    {
        private readonly AppDbContext _context;
        private readonly Member _member;
        public FormReturnBooks(Member member)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _member = member;
            LoadBooks(SearchTextBox.Text);
        }

        private void BooksDataGirdView_SelectionChanged(object sender, EventArgs e)
        {
            if (BooksDataGirdView.SelectedRows.Count > 0)
            {
                var rowsCount = BooksDataGirdView.SelectedRows.Count;
                if (rowsCount >= 2)
                    return;

                if (DateTime.TryParse(BooksDataGirdView.SelectedRows[0].Cells[nameof(ActualReturnDate)].Value.ToString(), out _))
                    return;

                ReturnButton.Enabled = rowsCount != 0;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(SearchTextBox.Text);
        }

        private async void LoadBooks(string text)
        {
            var borrows = new List<Borrow>();
            
            var query = _context.Borrows.AsNoTracking().Include(a => a.Book).Include(a => a.Member)
                .Where(a => a.Book.AvailableCount > 0 && a.Book.LibraryId == _member.LibraryId);

            if (string.IsNullOrEmpty(text))
            {
                borrows.AddRange(await query.ToListAsync());
            }
            else
            {
                if (PublisherRadio.Checked)
                    borrows.AddRange(await query.Where(a => a.Book.Publisher.Contains(text)).ToListAsync());

                else if (TitleRadio.Checked)
                    borrows.AddRange(await query.Where(a => a.Book.Title.Contains(text)).ToListAsync());

                else if (BothRadio.Checked)
                    borrows.AddRange(await query.Where(a => a.Book.Title.Contains(text) || a.Book.Publisher.Contains(text))
                        .ToListAsync());
            }

            FillDataGridView(borrows);
        }

        private void FillDataGridView(List<Borrow> borrows)
        {
            BooksDataGirdView.Rows.Clear();

            for (var i = 0; i < borrows.Count; i++)
            {
                BooksDataGirdView.Rows.Add();
                BooksDataGirdView.Rows[i].Cells[0].Value = (i + 1).ToString();
                BooksDataGirdView.Rows[i].Cells[1].Value = borrows[i].Book.Id;
                BooksDataGirdView.Rows[i].Cells[2].Value = borrows[i].Book.Title;
                BooksDataGirdView.Rows[i].Cells[3].Value = borrows[i].Book.ISBN;
                BooksDataGirdView.Rows[i].Cells[4].Value = borrows[i].Book.Price;
                BooksDataGirdView.Rows[i].Cells[5].Value = borrows[i].BorrowDate.ToFa("D");
                BooksDataGirdView.Rows[i].Cells[6].Value = borrows[i].SpecifiedReturnDate.ToFa("D");
                BooksDataGirdView.Rows[i].Cells[7].Value = borrows[i].ActualReturnDate?.ToFa("D") ?? "تحویل داده نشده";
                BooksDataGirdView.Rows[i].Cells[8].Value = borrows[i].Member.Name;
                BooksDataGirdView.Rows[i].Cells[9].Value = borrows[i].SpecifiedReturnDate;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ReturnButton_Click(object sender, EventArgs e)
        {
            var dialogResult =
                MessageBox.Show("آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult != DialogResult.Yes) return;

            var bookId = Convert.ToInt32(
                BooksDataGirdView.SelectedRows[0]
                    .Cells[nameof(BookIdentifierColumn)].Value);

            var memberName = BooksDataGirdView
                .SelectedRows[0]
                .Cells[nameof(UserFullNameColumn)]
                .Value.ToString();

            var memberId = (await _context.Members.FirstOrDefaultAsync(a => 
                a.Name == memberName))?.Id;

            var returnDate = DateTime.Parse(BooksDataGirdView
                .SelectedRows[0].Cells[nameof(ReturnDateHiddenColumn)].Value
                .ToString());

            var borrow = await _context.Borrows
                .FirstOrDefaultAsync(a =>
                    a.MemberId == memberId && a.BookId == bookId &&
                    a.SpecifiedReturnDate == returnDate);

            if (borrow is null)
            {
                MessageBox.Show("امانتی با مشخصات داده شده یافت نشد");
                return;
            }

            borrow.ActualReturnDate = DateTime.Today;
            _context.Entry(borrow).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            LoadBooks(SearchTextBox.Text);
        }
    }
}
