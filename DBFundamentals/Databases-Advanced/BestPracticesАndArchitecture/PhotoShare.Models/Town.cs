namespace PhotoShare.Models
{
    using System.Collections.Generic;

    public class Town
    {
        public Town()
        {
            this.UsersBornInTown = new HashSet<User>();
            this.UsersCurrentlyLivingInTown = new HashSet<User>();
        }

        public Town(string name, string country)
            : this()
        {
            this.Name = name;
            this.Country = country;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<User> UsersBornInTown { get; set; }

        public ICollection<User> UsersCurrentlyLivingInTown { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, {this.Country}";
        }
    }
}
