# <p align="center"> C# Basics December 2014 Lab <p>

## Problem 1 – Count Beers

Nakov is keen football fаn and he is passionate about the upcoming FIFA World Cup tournament. A month before the tournament Nakov started his preparations with a few **stacks of beer** and a few **single beer bottles**. You are given a list of Nakov&#39;s stacks and Nakov&#39;s single beers. Help him to count how many stacks of beer and how many additional single bottles he has for the tournament. Assume that **a stack of beer holds 20 beers**.

#### Input

The input comes from the console as list of beers and stacks of beer, each at a single line, ending with the text &quot; **End**&quot; at the last line. Each line (except the last) come in format &quot; **count measure**&quot; where **count** is a positive integer and measure is either &quot; **stacks**&quot; or &quot; **beers**&quot; (see the examples below).

The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

Print at the console the total number of stacks and the number of single beers that Nakov has in the following format: &quot; **x stacks + y beers**&quot;, where **x** is an integer number and **y** is an integer number, less than 20.

#### Constraints

- The **count** will be an integer number in the range [1…99].
- The **measure** is either &quot; **stacks**&quot; or &quot; **beers**&quot;.
- The number of input lines will be in the range [1..999].
- Time limit: 0.3 sec. Memory limit: 16 MB.

#### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| 4 stacks <br/> 12 beers <br/> 10 beers <br/> 1 stacks <br/> 1 beers <br/> End | 6 stacks + 3 beers | 41 beers <br/> 1 stacks <br/> 19 beers <br/> End | 4 stacks + 0 beers |

## Problem 2 – Fun with Matrices

Let&#39;s have some fun! You are given a 4x4 matrix of numbers. At the console you&#39;ll receive a **start value** , a **step** and a number of **operations to perform**. The start value shows the value of cell [0, 0]. Moving from left to right along each row you obtain each cell&#39;s value by incrementing the previous cell&#39;s value by the step.

Then, you&#39;ll receive some commands from the console in one of the following formats:

- **&quot;[row] [col] multiply [num]&quot;** – upon receiving this command you should multiply the value of the specified cell with coordinates [row, col] by [num];
- **&quot;[row] [col] sum [num]&quot;** – add the value of [num] to the value of the specified cell;
- **&quot;[row] [col] power [num]&quot;** – raise the value of the cell to the power [num];
- **&quot;Game Over!&quot;** – denotes the end of input.

After the game is over, you need to check the sum of cell values on each row, column and the two diagonals and print on the console one of the following (whichever has the **largest sum** ):

- **&quot;ROW[index] = sum&quot;**
- **&quot;COLUMN[index] = sum&quot;**
- **&quot;LEFT-DIAGONAL = sum&quot;**
- **&quot;RIGHT-DIAGONAL = sum&quot;**

The index is the **index** of the row/column with biggest sum and is surrounded with square brackets at the output, **sum** is the sum itself. **Left-diagonal** is the diagonal starting at [0, 0] and ending on [3, 3], **right-diagonal** is the diagonal starting at [3, 0] and ending at [0, 3].

#### Input

- The input data should be read from the console.
- The first input line holds **the start number**.
- The second input line holds **the step**.
- On the next lines you&#39;ll receive **orders in the described formats,** ending with the string &quot;Game Over!&quot;
- The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

- The output data should be printed on the console.
- On the only output line you must print the **row, column or diagonal with the largest sum and the sum rounded to two digits after the decimal sign**. Use dot (&quot; **.**&quot;) as the decimal separator.
- In case there are two equal values **priority** is as follows: rows (upper-most), columns (left-most), left diagonal, right diagonal.

#### Constraints

- All numbers are in the range [±5.0 × 10-(-324) ...±1.7 x 10-308
- The **[row]** and **[col]** indexes will be valid, i.e. between [0 … 3].
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

#### Examples

| **Input** | **Output** | **Visualization**|
| --- | --- |---|
|5.3 <br/> -2.09 <br/> 2 3 multiply -0.8 <br/> Game Over!|ROW[0] = 8.66|![Not fount](/Programming%20Basics/OldExams/images/1.PNG)|

| **Input** | **Output** |
| --- | --- |
| 55 <br/> 0.1 <br/> 0 0 power -2.4 <br/> 2 1 multiply 0 <br/> 0 2 sum 777 <br/> 3 1 power 2.4 <br/> Game Over! | ROW[3] = 16062.62 |
| -2444411 <br/> 500000 <br/> 2 2 power 3 <br/> 2 3 multiply -0.05 <br/> 2 0 multiply 1.11 <br/> 0 0 sum 13.99 <br/> Game Over! | COLUMN[2] = 16690641554532500000.00 |
| 0.01 <br/> 0.01 <br/> 0 0 multiply 0.01 <br/> 0 1 multiply -0.01 <br/> 0 2 multiply 0.01 <br/> 0 3 multiply 0.01 <br/> 1 2 sum -10 <br/> 2 0 sum -10 <br/> 3 3 sum -10 <br/> 2 2 sum -10 <br/> 1 1 sum -10 <br/> Game Over! | ROW[0] = 0.00 |

## Problem 4 – Tetris

![Not fount](/Programming%20Basics/OldExams/images/2.PNG)

In the classical Tetris game we have 7 Tetris figures (also called &quot; **tetriminos**&quot;), shown at the figure on the right: **I** , **L** , **J** , **O** , **Z** , **S** and **T**. You are given a rectangular Tetris **game field** consisting of full end empty cells. Your task is to write a JavaScript function to **count the number of each of these 7 tetriminos** (with overlapping, without rotations). For example, on the figure below we have a game field with 2 &quot; **I**&quot;, 1 &quot; **L**&quot;, 5 &quot; **J**&quot;, 3 &quot; **O**&quot;, 3 &quot; **Z**&quot;, 4 &quot; **S**&quot; and 3 &quot; **T**&quot; figures on it.

![Not fount](/Programming%20Basics/OldExams/images/3.PNG)

#### Input

The input will be read from the console. Each game field line holds only two letters: &#39; **-**&#39; and &#39; **o**&#39; (empty and full cells). All game field lines have the same length. An **empty line** denotes the **end** of the input. The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

Print at the console the number of **I** , **L** , **J** , **O** , **Z** , **S** and **T** tetriminos found in the game field (with overlapping and without rotations) in the same format like in the sample output below.

#### Constraints

- The **size of the game field** is in the range [2…100].
- All **input lines** have the same length and consist only of &#39; **-**&#39; and &#39; **o**&#39; (empty and full cells).
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

#### Examples

| **Input** | **Output** |
| --- | --- |
| 5 7 <br/> --o--o- <br/> --oo-oo <br/> ooo-oo- <br/> -ooooo- <br/> ---oo-- | I:2, L:1, J:5, O:3, Z:3, S:4, T:3 |

| **Input** | **Output** |
| --- | --- |
| 3 3 <br/> -oo <br/> ooo <br/> ooo | I:0, L:1, J:2, O:3, Z:1, S:2, T:1 |

