# <p align="center"> Arrays: Simple Array Processing  <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/384#0).

## 1.Sum Array Elements

Write a program which reads an **array** of integers, calculates its **sum** and **prints** it.

The input consists of a **number**** n**(the number of elements) +**n** integers, each as a separate line.

### Examples

| **Input** | **Output** |
| --- | --- |
| **4** <br/>1<br/>2<br/>3<br/>4 | 10 |
| **5** <br/>1<br/>1<br/>1<br/>1<br/>1 | 5 |
| **4** <br/>2<br/>-1<br/>-2<br/>8 | 7 |

### Hints

- First, read the number **n**.
- Allocate an array of **n** integers.
- Read the integers in a **for** -loop.

## 2.Multiply an Array of Doubles

Write a program to read **an array of doubles** , a double **p** , multiply each element by **p** and print the resulting array.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1.2 3.0 12.3 4.56<br/>4 | 4.8 12 49.2 18.24 |
| 6.0 8.8 1.2 -9.6<br/>0.5 | 3 4.4 0.6 -4.8 |

### Hints

- First, use the **Split()** function to read the integers on the single line
- Use a **for loop** to convert the resulting **string array** into a **double array**
- **Loop through** the array, **multiplying each element** by **p**
- Finally, **print** the resulting array, using a **for** loop

## 3.Smallest Element in Array

Write a program to read **an array of integers** , find the **smallest element** and **print** it.

### Examples

| **Input** | **Output** |
| --- | --- |
| **1** 2 3 4 | 1 |
| 3 2 9 **-9** 6 1 | -9 |
| -6 0 **-17** -1 | -17 |

### Hints

- First, use the **Split()** function to read the integers on the single line
- Use a **for loop** to convert the resulting **string array** into an **integer array**
- Finally, **loop through** the **integer array** until you find the **smallest element**

## 4.Rotate Array of Strings

Write a program to read **an array of strings** , **rotate** it to the right and **print** its rotated elements.

### Examples

| **Input** | **Output** |
| --- | --- |
| a b c d e | e a b c d |
| soft uni hi | hi soft uni |
| i r a b | b i r a |

### Hints:

- You can store the rotated array in a **second array** alongside the first one

## 5.Count of Odd Numbers in Array

Write a program to read **an array of integers** and find **how many odd elements it holds**.

### Examples

| **Input** | **Output** |
| --- | --- |
| **1** -2 **3** 4 | 2 |
| **3** ** 9 ** **-9** -6 **1** -2 | 4 |
| 66 0 2 1 | 1 |

### Hints:

- You can check if a number is **odd** if you **divide them by 2** and check whether you get **a remainder of 1**.
- Odd numbers which are negative have a **remainder** of **-1**.

1. 6.Odd Numbers at Odd Positions

Write a program to read an array of integers and find how many **odd numbers** at **odd positions** the array holds. If there are no numbers which match this criteria, **do not print anything**

### Examples

| **Input** | **Output** | **Explanation** |
| --- | --- | --- |
| 2 **3** 5 2 7 **9** -1 **-7** | Index 1 -&gt; 3<br/>Index 5 -&gt; 9<br/>Index 7 -&gt; -7 | Indexes: 0 **1** 2 3 4 **5**  6   **7** <br/> Numbers: 2 **3** 5 2 7 **9**** -1** -7 <br/><br/>Odd positions with odd numbers: 1, 5 and 7 |
| 2 **3** 55 2 4 **1** | Index 1 -&gt; 3<br/>Index 5 -&gt; 1 | Indexes: 0 **1** 23 4 **5** <br/> Numbers:2 **3** 55 2 4 **1** <br/><br/> Odd positions with odd numbers: 1 and 5 |
| 5 0 1 2 | _(no output)_ | Indexes: 0 1 2 3<br/>Numbers:5 0 1 2 <br/><br/>Odd positions with odd numbers: **none** |

### Hints

- Positions are counted **from**** 0**from left to right, so if for example the second element (**index 1**) is**odd **, then we** should** count it, and so on…
- Do **NOT** count odd numbers which are at **even** positions (0, 2, 4, etc…)