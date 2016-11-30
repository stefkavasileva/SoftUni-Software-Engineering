using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntegerToHexAndBinary
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(inputNum, 2);
        string hexadecimalNum = Convert.ToString(inputNum, 16).ToUpper();

        Console.WriteLine(hexadecimalNum);
        Console.WriteLine(binaryNum);
    }
}

