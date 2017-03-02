using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EncryptTheMessages
{
    static void Main(string[] args)
    {
        string comandStart = Console.ReadLine();
        while (comandStart != "START" && comandStart != "start")
        {
            comandStart = Console.ReadLine();
        }
        List<string> allMessages = new List<string>();
        for (;;)
        {
            string message = Console.ReadLine();
            if (message == "END" || message == "end")
            {
                break;
            }
            else if (message == string.Empty)
            {
                continue;
            }
            string newMessage = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 65 && message[i] <= 77)
                {
                    char letter = (char)(message[i] + 13);
                    newMessage = letter + newMessage;
                }
                else if (message[i] >= 78 && message[i] <= 90)
                {
                    char letter = (char)(message[i] - 13);
                    newMessage = letter + newMessage;
                }
                else if (message[i] >= 97 && message[i] <= 109)
                {
                    char letter = (char)(message[i] + 13);
                    newMessage = letter + newMessage;
                }
                else if (message[i] >= 110 && message[i] <= 122)
                {
                    char letter = (char)(message[i] - 13);
                    newMessage = letter + newMessage;
                }
                else if ((int)char.GetNumericValue(message[i]) >= 0 && (int)char.GetNumericValue(message[i]) <= 9)
                {

                    newMessage = message[i].ToString() + newMessage;
                }
                else if (message[i] == ' ')
                {
                    newMessage = "+" + newMessage;
                }
                else if (message[i] == ',')
                {
                    newMessage = "%" + newMessage;
                }
                else if (message[i] == '.')
                {
                    newMessage = "&" + newMessage;
                }
                else if (message[i] == '?')
                {
                    newMessage = "#" + newMessage;
                }
                else if (message[i] == '!')
                {
                    newMessage = "$" + newMessage;
                }
            }

            allMessages.Add(newMessage);
        }

        if (allMessages.Count == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", allMessages.Count);
            foreach (string message in allMessages)
            {
                Console.WriteLine(message);
            }
        }

    }
}

