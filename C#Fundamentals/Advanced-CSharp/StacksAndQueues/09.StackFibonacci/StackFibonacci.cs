using System;
using System.Collections.Generic;

public class StackFibonacci
{
    public static void Main()
    {
        var n = long.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine(n);
            return;
        }

        var fib = new Queue<long>();
        fib.Enqueue(1);
        fib.Enqueue(1);
        for (int i = 0; i < n-2; i++)
        {
            var num = fib.Dequeue() + fib.Peek();
            fib.Enqueue(num);
        }

        fib.Dequeue();
        Console.WriteLine(fib.Dequeue());
    }
}

