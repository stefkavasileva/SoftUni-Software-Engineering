using System;
using System.Linq;
using System.Text;

namespace _08.RadioactiveBunnies
{

    public class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }

    public class Startup
    {
        public static void Main()
        {
            //80/100
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrixRows = matrixSizes[0];
            var matrix = new char[matrixRows][];

            for (int rowIndex = 0; rowIndex < matrixRows; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToCharArray();
            }

            var player = new Player();

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex].Equals('P'))
                    {
                        player.Row = rowIndex;
                        player.Col = colIndex;
                    }
                }
            }

            var sb = new StringBuilder();
            var gameOver = false;

            var comands = Console.ReadLine();
            foreach (var comand in comands)
            {
                var nextRow = player.Row;
                var nextCol = player.Col;
                if (comand.Equals('U'))
                {
                    nextRow = player.Row - 1;
                }
                else if (comand.Equals('D'))
                {
                    nextRow = player.Row + 1;
                }
                else if (comand.Equals('L'))
                {
                    nextCol = player.Col - 1;
                }
                else
                {
                    nextCol = player.Col + 1;
                }

                if (nextCol < 0 || nextCol > matrix[player.Row].Length - 1 || nextRow < 0 ||
                    nextRow > matrix.Length - 1)
                {
                    sb.AppendLine($"won: {player.Row} {player.Col}");
                    gameOver = true;
                }

                if (!gameOver && matrix[nextRow][nextCol].Equals('B'))
                {
                    sb.AppendLine($"dead: {nextRow} {nextCol}");
                    gameOver = true;
                }

                if (gameOver)
                {
                    matrix[player.Row][player.Col] = '.';
                    matrix = MultiplayBunnies(matrix);
                    break;
                }

                if (IsPlayerDie(matrix))
                {
                    break;
                }

                matrix[player.Row][player.Col] = '.';
                player.Row = nextRow;
                player.Col = nextCol;
                matrix[player.Row][player.Col] = 'P';
                matrix = MultiplayBunnies(matrix);
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    Console.Write(matrix[rowIndex][colIndex]);
                }

                Console.WriteLine();
            }

            Console.Write(sb);
        }

        private static bool IsPlayerDie(char[][] matrix)
        {
            var isPlayerDie = true;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                if (!matrix[rowIndex].Contains('P'))
                {
                    isPlayerDie = false;
                }
            }

            return isPlayerDie;
        }

        private static char[][] MultiplayBunnies(char[][] matrix)
        {
            var temp = new char[matrix.Length][];
            for (int rowIndex = 0; rowIndex < temp.Length; rowIndex++)
            {
                temp[rowIndex] = new char[matrix[rowIndex].Length];
                for (int colIndex = 0; colIndex < temp[rowIndex].Length; colIndex++)
                {
                    temp[rowIndex][colIndex] = matrix[rowIndex][colIndex];
                }
            }


            for (int rowIndex = 0; rowIndex < temp.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < temp[rowIndex].Length; colIndex++)
                {
                    if (temp[rowIndex][colIndex].Equals('B') && matrix[rowIndex][colIndex] == 'B')
                    {
                        temp[Math.Max(0, rowIndex - 1)][colIndex] = 'B';
                        temp[Math.Min(temp.Length - 1, rowIndex + 1)][colIndex] = 'B';
                        temp[rowIndex][Math.Min(colIndex + 1, temp[rowIndex].Length - 1)] = 'B';
                        temp[rowIndex][Math.Max(0, colIndex - 1)] = 'B';
                    }
                }
            }

            return temp;
        }
    }
}
