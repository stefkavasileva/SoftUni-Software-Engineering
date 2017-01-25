using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class CubicMessages
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        while (!message.Equals("Over!"))
        {
            int number = int.Parse(Console.ReadLine());
            string pattern = $"(^\\d+)([A-Za-z]{{{number}}})([^A-Za-z]*$)";
            Regex reg = new Regex(pattern);
            Match match = Regex.Match(message, pattern);

            if (!match.Success)
            {
                message = Console.ReadLine();
                continue;
            }

            string validMessage = match.Groups[2].Value;
            string digitsInMessage = match.Groups[1].Value + match.Groups[3].Value;

            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < digitsInMessage.Length; i++)
            {

                int currentIndex = (int)char.GetNumericValue(digitsInMessage[i]);

                if (currentIndex >= 0 && currentIndex <= validMessage.Length - 1)
                {
                    decryptedMessage.Append(validMessage[currentIndex]);
                }
                else
                {
                    decryptedMessage.Append(" ");
                }
            }

            Console.WriteLine($"{validMessage} == {decryptedMessage}");

            message = Console.ReadLine();
        }
    }
}

