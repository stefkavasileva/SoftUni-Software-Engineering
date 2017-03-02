using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PoolPipes
{
    static void Main(string[] args)
    {
        int v = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double flowP1 = p1 * h;
        double flowP2 = p2 * h;

        if (flowP1 + flowP2 > v)
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, (flowP1 + flowP2) - v);
        }
        else
        {
            int totalV = (int)(((flowP1 + flowP2) / v) * 100.0);
            int pipe1 = (int)((flowP1 / (flowP1 + flowP2)) * 100.0);
            int pipe2 = (int)((flowP2 / (flowP1 + flowP2)) * 100.0);
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                totalV, pipe1, pipe2);
        }
    }
}

