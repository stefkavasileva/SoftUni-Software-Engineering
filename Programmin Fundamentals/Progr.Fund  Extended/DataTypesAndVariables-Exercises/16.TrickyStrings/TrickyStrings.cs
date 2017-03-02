using System;
using System.Text;

public class TrickyStrings
{
    public static void Main()
    {
        var delimeter = Console.ReadLine();
        var result = new StringBuilder();

        var stringCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < stringCount; i++)
        {
            if (i < stringCount - 1)
            {
                result.Append($"{Console.ReadLine()}{delimeter}");
                continue;
            }

            result.Append($"{Console.ReadLine()}");
        }

        Console.WriteLine(result);
    }
}
