using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointInFigure
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if ((y >= -5 && y <= 3) && (x >= 4 && x <= 10))
        {
            Console.WriteLine("in");
        }
        else if ((y >= -3 && y <= 1) && (x >= 2 && x <= 12))
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}

