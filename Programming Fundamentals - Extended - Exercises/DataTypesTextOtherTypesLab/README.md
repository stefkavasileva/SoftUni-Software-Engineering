#<p align="center"> Data Types: Text and Other Types, Variables - Lab <p>

## 01.Special Numbers
A **number** is special when its **sum of digits is 5, 7 or 11**.
Write a program to read an integer **n** and for all numbers in the range **1…n** to print the number and if it is special or not **(True / False)**.

####Hints
- To calculate the sum of digits of given number num, you might repeat the following: sum the last digit **(num % 10)** and remove it **(sum = sum / 10)** until num reaches **0**.

## 02.Triples of Latin Letters
Write a program to read an integer **n** and print all **triples** of the first **n small Latin letters**, ordered alphabetically:

####Hints
- Perform 3 nested loops from 0 to n-1. For each number num print its corresponding Latin letter.

##03.Greeting
Write a program that enters **first name, last name** and **age** and prints **"Hello, <first name> <last name>. You are <age> years old."**. Use interpolated strings.

##04.Refactor Volume of Pyramid 
You are given a **working code** that finds the **volume of a pyramid**. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that **have multiple purpose**.

##05.Refactor Special Numbers
You are given a **working code** that is a solution to **Problem 5. Special Numbers**. However, the variables are improperly named, declared before they are needed and some of them are used for multiple things. Without using your previous solution, modify the code so that it is **easy to read and understand**.
