using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PersonalTitles
{
    static void Main(string[] args)
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

