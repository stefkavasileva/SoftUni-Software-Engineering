using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person(string name, int age)
        : this(name, age, new List<BankAccount>())
    {

    }

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = accounts;
    }

    public string Name
    {
        get => this.name;
        protected set => this.name = value;
    }

    public int Age
    {
        get => this.age;
        protected set => this.age = value;
    }

    public List<BankAccount> Accounts
    {
        get => this.accounts;
        protected set => this.accounts = value;
    }

    public double GetBalance()
    {
        return this.Accounts.Sum(x => x.Balance);
    }
}