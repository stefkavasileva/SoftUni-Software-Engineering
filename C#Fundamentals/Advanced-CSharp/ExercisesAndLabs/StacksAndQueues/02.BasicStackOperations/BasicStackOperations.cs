using System;
using System.Collections.Generic;
using System.Linq;

public class BasicStackOperations
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var amountOfElementsToPush = numbers[0];
        var amountOfElementsToPop = numbers[1];
        var elementToCheck = numbers[2];

        var numbersToBePushed = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var stack = new Stack<int>();

        for (int i = 0; i < amountOfElementsToPush; i++)
        {
            stack.Push(numbersToBePushed[i]);
        }

        for (int i = 0; i < amountOfElementsToPop; i++)
        {
            stack.Pop();
        }

        var hasElement = stack.Contains(elementToCheck);

        if (stack.Count.Equals(0))
        {
            Console.WriteLine("0");
        }
        else if (hasElement)
        {
            Console.WriteLine(hasElement.ToString().ToLower());
        }
        else
        {
            var minNum = int.MaxValue;
            while (stack.Count > 0)
            {
                if (stack.Peek() < minNum)
                {
                    minNum = stack.Peek();
                }

                stack.Pop();
            }

            Console.WriteLine(minNum);
        }
    }
}

