using System;
using System.Linq;

public class ArrayContainsElement
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var number = int.Parse(Console.ReadLine());

        var isContains = false;

        for (int i = 0; i < numbers.Count(); i++)
        {
            if (numbers[i] == number)
            {
                isContains = true;
                break;
            }
        }

        var result = isContains ? "yes" : "no";
        Console.WriteLine(result);
    }
}
