using System;
using System.Collections.Generic;

public class AMinersTask
{
    public static void Main()
    {
        var resourses = new Dictionary<string, long>();
        while (true)
        {
            var resourse = Console.ReadLine();
            if (resourse.Equals("stop")) break;

            var quantity = int.Parse(Console.ReadLine());

            if (!resourses.ContainsKey(resourse))
            {
                resourses.Add(resourse,0);
            }

            resourses[resourse] += quantity;
        }

        foreach (var kvp in resourses)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}