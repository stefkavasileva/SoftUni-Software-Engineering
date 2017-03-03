using System;

public class DetectiveBoev
{
    public static void Main()
    {
        string secredWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        int sumOfLetters = 0;
        for (int i = 0; i < secredWord.Length; i++)
        {
            sumOfLetters += secredWord[i];
        }

        int mask = 0;
        while (sumOfLetters > 9)
        {
            while (sumOfLetters != 0)
            {
                mask += sumOfLetters % 10;
                sumOfLetters /= 10;
            }
            sumOfLetters = mask;
            if (mask > 9)
            {
                mask = 0;
            }
        }

        //Console.WriteLine(masck);
        string newMessage = string.Empty;
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if (encryptedMessage[i] % mask == 0)
            {
                char newLetter = (char)(encryptedMessage[i] + mask);
                newMessage = newLetter + newMessage;
            }
            else
            {
                char newLetter = (char)(encryptedMessage[i] - mask);
                newMessage = newLetter + newMessage;
            }
        }

        Console.WriteLine(newMessage);
    }
}
