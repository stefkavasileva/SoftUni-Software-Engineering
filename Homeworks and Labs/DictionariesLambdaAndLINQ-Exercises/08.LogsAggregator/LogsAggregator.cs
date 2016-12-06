using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LogsAggregator
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] inputLine = Console.ReadLine().Split();
            string name = inputLine[1];
            string ipAddress = inputLine[0];
            int duration = int.Parse(inputLine[2]);

            if (!logs.ContainsKey(name))
            {
                logs.Add(name, new SortedDictionary<string, int>());
            }

            if (!logs[name].ContainsKey(ipAddress))
            {
                logs[name].Add(ipAddress, duration);
            }
            else
            {
                logs[name][ipAddress] += duration;
            }
        }


        foreach (var l in logs)
        {
            SortedDictionary<string, int> ipLogs = l.Value;
            Console.WriteLine("{0}: {1} [{2}]",
                l.Key,
                ipLogs.Values.Sum(x => x),
                string.Join(", ", ipLogs.Keys));

        }
    }
}

