# <p align="center"> C# Basics Exam 11 April 2014 Evening <p>

## Problem 1 – Cinema

Most people like going to the cinema. If you are such person, help the cinema director Kircho solve his financial task.

Kircho is trying to calculate how much his **incomes** are for a single projection, if the movie hall is completely full. He knows the **type of projection** (and how much a ticket for each type costs), the number of **rows** and the number of **columns** in the hall (the cimena hall is rectangular).

There are three types of movies projected in Kircho&#39;s cinema:

- **Premiere** projection – **12.00** leva
- **Normal** projection – **7.50** leva
- **Discount** projection for kids, students and retirees – **5.00** leva

Your task is to calculate the incomes Kircho gets for a single projection full of people. You need to calculate how many people are watching the movie depending on the rows and columns in the hall and find the incomes in levas depending on the type of projection.

### Input

- The input data is read from the console.
- A string representing the type of projectionstays at the first input line. It can be one of the following: &quot; **Premiere**&quot;, &quot; **Normal**&quot;, &quot; **Discount**&quot; (without the quotes).
- The numberf **rows** stays at the second input line.
- The number of **columns** stays at the third input line.
- The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- On the only output line you must print the **incomes** with two digits after the decimal point with &quot;leva&quot; appended at the end (see the example tests). Use &quot; **.** &quot; as decimal separator.

### Constraints

- The **rows** and **columns** are numbers between 1 and 100, inclusively.
- Time limit: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| Premiere <br/> 10 <br/> 12 | 1440.00 leva | Normal <br/> 21 <br/> 13 | 2047.50 leva |

## Problem 2 – Illuminati

The illuminati are an ancient, very secret society that very secretly rules the world. They&#39;ve managed to keep their existence secret by using a very secretive way of communication. Their secret is that they incorporate their secret messages into popular (non-secret) movies.

Your task is to extract the meaning of some movie lines. The messages are actually codes that can be extracted by summing the secret values of every vowel in the message. The values of the vowels are as follows: **A = 65, E = 69, I = 73, O = 79, U = 85.** The values apply for both upper and lowercase letters. For example, &#39; **I am Batman!** &#39; has a total of **4 vowels** : three times &#39; **A** &#39; and one time &#39; **I** &#39; **and their sum is:** 3 \* 65 + 1 \* 73 = 268.

### Input

- The input data should be read from the console.
- The only input line holds the message that has to be deciphered.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data should be printed on the console.
- On the first output line you must print the **number of vowels** in the message.
- On the second output line you must print the **sum of all the vowels** in the message.

### Constraints

- The length of the message will be between 1 and 800 000 characters.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| Listen very carefully, I shall say this only once. | 13 <br/> 933 |
| Heeeeeeere&#39;s JOHNNY! | 9 <br/> 631 |
| Don&#39;t ask me about my business! | 9 <br/> 669 |

## Problem 3 – New House

Little Joro likes to build huts. After he built all the huts in his whole village, he decided to go to the big city and start building houses. But his knowledge of how to do this is limited. Help Joro to design the façade of a beautiful house by printing it to the console. The house must have a roof and one floor. The roof must contains only the symbols &#39; **\*** &#39; and &#39; **-**&#39; and the floor must contains the symbols &#39; **\*** &#39; and &#39; **|** &#39; (see the examples below).

### Input

- The input data should be read from the console.
- At the only input line you are given an integer number **N** (always an **odd number** ) showing the height of the house (without the roof).

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output should be printed on the console.
- You should print the house on the console, just like in the examples below. Each row can contain only the following characters: &quot; **-**&quot; (dash), &quot; **\*** &quot; (asterisk) and &quot; **|** &quot; (pipe).

### Constraints

- The number **N** will be a positive odd integer number between 3 and 101, inclusive.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 3

```
-*-
***
|*|
|*|
|*|
```

#### Input: 5

```
--*--
-***-
*****
|***|
|***|
|***|
|***|
|***|
```

#### Input: 7

```
--*--
-***-
*****
|***|
|***|
|***|
|***|
|***|
---*---
--***--
-*****-
*******
|*****|
|*****|
|*****|
|*****|
|*****|
|*****|
|*****|
```

## Problem 4 – Crossing Sequences

We&#39;re dealing with two sequences: the **Tribonacci sequence** , where every number is the sum of the previous three, and the **number spiral** , defined by walking over a grid of numbers as a spiral (right, down, left, up, right, down, up, left, …) and writing down the current number every time we take a turn. Find the first number that appears in both sequences.

### Example

Let the Tribonacci sequence start with 1, 2 and 3. It will therefore contain the numbers 1, 2, 3, 6, 11, 20, 37, 68, 125, 230, 423, 778, 1431, 2632, 4841, 8904, 16377, 30122, 55403, 101902, and so on.
Also, let the number spiral start with 5 and have a step of 2; it then contains he numbers 5, 7, 9, 13, 17, 23, 29, 37, etc. Since 37 is the first number that is both in the Tribonacci sequence and in the spiral, it is the answer.

![Not fount](/Programming%20Basics/OldExams/images/4.PNG)

#### Input

The input data should be read from the console.

- On the first three lines of input, you will read three integers, representing the three initial numbers of the Tribonacci sequence.
- On the next two lines of input, you will read two integers, representing the initial number and the step of each grid cell for the number spiral.
The input data will always be valid and in the format described. There is no need to check it.

#### Output

The output must be printed on the console.
On the single line of output you must print the smallest number that appears in both sequences. If no number in the range [1 … 1 000 000] exists that appears in both sequences, print "No".

#### Constraints

- All numbers in the input will be in the range [1 … 1 000 000].
- Allowed work time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Input** | **Output** |  
| --- | --- | --- | --- | 
| 1 <br/> 2 <br/> 3 <br/> 5 <br/> 2 | 37 | 1 <br/> 1 <br/> 1 <br/> 1 <br/> 1 | 1 | 
|13 <br/> 25 <br/> 99 <br/> 5 <br/> 2 | 13 | 99 <br/> 99 <br/> 99 <br/> 2 <br/> 2 | No |
