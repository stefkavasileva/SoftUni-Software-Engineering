using System.ComponentModel.DataAnnotations;

namespace Instagraph.DataProcessor.Models.Dto.Import
{
    public class UserFollowerDto
    {
        [Required]
        public string User { get; set; }

        [Required]
        public string Follower { get; set; }
    }
}
