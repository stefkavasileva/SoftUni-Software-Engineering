using System;
using System.Collections.Generic;
using System.Linq;

public class LambadaExpressions
{
    public static void Main()
    {
        //80/100

        var inputLine = Console.ReadLine();
        var selectors = new List<Selector>();

        while (!inputLine.Equals("lambada"))
        {
            var tokens = inputLine
                .Split("=>. ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (tokens.Length != 1)
            {
                var name = tokens[0];
                var obj = tokens[1];
                var prop = tokens[2];

                if (!selectors.Any(x => x.Name == name))
                {
                    var selector = new Selector { Name = name, SelectorObj = obj, Property = prop };
                    selectors.Add(selector);
                }
                else
                {
                    var existingSelector = selectors.Where(x => x.Name == name).First();
                    existingSelector.SelectorObj = obj;
                    existingSelector.Property = prop;
                }

            }
            else
            {
                var count = 0;
                while (inputLine.Equals("dance"))
                {
                    count++;
                    inputLine = Console.ReadLine();
                }

                for (int i = 0; i < selectors.Count; i++)
                {
                    selectors[i].SelectorObj += string.Concat(Enumerable.Repeat($".{selectors[i].SelectorObj}", count));
                }

                if (!inputLine.Equals("lambda"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            inputLine = Console.ReadLine();
        }

        foreach (var selector in selectors)
        {
            Console.WriteLine($"{selector.Name} => {selector.SelectorObj}.{selector.Property}");
        }
    }
}

