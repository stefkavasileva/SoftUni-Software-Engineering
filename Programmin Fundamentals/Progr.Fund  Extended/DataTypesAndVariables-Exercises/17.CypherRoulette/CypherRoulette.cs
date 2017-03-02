using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CypherRoulette
{
    public static void Main()
    {
        ////80/100
        var count = int.Parse(Console.ReadLine());
        var comands = new List<string>();

        for (int i = 0; i < count; i++)
        {
            var currentComand = Console.ReadLine();
            comands.Add(currentComand);
            i = currentComand.Equals("spin") ? --i : i;
        }

        var result = new StringBuilder();
        var end = true;
        var mustAdd = true;

        for (int i = 0; i < comands.Count; i++)
        {
            var currentComands = comands.Skip(i).Take(2);

            if (currentComands.First().Equals("spin"))
            {
                if (currentComands.Last().Equals("spin") && currentComands.Count() == 2)
                {
                    result.Clear();
                    mustAdd = false;
                    i ++;
                }

                end = !end;
                mustAdd = false;
            }
            else if (currentComands.First().Equals(currentComands.Last()) && currentComands.Count() == 2)
            {
                result.Clear();
                i ++;
                mustAdd = false;

            }

            if (end && mustAdd)
            {
                result.Append(currentComands.First());
            }
            else if (mustAdd)
            {
                result.Insert(0, currentComands.First());
            }

            mustAdd = true;
        }

        Console.WriteLine(result);
    }
}
