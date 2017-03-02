using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecryptTheMessages
{
    static void Main(string[] args)
    {

        string comandStart = Console.ReadLine();

        while (comandStart != "start" && comandStart != "START")
        {
            comandStart = Console.ReadLine();
        }

        string message = Console.ReadLine();
        List<List<char>> decriptedMessages = new List<List<char>>();
        int numOfMessage = 0;

        while (message != "end" && message != "END")
        {
            if (message.Equals(string.Empty))
            {
                message = Console.ReadLine();
                continue;
            }

            char[] messageSymbol = message.ToCharArray();
            List<char> messageletter = new List<char>();

            for (int i = 0; i < messageSymbol.Length; i++)
            {
                if (char.IsLetter(messageSymbol[i]))
                {
                    if (messageSymbol[i] >= 'A' && messageSymbol[i] <= 'M' ||
                        (messageSymbol[i] >= 'a' && messageSymbol[i] <= 'm'))
                    {
                        messageletter.Add((char)(messageSymbol[i] + 13));
                    }
                    else if (messageSymbol[i] >= 'm' && messageSymbol[i] >= 'a' ||
                       (messageSymbol[i] >= 'M' && messageSymbol[i] >= 'A'))
                    {
                        messageletter.Add((char)(messageSymbol[i] - 13));
                    }
                }
                else if (char.IsDigit(messageSymbol[i]))
                {
                    messageletter.Add(messageSymbol[i]);
                }
                else if (messageSymbol[i] == '+')
                {
                    messageletter.Add(' ');
                }
                else if (messageSymbol[i] == '%')
                {
                    messageletter.Add(',');
                }
                else if (messageSymbol[i] == '&')
                {
                    messageletter.Add('.');
                }
                else if (messageSymbol[i] == '#')
                {
                    messageletter.Add('?');
                }
                else if (messageSymbol[i] == '$')
                {
                    messageletter.Add('!');
                }

            }

            numOfMessage++;
            messageletter.Reverse();
            decriptedMessages.Add(messageletter);
            message = Console.ReadLine();
        }


        if (decriptedMessages.Count == 0)
        {
            Console.WriteLine("No message received.");
            return;
        }


        Console.WriteLine("Total number of messages: {0}", numOfMessage);

        foreach (var m in decriptedMessages)
        {
            Console.WriteLine(string.Join("", m));
        }
    }
}

