using System;

namespace _07.BasicMath
{    
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                var tokens = inputLine.Split();

                var action = tokens[0];
                var firstNum = double.Parse(tokens[1]);
                var secondNum = double.Parse(tokens[2]);

                if (action.Equals("Sum"))
                {
                    Console.WriteLine($"{MathUtil.Sum(firstNum, secondNum):f2}");
                }
                else if (action.Equals("Subtract"))
                {
                    Console.WriteLine($"{MathUtil.Subtract(firstNum, secondNum):f2}");
                }
                else if (action.Equals("Multiply"))
                {
                    Console.WriteLine($"{MathUtil.Multiply(firstNum, secondNum):f2}");
                }
                else if (action.Equals("Divide"))
                {
                    Console.WriteLine($"{MathUtil.Divide(firstNum, secondNum):f2}");
                }
                else
                {
                    Console.WriteLine($"{MathUtil.Persentage(firstNum, secondNum):f2}");
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
