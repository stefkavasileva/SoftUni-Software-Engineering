namespace _02.IndexOfLetters
{
    using System;
    using System.IO;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {
            var alphabet = "abcdefjhijklmnopqrstuvwxyz".ToCharArray();
            var letters = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();

            File.WriteAllLines("inputNumbers.txt", letters);
            File.WriteAllText("output.txt", string.Empty);

            foreach (var letter in letters)
            {
                File.AppendAllText("output.txt", $"{letter} -> {Array.IndexOf(alphabet, char.Parse(letter))}{Environment.NewLine}");
            }
        }
    }
}