# <p align="center"> Data Type And Variables <p>

## 01. **Centuries to Minutes**

####**Problem Description**

Write program to enter an integer number of **centuries** and convert it to **years, days, hours** and **minutes**.
####Examples
**1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes**
####Hints
- Use appropriate data type to fit the result after each data conversion.
- Assume that a year has 365.2422 days at average (the Tropical year).

## 02. **Circle Area (12 Digits Precision)**

####Problem Description

Write program to enter a radius r (real number) and **print the area** of the circle with exactly **12 digits** after the decimal point. Use data type of **enough precision** to hold the results.

####Hints
- You might use the data type double. It has precision of 15-16 digits.

## 03.Exact Sum of Real Numbers

####Problem Description

Write program to enter n numbers and calculate and print their **exact sum** (without rounding).

####Hints
- If you use types like **float** or **double**, the result will lose some of its precision. Also it might be printed in scientific notation.
- You might use the **decimal** data type which holds real numbers with high precision with less loss.
- Note that **decimal** numbers sometimes hold the unneeded zeroes after the decimal point, so **0m** is different than **0.0m** and **0.00000m**.

## 04.Elevator 
####Problem Description

Calculate how many courses will be needed to **elevate n persons** by using an elevator of **capacity of p persons**. The input holds two lines: the **number of people** n and the **capacity p** of the elevator.
####Hints
- You should **divide n by p**. This gives you the number of full courses (e.g. 17 / 3 = 5).
- If **n** does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).
- Another approach is to round up **n / p** to the nearest integer (ceiling), e.g. 17/3 = 5.67  rounds up to 6.

## 05.Special Numbers
#### Problem Description

A **number** is special when its **sum of digits is 5, 7 or 11**.
Write a program to read an integer **n** and for all numbers in the range **1…n** to print the number and if it is special or not **(True / False)**.

####Hints
- To calculate the sum of digits of given number **num**, you might repeat the following: sum the last digit **(num % 10)** and remove it **(sum = sum / 10)** until num reaches **0**.

## 06.Triples of Latin Letters
#### Problem Description

Write a program to read an integer **n** and print all **triples** of the first **n small Latin letters**, ordered alphabetically.

####Hints
- Perform 3 nested loops from **0** to **n-1**. For each number num print its corresponding Latin letter .

## 07.Greeting
#### Problem Description

Write a program that enters **first name, last name** and **age** and prints "Hello, <first name> <last name>. You are <age> years old.". Use **interpolated** strings.


