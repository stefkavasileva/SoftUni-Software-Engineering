using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models
{
    public class BorrowBookViewModel
    {
        public BorrowBookViewModel()
        {
            this.StartDate = DateTime.Today;
        }

        [Required]
        [Display(Name = "Borrower name")]
        public string BorrowerName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }
    }
}
