using System;
using System.Collections.Generic;
using System.Text;

namespace _1.ReverseStrings
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var stack = new Stack<char>(inputLine);

            var sb = new StringBuilder();

            while (stack.Count != 0)
            {
                sb.Append(stack.Pop());
            }

            Console.WriteLine(sb);
        }
    }
}
