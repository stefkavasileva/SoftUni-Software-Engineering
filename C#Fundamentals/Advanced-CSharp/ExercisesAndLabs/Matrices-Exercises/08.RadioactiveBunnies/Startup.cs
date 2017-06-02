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
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var matrix = new char[matrixSizes[0]][];
            var player = new Player();

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                var currentRow = Console.ReadLine();
                matrix[rowIndex] = currentRow.ToCharArray();
                if (currentRow.Contains('P'))
                {
                    player.Row = rowIndex;
                    player.Col = currentRow.IndexOf('P');
                }
            }

            var sb = new StringBuilder();

            var comands = Console.ReadLine();
            foreach (var comand in comands)
            {
                if (comand.Equals('U'))
                {
                    if (player.Row <= 0)
                    {
                        sb.AppendLine($"won: {player.Row} {player.Col}");
                        matrix[player.Row][player.Col] = '.';
                        matrix = MultiplyBunnies(matrix);
                        break;
                    }

                    if (matrix[player.Row - 1][player.Col] == 'B')
                    {
                        sb.AppendLine($"dead: {player.Row} {player.Col}");
                        matrix = MultiplyBunnies(matrix);
                        break;
                    }

                    matrix[player.Row - 1][player.Col] = 'P';
                    matrix[player.Row][player.Col] = '.';
                    player.Row--;
                }
                else if (comand.Equals('D'))
                {
                    if (player.Row >= matrix.Length)
                    {
                        sb.AppendLine($"won: {player.Row} {player.Col}");
                        matrix[player.Row][player.Col] = '.';
                        matrix = MultiplyBunnies(matrix);
                        break;
                    }

                    if (matrix[player.Row + 1][player.Col] == 'B')
                    {
                        sb.AppendLine($"dead: {player.Row} {player.Col}");
                        matrix = MultiplyBunnies(matrix);
                        break;
                    }

                    matrix[player.Row + 1][player.Col] = 'P';
                    matrix[player.Row][player.Col] = '.';
                    player.Row++;
                }
                else if (comand.Equals('L'))
                {
                    if (player.Col <= 0)
                    {
                        sb.AppendLine($"won: {player.Row} {player.Col}");
                        matrix = MultiplyBunnies(matrix);
                        matrix[player.Row][player.Col] = '.';
                        break;
                    }

                    if (matrix[player.Row][player.Col - 1] == 'B')
                    {
                        sb.AppendLine($"dead: {player.Row} {player.Col}");
                        matrix = MultiplyBunnies(matrix);
                        break;
                    }

                    matrix[player.Row][player.Col - 1] = 'P';
                    matrix[player.Row][player.Col] = '.';
                    player.Col--;
                }
                else
                {
                    if (player.Col >= matrix.Length)
                    {
                        sb.AppendLine($"won: {player.Row} {player.Col}");
                        matrix = MultiplyBunnies(matrix);
                        matrix[player.Row][player.Col] = '.';
                        break;
                    }

                    if (matrix[player.Row][player.Col + 1] == 'B')
                    {
                        sb.AppendLine($"dead: {player.Row} {player.Col}");
                        matrix = MultiplyBunnies(matrix);
                        break;
                    }

                    matrix[player.Row][player.Col + 1] = 'P';
                    matrix[player.Row][player.Col] = '.';
                    player.Col++;
                }

                matrix = MultiplyBunnies(matrix);
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));

            }

            if (sb.ToString().Any())
            {
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine($"won: {player.Row} {player.Col}");
            }

        }

        private static char[][] MultiplyBunnies(char[][] matrix)
        {
            var temp = new char[matrix.Length][];

            for (int row = 0; row < matrix.Length; row++)
            {
                temp[row] = new char[matrix[row].Length];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        var leftSpread = Math.Max(0, col - 1);
                        var rightSpread = Math.Min(col + 1, matrix[row].Length - 1);
                        var upSpread = Math.Max(0, row - 1);
                        var downSpread = Math.Min(row + 1, matrix.Length - 1);

                        temp[row][col] = 'B';
                        temp[upSpread][col] = 'B';
                        temp[downSpread][col] = 'B';
                        temp[row][leftSpread] = 'B';
                        temp[row][rightSpread] = 'B';

                    }
                    else if (matrix[row][col] == 'P')
                    {
                        temp[row][col] = 'P';
                    }
                    else if (temp[row][col] == 0)
                    {
                        temp[row][col] = '.';
                    }
                }
            }

            return temp;
        }
        

        private static void MultiplyBunny(char[][] matrix, int rowIndex, int colIndex)
        {
            if (rowIndex - 1 >= 0)
            {
                matrix[rowIndex - 1][colIndex] = 'B';
            }

            if (colIndex - 1 >= 0)
            {
                matrix[rowIndex][colIndex - 1] = 'B';
            }

            if (rowIndex + 1 < matrix.Length)
            {
                matrix[rowIndex + 1][colIndex] = 'B';
            }

            if (colIndex + 1 < matrix[rowIndex].Length)
            {
                matrix[rowIndex][colIndex + 1] = 'B';
            }
        }
    }
}
