# <p align="center">Exercises: Methods </p>

This document defines the exercises for [&quot;C# OOP Basics&quot; course @ Software University](https://softuni.bg/trainings/1375/csharp-basics-oop-june-2016). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/).

## Problem 1. Method Says Hello!

You will receive the **person name as an input**. Write a class **Person** that only has a name and a **method**. The method should describe a greeting by the person, returning a string &quot;&lt;Person name&gt; says Hello!&quot;. Print the result of the method call.

#### Note

Add the following code to your main method and submit it to Judge.

```csharp
Type personType = typeof(Person);
FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

if (fields.Length != 1 || methods.Length != 5)
{
    throw new Exception();
}

string personName = Console.ReadLine();
Person person = new Person(personName);

Console.WriteLine(person.SayHello());

```

If you defined the class correctly, the test should pass.

### Examples

| **Input** | **Output** |
| --- | --- |
| Peter | Peter says &quot;Hello&quot;! |

## Problem 2. Oldest Family Member

Create class **Person** with fields **name** and **age**. Create a class **Family**. The class should have **list of people** , method for adding members (**void AddMember(Person member)**) and a method returning the oldest family member(**Person  GetOldestMember()**). Write a program that reads name and age for **N** people and **add them to the family**. Then **print** the **name** and **age** of the oldest member.

#### Note

Add the following code to your main method before your code and submit it to Judge.

```csharp
MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
if(oldestMemberMethod == null || addMemberMethod == null)
{
   throw new Exception();
}

```

If you defined the class correctly, the test should pass.

### Examples

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 3 <br/> Pesho 3 <br/> Gosho 4 <br/> Annie 5 | Annie 5 | 5 <br/> Steve 10 <br/> Christopher 15 <br/> Annie 4 <br/> Ivan 35 <br/> Maria 34 | Ivan 35 |

## Problem 3. Last Digit Name

Write a class **Number** that will hold an integer number. Write a **method** in the class that returns the **English name** of the last digit **of the given number. Write a program that** reads an integer **and prints the** returned value from this method.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| 1024 | four |  512 | two |

## Problem 4. Number in Reversed Order

Write a class **DecimalNumber** that has a method that **prints all its digits** in **reversed order**.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- |
| 256 | 652 | 1.12 | 21.1 |

## Problem 5. Fibonacci Numbers

Define a class **Fibonacci**. It should keep a **list** of all **Fibonacci numbers** starting from **0, 1 until Nth** number in the sequence. Write a **method** in the Fibonacci class that receives as parameters **start position** and **end position** and returns **part of the sequence** starting from **start position (inclusive)** until **end position (exclusive)**.
**List&lt;int&gt; GetNumbersInRange(int startPosition, int endPosition)**.

Write a program that reads **start position** and **end position** and prints the **Fibonacci numbers in that range**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 0 <br/> 6 | 0, 1, 1, 2, 3, 5 |
| 6 <br/> 7 | 8 |
| 17 <br/> 20 | 1597, 2584, 4181 |

## **Problem 6. Prime Checker**

Create a class **Number**. It should consist of an Integer and a Boolean. The integer is the actual value of the Number instance itself and the Boolean is representing – is it prime or not. They should be passed as parameters to the constructor ( **Note there could be a case in which a passed Boolean value does not match** ). The class should have a functionality to return the values of the Integer and the Boolean. Write another method whose goal is to return the next prime number as **new instance of the class**.

  **You will be given an input** – the integer **&quot;n&quot;** of the class. Your task is to print on the console the next prime number and the Boolean value of the **current instance**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 0 | 1, true |
| 1 | 2, true |
| 2 | 3, true |
| 14 | 17, false |

## **Problem 7. ImmutableList**

Create a class **ImmutableList**. It should consist of a collection of integers and a function to return them. You **should not** be able to modify the collection (e.g. every time you try to get the current collection, you should get a new collection of the same elements or return a copy of the current collection, **and never the collection itself** ).

#### Note

Add the following code to your main method and submit it to Judge.

```csharp
Type immutableList = typeof(ImmutableList);
FieldInfo[] fields = immutableList.GetFields();
if(fields.Length < 1)
{
   throw new Exception();
}
else
{
   Console.WriteLine(fields.Length);
}

MethodInfo[] methods = immutableList.GetMethods();
bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
if(!containsMethod)
{
    throw new Exception();
}
else
{
    Console.WriteLine(methods[0].ReturnType.Name);
}

```

If you&#39;ve defined the class correctly, the test should pass.

## 6.Problem 8. Car

Create a class **Car**. Every car has a **speed, fuel** and **fuel economy** (given in the same order on the first line). They should be stored in the class. Your task is to create a program which executes one of the commands:

- **Travel &lt;distance&gt;** – makes the car travel the specified &lt;distance&gt;

If you are given a distance which you don&#39;t have enough fuel to travel, just go as far as you can.

- **Refuel &lt;liters&gt;** – refuels the car with the specified &lt;fuel&gt;
- **Distance** – gets the total travel distance
- **Time** – get the total travel time
- **Fuel** – gets the remaining fuel
- **END** – stops the program

### Examples

| **Input** | **Output** |
| --- | --- |
| 100 20 20 <br/> Travel 100 <br/> Distance <br/> Time <br/> Fuel <br/> END | Total distance: 100.0 kilometers <br/> Total time: 1 hours and 0 minutes <br/> Fuel left: 0.0 liters |

## Problem 9. Pizza Time

Create a class **Pizza**. Every Pizza has a name (e.g. &quot;Peperoni&quot;) and a group. You should make it have a functionality to return its name and group.

Write a method ( **in the class Pizza** ), which parameters are Strings and the result is a **SortedDictionary** of groups (integer) as key and **list of names** (strings) as value. On the single input line, you will receive some strings. Every string is in format **{group number}{pizza name}**

Your task is to get the input from the console and create a collection of pizza instances. Set their names and their groups to correspond the input. Make a **SortedDictonary** consisting of the group and all pizza names of that group. After you collect the input, print the groups and their pizzas. **You must use params!**

| **Input** | **Output** |
| --- | --- |
| 4Peperoni 2Margarita 2RunningChiken 4DonVito | 2 – Margarita, RunningChiken <br/> 4 – Peperoni, DonVito |

#### Note

Add the following code to your main method and submit it to Judge.

```csharp
MethodInfo[] methods = typeof(Pizza).GetMethods();
bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
if (!containsMethod)
{
    throw new Exception();
}

```

If you&#39;ve defined the class correctly, the test should pass.

> #### Hint
> Try using **regex** for processing the input.

## Problem 10. Date Modifier

Create a class **DateModifier** which stores the difference of the days between two Dates. It should have a method which takes **two string parameters** representing a date **as strings and** calculates the difference in the days between them.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1992 05 31 <br/> 2016 06 17 | 8782 |
| 2016 05 31 <br/> 2016 04 19 | 42 |

> #### Hint
> Use the **DateTime** class.

## Problem 12. Rectangle Intersection

Create a class **Rectangle**. It should consist of an **ID, width, height** and the **coordinates of its top left corner** ( **horizontal and vertical** ). Create a **method** which **receives as a parameter** another Rectangle **, checks if the two rectangles** intersect **and** returns true or false.

On the first line you will receive the **number of rectangles** – **N** and the number of **intersection checks** – **M**. On the next **N** lines, you will get the rectangles with their **ID, width, height and coordinates**. On the last **M** lines, you will get **pairs of IDs** which represent rectangles. Print if each of the pairs **intersect.**

You will always receive valid data. There is no need to check if a rectangle exists.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 1 <br/> Pesho 2 2 0 0 <br/> Gosho 2 2 0 0 <br/> Pesho Gosho | true |

## Problem 13. \*Print People

Create a class **Person**. Every person should have name, age and occupation. Your task is to create the class and read some people, while adding them to a collection. Sort them by age and print them in the given format. **Override the ToString() and CompareTo() methods.**

### Examples

| **Input** | **Output** |
| --- | --- |
| Gosho 22 Dentist <br/> Mimi 13 Student <br/> END | Mimi - age: 13, occupation: Student <br/> Gosho - age: 22, occupation: Dentist |

## Problem 14. \*\*Drawing tool

You are young programmer and your Boss is giving you a task to create a tool which is drawing figures on the console. He knows you are not so good at OOP tasks so he told you to create only single class - CorDraw. Its task is to draw rectangular figures on the screen.

CorDraw&#39;s constructor should take as parameter a Square instance or a Rectangle instance, extract its characteristics and draw the figure. Like we said your Boss is a good guy and he has some more info for you:

One of your classes should be a class named **Square** that should have only one method – **Draw()** which uses the length of the square&#39;s sides and draws them on the console. For horizontal lines, use dashes (&quot;-&quot;) and spaces (&quot; &quot;). For vertical lines – pipes (&quot;|&quot;). If the size of the figure is 6, dashes should also be 6.

### Examples

#### Input: 
**Square** <br/> 
**3**

```
|- - -|
|     |
|- - -|
```

#### Input: 
**Rectangle** <br/> 
**7** <br/> 
**3**

```
|- - - - - - -|
|             |
|- - - - - - -|
```
