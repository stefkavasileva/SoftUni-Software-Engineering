using System;
using System.Collections.Generic;

namespace HTTPServer.ByTheCakeApplication.Models
{
    public class User
    {
        public User()
        {
            this.Orders = new List<Order>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
