# <p align="center"> OOP Intro - Defining Classes - Exercises </p>

##  Exercises : Defining Classes

This document defines the **exercise assignments** for the [&quot;CSharp DB Advanced&quot; course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

## Problem 1.Define a class Person

Define a class **Person** with **public** properties for **Name** and **Age**.

### Note

Add the following code to your main method and submit it to Judge.

```csharp
static void Main(string[] args)
{
    Type personType = typeof(Person);
    PropertyInfo[] properties = personType.GetProperties
        (BindingFlags.Public | BindingFlags.Instance);
    Console.WriteLine(properties.Length);
}
```

If you defined the class correctly, the test should pass.

### Bonus\*

Try to create a few objects of type Person:

| **Name** | **Age** |
| --- | --- |
| Pesho | 20 |
| Gosho | 18 |
| Stamat | 43 |

Use both the inline initialization and the default constructor. Your fields should be **public** , otherwise you won&#39;t see them.

## Problem 2.Creating Constructors

Add 3 constructors to the **Person** class from the last task, use constructor chaining to reuse code:

1. The first should take **no arguments** and produce a person with **name**&quot; **No name**&quot; and **age** = **1**.
2. The second should accept only **an**** integer ****number** for the **age** and produce a person with **name**&quot; **No name**&quot; and **age** equal to the passed parameter.
3. The third one should accept a **string** for the name and an **integer** for the age and should produce a person with the given **name** and **age**.

Add the following code to your main method and submit it to Judge.

```csharp
Type personType = typeof(Person);
ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
bool swapped = false;
if (nameAgeCtor == null)
{
    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
    swapped = true;
}

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) :(Person)nameAgeCtor.Invoke(new object[] { name, age });

Console.WriteLine("{0} {1}", basePerson.Name, basePerson.Age);
Console.WriteLine("{0} {1}", personWithAge.Name, personWithAge.Age);
Console.WriteLine("{0} {1}", personWithAgeAndName.Name, personWithAgeAndName.Age);
```

If you defined the constructors correctly, the test should pass.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho <br/> 20 | No name 1 <br/> No name 20 <br/> Pesho 20 |
| Gosho <br/> 18 | No name 1 <br/> No name 18 <br/> Gosho 18 |
| Stamat <br/> 43 | No name 1 <br/> No name 43 <br/> Stamat 43 |

## Problem 3.Opinion Poll

Using the Person class, write a program that reads from the console **N** lines of personal information and then prints all people whose **age** is **more than 30** years, **sorted in alphabetical order**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 <br/> Pesho 12 <br/> Stamat 31 <br/> Ivan 48 | Ivan - 48 <br/> Stamat - 31 |
| 5 <br/> Nikolai 33 <br/> Yordan 88 <br/> Tosho 22 <br/> Lyubo 44 <br/> Stanislav 11 | Lyubo - 44 <br/> Nikolai - 33 <br/> Yordan - 88 |

## Problem 4.Speed Racing

Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class **Car** that keeps track of a car&#39;s **Model, fuel amount, fuel consumption for 1 kilometer** and **distance traveled**. A Car&#39;s Model is **unique** - there will never be 2 cars with the same model.

 On the first line of the input you will receive a number **N** – the number of cars you need to track, on each of the next **N** lines you will receive information for a car in the following format &quot;&lt; **Model&gt; &lt;FuelAmount&gt; &lt;FuelConsumptionFor1km&gt;**&quot;, all **cars start at 0 kilometers traveled**.

After the **N** lines, until the command &quot; **End**&quot; is received, you will receive a command in the following format &quot; **Drive &lt;CarModel&gt;  &lt;amountOfKm&gt;**&quot;. Implement a method in the **Car** class to calculate whether a car can move that distance. If it can the car&#39;s **fuel amount** should be **reduced** by the amount of used fuel and its **distance traveled** should be increased by the amount of kilometers traveled, otherwise the car should not move (Its fuel amount and distance traveled should stay the same) and you should print on the console &quot; **Insufficient fuel for the**  **drive**&quot;. After the &quot; **End**&quot; command is received, print **each car** and its **current fuel amount** and **distance traveled** in the format &quot; **&lt;Model&gt; &lt;fuelAmount&gt;  &lt;distanceTraveled&gt;**&quot;, where the fuel amount should be printed to **two decimal places** after the separator.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 <br/> AudiA4 23 0.3 <br/> BMW-M2 45 0.42 <br/> Drive BMW-M2 56 <br/> Drive AudiA4 5 <br/> Drive AudiA4 13 <br/> End | AudiA4 17.60 18 <br/> BMW-M2 21.48 56 |
| 2 <br/> AudiA4 23 0.3 <br/> BMW-M2 45 0.42 <br/> Drive BMW-M2 56 <br/> Drive AudiA4 5 <br/> Drive AudiA4 13 <br/> End | AudiA4 17.60 18 <br/> BMW-M2 21.48 56 |
| 3 <br/> AudiA4 18 0.34 <br/> BMW-M2 33 0.41 <br/> Ferrari-488Spider 50 0.47 <br/> Drive Ferrari-488Spider 97 <br/> Drive Ferrari-488Spider 35 <br/> Drive AudiA4 85 <br/> Drive AudiA4 50 <br/> End | Insufficient fuel for the drive <br/> Insufficient fuel for the ride <br/> AudiA4 1.00 50 <br/> BMW-M2 33.00 0 <br/> Ferrari-488Spider 4.41 97 |

## Problem 5.Company Roster

Define a class **Employee** that holds the following information: **name, salary, position, department, email** and **age**. The **name, salary** , **position** and **department** are **mandatory** while the rest are **optional**.

Your task is to write a program which takes **N** lines of employees from the console and calculates the department with the highest average salary and prints for each employee in that department his **name, salary, email and age** – **sorted by salary in descending order**. If an employee **doesn&#39;t have** an **email** – in place of that field you should print &quot; **n/a**&quot; instead, if he doesn&#39;t have an **age** – print &quot; **-1**&quot; instead. The **salary** should be printed to **two decimal places** after the seperator.

### Examples

| **Input** | **Output** |
| --- | --- |
|4<br/> Pesho 120.00 Dev Development pesho@abv.bg 28<br/> Toncho 333.33 Manager Marketing 33<br/> Ivan 840.20 ProjectLeader Development ivan@ivan.com<br/> Gosho 0.20 Freeloader Nowhere 18 |4<br/> Pesho 120.00 Dev Development pesho@abv.bg 28<br/> Toncho 333.33 Manager Marketing 33<br/> Ivan 840.20 ProjectLeader Development ivan@ivan.com<br/> Gosho 0.20 Freeloader Nowhere 18 |
|6<br/> Stanimir 496.37 Temp Coding stancho@yahoo.com<br/> Yovcho 610.13 Manager Sales<br/> Toshko 609.99 Manager Sales toshko@abv.bg 44<br/> Venci 0.02 Director BeerDrinking beer@beer.br 23<br/> Andrei 700.00 Director Coding<br/> Popeye 13.3333 Sailor SpinachGroup popeye@pop.ey |Highest Average Salary: Sales<br/> Yovcho 610.13 n/a -1<br/> Toshko 609.99 toshko@abv.bg 44|














![Not fount](/DBFundamentals/Databases-Advanced/images/10.png)