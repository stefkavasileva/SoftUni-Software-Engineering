using System;
using System.Collections.Generic;
using System.Linq;

public class MaximumElement
{
    public static void Main()
    {
        var queriesCount = int.Parse(Console.ReadLine());

        var numbers = new Stack<int>();
        var maxNumber = int.MinValue;

        for (int i = 0; i < queriesCount; i++)
        {
            var queryArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var query = queryArgs[0];
            if (query.Equals(1))
            {
                numbers.Push(queryArgs[1]);

                if (maxNumber < numbers.Peek())
                {
                    maxNumber = numbers.Peek();
                }
            }
            else if (query.Equals(2))
            {
                numbers.Pop();
                if (numbers.Count > 0)
                {
                    maxNumber = numbers.Max();
                }
                else
                {
                    maxNumber = int.MinValue;
                }

            }
            else
            {
                if (maxNumber.Equals(int.MinValue))
                {
                    Console.WriteLine(numbers.Peek());
                }
                else
                {
                    Console.WriteLine(maxNumber);
                }
            }
        }
    }
}