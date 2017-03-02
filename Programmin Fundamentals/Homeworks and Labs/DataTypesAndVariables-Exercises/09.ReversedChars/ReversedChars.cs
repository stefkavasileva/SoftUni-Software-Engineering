using System;

public class ReversedChars
{
    public static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char thirdLetter = char.Parse(Console.ReadLine());

        Console.WriteLine(thirdLetter.ToString() + secondLetter + firstLetter);
    }
}