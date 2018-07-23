using System.Linq;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Web.Models;
using BookLibrary.Web.Models.BindingModels;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Pages.Book
{
    public class BorrowModel : BasePageModel
    {
        public BorrowModel(BookLibraryContext context)
            : base(context)
        {
            this.BorrowBookBindingModel = new BorrowBindingModel();
        }

        [BindProperty]
        public BorrowBindingModel BorrowBookBindingModel { get; set; }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

            if (this.BorrowBookBindingModel.StartDate > this.BorrowBookBindingModel.EndDate)
            {
                return this.Page();
            }

            var borrower = this._context
                .Borrowers
                .FirstOrDefault(x => x.Name.Equals(BorrowBookBindingModel.BorrowerName));

            if (borrower == null)
            {
                borrower = new BookLibrary.Models.Borrower {Name = BorrowBookBindingModel.BorrowerName};

                this._context.Borrowers.Add(borrower);
                this._context.SaveChanges();
            }

            var book = this._context.Books.Find(id);
        
            if (book == null)
            {
                return this.Page();
            }

            this._context.BookBorrowerses.Add(new BookBorrowers
            {
                BookId = book.Id,
                BorrowDate = this.BorrowBookBindingModel.StartDate,
                BorrowerId = borrower.Id,
                ReturnDate = this.BorrowBookBindingModel.EndDate
            });

            book.IsBorrowed = true;
            this._context.SaveChanges();
            return RedirectToPage("/Book/Details", new { id = id });
        }      
    }
}