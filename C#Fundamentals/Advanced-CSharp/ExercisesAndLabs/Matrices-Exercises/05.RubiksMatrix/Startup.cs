using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RubiksMatrix
{
    public class Startup
    {
        public static void Main()
        {
            var tokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var commandsLength = int.Parse(Console.ReadLine());
            var matrix = new int[tokens[0]][];

            for (int row = 0, counter = 1; row < matrix.Length; row++)
            {
                matrix[row] = new int[tokens[1]];

                for (int col = 0; col < matrix[row].Length; col++, ++counter)
                {
                    matrix[row][col] = counter;
                }
            }

            for (int commandIndex = 0; commandIndex < commandsLength; commandIndex++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(' ');
                var selectedIndex = int.Parse(inputTokens[0]);
                var command = inputTokens[1];
                var rollTimes = int.Parse(inputTokens[2]);

                switch (command)
                {
                    case "up":
                    {
                        var queue = new Queue<int>();

                        for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                        {
                            queue.Enqueue(matrix[rowIndex][selectedIndex]);
                        }

                        for (int i = 0; i < rollTimes % matrix.Length; i++)
                        {
                            var number = queue.Dequeue();
                            queue.Enqueue(number);
                        }

                        for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                        {
                            matrix[rowIndex][selectedIndex] = queue.Dequeue();
                        }

                        break;
                    }
                    case "down":
                    {
                        var queue = new Queue<int>();

                        for (int rowIndex = matrix.Length - 1; rowIndex >= 0; rowIndex--)
                        {
                            queue.Enqueue(matrix[rowIndex][selectedIndex]);
                        }

                        for (int i = 0; i < rollTimes % matrix.Length; i++)
                        {
                            var number = queue.Dequeue();
                            queue.Enqueue(number);
                        }

                        for (int rowIndex = matrix.Length - 1; rowIndex >= 0; rowIndex--)
                        {
                            matrix[rowIndex][selectedIndex] = queue.Dequeue();
                        }

                        break;
                    }
                    case "left":
                    {
                        for (int i = 0; i < rollTimes % matrix[selectedIndex].Length; i++)
                        {
                            var first = matrix[selectedIndex][0];
                            Array.Copy(matrix[selectedIndex], 1, matrix[selectedIndex], 0,
                                matrix[selectedIndex].Length - 1);
                            matrix[selectedIndex][matrix[selectedIndex].Length - 1] = first;
                        }

                        break;
                    }
                    case "right":
                    {
                        for (int i = 0; i < rollTimes % matrix[selectedIndex].Length; i++)
                        {
                            var last = matrix[selectedIndex][matrix[selectedIndex].Length - 1];
                            Array.Copy(matrix[selectedIndex], 0, matrix[selectedIndex], 1,
                                matrix[selectedIndex].Length - 1);
                            matrix[selectedIndex][0] = last;
                        }

                        break;
                    }
                }
            }

            for (int row = 0, previous = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++, ++previous)
                {
                    if (matrix[row][col] - 1 == previous)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int nestedRow = row; nestedRow < matrix.Length; nestedRow++)
                        {
                            var foundColumn = Array.IndexOf(matrix[nestedRow], previous + 1);

                            if (foundColumn >= 0)
                            {
                                matrix[nestedRow][foundColumn] = matrix[row][col];
                                matrix[row][col] = previous + 1;
                                Console.WriteLine($"Swap ({row}, {col}) with ({nestedRow}, {foundColumn})");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}

