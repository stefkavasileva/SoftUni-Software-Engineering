using System;

public class TrickyStrings
{
    public static void Main()
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());

        var result = string.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            if (i < numberOfStrings - 1)
            {
                result += Console.ReadLine() + delimiter;
                continue;
            }

            result += Console.ReadLine();
        }

        Console.WriteLine(result);
    }
}
