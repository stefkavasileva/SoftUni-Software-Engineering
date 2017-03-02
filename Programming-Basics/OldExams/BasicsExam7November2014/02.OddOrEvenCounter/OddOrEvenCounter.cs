using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOrEvenCounter
{
    static void Main(string[] args)
    {
        int setsCounter = int.Parse(Console.ReadLine());
        int numberCounter = int.Parse(Console.ReadLine());
        string typeOfNum = Console.ReadLine().ToLower();

        int maxCountNum = 0;
        int currentSet = 0;
        for (int i = 0; i < setsCounter; i++)
        {
            int oddCounter = 0;
            int evenCounter = 0;

            for (int n = 0; n < numberCounter; n++)
            {
                int num = int.Parse(Console.ReadLine());
                if (typeOfNum.Equals("odd") && num % 2 == 1)
                {
                    oddCounter++;
                }
                else if (typeOfNum.Equals("even") && num % 2 == 0)
                {
                    evenCounter++;
                }
            }

            if (oddCounter > maxCountNum)
            {
                maxCountNum = oddCounter;
                currentSet = i;
            }
            else if (evenCounter > maxCountNum)
            {
                maxCountNum = evenCounter;
                currentSet = i;
            }
        }

        string[] numerAsText = new string[] { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };

        if (maxCountNum == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine($"{numerAsText[currentSet]} set has the most {typeOfNum} numbers: {maxCountNum}");
        }
    }
}

