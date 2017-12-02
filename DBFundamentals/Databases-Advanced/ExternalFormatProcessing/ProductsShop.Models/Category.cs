using System.Collections.Generic;

namespace ProductsShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CategoryProducts> CategoryProductses { get; set; } = new List<CategoryProducts>();
    }
}
