using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Models;
using LibraryManagement.Models.Enums;

namespace LibraryManagement
{
    public partial class FormLogin : Form
    {
        private readonly AppDbContext _context;
        public FormLogin()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            var member = await _context.Members.FirstOrDefaultAsync(a =>
                a.Username == UsernameTextBox.Text && a.Password == PasswordTextBox.Text);

            if (member is null)
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                return;
            }

            if (member.MemberType == MemberType.Employee)
            {
                var formIssuedBooks = new FormIssueBooks(member.Id);
                formIssuedBooks.ShowDialog();
            }
            else
            {
                var formBooks = new FormBooks(member.Id);
                formBooks.ShowDialog();
            }
        }
    }
}
