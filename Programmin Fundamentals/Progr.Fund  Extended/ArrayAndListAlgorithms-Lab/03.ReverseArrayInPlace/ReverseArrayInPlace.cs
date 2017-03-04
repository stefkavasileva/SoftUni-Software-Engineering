using System;
using System.Linq;

public class ReverseArrayInPlace
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            var tempNum = numbers[i];
            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = tempNum;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
