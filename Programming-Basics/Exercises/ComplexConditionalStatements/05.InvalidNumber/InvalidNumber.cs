using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InvalidNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if ((number < 100 || number > 200) && number != 0)
        {
            Console.WriteLine("invalid");
        }
    }
}

