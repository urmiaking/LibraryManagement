using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MemberCount { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}