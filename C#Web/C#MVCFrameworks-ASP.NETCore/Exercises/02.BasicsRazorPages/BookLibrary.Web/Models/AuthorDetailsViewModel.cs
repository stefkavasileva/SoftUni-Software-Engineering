using System.Collections.Generic;

namespace BookLibrary.Web.Models
{
    public class AuthorDetailsViewModel
    {
        public AuthorDetailsViewModel()
        {
            this.Books = new List<BookByAuthorViewModel>();
        }

        public string Name { get; set; }

        public ICollection<BookByAuthorViewModel> Books { get; set; }
    }
}
