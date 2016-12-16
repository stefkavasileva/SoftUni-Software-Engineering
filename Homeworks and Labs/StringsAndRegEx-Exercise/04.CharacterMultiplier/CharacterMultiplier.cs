using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CharacterMultiplier
{
    static void Main(string[] args)
    {
        string[] inputLine = Console.ReadLine().Split().ToArray();
        string firstStr = inputLine[0];
        string secondStr = inputLine[1];

        int maxLength = Math.Max(firstStr.Length, secondStr.Length);
        int totalSum= CalcSumOfCharacters(firstStr, secondStr, maxLength);

        Console.WriteLine(totalSum);
    }

    private static int CalcSumOfCharacters(string firstStr, string secondStr, int maxLength)
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

