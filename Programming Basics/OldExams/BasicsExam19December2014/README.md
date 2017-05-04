# <p align="center"> C# Basics Exam 19 December 2014 <p>

## Problem 1.Problem 1 – Traveller Bob

Bob loves travelling by plane. Thankfully, his job of being a businessman involves traveling a couple of times during the month. Bob is a busy man. He has months when he uses his private jet in order to go and sign new contracts. In a **contract** month, he travels **3** times per week. Although Bob loves his work, he also cares about his family. He spends **family** months, when he has **1 less travel per week** than a contract month and he travels only **2 weeks**. The other months are considered &quot;normal&quot; during which Bob travels 2/5 less than during contract months.

In addition, if the year is **leap** , Bob travels **5%** more overall. Assume that a month has exactly **4 weeks**.

Your task is to write a program that calculates **how many times Bob travels** around the world **during the year** (rounded **down** to the nearest integer number).

### Input

The input data should be read from the console. It consists of three input values, each at separate line:

- The string &quot; **leap**&quot; for leap year or &quot; **normal**&quot; for year that is not leap.
- The number **c** – number of months Bob signs **contracts** in the year.
- The number **f** – number of months that Bob spends with his **family**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data must be printed on the console.

- On the only output line you must print the number of travels as integer.

### Constraints

- The numbers **c** is in range [0...12] and **f** is in range [0…12].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| leap <br/> 2 <br/> 1 | 97 | 12 months total in the year, split into: <br/> - 2 contract months 4 weeks \* 3 travels 12 travels \* 2 months **24** travels <br/> - 1 family month 2 weeks \* 2 travels **4** travels <br/> - 9 normal months 12 travels \* 9 months <br/> **108 travels** \* 3/5 **64.8** <br/> Leap year -> additional **5%** -> (64.8 + 24 + 4) \* 5% -> **4.64** <br/>  Total travels = **97.44** -> **97** travels |

| **Input** | **Output** |  **Input** | **Output** |  **Input** | **Output** |   **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- | 
| normal <br/> 5 <br/> 2 | 104 | leap <br/> 2 <br/> 6 | 80 | leap <br/> 4 <br/> 0 | 110 | normal <br/> 0 <br/> 1 | 83 |

## Problem 2 – Spy Hard

You are a handler. Your task is to relay messages between field operatives (spies), and headquarters (the CIA). The CIA developed a system; first, the operatives send coded messages to you, then you partially decrypt each message and relay it to headquarters where further decryption takes place.

You will be given **a key and a message**. The key will be a number, it shows the **base of the numeral system** you&#39;ll need to use for decryption. The message is comprised of **various symbols which you convert to a number** by adding together either the **letter&#39;s position in the alphabet** (a = 1, b = 2, … , z = 26) if the symbol is a letter, **or the symbol&#39;s code in the ASCII table** otherwise. After you get the sum of the symbols, you need to convert it to the numeral system provided by the key.

To headquarters you need to send a single string containing three numbers concatenated together; the first part will be the numeral system you used, next comes the number of symbols in the initial message and finally comes the partially decrypted message (a number in the specified numeral system). See the example below to get a clearer idea of the steps you need to take.

### Input

The input data should be read from the console.

- The first input line holds **a number (the key)**.
- The second input line holds **a string (the message)**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

- On the only output line you must print the **code** you&#39;ll transmit to headquarters.

### Constraints

- The **key** will be a number between 2 and 10 inclusive.
- The **length of the message** will be between 1 and 100 symbols.
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Comments** | **Output** |
| --- | --- | --- |
| _2_ <br/> a%B | We&#39;ll use binary =&gt; first symbol in decyphered message is 2.3 symbols in initial message, we concatenate with 2.1(a) + 37(%) + 2(B) = 40(10) =&gt; 101000(2); add at the end of the result and print. | 23101000 |

| **Input** | **Output** | **Input** | **Output** |**Input** | **Output** |
| --- | --- |---|---|---|---|
| 7 <br/> [softuni] | 79561 | 10 <br/> aaAoZz | 10670 | 5 <br/> 0%/,qT~ | 572324 |

## Problem 3 – Headphones

Stamat really loves all kinds of music. He listens to music all the time. He even dreams of it. One day he decided to start programming. The only way he can write code is while listening to music (and singing… and even dancing).

Your task is to help Stamat write a program that **prints his headphones** on the console using only asterisks &#39; **\*** &#39; and dashes &#39; **-** &#39;. And since his headphones are very special they have a **diameter**. See the example below to better understand how the diameter affects the headphones&#39; size.

![Not fount](/Programming%20Basics/OldExam/images/13.PNG)

### Input

The input data consists of only 1 line: the **diameter** of Stamat&#39;s headphones.

### Output

The output data should be printed on the console.

### Constraints

- The diameter of Stamat&#39;s headphones will always be an **odd number** in the range [3..29].
- Allowed work time: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 5

```
--*******--
--*-----*--
--*-----*--
--*-----*--
--*-----*--
--*-----*--
-***---***-
*****-*****
-***---***-
--*-----*--
```

#### Input: 7

```
---*********---
---*-------*---
---*-------*---
---*-------*---
---*-------*---
---*-------*---
---*-------*---
---*-------*---
--***-----***--
-*****---*****-
*******-*******
-*****---*****-
--***-----***--
---*-------*---
```

# Problem 4 – Spiral Matrix

We have to make a **spiral matrix** (n x n) defined by walking over a grid of letters as a spiral (right, down, left, up, and again - right, down, left, etc.). We start from the upper left corner of the matrix and fill each cell with a letter from a given **keyword**. We fill the cells starting with the first letter of the keyword; when we get to the last letter we return to the first letter again. The process is repeated until the matrix is fully filled. See the example below to better understand your task.

The weight of each letter is the product of its position in the English alphabet and the number 10 (weight &#39; **a**&#39; = 1\*10 = 10, weight &#39; **b**&#39; = 2\*10 =20 … weight &#39; **z**&#39; = 26\*10 = 260). Find the index and the weight of the row with the biggest weight. If several rows have an **equal** weight, print the **upper-most** row.

Example

![Not fount](/Programming%20Basics/OldExam/images/14.PNG)

The matrix is 4x4 and the keyword is &quot;SoftUni&quot;. The weight of every row is:

- Row 0 = weight (&#39;S&#39;) + weight (&#39;o&#39;) + weight (&#39;f&#39;) + weight (&#39;t&#39;) = 600
- Row 1 = weight (&#39;U&#39;) + weight (&#39;n&#39;) + weight (&#39;I&#39;) + weight (&#39;U&#39;) = 650
- **Row 2 = weight (&#39;t&#39;) + weight (&#39;o&#39;) + weight (&#39;S&#39;) + weight (&#39;n&#39;) = 680**
- Row 3 = weight (&#39;f&#39;) + weight (&#39;I&#39;) + weight (&#39;S&#39;) + weight (&#39;I&#39;) = 490

Therefore, the row with biggest weight is **row 2** with a weight of **680**.

### Input

The input data should be read from the console.

- On the first line of input, you will read a number n, representing the size of the matrix.
- On the second line of input, you will read a string – the keyword.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output must be printed on the console.
On the only output line you must print the index and weight of the row with biggest weight in the format: &quot;{row} - {weight}&quot;.

### Constraints

- The size of the matrix will be in the range [1…1000].
- The keyword will contain only Latin upper- and lower-case letters: [a-z] [A-Z].
- Allowed work time for your program: 0.25 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |  **Input** | **Output** |  
| --- | --- | --- | --- | 
| 4 <br/> SoftUni | 2 - 680 | 7 <br/> Abcd | 1 - 190 |  
| 6 <br/> Hello | 2 - 680 |12 <br/> Matrix | 4 - 1890 |
