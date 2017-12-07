using System.Collections.Generic;

namespace Instagraph.Models
{
    public class Picture
    {
        public Picture()
        {
            this.Posts = new HashSet<Post>();
            this.Users = new HashSet<User>();
        }

        public int Id { get; set; }

        public string Path { get; set; }

        public decimal Size { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
