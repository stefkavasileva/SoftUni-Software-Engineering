using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tic_Tac_ToePower
{
    static void Main(string[] args)
    {
        int y = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int startValue = int.Parse(Console.ReadLine());
        int index = (x * 3) + y + 1;
        int currentNum = startValue + index - 1;

        long result = (long)Math.Pow(currentNum, index);

        Console.WriteLine(result);

    }
}

