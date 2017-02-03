using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = nums.Length / 4;

        int[] firstKElements = nums.Take(k).Reverse().ToArray();
        int[] lastKElements = nums.Skip(3 * k).Take(k).Reverse().ToArray();

        int[] middleKELements = nums.Skip(k).Take(2 * k).ToArray();
        int[] arrsConcated = firstKElements.Concat(lastKElements).ToArray();

        var result = middleKELements.Zip(arrsConcated, (x, y) => x + y);

        Console.WriteLine(string.Join(" ",result));
    }

   
}

