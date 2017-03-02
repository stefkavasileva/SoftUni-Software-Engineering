using System;

public class PersonalTitles
{
    public static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());

        if (age < 16)
        {
            if (gender == 'm')
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
        else
        {
            if (gender == 'm')
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
