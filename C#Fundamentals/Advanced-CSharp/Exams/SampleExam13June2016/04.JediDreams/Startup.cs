using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.JediDreams
{
    public class Startup
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var methodsCount = new Dictionary<string, List<string>>();

            var previousMethodName = string.Empty;
            for (int i = 0; i < linesCount; i++)
            {
                var currentLine = Console.ReadLine();
                var methodName = GetMethodName(currentLine, -1);

                if (methodName.Equals(string.Empty))
                {
                    continue;
                }

                if (currentLine.Contains("static"))
                {
                    if (!methodsCount.ContainsKey(methodName))
                    {
                        methodsCount.Add(methodName, new List<string>());
                    }

                    previousMethodName = methodName;
                }
                else
                {
                    methodsCount[previousMethodName].Add(methodName);
                    var firstIndex = currentLine.IndexOf(methodName);

                    while (methodName != string.Empty)
                    {
                        var nextIndex = firstIndex + methodName.Length + 2;
                        if(nextIndex>=currentLine.Length) break;
                        var index = currentLine.IndexOf("(", firstIndex + methodName.Length + 2);

                        if (index == -1) break;

                        methodName = GetMethodName(currentLine, index);
                        methodsCount[previousMethodName].Add(methodName);
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

        private static string GetMethodName(string currentLine, int startIndex)
        {
            var indexOfStartLetter = startIndex;
            var indexOfBracket = startIndex;

            for (int j = 0; j < currentLine.Length; j++)
            {
                if (char.IsUpper(currentLine[j]) && indexOfStartLetter > startIndex)
                {
                    indexOfStartLetter = j;
                }

                if (currentLine[j] == '(' && indexOfStartLetter != -1 && j > indexOfBracket)
                {
                    indexOfBracket = j;
                    break;
                }
            }

            if (indexOfBracket == -1 || indexOfStartLetter == -1)
            {
                return string.Empty;
            }

            return currentLine
                .Substring(indexOfStartLetter, indexOfBracket - indexOfStartLetter)
                .Trim();
        }
    }
}
