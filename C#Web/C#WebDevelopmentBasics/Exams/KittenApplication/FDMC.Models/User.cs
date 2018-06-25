using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FDMC.Models
{
    public class User
    {
        public User()
        {
            this.Kittens = new HashSet<Kitten>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Username  { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public ICollection<Kitten> Kittens { get; set; }
    }
}
