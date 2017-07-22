using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var citizens = new List<Citizen>();
        var pets = new List<Pet>();

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("End"))
        {
            var tokens = inputLine.Split();
            if (tokens[0].Equals("Citizen"))
            {
                citizens.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
            }
            else if (tokens[0].Equals("Pet"))
            {
                pets.Add(new Pet(tokens[1], tokens[2]));
            }

            inputLine = Console.ReadLine();
        }

        var year = Console.ReadLine();
        var dates = citizens
            .Where(x => x.Birthdate.EndsWith(year))
            .Select(x => x.Birthdate)
            .ToList()
            .Concat(pets.Where(x => x.Birthdate.EndsWith(year))
            .Select(x => x.Birthdate)
            .ToList());

        Console.WriteLine(string.Join(Environment.NewLine, dates));

    }
}