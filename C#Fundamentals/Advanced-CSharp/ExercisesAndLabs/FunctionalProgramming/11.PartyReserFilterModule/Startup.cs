using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReserFilterModule
{
    public class Startup
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var filters = new List<string>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("Print"))
            {
                var lineArgs = inputLine.Split(new[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (lineArgs[0].Equals("Add"))
                {
                    filters.Add($"{lineArgs[2]} {lineArgs[lineArgs.Length - 1]}");
                }
                else if (lineArgs[0].Equals("Remove"))
                {
                    for (int i = 0; i < filters.Count; i++)
                    {
                        var currentFileter = $"{lineArgs[2]} {lineArgs[lineArgs.Length - 1]}";
                        if (filters[i].Equals(currentFileter)) filters.RemoveAt(i);
                    }
                }

                inputLine = Console.ReadLine();
            }

            names = AddFilters(filters, names);
            Print(names);
        }

        private static List<string> AddFilters(List<string> filters, List<string> names)
        {
            foreach (var filter in filters)
            {
                if (filter.Contains("Starts"))
                {
                    names = names.Where(x => !x.StartsWith(filter.Split().Last())).ToList();
                }
                else if (filter.Contains("Ends"))
                {
                    names = names.Where(x => !x.EndsWith(filter.Split().Last())).ToList();
                }
                else if (filter.Contains("Length"))
                {
                    names = names.Where(x => !x.Length.Equals(int.Parse(filter.Split().Last()))).ToList();
                }
                else
                {
                    names = names.Where(x => !x.Contains(filter.Split().Last())).ToList();
                }
            }

            return names;
        }

        private static void Print(List<string> names)
        {
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
