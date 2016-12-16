using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class ConvertFromBase_10ToBase_N
{
    static void Main(string[] args)
    {
        string[] inputNums = Console.ReadLine().Split().ToArray();
        BigInteger baseNum = BigInteger.Parse(inputNums[0]);
        BigInteger numsToConvert = BigInteger.Parse(inputNums[1]);

        string result = "";

        while (numsToConvert>0)
        {
            BigInteger remainder =numsToConvert % baseNum;
            result = remainder.ToString()+result;
            numsToConvert /= baseNum;
        }

        Console.WriteLine(result);
    }
}

