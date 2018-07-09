using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(30)]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public int AuthorId { get; set; }
        
        public Author Author { get; set; }

        public string ImageUrl { get; set; }
    
        public int? BorrowerId { get; set; }

        public Borrower Borrower { get; set; }
    }
}
