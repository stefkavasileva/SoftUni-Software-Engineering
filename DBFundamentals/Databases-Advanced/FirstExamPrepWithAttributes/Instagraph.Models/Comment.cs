using System.ComponentModel.DataAnnotations;

namespace Instagraph.Models
{
    public class Comment
    {
        public Comment()
        {

        }

        public Comment(string content, User user, Post post)
        {
            this.Content = content;
            this.User = user;
            this.Post = post;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; }

        [Required]
        public User User { get; set; }
        public int UserId { get; set; }

        [Required]
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}