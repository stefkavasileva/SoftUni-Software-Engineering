using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    public static void Main()
    {
        var files = new Dictionary<string, Dictionary<string, long>>();

        var filesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < filesCount; i++)
        {
            var filePathArgs = Console.ReadLine()
                .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var root = filePathArgs.First().Trim();

            var fileArgs = filePathArgs
                .Last()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            var name = fileArgs.First().Trim();
            var size = long.Parse(fileArgs.Last().Trim());

            if (!files.ContainsKey(root))
            {
                files.Add(root, new Dictionary<string, long>());
            }

            if (!files[root].ContainsKey(name))
            {
                files[root].Add(name, 0);
            }

            files[root][name] = size;
        }

        var filesInGivenRoot = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var extension = filesInGivenRoot.First().Trim();
        var givenRoot = filesInGivenRoot.Last().Trim();

        bool hasFile = false;

        if (files.ContainsKey(givenRoot))
        {
            var currentFiles = files[givenRoot].OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var file in currentFiles)
            {
                if (file.Key.Contains($".{extension}"))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
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