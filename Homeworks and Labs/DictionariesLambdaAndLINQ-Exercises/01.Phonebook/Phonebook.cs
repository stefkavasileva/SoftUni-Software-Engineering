using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Phonebook
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (!inputLine.Equals("END"))
        {
            string[] comandArgs = inputLine.Split().ToArray();
            string comand = comandArgs[0];
            string name = comandArgs[1];

            if (comand.Equals("A"))
            {
                string phoneNumber = comandArgs[2];
                phonebook[name] = phoneNumber;
            }
            else
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }
            }

            inputLine = Console.ReadLine();
        }
    }
}

