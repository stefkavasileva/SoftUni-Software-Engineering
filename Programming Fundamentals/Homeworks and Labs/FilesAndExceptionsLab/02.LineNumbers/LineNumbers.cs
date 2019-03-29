namespace _02.LineNumbers
{
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            var file = File.ReadAllLines("input.txt");
            var outputFileText = new List<string>();

            int lineCount = 1;
            foreach (var line in file)
            {
                outputFileText.Add($"{lineCount}. {line}");
                lineCount++;
            }

            File.WriteAllLines("output.txt", outputFileText);
        }
    }
}
