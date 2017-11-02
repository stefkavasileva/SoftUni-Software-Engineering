public class BankAccount
{
    private int id;
    private double balance;

    public int ID
    {
        get => this.id;
        set => this.id = value;
    }

    public double Balance
    {
        get => this.balance;
        set => this.balance = value;
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.ID}, balance {this.Balance:f2}";
    }
}