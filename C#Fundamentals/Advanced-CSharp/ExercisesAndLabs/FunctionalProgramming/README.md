# <p align="center"> Exercises: Functional Programming </p>

This document defines the **exercise assignments** for the [&quot;CSharp Advanced&quot; course @ Software University](https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/).

## Problem 1.Action Print

Write a program that reads a collection of strings from the console and then prints them onto the console. Each name should be printed on a new line. Use **Action&lt;T&gt;**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Gosho Adasha | Pesho <br/> Gosho <br/> Adasha |

## Problem 2.Knights of Honor

Write a program that reads a collection of names as strings from the console then appends &quot;Sir&quot; in front of every name and prints it back onto the console. Use **Action&lt;T&gt;**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Gosho Adasha StanleyRoyce | Sir Pesho <br/>  Sir Gosho <br/> Sir Adasha <br/> Sir StanleyRoyce |

## Problem 3.Custom Min Function

Write a simple program that reads from the console a set of numbers and prints back onto the console the smallest number from the collection. Use **Func&lt;T, T&gt;**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 4 3 2 1 7 13 | 1 |

## Problem 4.Find Evens or Odds

You are given a lower and an upper bound for a range of integer numbers. Then a command specifies if you need to list all even or odd numbers in the given range. Use **Predicate&lt;T&gt;**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 10 <br/> odd | 1 3 5 7 9 |
| 20 30 <br/> even | 20 22 24 26 28 30 |

## Problem 5.Applied Arithmetics

Write a program that executes some mathematical operations on a given collection. On the first line you are given a list of numbers. On the next lines you are passed different commands that you need to apply to all numbers in the list: &quot;add&quot; -&gt; add 1 to each number; &quot;multiply&quot; -&gt; multiply each number by 2; &quot;subtract&quot; -&gt; subtract 1 from each number; &quot;print&quot; -&gt; print the collection. The input will end with and &quot;end&quot; command, after which you need to print the result.Use functions.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 <br/> add <br/> add <br/> print <br/> end | 3 4 5 6 7 |
| 5 10 <br/> multiply <br/> subtract <br/> print <br/> end | 9 19 |

## Problem 6.Reverse and exclude

Write a program that reverses a collection and removes elements that are divisible by a given integer **n**. Use predicates/functions.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 6 <br/> 2 | 5 3 1 |
| 20 10 40 30 60 50 <br/> 3 | 50 40 10 20 |

## Problem 7.Predicate for names

Write a program that filters a list of names according to their length. On the first line you will be given integer **n** representing name length. On the second line you will be given some names as strings separated by space. Write a function that prints only the names whose length is **less than or equal** to **n**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4 <br/> Kurnelia Qnaki Geo Muk Ivan | Geo <br/> Muk <br/> Ivan |
| 4 <br/> Karaman Asen Kiril Yordan | Asen |

## Problem 8.Custom Comparator

Write a custom comparator that sorts all even numbers before all odd ones in ascending order. Pass it to an Array.sort() function and print the result.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 6 | 2 4 6 1 3 5 |
| -3 2 | 2 -3 |

## Problem 9.List of Predicates

Find all numbers in the range 1..N that are divisible by the numbers of a given sequence. Use predicates/functions.

### Examples

| **Input** | **Output** |
| --- | --- |
| 10 <br/> 1 1 1 2 | 0 2 4 6 8 10 |
| 100 <br/> 2 5 10 20 | 0 20 40 60 80 100 |

