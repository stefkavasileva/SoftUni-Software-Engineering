using System;

public class Calculator
{
    public static void Main()
    {
        var firstOperand = int.Parse(Console.ReadLine());
        var @operator = Console.ReadLine();
        var secondOperand = int.Parse(Console.ReadLine());

        switch (@operator)
        {
            case "+":
                Console.WriteLine($"{firstOperand} {@operator} {secondOperand} = {firstOperand + secondOperand}");
                break;
            case "-":
                Console.WriteLine($"{firstOperand} {@operator} {secondOperand} = {firstOperand - secondOperand}");
                break;
            case "*":
                Console.WriteLine($"{firstOperand} {@operator} {secondOperand} = {firstOperand * secondOperand}");
                break;
            case "/":
                Console.WriteLine($"{firstOperand} {@operator} {secondOperand} = {firstOperand / secondOperand}");
                break;
            default:
                break;
        }
    }
}