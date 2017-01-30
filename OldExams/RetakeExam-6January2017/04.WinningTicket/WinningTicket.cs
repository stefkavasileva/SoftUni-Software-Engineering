using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class WinningTicket
{
    static void Main(string[] args)
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
            string rightPart = tickets[i].Substring(11);

            Regex reg = new Regex(@"[@|$|#|^]{6,10}");

            Match leftMatch = reg.Match(leftPart);
            Match rightMatch = reg.Match(rightPart);

            string result = string.Empty;

            if (leftMatch.Success && rightMatch.Success)
            {
                int leftLenght = leftMatch.Groups[0].Value.Length;
                int rightLenght = rightMatch.Groups[0].Value.Length;

                if (leftLenght != rightLenght)
                {
                    results.Add("invalid ticket");
                    continue;
                }

                string symbol = leftMatch.Groups[0].Value.Substring(0, 1);

                if (leftLenght == 10)
                {
                    result = $"ticket \"{tickets[i]}\" - {leftLenght}{symbol} Jackpot!";

                }
                else if (leftLenght >= 6)
                {
                    result = $"ticket \"{tickets[i]}\" - {leftLenght}{symbol}";
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

