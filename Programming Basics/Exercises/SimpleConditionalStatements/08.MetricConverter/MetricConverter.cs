using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MetricConverter
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        string input = Console.ReadLine().ToLower();
        string output = Console.ReadLine().ToLower();
        double metres = 1d;

        if (input == "mm")
        {
            metres = length / 1000;
        }
        else if (input == "cm")
        {
            metres = length / 100;
        }
        else if (input == "mi")
        {
            metres = length / 0.000621371192;
        }
        else if (input == "in")
        {
            metres = length / 39.3700787;
        }
        else if (input == "km")
        {
            metres = length / 0.001;
        }
        else if (input == "ft")
        {
            metres = length / 3.2808399;
        }
        else if (input == "yd")
        {
            metres = length / 1.0936133;
        }
        else if (input == "m")
        {
            metres = length;
        }

        double result = 0d;

        if (output == "mm")
        {
            result = metres * 1000;
        }
        else if (output == "cm")
        {
            result = metres * 100;
        }
        else if (output == "mi")
        {
            result = metres * 0.000621371192;
        }
        else if (output == "in")
        {
            result = metres * 39.3700787;
        }
        else if (output == "km")
        {
            result = metres * 0.001;
        }
        else if (output == "ft")
        {
            result = metres * 3.2808399;
        }
        else if (output == "yd")
        {
            result = metres * 1.0936133;
        }
        else if (output == "m")
        {
            result = metres;
        }

        Console.WriteLine("{0} {1}", result, output);
    }
}

