using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Book
    {
        public Book()
        {
            this.Borrowerses = new List<BookBorrowers>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public string ImageUrl { get; set; }

        public bool IsBorrowed { get; set; }

        public ICollection<BookBorrowers> Borrowerses { get; set; }
    }
}
