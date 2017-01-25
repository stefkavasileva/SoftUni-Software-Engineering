using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrifonsQuest
{
    static void Main(string[] args)
    {
        long health = long.Parse(Console.ReadLine());
        int[] matrixDimensions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        char[][] matrix = new char[matrixDimensions[0]][];

        FillTheMatrix(matrix);
        int turns = 0;

        for (int col = 0; col < matrixDimensions[1]; col++)
        {
            if (col % 2 == 0)
            {
                int row = 0;

                while (row < matrix.Length)
                {
                    UpdateHealthState(ref health, matrix, ref turns, col, row);
                    if (health <= 0)
                    {
                        Console.WriteLine($"Died at: [{row}, {col}]");
                        return;
                    }

                    row++;
                    turns++;
                }
            }
            else
            {
                int row = matrix.Length - 1;

                while (row >= 0)
                {
                    UpdateHealthState(ref health, matrix, ref turns, col, row);
                    if (health <= 0)
                    {
                        Console.WriteLine($"Died at: [{row}, {col}]");
                        return;
                    }

                    turns++;
                    row--;
                }
            }
        }

        Console.WriteLine("Quest completed!");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Turns: {turns}");

    }

    private static void UpdateHealthState(ref long health, char[][] matrix, ref int turns, int col, int row)
    {
        if (matrix[row][col] == 'F')
        {
            health -= (turns / 2);
        }
        else if (matrix[row][col] == 'H')
        {
            health += (turns / 3);
        }
        else if (matrix[row][col] == 'T')
        {
            turns += 2;
        }
    }

    private static void FillTheMatrix(char[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine().ToCharArray();
        }
    }
}

