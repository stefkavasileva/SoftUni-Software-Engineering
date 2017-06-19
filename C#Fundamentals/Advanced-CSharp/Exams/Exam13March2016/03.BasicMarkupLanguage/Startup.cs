using System;
using System.Linq;
using System.Text;

namespace _03.BasicMarkupLanguage
{
    public class Startup
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var result = new StringBuilder();
            var lineCounter = 1;

            while (!line.Equals("<stop/>"))
            {
                var tokens = line.Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length == 3)
                {
                    if (tokens[0].Contains("reverse"))
                    {
                        result.AppendLine($"{lineCounter}. {new string(tokens[1].Reverse().ToArray())}");
                        lineCounter++;
                    }
                    else
                    {
                        var token = tokens[1];
                        var inverseToken = Inverse(token);
                        result.AppendLine($"{lineCounter}. {inverseToken}");
                        lineCounter++;
                    }
                }
                else if (tokens.Length > 3)
                {
                    var count = int.Parse(tokens[1]);
                    var stringToRepeat = tokens[3];
                    for (int i = 0; i < count; i++)
                    {
                        result.AppendLine($"{lineCounter}. {stringToRepeat}");
                        lineCounter++;
                    }

                }

                line = Console.ReadLine();
            }

            Console.Write(result);
        }

        private static string Inverse(string token)
        {
            var currentToken = new StringBuilder();
            for (int i = 0; i < token.Length; i++)
            {
                if (char.IsUpper(token[i]))
                {
                    currentToken.Append(char.ToLower(token[i]));
                }
                else
                {
                    currentToken.Append(char.ToUpper(token[i]));
                }
            }

            return currentToken.ToString();
        }
    }
}
