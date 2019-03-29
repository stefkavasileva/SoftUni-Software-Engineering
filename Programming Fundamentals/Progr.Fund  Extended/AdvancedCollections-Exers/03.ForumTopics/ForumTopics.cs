using System;
using System.Collections.Generic;
using System.Linq;

public class ForumTopics
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var topics = new Dictionary<string, HashSet<string>>();

        while (!inputLine.Equals("filter"))
        {
            var tokens =
                inputLine.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim(','))
                    .ToArray();

            var topicName = tokens[0];
            var tags = tokens.Skip(1).ToList();

            if (!topics.ContainsKey(topicName))
            {
                topics.Add(topicName, new HashSet<string>());
                var test = new HashSet<string>();
            }

            tags.ForEach(t => topics[topicName].Add(t));

            inputLine = Console.ReadLine();
        }

        var inputTags = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (var kvp in topics)
        {
            var topicTags = kvp.Value;
            bool hasAllTags = CheckForTags(inputTags, topicTags);
            if (hasAllTags)
            {
                Console.WriteLine($"{kvp.Key} | {string.Join(", ", topicTags.Select(t => $"#{t}"))}");
            }
        }
    }

    public static bool CheckForTags(List<string> inputTags, HashSet<string> topicTags)
    {
        bool hasAllTags = true;
        foreach (var tag in inputTags)
        {
            if (!topicTags.Contains(tag))
            {
                hasAllTags = false;
                break;
            }
        }

        return hasAllTags;
    }
}
