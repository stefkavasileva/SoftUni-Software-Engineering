using System.Collections.Generic;

namespace _09.PizzaTime
{
    public class Pizza
    {
        public Pizza(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }

        public string Name { get; set; }
        public int Group { get; set; }

        public static SortedDictionary<int, List<string>> AddPizza(Pizza pizza, SortedDictionary<int, List<string>> pizzas)
        {

            if (!pizzas.ContainsKey(pizza.Group))
            {
                pizzas.Add(pizza.Group, new List<string>());
            }

            ; pizzas[pizza.Group].Add(pizza.Name);

            return pizzas;
        }
    }
}
