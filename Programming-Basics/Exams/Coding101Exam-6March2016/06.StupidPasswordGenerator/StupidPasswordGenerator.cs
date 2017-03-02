using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StupidPasswordGenerator
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        List<string> stupidPasswards = new List<string>();

        for (int i1 = 1; i1 <= n; i1++)
        {
            for (int i2 = 1; i2 <= n; i2++)
            {
                for (int i3 = 97; i3 < 97 + l; i3++)
                {
                    for (int i4 = 97; i4 < 97 + l; i4++)
                    {
                        for (int i5 = 0; i5 <= n; i5++)
                        {
                            if (i5 > i1 && i5 > i2)
                            {
                                stupidPasswards.Add(i1.ToString() + i2 + (char)i3 + (char)i4 + i5);
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", stupidPasswards));
    }
}

