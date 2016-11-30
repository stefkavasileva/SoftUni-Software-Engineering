using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

class PrintPartOfASCIITable
{
    static void Main(string[] args)
    {
        int startIndex = int.Parse(Console.ReadLine());
        int endIndex = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();

        for (int letter = startIndex; letter <=endIndex ; letter++)
        {
            result.Append((char)letter+" ");
        }

        Console.WriteLine(result);
    }
}

