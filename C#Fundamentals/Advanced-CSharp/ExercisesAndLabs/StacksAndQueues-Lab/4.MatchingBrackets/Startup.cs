using System;
using System.Collections.Generic;
using System.Text;

namespace _4.MatchingBrackets
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var stack = new Stack<int>();
            var sb = new StringBuilder();

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i].Equals('('))
                {
                    stack.Push(i);
                    continue;
                }

                if (inputLine[i].Equals(')'))
                {
                    var startIndex = stack.Pop();
                    sb.AppendLine(inputLine.Substring(startIndex, i - startIndex + 1));
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
