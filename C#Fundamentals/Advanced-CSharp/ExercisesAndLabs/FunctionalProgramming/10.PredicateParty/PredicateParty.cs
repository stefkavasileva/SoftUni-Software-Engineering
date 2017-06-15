using System;
using System.Collections.Generic;
using System.Linq;

public class PredicateParty
{
    public static void Main()
    {
        var guests = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();

        var comand = Console.ReadLine();
        while (!comand.Equals("Party!"))
        {           
            var commandArgs = comand.Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries);
            var currentComand = commandArgs[1];

            if (currentComand.Equals("StartsWith"))
            {
                ForeachName(commandArgs[0], guests, n => n.StartsWith(commandArgs[2]));
            }
            else if (currentComand.Equals("EndsWith"))
            {
                ForeachName(commandArgs[0], guests, n => n.EndsWith(commandArgs[2]));
            }
            else if (currentComand.Equals("Length"))
            {
                ForeachName(commandArgs[0], guests, n => n.Length == int.Parse(commandArgs[2]));
            }

            comand = Console.ReadLine();
        }

        PrintResult(guests);

    }

    private static void PrintResult(List<string> guests)
    {
        var guestsNames = string.Join(", ", guests);
        if (!guestsNames.Any())
        {
            Console.WriteLine("Nobody is going to the party!");
            return;
        }

        Console.WriteLine($"{guestsNames} are going to the party!");
    }

    private static void ForeachName(string command, List<string> guestList, Func<string, bool> condition)
    {
        for (int i = guestList.Count - 1; i >= 0; i--)
        {
            if (condition(guestList[i]))
            {
                switch (command)
                {
                    case "Remove":
                        guestList.RemoveAt(i);
                        break;
                    case "Double":
                        guestList.Add(guestList[i]);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

