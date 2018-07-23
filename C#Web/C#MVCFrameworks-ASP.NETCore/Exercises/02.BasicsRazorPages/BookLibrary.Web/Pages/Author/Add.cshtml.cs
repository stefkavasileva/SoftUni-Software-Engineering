using System.ComponentModel.DataAnnotations;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Pages.Author
{
    public class AddModel : BasePageModel
    {
        public AddModel(BookLibraryContext context)
            : base(context)
        {
        }

        [BindProperty]
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3,ErrorMessage = "The name must be at least three cheracters long.")]
        public string Name { get; set; }

        public IActionResult OnPost()
        {
            var author = new BookLibrary.Models.Author {Name = this.Name};
            this._context.Authors.Add(author);
            this._context.SaveChanges();

            return RedirectToPage("/Index");
        }
    }
}