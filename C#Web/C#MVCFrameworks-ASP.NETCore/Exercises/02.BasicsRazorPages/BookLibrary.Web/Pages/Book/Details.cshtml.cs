using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages.Book
{
    public class DetailsModel : BasePageModel
    {
        public DetailsModel(BookLibraryContext context)
            : base(context)
        {
        }

        public BookDetailsViewModel Book { get; set; }

        public void OnGet(int id)
        {
            var bookDb = _context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);
            this.Book = new BookDetailsViewModel
            {
                Author = bookDb.Author.Name,
                Status = bookDb.IsBorrowed ? "Borrowed" : "At home",
                Title = bookDb.Title,
                Description = bookDb.Description,
                ImageUrl = bookDb.ImageUrl,
                Id = bookDb.Id
            };
        }

        public IActionResult OnGetReturnBook(int id)
        {
            var book = this._context.Books.Find(id);

            if (book == null)
            {
                return this.Page();
            }

            book.IsBorrowed = false;
            this._context.SaveChanges();

            return RedirectToPage("/Book/Details", new { id = book.Id });
        }

        public IActionResult OnGetDeleteBook(int id)
        {
            var bookDb = this._context.Books.Find(id);

            if (bookDb == null)
            {
                return this.Page();
            }

            this._context.Books.Remove(bookDb);

            var borrowerBook = this._context.BookBorrowerses.Where(e => e.BookId == id).ToList();
            if (borrowerBook.Any())
            {
                this._context.BookBorrowerses.RemoveRange(borrowerBook);
            }

            this._context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}