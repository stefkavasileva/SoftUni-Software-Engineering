# <p align="center"> C# Basics Exam 14 April 2014 Evening <p>

## Problem 1 – Inside the Building


In Absurdistan the **buildings** look like the figure on the right. They consist of **6 blocks of size h \* h**. Their bottom-left corner is located at the coordinates (0, 0). See the figure (for h = 2) to get a better idea.

![Not fount](/Programming%20Basics/OldExams/images/10.PNG)

Write a program that enters a size **h** and 5 points **{x1, y1}, {x2, y2}, {x3, y3}, {x4, y4}, and {x5, y5}** and prints for each of the points whether it is inside or outside of the building. Points at the building&#39;s border, like {0, 0}, are considered inside.
### Input

The input data should be read from the console.

- At the first line an integer number **h** specifying the **size** of the building will be given.
- At the next 10 lines the numbers numbers **x1, y1, x2, y2, x3, y3, x4, y4, x5, y5** are given.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of exactly 5 lines. At each line print either &quot; **inside**&quot; or &quot; **outside**&quot; depending of where each of the 5 input points are located.

### Constraints

- All numbers in the input will be integers in the range [-1000 … 1000].
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** | 
| --- | --- | --- | 
| 2 <br/> 3 <br/> 10 <br/> 0 <br/> 6 <br/> 2 <br/> 2 <br/> 3 <br/> 1 <br/> 6 <br/> 0 | outside <br/> outside <br/> inside <br/> inside <br/> inside  |![Not fount](/Programming%20Basics/OldExams/images/11.PNG)|
| 15 <br/> 29 <br/> 38 <br/> 37 <br/> 19 <br/> 30 <br/> 0 <br/> -4 <br/> 7 <br/> 13 <br/> 57 | inside <br/> outside <br/> inside <br/> outside <br/> outside |![Not fount](/Programming%20Basics/OldExams/images/12.PNG)|

# Problem 2 – Student Cables

Once at the Software University (SoftUni) we had problems with the Wi-Fi network. It was working well in the previous days even with a few hundred students browsing Internet in the same time, but at the exam all the students came with their laptop at fixed time and tried to establish a wireless connection simultaneously. This flooded the Wi-Fi access points and as a result some of the students were unable to get an IP address from the DHCP server. They of course established a Wi-Fi Internet connection after a few reconnects in next 5-10 minutes, but were highly stressed because they didn&#39;t had Internet immediately before the start the exam start.

Nakov, the main driver of SoftUni, decided to solve the problem by connecting some of the students through a standard **network cables**. He installed a few network switches in the exam lab and started to prepare cables for the students. His idea was to use **5 meters long cables** (called **student cables** ) between the switches and the student&#39;s laptops. Nakov wanted to create as much as possible cablesof size 5 meters. He had a lot of cables of different sizes, e.g. a big roll of 300 meters, another big roll of 130 meters and a few small cables of 30 cm, 15 cm and 10 cm. The cables had **different sizes** and was measured in **different** **measures**(meters or centimeters). Nakov calculated that he needed **2**  cm for crimping each RJ45 connector **and 3** cm for joining each two pieces of cable. It was complex to calculate how much cables Nakov can create so he needs your help.

Write a program that takes as an input a **sequence of N cables of different sizes** and calculates **how many student cables** Nakov can create by first joining them all together, then cut them into 5 meters and 4 cm, and finally crimp the RJ45 connectors to obtain 5 meters long student network cables. Calculate also **the length of the unused remaining cable**. Note that cables **shorter than 20 cm** in the input will be thrown away, so please discard therm.

### Input

The input data should be read from the console.

- At the **first line** an integer number **n** specifying the **number of cables** will be given.
- At the next **2 \* n lines** the cables will be given: first comes the **cable length** ; second comes the **measure**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of exactly 2 lines:

- The first line should hold the **number of student cables**.
- The second line should hold the **length of the remaining cable**.

### Constraints

- The number **n** will be integer in the range [1 … 100].
- The **cable length** is integer in the range [1 … 500].
- The **cable measure** is one of the following values: **meters** , **centimeters**.
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** | 
| --- | --- | --- | 
| 4 <br/> 11 b<br/> meters <br/> 18 <br/> centimeters <br/> 8 <br/> meters <br/> 120 <br/> centimeters | 3502 | We have **4** cables: **1100** cm, **18** cm, **800** cm and **120** cm. The 18 cm cable is too short (18 cm &lt; 20 cm), so it is discarded. <br/>  We join 1100 cm + 800 cm + 120 cm and we lose 2\*3 = 6 cm. <br/> We obtain **2014** cm joined cable. We create **3 student cables** : 3 \* (5 m cable + 2 cm RJ crimp + 2 cm RJ crimp) = 3 \* 504 = **15**** 12 **cm. <br/>  The remainder is 2014 – 1512 =** 502 cm**. |

| **Input** | **Output** |
|---|---|
| 3 <br/> 116 <br/> centimeters <br/> 4 <br/> meters <br/> 20 <br/> centimeters | 126 |

## Problem 3 – Programmer DNA

The secret scientists from the institute of Bizarre Artificial Neurobiology or B.A.N have tried for years to find the DNA markers of the perfect programmer. The work is going well but after an incident with the printer in the institute it is impossible to print the latest discovery. That is why they have asked you to help them.

Your task is to make a program that can **print simple DNA chains of various lengths**. Simple DNA chains consist of **sequence of diamond blocks containing only letters from A to G** (see the example on the right).

Letters are chained alphabetically: A is followed by B, then C, D, E, F, G, then again A and so on. Each DNA block is with size 7.

### Input

The input data should be read from the console.

- On the first line an integer number **N** specifying the **length** of the DNA chain will be given.
- On the second line the **starting letter** of the chain will be given (capital letter from **A** to **G** ).

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Following the examples below print exactly **N** lines of the programmer&#39;s DNA. Use only capital letters from **A** to **G** and &quot; **.** &quot; for the empty space.

### Constraints

- **N** will always be a positive number between **7** and **999** inclusive.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input:
 7 <br/> B

 ```
 ...B...
..CDE..
.FGABC.
DEFGABC
.DEFGA.
..BCD..
...E...
```

#### Input:
 10 <br/> F

 ```
 ...F...
..GAB..
.CDEFG.
ABCDEFG
.ABCDE.
..FGA..
...B...
...C...
..DEF..
.GABCD.
```

## Problem 4 – Magic Car Numbers

Cars in Sofia have registration numbers in format &quot; **CA abcdXY** &quot; where a **,** b **,** c and d are digits from **0 to 9** and **X** and **Y** are **letters** from the following subset of the Latin alphabet: &#39;A&#39;, &#39;B&#39;, &#39;C&#39;, &#39;E&#39;, &#39;H&#39;, &#39;K&#39;, &#39;M&#39;, &#39;P&#39;, &#39;T&#39; and &#39;X&#39;. Examples of car numbers from Sofia are &quot;CA8517TX&quot;, &quot;CA2277PC&quot;, &quot;CA0710XC&quot;, &quot;CA1111AC&quot;, while &quot;CC7512FJ&quot; in not valid car number from Sofia. Local people are keen to choose special numbers for their cars, know as magic car numbers . They calculate the** weight of a car number as follows: they sum its digits and letters, assuming that letters have the following values: &#39;A&#39; => 10, &#39;B&#39; => 20, &#39;C&#39; => 30, &#39;E&#39; => 50, &#39;H&#39; => 80, &#39;K&#39; => 110, &#39;M&#39; => 130, &#39;P&#39; => 160, &#39;T&#39; => 200, &#39;X&#39; => 240. For example the weight(&quot;CA6511BM&quot;) = 30 + 10 + 6 + 5 + 1 + 1 + 20 + 130 = 203. A **magic car number **is a car number that has a** special magic weight**(e.g. 256 or 512 for developers) and its number is in some of the formats &quot;CA_aaaaXY_&quot;, &quot;CA_abbbXY_&quot;, &quot;CA_aaabXY_&quot;, &quot;CA_aabbXY_&quot;, &quot;CA_ababXY_&quot; and &quot;CA_abbaXY_&quot;, where**a **and** b **are two different digits and** X **and** Y** are letters from the Latin alphabet subset { &#39;A&#39;, &#39;B&#39;, &#39;C&#39;, &#39;E&#39;, &#39;H&#39;, &#39;K&#39;, &#39;M&#39;, &#39;P&#39;, &#39;T&#39;, &#39;X&#39; }.

Your task is to write a program that calculates **how many cars** can be registered in Sofia **for given magic weight**.

### Input

The input data should be read from the console. It will consist of a single value: the **magic weight**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It is a single value: the number of cars matching given magic value.

### Constraints

- All input numbers will be **integers** in the range [1…1000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Matching Car Numbers** |
| --- | --- | --- |
| 555 | 2 | CA8999XX, CA9998XX |
| 512 | 18 | CA5999TX, CA5999XT, CA7799TX, CA7979TX, CA7997TX, CA7799XT, CA7979XT, CA7997XT, CA8888TX, CA8888XT, CA9995TX, CA9977TX, CA9797TX, CA9779TX, CA9995XT, CA9977XT, CA9797XT, CA9779XT |
| 95 | 46 | CA0555AC, CA0555BB, CA0005BC, CA0555CA, CA0005CB, CA1888AB, CA1888BA, CA1112BC, CA1112CB, CA2229AC, CA2229BB, CA2111BC, CA2229CA, CA2111CB, CA3444AC, CA3336AC, CA3444BB, CA3336BB, CA3444CA, CA3336CA, CA4777AB, CA4443AC, CA4777BA, CA4443BB, CA4443CA, CA5550AC, CA5550BB, CA5000BC, CA5550CA, CA5000CB, CA6667AB, CA6333AC, CA6667BA, CA6333BB, CA6333CA, CA7774AB, CA7666AB, CA7774BA, CA7666BA, CA8999AA, CA8881AB, CA8881BA, CA9998AA, CA9222AC, CA9222BB, CA9222CA |