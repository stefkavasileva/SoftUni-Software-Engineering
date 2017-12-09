using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Instagraph.Models
{
    public class User
    {
        public User()
        {
            this.Posts = new HashSet<Post>();
            this.Comments = new HashSet<Comment>();
        }

        public User(string username, string password, Picture profilePicture)
            : this()
        {
            this.Username = username;
            this.Password = password;
            this.ProfilePicture = profilePicture;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        public Picture ProfilePicture { get; set; }
        public int ProfilePictureId { get; set; }

        public ICollection<UserFollower> Followers { get; set; }

        public ICollection<UserFollower> UsersFollowing { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}