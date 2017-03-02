using System;
using System.Linq;

public class VowelOrDigit
{
    public static void Main()
    {
        char symbol = char.Parse(Console.ReadLine().ToLower());

        char[] vowelLetter = new char[] { 'a', 'e', 'u', 'i', 'o' };

        if (char.IsDigit(symbol))
        {
            Console.WriteLine("digit");
        }
        else if (char.IsLetter(symbol) && vowelLetter.Contains(symbol))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
