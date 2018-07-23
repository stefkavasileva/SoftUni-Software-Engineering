using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Borrower
    {
        public Borrower()
        {
            this.BorrowersedMovies = new List<MovieBorrowers>();
            this.BorrowersedBooks = new List<BookBorrowers>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<BookBorrowers> BorrowersedBooks { get; set; }

        public ICollection<MovieBorrowers> BorrowersedMovies { get; set; }
    }
}
