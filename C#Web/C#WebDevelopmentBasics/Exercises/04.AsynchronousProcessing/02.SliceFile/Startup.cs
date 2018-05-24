using System;
using System.IO;
using System.Threading.Tasks;

namespace _02.SliceFile
{
    public class Startup
    {
        public static void Main()
        {
            //still working on it
            var videoPath = Console.ReadLine();
            var destination = Console.ReadLine();
            var pieces = int.Parse(Console.ReadLine());

            SliceAsync(videoPath, destination, pieces);

            Console.WriteLine("Anything else?");
            while (true) Console.ReadLine();
        }

        private static void SliceAsync(string videoPath, string destination, int pieces)
        {
            Task.Run(() => { Slice(videoPath, destination, pieces); });
        }

        private static void Slice(string videoPath, string destination, int pieces)
        {
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            using (var source = new FileStream(videoPath, FileMode.Open))
            {
                var fileInfo = new FileInfo(videoPath);

                var partLength = (source.Length / pieces) + 1L;
                var currentByte = 0L;

                for (int currentPath = 1; currentPath <= pieces; currentPath++)
                {
                    var filePath = string.Format("{0}/Part-{1}{2}",
                        destination, currentPath, fileInfo.Extension);
                }

                using (var destinationNew = new FileStream(videoPath, FileMode.Create))
                {
                   // var buffer = new byte[BufferLenght];
                    
                }
            }
        }
    }
}
