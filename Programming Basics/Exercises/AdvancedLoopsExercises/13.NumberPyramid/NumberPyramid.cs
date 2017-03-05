using System;

public class NumberPyramid
{
    public static void Main()
    {
        int endNum = int.Parse(Console.ReadLine());
        int counter = 1;

        for (int row = 1; row <= endNum; row++)
        {
            for (int col = 0; col < row; col++)
            {
                if (counter > endNum)
                {
                    return;
                }
                Console.Write(counter + " ");
                counter++;
            }

            Console.WriteLine();
        }
    }
}
