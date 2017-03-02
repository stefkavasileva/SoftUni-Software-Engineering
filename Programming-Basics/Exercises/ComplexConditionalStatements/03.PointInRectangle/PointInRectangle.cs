using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointInRectangle
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool overTheTop = (x < x1);
        bool overTheBottom = (x > x2);
        bool beforeLeftSide = (y < y1);
        bool afterRightSide = (y > y2);

        if (overTheBottom || overTheTop || beforeLeftSide || afterRightSide)
        {
            Console.WriteLine("Outside");
        }
        else
        {
            Console.WriteLine("Inside");
        }
    }
}

