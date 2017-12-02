using System.Collections.Generic;

namespace ProductsShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BuyerId { get; set; }
        public User Buyer { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; }

        public ICollection<CategoryProducts> CategoryProductses { get; set; } = new List<CategoryProducts>();
    }
}
