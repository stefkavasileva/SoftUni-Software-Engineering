# <p align="center"> C# Basics Exam 26 August 2014 <p>

## Problem 1 – Tic-Tac-Toe Power

You are given tic-tac-toe board ( **3 columns and 3 rows** ) like the one the right. As inputs you will be given the **X** and **Y**** coordinates **of one of the cells. Each of the** cells **in the field has an** index **and a** value**(look at the examples on the right). You will be given the value of the**first ****cell V** ( **index1** ). Each of the next cells will have value **greater by 1** than the **previous**. **Example** : if value=80, then index1=80, index2=81, index3=82, ..., index9=89. Your task is to print on the console the **value** of the cell **C** raised to the **power** of its **index** : **C**  **index**. Look at comments in the examples below to understand your task better.

![Not fount](/Programming%20Basics/OldExams/images/17.PNG)

### Input

The input data should be read from the console.

- At the **first line** you will be given the **X**
- At the **second line** you will be given the **Y**
- At the **third line** an integer number **V** will be given,specifying the value of the first cell.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of **1** **line**:

- Print the **value** **C** of the cell at position {X, Y} raised to the power of its **index**.

### Constraints

- The **X** and **Y** inputs will be integers in the range [0…2].
- The **V** input will be an integer in the range [0…100].
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Board** | **Comments** |
| --- | --- | --- | --- |
| 1 <br/> 1 <br/> 10 | 537824 |    0    1    2 <br/> 0 \|10 \| 11 \| 12  <br/> 1 \|13 \| **14** \| 15 <br/> 2 \|16 \| 17 \| 18 | The cell with coordinates {x=1, y=1} has an index 5. Cell at index 5 has value = 14. 14-5 = 537824  |

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | 
| 2 <br/> 1 <br/> 5  | 1000000 | 0 <br/> 0 <br/> 1  | 1 | 2 <br/> 0 <br/> 88  | 729000 |

## Problem 2 – Jumping Sums

You are given a string **S** consisting of **N** numbers. Each of them have indexes ranging from **0 to N-1** and a **value** (integer number). You are also given a number **J** which represents the number of **jumps** to be made. **Each** of the **numbers** jumps J times to the right. Your task is to find all sums after each of the numbers has made its **J jumps**. The **value of the number** and the **current index** show the **next index** that we have to jump to (_e.g. index = 3, value = 4, nextIndex = 3+4 =7_). **Example:** if **S = “2 1 2”** and **J=2**. The first number **“2”** (**index0**) (**sum1 += 2**) should **jump 2 positions to the right**, so it jumps to the last number (index2). This index holds value **2** (sum1 += 2), so it jumps **2 indexes to the right**. In this case, we **don’t have enough indexes** to the right so we restart from the **beginning** and the jump will land on index1 (sum1 += 1, sum1 = 5). For the second sum **we start from the second** position (index1, sum2 += 1). The next index is **1 position on the righ*t (index2, sum2 += 2). The next position is **2 positions on the right** with restart from the beginning (index1, sum2 += 1). Finally **sum2 = 4**. We repeat that process for every number in S. Your task is to find the biggest sum after every number has made **enough jumps**. Look at the picture to understand your task better.

![Not fount](/Programming%20Basics/OldExams/images/18.PNG)

### Input

The input data should be read from the console. It consists of 2 lines:

- At the **first line** you will be given string **S** holding integer numbers separated by a **single space**.
- At the **second line** you will be given **integer J** representing the number of jumps each number should make.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of exactly **1** line:

- On the **first line** print the **maximal** **sum** in the format &quot; **max sum = {0}** &quot;.

### Constraints

- The string **S** will hold maximum of 100 numbers in the range [0…1000]
- The **J** input  value will be an integer in the range [1…10000]
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- |
| 1 2 3 5 <br/> 4  | max sum = 15 | 165 782 15 77 15 20 <br/> 102 | max sum = 23229 |

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| 2 7 4 10 6 9 <br/> 14  | max sum = 90 | 1 1 1 1 1 1 1 <br/> 50 | max sum = 51 |

## Problem 3 – Star

You will be given an integer **N**. Your task is to **draw a star on the console**. The **width** of the star is **(2\*N+1).** The **height** of the star is **(N\*2 - (N/2-1))**. The **top** and the **middle** part **height** is exactly **(N/2)**.The height of the legs is **(N/2+1).** Check the examples below to understand your task better.

### Input

The input data is read from the console. The number **N** stays alone at the first line. The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- You must print at the console a star of size **N** following the formulas above and the examples below.

### Constraints

- **N** will be a number between **6** and **36** and will be **an even number**.
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

#### Input: 6

```
......*......
.....*.*.....
....*...*....
****.....****
.*.........*.
..*.......*..
...*..*..*...
..*..*.*..*..
.*..*...*..*.
****.....****
```

#### Input: 8

```
........*........
.......*.*.......
......*...*......
.....*.....*.....
*****.......*****
.*.............*.
..*...........*..
...*.........*...
....*...*...*....
...*...*.*...*...
..*...*...*...*..
.*...*.....*...*.
*****.......*****
```

#### Input: 10

```
..........*..........
.........*.*.........
........*...*........
.......*.....*.......
......*.......*......
******.........******
.*.................*.
..*...............*..
...*.............*...
....*...........*....
.....*....*....*.....
....*....*.*....*....
...*....*...*....*...
..*....*.....*....*..
.*....*.......*....*.
******.........******
```

## Problem 4 – Winning Numbers

We are given a string **S** consisting of **capital** and **non-capital** **letters**. Every letter has a value equal to its position in the English alphabet (**a=1, b=2, …, z=26**). First you have to calculate the **sum** of all letters **letSum**. Then, find all** 6-digits numbers**in range [**000 000 **…** 999 999**] called**winning numbers **for which the following is true: the** product of **the** first ****three** digits is **equal** to the product of the **second**** three **digits, and both of those are equal to** letSum **. Your task is to print on the console all** winning numbers.

### Input

The input data should be read from the console. It consists of 1 line:

- On the **first** line you will be given a **string** **S** which will only consist of **lower** and **capital** case letters.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console as a sequence of **winning numbers** in **format abc-def** in **ascending order**. Each winning number should stay alone on a separate line. In case there are no winning numbers, print &quot; **No**&quot;.

### Constraints

- The **string S** will have maximal length of 150 characters.
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |  
| --- | --- | --- | 
| aa | 112-112 <br/> 112-121 <br/> 112-211 <br/> 121-112 <br/> 121-121 <br/> 121-211 <br/> 211-112 <br/> 211-121 <br/> 211-211 | The sum of aa = **2**. The first output has product of the first 3 digits 1\*1\*2 = 2 and second 3 digits have product 1\*1\*2 = 2. <br/>  The same product 2 is obtained in all other outputs. |

| **Input** | **Output** | **Input**|**Output**|
|---|---|---|---|
| xz | 255-255 <br/> 255-525 <br/> 255-552 <br/> 525-255 <br/> 525-525 <br/> 525-552 <br/> 552-255 <br/> 552-525 <br/> 552-552|cobazaa|177-177 <br/> 177-717 <br/> 177-771 <br/> 717-177 <br/> 717-717 <br/> 717-771 <br/> 771-177 <br/> 771-717 <br/> 771-771|

