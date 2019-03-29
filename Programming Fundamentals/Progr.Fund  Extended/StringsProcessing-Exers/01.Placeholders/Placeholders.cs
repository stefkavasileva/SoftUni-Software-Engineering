using System;
using System.Linq;

public class Placeholders
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var text = tokens[0];
            var elements = tokens[1]
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var indexFirst = text.IndexOf("{");
            var indexLast = text.IndexOf("}");

            while (indexFirst != -1)
            {
                var index = int.Parse(text.Substring(indexFirst + 1, indexLast - indexFirst - 1));
                var oldStr = text.Substring(indexFirst, indexLast - indexFirst + 1);

                if (index >= 0 && index < elements.Length)
                {
                    text = text.Replace(oldStr, elements[index]);
                }

                indexFirst = text.IndexOf("{", indexFirst + 1);

                if (indexFirst == -1)
                {
                    break;
                }

                indexLast = text.IndexOf("}", indexLast + 1);
            }

            //<====== With regular expression =====>
            //string pattern = @"{(\d+)}";

            //foreach (Match m in Regex.Matches(text, pattern))
            //{
            //    var index = int.Parse(m.Groups[1].Value);
            //    if (index >= 0 && index < elements.Length)
            //    {
            //        text = text.Replace(m.Value, elements[index]);
            //    }
            //}

            Console.WriteLine(text);

            inputLine = Console.ReadLine();
        }
    }
}

