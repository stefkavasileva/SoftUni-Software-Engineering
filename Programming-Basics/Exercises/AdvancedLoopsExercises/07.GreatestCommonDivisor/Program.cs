using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int remainder = 0;

        while (num2!=0)
        {
            remainder = num1 % num2;
            num1 = num2;
            num2 = remainder;
            
        }

        Console.WriteLine(num1);
    }
}

