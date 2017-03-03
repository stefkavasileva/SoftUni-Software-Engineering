using System;

public class DailyCalorieIntake
{
    public static void Main()
    {
        int weightLbs = int.Parse(Console.ReadLine());
        int hightInInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutPerWeek = int.Parse(Console.ReadLine());

        double heightInCm = hightInInches * 2.54;
        double weightToKg = weightLbs / 2.2;

        double bMR = 0.0;

        if (gender.Equals('m'))
        {
            bMR = 66.5 + (13.75 * weightToKg) + (5.003 * heightInCm) - (6.755 * age);
        }
        else
        {
            bMR = 655 + (9.563 * weightToKg) + (1.850 * heightInCm) - (4.676 * age);
        }

        double dCI = 0.0;

        if (workoutPerWeek <= 0)
        {
            dCI = bMR * 1.2;
        }
        else if (workoutPerWeek >= 1 && workoutPerWeek <= 3)
        {
            dCI = bMR * 1.375;
        }
        else if (workoutPerWeek >= 4 && workoutPerWeek <= 6)
        {
            dCI = bMR * 1.55;
        }
        else if (workoutPerWeek >= 7 && workoutPerWeek <= 9)
        {
            dCI = bMR * 1.725;
        }
        else
        {
            dCI = bMR * 1.9;
        }

        Console.WriteLine(Math.Floor(dCI));
    }
}
