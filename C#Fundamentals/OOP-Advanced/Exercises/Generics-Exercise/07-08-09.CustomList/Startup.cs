using System;
using System.Collections.Generic;

public class Startup
{
   
    public static void Main()
    {
      ICustomList<string> myList = new CustomList<string>();

        var command = Console.ReadLine();
        while (!command.Equals("END"))
        {
            Execute(command, myList);
            command = Console.ReadLine();
        }
    }

    private static void Execute(string command, ICustomList<string> myList)
    {
        var commandArgs = command.Split();
        switch (commandArgs[0])
        {
            case "Add":
                myList.Add(commandArgs[1]);
                break;
            case "Remove":
                myList.Remove(int.Parse(commandArgs[1]));
                break;
            case "Contains":
                Console.WriteLine(myList.Contains(commandArgs[1]));
                break;
            case "Swap":
                myList.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                break;
            case "Greater":
                Console.WriteLine(myList.CountGreaterThan(commandArgs[1]));
                break;
            case "Min":
                Console.WriteLine(myList.Min());
                break;
            case "Max":
                Console.WriteLine(myList.Max());
                break;
            case "Print":
                Console.WriteLine(string.Join(Environment.NewLine, myList));
                break;
            case "Sort":
               myList.Sort();
                break;
            default:
                break;
        }
    }
}

