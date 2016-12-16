using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class ConvertFromBase_NToBase_10
{
    static void Main(string[] args)
    {
        string[] inputNums = Console.ReadLine().Split().ToArray();
        int baseNum = int.Parse(inputNums[0]);
        BigInteger numsToConvert = BigInteger.Parse(inputNums[1]);

        BigInteger sum = new BigInteger();
        int counter = 0;
        while (numsToConvert!=0)
        {
            BigInteger lastDigit =numsToConvert % 10;
            BigInteger num =BigInteger.Multiply(lastDigit ,BigInteger.Pow(baseNum, counter));
            sum += num;
            numsToConvert /= 10;
            counter++;
        }   
       
        Console.WriteLine(sum);
    }
}

