using System.Collections.Generic;

namespace BookLibrary.Models
{
   public class Movie
    {
        public Movie()
        {
            this.Borrowerses = new List<MovieBorrowers>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int DirectorId { get; set; }

        public Director Director { get; set; }

        public string PosterImageUrl { get; set; }

        public bool IsBorrowed { get; set; }    

        public ICollection<MovieBorrowers> Borrowerses { get; set; }
    }
}
