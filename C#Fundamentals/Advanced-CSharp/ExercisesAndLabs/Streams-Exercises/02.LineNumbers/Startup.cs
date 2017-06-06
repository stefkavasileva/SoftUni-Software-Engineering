using System;
using System.IO;

namespace _02.LineNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var filePath = Console.ReadLine();

            using (var reader = new StreamReader(filePath))
            {
                using (var writer = new StreamWriter("../../result.txt"))
                {
                    var line = reader.ReadLine();
                    var counter = 1;

                    while (line != null)
                    {
                        writer.WriteLine($"{counter} {line}");
                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }         
        }
    }
}
