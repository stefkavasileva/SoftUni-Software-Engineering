using System;
using System.Collections.Generic;

public class BalancedParenthesis
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var stack = new Stack<char>();
        var isBalanced = true;

        foreach (var symbol in inputLine)
        {
            if (symbol.Equals('(') || symbol.Equals('{') || symbol.Equals('['))
            {
                stack.Push(symbol);
            }
            else
            {
                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                var lastSymbol = stack.Pop();
                if (lastSymbol.Equals('(') && !symbol.Equals(')'))
                {
                    isBalanced = false;
                    break;
                }
                else if (lastSymbol.Equals('{') && !symbol.Equals('}'))
                {
                    isBalanced = false;
                    break;
                }
                else if (lastSymbol.Equals('[') && !symbol.Equals(']'))
                {
                    isBalanced = false;
                    break;
                }
            }
        }


        if (isBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

