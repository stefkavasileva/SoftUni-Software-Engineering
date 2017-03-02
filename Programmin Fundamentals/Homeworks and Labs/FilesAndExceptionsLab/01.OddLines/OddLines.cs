namespace _01.OddLines
{
    using System.IO;
    using System.Linq;

    public class OddLines
    {
        public static void Main()
        {
            var inputFile = File.ReadAllLines("text.txt");
            var oddLineFromFile = inputFile.Where((x, i) => i % 2 != 0).ToArray();
            File.WriteAllLines("output.txt", oddLineFromFile);
        }
    }
}
