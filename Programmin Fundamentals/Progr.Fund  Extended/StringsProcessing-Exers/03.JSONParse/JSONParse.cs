using System;
using System.Collections.Generic;
using System.Linq;

public class JSONParse
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        inputLine = inputLine.Remove(0, 1);
        inputLine = inputLine.Remove(inputLine.Length - 1);

        var inputArgs = inputLine
            .Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < inputArgs.Length; i += 2)
        {
            var currentJSONArgs = inputArgs[i]
                .Split(":\",[]".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = currentJSONArgs[1];
            var age = int.Parse(currentJSONArgs[3]);
            var grades = currentJSONArgs.Length > 2 ?
                currentJSONArgs.Skip(5).ToList() :
                new List<string>();

            var gradesToString = grades.Any() ? string.Join(",", grades) : "None";

            Console.WriteLine($"{name} : {age} -> {gradesToString}");
        }
    }
}

