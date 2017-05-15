using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _09.PizzaTime
{  
    public class StartUp
    {
        public static void Main()
        {
            var pizzas = new SortedDictionary<int, List<string>>();

            var tokens = Console.ReadLine().Split();
            foreach (var token in tokens)
            {
                var key = int.Parse(new string(token.TakeWhile(x => char.IsDigit(x)).ToArray()));
                var value = new string(token.SkipWhile(x => char.IsDigit(x)).ToArray());
                var pizza = new Pizza(value, key);
                pizzas = Pizza.AddPizza(pizza,pizzas);
            }

            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            foreach (var pizza in pizzas)
            {
                Console.WriteLine($"{pizza.Key} - {string.Join(", ",pizza.Value)}");
            }
        }
    }
}
