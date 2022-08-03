using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Models;
using PersianDate;

namespace LibraryManagement
{
    public partial class FormBorrowedBooks : Form
    {
        private readonly Member _member;
        private readonly AppDbContext _context;
        public FormBorrowedBooks(Member member)
        {
            _member = member;
            _context = new AppDbContext();
            InitializeComponent();
            LoadGridView();
        }

        private async void LoadGridView()
        {
            var borrows = await _context.Borrows
                .Include(a => a.Book)
                .Where(a => a.MemberId == _member.Id)
                .ToListAsync();

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
            }
        }
    }
}
