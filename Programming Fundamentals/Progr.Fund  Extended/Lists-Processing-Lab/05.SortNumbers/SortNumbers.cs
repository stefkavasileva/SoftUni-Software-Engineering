using System;
using System.Collections.Generic;
using System.Linq;

public class SortNumbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        numbers.Sort();

        Console.WriteLine(string.Join(" <= ", numbers));
    }
}