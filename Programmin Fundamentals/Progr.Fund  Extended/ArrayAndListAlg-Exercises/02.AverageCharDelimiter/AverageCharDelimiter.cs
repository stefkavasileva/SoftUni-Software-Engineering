using System;
using System.Linq;

public class AverageCharDelimiter
{
    public static void Main()
    {
        var inputArgs = Console.ReadLine().Split().ToArray();

        var sum = 0;
        var count = 0.0;
        for (int i = 0; i < inputArgs.Length; i++)
        {
            var currentStr = inputArgs[i];
            for (int j = 0; j < currentStr.Length; j++)
            {
                sum += currentStr[j];
                count++;
            }
        }

        var average = sum / count;
        var letter = (char)((int)average);
        letter = char.ToUpper(letter);

        Console.WriteLine(string.Join(letter.ToString(), inputArgs));

        //var inputLine = Console.ReadLine();
        //var letters = inputLine.Where(x => x != ' ').ToArray();

        //var sum = letters.Select(x => (int)x).Sum();
        //var average = sum / letters.Count();
        //var letter = char.ToUpper((char)(average));

        //Console.WriteLine(string.Join(letter.ToString(), inputLine.Split()));
    }
}

