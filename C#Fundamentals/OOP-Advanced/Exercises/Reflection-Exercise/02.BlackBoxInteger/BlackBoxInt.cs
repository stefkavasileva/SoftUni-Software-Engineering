class BlackBoxInt
{
    private int innerValue;

    private BlackBoxInt()
    {
        this.innerValue = 0;
    }

    private void Add(int inputValue)
    {
        this.innerValue += inputValue;
    }

    private void Subtract(int inputValue)
    {
        this.innerValue -= inputValue;
    }

    private void Multiply(int inputValue)
    {
        this.innerValue *= inputValue;
    }

    private void Divide(int inputValue)
    {
        this.innerValue /= inputValue;
    }

    private void LeftShift(int shiftsCount)
    {
        this.innerValue <<= shiftsCount;
    }

    private void RightShift(int shiftsCount)
    {
        this.innerValue >>= shiftsCount;
    }
}
