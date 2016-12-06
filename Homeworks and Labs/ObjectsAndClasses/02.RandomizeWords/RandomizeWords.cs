using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizeWords
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split().ToArray();

        Random rand = new Random();

        for (int first = 0; first < words.Length; first++)
        {
            int second = rand.Next(0, words.Length);
            string old = words[first];
            words[first] = words[second];
            words[second] = old;
        }

        Console.WriteLine(string.Join("\r\n", words));
    }
}

