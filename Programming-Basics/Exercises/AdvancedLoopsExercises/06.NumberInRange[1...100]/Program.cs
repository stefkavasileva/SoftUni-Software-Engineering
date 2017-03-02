using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        int num = 0;

        while (true)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine("The number is: {0}", num);
                return;
            }
        }

    }
}

