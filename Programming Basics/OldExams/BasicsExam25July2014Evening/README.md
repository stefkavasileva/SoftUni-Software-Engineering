# <p align="center"> C# Basics Exam 25 July 2014 Evening <p>

## Problem 1 – Electricity

In the &quot;Students Town&quot; each flat in the dorms has **8 lamps, each consuming 100.53 Watts** (2 in the kitchen, 3 in the living-room, 1 in the bathroom, 1 in the bedroom and 1 in the lumber-room). Additionally each flat has **8 computers, each consuming 125.90 Watts** (1 in the kitchen, 2 in the living-room, 1 in the bathroom, 3 in the bedroom and 1 in the lumber-room). The lamps and computers in each flat always operate in a strict schedule every day:

- From 14:00 to 18:59 2 lamps + 2 computers are running
- From 19:00 to 23:59 7 lamps + 6 computers are running
- From 00:00 to 08:59 1 lamp + 8 computers are running

Write a program to calculate **how many Watts is the total power consumption** of the dorms at given **time** of the day. You will be given the number of **floors** in the dorms and the **number of flats** at each floor that operate in the specified time.

### Input

The input data should be read from the console. It consists of exactly 3 lines:

- The first line holds the number of floors – **floors**.
- The second line holds the number of flats at each floor – **flats**.
- The third line holds the time of the day in format **hh:mm** – **time**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

Print at the console the total power consumption in format &quot; **X Watts**&quot; where **X** is the total power consumption. Truncate down the result to the nearest **whole number**.

### Constraints

- The number **floors** is a positive integer in the range [1…30].
- The number **flats** is a positive integer in the range [1…222].
- The hours **hh** is a positive integer in the range [0…23]. It might have a leading zero, e.g. &quot;09&quot;.
- The minutes **mm** is a positive integer in the range [0…59]. It might have a leading zero, e.g. &quot;00&quot;.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- | 
| 3 <br/> 40 <br/> 18:00 | 54343 Watts | 24 <br/> 120 <br/> 16:25 | 1304236 Watts | 30 <br/> 222 <br/> 19:30 | 9717672 Watts | 2 <br/> 76 <br/> 9:00 | 0 Watts |

## Problem 2 – Odd and Even Jumps

We are given an input string, e.g. &quot;Software University&quot;. We take its odd and even letters, turned into lowercase:

- dd letters &quot;sfwruiest&quot;
- even letters &quot;taenvriy&quot;

We are also given two numbers: **oddJump** and **evenJump**. We pass through the **odd letters** from left to right and we **sum their ASCII codes** and aggregate the sum to the **result** (initially starting form 0). Through a step of **oddJump** we **multiply** the current result by the ASCII code of the current letter instead of adding it to the result. Finally we print the result as **hexadecimal** number. We do the same for the even letters with a step of **evenJump**. For our example, let&#39;s assume **oddJump** = **3** and **evenJump** = **2**. The calculations are performed as follows:

- dd result = ( ( (+ 115 &#39;s&#39; + 102 &#39;f&#39;) \* 119 &#39;w&#39; + 114 &#39;r&#39; + 117 &#39;u&#39; ) \* 105 &#39;i&#39; + 101 &#39;e&#39; + 115 &#39;s&#39; ) \* 116 &#39;t&#39; = 317362776 = **12EA9258** (hex)
- even result = ( ( + 111 &#39;&#39; \* 116 &#39;t&#39; + 97 &#39;a&#39; ) \* 101 &#39;e&#39; + 110 &#39;n&#39; ) \* 118 &#39;v&#39; + 114 &#39;r&#39; ) \* 105 &#39;i&#39; + 121 &#39;y&#39; = 16235657461 = **3C7B878F5** (hex)

### Input

The input data should be read from the console. It consists of 3 lines:

- The first line holds the **input string**.
- The second line holds the number **oddJump**.
- The third line holds the number **evenJump**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should consist of 2 lines:

- The **odd result** in hexadecimal form in format: „ **Odd: XXX**&quot;.
- The **even result** in hexadecimal form in format: „ **Even: XXX**&quot;.

### Constraints

- The **input string** will consist of only Latin letters and spaces in the range [1…100].
- The numbers **oddJump** and **evenJump** will be integer in the range [1…100].
- The odd and even **results** will be in the range [0…7FFF FFFF FFFF FFFF].
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |   **Input** | **Output** |
| --- | --- | --- | --- | 
| Software University <br/> 3 <br/> 2 | Odd: 12EA9258 <br/> Even: 3C7B878F5 | CSharp Exam SoftUni <br/> 7 <br/> 11 | Odd: FBE2 <br/> Even: 37A |

## Problem 3 – House with a Window

Write a program to print at the console a house of given size N. The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls, the window and the base of the house it build of &#39;\* &#39;. Everything else is filled with &#39; **.** &#39; (see the examples below).

You will be given an integer **N** (N % 4 = 0). The **width** of the house is **(2\*N-1),** the height of the house is **(2\*N+2).**
The **height** of the **roof** is exactly **N lines.** The **base** of the house **height** is **(N+2).** The **window height** is always **(N/2).**
The **window width** is (**N-3).** See the examples below to understand better these formulas.

### Input

- The input data is read from the console.
- The number **N** stays alone at the first line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output data must be printed on the console.
- You should print the house on the console, just like in the examples below. Each row can contain only the following characters: &quot; **.** &quot; (dot) and &quot; **\*** &quot; (asterisk).

### Constraints

- **N** will be an integer number between **4** and **120** and will always be divided by **4 without reminder**.
- Time limit: 0.25 seconds. Allowed memory: 16 MB.

### Examples

#### Input: 4

```
...*...
..*.*..
.*...*.
*.....*
*******
*.....*
*..*..*
*..*..*
*.....*
*******
```

#### Input: 5

```
.......*.......
......*.*......
.....*...*.....
....*.....*....
...*.......*...
..*.........*..
.*...........*.
*.............*
***************
*.............*
*.............*
*....*****....*
*....*****....*
*....*****....*
*....*****....*
*.............*
*.............*
***************
```

#### Input: 12

```
.......*.......
......*.*......
.....*...*.....
....*.....*....
...*.......*...
..*.........*..
.*...........*.
*.............*
***************
*.............*
*.............*
*....*****....*
*....*****....*
*....*****....*
*....*****....*
*.............*
*.............*
***************
...........*...........
..........*.*..........
.........*...*.........
........*.....*........
.......*.......*.......
......*.........*......
.....*...........*.....
....*.............*....
...*...............*...
..*.................*..
.*...................*.
*.....................*
***********************
*.....................*
*.....................*
*.....................*
*......*********......*
*......*********......*
*......*********......*
*......*********......*
*......*********......*
*......*********......*
*.....................*
*.....................*
*.....................*
***********************
```

## Problem 4 – Nakovs Matching

We are given two words **a** and **b**. Each word can be split in several ways into left and right side:

- **a = (aLeft|aRight)**
- **b = (bLeft|bRight**)

The weight **w(s)** of given character sequence **s** is calculated as **sum of the ASCII codes** of its characters. The **Nakov&#39;s distance** between two split words **(aLeft|aRight)** and **(bLeft|bRight**) is defined as:

- **nakovs = w(aLeft) \* w(bRight) - w(aRight) \* w(bLeft)**, as absolute value

We assume that two word splits have **good matching** if their Nakov&#39;s difference is not greater than given limit number **d**. Your task is to write a program that prints all good matchings between given two words **a** and **b** and given limit number **d**.

Example: **a** = &quot; **hello**&quot;, **b** = &quot; **csharp**&quot;, **d** = **20000**. The word **a** can be split in 4 ways: &quot; **h|ello**&quot;, &quot; **he|llo**&quot;,&quot; **hel|lo**&quot; and &quot; **hell|o**&quot;. The word **b** can be split in 5 ways: &quot; **c|sharp**&quot;, &quot; **cs|harp**&quot;, &quot; **csh|arp**&quot;, &quot; **csha|rp**&quot; and &quot; **cshar|p**&quot;. There are 20 possible matchings between the words **a** and **b** , but only 3 of them are good matchings ( **nakovs ≤ d** ):

| (h\|ello) matches (c\|sharp) by 13996 nakovs | w(h) = 104, w(ello) = 428, w(c) = 99, w(sharp) = 542nakovs = abs(104 \* 542 - 428 \* 99) = **13996** ≤ 20000 |
| --- | --- |
| (he\|llo) matches (cs\|harp) by 17557 nakovs | w(he) = 205, w(llo) = 327, w(cs) = 214, w(harp) = 427nakovs = abs(205 \* 427 - 327 \* 214) = **17557** ≤ 20000 |
| (hell\|o) matches (cshar\|p) by 11567 nakovs | w(hell) = 421, w(o) = 111, w(cshar) = 529, w(p) = 112nakovs = abs(421 \* 112 - 529 \* 111) = **11567** ≤ 20000 |

Your task is to write a program that **enters a, b and d** and prints on the console **all good matchings** between **a** and **b**.

### Input

The input data should be read from the console. It consists of 3 lines:

- The first line hold the **first string**.
- The second line holds the **second string**.
- The third line holds the **limit number** **d**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

Print on the console **all good matchings** between these two words in format &quot;**(aLeft|aRight) matches (bLeft|bRight) by XXX nakovs**&quot;, each at separate line. The **order** of the output lines is not important. Print &quot; **No**&quot; if no good matchings are found.

### Constraints

- The input words **a** and **b** consist of small Latin letters only. The **length** of the words is in the range [2…20].
- The number **d** is integer in the range [0…5 000 000].
- Allowed working time: 0.25 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| hello <br/> csharp <br/> 20000 | (h\|ello) matches (c\|sharp) by 13996 nakovs <br/> (he\|llo) matches (cs\|harp) by 17557 nakovs <br/> (hell\|o) matches (cshar\|p) by 11567 nakovs | nice <br/> exam <br/> 100 | (ni\|ce) matches (ex\|am) by 90 nakovs |
