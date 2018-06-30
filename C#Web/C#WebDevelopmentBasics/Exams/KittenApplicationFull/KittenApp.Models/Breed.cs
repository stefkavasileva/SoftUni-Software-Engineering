namespace KittenApp.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Breed
    {
        public Breed()
        {
            this.Kittens = new List<Kitten>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public ICollection<Kitten> Kittens { get; set; }
    }
}
