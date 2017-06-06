using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SecondNature
{
    public class SecondNature
    {
        public static void Main()
        {
            //80/100
            var flowers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            var buckets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var secondNatureFlowers = new Queue<int>();

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                var currentBuket = buckets.Pop();
                var currentFlower = flowers.Pop();
                
                if (currentFlower > currentBuket)
                {
                    currentFlower -= currentBuket;
                    while (buckets.Any())
                    {
                        currentBuket = buckets.Pop();
                        currentFlower -= currentBuket;

                        if (currentFlower <= 0)
                        {
                            buckets.Push(Math.Abs(currentFlower));
                            break;
                        }
                    }

                    if (currentFlower > 0)
                    {
                        flowers.Push(currentFlower);
                    }
                }
                else if (currentFlower == currentBuket)
                {
                    secondNatureFlowers.Enqueue(currentFlower);
                }
                else
                {
                    var remainder = currentBuket - currentFlower;

                    if (buckets.Count > 0)
                    {
                        buckets.Push(buckets.Pop() + remainder);
                    }
                    else
                    {
                        buckets.Push(remainder);
                    }
                }
            }

            if (flowers.Any())
            {
                Console.WriteLine(string.Join(" ", flowers));
            }
            else
            {
                Console.WriteLine(string.Join(" ", buckets));
            }

            if (secondNatureFlowers.Any())
            {
                Console.WriteLine(string.Join(" ", secondNatureFlowers));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
