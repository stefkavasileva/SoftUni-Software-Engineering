using System.Collections.Generic;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages.Book
{
    public class DetailsModel : PageModel
    {
        private BookLibraryContext _context;

        public DetailsModel(BookLibraryContext context)
        {
            this._context = context;
        }

        public BookDetailsViewModel Book { get; set; }

        public void OnGet(int id)
        {
            var bookDb = _context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);
            this.Book = new BookDetailsViewModel
            {
                Author = bookDb.Author.Name,
                Status = bookDb.BorrowerId.HasValue ? "Borrowed" : "At home",
                Title = bookDb.Title,
                Description = bookDb.Description,
                ImageUrl = bookDb.ImageUrl,
            };
        }
    }
}