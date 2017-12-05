using System.Collections.Generic;

namespace Instagraph.Models
{
    public class User
    {
        public User()
        {
            Followers = new HashSet<UsersFollowers>();
            UsersFollowing = new HashSet<UsersFollowers>();
            Posts = new HashSet<Post>();
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int ProfilePictureId { get; set; }
        public Picture ProfilePicture { get; set; }

        public ICollection<UsersFollowers> Followers { get; set; }

        public ICollection<UsersFollowers> UsersFollowing { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
