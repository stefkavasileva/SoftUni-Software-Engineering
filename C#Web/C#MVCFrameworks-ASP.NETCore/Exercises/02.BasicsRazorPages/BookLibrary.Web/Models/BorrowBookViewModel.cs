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
        public string BorrowerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
