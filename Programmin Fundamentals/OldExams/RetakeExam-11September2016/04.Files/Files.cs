using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    public static void Main()
    {
        var filesCount = int.Parse(Console.ReadLine());

        var filesPaths = new Dictionary<string, Dictionary<string, long>>();

        for (int i = 0; i < filesCount; i++)
        {
            var fileArgs = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions
                .RemoveEmptyEntries).ToArray();

            var filePathArgs = fileArgs[0]
                .Split(new char[] { '\\' }, StringSplitOptions
                .RemoveEmptyEntries).ToArray();

            var fileSize = long.Parse(fileArgs[1].Trim());
            var root = filePathArgs[0].Trim();
            var fileName = filePathArgs[filePathArgs.Length - 1].Trim();

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

        var queryFileArgs = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries).ToArray();

        var extension = queryFileArgs[0];
        var queryRoot = queryFileArgs[2];
        var hasFile = false;

        if (filesPaths.ContainsKey(queryRoot))
        {
            var currentRoot = filesPaths[queryRoot]
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