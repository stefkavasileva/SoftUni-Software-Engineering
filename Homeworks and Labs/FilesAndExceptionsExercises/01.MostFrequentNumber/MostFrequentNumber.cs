namespace _01.MostFrequentNumber
{
    using System;
    using System.IO;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            File.WriteAllLines("inputNumbers.txt", numbers);

            int maxCount = 0;
            int mostFrequentNum = 0;

            foreach (var currentNumAsStr in File.ReadAllLines("inputNumbers.txt"))
            {
                int num = int.Parse(currentNumAsStr);
                int count = numbers.Count(x => int.Parse(x) == num);
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentNum = num;
                }
            }

            File.WriteAllText("output.txt", $"The number {mostFrequentNum.ToString()} is the most frequent.");
        }
    }
}
