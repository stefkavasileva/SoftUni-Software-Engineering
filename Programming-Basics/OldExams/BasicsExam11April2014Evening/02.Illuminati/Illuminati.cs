using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Illuminati
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine().ToUpper();

        int vowelCount = 0;
        int vowelSum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == 'A' || message[i] == 'E' || message[i] == 'I' || message[i] == 'O' || message[i] == 'U')
            {
                vowelSum += message[i];
                vowelCount++;
            }
        }

        Console.WriteLine(vowelCount);
        Console.WriteLine(vowelSum);
    }
}

