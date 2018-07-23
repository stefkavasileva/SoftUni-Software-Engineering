using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models.BindingModels
{
    public class AddBorrowerBingingModel
    {
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3, ErrorMessage = "The name must be at least three characters long!")]
        [MaxLength(20, ErrorMessage = "The name must be lest then twenty characters long!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The address is required")]
        [MaxLength(50, ErrorMessage = "The address must be lest then two hundred characters long!")]
        public string Address { get; set; }
    }
}
