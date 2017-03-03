using System;
using System.Collections.Generic;
using System.Linq;

public class NestedLoops
{
    public static void Main()
    {
        int secretNum = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int sumOfBulls = 0;
        int sumOfCow = 0;
        bool isSecretNums = false;

        string secretNumAsStr = secretNum.ToString();
        int[] secretDigits = new int[4];
        for (int i = 0; i < secretDigits.Length; i++)
        {
            secretDigits[i] = (int)char.GetNumericValue(secretNumAsStr[i]);
        }

        for (int i1 = 1; i1 <= 9; i1++)
        {
            for (int i2 = 1; i2 <= 9; i2++)
            {
                for (int i3 = 1; i3 <= 9; i3++)
                {
                    for (int i4 = 1; i4 <= 9; i4++)
                    {
                        int digit1 = (secretNum / 1000) % 10;
                        int digit2 = (secretNum / 100) % 10;
                        int digit3 = (secretNum / 10) % 10;
                        int digit4 = secretNum % 10;

                        List<int> nums1 = new List<int>() { digit1, digit2, digit3, digit4 };
                        List<int> nums2 = new List<int>() { i1, i2, i3, i4 };

                        if (nums1[0] == nums2[0])
                        {
                            sumOfBulls++;
                            nums1[0] = -1;
                            nums2[0] = -2;
                        }

                        if (nums1[1] == nums2[1])
                        {
                            sumOfBulls++;
                            nums1[1] = -1;
                            nums2[1] = -2;
                        }

                        if (nums1[2] == nums2[2])
                        {
                            sumOfBulls++;
                            nums1[2] = -1;
                            nums2[2] = -2;
                        }

                        if (nums1[3] == nums2[3])
                        {
                            sumOfBulls++;
                            nums1[3] = -1;
                            nums2[3] = -2;
                        }

                        nums1 = nums1.Distinct().ToList();

                        for (int i = 0; i < nums1.Count; i++)
                        {
                            if (nums2.Contains(nums1[i]))
                            {
                                sumOfCow++;
                                nums1.RemoveAt(i);
                                i--;
                            }
                        }

                        if (sumOfCow == cows && sumOfBulls == bulls)
                        {
                            Console.Write("{0} ", i1.ToString() + i2 + i3 + i4);
                            isSecretNums = true;
                        }

                        sumOfCow = 0;
                        sumOfBulls = 0;
                    }
                }
            }
        }

        if (!isSecretNums)
        {
            Console.WriteLine("No");
        }
    }
}