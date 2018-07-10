using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages.Author
{
    public class DetailsModel : PageModel
    {
        private BookLibraryContext _context;

        public DetailsModel(BookLibraryContext context)
        {
            this._context = context;
        }

        public AuthorDetailsViewModel BooksByAuthor { get; set; }

        public void OnGet(int id)
        {
            var author = this._context.Authors.Include(a=>a.Books).FirstOrDefault(a=>a.Id == id);
            this.BooksByAuthor = new AuthorDetailsViewModel
            {
                Name = author.Name,
                Books = author.Books.Select(b => new BookByAuthorViewModel
                {
                    Title = b.Title,
                    Id = b.Id,
                    Status = b.BorrowerId.HasValue ? "Borrowed" : "At home",
                }).ToList()
            };           
        }
    }
}