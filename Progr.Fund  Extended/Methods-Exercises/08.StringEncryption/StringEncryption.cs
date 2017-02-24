using System;
using System.Text;

public class StringEncryption
{
    public static void Main()
    {
        var charCount = int.Parse(Console.ReadLine());
        var result = new StringBuilder();

        for (int i = 0; i < charCount; i++)
        {
            var letter = char.Parse(Console.ReadLine());
            var decryptedLetter = Encrypt(letter);
            result.Append(decryptedLetter);
        }

        Console.WriteLine(result);
    }

    public static string Encrypt(char letter)
    {
        var letterCode = (int)letter;
        var firstNum = int.Parse(letterCode.ToString().Substring(0, 1));
        var lastNum = int.Parse(letterCode.ToString().Substring(letterCode.ToString().Length - 1));
        var firstLetter = (char)(letterCode + lastNum);
        var lastLetter = (char)(letterCode - firstNum);

        var result = firstLetter.ToString() + firstNum + lastNum + lastLetter;

        return result;
    }
}
