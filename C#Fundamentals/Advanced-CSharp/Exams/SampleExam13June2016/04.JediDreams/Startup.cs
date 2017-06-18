using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.JediDreams
{
    public class Startup
    {
        public static void Main()
        {
            //40/100
            var linesCount = int.Parse(Console.ReadLine());
            var methodsCount = new Dictionary<string, List<string>>();

            var reg = new Regex(@"([A-Z]+[\w]*?)\s*\(");
            var previousMethodName = string.Empty;
            for (int i = 0; i < linesCount; i++)
            {
                var currentLine = Console.ReadLine();
                var matches = reg.Matches(currentLine);
                foreach (Match match in matches)
                {
                    if (match.Success && currentLine.Contains("static"))
                    {
                        var currentMethodName = match.Groups[1].Value;
                        previousMethodName = currentMethodName;
                        if (!methodsCount.ContainsKey(currentMethodName))
                        {
                            methodsCount.Add(currentMethodName, new List<string>());
                        }
                    }
                    else if (match.Success && methodsCount.ContainsKey(previousMethodName))
                    {
                        methodsCount[previousMethodName].Add(match.Groups[1].Value);
                    }
                    
                }

            }

            methodsCount = methodsCount
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var method in methodsCount)
            {
                Console.WriteLine($"{method.Key} -> {method.Value.Count} -> {string.Join(", ", method.Value.OrderBy(x => x))}");
            }

        }
    }
}
