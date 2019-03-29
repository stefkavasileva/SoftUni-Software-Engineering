using System;
using System.Collections.Generic;
using System.Linq;

public class EqualSequenceOfElementsIArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray().Distinct();

        if (numbers.Count() != 1)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }
}
