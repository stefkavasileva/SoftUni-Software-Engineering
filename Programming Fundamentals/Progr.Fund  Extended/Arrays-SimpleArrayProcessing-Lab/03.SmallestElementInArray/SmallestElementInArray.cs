using System;
using System.Linq;

public class SmallestElementInArray
{
    public static void Main()
    {
        Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Min());
    }
}