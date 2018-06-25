using System.ComponentModel.DataAnnotations;

namespace FDMC.Models
{
    public class Kitten
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        public string Breed { get; set; }

        public int OwnerId { get; set; }

        public User Owner { get; set; }
    }
}
