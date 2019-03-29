using System;
using System.Collections.Generic;
using System.Linq;

public class Messages
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var users = new List<User>();

        while (!inputLine.Equals("exit"))
        {
            var tokens = inputLine.Split();

            if (tokens.Length.Equals(2))
            {
                var userName = tokens[1];
                var user = new User { UserName = userName, ReceivedMessages = new List<Message>() };
                users.Add(user);
            }
            else
            {
                var senderUsername = tokens[0];
                var recipientUsername = tokens[2];

                if (!users.Any(u => u.UserName == senderUsername) || !users.Any(u => u.UserName == recipientUsername))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var content = tokens[3];
                var sender = users.Where(u => u.UserName == senderUsername).First();
                var message = new Message { Sender = sender, Content = content };

                users.Where(u => u.UserName == recipientUsername).First().ReceivedMessages.Add(message);
            }

            inputLine = Console.ReadLine();
        }

        inputLine = Console.ReadLine();
        var usersNames = inputLine.Split();

        var recipientMessages = users
            .Where(u => u.UserName == usersNames[0])
            .First()
            .ReceivedMessages
            .Where(m => m.Sender.UserName == usersNames[1])
            .ToArray();

        var senderMessages = users
            .Where(u => u.UserName == usersNames[1])
            .First()
            .ReceivedMessages
            .Where(m => m.Sender.UserName == usersNames[0])
            .ToArray();

        var hasMessage = false;

        for (int i = 0; i < Math.Max(recipientMessages.Length, senderMessages.Length); i++)
        {
            if (senderMessages.Length > i)
            {
                Console.WriteLine($"{usersNames[0]}: {senderMessages[i].Content}");
                hasMessage = true;
            }

            if (recipientMessages.Length > i)
            {
                Console.WriteLine($"{recipientMessages[i].Content} :{usersNames[1]}");
                hasMessage = true;
            }
        }

        if (!hasMessage)
        {
            Console.WriteLine("No messages");
        }
    }
}

