using System;
using System.Collections.Generic;
using System.Text;

namespace _3.DecimalToBinaryConverter
{
    public class Startup
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (inputNumber.Equals(0))
            {
                Console.WriteLine(0);
                return;
            }

            while (inputNumber > 0)
            {
                stack.Push(inputNumber % 2);
                inputNumber /= 2;
            }

            var sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            Console.WriteLine(sb);
        }
    }
}
