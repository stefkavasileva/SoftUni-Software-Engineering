using System.ComponentModel.DataAnnotations;

namespace MeTube.Models
{
    public class Tube
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Description { get; set; }
         
        [Required]
        public string YoutubeId { get; set; }

        public int Views { get; set; }

        public int UploaderId { get; set; }

        public User Uploader { get; set; }
    }
}
