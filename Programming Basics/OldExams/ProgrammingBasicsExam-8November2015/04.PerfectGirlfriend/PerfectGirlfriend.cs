using System;
using System.Collections.Generic;

public class PerfectGirlfriend
{
    public static void Main()
    {
        List<string> girls = new List<string>();
        int perfectGirls = 0;

        for (;;)
        {
            string input = Console.ReadLine();
            if (input == "Enough dates!")
            {
                break;
            }

            string[] girlsInfo = input.Split('\\');
            int day = 0;

            switch (girlsInfo[0])
            {
                case "Monday":
                    day = 1;
                    break;
                case "Tuesday":
                    day = 2;
                    break;
                case "Wednesday":
                    day = 3;
                    break;
                case "Thursday":
                    day = 4;
                    break;
                case "Friday":
                    day = 5;
                    break;
                case "Saturday":
                    day = 6;
                    break;
                default:
                    day = 7;
                    break;
            }

            string phoneNumber = girlsInfo[1];
            int sumOfTelephoneNumber = 0;

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                int num = (int)char.GetNumericValue(phoneNumber[i]);
                sumOfTelephoneNumber += num;
            }

            string braSize = girlsInfo[2];
            int size = int.Parse(braSize.Substring(0, braSize.Length - 1));
            char letter = braSize[braSize.Length - 1];
            int bra = size * letter;
            string name = girlsInfo[3];
            int sumOfName = name[0] * name.Length;
            int totalSum = day + sumOfTelephoneNumber + bra - sumOfName;

            if (totalSum >= 6000)
            {
                string result = name + " is perfect for you.";
                perfectGirls++;
                girls.Add(result);
            }
            else
            {
                string result = "Keep searching, " + name + " is not for you.";
                girls.Add(result);
            }
        }

        foreach (string girl in girls)
        {
            Console.WriteLine(girl);
        }

        Console.WriteLine(perfectGirls);
    }
}
