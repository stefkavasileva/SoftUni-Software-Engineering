using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var people = new List<Person>();

        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var personInfo = Console.ReadLine().Split();
            var name = personInfo[0];
            var age = int.Parse(personInfo[1]);

            var person = new Person(name, age);
            people.Add(person);
        }

        var result = people.Where(p => p.Age > 30).ToList().OrderBy(p => p.Name);

        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

