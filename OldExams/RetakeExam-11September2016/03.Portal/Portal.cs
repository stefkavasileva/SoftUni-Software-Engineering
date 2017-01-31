using System;
using System.Collections.Generic;
using System.Linq;

public class Portal
{
    public static void Main()
    {
        ////50/100
        int size = int.Parse(Console.ReadLine());
        char[][] matrix = new char[size][];
        FillTheMatrix(matrix, size);

        int[] startPosition = GetStartPosition(matrix);

        string diraction = Console.ReadLine();

        int row = startPosition[0];
        int col = startPosition[1];
        int turns = 0;

        for (int i = 0; i < diraction.Length; i++)
        {
            turns++;
            if (diraction[i].Equals('D'))
            {
                row++;
                if (row >= matrix.Length)
                {
                    row = 0;
                }

                if (matrix[row][col] == 'X')
                {
                    while (matrix[row][col] == 'X')
                    {
                        row++;
                        if (row >= matrix.Length)
                        {
                            row = 0;
                        }
                    }
                }
            }
            else if (diraction[i].Equals('U'))
            {
                row--;
                if (row == -1)
                {
                    row = matrix.Length - 1;
                }

                if (matrix[row][col] == 'X')
                {
                    while (matrix[row][col] == 'X')
                    {
                        row--;
                        if (row == -1)
                        {
                            row = matrix.Length - 1;
                        }
                    }
                }
            }
            else if (diraction[i].Equals('L'))
            {
                col--;
                if (col == -1)
                {
                    col = matrix[row].Length - 1;
                }

                if (matrix[row][col] == 'X')
                {
                    while (matrix[row][col] == 'X')
                    {
                        col--;
                        if (col == -1)
                        {
                            col = matrix[row].Length - 1;
                        }
                    }
                }         
            }
            else
            {
                col++;
                if (col >= matrix[row].Length)
                {
                    col = 0;
                }

                if (matrix[row][col] == 'X')
                {
                    while (matrix[row][col] == 'X')
                    {
                        col++;
                        if (col >= matrix[row].Length)
                        {
                            col = 0;
                        }
                    }
                }
            }

            if (matrix[row][col].Equals('E'))
            {
                Console.WriteLine($"Experiment successful. {turns} turns required.");
                return;
            }
        }

        Console.WriteLine($"Robot stuck at {row} {col}. Experiment failed.");
    }

    private static int[] GetStartPosition(char[][] matrix)
    {
        int[] position = new int[2] { 0, 0 };
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix.Length; col++)
            {
                if (matrix[row][col] == 'S')
                {
                    position[0] = row;
                    position[1] = col;
                    return position;
                }
            }
        }

        return position;
    }

    private static void FillTheMatrix(char[][] matrix, int size)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            List<char> colsElements = Console.ReadLine().ToCharArray().ToList();

            while (colsElements.Count < size)
            {
                colsElements.Add('X');
            }

            matrix[row] = colsElements.ToArray();
        }
    }
}
