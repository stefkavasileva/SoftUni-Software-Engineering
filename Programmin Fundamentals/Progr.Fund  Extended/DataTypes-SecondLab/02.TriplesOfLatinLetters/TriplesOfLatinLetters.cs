using System;

public class TriplesOfLatinLetters
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int firstLetter = 0; firstLetter < number; firstLetter++)
        {
            for (int secondLetter = 0; secondLetter < number; secondLetter++)
            {
                for (int thirdLetter = 0; thirdLetter < number; thirdLetter++)
                {
                    Console.WriteLine($"{(char)('a' + firstLetter)}{(char)('a' + secondLetter)}{(char)('a' + thirdLetter)}");
                }
            }
        }
    }
}