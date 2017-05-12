# <p align="center"> C# Basics Basics November 2014 Lab </p>

## Account Information

Write a program that reads a **first name** , **last name** , **client id** and **account balance,** and prints a text with that information on the console.

## Input

The input data is read from the console.

- The input consists of 4 lines:
  - On the first line you will receive the **first name**
  - On the second line you will receive the **last name**
  - On the third line you will receive the **client** **id**
  - On the last line you will receive the **total account balance**
- The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data must be printed on the console in following format:

```
Hello, <first name> <last name>
Client id: <id>
Total balance: <account balance>
Active: <yes/no>
```

The **account balance should** be rounded to **2 digits** after the decimal separator. Print &quot; **yes**&quot; if the balance is greater or equal to 0, and &quot; **no**&quot; if it is negative.

## Constraints

- .The **client id** will be an integer number in the range [0…2 147 483 647].
- .Time limit: 0.1 seconds.
- .Allowed memory: 16 MB.

## Examples

| Input | Output |   Input | Output |
| --- | --- | --- | --- |
| Pedro <br/> Pedrev <br/> 1352425 <br/> 3200 | Hello, Pedro Pedrev <br/> Client id: 1352425 <br/> Total balance: 3200.00 <br/> Active: yes |  Tashko <br/> Toshov <br/> 3213502 <br/> -5.1301 | Hello, Tashko Toshov <br/> Client id: 3213502 <br/> Total balance: -5.13 <br/> Active: no |

## Nums

Write a program that reads reads numbers **n** and **m**. The program should go through each number in the range [n..m] and print its **square root** ( **√** ) if the number is **even** or **number-2th** if it&#39;s **odd**.

Example: **n** is 5 and **m** is 11, so all the numbers in the range are **5** , **6** , **7** , **8** , **9** , **10** and **11**. 5 is odd, so we print 5 -2th = **25.000**. 6 is even so we print √6 = **2.449** , 7 is odd – 7 -2th = **49.000** , etc.
## Input

The input data is read from the console.

- The input consists of 2 lines:
  - On the first line you will receive the number **n**
  - On the second line you will receive thenumber **m**
- The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data must be printed on the console – each number&#39;s calculation should be printed on a **separate line**. The resulting number should be rounded to **3**  **digits** after the decimal separator.

## Constraints

- The numbers **n** and **m** will be integer numbers in the range [0..100].
- Time limit: 0.1 seconds.
- Allowed memory: 16 MB.

## Examples

| **Input** | **Output** |
| --- | --- |
| 5 <br/> 11 | 25.000 <br/> 2.449 <br/> 49.000 <br/> 2.828 <br/> 81.000 <br/> 3.162 <br/> 121.000 |

## Largest Product of Digits

You are given an integer number. Your task is to **find the largest product of six consecutive digits** of that number and print it on the console. E.g., in the number 1111110 the product of the first six digits is 1 (1\*1\*1\*1\*1\*1 = 1) and the product of the last six digits is 0 (1\*1\*1\*1\*1\*0 = 1), therefore, the output should be 1.

## Input

- The input data is read from the console.
- On the only input line you will be given an integer number.
- The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

- The output data must be printed on the console.
- On the only output line you must print the **largest product of six consecutive digits** found in the input number.

## Constraints

- The **number of digits** of the input number will be in the range [6 … 1000].
- Time limit: 0.25 seconds.
- Allowed memory: 16 MB.

## Examples

| **Input** | **Output** 
| --- | --- | 
| **111111** 0 | 1 |  

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 7316717653133062491922511967442 **657474** 2355349194934 | 23520 | 6\*5\*7\*4\*7\*4 = 23520 <br/> This is the largest product of six consecutive digits. |

## Console Graphics

### One line

Write a program that reads a number **n** and prints two lines with **n \* 2** symbols &#39; **\*** &#39;.

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| 5 | \*\*\*\*\*\*\*\*\*\* <br/> \*\*\*\*\*\*\*\*\*\* | 7 | \*\*\*\*\*\*\*\*\*\*\*\*\*\* <br/> \*\*\*\*\*\*\*\*\*\*\*\*\*\* |

### Bridge

Modify your program to print a bridge. Upload your solution to the Judge System.

**Tips** : Use a **for** loop. Study the bridge dimensions from the output.

#### Input: 5

```
**********
**********
***    ***
***    ***
***    ***
***    ***
~~~~~~~~~~
~~~~~~~~~~
```

#### Input: 9

```
******************
******************
*****        *****
*****        *****
*****        *****
*****        *****
*****        *****
*****        *****
*****        *****
*****        *****
~~~~~~~~~~~~~~~~~~
~~~~~~~~~~~~~~~~~~
```

### Constraints

- **n** will always be an **odd** number in the range [3…49].

## Diamonds

Write a program that prints a **diamond** of given size **n**.

### Input

Input data should be read from the console.

- The only input line will hold the width of the diamond – **n**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data must be printed on the console.

- The output lines should hold the diamond.

### Constraints

- The number **n** **is positive odd integer between 3 and 59**, inclusive.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 5

```
--*--
-*-*-
*---*
-*-*-
--*--
```

#### Input: 7

```
---*---
--*-*--
-*---*-
*-----*
-*---*-
--*-*--
---*---
```