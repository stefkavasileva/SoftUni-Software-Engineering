#<p align="center"> Arrays - Lab <p>

## 01.Day of Week
Enter a **day number** [1…7] and print the **day name** (in English) or **“Invalid Day!”**. Use an **array of strings**.

####Hints

- Use an **array of strings-- holding the day names: {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}.
- Print the element at index **(day-1)** when it is in the range [1…7] or **“Invalid Day!”** otherwise.


## 02.Reverse an Array of Integers
Write a program to read **an array of integers, reverse** it and **print** its elements. The input consists of a **number n** (the number of elements) + **n** integers, each as a separate line. Print the output on a single line (space separated).

##03.Last K Numbers Sums Sequence
Enter two integers **n** and **k**. Generate and print the following sequence of **n** elements:
- The first element is: **1**
- All other elements = sum of the previous **k** elements (if less than **k** are available, sum all of them)
- Example: n = **9**, k = **5 -> 120** = 4 + 8 + 16 + 31 + 61

##04.Triple Sum
Write a program to read **an array of integers** and find all triples of elements **a, b** and **c**, such that **a + b == c** (where **a** stays left from **b**). Print **“No”** if no such triples exist.

##05.Rounding Numbers Away from Zero
Write a program to read **an array of real numbers** (space separated values), **round** them to the nearest integer in **“away from 0”** style and print the output as in the examples below.
Rounding in “away from zero” style means:
- To round to the nearest integer, e.g. 2.9  3; -1.75  -2
- In case the number is exactly in the middle of two integers (midpoint value), round it to the next integer which is away from the 0:

##06.Reverse an Array of Strings
Write a program to read **an array of strings**, reverse it and **print** its elements. The input consists of a sequence of space separated strings. Print the output on a single line (space separated).

##07.Sum Arrays
Write a program that reads two **arrays of integers** and sums them. When the arrays are not of the same size, duplicate the smaller array a few times.

##08.Condense Array to Number
Write a program to read **an array of integers** and **condense** them by **summing** adjacent couples of elements until a **single integer** is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.

##09.Extract Middle 1, 2 or 3 Elements
Write a method to extract the **middle 1, 2** or **3** elements from array of n integers and **print** them.
- **n** = 1 -> **1** element
- even **n** -> **2** elements
- odd **n** -> **3** elements
Create a program that reads an **array of integers** (space separated values) and prints the middle elements in the format shown in the examples.
