using System;
using System.Linq;
using System.Text;

namespace _02.Monopoly
{
    public class Startup
    {
        public static long playerMoney = 50;
        public static long hotelCount = 0;
        public static long turns = 0;
        public static void Main()
        {
            var matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = matrixSizes[0];

            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            var messages = new StringBuilder();
            for (int row = 0; row < matrix.Length; row++)
            {
                if (row % 2 == 0)
                {
                    messages.Append(GoRight(matrix, row));
                    continue;
                }

                messages.Append(GoLeft(matrix, row));
            }

            Console.Write(messages);
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {playerMoney}");
        }

        private static string GoLeft(char[][] matrix, int row)
        {
            var messages = new StringBuilder();
            for (int col = matrix[row].Length - 1; col >= 0; col--)
            {
                GoAhead(matrix, row, messages, col);
                turns++;
                playerMoney += 10 * hotelCount;
            }

            return messages.ToString();
        }

        private static string GoRight(char[][] matrix, int row)
        {
            var messages = new StringBuilder();

            for (int col = 0; col < matrix[row].Length; col++)
            {
                GoAhead(matrix, row, messages, col);
                turns++;
                playerMoney += 10 * hotelCount;
            }

            return messages.ToString();
        }

        private static void GoAhead(char[][] matrix, int row, StringBuilder messages, int col)
        {
            if (matrix[row][col].Equals('H'))
            {
                messages.AppendLine($"Bought a hotel for {playerMoney}. Total hotels: {hotelCount + 1}.");
                playerMoney = 0;
                hotelCount += 1;
            }
            else if (matrix[row][col].Equals('J'))
            {
                messages.AppendLine($"Gone to jail at turn {turns}.");
                turns += 2;
                playerMoney += 2 * (10 * hotelCount);
            }
            else if (matrix[row][col].Equals('S'))
            {
                var money = (col + 1) * (row + 1);
                var spendMoney = playerMoney - money;
                if (spendMoney < 0)
                {
                    spendMoney = playerMoney;
                    playerMoney = 0;
                }
                else
                {
                    spendMoney = (col + 1) * (row + 1);
                    playerMoney -= spendMoney;
                }

                messages.AppendLine($"Spent {spendMoney} money at the shop.");
            }
            
        }
    }
}
