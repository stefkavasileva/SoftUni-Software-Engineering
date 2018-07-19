using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Borrower
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<BookBorrowers> BorrowersedBooks { get; set; }
        
    }
}
