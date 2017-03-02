using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreaterNumber
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum >= secondNum)
        {
            Console.WriteLine(firstNum);
        }
        else
        {
            Console.WriteLine(secondNum);
        }
    }
}

