using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class CubicMessages
{
    public static void Main()
    {
        var result = new StringBuilder();

        var message = Console.ReadLine();
        while (!message.ToLower().Equals("over!"))
        {
            var messageLenght = int.Parse(Console.ReadLine());
            var reg = new Regex($@"^\d+([A-Za-z]{{{messageLenght}}})[^A-Za-z]*$");
            var match = reg.Match(message);

            if (match.Success)
            {
                var indexes = message.Where(x => char.IsDigit(x)).ToArray();
                var currentMessage = match.Groups[1].Value;
                var code = string.Empty;

                for (int i = 0; i < indexes.Count(); i++)
                {
                    var currentIndex = (int)char.GetNumericValue(indexes[i]);
                    if (currentIndex < 0 || currentIndex >= currentMessage.Length)
                    {
                        code += " ";
                    }
                    else
                    {
                        code += currentMessage[currentIndex];
                    }
                }

                result.AppendLine($"{currentMessage} == {code}");
            }

            message = Console.ReadLine();
        }

        Console.Write(result);
    }
}