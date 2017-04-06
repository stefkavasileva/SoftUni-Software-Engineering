using System;
using System.Collections.Generic;
using System.Linq;

public class Dict_Ref
{
    public static void Main()
    {
        var refDic = new Dictionary<string, int>();

        while (true)
        {
            var pair = Console.ReadLine();
            if (pair.Equals("end")) break;

            var pairArgs = pair.Split('=').Select(x => x.Trim());
            var key = pairArgs.First();
            var valueAsStr = pairArgs.Last();

            var valueNum = 0;
            bool isDigit = int.TryParse(valueAsStr, out valueNum);

            if (isDigit)
            {
                if (!refDic.ContainsKey(key))
                {
                    refDic.Add(key, 0);
                }

                refDic[key] = valueNum;
            }
            else
            {
                if (refDic.ContainsKey(valueAsStr))
                {
                    if (!refDic.ContainsKey(key))
                    {
                        refDic.Add(key,0);
                    }

                    refDic[key] = refDic[valueAsStr];
                }
            }
        }

        foreach (var kvp in refDic)
        {
            Console.WriteLine($"{kvp.Key} === {kvp.Value}");
        }
    }
}
