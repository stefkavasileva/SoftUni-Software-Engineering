using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class QueryMess
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        while (!line.Equals("END"))
        {
            var pairsValues = new Dictionary<string, List<string>>();
            string[] pairs = line
                .Split(new char[] { '&', '?' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> pairsAndValueArgs = new List<string>();
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = Regex.Replace(pairs[i], @"(\+|%20)+", " ").Trim();
      
                Regex reg = new Regex(@"[^\&\?]+=[^\&\?]+");
                if (reg.IsMatch(pairs[i]))
                {
                    string[] temp = pairs[i]
                        .Split(new char[] { '=' }
                        , StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim()).ToArray();

                    if (!pairsValues.ContainsKey(temp[0]))
                    {
                        pairsValues.Add(temp[0], new List<string>());
                    }
                    pairsValues[temp[0]].Add(temp[1]);
                }

            }
            foreach (var p in pairsValues)
            {
                Console.Write($"{p.Key}=[{string.Join(", ", p.Value)}]");
            }
            Console.WriteLine();

            line = Console.ReadLine();
        }
    }
}


