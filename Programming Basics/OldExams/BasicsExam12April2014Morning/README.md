# <p align="center"> C# Basics Exam 11 April 2014 Evening <p>

## Problem 1 – Triangle

You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: A(Ax, Ay), B(Bx,  By), C(Cx, Cy). Write a program to check if these three points can form a triangle. Then calculate the area of this triangle. To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:

![Not fount](/Programming%20Basics/OldExams/images/5.PNG)

You can use the inequalities of a triangle to check whether three segments a, b and c can form a triangle:

![Not fount](/Programming%20Basics/OldExams/images/6.PNG)

To calculate the area you can use Heron`s formula (a method for calculating the area of a triangle when you know the lengths of all three sides). Let a, b, c be the lengths of the sides of a triangle. Thus:

![Not fount](/Programming%20Basics/OldExams/images/7.PNG)

### Input

The input data comes from the console. It consists of exactly 6 lines holding the coordinates of the three points: **Ax** -coordinate, **Ay** -coordinate, **Bx** -coordinate, **By** -coordinate, **Cx** -coordinate and **Cy** -coordinate. The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console and must contain two lines.

- **First line:** If the given points can form a triangle you must print the message &quot; **Yes**&quot;, otherwise &quot; **No**&quot;.
- **Second line:** If the given points can form a triangle you must print the **area of the triangle** rounded to two decimal places (see the examples), otherwise you must print the **distance between point A and point B**. Use &quot; **.** &quot; as decimal separator.

### Constraints

- The coordinate **X** is integer in the range [-10000…10000] inclusive.
- The coordinate **Y** is integer in the range [-10000…10000] inclusive.
- Allowed work time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** | 
| --- | --- | --- | --- | --- | --- | --- 
| 2 <br/> 2 <br/> 0 <br/> 0 <br/> 1 <br/> 1 | No  <br/> 2.83  |![Not fount](/Programming%20Basics/OldExams/images/8.PNG)|
| 0 <br/> 2 <br/> 3 <br/> 0 <br/> -1 <br/> 4 <br/> -2 | Yes <br/> 2.00 |![Not fount](/Programming%20Basics/OldExams/images/9.PNG)|

## Problem 2 – Pairs

You are given a number **N** and **2\*N elements** (integer numbers). The first and the second element form a **pair** , the third and the fourth element form a pair as well, etc. Each pair has a **value** , calculated as the **sum** of its two elements. Your task is to write a program to check **whether all pairs have the same value** or print the **max difference** between two consecutive values.

### Input

You are given at the console **even number of integers** , all in a single line, separated by a space.

### Output

The output is single line, printed at the console.

- In case all pairs have the same value, print &quot; **Yes, value=…** &quot; and the value.
- Otherwise, print &quot; **No, maxdiff=…** &quot; and the maximal difference between two consecutive values, always a **positive integer**.

### Constraints

- All input values will be integers in the range [-1000…1000] inclusive.
- The number of elements are even number in the range [2…1000] inclusive.
- Allowed work time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 0 3 4 -1 | Yes, value=3 | values = {3, 3, 3} --&gt; equal values |
| 1 2 2 2 | No, maxdiff=1 | values = {3, 4}, different values --&gt; max difference = 4-3 = 1 |
| 1 1 3 1 2 2 0 0 | No, maxdiff=4 | values = {2, 4, 4, 0}, differences = {2, 0, 4}, max difference = 4 |
| 5 5 | Yes, value=10 | values = {10} --&gt; single value --&gt; equal values |
| -1 0 0-1 | Yes, value=-1 | values = {-1, -1}, equal values |

## Problem 3 – House

Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have to help him construct the building from the ground zero.

The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls and the base of the house it build of &#39; **\*** &#39;. Everything else is filled with &#39; **.** &#39; (see the examples below to catch the idea).

You will be given an odd integer **N** , representing the width and the height of the house. The roof&#39;s top starts from the center (**N+1)/2** and forms a triangle with base of width **N**. The roof&#39;s height is (**N+1)/2**. The distance between the roofs&#39; end point and the walls of the building is **N/4** , rounded down to an integer number. See the examples below to understand better these formulas.

### Input

- Input data is read from the console.
- The number **N** stays alone at the first line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- You must print at the console a house of size **N** following the formulas above and the examples below.

### Constraints

- **N** will be an **odd** number between **5** and **49**.
- Time limit: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 5

```
..*..
.*.*.
*****
.*.*.
.***.
```

#### Input: 7

```
...*...
..*.*..
.*...*.
*******
.*...*.
.*...*.
.*****.
```

### Input: 9

```
....*....
...*.*...
..*...*..
.*.....*.
*********
..*...*..
..*...*..
..*...*..
..*****..
```


## Problem 4 – Magic Dates

Consider we are given a **date** in format dd-mm-yyyy, e.g. 17-03-2007. We calculate the **weight of this date** by joining together all its digits, multiplying each digit by each of the other digits and finally sum all obtained products. In our case we will have 8-digits: 17032007, so the weight is 1\*7 + 1\*0 + 1\*3 + 1\*2 + 1\*0 + 1\*0 + 1\*7 + 7\*0 + 7\*3 + 7\*2 + 7\*0 + 7\*0 + 7\*7 + 0\*3 + 0\*2 + 0\*0 + 0\*0 + 0\*7 + 3\*2 + 3\*0 + 3\*0 + 3\*7 + 2\*0 + 2\*0 + 2\*7 + 0\*0 + 0\*7 + 0\*7 = 144.

Your task is to write a program that finds all **magic dates** : **dates between two fixed years matching given magic weight**. The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar (years have 12 months, each having 28, 29, 30 or 31 days, etc.)

### Input

The input data should be read from the console. It consists of 3 lines:

- The first line holds an integer number – **start year**.
- The first line holds an integer number – **end year**.
- The first line holds an integer number – **magic weight**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console as a sequence of dates in **format dd-mm-yyyy** in **alphabetical order**. Each string should stay on a separate line. In case no magic dates exist, print &quot; **No**&quot;.

### Constraints

- The **start** and **end year** are **integers** in the range [1900-2100].
- The **magic weight** is an integer number in range [1…1000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| 2007 <br/> 2007 <br/> 144 | 17-03-2007 <br/> 13-07-2007 <br/> 31-07-2007 |
| 2003 <br/> 2004 <br/> 1500 | No |
| 2012 <br/> 2014 <br/> 80 | 09-01-2013 <br/> 17-01-2013 <br/> 23-03-2013 <br/> 11-07-2013 <br/> 01-09-2013 <br/> 10-09-2013 <br/> 09-10-2013 <br/> 17-10-2013 <br/> 07-11-2013 <br/> 24-11-2013 <br/> 14-12-2013 <br/> 23-11-2014 <br/> 13-12-2014 <br/> 31-12-2014 |
| 2011 <br/> 2012 <br/> 14 | 01-01-2011 <br/> 10-01-2011 <br/> 01-10-2011 <br/> 10-10-2011 |
