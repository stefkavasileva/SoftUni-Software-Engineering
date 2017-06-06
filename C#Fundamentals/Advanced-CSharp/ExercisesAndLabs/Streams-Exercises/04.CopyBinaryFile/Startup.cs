using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    public class Startup
    {
        public static void Main()
        {
            var inputFile = Console.ReadLine();

            using (var reader = new StreamReader(inputFile))
            {
                using (var writer = new StreamWriter("../../result.txt"))
                {
                    var buffer = new char[4096];

                    while (true)
                    {
                        var readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
