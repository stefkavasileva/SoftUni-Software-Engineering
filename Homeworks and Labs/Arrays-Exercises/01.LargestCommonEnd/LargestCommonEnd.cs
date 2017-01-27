using System;
using System.Linq;

class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] firstWords = Console.ReadLine().Split().ToArray();
        string[] secondWords = Console.ReadLine().Split().ToArray();

        int minLength = Math.Min(firstWords.Length, secondWords.Length); 

        int firstLength = GetMaxLength(firstWords, secondWords, minLength);

        Array.Reverse(firstWords);
        Array.Reverse(secondWords);

        int secondLength = GetMaxLength(firstWords, secondWords, minLength);

        Console.WriteLine(firstLength > secondLength ? firstLength : secondLength);
    }

    private static int GetMaxLength(string[] firstWords, string[] secondWords, int minLength)
    {
        int firstLength = 0;
        for (int i = 0; i < minLength; i++)
        {
            if (firstWords[i].Equals(secondWords[i]))
            {
                firstLength++;
            }
            else
            {
                break;
            }
        }

        return firstLength;
    }
}

