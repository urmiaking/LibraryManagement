using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public float Price { get; set; }
        public string Publisher { get; set; }
        public int AvailableCount { get; set; }

        public int LibraryId { get; set; }
        public Library Library { get; set; }

        public ICollection<Borrow> Borrows { get; set; }
    }
}