using System.Collections.Generic;

namespace HTTPServer.ByTheCakeApplication.Models
{
    public class Product
    {
        public Product()
        {
            this.Orders = new List<OrderProduct>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<OrderProduct> Orders { get; set; }
    }
}
