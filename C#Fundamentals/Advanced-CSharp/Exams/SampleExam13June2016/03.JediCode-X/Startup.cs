using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.JediCode_X
{
    public class Startup
    {
        public static void Main()
        {
            var lineCount = int.Parse(Console.ReadLine());

            var input = new StringBuilder();

            for (int i = 0; i < lineCount; i++)
            {
                input.Append(Console.ReadLine());
            }

            var namePattern = Console.ReadLine();
            var messagePttern = Console.ReadLine();
           
            var nameRegex = new Regex($"{namePattern}([A-Za-z]{{{namePattern.Length}}})(?![A-Za-z])");   
            var messageRegex = new Regex($"{messagePttern}([A-Za-z0-9]{{{messagePttern.Length}}})(?![A-Za-z0-9])");


            var jediNames = new List<string>();
            var jediMessages = new List<string>();


            var namesMatches = nameRegex.Matches(input.ToString());
            var messageMatches = messageRegex.Matches(input.ToString());

            foreach (Match namesMatch in namesMatches)
            {
                jediNames.Add(namesMatch.Groups[1].Value);
            }

            foreach (Match jediMessage in messageMatches)
            {
                jediMessages.Add(jediMessage.Groups[1].Value);
            }

            var messageIndex = Console.ReadLine()
                .Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
             
            var result = new StringBuilder();

            int currentJediIndex = 0;
            for (int i = 0; i < messageIndex.Length; i++)
            {
                if (messageIndex[i] - 1 < jediMessages.Count && currentJediIndex < jediNames.Count)
                {
                    result.AppendLine($"{jediNames[currentJediIndex]} - {jediMessages[messageIndex[i] - 1]}");
                    currentJediIndex++;
                }
            }

            Console.Write(result);
        }
    }
}
