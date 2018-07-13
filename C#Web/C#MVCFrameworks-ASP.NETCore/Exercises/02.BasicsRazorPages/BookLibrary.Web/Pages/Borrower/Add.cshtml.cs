using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Web.Pages.Borrower
{
    public class AddModel : PageModel
    {
        private BookLibraryContext _context;

        public AddModel(BookLibraryContext context)
        {
            this._context = context;
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