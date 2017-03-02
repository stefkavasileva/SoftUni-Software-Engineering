#<p align="center"> Simple Arrays - More Exercises  <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/422#0).

## 1.Last 3 Consecutive Equal Strings

Read an array of **strings** and find the **last three** consecutive equal strings.

### Examples

| **Input** | **Output** |
| --- | --- |
| one one one one two hi hi my echo **last last last** pi | last last last |
| Gosho had a **little little little** lamb | little little little |
| no shirt shirt shirt no **shoes shoes shoes** no service | shoes shoes shoes |

1. 2.Array Elements Equal to Their Index

Read an array of **integers** and extract the elements which have the **same value** as their **index**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 **1** 1 1 **4** 2 1 3 **8** **9** 5 | 1 4 8 9 |
| 2 5 **2** 24 254 **5** **6** | 2 5 6 |
| **0 1 2 3 4 5 6 7 8** 8 | 0 1 2 3 4 5 6 7 8 |

1. 3.Phonebook

You will be given an array of **phone numbers** (strings) and an array of **names** (strings). After which, you will be given **strings on new lines** , **until** you receive the command &quot; **done**&quot;. Find the **numbers** , which correspond to the **names** and print them on the console in the following format:

- {name} -&gt; {number}

A number corresponds to a name when it&#39;s located on the **same position** as its corresponding **name** in both arrays.

### Examples

| **Input** | **Output** |
| --- | --- |
| 0888888888 0888123456 +359886001122 <br/> Nakov Ivan Maria<br/>Ivan<br/>Maria<br/>done | Ivan -&gt; 0888123456<br/>Maria -&gt; +359886001122 |
| (602)207-2544 +918671613200 1-661-335-8202<br/>John Prakash Felix<br/>Felix<br/>done | Felix -&gt; 1-661-335-8202 |
| 0882983983 0822223321 0898128398 0878223211<br/>Vasil Hristo Georgi Luben<br/>Vasil<br/>Luben<br/>done | Vasil -&gt; 0882983983Luben -&gt; 0878223211 |

## 4.\* Phone

This is an upgrade of the previous problem. Implement the **phonebook** functionality from the previous problem with this additional functionality:

- **call {number/name}** -&gt; print &quot; **calling {name/number}…**&quot;
  - If the **sum of the digits** (ignore other characters) of the number is **odd** , print &quot; **no answer**&quot;.
  - If the **sum of the digits** (ignore other characters) of the number is **even** , print &quot; **call ended. duration: {duration}**&quot;. The duration is calculated from the **sum of the digits** in the format &quot; **mm:ss**&quot;
- message {number/name} -&gt; print &quot;sending sms to {name/number}...&quot;
  - if the **difference**** of the digits**(ignore other characters) of the number is**odd **, print &quot;** busy**&quot;
  - if the **difference of the digits** (ignore other characters) of the number is **even** , print &quot; **meet me there**&quot;

### Constraints

- The numbers will contain the digits **0-9** and might contain the plus sign **+**. They will **always be valid** and in this format.
- The numbers and names will be **unique** – there will be no cases of **repeated numbers** or **repeated names**.
- The names and numbers will **always** be separated by exactly **one** whitespace.

### Examples

| **Input** | **Output** |
| --- | --- |
| 0888888888 0888123456 +359886001122<br/>Nakov Ivan Maria<br/>call 0888888888<br/>call Ivan<br/>message Maria<br/>done | calling Nakov...<br/>call ended. duration: 01:12<br/>calling 0889123456...<br/>no answer<br/>sending sms to +359886001122...<br/>busy |
| (602)207-2544 +918671613200 1-661-335-8202<br/>John Prakash Felix<br/>call Prakash<br/>call John<br/>call Felix<br/>done | calling +918671613200<br/>call ended. duration: 00:44<br/>calling (602)207-2544<br/>call ended. duration: 00:32<br/>calling 1-661-335-8202<br/>no answer |
| 0882983983 0822223321 0898128398 0878223211<br/>Vasil Hristo Georgi Luben<br/>message Vasil<br/>message 0878223211<br/>message Hristo<br/>done | sending sms to 0882983983...<br/>meet me there<br/>sending sms to Luben<br/>meet me there<br/>sending sms to 0822223321...<br/>busy |

## 5.Char Rotation

You are given **two lines of input** : a **string** and an **int** array. Modify the elements in the first array by the second array, following these conditions:

- If the element at the position is **even** , **subtract** its value to the ASCII code of the character on the same position.
- If the element at the position is **odd** , **add** its value to the ASCII code of the character on the same position.

After that, **print** the resulting string.

### Examples

| **Input** | **Output** |
| --- | --- |
| $wM+J\_H<br/>47 8 25 73 11 15 33 | SoftUni |
| tszL<br/>18 10 8 21 | bira |
| luFqfd~}<br/>6 2 41 14 3 1 10 4 | fsociety |

### Hints

- You can use the **string.ToCharArray()** or the **string.Split(&#39;&#39;)** methods to turn the initial input from a string into an array.

## 6.\* Power Plants

Ever heard of **Power Plants**? Power Plants are a special type of plant which collectively withers and blooms in strange ways.

You will receive an **array** of **integers** , holding the plants&#39; **power**** level **. If a plant&#39;s power reaches** 0 **, it** dies**.

The plants get more and more withered each **day** , and so – their power **decreases** by 1, except for one special plant, which **blooms** instead. The special plant which blooms is the one whose **index** corresponds to the **current day**. Its power is increased by 1, but only if it **isn&#39;t dead** (but since it has withered the same day, realistically its power stays the same).

When a season ends, all plants which are still alive **bloom**. The season ends when the **Nth** day is reached, **N** being the total number of plants.

Your task is to calculate how many days and seasons it will take for all the plants to **die**. Print them on the console in the following format: &quot;**survived {days} days ({seasons} seasons)**&quot;

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 3 4 | survived 6 days (1 season) | x -&gt; day index, y -&gt; withering  <br/>   initial: 1 2 3 4    <br/>  day 0: 1123  <br/>    day 1: 0112   <br/>   day 2: 0011  <br/>    day 3: 0001<br/>season over: 0 0 0 2 (alive ++)   <br/>   day 4: 0001     <br/> day 5: 0000 days survived -> 6, seasons -> 1 |
| 3 3 3 3 | survived 4 days (0 seasons) | x -&gt; day index, y -&gt; withering <br/> initial: 3 3 3 3  <br/> day 0: 3222  <br/>day 1: 2211  <br/>day 2: 1110  <br/>day 3: 0000 <br/>days survived -> 4, seasons -> 0 |
| 10409 32 2 | survived 31224 days (10407 seasons) |   |
