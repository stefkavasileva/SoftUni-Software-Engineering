using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int num1 = 1;
        int num2 = 1;

        for (int i = 2; i <=n ; i++)
        {
            int sum = num1 + num2;
            num1 = num2;
            num2 = sum;
        }

        Console.WriteLine(num2);
    }
}

