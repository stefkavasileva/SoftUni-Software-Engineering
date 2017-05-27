using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main()
    {
        var nameCount = int.Parse(Console.ReadLine());
        var uniqueNames = new HashSet<string>();

        for (int i = 0; i < nameCount; i++)
        {
            var currentName = Console.ReadLine();
            uniqueNames.Add(currentName);
        }

        foreach (var uniqueName in uniqueNames)
        {
            Console.WriteLine(uniqueName);
        }
    }
}
