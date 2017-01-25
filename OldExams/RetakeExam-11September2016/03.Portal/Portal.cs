using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Portal
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        char[][] matrix = new char[size][];
        FillTheMatrix(matrix, size);

        int[] startPosition = GetStartPosition(matrix);

        string diraction = Console.ReadLine();

        int row = startPosition[0];
        int col = startPosition[1];
        int turns = 0;
        for (;;)
        {

            if (matrix[row][col] == 'E')
            {
                Console.WriteLine($"Experiment successful. {turns} turns required.");
                return;
            }

            if (turns.Equals(diraction.Length))
            {
                Console.WriteLine("Robot stuck at {0} {1}. Experiment failed.", row, col);
                return;
            }

            if (diraction[turns].Equals('D'))
            {
                while (true)
                {
                    row++;
                    if (row > size - 1)
                    {
                        row = 0;
                    }

                    if (matrix[row][col] == 'E')
                    {
                        turns++;
                        Console.WriteLine($"Experiment successful. {turns} turns required.");
                        return;
                    }

                    if (matrix[row][col] == 'X')
                    {

                        continue;
                    }

                    break;
                }
            }
            else if (diraction[turns].Equals('U'))
            {
                while (true)
                {
                    row--;
                    if (row < 0)
                    {
                        row = size - 1;
                    }

                    if (matrix[row][col] == 'E')
                    {
                        turns++;
                        Console.WriteLine($"Experiment successful. {turns} turns required.");
                        return;
                    }
                    if (matrix[row][col] == 'X')
                    {
                        continue;
                    }
                    break;
                }


            }
            else if (diraction[turns].Equals('R'))
            {
                while (true)
                {
                    col++;
                    if (col > size - 1)
                    {
                        col = 0;
                    }

                    if (matrix[row][col] == 'E')
                    {
                        turns++;
                        Console.WriteLine($"Experiment successful. {turns} turns required.");
                        return;
                    }

                    if (matrix[row][col] == 'X')
                    {
                        continue;
                    }
                    break;

                }


            }
            else if (diraction[turns].Equals('L'))
            {
                while (true)
                {
                    col--;
                    if (col < 0)
                    {
                        col = size - 1;
                    }

                    if (matrix[row][col] == 'E')
                    {
                        turns++;
                        Console.WriteLine($"Experiment successful. {turns} turns required.");
                        return;
                    }

                    if (matrix[row][col] == 'X')
                    {
                        continue;
                    }
                    break;
                }


            }

            turns++;

        }


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

