using System.ComponentModel.DataAnnotations;

namespace Models.Dto
{
    public class FollowerUserDto
    {
        [Required]
        [MaxLength(30)]
        public string User { get; set; }

        [Required]
        [MaxLength(30)]
        public string Follower { get; set; }
    }
}
