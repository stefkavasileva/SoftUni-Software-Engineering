using System;
using System.Collections.Generic;
using System.Linq;

public class AppendLists
{
    public static void Main()
    {
        char[] delimiter = " ".ToCharArray();

        List<string> inputLists = Console.ReadLine()
            .Split('|')
            .Reverse()
            .ToList();

        List<string> reversedElements = new List<string>();

        for (int i = 0; i < inputLists.Count; i++)
        {
            List<string> tempElements = inputLists[i]
                .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            reversedElements.AddRange(tempElements);
        }

        Console.WriteLine(string.Join(" ", reversedElements));
    }
}
