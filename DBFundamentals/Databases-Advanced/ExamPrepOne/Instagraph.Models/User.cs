using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instagraph.Models
{
    public class User
    {
        public User()
        {
            Followers = new HashSet<UserFollower>();
            UsersFollowing = new HashSet<UserFollower>();
            Posts = new HashSet<Post>();
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        public int ProfilePictureId { get; set; }

        [Required]
        public Picture ProfilePicture { get; set; }

        public ICollection<UserFollower> Followers { get; set; }

        public ICollection<UserFollower> UsersFollowing { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
