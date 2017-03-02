using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextBombardment
{
    static void Main(string[] args)
    {
        char[] text = Console.ReadLine().ToCharArray();
        int cols = int.Parse(Console.ReadLine());
        int[] colToBeBombarded = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = (text.Length / cols) + 1;
        char[][] matrix = new char[rows][];
        int index = 0;

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new char[cols];
            for (int col = 0; col < cols; col++)
            {
                try
                {
                    matrix[row][col] = text[index];
                    index++;
                }
                catch (Exception)
                {
                    matrix[row][col] = ' ';
                }

            }
        }

        bool isBombarded = false;
        for (int i = 0; i < colToBeBombarded.Length; i++)
        {
            int col = colToBeBombarded[i];
            for (int r = 0; r < rows; r++)
            {
                if (matrix[r][col] == ' ' && isBombarded)
                {
                    break;
                }
                else
                {
                    if (matrix[r][col] != ' ')
                    {
                        isBombarded = true;
                    }
                    matrix[r][col] = ' ';
                }

            }

            isBombarded = false;

        }

        foreach (var row in matrix)
        {
            Console.Write(row);
        }
    }
}

