using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ComparingFloats
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        double diff = Math.Abs(firstNum - secondNum);

        if (diff>eps)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }

    }
}

