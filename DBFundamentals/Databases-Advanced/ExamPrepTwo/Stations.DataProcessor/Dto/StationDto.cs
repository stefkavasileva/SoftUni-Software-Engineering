using System.ComponentModel.DataAnnotations;

namespace Stations.DataProcessor.Dto
{
    public class StationDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Town { get; set; }
    }
}
