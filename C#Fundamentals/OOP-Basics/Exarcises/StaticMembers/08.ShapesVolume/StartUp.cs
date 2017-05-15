using System;

namespace _08.ShapesVolume
{
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                var tokens = inputLine.Split();
                var volume = 0.0;

                if (tokens[0].Equals("Cube"))
                {
                    var cube = new Cube { sideLenght = double.Parse(tokens[1]) };
                    volume = VolumeCalculator.GetVolume(cube);
                }
                else if (tokens[0].Equals("Cylinder"))
                {
                    var cylinder = new Cylinder { radius = double.Parse(tokens[1]), height = double.Parse(tokens[2]) };
                    volume = VolumeCalculator.GetVolume(cylinder);
                }
                else
                {
                    var triangularPrism = new TriangularPrism
                    {
                        lenght = double.Parse(tokens[1]),
                        baseSide = double.Parse(tokens[2]),
                        height = double.Parse(tokens[3])

                    };

                    volume = VolumeCalculator.GetVolume(triangularPrism);
                }

                Console.WriteLine($"{volume:f3}");
                inputLine = Console.ReadLine();
            }
        }
    }
}
