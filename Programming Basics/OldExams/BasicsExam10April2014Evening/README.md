# <p align="center"> C# Basics Exam 10 April 2014 Evening <p>

## Problem 1 – Volleyball

Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he is able to **play only in the holidays** and in the **weekends**. Vladi plays in **2/3 of the holidays** and each **Saturday** , but **not every weekend** – only when he is **not at work** and only when he is **not going to his hometown**. Vladi goes at his hometown **h** weekends in the year. The other weekends are considered &quot; **normal**&quot;. Vladi is **not at work in 3/4 of the normal weekends**. When Vladi is at his hometown, he always plays volleyball with his old friends once, at **Sunday**. In addition, if the year is **leap** , Vladi plays volleyball **15% more times** additionally. We assume the year has **exactly 48 weekends** suitable for volleyball.

Your task is to write a program that calculates **how many times Vladi plays volleyball** (rounded down to the nearest integer number).

### Input

The input data should be read from the console. It consists of three input values, each at separate line:

- The string &quot; **leap**&quot; for leap year or &quot; **normal**&quot; for year that is not leap.
- The number **p** – number of **holidays** in the year (which are not Saturday or Sunday).
- The number **h** – number of weekends that Vladi spends in his **hometown**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- On the only output line you must print an integer representing how many times Vladi plays volleyball for a year.

### Constraints

- The numbers **p** is in range [0...300] and **h** is in range [0…48].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| leap <br/> 5 <br/> 2 | 45 | 48 weekends total in the year, split into: <br/> - 2 hometown weekends 2 Sundays **2** plays <br/> - 46 normal weekends 46 \* 3 / 4 **34.5** plays <br/> 4 holidays  5 \* 2/3  **3.33** playsLeap year  additional 15% \* 39.83  **5.97** playsTotal plays = **45.8** plays  **45** (rounded down) |

| **Input** | **Output** |  **Input** | **Output** |   **Input** | **Output** |  
| --- | --- | --- | --- | --- | --- |
| normal <br/> 3 <br/> 2 | 38 | leap <br/> 2 <br/> 3 | 43 | normal <br/> 11 <br/> 6 | 44 | 

## Problem 2 – Odd / Even Sum

You are given a number **n** and **2\*n** numbers. Write a program to check whether **the sum of the odd numbers is equal to the sum of the even n numbers**.The first number is considered odd, the next even, the next odd again, etc. Print as result &quot;Yes&quot; or &quot;No&quot;. In case of **yes** , print also the sum. In case of **no** , print also the difference between the odd and the even sums.

### Input

The input data should be read from the console.

- The first line holds an integer **n** – the count of numbers.
- Each of the next **2\*n** lines holds exactly one number.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output must be printed on the console.
- Print &quot; **Yes, sum= S** &quot; where S **is the sum of the odd** n **numbers in case of the sum of the odd** n **numbers is equal to the sum of the even** n** numbers.
- Otherwise print &quot; **No, diff=** D **&quot; where** D **is the difference between the sum of the odd** n **numbers and the sum of the even** n **numbers.** D **should always be a** positive number.

### Constraints

- The number **n** is integer in range [0...500].
- All other numbers are integers in range [-500 000 ... 500 000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- |
| **4** <br/>  3  <br/> **4** <br/>  -1  <br/> **-1** <br/>  2 <br/>  **1**  <br/> 1 <br/>  **1** | Yes, sum=5 | **3** <br/>  1 <br/>  **2** <br/>  3 <br/>  **1**  <br/> 2  <br/> **2** | No, diff=1 | **2**  <br/> 1  <br/> **0**  <br/> 1 <br/>  **0** | No, diff=2 |

## Problem 3 – Eclipse

Write a program to print a figure at the console in the form of sunglasses for watching the solar eclipse.

### Input

- The input data should be read from the console.
- You have an integer number **N** (always an **odd number** ) specifying the height of sunglasses.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console.

You should print the sunglasses on the console. The sunglasses consist of three parts: **frames** , **lenses** and a **bridge** (the connection between the two frames). Each frame&#39;s width is double the height N and should be printed using the character &#39; **\*** &#39; (asterisk) without the corners which should be printed with &#39;&#39; (space). Print the lenses with the character &#39; **/** &#39;. Finally, connect the two frames with a bridge that is of size N-1, using the character &#39; **-**&#39;. Leave the rest of the space between the frames blank.

### Constraints

- The number **N** will be a positive **odd integer** number in range [3…101].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

##### Input: 3

```
 ****    **** 
*////*--*////*
 ****    ****
```

##### Input: 7

```
 ************        ************
*////////////*      *////////////*
*////////////*      *////////////*
*////////////*------*////////////*
*////////////*      *////////////*
*////////////*      *////////////*
 ************        ************ 
```

## Problem 4 – Hayvan Numbers

Hayvan often plays with numbers. His recent game was to play with 9-digit numbers and calculate their sums of digits, as well as to split them into triples with special properties. Help Hayvan to find a very special set of numbers called &quot; **Hayvan numbers**&quot;.

Hayvan numbers are 9-digit numbers in format **abcdefghi** , such that their sub-numbers **abc** , **def** and **ghi** have a difference **diff** (ghi-def = def-abc = diff), their sum of digits is **sum** and **abc &lt; def** &lt; **ghi** , where each digit **a** , **b** , **c** , **d** , **e** , **f** , **g** , **h** and **i** is in range [5…9].

Your task is to write a program to print all Hayvan numbers for given **sum** and **diff** in increasing order.

### Input

- The input data should be read from the console.
- The number **sum** stays at the first line.
- The number **diff** stays at the second line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Print Hayvan numbers matching given difference **diff** and given sum of digits **sum** , in increasing order, each at a separate line. In case no Hayvan numbers exits, print &quot; **No**&quot;.

### Constraints

- The number **sum** will be a positive **integer** number in the range [0…100].
- The number **diff** will be a positive **integer** number in the range [0…1000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 63 <br/> 201 | 567768969 <br/> 576777978 <br/> 585786987| 5+6+7+7+6+8+9+6+9 = 63; 768-567 = 201; 969-768 = 201 <br/> 5+7+6+7+7+7+9+7+8 = 63; 777-576 = 201; 978-777 = 201 <br/> 5+8+5+7+8+6+9+8+7 = 63; 786-585 = 201; 987-786 = 201 |

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| 75 <br/> 1 | 897898899 <br/> 987988989 <br/> 996997998 | 93 <br/> 10 | No |