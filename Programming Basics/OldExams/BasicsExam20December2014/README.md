# <p align="center"> C# Basics Exam 20 December 2014 <p>

## Problem 1 – Piggy Bank

Anastas wants to buy himself a tank to drive around the streets of Sofia (he&#39;s a fan of the classic game Carmageddon). He&#39;s saving up and he needs your help to keep track of his progress.

**Every day** in a given month **he saves up 2 leva** and puts them in his piggy bank. **Unless there is a party** that day – he **needs** **5 leva** to buy vodka on a party day, so he **takes them out of the piggy bank**.

You will be given **the tank&#39;s price and the number of party days in a month** , each on a separate line. Assume **each month has 30 days** and **each year has 12 months**. Calculate how many years and months Anastas will need in order to save enough to buy his very own tank and print the result on the console in the format **&quot;X years, Y months&quot;**. In case he isn&#39;t saving up at all and is wasting money on cheap alcohol instead, print **&quot;never&quot;**.

**Note** that if, for example, Anastas needs 3.1 months, you need to **round that up** – so you have to print &quot;0 years 4 months&quot;. The years and months should be integer numbers. Check out the examples to understand your task better.

### Input

The input will be read from the console. The input consists of exactly **two lines** :

- On the **first line** you will be given an integer – **the price of the tank**.
- On the **second line** you will be given the **number of party days in a month**.

The input will always be valid and in the format described, there is no need to check it explicitly.

### Output

The output should be printed on the console.

- On the only output line **print the number of years and months** Anastas will need to save enough money in the **format &quot;X years, Y months&quot;** , or **print &quot;never&quot; in case he&#39;s actually wasting money** each month.

### Constraints

- The **price** of the tank will be an integer in the range [1 … 2 000 000 000].
- The number of **party days** will be an integer in the range [0 … 30].
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 200000 <br/> 5 | 666 years 8 months | There are 30 days in a month =&gt; 5 party days and 25 normal days. On a normal day he saves 2 leva =&gt; 25\*2 = 50 leva. On a party day he spends 5 leva =&gt; 5\*5 = 25. On average, he saves 50 – 25 = 25 leva per month.200000/25 = 8000 – he needs exactly 8000 months. This is 666 years and 8 months, or 666.(6) years to be exact). Not gonna happen in our lifetime, thankfully! |

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 12345 <br/> 10 | never | 24300000 <br/> 0 | 33750 years, 0 months |



| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 200 <br/> 8 | 4 years, 2 months | 15999 <br/> 3 | 34 years, 3 months |

# Problem 2 – Cheat Sheet

Goshko is a great singer, but he sucks at math - multiplication table is the thing he hates the most. Help him by generating a cheat sheet with the multiplication table for him. Goshko should be able to enter the followingthings:

- The numbers of **rows** and **columns** of the output table
- The **start number vertically**
- The **start number horizontally**

For example, if he enters **9** rows, **9** columns, vertical and horizontal start numbers **1** , the generated cheat sheet should look like this:

|   | **1** | _2_ | _3_ | _4_ | _5_ | _6_ | _7_ | _8_ | _9_ |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| **1** | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| _2_ | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 |
| _3_ | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 |
| _4_ | 4 | 8 | 12 | 16 | 20 | 24 | 28 | 32 | 36 |
| _5_ | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 |
| _6_ | 6 | 12 | 18 | 24 | 30 | 36 | 42 | 48 | 54 |
| _7_ | 7 | 14 | 21 | 28 | 35 | 42 | 49 | 56 | 63 |
| _8_ | 8 | 16 | 24 | 32 | 40 | 48 | 56 | 64 | 72 |
| _9_ | 9 | 18 | 27 | 36 | 45 | 54 | 63 | 72 | 81 |

If he enters **3** rows, **5** columns, vertical start number **4** , horizontal start numbers **8** , the generated cheat sheet should look like this:

|   | **8** | _9_ | _10_ | _11_ | _12_ |
| --- | --- | --- | --- | --- | --- |
| **4** | 32 | 36 | 40 | 44 | 48 |
| _5_ | 40 | 45 | 50 | 55 | 60 |
| _6_ | 48 | 54 | 60 | 66 | 72 |

### Input

The input data should be read from the console.

- The **first line** will contain the number of **rows R**. The second line will contain the number of c **columns**** C **. The third line will contain the** vertical start number V **. The fourth line will contain the** horizontal start number H**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

The output should contain **exactly R lines** with **exactly C numbers per line** – representing each line of the cheat sheet. **Numbers should be separated by exactly one whitespace** (&quot; &quot;), and there **shouldn&#39;t be any whitespaces after the last number on a line**.

### Constraints

- 0 ≤ **R** ≤ 100.
- 0 ≤ **C** ≤ 100.
- Any number **N** in the cheat sheet will be in the range [-9223372036854775808…9223372036854775807].
- Allowed working time for your program: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | 
| 9 <br/> 9 <br/> 1 <br/> 1 | 1 2 3 4 5 6 7 8 9 <br/> 2 4 6 8 10 12 14 16 18 <br/> 3 6 9 12 15 18 21 24 27 <br/> 4 8 12 16 20 24 28 32 36 <br/> 5 10 15 20 25 30 35 40 45 <br/> 6 12 18 24 30 36 42 48 54 <br/> 7 14 21 28 35 42 49 56 63 <br/> 8 16 24 32 40 48 56 64 72 <br/> 9 18 27 36 45 54 63 72 81 |  3 <br/> 5<br/> 4 <br/> 8  | 32 36 40 44 48 <br/> 40 45 50 55 60 <br/> 48 54 60 66 72  |

## Problem 3 – Boat

We all know Popeye the Sailor Man. In this episode he was captured and thrown in a prison by Bluto on a lonely island in the middle of the Atlantic Ocean. He used his last spinach can to break out of the prison, but he still had to escape from the island. His only chance to survive and rescue his beloved Olive Oil is to somehow find a **boat** , but sadly the Animator doesn&#39;t know how to draw boats. Your task is to draw a boat by given **N** (the height and width of the sail) and bring this story to a happy ending.

### Input

The input data should be read from the console.

On the only input line you have an integer number **N** , showing the **height** and **width** of the sail.

The body of the boat should be exactly **(N – 1) / 2** lines high.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

You must print the boat on the console. Each row contains only characters &quot; **.** &quot; (dot)  or &quot; **\*** &quot; (asterisk).

The first row should have exactly one &quot; **\*** &quot; in the middle (that is the top of the sail) and every next line should have two more.

The first row of the body should have exactly **N \* 2** &quot;\*&quot; and every next line, two asterisk less. (see the example below)

### Constraints

- The number **N** will always be an **odd** integer number in the range [3…39].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 3

```
..*...
***...
..*...
******
```

#### Input: 5

```
....*.....
..***.....
*****.....
..***.....
....*.....
**********
.********.
```

## Problem 4 - Text Bombardment

Write a program that reads a **text** and **line width** from the console. The program should distribute the text so that it fits in a table with a specific line width. Each cell should contain only **1 character**. It should then read a **line with numbers** , holding the **columns that should be bombarded**.

![Not fount](/Programming%20Basics/OldExams/images/15.PNG)

For example, we read the text &quot; **Well this problem is gonna be a ride.** &quot; and line width **10**. We distribute the text among 4 rows with 10 columns. We read the numbers &quot; **1 3 7 9**&quot; and drop bombs on those columns in the table.

The bombs **destroy** the character they fall on + all the neighboring characters **below** it. **Note** : Empty spaces below destroyed characters stop the bombs (see column 7).

Finally, we print the bombarded text on the console:      &quot; **W l  th s p o lem i   o na be a r de.** &quot;

**Note:** The empty cells in the table after the text should NOT be printed.

### **Input**

The input data is read from the console.

- On the first line you will be given the **text**
- On the next lines you will be given the **line width**
- On the third line you will receive the **columns** that should be bombed (space-separated)

The input data will always be valid and in the format described. There is no need to check it explicitly.

### **Output**

The output data must be printed on the console and should contain only 1 line: the **bombarded text** as a single string.

### **Constraints**

- The text will contain only ASCII characters and will be no longer than 1000 symbols.
- The line width will be in the range [1…100].
- The columns will be valid integers in the range [1…&lt;line width&gt; - 1].
- A column will not be bombed more than once.
- Time limit: 0.25 seconds. Allowed memory: 16 MB.

### **Examples**

| **Input** | **Output** |
| --- | --- |
| Well this problem is gonna be a ride. <br/> 10 <br/> 1 3 7 9 | W l  th s p o lem i   o na be a r de. |