using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;
namespace BookLibrary.Web.Pages.Borrower
{
    public class AddModel : BasePageModel
    {
        public AddModel(BookLibraryContext context)
            : base(context)
        {
        }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Address { get; set; }

        public IActionResult OnGet()
        {
            if (ModelState.IsValid)
            {
                var borrower = new BookLibrary.Models.Borrower
                {
                    Name = this.Name,
                    Address = this.Address
                };

                this._context.Borrowers.Add(borrower);
                this._context.SaveChanges();
                return RedirectToPage("/Index");
            }


            return this.Page();
        }
    }
}