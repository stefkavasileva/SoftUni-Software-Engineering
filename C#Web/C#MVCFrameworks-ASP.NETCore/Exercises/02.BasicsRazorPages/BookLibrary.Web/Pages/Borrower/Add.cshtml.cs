using BookLibrary.Data;
using BookLibrary.Web.Models;
using BookLibrary.Web.Models.BindingModels;
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
        public AddBorrowerBingingModel AddBorrowerBingingModel { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var borrower = new BookLibrary.Models.Borrower
                {
                    Name = this.AddBorrowerBingingModel.Name,
                    Address = this.AddBorrowerBingingModel.Address
                };

                this._context.Borrowers.Add(borrower);
                this._context.SaveChanges();
                return RedirectToPage("/Index");
            }


            return this.Page();
        }
    }
}