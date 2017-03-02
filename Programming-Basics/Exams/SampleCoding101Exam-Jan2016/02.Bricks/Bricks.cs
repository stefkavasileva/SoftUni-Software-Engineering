using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bricks
{
    static void Main(string[] args)
    {
        double x = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        double result = x / (workers * m);

        Console.WriteLine(Math.Ceiling(result));
    }
}

