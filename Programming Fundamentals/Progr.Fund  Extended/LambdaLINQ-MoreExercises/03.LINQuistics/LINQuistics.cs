using System;
using System.Collections.Generic;
using System.Linq;

public class LINQuistics
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var collections = new Dictionary<string, HashSet<string>>();

        while (!inputLine.Equals("exit"))
        {
            var tokens = inputLine.Split(".( )".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 1)
            {
                var result = new List<string>();

                try
                {
                    var count = int.Parse(tokens[0]);

                    result = collections
                        .OrderByDescending(x => x.Value.Count)
                        .First()
                        .Value
                        .OrderBy(x => x.Length)
                        .Take(int.Parse(tokens[0]))
                        .ToList();
                }
                catch (Exception)
                {
                    if (!collections.ContainsKey(tokens[0]))
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    result = collections[inputLine]
                        .OrderByDescending(x => x.Length)
                       .ThenByDescending(x => x.Distinct().Count())
                        .ToList();

                }

                foreach (var item in result)
                {
                    Console.WriteLine($"* {item}");
                }

            }

            var name = tokens[0];
            var methods = tokens.Skip(1).ToList();

            if (!collections.ContainsKey(name))
            {
                collections.Add(name, new HashSet<string>());
            }

            methods.ForEach(x => collections[name].Add(x));

            inputLine = Console.ReadLine();
        }

        var comandArgs = Console.ReadLine().Split();
        var methodName = comandArgs[0];
        var selection = comandArgs[1];

        var collectionResult = collections
            .Where(x => x.Value.Contains(methodName))
            .OrderByDescending(x => x.Value.Count())
            .ThenByDescending(x => x.Value.Min(y => y.Length))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var collection in collectionResult)
        {
            Console.WriteLine(collection.Key);

            if (selection.Equals("all"))
            {

                foreach (var item in collection.Value.OrderByDescending(x => x.Length))
                {
                    Console.WriteLine($"* {item}");
                }

            }
        }
    }
}

