using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberFrom100To200
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());

        if (inputNum < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (inputNum >= 100 && inputNum <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}

