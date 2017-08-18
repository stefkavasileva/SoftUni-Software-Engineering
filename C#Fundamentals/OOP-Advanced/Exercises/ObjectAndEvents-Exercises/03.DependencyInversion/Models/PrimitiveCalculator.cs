using System.Collections.Generic;

public class PrimitiveCalculator
{
    private readonly IDictionary<char, IStrategy> possibleStrategies = new Dictionary<char, IStrategy>
    {
        { '+', new AdditionStrategy() },
        { '-', new SubtractionStrategy() },
        { '*', new MultiplicationStrategy() },
        { '/', new DivisionStrategy() }
    };

    private IStrategy strategy;

    public PrimitiveCalculator(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ChangeStrategy(char @operator)
    {
        this.strategy = this.possibleStrategies[@operator];
    }

    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        return this.strategy.Calculate(firstOperand, secondOperand);
    }
}
