using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BooleanVariable
{
    static void Main(string[] args)
    {
        string trueOrFalse = Console.ReadLine();

        bool isTrue = Convert.ToBoolean(trueOrFalse);

        if (isTrue)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

