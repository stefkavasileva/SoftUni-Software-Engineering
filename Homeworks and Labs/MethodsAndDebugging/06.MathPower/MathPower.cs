using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MathPower
{
    static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double result = ReiseToPower(num, power);

        Console.WriteLine(result);
    }

    private static double ReiseToPower(double num, int power)
    {
        double result = num;
        for (int i = 0; i < power-1; i++)
        {
            result*=num ;
        }

        return result;
    }
}

