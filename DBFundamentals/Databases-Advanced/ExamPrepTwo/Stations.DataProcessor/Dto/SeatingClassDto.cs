using System.ComponentModel.DataAnnotations;

namespace Stations.DataProcessor.Dto
{
    public class SeatingClassDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MinLength(2), MaxLength(2)]
        public string Abbreviation { get; set; }
    }
}
