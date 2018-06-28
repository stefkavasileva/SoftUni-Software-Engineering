using System.ComponentModel.DataAnnotations;

namespace MeTube.App.Models.BindingModels
{
    public class TubeUploadBindingModel
    {
        [Required(ErrorMessage = "Title is required")]
        [MinLength(5,ErrorMessage = "Title must be at least five cheracters long")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Link is required")]
        public string YouTubeLink { get; set; }

        public string Description { get; set; }
    }
}
