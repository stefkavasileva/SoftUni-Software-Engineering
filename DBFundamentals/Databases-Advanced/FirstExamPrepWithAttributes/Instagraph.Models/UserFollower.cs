using System.ComponentModel.DataAnnotations;

namespace Instagraph.Models
{
    public class UserFollower
    {
        public UserFollower()
        {

        }

        public UserFollower(User user, User follower)
        {
            this.User = user;
            this.Follower = follower;
        }

        [Required]
        public User User { get; set; }
        public int UserId { get; set; }

        [Required]
        public User Follower { get; set; }
        public int FollowerId { get; set; }
    }
}
