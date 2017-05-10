using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        var users = new List<User>();

        var inputLine = Console.ReadLine();

        while (!inputLine.ToLower().Equals("end"))
        {
            var userArgs = inputLine.Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = userArgs[userArgs.Length - 1];
            var ipAddress = userArgs[1];

            if (!users.Any(x => x.Name == name))
            {
                var user = new User(name, new List<string>());
                users.Add(user);
            }

            users.First(x => x.Name == name).Logs.Add(ipAddress);
            inputLine = Console.ReadLine();
        }

        foreach (var user in users.OrderBy(x => x.Name))
        {
            Console.WriteLine($"{user.Name}: ");
            var distinctIp = user.Logs.Distinct().ToArray();

            for (int i = 0; i < distinctIp.Count(); i++)
            {
                if (i == distinctIp.Count() - 1)
                {
                    Console.WriteLine($"{distinctIp[i]} => {user.Logs.Where(x => x == distinctIp[i]).Count()}.");
                }
                else
                {
                    Console.Write($"{distinctIp[i]} => {user.Logs.Where(x => x == distinctIp[i]).Count()}, ");
                }
            }
        }
    }
}

