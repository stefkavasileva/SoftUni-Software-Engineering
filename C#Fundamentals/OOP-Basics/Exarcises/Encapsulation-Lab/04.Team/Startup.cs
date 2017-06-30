using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var team = new Team("Test");

        for (int i = 0; i < count; i++)
        {
            var tokens = Console.ReadLine().Split().ToArray();
            var person = new Person(tokens[0],tokens[1],int.Parse(tokens[2]));
            team.AddPlayer(person);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reverse team have {team.ReserveTeam.Count} players");
    }
}

