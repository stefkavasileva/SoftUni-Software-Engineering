using System.Collections.Generic;

namespace ProductsShop.Models
{
    public class User
    {
        public User()
        {
            
        }

        public User(string firstName, string lastName, int? age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public ICollection<Product> SoldProducts { get; set; } = new List<Product>();

        public ICollection<Product> BougthProducts { get; set; } = new List<Product>();
    }
}
