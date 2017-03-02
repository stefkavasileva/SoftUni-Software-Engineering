using System;
using System.Collections.Generic;
using System.Linq;

public class IntegerInsertion
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        var currentNumber = Console.ReadLine();
        while (!currentNumber.Equals("end"))
        {
            var index = int.Parse(currentNumber.Substring(0, 1));
            numbers.Insert(index, int.Parse(currentNumber));
            currentNumber = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ",numbers));
    }
}

