using System;

public class ChessQueens
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        char[] letters = new char[n];

        for (int i = 0; i < n; i++)
        {
            letters[i] = Convert.ToChar(i + 97);
        }

        int counter = 0;

        for (int x1 = 0; x1 < n; x1++)
        {
            for (int y1 = 0; y1 < n; y1++)
            {
                for (int x2 = 0; x2 < n; x2++)
                {
                    for (int y2 = 0; y2 < n; y2++)
                    {
                        if ((x1 == x2 && Math.Abs(y1 - y2) == distance + 1) ||
                            (y1 == y2 && Math.Abs(x1 - x2) == distance + 1) ||
                            (Math.Abs(x1 - x2) == distance + 1 && Math.Abs(y1 - y2) == distance + 1))
                        {
                            Console.WriteLine(letters[x1].ToString() + (y1 + 1) + " - " + letters[x2] + (y2 + 1));
                            counter++;
                        }

                    }
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No valid positions");
        }
    }
}