using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleTextEditor
{
    public static void Main()
    {
        var operationsCount = int.Parse(Console.ReadLine());

        var stack = new Stack<string>();

        for (int i = 0; i < operationsCount; i++)
        {
            var currentOperationArgs = Console.ReadLine().Split().ToArray();
            var operation = currentOperationArgs[0];

            if (operation.Equals("1"))
            {
                if (stack.Count == 0)
                {
                    stack.Push(currentOperationArgs[1]);
                    continue;
                }

                var newString = stack.Peek();
                newString += currentOperationArgs[1];
                stack.Push(newString);
            }
            else if (operation.Equals("2"))
            {
                var newString = stack.Peek();
                newString = newString.Substring(0, newString.Count() - int.Parse(currentOperationArgs[1]));
                stack.Push(newString);
            }
            else if (operation.Equals("3"))
            {
                var currentString = stack.Peek();
                Console.WriteLine(currentString[int.Parse(currentOperationArgs[1]) - 1].ToString());
            }
            else
            {
                stack.Pop();
            }
        }
    }
}
