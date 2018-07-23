using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models.BindingModels
{
    public class BorrowBindingModel
    {
        public BorrowBindingModel()
        {
            this.StartDate = DateTime.Today;
        }

        [Display(Name = "Borrower name")]
        [Required(ErrorMessage = "The borrower name is required")]
        [MinLength(5, ErrorMessage = "The borrower name must be at least five characters long!")]
        [MaxLength(50, ErrorMessage = "The borrower name must be lest then fifty characters long!")]
        public string BorrowerName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "The end date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }
    }
}
