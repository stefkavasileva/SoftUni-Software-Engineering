using System;
using System.Linq;

public class ReverseAndExclude
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var number = int.Parse(Console.ReadLine());

        var result = numbers.Where(num => Filter(num, x => x % number != 0));

        Console.WriteLine(string.Join(" ",result.Reverse()));
    }

    public static bool Filter(int num, Func<int, bool> filter)
    {
        return filter(num);
    }
}

