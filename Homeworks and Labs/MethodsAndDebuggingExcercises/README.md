#<p align="center"> Methods and Debugging - Exercises <p>

## 01.Hello, Name!
Write a **method** that receives a name as **parameter** and prints on the console. **“Hello, <name>!”**

## 02.Max Method
Create a method **GetMax(int a, int b)**, that returns maximal of two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the **GetMax(…)** method you just created.


##03.English Name оf The Last Digit
Write a **method** that returns the **English name** of the last digit of a given number. Write a program that reads an integer and prints the returned value from this method.


## 04.Numbers in Reversed Order
Write a method that **prints the digits** of a given decimal number in a **reversed order**.


## 05.Fibonacci Numbers
Define a method **Fib(n)** that calculates the **nth** Fibonacci number. 

## 06.Prime Checker
Write a Boolean method **IsPrime(n)** that check whether a given integer number **n is prime**.

## 07.* Primes in Given Range
Write a method that calculates **all prime numbers in given range** and returns them as list of integers.Write a **method** to **print a list of integers**. Write a program that **enters two integer numbers** (each at a separate line) and prints all primes in their range, separated by a comma.

## 08.Center Point
You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2. **Create a method** that prints the point that is closest to the center of the coordinate system **(0, 0)** in the format **(X, Y)**. If the points are on a same distance from the center, print only the first one.

## 09.Longer Line
You are given the coordinates of **four points** in the 2D plane. The first and the second pair of points form **two different lines**. Print the longer line in format **"(X1, Y1)(X2, Y2)"** starting with the point that is **closer** to the **center** of the coordinate system **(0, 0)** (You can reuse the method that you wrote for the previous problem). If the lines are of **equal length**, **print only** the first one.

##10.Cube Properties
Write a program that can calculate the **length** of the **face diagonals, space diagonals, volume** and **surface area** of a cube (http://www.mathopenref.com/cube.html) by a given **side**. On the first line you will get the **side** of the cube. On the second line is given the **parameter** (face, space, volume or area).
Output should be **rounded** to the **second digit after the decimal point.**

##11.Geometry Calculator
Write a program that can **calculate the area** of four different geometry figures - **triangle, square, rectangle** and **circle**.
On the **first line** you will get the **figure type**. Next you will get **parameters** for the chosen figure, each on a different line:
- **Triangle - side and height**
- **Square - side**
- **Rectangle - width and height**
- **Circle - radius**
The output should be **rounded** to the **second digit after the decimal point.**

##12.Master Numbers
A master number is an integer that holds the following properties:
- Is **symmetric** (palindrome), e.g. 5, 77, 282, 14341, 9553559.
- Its **sum of digits is divisible by 7**, e.g. 77, 313, 464, 5225, 37173.
- Holds **at least one even digit**, e.g. 232, 707, 6886, 87578.
Write a program to **print all master numbers** in the range **[1…n]**.

##13.* Factorial
Write a program that calculates and prints the **n!** for any n in the range [1…1000].
####Hints
Use the class **BigInteger** from the built-in .NET library **System.Numerics.dll**.

##14.Factorial Trailing Zeroes
Create a program that counts the trailing zeroes of the factorial of a given number.

##15-18 Debugging Exercises-The goal of this exercises is to practice debugging techniques in scenarios where a piece of code does not work correctly. Your task is to pinpoint the bug and fix it (without rewriting the entire code)