using System;
using System.Linq;

public class CustomMinFunction
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Func<int[], int> myFunc = GetMinNUmber;
        var minNumber = myFunc(numbers);

        Console.WriteLine(minNumber);
    }

    public static int GetMinNUmber(int[] numbers)
    {
        return numbers.Min();
    }
}
