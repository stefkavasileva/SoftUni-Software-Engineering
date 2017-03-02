using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpiralMatrix
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        string word = Console.ReadLine().ToLower();

        char[][] matrix = new char[size][];
        for (int i = 0; i < size; i++)
        {
            matrix[i] = new char[size];
        }

        int counter = 0;
        int col = -1;
        int row = 0;
        string diraction = "right";
        //fill the matrix

        for (int count = 0; count < (matrix.Length * 2) - 1; count++)
        {
            if (diraction == "right")
            {
                GoRight(word, matrix, ref counter, ref col, row);
                diraction = "down";
            }
            else if (diraction == "down")
            {
                GoDown(word, matrix, ref counter, col, ref row);
                diraction = "left";
            }
            else if (diraction == "left")
            {
                GoLeft(word, matrix, ref counter, ref col, row);
                diraction = "up";
            }
            else if (diraction == "up")
            {
                GoUp(word, matrix, ref counter, col, ref row);
                diraction = "right";
            }
        }

        int weight = 0;
        int maxWeight = int.MinValue;

        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix.Length; c++)
            {
                weight += (matrix[r][c] - 96) * 10;
            }

            if (weight > maxWeight)
            {
                maxWeight = weight;
                row = r;
            }

            weight = 0;
        }

        Console.WriteLine("{0} - {1}", row, maxWeight);
    }

    private static void GoUp(string word, char[][] matrix, ref int counter, int col, ref int row)
    {
        for (int r = row - 1; r >= 0; r--)
        {
            if (matrix[r][col] > 0)
            {
                row = r + 1;
                break;
            }

            if (counter > word.Length - 1)
            {
                counter = 0;
            }
            matrix[r][col] = word[counter];
            counter++;
            row = r;
        }
    }

    private static void GoLeft(string word, char[][] matrix, ref int counter, ref int col, int row)
    {
        for (int c = col - 1; c >= 0; c--)
        {
            if (matrix[row][c] > 0)
            {
                col = c + 1;
                break;
            }

            if (counter > word.Length - 1)
            {
                counter = 0;
            }
            matrix[row][c] = word[counter];
            counter++;
            col = c;
        }
    }

    private static void GoDown(string word, char[][] matrix, ref int counter, int col, ref int row)
    {
        for (int r = row + 1; r < matrix.Length; r++)
        {
            if (matrix[r][col] > 0)
            {
                row = r - 1;
                break;
            }

            if (counter > word.Length - 1)
            {
                counter = 0;
            }
            matrix[r][col] = word[counter];
            counter++;
            row = r;
        }
    }

    private static void GoRight(string word, char[][] matrix, ref int counter, ref int col, int row)
    {
        for (int c = col + 1; c < matrix.Length; c++)
        {
            if (matrix[row][c] > 0)
            {
                col = c - 1;
                break;
            }

            if (counter > word.Length - 1)
            {
                counter = 0;
            }
            matrix[row][c] = word[counter];
            counter++;
            col = c;
        }
    }
}

