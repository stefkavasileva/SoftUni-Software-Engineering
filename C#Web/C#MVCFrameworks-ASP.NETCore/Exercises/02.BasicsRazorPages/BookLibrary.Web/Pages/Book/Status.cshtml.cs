using System.Collections.Generic;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages.Book
{
    public class StatusModel : BasePageModel
    {
        public StatusModel(BookLibraryContext context)
            : base(context)
        {
        }

        public ICollection<StatusViewModel> StatusViewModels { get; set; }

        public string BookTitle { get; set; }

        public IActionResult OnGet(int id)
        {
            var borrowedBooks = this._context.BookBorrowerses
                .Include(e=>e.Book)
                .Include(e=>e.Borrower)
                .Where(e => e.BookId == id)
                .ToList();

            this.BookTitle = this._context.Books.Find(id).Title;

            if (borrowedBooks.Count == 0)
            {
                this.StatusViewModels = new List<StatusViewModel>();
                return this.Page();
            }

           

            var result = new List<StatusViewModel>();

            foreach (var bookBorrowerse in borrowedBooks)
            {
                var period = bookBorrowerse.BorrowDate.ToString("yyyy-MM-dd") +" : "+ bookBorrowerse.ReturnDate.ToString("yyyy-MM-dd");
                result.Add(new StatusViewModel
                {
                    BorrowerName = bookBorrowerse.Borrower.Name,
                    Period = period,                 
                });
            }

            this.StatusViewModels = result;
            return this.Page();
        }

    
    }
}