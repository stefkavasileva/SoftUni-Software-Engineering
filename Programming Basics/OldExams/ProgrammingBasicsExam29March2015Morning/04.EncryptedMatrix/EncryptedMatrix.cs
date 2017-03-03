using System;
using System.Collections.Generic;

public class EncryptedMatrix
{
    public static void Main()
    {
        string message = Console.ReadLine();
        char direction = char.Parse(Console.ReadLine());
        List<int> digitsFromMessage = new List<int>();

        for (int i = 0; i < message.Length; i++)
        {
            int numLetter = message[i];
            int lastDigit = numLetter % 10;
            digitsFromMessage.Add(lastDigit);
        }

        List<int> convertedNum = new List<int>();

        for (int i = 0; i < digitsFromMessage.Count; i++)
        {
            int digit = digitsFromMessage[i];
            int previousDigit;
            int nextDigit;

            try
            {
                previousDigit = digitsFromMessage[i - 1];
            }
            catch (Exception)
            {
                previousDigit = 0;
            }

            try
            {
                nextDigit = digitsFromMessage[i + 1];
            }
            catch (Exception)
            {

                nextDigit = 0;
            }

            int sum = 0;
            if (digit % 2 == 0 || digit == 0)
            {
                sum = digit * digit;
            }
            else
            {
                sum = digit + nextDigit + previousDigit;
            }
            if (sum > 9)
            {
                int lastDigit = sum % 10;
                int firstDigit = (sum / 10) % 10;
                convertedNum.Add(firstDigit);
                convertedNum.Add(lastDigit);
            }
            else
            {
                convertedNum.Add(sum);
            }
        }

        int count = convertedNum.Count - 1;
        for (int row = 0; row < convertedNum.Count; row++)
        {
            for (int col = 0; col < convertedNum.Count; col++)
            {
                if (direction == '\\') //main diagonal
                {
                    if (row == col)
                    {
                        Console.Write("{0} ", convertedNum[col]);
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                else
                {
                    if (row == 0 && col == 0)
                    {
                        convertedNum.Reverse();
                    }
                    if (col - row == count)
                    {
                        Console.Write("{0} ", convertedNum[row]);
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
            }

            Console.WriteLine();
            count -= 2;
        }
    }
}
