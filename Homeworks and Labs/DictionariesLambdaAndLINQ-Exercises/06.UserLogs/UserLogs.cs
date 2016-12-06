using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UserLogs
{
    static void Main(string[] args)
    {
        var usersLogs = new SortedDictionary<string, Dictionary<string, int>>();

        string inputLine = Console.ReadLine();
        while (!inputLine.Equals("end"))
        {
            string[] inputArgs = inputLine.Split();
            string[] userInfo = inputArgs[2].Split('=');
            string userName = userInfo[1];

            if (!usersLogs.ContainsKey(userName))
            {
                usersLogs.Add(userName, new Dictionary<string, int>());
            }

            string[] ipInfo = inputArgs[0].Split('=');
            string ipAddress = ipInfo[1];

            if (!usersLogs[userName].ContainsKey(ipAddress))
            {
                usersLogs[userName].Add(ipAddress, 1);
            }
            else
            {
                usersLogs[userName][ipAddress]++;

            }

            inputLine = Console.ReadLine();
        }

        foreach (var user in usersLogs)
        {
            Console.WriteLine("{0}: ", user.Key);
            int counter = 0;

            foreach (var ip in user.Value)
            {
                if (counter < user.Value.Count - 1)
                {
                    Console.Write("{0} => {1}, ", ip.Key, ip.Value);
                }
                else
                {
                    Console.Write("{0} => {1}.", ip.Key, ip.Value);

                }
                counter++;
            }

            Console.WriteLine();
        }
    }
}

