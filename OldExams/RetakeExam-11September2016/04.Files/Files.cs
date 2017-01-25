using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Files
{
    static void Main(string[] args)
    {
        int filesCount = int.Parse(Console.ReadLine());

        var filesPaths = new Dictionary<string, Dictionary<string, long>>();

        for (int i = 0; i < filesCount; i++)
        {
            string[] fileArgs = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions
                .RemoveEmptyEntries).ToArray();

            string[] filePathArgs = fileArgs[0]
                .Split(new char[] { '\\' }, StringSplitOptions
                .RemoveEmptyEntries).ToArray();

            long fileSize = long.Parse(fileArgs[1].Trim());
            string root = filePathArgs[0].Trim();
            string fileName = filePathArgs[filePathArgs.Length - 1].Trim();

            if (!filesPaths.ContainsKey(root))
            {
                filesPaths.Add(root, new Dictionary<string, long>());
            }

            if (!filesPaths[root].ContainsKey(fileName))
            {
                filesPaths[root].Add(fileName, 0);
            }

            filesPaths[root][fileName] = fileSize;
        }

        string[] queryFileArgs = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries).ToArray();

        string extension = queryFileArgs[0];
        string queryRoot = queryFileArgs[2];
        bool hasFile = false;

        if (filesPaths.ContainsKey(queryRoot))
        {
            Dictionary<string, long> currentRoot = filesPaths[queryRoot]
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var currentFile in currentRoot)
            {
                if (currentFile.Key.Contains($".{extension}"))
                {
                    Console.WriteLine($"{currentFile.Key} - {currentFile.Value} KB");
                    hasFile = true;
                }
            }

        }

        if (!hasFile)
        {
            Console.WriteLine("No");
        }

    }
}

