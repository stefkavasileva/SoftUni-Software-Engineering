using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareArea
{
    static void Main(string[] args)
    {
        Console.Write("a= ");

        double side = double.Parse(Console.ReadLine());
        double area = side * side;

        Console.Write("Sqare = ");
        Console.WriteLine(area);
    }
}

