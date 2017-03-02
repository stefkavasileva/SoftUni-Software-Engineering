using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Operations
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string inputOperator = Console.ReadLine();

        double result = 0;

        if (inputOperator.Equals("+"))
        {
            result = n1 + n2;
        }
        else if (inputOperator.Equals("-"))
        {
            result = n1 - n2;
        }
        else if (inputOperator.Equals("*"))
        {
            result = n1 * n2;
        }
        else if (inputOperator.Equals("/"))
        {
            if (n2 > 0)
            {
                result = (double)n1 / n2;
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
                return;
            }
        }
        else
        {
            if (n2 > 0)
            {
                result = (double)n1 % n2;
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
                return;
            }
        }

        string numType = string.Empty;

        if (result % 2 == 0)
        {
            numType = "even";
        }
        else
        {
            numType = "odd";
        }

        if (inputOperator.Equals("/"))
        {
            Console.WriteLine("{0} {1} {2} = {3:f2}", n1, inputOperator, n2, result);
        }
        else if (inputOperator.Equals("%"))
        {
            Console.WriteLine("{0} {1} {2} = {3}", n1, inputOperator, n2, result);
        }
        else
        {
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, inputOperator, n2, result, numType);
        }
    }
}

