using System;
using System.Collections.Generic;
using System.Linq;

public class MatrixOperator
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();

        for (int row = 0; row < rows; row++) 
        {
            matrix.Add(new List<int>());
            matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        string comand = Console.ReadLine();
        while (!comand.Equals("end"))
        {
            string[] comandArgs = comand.Split().ToArray();
            string comandName = comandArgs[0];
            if (comandName.Equals("remove"))
            {
                string type = comandArgs[1];
                bool isRow = comandArgs[2].Equals("row");
                int index = int.Parse(comandArgs[3]);

                RemoveNums(matrix, isRow, index, type);
            }
            else if (comandName.Equals("swap"))
            {
                int firstIndexOfRow = int.Parse(comandArgs[1]);
                int secondIndexOfRow = int.Parse(comandArgs[2]);
                List<int> firstRow = matrix[firstIndexOfRow].ToList();
                List<int> secondRow = matrix[secondIndexOfRow].ToList();
                matrix[firstIndexOfRow] = secondRow;
                matrix[secondIndexOfRow] = firstRow;            
            }
            else if (comandName.Equals("insert"))
            {
                int row = int.Parse(comandArgs[1]);
                int element = int.Parse(comandArgs[2]);
                matrix[row].Insert(0, element);
            }

            comand = Console.ReadLine();
        }

        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }

    private static void RemoveNums(List<List<int>> matrix, bool isRow, int index, string type)
    {
        if (isRow)
        {
            for (int col = 0; col < matrix[index].Count; col++)
            {
                if (matrix[index].Count <= col)
                {
                    continue;
                }

                if ((type.Equals("positive") && matrix[index][col] >= 0) ||
                    (type.Equals("negative") && matrix[index][col] < 0) ||
                    (type.Equals("odd") && matrix[index][col] % 2 != 0) ||
                    (type.Equals("even") && matrix[index][col] % 2 == 0))
                {
                    matrix[index].RemoveAt(col);
                    col--;
                }
            }
        }
        else
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                if (matrix[row].Count <= index)
                {
                    continue;
                }

                if ((type.Equals("positive") && matrix[row][index] >= 0) ||
                    (type.Equals("negative") && matrix[row][index] < 0) ||
                    (type.Equals("odd") && matrix[row][index] % 2 != 0) ||
                    (type.Equals("even") && matrix[row][index] % 2 == 0))
                {
                    matrix[row].RemoveAt(index);
                }
            }
        }
    }
}
