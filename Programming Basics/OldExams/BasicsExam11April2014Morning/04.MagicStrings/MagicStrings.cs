using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicStrings
{
    static void Main(string[] args)
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = new char[] { 's', 'n', 'k', 'p' };
        List<string> megicStrings = new List<string>();

        for (int i1 = 0; i1 < 4; i1++)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    for (int i4 = 0; i4 < 4; i4++)
                    {
                        for (int i5 = 0; i5 < 4; i5++)
                        {
                            for (int i6 = 0; i6 < 4; i6++)
                            {
                                for (int i7 = 0; i7 < 4; i7++)
                                {
                                    for (int i8 = 0; i8 < 4; i8++)
                                    {
                                        int sum1 = CalcSum(letters[i1]) + CalcSum(letters[i2]) + CalcSum(letters[i3]) + CalcSum(letters[i4]);
                                        int sum2 = CalcSum(letters[i5]) + CalcSum(letters[i6]) + CalcSum(letters[i7]) + CalcSum(letters[i8]);
                                        if (Math.Abs(sum1 - sum2) == diff)
                                        {
                                            megicStrings.Add(letters[i1].ToString() + letters[i2] + letters[i3] +
                                                 letters[i4] + letters[i5] + letters[i6]
                                                 + letters[i7] + letters[i8]);

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (megicStrings.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            megicStrings.Sort();
            foreach (var s in megicStrings)
            {
                Console.WriteLine(s);
            }
        }
    }

    private static int CalcSum(char v)
    {
        int num = 0;
        switch (v)
        {
            case 's':
                num = 3;
                break;
            case 'n':
                num = 4;
                break;
            case 'k':
                num = 1;
                break;
            default:
                num = 5;
                break;
        }
        return num;
    }
}

