using System.Linq;
using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using    BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Pages.Book
{
    public class AddModel : PageModel
    {

        private BookLibraryContext _context;

        public AddModel(BookLibraryContext context)
        {
            this._context = context;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public IActionResult OnPostAddBook()
        {
            if (ModelState.IsValid)
            {
                var book = new BookLibrary.Models.Book();
                book.Title = Title;

                var author = _context.Authors.FirstOrDefault(a => a.Name == Author);
                if (author is null)
                {
                    author = new Author {Name = Author};
                }

                book.AuthorId = author.Id;
                book.ImageUrl = ImageUrl;

                this._context.Books.Add(book);
                this._context.SaveChanges();

                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}