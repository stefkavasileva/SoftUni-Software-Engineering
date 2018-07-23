using System.Collections.Generic;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages
{
    public class IndexModel : BasePageModel
    {
        public IndexModel(BookLibraryContext context)
            : base(context)
        {
           
        }

        public ICollection<BookViewModel> BookViewModels { get; set; }

        public ICollection<MovieViewModel> MovieViewModels { get; set; }

        public void OnGet()
        {
            this.BookViewModels = this._context.Books.Include(e => e.Author)
                .Select(e => new BookViewModel
                {
                    Author = e.Author.Name,
                    Status = e.IsBorrowed ? "Borrowed" : "At home",
                    Title = e.Title,
                    AuthorId = e.AuthorId,
                    BookId = e.Id
                }).ToList();

            this.MovieViewModels = this._context.Movies.Include(e => e.Director)
                .Select(e => new MovieViewModel
                {
                    Director = e.Director.Name,
                    Status = e.IsBorrowed ? "Borrowed" : "At home",
                    Title = e.Title,
                    DirectorId = e.DirectorId,
                    MovieId = e.Id
                }).ToList();
        }
    }
}
