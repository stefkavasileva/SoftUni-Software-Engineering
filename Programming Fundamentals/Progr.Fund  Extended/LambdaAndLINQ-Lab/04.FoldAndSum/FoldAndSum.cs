using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var k = numbers.Length / 4;

        //var leftK = numbers.Take(k).Reverse();
        //var middleK = numbers.Skip(k).Take(2 * k);
        //var rightK = numbers.Skip(3 * k).Reverse();

        var result = numbers.Skip(k).Take(2 * k).Zip(numbers.Take(k).Reverse().Concat(numbers.Skip(3 * k).Reverse()), (x, y) => x + y);

        Console.WriteLine(string.Join(" ", result));
    }
}

