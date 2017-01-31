using System;

public class IndexOfLetters
{
    public static void Main()
    {
        string letters = Console.ReadLine();

        foreach (var letter in letters)
        {
            Console.WriteLine($"{letter} -> {letter - 97}");
        }
    }
}
