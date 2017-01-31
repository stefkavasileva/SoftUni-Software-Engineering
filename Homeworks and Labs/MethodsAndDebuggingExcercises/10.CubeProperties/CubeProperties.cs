using System;

public class CubeProperties
{
    public static void Main()
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string cubeParameter = Console.ReadLine().ToLower();

        if (cubeParameter.Equals("face"))
        {
            double faceDiagonal = CalcFaceDiagonal(cubeSide);
            PrintCubeParameter(faceDiagonal);
        }
        else if (cubeParameter.Equals("space"))
        {
            double spaceDiagonal = CalcSpaceDiagonal(cubeSide);
            PrintCubeParameter(spaceDiagonal);
        }
        else if (cubeParameter.Equals("volume"))
        {
            double volume = CalcVolume(cubeSide);
            PrintCubeParameter(volume);
        }
        else
        {
            double area = CalcCubeArea(cubeSide);
            PrintCubeParameter(area);
        }
    }

    private static double CalcCubeArea(double cubeSide)
    {
        double area = 6 * (cubeSide * cubeSide);
        return area;
    }

    private static void PrintCubeParameter(double cubeParameter)
    {
        Console.WriteLine($"{cubeParameter:f2}");
    }

    private static double CalcVolume(double cubeSide)
    {
        double volume = cubeSide * cubeSide * cubeSide;
        return volume;
    }

    private static double CalcSpaceDiagonal(double cubeSide)
    {
        double spaceDiagonal = Math.Sqrt(3 * (cubeSide * cubeSide));
        return spaceDiagonal;
    }

    private static double CalcFaceDiagonal(double cubeSide)
    {
        double faceDiagonal = Math.Sqrt(2 * (cubeSide * cubeSide));
        return faceDiagonal;
    }
}
