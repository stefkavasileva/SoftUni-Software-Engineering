using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Web.Models.BindingModels
{
    public class AddDirectorBindingModel
    {
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3, ErrorMessage = "The name must be at least three cheracters long.")]
        public string Name { get; set; }
    }
}
