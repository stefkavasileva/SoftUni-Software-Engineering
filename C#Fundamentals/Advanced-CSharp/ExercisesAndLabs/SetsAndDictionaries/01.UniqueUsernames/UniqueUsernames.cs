using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main()
    {
        var namesCount = int.Parse(Console.ReadLine());
        var uniqueNames = new HashSet<string>();

        for (int i = 0; i < namesCount; i++)
        {
            uniqueNames.Add(Console.ReadLine());
        }

        Console.Write(string.Join(Environment.NewLine, uniqueNames));
    }
}
