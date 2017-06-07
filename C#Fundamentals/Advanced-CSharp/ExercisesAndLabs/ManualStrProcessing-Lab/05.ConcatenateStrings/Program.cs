using System;
using System.Text;

namespace _05.ConcatenateStrings
{
    public class Program
    {
        public static void Main()
        {
            var wordsCount = int.Parse(Console.ReadLine());
            var result = new StringBuilder();

            for (int index = 0; index < wordsCount; index++)
            {
                result.Append($"{Console.ReadLine()} ");
            }

            Console.WriteLine(result);
        }
    }
}
