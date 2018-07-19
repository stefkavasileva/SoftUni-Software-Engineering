using System;

namespace BookLibrary.Models
{
    public class BookBorrowers
    {
        public int BookId { get; set; }

        public Book Book { get; set; }

        public int BorrowerId { get; set; }

        public Borrower Borrower { get; set; }

        public DateTime ReturnDate { get; set; }

        public DateTime BorrowDate { get; set; }

        public bool IsBookReturned { get; set; }    
    }
}
