using System;
using System.Collections.Generic;

namespace HTTPServer.ByTheCakeApplication.Models
{
    public class Order
    {
        public Order()
        {
            this.Products = new List<OrderProduct>();
        }

        public int Id { get; set; }

        public DateTime DateOfCreation  { get; set; }

        public ICollection<OrderProduct> Products { get; set; }
    }
}
