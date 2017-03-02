using System;

public class NumbersFrom0To100ToText
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string[] numToNineText = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] numToNineteenText = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };

        if (inputNumber == 100)
        {
            Console.WriteLine("one hundred");
        }
        else if (inputNumber < 0 || inputNumber > 100)
        {
            Console.WriteLine("invalid number");
        }
        else if (inputNumber < 10)
        {
            for (int i = 0; i < numToNineText.Length; i++)
            {
                if (inputNumber == i)
                {
                    Console.WriteLine(numToNineText[i].ToString());
                }
            }
        }
        else if (inputNumber > 10 && inputNumber < 20)
        {
            inputNumber -= 10;
            for (int i = 0; i < numToNineteenText.Length; i++)
            {
                if (inputNumber == i)
                {
                    Console.WriteLine(numToNineteenText[i].ToString());
                }
            }
        }
        else if (inputNumber > 9 && (inputNumber % 10) == 0)
        {
            for (int i = 1; i <= tens.Length; i++)
            {

                if ((inputNumber / 10) % 10 == i)
                {
                    Console.WriteLine(tens[i].ToString());
                }
            }
        }
        else if (inputNumber > 9)
        {
            for (int i = 1; i <= tens.Length; i++)
            {

                if ((inputNumber / 10) % 10 == i)
                {
                    Console.Write(tens[i].ToString());
                    break;
                }
            }
            for (int i = 1; i <= numToNineText.Length; i++)
            {

                if (inputNumber % 10 == i)
                {
                    Console.Write(" {0}", numToNineText[i].ToString());
                }
            }
        }
    }
}