using System.ComponentModel.DataAnnotations;

namespace Models.Dto
{
    public class UserPicDto
    {
        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        public string ProfilePicture { get; set; }
    }
}
