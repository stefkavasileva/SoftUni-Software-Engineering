using System;
using System.Collections.Generic;

public class RecordUniqueNames
{
    public static void Main()
    {
        var uniqueNames = new HashSet<string>();

        var namesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < namesCount; i++)
        {
            uniqueNames.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join(Environment.NewLine,uniqueNames));
    }
}