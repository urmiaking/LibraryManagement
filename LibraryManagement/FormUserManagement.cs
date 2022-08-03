using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Models;

namespace LibraryManagement
{
    public partial class FormUserManagement : Form
    {
        private readonly AppDbContext _context;
        private readonly Member _member;

        public FormUserManagement(Member member)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _member = member;
            LoadUsers(SearchTextbox.Text);
        }

        private async void LoadUsers(string text)
        {
            var members = new List<Member>();

            var query = _context.Members.AsNoTracking()
                .Where(a => a.LibraryId == _member.LibraryId);

            if (string.IsNullOrEmpty(text))
            {
                members.AddRange(await query.ToListAsync());
            }
            else
            {
                if (UserFullNameRadio.Checked)
                    members.AddRange(await query.Where(a => a.Name.Contains(text)).ToListAsync());

                else if (UsernameRadio.Checked)
                    members.AddRange(await query.Where(a => a.Username.Contains(text)).ToListAsync());

            }

            FillDataGridView(members);
        }

        private void FillDataGridView(List<Member> members)
        {
            UserDataGridView.Rows.Clear();

            for (var i = 0; i < members.Count; i++)
            {
                UserDataGridView.Rows.Add();
                UserDataGridView.Rows[i].Cells[0].Value = members[i].Id;
                UserDataGridView.Rows[i].Cells[1].Value = members[i].Name;
                UserDataGridView.Rows[i].Cells[2].Value = members[i].Username;
                UserDataGridView.Rows[i].Cells[3].Value = members[i].Password;
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(SearchTextbox.Text);
        }

        private void UserDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                var currentRowIndex = UserDataGridView.SelectedRows[0].Index;

                if (currentRowIndex == -1)
                    return;

                var row = UserDataGridView.Rows[currentRowIndex];

                FullNameTextbox.Text = row.Cells[nameof(UserFullNameColumn)].Value.ToString();
                UsernameTextbox.Text = row.Cells[nameof(UsernameColumn)].Value.ToString();
                PasswordTextbox.Text = row.Cells[nameof(PasswordColumn)].Value.ToString();
            }
        }

        private async void AddOrUpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextbox.Text) || string.IsNullOrEmpty(UsernameTextbox.Text) ||
                string.IsNullOrEmpty(PasswordTextbox.Text))
            {
                MessageBox.Show("لطفا مقادیر اجباری را پر کنید");
                return;
            }

            var isUserSelected = UserDataGridView.SelectedRows.Count > 0;

            if (isUserSelected)
            {
                var currentRowIndex = UserDataGridView.SelectedCells[0].RowIndex;

                if (currentRowIndex == -1)
                    return;

                var row = UserDataGridView.Rows[currentRowIndex];

                var userId = row.Cells[nameof(UserIdColumn)].Value.ToString();

                var member = await _context.Members.FindAsync(int.Parse(userId));

                if (member != null)
                {
                    member.Name = FullNameTextbox.Text;
                    member.Username = UsernameTextbox.Text;
                    member.Password = PasswordTextbox.Text;

                    _context.Entry(member).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    MessageBox.Show("کاربر مورد نظر با موفقیت ویرایش شد!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                var newUser = new Member
                {
                    Name = FullNameTextbox.Text,
                    Username = UsernameTextbox.Text,
                    Password = PasswordTextbox.Text,
                    RegisterDate = DateTime.Now,
                    LibraryId = _member.LibraryId
                };

                _context.Members.Add(newUser);
                await _context.SaveChangesAsync();

                var library = await _context.Libraries.FirstOrDefaultAsync(x => x.Id == _member.LibraryId);

                library.MemberCount = (int.Parse(library.MemberCount) + 1).ToString();

                _context.Entry(library).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                MessageBox.Show("کاربر مورد نظر با موفقیت اضافه شد!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LoadUsers(SearchTextbox.Text);
        }
    }
}
