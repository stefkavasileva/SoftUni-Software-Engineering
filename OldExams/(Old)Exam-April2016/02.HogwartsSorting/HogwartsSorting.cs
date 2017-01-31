using System;
using System.Collections.Generic;

public class HogwartsSorting
{
    public static void Main()
    {
        int numsOfStudents = int.Parse(Console.ReadLine());

        List<string> students = new List<string>();
        int studenstInGri = 0;
        int studenstInSly = 0;
        int studenstInRav = 0;
        int studenstInHuff = 0;

        for (int student = 0; student < numsOfStudents; student++)
        {
            string studentName = Console.ReadLine();

            int sumOfLetters = 0;
            int index = studentName.IndexOf(' ') + 1;
            string initialsLetters = studentName[0].ToString() + studentName[index];

            for (int letter = 0; letter < studentName.Length; letter++)
            {
                sumOfLetters += studentName[letter];
            }

            sumOfLetters -= 32;

            if (sumOfLetters % 4 == 0)
            {
                string result = "Gryffindor " + sumOfLetters + initialsLetters;
                students.Add(result);
                studenstInGri++;
            }
            else if (sumOfLetters % 4 == 1)
            {
                string result = "Slytherin " + sumOfLetters + initialsLetters;
                students.Add(result);
                studenstInSly++;
            }
            else if (sumOfLetters % 4 == 2)
            {
                string result = "Ravenclaw " + sumOfLetters + initialsLetters;
                students.Add(result);
                studenstInRav++;
            }
            else if (sumOfLetters % 4 == 3)
            {
                string result = "Hufflepuff " + sumOfLetters + initialsLetters;
                students.Add(result);
                studenstInHuff++;
            }
        }

        foreach (var s in students)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        Console.WriteLine("Gryffindor: {0}", studenstInGri);
        Console.WriteLine("Slytherin: {0}", studenstInSly);
        Console.WriteLine("Ravenclaw: {0}", studenstInRav);
        Console.WriteLine("Hufflepuff: {0}", studenstInHuff);
    }
}
