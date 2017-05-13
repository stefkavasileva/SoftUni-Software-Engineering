# <p align="center">Programming Basics Exam - 18 October 2015 <p>

## **Problem 1 – The Better Music Producer**

After a young rock band wins a music contest, they receive offers from two famous producers. And now they must choose the better one.

The first one offers the young musicians to record an album and distribute it in North America, South America, and Europe. The band makes a research to find out **how many albums** can be **sold in each continent** , as well as the **price for the music** album in local currency. According to the contract, the **producer takes 35%** from all profits. The band must pay **20% taxes** on the rest of the income.

The second offer includes a world tour with &quot;N&quot; (number of) concerts. Each concert makes the same amount of profit. If the total income from all concerts is **more than**** 100,000 lv **the producer** keeps 15%.**

Your task is to write a program to **calculate** which offer is better. You&#39;ll be given some **numbers**. For the **first** offer - the **number of albums** sold in **each** continent and the **price** for a **single album** in each continent. For the second offer – **the number of concerts** and the **profit from a single concert** (it is the same for all concerts). You must convert all currencies in **levas**. Assume that:

- 1 euro is 1.94lv.
- 1 dollar is 1.72lv.
- 74 pesos are 1lv.
-

- **Find the profit** from all albums, **subtract** the **producer&#39;s share** and after that **subtract**** taxes. **Finally you must** find **which of the offers is** more profitable**. Print your results on the console.

#### Input
- The input data should be read from the console. It will consist of exactly 8 lines:

1. The number of albums sold in Europe
2. The price of an album in euro
3. The number of albums sold in North America
4. The price of an album in dollars
5. The number of albums sold in South America
6. Price of an album in pesos
7. The number of concerts during a tour
8. Profit from a single concert in euro

The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output
 The output should be printed on the console.

- **If the total profit from all album is more than from all concerts print on the console:**
  - &quot;Let&#39;s record some songs! They&#39;ll bring us {incomes from albums}lv.&quot;
- **If it is equal to or the profit from the concerts is greater:**
  - &quot;On the road again! We&#39;ll see the world and earn {profit from concerts}lv.&quot;
- All incomes must be rounded to two digits after the decimal point.

### Constraints

- The prices for different continents and incomes from concert will be a valid floating-point numbers in range [0…7.9 x 10-28]
- The count of albums and concerts will be a valid integers in range [0… 10000]
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|1234 <br/> 11.50 <br/> 987 <br/> 8.99 <br/> 567 <br/> 6543 <br/> 100 <br/> 593.20|On the road again! We'll see the world and earn 97818.68lv.|Europe -> 1234 * 11.50 euro = 27530.54 lv <br/> N. America -> 987 * 8.99 dollars = 15261.7836 lv <br/> S. America -> 567 * 6543 pesos = 11149.4890… lv <br/>  <br/> All albums -> 53941.8126 - 35% for the producer -> 35062.1782 lv – 20% taxes = 28049.7426 <br/>  <br/> Concerts profit -> 100 * 593.20 euro -> 115080.800 lv (more than 100000) – 15% -> 97818.680 > 28049.7426

|**Input**|**Output**|
|---|---|
|2234 <br/> 11.50 <br/> 987 <br/> 8.99 <br/> 567 <br/> 6543 <br/> 50 <br/> 345.20|Let's record some songs! They'll bring us 39650.94lv.|

## Problem 2 – Grand Theft Examo

There has been a security breach in the Schöftung Universität in the peaceful Bavarian village of Körpergörper-am-Harlachinger-Quellbach. Thieves have found the secret vault holding the exam sheets and are busy making use of it. The headmaster, Trie von Apovberger is the only one left in the university. He is renowned for his mighty right hand and is standing at the entrance, slapping the pesky thieves. There are too many of them though.

Von Apovberger can only **slap** 5 thieves per **escape attempt**. The others manage to escape with the exam sheets. Hėr Apovberger also replenishes his strength by drinking beer. He is German so he drinks a lot of it. No beer can evade the stomach and kidneys of von Apovberger, so every single bottle is put to use.

Your task is to calculate the amount of thieves **that are slapped** , thieves that **manage to escape** , and beer drunk in amount of **six-packs** and remaining **bottles**.

### Input

- On the first line you receive the number **N** – the number of escape attempts.
- On the next **N** \* 2 lines, you receive two integers, each on a new line
  - **T** – the amount of thieves that attempt to escape
  - **B** – the amount of beer that von Apovberger drinks

### Output

- On the first line, display the amount of thieves slapped, in format **{count} thieves slapped.**
- On the second line – the thieves that escaped, in format **{count} thieves escaped.**
- On the third line – the beer drunk, in format **{count} packs, {count} bottles.**

### Constraints

- **N** is an integer in range [1 … 50]
- **T** and **B** are integers in range 
- Allowed memory: 16 MB
- Allowed time: 0.1s

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 3 <br/> 8 <br/> 2 <br/> 6 <br/> 3 <br/> 9 <br/> 2 | 15 thieves slapped. <br/> 8 thieves escaped. <br/> 1 packs, 1 bottles.  | 3 escape attempts: <br/> 1st: 5 thieves slapped, 3 escape, 2 beers <br/> 2nd: 5 thieves slapped, 1 escape, 3 beers <br/> 3rd: 5 thieves slapped, 4 escape, 2 beersTotal: 15 slaps, 8 escapes, 1 six-pack and 1 beer |

| **Input** | **Output** |
| --- | --- |
| 1 <br/> 5 <br/> 6 | 5 thieves slapped. <br/> 0 thieves escaped. <br/> 1 packs, 0 bottles. |

## Problem 3 – Plaid Towel

 After Angel&#39;s awesome striped tower, he wants a new one. Actually, he asked his &quot;very well-known local producer&quot; if it was possible to make a lot of plaid towels, but every single one to be of different size and color. It turned out it was possible. There is only one problem – someone should program the machines to change the colors and size.

Your task is to write that program. Well not exactly colors are represented by **symbols** - one for the **background** and one for the **rhombus**. The **size** is the distance between the top left corner and the top edge of the rhombus. See the examples for more clarity.

### Input

The input should be read from the console. It will consist three lines.

- 1st line –&gt;  the size
- 2nd–&gt; the background symbol
- 3rd –&gt; the rhombus symbol

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be the towel design, based on the input values.

### Constraints

- The size will be a valid integer in range [0… 100].
- The symbols will be valid symbols from ASCII table.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: <br/> 3 <br/> . <br/> \#

```
...#.....#...
..#.#...#.#..
.#...#.#...#.
#.....#.....#
.#...#.#...#.
..#.#...#.#..
...#.....#...
..#.#...#.#..
.#...#.#...#.
#.....#.....#
.#...#.#...#.
..#.#...#.#..
...#.....#...
```

#### Input: <br/> 4 <br/> \# <br/> .

```
####.#######.####
###.#.#####.#.###
##.###.###.###.##
#.#####.#.#####.#
.#######.#######.
#.#####.#.#####.#
##.###.###.###.##
###.#.#####.#.###
####.#######.####
###.#.#####.#.###
##.###.###.###.##
#.#####.#.#####.#
.#######.#######.
#.#####.#.#####.#
##.###.###.###.##
###.#.#####.#.###
####.#######.####
```

## Problem 4 – Firefighting organization

You are Chief at the Fire Department. Your job is to manage your firefighting group, and save as many lives as possible. You will be given a **number of firefighters** , and after that you will receive a sequence of lines, until you receive as input &quot;rain&quot;, which extinguishes all fires.

Each line of input contains a **string containing letters** representing the people in a burning building. **Each letter corresponds to a type of person**.

**Person types:**

**K** – Kid, **A** – Adult, **S** – Senior

Your highest priority should always be **Kids** , followed by **Adults** and your lowest priority should be **Seniors.** That means that you are going to save all the **kids** first(if you have enough firefighters), then if you have free firefighters you will start saving the **adults** , and finally if you still have firefighters, you can start saving **seniors**. If you run out of firefighters you should immediately stop saving people and move on to the next **alert**.

### Input

The input data should be read from the console.

- On the **first line** you will be given an integer number **p** specifying the **number of firefighters**.
- On the next **lines** you will receive strings containing **random amount of letters,** representing the people in the current building, until you receive a line with the string &quot;rain&quot;, which determines the end of the input.

### Output

The output should be printed on the console. It should consist of exactly 3 lines:

- The first line should hold the **number of kids saved** in the following format :
{Kids: **[number of kids saved]**}
- The second line should hold the **number of adults saved** in the following format :
{Adults: **[number of adults saved]**}
- The third line should hold the **number of seniors saved** in the following format :
{Seniors: **[number of seniors saved]**}

### Constraints

- The number **p** will be an integer in the range [0 … 20].
- The count of input strings will be in the range [0…50].
- The letter sequence will always contain the letters **&#39;K&#39;** , **&#39;A&#39;** , **&#39;S&#39;**.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 5 <br/> SSAKA <br/> KSA <br/> KKK <br/> SSKASAAKSA <br/> AKKKS <br/> rain | Kids: 10 <br/> Adults: 7 <br/> Seniors: 4 | You have 5 firefighters to work with. <br/> 5 firefighters are enough to save everyone from the buildings except one. <br/>  For the building with most people in it you should get the kids first(2 kids at total), then you can only take 3 of the remaining people. <br/>  You start taking adults until you run out of firefighters. <br/> After all the input has been processed the “rain” command has been entered and the input has ended. <br/> Then you print the output (saved people) in the way it was described above. |

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 3 <br/> SKSKSKSKSK <br/> AKS <br/> SSA <br/> AKS <br/> KAKSKKASS <br/> KKAAS <br/> AAAAAAAAAA <br/> SSAKA <br/> AAA <br/> rain | Kids: 11 <br/> Adults: 12 <br/> Seniors: 4 | 4 <br/> AASASKSSSS <br/> ASA <br/> KASSKAA <br/> rain | Kids: 3 <br/> Adults: 7 <br/> Seniors: 1 |
