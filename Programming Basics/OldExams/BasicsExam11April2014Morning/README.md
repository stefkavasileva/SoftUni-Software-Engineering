# <p align="center"> C# Basics Exam 11 April 2014 Morning <p>

## Problem 1 – Work Hours

Lelia Vanche is a very keen freelance developer. She is well known for her outstanding skills, but she is also known for being pretty moody, which often affects her productivity. She also has a passion for bicycles and **10% of the normal work days** she goes mountain-biking instead of working.

You are asked to calculate whether Lelia Vanche can finish a project on time. You will be given thenumber of **hours required to finish the project** , the **days** that Lelia Vanche has available for working (mind that she goes to biking in 10% of this time) and her **average productivity** during the given period. Assume that a normal work day for Lelia Vanche has **12 hours**. Note that only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).

### Input

Input data should be read from the console.

- The number **h** (the required work **hours** to finish the project) is on the first input line.
- The number **d** (the **days** available to finish the project) is on the second input line.
- The number **p** (the productivity in **percent** ) is on the third input line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data must be printed on the console.

- On the first output line you should print &#39; **Yes&#39;** or &#39; **No&#39;** if Lelya Vanche can complete the project.
- On the second output line you should print the **difference,** between the project hours and the work hours **.**

### Constraints

- The number **h** will be an integer between 0and 2 147 483 647, inclusive.
- The number **d** will be an integer between 0 and 89 478 485, inclusive.
- The number **p** will be an integer between 0 and 100, inclusive.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 60 <br/> 6 <br/> 75 | No <br/> -12 | The project requires 40 hours. Lalia Vanche has 6 days, of which 10% she will be biking, so she will work 5.4 days \* 12 hours = 64.8 hours \* 75% productivity = 48.6 efficient work hours, which is rounded down to 48. She will be able to complete the project. The difference is 60 - 48 = -12 (she needs more 12 hours). |

| **Input** | **Output** | **Input** | **Output** |   
| --- | --- | --- | --- |
| 1 <br/> 1 <br/> 100 | Yes <br/> 9 | 240 <br/> 10 <br/> 100 | No <br/> -132 |
| 10 <br/> 10 <br/> 10 | Yes <br/> 0 | 21 <br/> 10 <br/> 10 | No <br/> -11 |

## Problem 2 – Sum of Elements

You are given **n** numbers. Find an **element that is equal to the sum of all of the other elements**.

### Input

Input data should be read from the console.

- At the **only line** in the input a **sequence of integers** stays (numbers separated one from another by a space).

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data must be printed on the console. At the only line of the output print the result.

- Print &quot; **Yes, sum=…** &quot; if there is an element that is equal to the sum of all other elements, along with this **sum**.
- Print &quot; **No, diff=…** &quot; if there is no element that is equal to the sum of all other elements. Print also the minimum possible difference between an element from the sequence and the sum of all other elements (always a **positive number** ).

### Constraints

- All input numbers are integers in the range [0 … 2 000 000 000].
- The count **n** of the input integers is in the range [2 ... 1 000].
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** | 
| --- | --- | --- | 
| 3 4 1 1 2 12 1 | Yes, sum=12 | 3 + 4 + 1 + 2 + 1 + 1 = 12 | 

| **Input** | **Output** |  **Input** | **Output** |   
| --- | --- | --- | --- | 
|6 1 2 3 | Yes, sum=6 | 1 1 10 | No, diff=8 |
| 5 5 1 | No, diff=1 | 1 1 1 | No, diff=1 | 

|**Input**|**Output**|
|---|---|
|0 0 | Yes, sum=0 |

## Problem 3 – The Explorer

Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them. Today he is going on an expedition to collect all kind of diamonds, no matter small or large. Help your friend to find all the diamonds in the biggest known cave &quot;The Console Cave&quot;. At the only input line you will be given the width of the diamond. The char that forms the outline of the diamonds is &#39; **\*** &#39; and the surrounding parts are made of &#39; **-**&#39; (see the examples). Your task is to **print a diamond** of given size **n**.

### Input

Input data should be read from the console.

- The only input line will hold the width of the diamond – **n**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data must be printed on the console.

- The output lines should hold the diamond.

### Constraints

- The number **n** **is positive odd integer between 3 and 59**, inclusive.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: 5

```
--*--
-*-*-
*---*
-*-*-
--*--
```

#### Input: 7

```
---*---
--*-*--
-*---*-
*-----*
-*---*-
--*-*--
---*---
```

## Problem 4 – Magic Strings

You are given a number **diff**. Write a program to **generate all sequences of 8 letters** , each from the set { &#39; **s**&#39;, &#39; **n**&#39;, &#39; **k**&#39;, &#39; **p**&#39; }, such that the weight of the first 4 letters differs from the weight of the second 4 letters exactly by **diff**. These sequences are called &quot; **magic strings**&quot;. Print them in alphabetical order.

The **weight of a single letter** is calculated as follows:  weight(&#39; **s**&#39;) = **3** ; weight(&#39; **n**&#39;) = **4** ;  weight(&#39; **k**&#39;) = **1** ;  weight(&#39; **p**&#39;) = **5**. The **weight of a sequence** of 4 letters is the calculated as sum of the weights of these 4 individual letters.

### Input

- The input data should be read from the console.
- The number **diff** stays at the first line.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console as a sequence of strings in **alphabetical order**. Each string should stay on a separate line. In case no magic strings exist, print &quot; **No**&quot;.

### Constraints

- The number **diff** will be an **integer** number in the range [0…100].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 16 | kkkkpppp <br/> ppppkkkk| weight(&#39;kkkk&#39;) = 4; weight(&#39;pppp&#39;) = 20; diff = 16weight(&#39;pppp&#39;) = 4; weight(&#39;kkkk&#39;) = 20; diff = 16 |

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
|15|kkkknppp <br/> kkkkpnpp <br/> kkkkppnp <br/> kkkkpppn <br/> npppkkkk <br/> pnppkkkk <br/> ppnpkkkk <br/> pppnkkkk|weight('kkkk') = 4; weight('nppp') = 19; diff = 15 <br/> weight('kkkk') = 4; weight('pnpp') = 19; diff = 15 <br/> weight('kkkk') = 4; weight('ppnp') = 19; diff = 15 <br/> weight('kkkk') = 4; weight('pppn') = 19; diff = 15 <br/> weight('nppp') = 19; weight('kkkk') = 4; diff = 15 <br/> weight('pnpp') = 19; weight('kkkk') = 4; diff = 15 <br/> weight('ppnp') = 19; weight('kkkk') = 4; diff = 15 <br/> weight('pppn') = 19; weight('kkkk') = 4; diff = 15|


| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 20 | No | No magic strings match the specified difference diff |

