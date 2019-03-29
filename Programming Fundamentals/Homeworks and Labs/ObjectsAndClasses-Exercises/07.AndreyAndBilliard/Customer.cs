namespace _07.AndreyAndBilliard
{
    using System.Collections.Generic;

    public class Customer
    {
        public Customer(string name, Dictionary<string, int> shopList)
        {
            this.Name = name;
            this.ShopList = shopList;
        }

        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }
    }
}