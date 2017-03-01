using System;
using System.Collections.Generic;
using System.Linq;

public class DistinctList
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        Console.WriteLine(string.Join(" ",numbers));
    }
}

