namespace _04.MergeFiles
{
    using System;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            var firstFile = File.ReadAllLines("firstInput.txt");
            var secondFile = File.ReadAllLines("secondInput.txt");

            File.WriteAllText("result.txt", string.Empty);

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("result.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            }
        }
    }
}
