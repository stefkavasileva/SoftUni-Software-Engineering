using System;
using System.Linq;

public class ReverseString
{
    public static void Main()
    {
        var inputString = Console.ReadLine();
        var reversedString = string.Join(string.Empty, inputString.ToCharArray().Reverse());
        Console.WriteLine(reversedString);
    }
}