using System;
using System.Collections.Generic;
using System.Linq;

public class TrackDownloader
{
    public static void Main()
    {
        var blackList = Console.ReadLine().Split();

        var result = new List<string>();

        var fileName = Console.ReadLine();
        while (!fileName.Equals("end"))
        {
            var contains = false;
            foreach (var item in blackList)
            {
                if (fileName.Contains(item))
                {
                    contains = true;
                }
            }

            if (!contains)
            {
                result.Add(fileName);
            }

            fileName = Console.ReadLine();
        }

        result = result.OrderBy(x => x).ToList();
        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}