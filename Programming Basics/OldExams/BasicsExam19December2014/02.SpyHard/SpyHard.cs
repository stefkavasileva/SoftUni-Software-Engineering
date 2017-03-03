using System;

public class SpyHard
{
    public static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        int sumOfLetters = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] >= 97 && message[i] <= 122)
            {
                int symbolValue = message[i] - 96;
                sumOfLetters += symbolValue;
            }
            else if (message[i] >= 65 && message[i] <= 90)
            {
                int symbolValue = message[i] - 64;
                sumOfLetters += symbolValue;
            }
            else
            {
                sumOfLetters += message[i];
            }
        }


        string convertedNumber = ConvertToNumeralSystem(sumOfLetters, key);
        string result = key.ToString() + message.Length.ToString() + convertedNumber;
        Console.WriteLine(result);
    }

    public static string ConvertToNumeralSystem(int num, int key)
    {
        string numsInNumeralSystem = string.Empty;
        int divisor = 0;
        switch (key)
        {
            case 2:
                divisor = 2;
                break;
            case 3:
                divisor = 3;
                break;
            case 4:
                divisor = 4;
                break;
            case 5:
                divisor = 5;
                break;
            case 6:
                divisor = 6;
                break;
            case 7:
                divisor = 7;
                break;
            case 8:
                divisor = 8;
                break;
            case 9:
                divisor = 9;
                break;
            default:
                divisor = 10;
                break;
        }

        while (num > 0)
        {
            int binaryNum = num % divisor;
            num = num / divisor;
            numsInNumeralSystem = binaryNum.ToString() + numsInNumeralSystem;
        }

        return numsInNumeralSystem;
    }
}