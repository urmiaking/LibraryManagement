using System;
using System.Collections.Generic;
using LibraryManagement.Models.Enums;

namespace LibraryManagement.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime RegisterDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public MemberType MemberType { get; set; }

        public int LibraryId { get; set; }
        public virtual Library Library { get; set; }
        public virtual List<Borrow> Borrows { get; set; }
    }
}