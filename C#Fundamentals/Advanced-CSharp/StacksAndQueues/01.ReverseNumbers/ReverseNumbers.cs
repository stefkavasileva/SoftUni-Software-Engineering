using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        var stack = new Stack<int>();

        foreach (var number in numbers)
        {
            stack.Push(number);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}

