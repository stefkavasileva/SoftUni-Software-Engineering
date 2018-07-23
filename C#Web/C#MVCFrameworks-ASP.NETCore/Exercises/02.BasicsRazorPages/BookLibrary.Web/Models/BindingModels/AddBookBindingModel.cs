using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models.BindingModels
{
    public class AddBookBindingModel
    {
        [Required(ErrorMessage = "The title is required")]
        [MinLength(5,ErrorMessage = "The title must be at least five characters long!")]
        [MaxLength(50, ErrorMessage = "The title must be lest then fifty characters long!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The author is required")]
        [MinLength(5, ErrorMessage = "The author must be at least five characters long!")]
        [MaxLength(50, ErrorMessage = "The author must be lest then fifty characters long!")]
        public string Author { get; set; }

        [MaxLength(300, ErrorMessage = "The description must be lest then three hundred characters long!")]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; set; }
    }
}
