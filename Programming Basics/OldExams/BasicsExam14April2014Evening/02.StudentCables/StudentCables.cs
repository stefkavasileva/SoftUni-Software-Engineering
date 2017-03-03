using System;

public class StudentCables
{
    public static void Main()
    {
        int numOfCables = int.Parse(Console.ReadLine());

        int totalLenght = 0;
        int counter = 0;
        for (int i = 0; i < numOfCables; i++)
        {
            int lenght = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine().ToLower();
            if (measure.Equals("meters"))
            {
                lenght *= 100;
                totalLenght += lenght;
                counter++;
            }
            else if (measure.Equals("centimeters") && lenght >= 20)
            {
                totalLenght += lenght;
                counter++;
            }

        }

        totalLenght -= 3 * (counter - 1);
        int studentsCables = totalLenght / 504;
        int remainder = totalLenght % 504;

        Console.WriteLine(studentsCables);
        Console.WriteLine(remainder);
    }
}
