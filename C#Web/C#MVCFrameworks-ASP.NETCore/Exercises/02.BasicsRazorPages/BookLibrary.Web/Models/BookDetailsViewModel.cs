using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}
