using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Pages.Book
{
    public class BorrowModel : BasePageModel
    {
        public BorrowModel(BookLibraryContext context)
            : base(context)
        {
            this.BorrowBookViewModel = new BorrowBookViewModel();
        }

        [BindProperty]
        public BorrowBookViewModel BorrowBookViewModel { get; set; }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

            if (this.BorrowBookViewModel.StartDate > this.BorrowBookViewModel.EndDate)
            {
                return this.Page();
            }

            var borrower = this._context
                .Borrowers
                .FirstOrDefault(x => x.Name.Equals(BorrowBookViewModel.BorrowerName));

            if (borrower == null)
            {
                borrower = new BookLibrary.Models.Borrower {Name = BorrowBookViewModel.BorrowerName};

                this._context.Borrowers.Add(borrower);
                this._context.SaveChanges();
            }

            var book = this._context.Books.Find(id);

            if (book == null)
            {
                return this.Page();
            }

            borrower.BorrowedBooks.Add(book);
            this._context.SaveChanges();
            return RedirectToPage("/Book/Details", new {id = id});
        }
    }
}