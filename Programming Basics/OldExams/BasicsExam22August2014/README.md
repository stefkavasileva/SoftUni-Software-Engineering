# <p align="center"> C# Basics Exam 22 August 2014 <p>

## Problem 1 – Tables

Gosho is very good table **maker**. He has **4 bundles** full of **table**** legs **. Every bundle holds** packets **. The** first bundle **holds** packets **with** 1 ****leg** , the **second bundle** holds packets with **2 legs** and the **other 2 bundles** hold packets with **3 and 4 legs** respectively. Example: (**bundle3 = 5 packets \* 3 legs = 15 legs)**. He also has **T** amount of **table tops** and **N** amount of tables that **need**** to be made **. Your task is to** calculate **how many tables can Goshko make and whether he has made** more **,** less **or** equal **amount of the needed tables. Every table is made from** 4 legs **and** 1 table top.  Check the examples below to understand your task better.

### Input

The input data should be read from the console.

- At the **first four lines** you will be given integer numbers  representing how many **packets** each **bundle** has
- At the **fifth line** an integer number **T** specifying the amount of **table** **tops**.
- At the **sixth line** an integer number **N** specifying the amount of tables **to be made**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of **1**** or 2** lines:

- Print &quot; **more: {0}** &quot; on the **first** line **, if the** tables ****made** are **more** than the **tables**** needed.
  - Print the materials **left** on the **second line** : &quot; **table tops left: {0}, legs left: {1}** &quot;
- Print &quot; **less: {0}** &quot;, if the **tables** made **are** less **than the** tables **needed**.
  - Print the materials **needed**  to create all needed tables: &quot; **tops needed: {0}, legs needed {1}&quot;**
- Print &quot; **Just enough tables made: {0}** &quot;, if the **tables** made **are** equal **with the** tables **needed**.

### Constraints

- The **inputs** will be an integers in the range [0…999 999 999].
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 <br/> 1 <br/> 1 <br/> 2 <br/> 2 <br/> 3 | less: -1 <br/> tops needed: 1, legs needed: 0 | Bundle1+Bundle2+Bundle3+Bundle4 =(1\*1) + (1\*2) + (1\*3) + (2\*4) = 14 legs, 2 table tops and 3 tables to be made. To make 3 tables Gosho needs 12 legs and 3 table tops. He can&#39;t make enough tables. He has enough legs but needs 1 more table top. |

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| 2 <br/> 3 <br/> 4 <br/> 5 <br/> 10 <br/> 8 | more: 2 <br/> tops left: 2, legs left: 8 | 1 <br/> 1 <br/> 1 <br/> 1 <br/> 1 <br/> 1 | Just enough tables made: 1 |

## Problem 2 – Book Orders

Bai NakMan has his own book store business. He often makes orders for new books, but the procedure is kind of complicated. You will be giventhe **number of orders N.** Each **order** holds, number of **packets, amount of books** per packet and **price**** per book. **Depending on the** number **of** packets **, you get different discount ranging from** 5% **to** 15% **.  If the packets in the order are less than** 10,**there is no discount. Otherwise they have the following discounts (**10-19 packets = 5% discount, 20-29 = 6%, 30-39 = 7%, ..., 100-109 = 14%**)**. **If the packets are** 110 or more, **there is** 15% discount **for all books**. **Your task is to sum how many books Bai NakMan has bought and the** end ****price** of **all**** books. Check the examples below to understand your task better.

### Input

The input data should be read from the console.

- At the **first line** you will be given integer number **N** representing the number or orders.
- At the **next 3\*N lines** you will be given the following inputs:
  - **Book price**
  - **Number of packets**
  - **Books per packet**

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of exactly **2** lines:

- On the **first line** print the amount of all bought books
- On the **second line** print the price of all books bough, rounded to the second number after the decimal point

### Constraints

- The number of **orders** , **packets** and **books**** per ****packet** will all be integers in range [0…10000].
- The **book price** will always be a floating-point number in range [[±5.0 × 10-(-324) … ±1.7 × 10-308]
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 <br/> 25 <br/> 15 <br/> 10.00 | 375 <br/> 3525.00 | 1 order with 25 packets, each packet holds 15 books (15\*25 = 375 books) costing 10.00. For the 25 packets we have 6% discount making each book costing 9.4. All books cost 375 \* 9.4 = 3525.00 |

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |  
| --- | --- | --- | --- | ---|---|
| 2 <br/> 60 <br/> 10 <br/> 8.00 <br/> 150 <br/> 100 <br/> 15.90 | 15600 <br/> 207045.00 | 2 <br/> 100 <br/> 4 <br/> 6.88 <br/> 188 <br/> 7 <br/> 10.88 | 1716 <br/> 14537.09 |2 <br/> 5 <br/> 4 <br/> 7.24 <br/> 64 <br/> 8 <br/> 9.86 | 532 <br/> 4688.29 |

## Problem 3 – Car

You will be given an integer **N**. The **width** of the car is **(3\*N).** The **height** of the caris **(3\*N/2-1).**  The **roof** height **and the** body height is exactly (**N/2).   **The car&#39;s wheels** height **are** (N/2-1).** Check the examples below to understand your task better.

### Input

- Input data is read from the console.
- The number **N** stays alone at the first line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- You must print at the console a car of size **N** following the formulas above and the examples below.

## Constraints

- **N** will be a number between **6** and **36** and will be **an even number**.
- Time limit: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 10

```
..........**********..........
.........*..........*.........
........*............*........
.......*..............*.......
......*................*......
******..................******
*............................*
*............................*
*............................*
******************************
.....*....*........*....*.....
.....*....*........*....*.....
.....*....*........*....*.....
.....******........******.....
```

#### Input: 8

```
........********........
.......*........*.......
......*..........*......
.....*............*.....
*****..............*****
*......................*
*......................*
************************
....*...*......*...*....
....*...*......*...*....
....*****......*****....
```

#### Input: 6

```
......******......
.....*......*.....
....*........*....
****..........****
*................*
******************
...*..*....*..*...
...****....****...
```

## Problem 4 – Chess Queens

We are given a chess board of size **N \* N**. The only figures we have on the
chess board are two queens. The queen in chess can move in **horizontal** , **vertical** and **diagonal** directions.We are also given a **number D** whichrepresents the distance between the two queens. The distance is measured by **D squares away**. All positions on the chessboard are represented with numbers and letters **(a1, a2… a8, b1-b8, c1-c8, …, h1-h8)**. Example: if **N=16** , the numbers on the board will be represented with integers **(1-16)** and letters **(a-o)**. Your task is to find **all**** couples **of queens where the queens stay either on the** same ****vertical** , **horizontal** or **diagonal** , at **distance**** D **. See the diagram aside to understand your task better. The green queens meet the condition of** 2** blocks away but the red queens aren&#39;t.

![Not fount](/Programming%20Basics/OldExams/images/16.PNG)

### Input

The input data should be read from the console. It consists of 2 lines:

- The first line holds an integer number **N** representing the **width** and **height** of the **chess** **board**.
- The second line holds an integer number **D** representing the **distance** that we should be looking for.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console as a sequence of chess position in the **format [qu****е ****en1X, qu**** е ****en1Y  - qu**** е ****en2X, qu**** е****en2Y]**. The order of the output is **not important.** Each string should stay on a separate line. In case they are no valid positions print &quot; **No valid position**&quot;.

### Constraints

- The **numbers N** and **D** will be **integers** in the range [0…20].
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | --- | --- |
| 3 <br/> 1 | a1 - a3 <br/> a1 - c1 <br/> a1 - c3 <br/> a2 - c2 <br/> a3 - a1 <br/> a3 - c1 <br/> a3 - c3 <br/> b1 - b3 <br/> b3 - b1 <br/> c1 - a1c1 - a3 <br/> c1 - c3 <br/> c2 - a2 <br/> c3 - a1 <br/> c3 - a3 <br/> c3 - c1 | 42 | a1 - a4 <br/> a1 - d1 <br/> a1 - d4 <br/> a2 - d2 <br/> a3 - d3 <br/> a4 - a1 <br/> a4 - d1 <br/> a4 - d4 <br/> b1 - b4 <br/> b4 - b1 <br/> c1 - c4 <br/> c4 - c1 <br/> d1 - a1 <br/> d1 - a4 <br/> d1 - d4 <br/> d2 - a2 <br/> d3 - a3 <br/> d4 - a1 <br/> d4 - a4 <br/> d4 - d1 | 87 | No valid positions |

