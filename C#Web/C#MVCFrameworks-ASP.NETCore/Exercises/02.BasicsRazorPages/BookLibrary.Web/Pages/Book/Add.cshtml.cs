using System.ComponentModel.DataAnnotations;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Pages.Book
{
    public class AddModel : BasePageModel
    {
        public AddModel(BookLibraryContext context) 
            : base(context)
        {
        }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Author { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        [Display(Name = "Image URL")]
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
                    author = new BookLibrary.Models.Author {Name = Author};
                    this._context.Authors.Add(author);
                    this._context.SaveChanges();
                }

                book.AuthorId = author.Id;
                book.ImageUrl = ImageUrl;
                book.Description = Description;

                this._context.Books.Add(book);
                this._context.SaveChanges();

                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}