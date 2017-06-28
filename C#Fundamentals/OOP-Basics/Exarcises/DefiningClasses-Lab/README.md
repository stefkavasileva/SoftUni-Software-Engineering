# <p align="center"> Lab:  Defining Classes </p>
Problems for exercises and homework for the [&quot;C# OOP Basics&quot; course @ SoftUni](https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017).

You can check your solutions here: [https://judge.softuni.bg/Contests/674/Defining-Classes-Lab](https://judge.softuni.bg/Contests/674/Defining-Classes-Lab)

# Part I: Defining Classes

## 1.Define Bank Account Class

Create a class named **BankAccount**.

The class should have private fields for:

- id: int
- balance: double

The class should also have public properties for:

- **ID:** **int**
- **Balance:** **double**

You should be able to use the class like this:

```csharp
public static void Main()
{
    BankAccount acc = new BankAccount();
    
    acc.ID = 1;
    acc.Balance = 15;

    Console.WriteLine( $"Account {this.ID}, balance {this.Balance:f2}")
}
```

### Solution

Create a **new class** and ensure **proper naming**

## 2.Methods

Create a class **BankAccount** (you can use class from previous task)

The class should have private fields for:

- id: int
- balance: double

The class should also have properties for:

- **ID:** **int**
- **Balance:** **double**
- **Deposit(Double amount):** **void**
- **Withdraw(Double amount):** **void**

Override the method **ToString()**.

You should be able to use the class like this:

```csharp
public static void Main()
{
    BankAccount acc = new BankAccount();
    
    acc.ID = 1;
    acc.Deposit(15);
    acc.Withdraw(5);

    Console.WriteLine(acc.ToString());
}
```

### Solution

Create a method **Deposit(double amount)**

```csharp
public void Deposit(double amount)
{
    this.balance += amount;
}
```

Create a method **Withdraw(double amount)**

```csharp
public void Withdraw(double amount)
{
    this.balance -= amount;
}
```

Override the method **toString()**

```csharp
public override string ToString()
{
    return $"Account ID{this.ID}, balance {this.Balance:f2}";
}
```

## 3.Test Client

Create a test client that tests your **BankAccount** class.

Support the **following commands** :

- **Create {Id}**
- **Deposit {Id} {Amount}**
- **Withdraw {Id} {Amount}**
- **Print {Id}**
- **End**

If you try to create an account with existing Id, print **&quot;Account already exists&quot;.**

If you try to perform an operation on **non-existing account** with existing Id, print **&quot;** **Account does not exist** &quot;.

If you try to withdraw an amount larger than the balance, print **&quot;** **Insufficient balance** **&quot;**.

The Print command should print **&quot;Account ID{id}, balance {balance}&quot;**. Round the balance to the second digit after the decimal separator.

### Examples

| **Input** | **Output** |
| --- | --- |
| Create 1 <br/> Create 2 <br/> Deposit 1 20 <br/> Withdraw 1 30 <br/> Withdraw 1 10 <br/> Print 1 <br/> End | Account already exists <br/> Insufficient balance <br/> Account ID1, balance 10.00 |
| Create 1 <br/> Deposit 2 20 <br/> Withdraw 2 30 <br/> Print 2 <br/> End | Account does not exist <br/> Account does not exist <br/> Account does not exist |

### Solution

Create a **Dictionary&lt;int, BankAccount&gt;** to store existing accounts

Create the input loop

Check the **type of command** and **execute** accordingly ( **optional:** _you can create a separate method for each command_)

Implement the Create command

Implement the rest of the commands following the same logic

## 4.Define Person Class

Create a **Person** class.

The class should have **private fields** for:

- Name: **string**
- Age: **int**
- Accounts: **List&lt;BankAccount&gt;**

The class should have **constructors** :

- **Person(string name, int age)**
- **Person(string name, int age, List&lt;BankAccount&gt; accounts)**

The class should also have **public methods** for:

- **GetBalance():** **double**

### Solution

Create the class as usual

```csharp
public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;
}
```

Create a constructor with two parameters

```csharp
public Person(string name, int age)
{
    this.Name = name;
    this.Age = age;
    this.Accounts = new List<BankAccount> accounts;
}
```

Create a constructor with three parameters

```csharp
public Person(string name, int age, List<BankAccount> accounts)
{
    this.Name = name;
    this.Age = age;
    this.Accounts = accounts;
}
```

**Optional:** You can take advantage of **constructor chaining**

```csharp
public Person(string name, int age)
     : this(name, age, new List<BankAccount>())
{
    
}
```
