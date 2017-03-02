using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InchesToCentimeters
{
    static void Main(string[] args)
    {
        Console.Write("Inches = ");

        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;

        Console.Write("Centimeters = ");

        Console.WriteLine(centimeters);
    }
}

