using System;
using System.Text;

public class MelrahShake
{
    public static void Main()
    {
        var randomCharacters = Console.ReadLine();
        var pattern = Console.ReadLine();

        var messages = new StringBuilder();

        if (pattern.Length == 0)
        {
            Console.WriteLine("No shake.");
            Console.WriteLine(randomCharacters);
            return;
        }

        while (true)
        {
            var firstOccureence = randomCharacters.IndexOf(pattern);
            var lastOccureence = randomCharacters.LastIndexOf(pattern);

            if (firstOccureence > -1 && lastOccureence > -1 && pattern.Length > 0)
            {
                randomCharacters = randomCharacters.Remove(lastOccureence, pattern.Length);
                randomCharacters = randomCharacters.Remove(firstOccureence, pattern.Length);
                messages.AppendLine("Shaked it.");

                pattern = pattern.Remove(pattern.Length / 2, 1);

            }
            else
            {
                messages.AppendLine("No shake.");
                break;
            }

        }

        Console.Write(messages.ToString());
        Console.WriteLine(randomCharacters);

    }
}

