using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool isSpesialNum = true;

        for (int i1 = 1; i1 <=9 ; i1++)
        {
            for (int i2 = 1; i2 <= 9; i2++)
            {
                for (int i3 = 1; i3 <= 9; i3++)
                {
                    for (int i4 = 1; i4 <= 9; i4++)
                    {
                        string number = i1.ToString() + i2 + i3 + i4;

                        for (int i = 0; i < number.Length; i++)
                        {
                            int curentNum = (int)char.GetNumericValue(number[i]);
                            if (n%curentNum==0)
                            {
                                isSpesialNum = true;
                                continue;
                            }
                            else
                            {
                                isSpesialNum = false;
                                break;
                            }
                        }

                        if (isSpesialNum)
                        {
                            Console.Write(number+" ");
                        }
                    }
                }
            }
        }

        Console.WriteLine();
    }
}

