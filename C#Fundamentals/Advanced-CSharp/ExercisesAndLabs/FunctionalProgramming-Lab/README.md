# <p align="center"> Lab: Functional Programming </p>

# 1.Lab: Functional Programming

Problems for exercises and homework for the [&quot;C# Advanced&quot; course @ SoftUni&quot;.](https://softuni.bg/courses/csharp-advanced)

Submit your solutions in the SoftUni judge system at [https://judge.softuni.bg/Contests/597/Functional-Programming-Lab.](https://judge.softuni.bg/Contests/597/Functional-Programming-Lab)

## 1.Sort Even Numbers

Write a program that reads one line of **int** separated by **&quot;, &quot;**. Then print exactly 2 lines of output. On the first line print **only the even numbers** of that sequence. On the second line print those **even numbers sorted** in **increasing** order.

### Examples

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | 
| 4, 2, 1, 3, 5, 7, 1, 4, 2, 12 | 2, 2, 4, 4, 12 | 1, 3, 5 | |  2, 4, 6 | 2, 4, 6 |

> ### Hints
> It is up to you what type of data structures you will use to solve this problem
> Using functional programming filter and sort the collection of numbers.

## 2.Sum Numbers

Write a program that reads one line of **int** separated by **&quot;, &quot;**. Print **count** of numbers and their **sum.**

### Examples

| **Input** | **Output** |
| --- | --- |
| 4, 2, 1, 3, 5, 7, 1, 4, 2, 12 | 10 <br/> 41 |
| 2, 4, 6 | 3 <br/> 12 |

## 3.Count Uppercase Words

Write a program that reads one line of **text** from console. Print **all** words that start with **Uppercase** in the **same order** like you find them in text.

### Examples

| **Input** | **Output** |
| --- | --- |
| The following example shows how to use Function | The <br/> Function |
| Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in the same order like you find them in text. | Write <br/> Print <br/> Uppercase, |

> ### Hints
> Use **Func&lt;string, bool&gt;** like or in if condition
> Use **&quot; &quot;** for splitting words.

## 4.Add VAT

Write a program that reads one line of **double** prices separated by **&quot;, &quot;**. Print prices with added VATs for all of them.

Format them to 2 sign after decimal point. Order of prices must be the same. VAT is equal to 20% of the price.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- |
| 1.38, 2.56, 4.4 | 1.66 <br/> 3.07 <br/> 5.28 | 1, 3, 5, 7 | 1.20 <br/> 3.60 <br/> 6.00 <br/> 8.40 |

## 5.Filter by Age

Write a program that read integer **N** on first line. And on next **N** lines read pairs of **&quot;[name], [age]&quot;.** Then read three lines with:

- **Condition** - &quot;younger&quot; or &quot;older&quot;
- **Age** - Integer
- **Format** - &quot;name&quot;, &quot;age&quot; or &quot;name age&quot;

Depend on **condition** print right **pairs** in right **format**.

**Don&#39;t use built-in functionality from .NET. Write your own methods.**

### Examples

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | 
| 5 <br/> Pesho, 20 <br/> Gosho, 18 <br/> Mimi, 29 <br/> Ico, 31 <br/> Simo, 16 <br/> older <br/> 20 <br/> name age | Pesho - 20 <br/> Mimi - 29 <br/> Ico - 31 | 5 <br/> Pesho, 20 <br/> Gosho, 18 <br/> Mimi, 29 <br/> Ico, 31 <br/> Simo, 16 <br/> younger <br/> 20 <br/> name | Gosho <br/> Simo | 5 <br/> Pesho, 20 <br/> Gosho, 18 <br/> Mimi, 29 <br/> Ico, 31 <br/> Simo, 16 <br/> younger <br/> 50 <br/> age | 20 <br/> 18 <br/> 29 <br/>31 <br/> 16 |