using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        while (num>0)
        {
            sum += num % 10;
            num /= 10;        
        }

        Console.WriteLine(sum);
    }
}

