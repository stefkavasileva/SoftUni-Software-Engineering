using System;

public class Startup
{
    public static void Main()
    {
        var calculator = new PrimitiveCalculator(new AdditionStrategy());

        var input = Console.ReadLine().Split();

        while (!input[0].Equals("End"))
        {
            if (input[0].Equals("mode"))
            {
                calculator.ChangeStrategy(char.Parse(input[1]));
            }
            else
            {
                var firstNum = int.Parse(input[0]);
                var secondNum = int.Parse(input[1]);

                Console.WriteLine(calculator.PerformCalculation(firstNum, secondNum));
            }

            input = Console.ReadLine().Split();
        }
    }
}
