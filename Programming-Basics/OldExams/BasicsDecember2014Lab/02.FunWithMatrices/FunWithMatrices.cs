using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FunWithMatrices
{
    static void Main(string[] args)
    {
        double startValue = double.Parse(Console.ReadLine());
        double stepNum = double.Parse(Console.ReadLine());
        // fill the matrix
        double[][] matrix = new double[4][];
        double previousNum = 0.0;
        for (int row = 0; row < 4; row++)
        {
            matrix[row] = new double[4];
            for (int col = 0; col < 4; col++)
            {
                if (row == 0 && col == 0)
                {
                    matrix[row][col] = startValue;
                }
                else
                {
                    matrix[row][col] = previousNum + stepNum;
                }
                previousNum = matrix[row][col];
            }
        }

        //operation with nums in matrix

        string[] input = Console.ReadLine().Split();

        while (input[0] != "Game")
        {
            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);
            string operation = input[2];
            double num = double.Parse(input[3]);

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix.Length; c++)
                {
                    if (r == row && c == col)
                    {
                        if (operation == "multiply")
                        {
                            matrix[row][col] = matrix[row][col] * num;
                        }
                        else if (operation == "sum")
                        {
                            matrix[row][col] = matrix[row][col] + num;
                        }
                        else if (operation == "power")
                        {
                            matrix[row][col] = Math.Pow(matrix[row][col], num);
                        }
                    }
                }
            }

            input = Console.ReadLine().Split();
        }

        // bigest sum

        double sumInRow = 0.0;
        double sumInCol = 0.0;
        double sumInLeftDiag = 0.0;
        double sumInRightDiag = 0.0;

        double maxSum = double.MinValue;
        string index = string.Empty;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int col = 0; col < matrix.Length; col++)
            {
                if (i == col)
                {
                    sumInLeftDiag += matrix[i][col];
                }
                else if (i + col == matrix.Length - 1)
                {
                    sumInRightDiag += matrix[i][col];
                }
            }

            sumInRow = matrix[i][0] + matrix[i][1] + matrix[i][2] + matrix[i][3];
            sumInCol = matrix[0][i] + matrix[1][i] + matrix[2][i] + matrix[3][i];
            if (sumInRow >= sumInCol && sumInRow > maxSum)
            {
                maxSum = sumInRow;
                index = "ROW" + "[" + i + "]";
            }
            else if (sumInCol > sumInRow && sumInCol > maxSum)
            {
                maxSum = sumInCol;
                index = "COLUMN" + "[" + i + "]";
            }
        }
        if (sumInLeftDiag >= sumInRightDiag && sumInLeftDiag > maxSum)
        {
            maxSum = sumInLeftDiag;
            index = "LEFT-DIAGONAL";
        }
        else if (sumInRightDiag > sumInLeftDiag && sumInRightDiag > maxSum)
        {
            maxSum = sumInRightDiag;
            index = "RIGHT-DIAGONAL";
        }


        Console.WriteLine("{0} = {1:f2}", index, maxSum);

    }
}


