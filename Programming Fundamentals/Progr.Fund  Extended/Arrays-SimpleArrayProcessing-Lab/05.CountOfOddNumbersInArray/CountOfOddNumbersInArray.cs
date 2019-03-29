using System;
using System.Linq;

public class CountOfOddNumbersInArray
{
    public static void Main()
    {
        Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 != 0).Count());
    }
}
