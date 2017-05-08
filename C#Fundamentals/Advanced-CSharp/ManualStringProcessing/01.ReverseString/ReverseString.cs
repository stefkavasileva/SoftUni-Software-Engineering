using System;
using System.Text;

public class ReverseString
{
    public static void Main()
    {
        var input = Console.ReadLine();
        //var output = new string(input.Reverse().ToArray()); - 90/100 - memory

        var result = new StringBuilder();
        for (int i = input.Length-1; i >=0 ; i--)
        {
            result.Append(input[i]);
        }

        Console.WriteLine(result);
    }
}

