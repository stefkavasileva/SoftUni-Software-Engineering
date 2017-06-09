using System;
using System.Text.RegularExpressions;

namespace _02.VowelCount
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var reg = new Regex(@"[aeiouay]");
            var vowelCount = reg.Matches(text).Count;

            Console.WriteLine($"Vowels: {vowelCount}");
        }
    }
}
