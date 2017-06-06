using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.DirectoryTraversal
{
    public class Startup
    {
        public static void Main()
        {
            var allFiles = new Dictionary<string, Dictionary<string, long>>();
            var dir = GetDirectory();
            var files = Directory.GetFiles(dir);
          
            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                var fileSize = new FileInfo(file).Length;

                if (!allFiles.ContainsKey(extension))
                {
                    allFiles[extension] = new Dictionary<string, long>();
                }

                allFiles[extension][file] = fileSize;
            }

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var report = Path.Combine(dir, "report.txt");

            using (var writer = new StreamWriter(report))
            {
                foreach (var group in allFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    var filesInGroup = string.Join(Environment.NewLine, group.Value
                        .OrderByDescending(f => f.Value)
                        .Select(kvp => $"--{kvp.Key} - {kvp.Value}kb"));

                    writer.Write($"{group.Key}{Environment.NewLine}{filesInGroup}{Environment.NewLine}");
                }
            }
        }

        public static string GetDirectory()
        {
            Console.Write("Enter Directory path: ");
            var dir = Console.ReadLine();

            while (!Directory.Exists(dir))
            {
                Console.WriteLine($@"This Directory does not exists. Please try again. You must enter the full path to your folder{Environment.NewLine}e.g. ""D:\Software-University-SoftUni\C# Advanced""");
                dir = Console.ReadLine();
            }

            return dir;
        }
    }
}
