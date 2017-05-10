using System;
using System.Linq;

public class CharacterMultiplier
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().Split().ToArray();
        var firstStr = inputLine[0];
        var secondStr = inputLine[1];

        var maxLength = Math.Max(firstStr.Length, secondStr.Length);
        var totalSum = CalcSumOfCharacters(firstStr, secondStr, maxLength);

        Console.WriteLine(totalSum);
    }

    public static int CalcSumOfCharacters(string firstStr, string secondStr, int maxLength)
    {
        int totalSum = 0;

        for (int i = 0; i < maxLength; i++)
        {
            if (firstStr.Length < i + 1)
            {
                totalSum += secondStr[i];
            }
            else if (secondStr.Length < i + 1)
            {
                totalSum += firstStr[i];
            }
            else
            {
                totalSum += firstStr[i] * secondStr[i];
            }
        }

        return totalSum;
    }
}

