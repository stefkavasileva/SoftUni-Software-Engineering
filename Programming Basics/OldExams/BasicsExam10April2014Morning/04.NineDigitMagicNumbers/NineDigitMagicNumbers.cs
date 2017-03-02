using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NineDigitMagicNumbers
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 111; i <= 777; i++)
        {
            int firstElement = i;
            int secondElement = firstElement + diff;
            int thirdElement = secondElement + diff;

            if (thirdElement > 777)
            {
                break;
            }
            string wholeNumber = firstElement.ToString() + secondElement + thirdElement;
            if (wholeNumber.Contains("8") || wholeNumber.Contains("9") || wholeNumber.Contains("0"))
            {
                continue;
            }
            int sumOfElement = 0;
            for (int k = 0; k < wholeNumber.Length; k++)
            {
                sumOfElement += Convert.ToInt32(Convert.ToString(wholeNumber[k]));
            }
            if (sumOfElement == sum)
            {
                Console.WriteLine(wholeNumber);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

