using System;
using System.Collections.Generic;

public class LongestAlphabeticalWord
{
    public static void Main()
    {
        string word = Console.ReadLine();
        int size = int.Parse(Console.ReadLine());
        if (size == 1)
        {
            Console.WriteLine(word[0]);
            return;
        }

        char[][] matrix = new char[size][];
        int counter = 0;
        for (int row = 0; row < size; row++)
        {
            matrix[row] = new char[size];
            for (int col = 0; col < size; col++)
            {
                if (counter == word.Length)
                {
                    counter = 0;
                }

                matrix[row][col] = word[counter];
                counter++;
            }
        }

        List<string> words = new List<string>();

        string alphabeticalWord = string.Empty;

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix.Length; col++)
            {
                char letter1 = matrix[row][col];

                for (int down = row; down < matrix.Length - 1; down++)
                {
                    char letter2 = matrix[down + 1][col];
                    if (letter1 < letter2)
                    {
                        alphabeticalWord += letter1.ToString();

                        if (down == matrix.Length - 2)
                        {
                            alphabeticalWord += letter2.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                            break;
                        }

                        letter1 = matrix[down + 1][col];
                    }
                    else
                    {
                        if (alphabeticalWord.Length > 0)
                        {
                            alphabeticalWord += letter1.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                        }

                        break;
                    }
                }

                for (int up = row; up > 0; up--)
                {
                    char letter2 = matrix[up - 1][col];

                    if (letter1 < letter2)
                    {
                        alphabeticalWord += letter1.ToString();

                        if (up == 1)
                        {
                            alphabeticalWord += letter2.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                            break;
                        }

                        letter1 = matrix[up - 1][col];
                    }
                    else
                    {
                        if (alphabeticalWord.Length > 0)
                        {
                            alphabeticalWord += letter1.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                        }

                        break;
                    }
                }

                for (int left = col; left > 0; left--)
                {
                    char letter2 = matrix[row][left - 1];

                    if (letter1 < letter2)
                    {
                        alphabeticalWord += letter1.ToString();
                        if (left == 1)
                        {
                            alphabeticalWord += letter2.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                            break;
                        }

                        letter1 = matrix[row][left - 1];
                    }
                    else
                    {
                        if (alphabeticalWord.Length > 0)
                        {
                            alphabeticalWord += letter1.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                        }

                        break;
                    }
                }

                for (int right = col; right < matrix.Length - 1; right++)
                {
                    char letter2 = matrix[row][right + 1];
                    if (letter1 < letter2)
                    {
                        alphabeticalWord += letter1.ToString();

                        if (right == matrix.Length - 2)
                        {
                            alphabeticalWord += letter2.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                            break;
                        }

                        letter1 = matrix[row][right + 1];
                    }
                    else
                    {
                        if (alphabeticalWord.Length > 0)
                        {
                            alphabeticalWord += letter1.ToString();
                            words.Add(alphabeticalWord);
                            alphabeticalWord = string.Empty;
                            letter1 = matrix[row][col];
                        }

                        break;
                    }
                }
            }
        }

        words.Sort();
        int maxLent = int.MinValue;
        string result = string.Empty;
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Length > maxLent)
            {
                maxLent = words[i].Length;
                result = words[i];
            }
        }

        Console.WriteLine(result);
    }
}
