using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        IList<IPerson> people = new List<IPerson>();

        var numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            var inputLine = Console.ReadLine();
            people.Add(CreatePerson(inputLine));
        }

        var name = Console.ReadLine();
        while (!name.Equals("End"))
        {
            AddFood(name, people);
            name = Console.ReadLine();
        }

        Console.WriteLine(people.Sum(x => x.Food));
    }

    private static void AddFood(string name, IList<IPerson> people)
    {
        if (people.Any(p => p.Name == name))
        {
            people.First(x => x.Name == name).BuyFood();
        }
    }

    private static IPerson CreatePerson(string inputLine)
    {
        var tokens = inputLine.Split();

        if (tokens.Length == 3)
        {
            return new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
        }

        return new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
    }
}

