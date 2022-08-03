using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Borrow
    {
        [Key]
        [Column(Order = 1)]
        public int MemberId { get; set; }
        public Member Member { get; set; }

        [Key]
        [Column(Order = 2)]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime BorrowDate { get; set; }

        public DateTime SpecifiedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
    }
}