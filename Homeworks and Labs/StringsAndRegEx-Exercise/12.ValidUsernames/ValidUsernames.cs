using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ValidUsernames
{
    static void Main(string[] args)
    {
        string[] usernames = Console.ReadLine()
            .Split(new char[] { '\\', '/', '(', ')',' ' }, 
             StringSplitOptions.RemoveEmptyEntries)
            .Select(x=>x.Trim())
            .ToArray();

        List<string> validUsernames = new List<string>();
        string pattern = @"^[A-Za-z][A-Za-z\d_]{2,24}$";
        Regex reg = new Regex(pattern);

        for (int i = 0; i < usernames.Length; i++)
        {
            if (reg.IsMatch(usernames[i]))
            {
                validUsernames.Add(usernames[i]);
            }
        }

        int maxLenght = 0;
        int startIndex = 0;
        for (int i = 0; i < validUsernames.Count-1; i++)
        {
            if (validUsernames[i].Length+validUsernames[i+1].Length>maxLenght)
            {
                maxLenght = validUsernames[i].Length + validUsernames[i + 1].Length;
                startIndex = i;
            }
        }

        string firstUsername = validUsernames[startIndex].Trim();
        string secondUsername = validUsernames[startIndex + 1].Trim();
        Console.WriteLine(firstUsername);
        Console.WriteLine(secondUsername);

    }
}

