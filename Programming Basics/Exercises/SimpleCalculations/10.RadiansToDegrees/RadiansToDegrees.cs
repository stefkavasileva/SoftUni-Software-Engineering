using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RadiansToDegrees
{
    static void Main(string[] args)
    {
        double radians = double.Parse(Console.ReadLine());
        double degrees = Math.Round((radians * 180) / Math.PI, 2);

        Console.WriteLine(degrees);
    }
}

