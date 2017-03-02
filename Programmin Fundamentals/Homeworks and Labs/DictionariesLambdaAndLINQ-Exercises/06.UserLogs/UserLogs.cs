using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserLogs
{
    public static void Main()
    {
        var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("end"))
        {
            string[] lineArgs = inputLine.Split().ToArray();

            int index = lineArgs[0].IndexOf('=');
            string ipAddress = lineArgs[0].Substring(index + 1).Trim();

            index = lineArgs[1].IndexOf('=');
            string message = lineArgs[1].Substring(index + 1).Trim();

            index = lineArgs[2].IndexOf('=');
            string username = lineArgs[2].Substring(index + 1).Trim();

            if (!userLogs.ContainsKey(username))
            {
                userLogs.Add(username, new Dictionary<string, int>());
            }

            if (!userLogs[username].ContainsKey(ipAddress))
            {
                userLogs[username].Add(ipAddress, 0);
            }

            userLogs[username][ipAddress]++;

            inputLine = Console.ReadLine();
        }

        foreach (var user in userLogs)
        {
            Console.WriteLine($"{user.Key}:");

            StringBuilder curentLine = new StringBuilder();

            int count = 0;

            foreach (var ip in user.Value)
            {
                if (count == user.Value.Count - 1)
                {
                    curentLine.Append($"{ip.Key} => {ip.Value}.");
                }
                else
                {
                    curentLine.Append($"{ip.Key} => {ip.Value}, ");
                }

                count++;
            }

            Console.WriteLine(curentLine.ToString());
        }
    }
}