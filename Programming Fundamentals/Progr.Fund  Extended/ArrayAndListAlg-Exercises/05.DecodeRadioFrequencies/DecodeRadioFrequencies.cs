using System;
using System.Collections.Generic;

public class DecodeRadioFrequencies
{
    public static void Main()
    {
        var realNumbers = Console.ReadLine().Split();

        var result = new List<char>();

        for (int i = 0; i < realNumbers.Length; i++)
        {
            var index = realNumbers[i].IndexOf('.');
            var firstNum = int.Parse(realNumbers[i].Substring(0, index));
            var secondNum = int.Parse(realNumbers[i].Substring(index + 1));

            if (firstNum != 0)
            {
                var firstLetter = (char)firstNum;
                result.Insert(i, firstLetter);
            }

            if (secondNum != 0)
            {
                var secondLetter = (char)secondNum;
                result.Insert(result.Count - 1 - i, secondLetter);
            }
        }

        result.Reverse();
        Console.WriteLine(string.Join(string.Empty, result));
    }
}