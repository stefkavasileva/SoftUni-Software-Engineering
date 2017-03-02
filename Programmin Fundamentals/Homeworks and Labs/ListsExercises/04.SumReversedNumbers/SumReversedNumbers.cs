using System;
using System.Collections.Generic;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        List<string> numbersAsStr = Console.ReadLine().Split().ToList();

        for (int i = 0; i < numbersAsStr.Count; i++)
        {
            char[] digits = numbersAsStr[i].ToCharArray();
            Array.Reverse(digits);
            string currentNum = new string(digits);
            numbersAsStr[i] = currentNum;
        }

        int sum = numbersAsStr.Sum(x => int.Parse(x));

        Console.WriteLine(sum);
    }
}