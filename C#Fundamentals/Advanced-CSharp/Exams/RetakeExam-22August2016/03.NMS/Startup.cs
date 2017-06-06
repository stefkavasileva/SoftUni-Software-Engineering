using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NMS
{
    public class Startup
    {
        public static void Main()
        {
            var text = new StringBuilder();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("---NMS SEND---"))
            {
                text.Append(inputLine);
                inputLine = Console.ReadLine();
            }

            var words = new List<string>();

            var startIndex = 0;
            var length = 1;
            for (int i = 0; i < text.Length - 1; i++)
            {
                var firstLetter = char.ToLower(text[i]);
                var secondLetter = char.ToLower(text[i + 1]);

                if (firstLetter <= secondLetter)
                {
                    length++;
                    if (i == text.Length - 2)
                    {
                        var currentWord = text.ToString().Substring(startIndex, length);
                        words.Add(currentWord);
                    }
                }
                else if (firstLetter > secondLetter)
                {
                    var currentWord = text.ToString().Substring(startIndex, length);
                    words.Add(currentWord);
                    startIndex = i + 1;
                    length = 1;

                    if (i == text.Length - 2)
                    {
                        words.Add(text.ToString().Substring(text.Length - 1));
                    }
                }
            }

            var delimeter = Console.ReadLine();
            Console.WriteLine(string.Join(delimeter, words));
        }
    }
}
