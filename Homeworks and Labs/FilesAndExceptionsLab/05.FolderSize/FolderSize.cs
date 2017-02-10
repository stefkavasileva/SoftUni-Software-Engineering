namespace _05.FolderSize
{
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("оutput.txt", sum.ToString());
        }
    }
}
