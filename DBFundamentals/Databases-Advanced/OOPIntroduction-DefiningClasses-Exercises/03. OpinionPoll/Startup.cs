using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var people = new List<Person>();

        var personCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < personCount; i++)
        {
            var lineArgs = Console.ReadLine().Split();
            people.Add(new Person(lineArgs[0], int.Parse(lineArgs[1])));
        }

        people
            .Where(x => x.Age > 30)
            .OrderBy(x => x.Name)
            .ToList()
            .ForEach(x => Console.WriteLine(x));     
    }
}
