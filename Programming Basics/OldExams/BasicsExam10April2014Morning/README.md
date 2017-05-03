# <p align="center">Basics Exam 10-April-2014 Morning <p>

## Problem 1 – Joro, the Football Player

Joro loves a lot to play football. He used to play for his local village club &quot;Pantera&quot; Kaloyanovets. However, he is a programmer now and he is very busy. Now he is able to **play only in the holidays** and in the **weekends**. Joro plays in **1/2 of the holidays** and **twice in the weekends** : each **Saturday** and each **Sunday** , but **not every weekend** – only when he is **not tired** and only when he is **not going to his hometown**. Joro goes at his hometown **h** weekends in the year. The other weekends are considered &quot; **normal**&quot;. Joro is **not**** tired in 1/3 of the normal weekends **. When Joro is at his hometown, he always plays football with his old friends once, at** Sunday **. In addition, if the year is** leap **, Joro plays football** 3 more times **additionally, in non-weekend days. We assume the year has** exactly 52 weekends**.

Your task is to write a program that calculates **how many times Joro plays football** (rounded down to the nearest integer number).

### Input

The input data should be read from the console. It consists of three input values, each at separate line:

- The string &quot; **t**&quot; for leap year or &quot; **f**&quot; for year that is not leap.
- The number **p** – number of **holidays** in the year (which are not Saturday or Sunday).
- The number **h** – number of weekends that Joro spends in his **hometown**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- On the only output line you must print an integer representing how many times Joro plays football for a year.

### Constraints

- The numbers **p** is in range [0...300] and **h** is in range [0…52].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| t <br/> 1 <br/> 2 | 38 | 52 weekends total in the year, split into: <br/> - 2 hometown weekends 2 Sundays **2** plays <br/> - 50 normal weekends 50 \* 2 / 3 **33.33** plays <br/> 1 holiday -> **0.5** playsLeap years -> additional **3** playsTotal plays = **38.83** plays -> **38** (rounded) |

| **Input** | **Output** | **Input** | **Output** | 
| --- | --- | --- | --- | 
| f <br/> 3 <br/> 2 | 36 | t <br/> 2 <br/> 3 | 39 | 
|f <br/> 10 <br/> 5 | 41 | t <br/> 0 <br/> 1 | 38 |

## Problem 2 – Half Sum

Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game. He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums the left and right sub-sums, and compares the sub-sums. Please help him.

You are given a number **n** and **2\*n** numbers. Write a program to check whether **the sum of the first n numbers is equal to the sum of the second n numbers**.Print as result &quot;Yes&quot; or &quot;No&quot;. In case of **yes** , print also the sum. In case of **no** , print also the difference between the left and the right sums.

### Input

The input data should be read from the console.

- The first line holds an integer **n** – the count of numbers.
- Each of the next **2\*n** lines holds exactly one number.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output must be printed on the console.
- Print &quot; **Yes, sum=** S **&quot; where** S **is the sum of the first** n **numbers in case of the sum of the first** n **numbers is equal to the sum of the second** n** numbers.
- Otherwise print &quot; **No, diff=** D **&quot; where** D **is the difference between the sum of the first** n **numbers and the sum of the second** n **numbers.** D **should always be a** positive number**.

### Constraints

- The number **n** is integer in range [0...500].
- All other numbers are integers in range [-500 000 ... 500 000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | --- | --- |
| **4** <br/> 3 <br/> 4 <br/> -1 <br/> -1 <br/> 2 <br/> 1 <br/> 1 <br/> 1 | Yes, sum=5 | **3**  <br/> 1 <br/> 2 <br/> 3 <br/> 1 <br/> 2 <br/> 2 | No, diff=1 | **2** <br/>  1 <br/> 1 <br/> 0 <br/> 0 | No, diff=2 |

## Problem 3 – Sunglasses

Do you know that the next solar eclipse will occur on April 29, 2014? It will be observable from South Asia, Australia, the Pacific and the Indian Oceans and Antarctica. Spiro is an entrepreneur who wants to cash in on this natural phenomenon. Help him produce protective **sunglasses of different sizes**. You will get 5% of the profit.

### Input

- The input data should be read from the console.
- You have an integer number **N** (always an **odd number** ) specifying the height of sunglasses.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console.

You should print the sunglasses on the console. The sunglasses consist of three parts: **frames** , **lenses** and a **bridge** (the connection between the two frames). Each frame&#39;s width is double the height N and should be printed using the character &#39; **\*** &#39; (asterisk). Print the lenses with the character &#39; **/** &#39;. Finally, connect the two frames with a bridge that is of size N, using the character &#39; **|** &#39;. Leave the rest of the space between the frames blank.

### Constraints

- The number **N** will be a positive **odd integer** number in range [3…101].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 3

```
******   ******
*////*|||*////*
******   ******
```

#### Input: 5

```
**********     **********
*////////*     *////////*
*////////*|||||*////////*
*////////*     *////////*
**********     **********
```

## Problem 4 – Nine-Digit Magic Numbers

Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums of digits, as well as to split them into triples with special properties. Help her to calculate very special numbers called &quot; **nine-digit magic numbers**&quot;.

You are given two numbers: **diff** and **sum**. Using the **digits from 1 to 7** generate all 9-digit numbers in format **abcdefghi** , such that their sub-numbers **abc** , **def** and **ghi** have a difference **diff** (ghi-def = def-abc = diff), their sum of digits is **sum** and **abc &lt; def** &lt; **ghi**. Numbers holding these properties are also called &quot; **nine-digit magic numbers**&quot;.

Your task is to write a program to print these numbers in increasing order.

### Input

- The input data should be read from the console.
- The number **sum** stays at the first line.
- The number **diff** stays at the second line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Print all nine-digit magic numbers matching given difference **diff** and given sum of digits **sum** , in increasing order, each at a separate line. In case no nine-digit magic numbers exits, print &quot; **No**&quot;.

### Constraints

- The number **sum** will be a positive **integer** number in the range [0…100].
- The number **diff** will be a positive **integer** number in the range [0…1000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 27 <br/> 46 | 125171217 <br/> 131177223 <br/> 221267313|1+2+5+1+7+1+2+1+7 = 27; 171-125 = 46; 217-171 = 46  <br/> 1+3+1+1+7+7+2+2+3 = 27; 177-131 = 46; 223-177 = 46 <br/> 2+2+1+2+6+7+3+1+3 = 27; 267-221 = 46; 313-267 = 46|

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 24 <br/> 103 | 121224327 <br/> 211314417 | 1+2+1+2+2+4+3+2+7 = 24; 224-121 = 103; 327-224 = 103 <br/> 2+1+1+3+1+4+4+1+7 = 24; 314-211 = 103; 417-314 = 103 |

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 12 <br/> 15 | No | No nine-digit magic numbers with sum=12 and diff=15 |