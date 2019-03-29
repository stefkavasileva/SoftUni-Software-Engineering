using System;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {    
        Console.WriteLine(
            string.Join(" ",Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(n=>n)
            .Take(3).ToArray()));
    }
}

