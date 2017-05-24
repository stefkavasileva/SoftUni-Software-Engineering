using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SimpleCalculator
{
    public class Startup
    {
        public static void Main()
        {
            var inputElements = Console.ReadLine().Split();
            var stack = new Stack<string>(inputElements.Reverse());

            while (stack.Count() > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var currentOperator = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                if (currentOperator.Equals("+"))
                {
                    stack.Push((firstNum + secondNum).ToString());
                    continue;
                }

                stack.Push((firstNum - secondNum).ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
