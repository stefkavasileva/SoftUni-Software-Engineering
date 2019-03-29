using System;
using System.Linq;

public class CompareCharArrays
{
    public static void Main()
    {
        char[] fitestLetters = Console.ReadLine().Split().Select(char.Parse).ToArray();
        char[] secondLetters = Console.ReadLine().Split().Select(char.Parse).ToArray();

        int minLength = Math.Min(fitestLetters.Length, secondLetters.Length);

        bool isEqual = true;
        int biggestArr = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (!fitestLetters[i].Equals(secondLetters[i]))
            {
                isEqual = false;
                if (fitestLetters[i] > secondLetters[i])
                {
                    biggestArr = 2;
                }
                else
                {
                    biggestArr = 1;
                }
            }
        }

        if ((!isEqual && biggestArr == 1) || (isEqual && fitestLetters.Length <= secondLetters.Length))
        {
            Console.WriteLine(string.Join(string.Empty, fitestLetters));
            Console.WriteLine(string.Join(string.Empty, secondLetters));
        }
        else if (!isEqual && biggestArr == 2 || (isEqual && fitestLetters.Length > secondLetters.Length))
        {
            Console.WriteLine(string.Join(string.Empty, secondLetters));
            Console.WriteLine(string.Join(string.Empty, fitestLetters));
        }
    }
}
