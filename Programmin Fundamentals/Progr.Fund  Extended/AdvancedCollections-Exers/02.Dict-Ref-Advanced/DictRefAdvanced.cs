using System;
using System.Collections.Generic;
using System.Linq;

public class DictRefAdvanced
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var refDic = new Dictionary<string, List<int>>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var key = tokens[0];
            var values = tokens.Skip(1).Select(x => x.Trim(',')).ToArray();
            var isKey = IsKey(values);

            if (!isKey)
            {
                AddKey(refDic, key);
                refDic[key].AddRange(values.Select(int.Parse));
            }
            else
            {
                if (refDic.ContainsKey(values[0]))
                {
                    AddKey(refDic, tokens[0]);
                    refDic[tokens[0]].AddRange(refDic[values[0]]);
                }
            }

            inputLine = Console.ReadLine();
        }

        foreach (var kvp in refDic)
        {
            Console.WriteLine($"{kvp.Key} === {string.Join(", ",kvp.Value)}");
        }
    }

    public static void AddKey(Dictionary<string, List<int>> refDic, string key)
    {
        if (!refDic.ContainsKey(key))
        {
            refDic.Add(key, new List<int>());
        }
    }

    public static bool IsKey(string[] tokens)
    {
        return tokens.Length == 1 && tokens[0].All(s => !char.IsDigit(s));
    }
}
