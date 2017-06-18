using System;
using System.Linq;

namespace _02.JediGalaxy
{
    public class Startup
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rowsCount = matrixSizes[0];
            var colsCount = matrixSizes[1];

            var matrix = new int [rowsCount][];
            FillMatrix(matrix, colsCount);
            var sum = 0L;

            while (true)
            {
                var ivoCoordinates = Console.ReadLine();
                if(ivoCoordinates.Equals("Let the Force be with you"))break;

                var ivoRow = int.Parse(ivoCoordinates.Split(' ').First());
                var ivoCol = int.Parse(ivoCoordinates.Split(' ').Last());

                var evilCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var evilRow = evilCoordinates[0];
                var evilCol = evilCoordinates[1];

                EvilAction(matrix, evilRow, evilCol);
                sum += IvoAction(matrix, ivoCol, ivoRow);
            }

            Console.WriteLine(sum);
        }

        private static long IvoAction(int[][] matrix, int ivoCol, int ivoRow)
        {
            var sum = 0L;

            if (ivoRow >= matrix.Length)
            {
                var shiftValue = ivoRow - matrix.Length + 1;
                ivoRow -= shiftValue;
                ivoCol += shiftValue;
            }

            if (ivoCol < 0)
            {
                ivoRow -= Math.Abs(ivoCol);
                ivoCol += Math.Abs(ivoCol);
            }

            while (ivoRow >= 0 && ivoCol < matrix[ivoRow].Length)
            {
                sum += matrix[ivoRow][ivoCol];
                ivoRow--;
                ivoCol++;
            }

            return sum;
        }

        private static void EvilAction(int[][] matrix, int evilRow, int evilCol)
        {
            if (evilRow >= matrix.Length)
            {
                var shiftValue = evilRow - matrix.Length + 1;
                evilRow -= shiftValue;
                evilCol -= shiftValue;
            }

            if (evilCol >= matrix[evilRow].Length)
            {
                var shiftValue = evilCol - matrix[evilRow].Length + 1;
                evilRow -= shiftValue;
                evilCol -= shiftValue;
            }

            while (evilRow >= 0 && evilCol >= 0)
            {
                matrix[evilRow][evilCol] = 0;
                evilRow--;
                evilCol--;
            }

        }

        private static void FillMatrix(int[][] matrix, int colsCount)
        {
            var counter = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[colsCount];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }
        }
    }
}
