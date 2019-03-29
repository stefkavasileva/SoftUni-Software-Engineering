using System;
using System.Linq;

public class ArrayElementsEqualТoTheirIndex
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var elements = numbers.Where((x, i) => x == i).ToArray();
        Console.WriteLine(string.Join(" ", elements));
    }
}