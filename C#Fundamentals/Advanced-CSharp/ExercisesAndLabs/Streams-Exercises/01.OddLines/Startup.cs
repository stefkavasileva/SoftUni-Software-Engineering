using System;
using System.IO;
using System.Text;

namespace _01.OddLines
{
    public class Startup
    {
        public static void Main()
        {
            var file = Console.ReadLine();
            var oddLines = new StringBuilder();

            using (var reader = new StreamReader(file))
            {
                var lineNumber = 0;
                var line = reader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        oddLines.AppendLine(line);
                    }

                    lineNumber++;
                    line = reader.ReadLine();
                }
            }

            Console.Write(oddLines);
        }
    }
}
