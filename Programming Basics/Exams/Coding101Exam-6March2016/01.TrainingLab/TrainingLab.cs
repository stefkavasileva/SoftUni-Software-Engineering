using System;

public class TrainingLab
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());

        int site = (int)(((hight * 100) - 100) / 70.0);
        int rows = (int)((width * 100) / 120);

        int result = (site * rows) - 3;

        Console.WriteLine(result);
    }
}

