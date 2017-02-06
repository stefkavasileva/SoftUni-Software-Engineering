using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        string[] tickets = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

        List<string> results = new List<string>();

        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i].Length != 20)
            {
                results.Add("invalid ticket");
                continue;
            }

            string leftPart = tickets[i].Substring(0, 10);
            string rightPart = tickets[i].Substring(10);

            Regex reg = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");

            Match leftMatch = reg.Match(leftPart);
            Match rightMatch = reg.Match(rightPart);

            string result = string.Empty;

            if (leftMatch.Success && rightMatch.Success)
            {
                int leftLenght = leftMatch.Groups[0].Value.Length;
                int rightLenght = rightMatch.Groups[0].Value.Length;

                int uniqLeftElements = leftMatch.Groups[0].Value.Distinct().Count();
                int uniqRightElements = rightMatch.Groups[0].Value.Distinct().Count();

                char symbolLeft = leftMatch.Groups[0].Value.Distinct().ToArray().First();
                char symbolRight = rightMatch.Groups[0].Value.Distinct().ToArray().First();

                if (uniqLeftElements > 1 || uniqRightElements > 1)
                {
                    result = $"ticket \"{tickets[i]}\" - no match";
                    results.Add(result);
                    continue;
                }

                if (!symbolLeft.Equals(symbolRight))
                {
                    result = $"ticket \"{tickets[i]}\" - no match";
                    results.Add(result);
                    continue;
                }

                if (leftLenght == 10 && rightLenght == 10)
                {
                    result = $"ticket \"{tickets[i]}\" - {leftLenght}{symbolLeft} Jackpot!";
                }
                else if (leftLenght >= 6 && rightLenght >= 6)
                {
                    int lenght = leftLenght > rightLenght ? rightLenght : leftLenght;
                    result = $"ticket \"{tickets[i]}\" - {lenght}{symbolLeft}";
                }
            }
            else
            {
                result = $"ticket \"{tickets[i]}\" - no match";
            }

            results.Add(result);
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}