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

        public IQueryable<BookViewModel> BookViewModels { get; set; }

        public void OnGet()
        {
            this.BookViewModels = this._context.Books.Include(e => e.Author)
                .Select(e => new BookViewModel
                {
                    Author = e.Author.Name,
                    Status = e.BorrowerId.HasValue ? "Borrowed" : "At home",
                    Title = e.Title,
                    AuthorId = e.AuthorId,
                    BookId = e.Id
                });
        }
    }
}
