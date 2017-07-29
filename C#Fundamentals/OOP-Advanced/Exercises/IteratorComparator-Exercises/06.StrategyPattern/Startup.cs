using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var nameSorted = new SortedSet<Person>(new NameComparer());
        var ageSorted = new SortedSet<Person>(new AgeComparer());

        var counter = int.Parse(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            var personArgs = Console.ReadLine().Split();
            var person = new Person(personArgs[0], int.Parse(personArgs[1]));

            nameSorted.Add(person);
            ageSorted.Add(person);
        }

        Console.WriteLine(string.Join(Environment.NewLine, nameSorted));
        Console.WriteLine(string.Join(Environment.NewLine, ageSorted));
    }
}

