using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tetris
{
    static void Main(string[] args)
    {
        int[] matrixInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        char[][] matrix = new char[matrixInfo[0]][];

        for (int row = 0; row < matrixInfo[0]; row++)
        {
            matrix[row] = Console.ReadLine().ToCharArray();
        }

        int[] sumOfElements = new int[7];

        sumOfElements[0] = GetSumOfIElements(matrix, matrixInfo);
        sumOfElements[1] = GetSumOfLElements(matrix, matrixInfo);
        sumOfElements[2] = GetSumOfJElements(matrix, matrixInfo);
        sumOfElements[3] = GetSumOfOElements(matrix, matrixInfo);
        sumOfElements[4] = GetSumOfZElements(matrix, matrixInfo);
        sumOfElements[5] = GetSumOfSElements(matrix, matrixInfo);
        sumOfElements[6] = GetSumOfTElements(matrix, matrixInfo);

        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}",
            sumOfElements[0],
            sumOfElements[1],
            sumOfElements[2],
            sumOfElements[3],
            sumOfElements[4],
            sumOfElements[5],
            sumOfElements[6]);
    }

    private static int GetSumOfTElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                bool isOElement = matrix[row][col] == 'o' &&
                    matrix[row][col + 1] == 'o' &&
                    matrix[row][col + 2] == 'o' &&
                    matrix[row + 1][col + 1] == 'o';

                if (isOElement)
                {
                    sum++;
                }
            }
        }

        return sum;
    }

    private static int GetSumOfSElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                bool isOElement = matrix[row][col + 1] == 'o' &&
                    matrix[row][col + 2] == 'o' &&
                    matrix[row + 1][col] == 'o' &&
                    matrix[row + 1][col + 1] == 'o';

                if (isOElement)
                {
                    sum++;
                }
            }
        }

        return sum;
    }

    private static int GetSumOfZElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                bool isOElement = matrix[row][col] == 'o' &&
                    matrix[row][col + 1] == 'o' &&
                    matrix[row + 1][col + 1] == 'o' &&
                    matrix[row + 1][col + 2] == 'o';

                if (isOElement)
                {
                    sum++;
                }
            }
        }

        return sum;
    }

    private static int GetSumOfOElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                bool isOElement = matrix[row][col] == 'o' &&
                    matrix[row][col + 1] == 'o' &&
                    matrix[row + 1][col] == 'o' &&
                    matrix[row + 1][col + 1] == 'o';

                if (isOElement)
                {
                    sum++;
                }
            }
        }

        return sum;

    }

    private static int GetSumOfJElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 1; col < cols; col++)
            {
                bool isJElement = matrix[row][col] == 'o' &&
                    matrix[row + 1][col] == 'o' &&
                    matrix[row + 2][col] == 'o' &&
                    matrix[row + 2][col - 1] == 'o';

                if (isJElement)
                {
                    sum++;
                }
            }
        }

        return sum;
    }

    private static int GetSumOfLElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                bool isLElement = matrix[row][col] == 'o' &&
                    matrix[row + 1][col] == 'o' &&
                    matrix[row + 2][col] == 'o' &&
                    matrix[row + 2][col + 1] == 'o';

                if (isLElement)
                {
                    sum++;
                }
            }
        }

        return sum;
    }

    private static int GetSumOfIElements(char[][] matrix, int[] matrixInfo)
    {
        int rows = matrixInfo[0];
        int cols = matrixInfo[1];
        int sum = 0;

        for (int row = 0; row < rows - 3; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                bool isIElement = matrix[row][col] == 'o' &&
                    matrix[row + 1][col] == 'o' &&
                    matrix[row + 2][col] == 'o' &&
                    matrix[row + 3][col] == 'o';

                if (isIElement)
                {
                    sum++;
                }
            }
        }

        return sum;
    }


}
}

