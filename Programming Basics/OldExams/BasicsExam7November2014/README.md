# <p align="center"> C# Basics Exam 7 November 2014

## Problem 1 – Budget

Kiro is a grown up now. He&#39;s working and he has a certain amount of **money** available to last the month. He wants to know if that&#39;s possible. Kiro spends **10lv every weekday** when he&#39;s **not** going **out**. He goes out **p** weekdays in the month. When he goes out he spends **3%** of his **total** **budget**(rounded down to the nearest integer. Example: **3% of 608 = 18.24** rounded down to **18**) in addition to his normal daily expense of 10lv . On weekends Kiro spends 20lv per day when he&#39;s not going to his hometown. Kiro goes to his hometown **h** weekends per month. When he&#39;s at his hometown he doesn&#39;t spend anything because he stays with his parents. On top of everything Kiro pays **150lv** per month for **rent**. We assume that each month has **30 days** and **4 weekends**.

Your task is to write a program that calculates **if Kiro can last the month**.

### Input

The input data should be read from the console. It consists of three input values, each at separate line:

- The number **n** – amount of **money** Kiro has to last the month.
- The number **p** – number of **weekdays** Kiro goes out per month.
- The number **h** – number of weekends that Kiro spends in his **hometown**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- On the only output line you must print **&quot;Yes, leftover {0}.&quot;** if Kiro has enough to last the month, or **&quot;No, not enough {0}.&quot;** if he can&#39;t.
- Print **&quot;Exact Budget.&quot;** if Kiro has just enough.

### Constraints

- The number **n** is an integer in range [0...2,147,483,647].
- The number **p** is an integer in range [0…22] and **h** is an integer in range [0…4].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 800 <br/> 10 <br/> 2 | Yes, leftover 110. | 30 days total in the month, split into: <br/> - 2 hometown weekends No expenses <br/> - 2 normal weekends 4 normal weekend days 80lv expense <br/> - 22 weekdays split into 10 going out and 12 normal <br/> - 10 weekdays going out 10 \* ((3% of 800=24) + 10lv) = 340lv <br/> - 12 normal weekdays times 10lv expense = 120lv <br/> + 150lv rent = Total 690lv |

| **Input** | **Output** | **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | 
| 600 <br/> 15 <br/> 4 | No, not enough 40. | 608 <br/> 11 <br/> 3 | Exact Budget. | 700 <br/> 5 <br/> 0 | Yes, leftover 65. |

## Problem 2 – Odd or Even Counter

Petko is bad with numbers. He&#39;s given a task to find and count some, but he has a hard time doing it. He is given **N** sets of numbers, and he has to count the odd numbers in each set, and then compare them. The number **C** shows **how many numbers** are there **in a set**. Then you are given a string **S** holding one of the words &quot; **odd**&quot; or **&quot;even&quot;** showing you what numbers should be counted . Then you are given **N \* C** numbers representing all sets.

Your task is to **count** the **odd** or **even** numbers in each set, and then say in which set has most **S** numbers.
The set with most **S** numbers should be represented as **ordinal** number word e.g. **&quot;First&quot;, &quot;Second&quot;, &quot;Third&quot;, &quot;Fourth&quot;, &quot;Fifth&quot;, &quot;Sixth&quot;, &quot;Seventh&quot;, &quot;Eighth&quot;, &quot;**** Ninth ****&quot;, &quot;Tenth&quot;.** If the count of one or more sets is equal, print the **first one** with biggest count. If there is no set holding odd or even numbers print **&quot;No&quot;**.

### Input

The input data should be read from the console. It consists of three input values, each at separate line:

- The first line holds an integer **N** – the count of sets
- The second line hold an integer **C** – the count of numbers in each set
- The third line holds a string **S**  holding either **&quot;odd&quot;** or **&quot;even&quot;** showing what numbers to count

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console. It consists of exactly **1 line.**

- Print on the console the following formatted string **&quot;{0} set has the most {1} numbers: {2}&quot;** , where **{0}** is the set as **ordinal** string **{1}** is the value of **S** and **{2}** is the biggest count of **S** numbers. If there is no set holding odd or even numbers print **&quot;No&quot;**.

### Constraints

- **N** will be an integer number in the range [1...10]
- **C** will be an integer number in the range [1...50]
- Each of the numbers in the set will be an integer in the range[-2 147 483 647… 2 147 483 647]
- Allowed working time for your program: 0.25 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |**Input** | **Output** |
| --- | --- | ---|---|
| 2 <br/> 5 <br/> odd <br/> 6 <br/> 4 <br/> 12 <br/> 8 <br/> 199 <br/> 15 <br/> 21 <br/> 7 <br/> 3 <br/> 5 | Second set has the most odd numbers: 5 | 3 <br/> 2 <br/> even <br/> 1 <br/> 3 <br/> 5 <br/> 7 <br/> 9<br/> 11 | No |

| **Input** | **Output** |
|---|---|
| 3 <br/> 2 <br/> odd <br/> 1 <br/> 3 <br/> 5 <br/> 9 <br/> 151 <br/> 193  | First set has the most odd numbers: 2 |

## Problem 3 – Plane

You will be given an integer **N**. The **width** of the rocklq is **(3\*N).** The **height** of the plane is **((N \* 3) – (N / 2))** and the width is **(N \* 3).** Check the examples below to understand your task better.

## Input

Input data is read from the console.

- The number **N** stays alone at the first line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

- The output data must be printed on the console.
- You must print at the console a picture of size **N** following the formulas above and the examples below.

## Constraints

- **N** will be a number between **5** and **31** and will be **an odd number**.
- Time limit: 0.25 seconds. Allowed memory: 16 MB.

## Examples

#### Input: 5

```
.......*.......
......*.*......
.....*...*.....
....*.....*....
...*.......*...
.*...........*.
*...*.....*...*
*.*.*.....*.*.*
....*.....*....
...*.......*...
..*.........*..
.*...........*.
***************
```

#### Input: 7

```
..........*..........
.........*.*.........
........*...*........
.......*.....*.......
......*.......*......
.....*.........*.....
...*.............*...
.*.................*.
*.....*.......*.....*
*...*.*.......*.*...*
*.*...*.......*...*.*
......*.......*......
.....*.........*.....
....*...........*....
...*.............*...
..*...............*..
.*.................*.
*********************
```

#### Input: 9

```
.............*.............
............*.*............
...........*...*...........
..........*.....*..........
.........*.......*.........
........*.........*........
.......*...........*.......
.....*...............*.....
...*...................*...
.*.......................*.
*.......*.........*.......*
*.....*.*.........*.*.....*
*...*...*.........*...*...*
*.*.....*.........*.....*.*
........*.........*........
.......*...........*.......
......*.............*......
.....*...............*.....
....*.................*....
...*...................*...
..*.....................*..
.*.......................*.
***************************
```

## Problem 4 – Weird Combinations

You are given a sequence of 5 distinct numbersand/or letters. Find all possible combinations of 5 symbols containing the given numbers/letters. Then you will be given a number n. You have to find the n-th number in the natural order of all combinations. **Example:** sequence = **&quot;a1bc2&quot;,n = 5**, combinations: **&quot;aaaaa&quot;, &quot;aaaa1&quot;, &quot;aaaab&quot;, &quot;aaaac&quot;, &quot;aaaa2&quot;, &quot;aaa1a&quot;, &quot;aaa1b&quot;…  &quot;2222b&quot;, &quot;2222c&quot;, &quot;22222&quot;**.  5th element = aaa1a (take notice that the first element in the order is counted as 0). If the **n-th number doesn&#39;t exist** in **print &quot;No&quot;**.

## Input

Input data is read from the console.

- The sequence of **letters/numbers** stays at the first line.
- The number **n** of stays at the second line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data must be printed on the console.

- Print the n-th number in the natural order of all combinations.

## Constraints

- **N** will be an integer number between **0** and **5000** and
- Time limit: 0.25 seconds. Allowed memory: 16 MB.

## Examples

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |   **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- | 
| a1bc2 <br/> 5 | aaa1a | f5182 <br/> 15 | fff8f |  12345 <br/> 250 | 13111 |  12345 <br/> 6000 | No |