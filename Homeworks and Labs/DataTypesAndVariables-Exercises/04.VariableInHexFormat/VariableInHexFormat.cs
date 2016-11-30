using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VariableInHexFormat
{
    static void Main(string[] args)
    {
        string hexadecimalNum = Console.ReadLine();

        int decimalNum = Convert.ToInt32(hexadecimalNum, 16);

        Console.WriteLine(decimalNum);
    }
}

