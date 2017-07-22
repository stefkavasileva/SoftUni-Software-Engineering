using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var individul = new List<IIndividual>();

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("End"))
        {
            var parsetResult = ParseData(inputLine);
            individul.Add(parsetResult);
            inputLine = Console.ReadLine();
        }

        var fakeId = Console.ReadLine();
        var ids = individul.Where(x => x.Id.EndsWith(fakeId)).Select(x => x.Id).ToList();
        Console.WriteLine(string.Join(Environment.NewLine,ids));

    }

    private static IIndividual ParseData(string inputLine)
    {
        var tokens = inputLine.Split();
        if (tokens.Length == 2)
        {
            return new Citizen(tokens[0], tokens[1]);
        }

        return new Robot(tokens[0], int.Parse(tokens[1]), tokens[2]);
    }
}