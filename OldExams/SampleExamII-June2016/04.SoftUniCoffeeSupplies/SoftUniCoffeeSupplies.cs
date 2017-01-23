using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniCoffeeSupplies
{
    static void Main(string[] args)
    {
        char[] delimiters = Console.ReadLine().Split().Select(char.Parse).ToArray();

        Dictionary<string, string> personOrders = new Dictionary<string, string>();
        Dictionary<string, int> coffeQuantity = new Dictionary<string, int>();

        string inputLine = Console.ReadLine();
        while (!inputLine.Equals("end of info"))
        {
            string[] inputArgs = inputLine.Split(delimiters).ToArray();
            int quantity = 0;
            string personName = string.Empty;

            try
            {
                quantity = int.Parse(inputArgs[1]);
            }
            catch (Exception)
            {
                personName = inputArgs[0];        
            }

            if (string.IsNullOrEmpty(personName))
            {
                if (!personOrders.ContainsKey(personName))
                {
                    personOrders.Add(personName, string.Empty);
                }

                personOrders[personName] = inputArgs[1];
            }
            else
            {
                if (!coffeQuantity.ContainsKey(inputArgs[0]))
                {
                    coffeQuantity.Add(inputArgs[0], 0);
                }

                coffeQuantity[inputArgs[0]] +=quantity;
            }    
            inputLine = Console.ReadLine();
        }
    }
}

