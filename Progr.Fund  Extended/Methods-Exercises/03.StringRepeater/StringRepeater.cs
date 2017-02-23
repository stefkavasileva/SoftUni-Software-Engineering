using System;
using System.Linq;

public class StringRepeater
{
    public static void Main()
    {
        var inputStr = Console.ReadLine();
        var count = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Concat(Enumerable.Repeat(inputStr,count)));
    }
}

