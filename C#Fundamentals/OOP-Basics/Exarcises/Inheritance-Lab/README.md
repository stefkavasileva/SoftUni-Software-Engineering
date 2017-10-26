# <p align="center"> Lab:  Inheritance </p>

Problems for exercises and homework for the [&quot;C# OOP Basics&quot; course @ SoftUni](https://softuni.bg/courses/csharp-oop-basics)&quot;.

You can check your solutions here: [https://judge.softuni.bg/Contests/679/Inheritance-Lab](https://judge.softuni.bg/Contests/679/Inheritance-Lab).

# Part I: Inheritance

## 1.Single Inheritance

Create two classes named **Animal** and **Dog**.

**Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**

**Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**

**Dog** should inherit from **Animal**.

> ### Hints
> Use the **: operator** to build a hierarchy

## 2.Multiple Inheritance

Create three classes named **Animal** , **Dog** and **Puppy**.

**Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**

**Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**

**Puppy** with a single public method **Weep()** that prints: **&quot;** **weeping…** **&quot;**

**Dog** should inherit from **Animal**. **Puppy** should inherit from **Dog**.

## 3.Hierarchical Inheritance

Create three classes named **Animal** , **Dog** and **Cat**.

**Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**

**Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**

**Cat** with a single public method **Meow()** that prints: **&quot;meowing…&quot;**

**Dog** and **Cat** should inherit from **Animal**.

# 3.Part II: Reusing Classes

## 4.Random List

Create a **RandomList** class that has all the functionality of **Array** **List**.

Add additional function that **returns** and **removes** a random element from the list.

- Public method: **RandomString(): string**

## 5.Stack of Strings

Create a class **StackOfStrings** which can store only strings and has the following functionality:

- Private field: **data: List&lt;string&gt;**
- Public method: **Push(string item): void**
- Public method: **Pop(): string**
- Public method: **Peek(): string**
- Public method: **IsEmpty(): bool**

Use composition/delegation in order to have a field in which to store the stack&#39;s data