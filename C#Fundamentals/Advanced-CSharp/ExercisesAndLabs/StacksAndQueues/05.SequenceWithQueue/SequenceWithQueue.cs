using System;
using System.Collections.Generic;

public class SequenceWithQueue
{
    public static void Main()
    {
        var n = long.Parse(Console.ReadLine());

        var queue = new Queue<long>();

        queue.Enqueue(n);
        int count = 1;

        while (count <= 50)
        {
            var firstNum = queue.Peek();

            queue.Enqueue(firstNum + 1);
            queue.Enqueue((2 * firstNum) + 1);
            queue.Enqueue(firstNum + 2);

            Console.Write(queue.Dequeue() + " ");
            count++;
        }
    }
}
