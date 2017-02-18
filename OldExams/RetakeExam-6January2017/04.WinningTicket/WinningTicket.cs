using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        var result = new StringBuilder();

        var tickets = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim());

        var pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
        var reg = new Regex(pattern);

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                result.Append($"invalid ticket{Environment.NewLine}");
                continue;
            }

            var leftMatch = reg.Match(ticket.Substring(0, 10));
            var rightMatch = reg.Match(ticket.Substring(10));
            var minLen = Math.Min(leftMatch.Length, rightMatch.Length);

            if (!leftMatch.Success || !rightMatch.Success)
            {
                result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
                continue;
            }

            var leftPart = leftMatch.Value.Substring(0, minLen);
            var rightPart = rightMatch.Value.Substring(0, minLen);

            if (leftPart.Equals(rightPart))
            {
                if (leftPart.Length == 10)
                {
                    result.Append($"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                }
                else
                {
                    result.Append($"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)}{Environment.NewLine}");
                }                             
            }
            else
            {
                result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
            }
        }

        Console.Write(result.ToString());
    }
}