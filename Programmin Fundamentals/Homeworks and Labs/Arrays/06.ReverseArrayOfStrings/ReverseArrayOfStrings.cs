using System;
using System.Linq;

public class ReverseArrayOfStrings
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string[] letters = text.Split(' ').ToArray();

        Array.Reverse(letters);

        Console.WriteLine(string.Join(" ", letters));
    }
}
