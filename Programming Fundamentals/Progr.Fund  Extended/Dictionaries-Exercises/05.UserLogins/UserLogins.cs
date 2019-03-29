using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogins
{
    public static void Main()
    {
        var usersData = new Dictionary<string, string>();

        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine.Equals("login")) break;

            var userArgs = inputLine.Split(" -> ".ToCharArray());
            var name = userArgs.First();
            var password = userArgs.Last();

            if (!usersData.ContainsKey(name))
            {
                usersData.Add(name, string.Empty);
            }

            usersData[name] = password;
        }
        var count = 0;

        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine.Equals("end")) break;

            var userArgs = inputLine.Split(" -> ".ToCharArray());
            var name = userArgs.First();
            var password = userArgs.Last();

            bool isSuccessfu = false;
            if (usersData.ContainsKey(name))
            {
                if (usersData[name] == password)
                {
                    isSuccessfu = true;
                }
            }

            if (!isSuccessfu)
            {
                Console.WriteLine($"{name}: login failed");
                count++;
            }
            else
            {
                Console.WriteLine($"{name}: logged in successfully");
            }
        }

        Console.WriteLine($"unsuccessful login attempts: {count}");
    }
}

