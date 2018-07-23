using System.Collections.Generic;

namespace BookLibrary.Web.Models
{
    public class DirectorDetailsViewModel
    {
        public DirectorDetailsViewModel()
        {
            this.Movies = new List<MovieByAuthorViewModel>();
        }

        public string Name { get; set; }

        public ICollection<MovieByAuthorViewModel> Movies { get; set; }
    }
}
