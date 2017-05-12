# <p align="center"> C# Basics Exam 8 November 2014

## Problem 1 – Baba Tinche Airlines

Every month Baba Tinche travels to the Republic of Tajikistan to meet her boyfriend. But the tickets are so expensive that she decides to establish her own airline instead called Baba Tinche Airlines. There are **three travel classes** in Baba Tinche Airlines:

- **First Class** which accommodates **12 passengers**. The ticket priceis **$7000**.
- **Business Class** which accommodates **28 passengers**. The ticket price is **$3500**.
- **Economy Class** which accommodates **50 passengers**. The ticket price is **$1000**.

Please note that **some passengers** are **Frequent Flyers** and **their tickets** are **70% off** ($1000 ticket will cost $300). Also **some passengers purchase a meal** on the flight, which **costs 0.5%** of the **ticket price** for the travel class they are in. Please help Baba Tinche **calculate her income** and **calculate the difference between** her income **and** the maximum possible income(the maximum possible income being**all seats taken **,** no **Frequent Flyers** and **everyone** purchasing meals**). You will be given the number of passengers for each class **, the number of passengers** who are **Frequent Flyers** in that class, and the number of passengers **who purchase a meal** in that class.

### Input

The input data should be read from the console. It consists of exactly 3 lines:

- The **first line** holds the number of **all passengers** in **First Class**
- The **second** line **holds the number of** all passengers **in** Business Class
- The **third line** holds the number of **all passengers** in **Economy Class**
- The **second** and **third** number **on** all lines **will be the** number  of Frequent Flyers **and the number of passengers who will** purchase ****a** meal** in the given class.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of **exactly 2** lines.

- The **first line** will  hold Baba Tinche&#39;s income **cast to an integer**
- The **second** line **holding the difference between the** maximum ****possible**** profit **and baba Tinche&#39;s** actual ****profit**** cast to an integer

### Constraints

- The **first number** in the **first line** will be in the range [0…12].
- The **first number** in the **second line** will be in the range [0…28].
- The **first number** in the **third line** will be in the range [0…50].
- The **second and third numbers** n all lineswill be less or equal to the **first** number.
- Allowed memory: 16 MB. Allowed working time: 0.25 seconds.

### Examples

| **Input** | **Output** |   
| --- | --- |
| 6 1 2 <br/> 21 8 7 <br/> 44 12 17 | 126877 <br/> 106283 |
| 8 2 1 <br/> 26 4 15 <br/> 50 16 23 | 166612 <br/> 66548 | 
|2 0 0 <br/> 2 0 0 <br/> 2 0 0 | 23000 <br/> 210160 | 
|11 4 6 <br/> 24 6 10 <br/> 38 2 5 | 163710 <br/>69450 |

## **Problem 2 – Numerology**

Numerology involves a lot of repeated calculations, but as a programmer you can automate this process and earn some easy cash! You will be given the **birthdate** and **username** of a random fellow student. Your task is to calculate a **celestial** **number**. Below is a description of the process, see the example to understand your task better.

First, **multiply** together the numbers representing the **day** , **year** and **month** of the birthdate. Numerologists love odd numbers, so if the **month** is an **odd** number, you should **square** the result of the **multiplication**. Next, **add** to the result **each** digit (&#39;0&#39; = 0, &#39;1&#39; = 1… &#39;9&#39; = 9) **or the** position in the English alphabet of each letter in the username – e.g.**&quot;a&quot; = 1, &quot;b&quot; = 2 **… &quot;** z&quot; = 26** **.** Capital **letters weigh** twice **as much - the letter**&quot;A&quot; **will add** 1\*2 to the sum,**&quot;Z&quot; **will add** 2\*26**, etc.

13 is a sacral number and your celestial number should be between **0 and 13 inclusive**. So, if the resulting number is **greater** than **13** you should keep **adding** its **digits** together until you get the coveted celestial number in its final form. Then all you have to do is print it to the console! Whew! Numerology…

## **Input**

The input data is read from the console.

- On the only input line you will be given **a date** in the format [**day.month.year]** and a **username, separated by a single space.**

The input data will always be valid and in the format described. There is no need to check it explicitly.

## **Output**

- The output data must be printed on the console.
- On the only output line you must print the calculated **celestial number.**

## **Constraints**

- The **date** will be in format **dd.mm.yyyy** and between 01.01.1900 and 31.12.2014.
- The **username** will be between 4 and 20 characters long and will contain only **digits (0-9) and upper-case and lower-case letters from the English alphabet** (no hyphens or non-English letters).
- Time limit: 0.25 seconds. Allowed memory: 16 MB.

## **Examples**

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 14.03.1990 Panayot | 9 | 14 \* 3 \* 1990 = 83,580;03 (odd month) <br/>  =&gt; 83,580 \* 83,580 = 6,985,616,400; <br/> 6,985,616,400 + 2 \* 16 (P) + 1 (a) + 14 (n) + 1 (a) + 25 (y) + 15 (o) + 20 (t) = 6,985,616,508  ( &gt; 13); <br/> 6 + 9 + 8 + 5 + 6 + 1 + 6 + 5 + 0 + 8 = 54   (&gt; 13); <br/> 5 + 4 = 9 (∈ [0, 13] =&gt; Done!) |

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | 
| 01.01.1914 g0g0 | 5 | 25.05.1997 P360 | 6 |

## Problem 3 – RockLq

You will be given an integer **N**. The **width** of the rocklq is **(3\*N).** The **height** of the rocklq is **(2\*N).** Check the examples below to understand your task better.

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
.....*****.....
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
.......*******.......
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

### Input: 9

```
.........*********.........
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

## Problem 4 – Gambling

Do you think you can use your newly acquired coding skills to decide whether a game is worth playing?

You&#39;ll be provided with some **amount of cash C** you may use to bet on a single hand of a card game called Vokan. You will be shown the **house&#39;s hand** consisting of **four** cards(drawn from a standard deck of 52 cards). The hand&#39;s strength is determined solely by the face values of the cards (suits are ignored). Cards with faces **2 to 10** increase the hand&#39;s strength with their numeric value. **J, Q, K and A** add **11, 12, 13** and **14** points respectively. Then, the four cards are shuffled back into the deck. At this point you&#39;ll have to decide whether you want to play or not. Continuing the game means you&#39;ll draw four cards from the deck, **one at a time**, shuffling back each card before drawing the next; you will then calculate your cards&#39; combined strength and compare it to the house&#39;s result.

You&#39;ll need to figure out the **ratio** between the number of **winning** hands(hands that are**stronger**than the house&#39;s) and the**total **number** of all **possible**** hands **in order to find** the probability **of you beating the house. If the probability is** **&lt; 50%** you should quit, otherwise the game is worth the risk.

Assume you bet your entire cash deposit **C** and the bank matches your bet **1:1** ; thus the pot&#39;s value will be **2\*C**. Your **expected winnings** are calculated as **(% probability of winning) \* (pot amount).**

The output should consist of two lines. On the first line, **print your decision** - &quot;FOLD&quot; if the game isn&#39;t worth the risk, or &quot;DRAW&quot; otherwise. On the second line, print your **expected winnings** rounded to two digits after the decimal point (you should use &quot;.&quot; as the decimal separator).

### Input

The input data should be read from the console.

- At the **first line** you&#39;ll be given some amount of **cash C.**
- At the **second line** you&#39;ll be given **the house&#39;s hand** as a sequence of four cards (faces only), each separated by a single whitespace.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of **exactly 2 lines** :

- The **first line** should hold a string – one of the two: &quot;FOLD&quot; or &quot;DRAW&quot;.
- The **second line** should hold your expected winnings of the game, rounded to two decimal points.

### Constraints

- The **number C** will be in the range [1.00 … 1 000 000.00].
- The **house&#39;s hand** will have exactly four cards (faces only) taken from a standard 52-card deck.
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 100 <br/> 2 7 9 A | FOLD <br/> 94.86 | House strength = 2 + 7 + 9 + 14 = 32. <br/> Under the game&#39;s rules, the probability of drawing a winning hand (strength &gt; 32) is ~47.428% (&lt; 50% =&gt; FOLD); <br/>  expected winnings: ~ 200\*47.428% = 94.856… |

| **Input** | **Output** | **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- |
| 203.03 <br/> A A K 3 | FOLD <br/> 19.41 |  5 <br/> 8 4 Q 10 | FOLD <br/> 3.74 |   150000.37 <br/> 10 4 4 J | DRAW <br/> 187924.56 |
