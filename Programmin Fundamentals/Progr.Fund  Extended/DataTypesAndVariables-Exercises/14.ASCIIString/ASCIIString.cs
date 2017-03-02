using System;
using System.Text;

public class ASCIIString
{
    public static void Main()
    {
        var numOfChars = int.Parse(Console.ReadLine());

        var result = new StringBuilder();

        for (int i = 0; i < numOfChars; i++)
        {
            result.Append((char)int.Parse(Console.ReadLine()));
        }

        Console.WriteLine(result);
    }
}