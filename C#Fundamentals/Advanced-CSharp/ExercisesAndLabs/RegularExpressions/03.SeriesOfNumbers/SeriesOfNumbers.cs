using System;
using System.Text;

public class SeriesOfNumbers
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var result = new StringBuilder();

        for (int i = 0; i < inputLine.Length-1; i++)
        {
            if(inputLine[i] != inputLine[i + 1])
            {
                result.Append(inputLine[i]);
            }
        }

        result.Append(inputLine[inputLine.Length - 1]);
        Console.WriteLine(result);
    }
}

