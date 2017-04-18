using System;
using System.Collections.Generic;
using System.Linq;

public class FlattenDictionary
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var dic = new Dictionary<string, Dictionary<string, string>>();
        var flattenKeys = new List<string>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine.Split();

            if (tokens.Length != 2)
            {
                var key = tokens[0];
                var innerKey = tokens[1];
                var value = tokens[2];

                if (flattenKeys.Contains(key))
                {
                    var concatedPairs = innerKey + value;
                    if (dic[key].Any(x => x.Key.Equals(concatedPairs)))
                    {
                        dic[key].Remove(concatedPairs);
                    }
                }

                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, new Dictionary<string, string>());
                }

                if (!dic[key].ContainsKey(innerKey))
                {
                    dic[key].Add(innerKey, string.Empty);
                }

                dic[key][innerKey] = value;

            }
            else
            {
                var key = tokens[1];
                var keyValuePapirs = new List<string>();

                foreach (var kvp in dic[key])
                {
                    var innerKey = kvp.Key;
                    var value = kvp.Value;
                    var concatedKey = innerKey + value;
                    keyValuePapirs.Add(concatedKey);
                    keyValuePapirs.Add(value);
                }

                for (int i = 0; i < keyValuePapirs.Count - 1; i += 2)
                {
                    dic[key].Add(keyValuePapirs[i], string.Empty);
                }

                flattenKeys.Add(key);
            }

            inputLine = Console.ReadLine();
        }

        foreach (var kvp in dic.OrderByDescending(x => x.Key.Length))
        {
            var nonFlattenKvp = kvp.Value.Where(x => x.Value != string.Empty).OrderBy(x => x.Key.Length);
            var flattenKvp = kvp.Value.Where(x => x.Value == string.Empty).ToDictionary(x => x.Key, x => x.Value);
            var count = 1;

            Console.WriteLine(kvp.Key);

            foreach (var innerKvp in nonFlattenKvp)
            {
                var concated = innerKvp.Key + innerKvp.Value;

                if (flattenKvp.Keys.Contains(concated))
                {
                    continue;
                }

                Console.WriteLine($"{count}. {innerKvp.Key} - {innerKvp.Value}");
                count++;
            }

            foreach (var innerKvp in flattenKvp)
            {
                Console.WriteLine($"{count}. {innerKvp.Key}");
                count++;
            }
        }
    }
}

