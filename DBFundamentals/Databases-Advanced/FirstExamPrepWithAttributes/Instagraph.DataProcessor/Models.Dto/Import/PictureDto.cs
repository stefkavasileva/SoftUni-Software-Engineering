using System.ComponentModel.DataAnnotations;

namespace Instagraph.DataProcessor.Models.Dto.Import
{
    public class PictureDto
    {
        [Required]
        public string Path { get; set; }
       
        [Required]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal? Size { get; set; }
    }
}
