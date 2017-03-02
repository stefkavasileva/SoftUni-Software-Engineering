using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class HornetComm
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var reg = new Regex(@"^([\d\D]+)\s+<->\s([A-Za-z\d]+)$");

        var messages = new StringBuilder();
        var broadcasts = new StringBuilder();

        while (!inputLine.Equals("Hornet is Green"))
        {
            var match = reg.Match(inputLine);
            if (match.Success)
            {
                var fisrtQuery = match.Groups[1].Value;
                var secondQuery = match.Groups[2].Value;

                if (fisrtQuery.All(x => char.IsDigit(x)))
                {
                    var code = string.Join(string.Empty, fisrtQuery.ToCharArray().Reverse());
                    messages.AppendLine($"{code} -> {secondQuery}");
                }
                else
                {
                    var frequency = secondQuery.ToArray();
                    for (int i = 0; i < secondQuery.Length; i++)
                    {
                        if (char.IsUpper(secondQuery[i]))
                        {
                            frequency[i] = char.ToLower(secondQuery[i]);
                        }
                        else if (char.IsLower(secondQuery[i]))
                        {
                            frequency[i] = char.ToUpper(secondQuery[i]);
                        }
                    }

                    broadcasts.AppendLine($"{string.Join(string.Empty, frequency)} -> {fisrtQuery}");
                }
            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine("Broadcasts:");
        if (broadcasts.Length == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            Console.Write($"{broadcasts}");
        }

        Console.WriteLine("Messages:");
        if (messages.Length==0)
        {
            Console.WriteLine("None");
            return;
        }
          
        Console.Write(messages);
    }
}

