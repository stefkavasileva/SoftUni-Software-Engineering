# <p align="center"> OOP Intro - Defining Classes - Lab </p>

# Lab: Defining Classes

Problems for exercises and homework for the [&quot;CSharp DB Advanced&quot; course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

## Part I: Defining Classes

 ### 1.Define Bank Account Class

Create a class named **BankAccount**.

The class should have public properties for:

- **ID:** **int**
- **Balance:** **decimal**

You should be able to use the class like this:

 ```csharp
 public static void Main()
 {
	BankAccount acc = new BankAccount();

	acc.ID = 1;
	acc.Balance = 15;

	Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
 }
 ```

### Solution

Create a **new class** and ensure **proper naming**

![Not fount](/DBFundamentals/Databases-Advanced/images/01.png)

### 2.Methods

Create a class **BankAccount** (you can use class from previous task)

The class should have properties for:

- **ID:** **int**
- **Balance:** **decimal**

And methods for:

- **Deposit(decimal amount):void**
- **Withdraw(decimal amount):void**

You should be able to use the class like this:

```csharp
static void Main()
{
    BankAccount acc = new BankAccount();

    acc.ID = 1;
    acc.Deposit(15);
    acc.Withdraw(5);

    Console.WriteLine($"Account {acc.ID}, balance = {acc.Balance:f2}.");
}
```

### Solution

Create a method **Deposit(decimal amount)**

![Not fount](/DBFundamentals/Databases-Advanced/images/02.png)

Create a method **Withdraw(double amount)**

![Not fount](/DBFundamentals/Databases-Advanced/images/03.png) 

### 3.Test Client

Create a test client that tests your **BankAccount** class.

Support the **following commands** :

- **Create {Id}**
- **Deposit {Id} {Amount}**
- **Withdraw {Id} {Amount}**
- **Print {Id}**
- **End**

If you try to create an account with existing Id, print **&quot;Account already exists&quot;.**

If you try to perform an operation on **non-existing account** with existing Id, print **&quot;** **Account does not exist** **&quot;**.

If you try to withdraw an amount larger than the balance, print **&quot;** **Insufficient balance** **&quot;**.

The Print command should print **&quot;Account ID {id}, balance = {balance}&quot;**. Round the balance to the second digit after the decimal separator.

### Examples

| **Input** | **Output** |
| --- | --- |
|Create 1<br/> Create 2<br/> Deposit 1 20<br/> Withdraw 1 30<br/> Withdraw 1 10<br/> Print 1<br/> End |Account already exists <br/> Insufficient balance <br/> Account ID1, balance 10.00 |
|Account already exists<br/> Insufficient balance<br/> Account ID1, balance 10.00 |Account does not exist</br> Account does not exist</br> Account does not exist|


### Solution

Create a **Dictionary&lt;int, BankAccount&gt;** to store existing accounts

Create the input loop

![Not fount](/DBFundamentals/Databases-Advanced/images/04.png) 

Check the **type of command** and **execute** accordingly ( **optional:** _you can create a separate method for each command_)

Implement the Create command

![Not fount](/DBFundamentals/Databases-Advanced/images/05.png) 

Implement the rest of the commands following the same logic

### 4.Define Person Class

Create a **Person** class.

The class should have **properties** for:

- Name: **string**
- Age: **int**
- Accounts: **List&lt;BankAccount&gt;**

The class should have **constructors** :

- **Person(string name, int age)**
- **Person(string name, int age, List&lt;BankAccount&gt; accounts)**

The class should also have **public methods** for:

- **GetBalance():** **decimal**

### Solution

Create the class as usual

![Not fount](/DBFundamentals/Databases-Advanced/images/06.png)

Create a constructor with two parameters

![Not fount](/DBFundamentals/Databases-Advanced/images/07.png)

Create a constructor with three parameters

![Not fount](/DBFundamentals/Databases-Advanced/images/08.png)

Create method **GetBalance()**

![Not fount](/DBFundamentals/Databases-Advanced/images/09.png)

**Optional:** You can take advantage of **constructor chaining**

![Not fount](/DBFundamentals/Databases-Advanced/images/10.png)