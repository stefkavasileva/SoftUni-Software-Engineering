using System;
using System.Linq;
using System.Text;

namespace _02.ParkingSystem
{
    public class Startup
    {
        public static void Main()
        {
            //80/100
            var matrixSizes = Console.ReadLine().Split().Select(int.Parse);
            var rows = matrixSizes.First();

            var matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[matrixSizes.Last()];
            }

            var results = new StringBuilder();
            var line = Console.ReadLine();
            while (!line.Equals("stop"))
            {
                var tookens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var startRow = tookens[0];
                var desiredRow = tookens[1];
                var desiredCol = tookens[2];
                var distance = 0;

                if (matrix[desiredRow][desiredCol] == 0)
                {
                    distance = Math.Abs(startRow - desiredRow) + 1 + desiredCol;
                    results.AppendLine(distance.ToString());
                    matrix[desiredRow][desiredCol] = 1;
                    line = Console.ReadLine();
                    continue;
                }

                var parkingCol = 0;
                for (int col = 1; col < matrix[desiredRow].Length; col++)
                {
                    if (((desiredCol - col) > 0) && matrix[desiredRow][desiredCol - col] == 0)
                    {
                        parkingCol = desiredCol - col;
                        matrix[desiredRow][desiredCol - col] = 1;
                        break;
                    }
                    else if (((desiredCol + col) < matrix[desiredRow].Length) && matrix[desiredRow][desiredCol + col] == 0)
                    {
                        parkingCol = desiredCol + col;
                        matrix[desiredRow][desiredCol + col] = 1;
                        break;
                    }
                }

                if (parkingCol == 0)
                {
                    results.AppendLine($"Row {desiredRow} full");
                }
                else
                {
                    distance = Math.Abs(startRow - desiredRow) + 1 + parkingCol;
                    results.AppendLine(distance.ToString());
                }

                line = Console.ReadLine();
            }

            Console.Write(results);
        }
    }
}
