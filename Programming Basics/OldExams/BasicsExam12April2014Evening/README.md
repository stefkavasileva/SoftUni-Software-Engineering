# <p align="center"> C# Basics Exam 12 April 2014 Evening <p>

# Problem 1 – Exam Schedule

At SoftUni we have a new trainee Stamat, who is assigned to make **schedules for the entrance exams**. Since today is his first day at work he is a little bit nervous and he is not working very fast. Unfortunately, it seems that he will not have enough time to make the schedule for the next exam and there is no one else to do the job … except you of course. You will be given **exam starting time** in the standard 12-hour clock ( **hours** , **minutes** and **part of the day** ) and **exam duration** ( **hours** and **minutes** ). Your job is to write a program that calculates **at what time the exam ends**.

\* Note that the **standard 12-hours clock** uses the following arrangements of the hours of the day: 12AM (midnight), 1AM, 2AM, 3AM, 4AM, 5AM, 6AM, 7AM, 8AM, 9AM, 10AM, 11AM, 12PM (noon), 1PM, 2PM, 3PM, 4PM, 5PM, 6PM, 7PM, 8PM, 9PM, 10PM, 11PM, 12AM, 1AM, … (learn more at [http://en.wikipedia.org/wiki/12-hour\_clock](http://en.wikipedia.org/wiki/12-hour_clock)).

## Input

The input data should be read from the console. The input data consists of exactly 5 lines:

- The first three lines are holding the exam start time: **hour** , **minutes** and **part of the day (AM or PM)**.
- The last two lines are holding two integer number: the exam **duration hours** and **minutes**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

You have to print the time the exam ends in format **HH:MM:PartOfDay**.

## Constraints

- The **starting hour** will be an integer number in the range [1…12] inclusive.
- The **starting minutes** will an integer number in the range [0…59] inclusive.
- The **part of the day** will consist of exactly two capital letters: **AM** r **PM**.
- The **duration hours** will be an integer number between [0…23] inclusive.
- The **duration minutes** will be an integer number between [0…59] inclusive.
- Allowed work time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

## Examples

| **Input** | **Output** | **Input** | **Output** | 
| --- | --- | --- | --- |
| 9 <br/> 30 <br/> AM <br/> 6 <br/> 00 | 03:30:PM | 2 <br/> 0 <br/> PM <br/> 2 <br/> 30 | 04:30:PM |  
| 11 <br/> 30 <br/> AM <br/> 2 <br/> 0 | 01:30:PM | 11 <br/> 59 <br/> PM <br/> 0 <br/> 3 | 12:02:AM |

## Problem 2 – Odd / Even Elements

You are given **N numbers**. Calculate the **sum** , **min** and **max** of its **odd elements** and **sum** , **min** and **max** of its **even elements.** Consider that the first element is odd, the second is even, etc.

### Input

The input data should be read from the console. It will consists of exactly one line.

- At the first line **N numbers** will be given, separated one from another by a single **space**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

You have to print the output in a single line at the console in the following format:

- **OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…**

Print the numbers in the output without any unneeded trailing zeroes (i.e. print 1.5 instead of 1.50; 1 instead of 1.00). In case the sum, the minimal or the maximal element cannot be calculated (due to missing data), print &quot; **No**&quot;.

### Constraints

- All numbers in the input will be in the range [-1 000 000 … 1 000 000], with no more than 10 digits (total, before and after the decimal point). The decimal separator in the non-integer numbers will be &#39; **.**&#39; and the numbers will have up to 2 digits after the decimal separator.
- The count N of the numbers in the input is in the range [0 … 1000].
- All numbers in the output should be formatted **without unneded trailing zeroes**.
- Allowed work time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 3 5 4 2 1 | OddSum=9, OddMin=2, OddMax=5, EvenSum=8, EvenMin=1, EvenMax=4 |
| 3 -2 8 11 -3 | OddSum=8, OddMin=-3, OddMax=8, EvenSum=9, EvenMin=-2, EvenMax=11 |
| 1 | OddSum=1, OddMin=1, OddMax=1, EvenSum=No, EvenMin=No, EvenMax=No |
| 1.5 -2.5 | OddSum=1.5, OddMin=1.5, OddMax=1.5, EvenSum=-2.5, EvenMin=-2.5, EvenMax=-2.5 |
| 1.5 1.75 1.5 1.75 | OddSum=3, OddMin=1.5, OddMax=1.5, EvenSum=3.5, EvenMin=1.75, EvenMax=1.75 |

## Problem 4 – Arrow

SoftUni has opened a new training center in Kaspichan, but the people there did not know how to find it. Your task is to **print a vertical arrow** , which will be used to indicate the path to the new building in the city. This will help thousands of people to become software engineers. Please help them!

### Input

The input data should be read from the console.

- On the only line will hold and integer number **N** (always **odd** number), indicating the **width** of the arrow.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Use the &quot; **#** &quot; (number sign) to mark the arrow and &quot; **.** &quot; (dot) for the rest. Follow the examples below.

### Constraints

- **N** will always be a positive **odd** number between **3** and **79** inclusive.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 5

```
..#####..
..#...#..
..#...#..
..#...#..
###...###
.#.....#.
..#...#..
...#.#...
....#....
```

#### Input: 9

```
....#########....
....#.......#....
....#.......#....
....#.......#....
....#.......#....
....#.......#....
....#.......#....
....#.......#....
#####.......#####
.#.............#.
..#...........#..
...#.........#...
....#.......#....
.....#.....#.....
......#...#......
.......#.#.......
........#........
```

#### Input: 3

```
.###.
.#.#.
##.##
.#.#.
..#..
```

## Problem 4 – Five Special Letters

We are given two numbers: **start** and **end**. Write a program to **generate all sequences of 5 letters** , each from the set { &#39; **a**&#39;, &#39; **b**&#39;, &#39; **c**&#39;, &#39; **d**&#39;, &#39; **e**&#39; }, such that the weight of these 5 letters is a number in the range [**start** … **end**] inclusively. Print them in alphabetical order, in a single line, separated by a space.

The **weight of a single letter** is calculated as follows:  weight(&#39; **a**&#39;) = **5** ; weight(&#39; **b**&#39;) = **-12** ;  weight(&#39; **c**&#39;) = **47** ;  weight(&#39; **d**&#39;) = **7** ;  weight(&#39; **e**&#39;) = **-32**. The **weight of a sequence** of letters **c1c2..cn** is the calculated by first removing all repeating letters (from right to left) and then calculate the formula:
 
 **weight (c1c2…cn) = 1*weight(c1) + 2*weight(c2) + … + n*weight(cn)**

For example, the weight of &quot; **bcddc**&quot; is calculated as follows: First we remove the repeating letters and we get &quot; **bcd**&quot;. Then we apply the formula: 1\*weight(&#39; **b**&#39;) + 2\*weight(&#39; **c**&#39;) + 3\*weight(&#39; **d**&#39;) = 1\*(-12) + 2\*47 + 3\*7 = 103. Another example: weight(&quot;cadea&quot;) = weight(&quot;cade&quot;) = 1\*47 + 2\*5 + 3\*7 - 4\*32 = -50.

### Input

The input data should be read from the console. It will consist of 2 lines:

- The number **start** stays at the first line.
- The number **end** stays at the second line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console as a sequence of strings in **alphabetical order**. Each string should be separated than the next string by a single space. In case no 5-letter strings exist with a weight in the specified range, print &quot; **No**&quot;.

### Constraints

- The numbers **start** and **end** will be an **integers** in the range [-10000…10000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 40 <br/> 42 | bcead bdcea | weight(&quot;bcead&quot;) = 41 <br/> weight(&quot;bdcea&quot;) = 40 |

| **Input** | **Output** |  **Input** | **Output** | **Input** | **Output** | 
| --- | --- | --- | --- |---|---|
| -1 <br/> 1 | bcdea cebda eaaad eaada eaadd eaade eaaed eadaa eadad eadae eadda eaddd eadde eadea eaded eadee eaead eaeda eaedd eaede eaeed eeaad eeada eeadd eeade eeaed eeea| 200 <br/> 300|baadc babdc badac badbc badca badcb badcc badcd baddc bbadc bbdac bdaac bdabc bdaca bdacb bdacc bdacd bdadc bdbac bddac beadc bedac eabdc ebadc ebdac edbac|300 <br/> 400| No|


