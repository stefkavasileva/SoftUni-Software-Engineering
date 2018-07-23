using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models
{
    public class MovieDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Poster URL")]
        public string PosterUrl { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}
