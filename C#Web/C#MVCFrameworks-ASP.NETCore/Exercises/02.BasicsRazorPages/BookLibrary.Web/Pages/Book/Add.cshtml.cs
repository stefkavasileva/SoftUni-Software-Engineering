using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using BookLibrary.Web.Models.BindingModels;
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
        public AddBookBindingModel AddBookBindingModel { get; set; }

        public IActionResult OnPostAddBook()
        {
            if (ModelState.IsValid)
            {
                var book = new BookLibrary.Models.Book();
                book.Title = this.AddBookBindingModel.Title;

                var author = _context.Authors.FirstOrDefault(a => a.Name == this.AddBookBindingModel.Author);
                if (author is null)
                {
                    author = new BookLibrary.Models.Author {Name = this.AddBookBindingModel.Author };
                    this._context.Authors.Add(author);
                    this._context.SaveChanges();
                }

                book.AuthorId = author.Id;
                book.ImageUrl = this.AddBookBindingModel.ImageUrl;
                book.Description = this.AddBookBindingModel.Description;

                this._context.Books.Add(book);
                this._context.SaveChanges();

                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}