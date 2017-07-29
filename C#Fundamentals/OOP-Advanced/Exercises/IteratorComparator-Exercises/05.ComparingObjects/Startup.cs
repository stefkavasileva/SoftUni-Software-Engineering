using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var people = new List<Person>();

        var inputLine = Console.ReadLine();

        while (!inputLine.Equals("END"))
        {
            var personArgs = inputLine.Split();
            people.Add(new Person(personArgs[0], int.Parse(personArgs[1]), personArgs[2]));
            inputLine = Console.ReadLine();
        }

        var personIndex = int.Parse(Console.ReadLine());

        var equalsPeopleCount = GetEqualsPeople(people[personIndex - 1], people);
        var notEqualsPeopleCount = GetNotEqualsPeople(people[personIndex - 1], people);

        if (equalsPeopleCount == 0 || equalsPeopleCount == 1)
        {
            Console.WriteLine("No matches");
            return;
        }

        Console.WriteLine($"{equalsPeopleCount} {notEqualsPeopleCount} {people.Count}");
    }

    private static int GetNotEqualsPeople(Person person, List<Person> people)
    {
        var counter = 0;
        foreach (var currentPerson in people)
        {
            if (person.CompareTo(currentPerson) != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    private static int GetEqualsPeople(Person person, List<Person> people)
    {
        var counter = 0;
        foreach (var currentPerson in people)
        {
            if (person.CompareTo(currentPerson) == 0)
            {
                counter++;
            }
        }

        return counter;
    }
}

