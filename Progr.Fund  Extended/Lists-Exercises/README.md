#<p align="center"> Lists - Exercises   <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/424#0).

## 1.Remove Elements at Odd Positions

Write a program which reads a **list** of **space-separated**** strings **and** removes**the elements at positions [1…3…5…7…etc.]. After that,**print **the elements with** no delimiter **. Note that positions are** counted from 1**.

### Examples

| **Input** | **Output** |
| --- | --- |
| First Soft ccc Uni fifth | SoftUni |
| now you&#39;re\_ fired hired | you&#39;re\_hired |
| java I\_ x &lt; php 3\_ - C# | I\_&lt;3\_C# |

### Hints

- Instead of removing elements from the initial list, **create** a new list and **add** the **even** elements to it.

## 2.Track Downloader

You will receive a list of **blacklisted words** (on the same line, separated by **one** space). On the next lines, you will start receiving a list of **filenames** (as **strings** ) until you receive the string &quot; **end**&quot;. Your task is to **add** the filenames to a **list** and **sort** them. **Ignore** the tracks which **contain** the text in the **blacklist**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Metallica Linkin Park <br/> 01. Ceca - Maskarada.mp3 <br/>6.Metallica–Nothing Else Matters.mp3  <br/> Kilo\_dole\_kilo\_gore\_superfreedotbiz.mp3  <br/> Metallica\_forWhomTheBellTolls.flac <br/>04. ...Powdered Water Too (Part 1).mp3  <br/>Linkin Park - Numb.mp3 <br/>10. One Word Extinguisher.flac <br/>end | 01. Ceca - Maskarada.mp3  <br/> 04. ...Powdered Water Too (Part 1).mp3  <br/>10. One Word Extinguisher.flac  <br/> Kilo\_dole\_kilo\_gore\_superfreedotbiz.mp3 |
| Britney  <br/>12 - The Messenger.mp3 <br/>01-Can&#39;t Knock The Hustle.mp3  <br/> 09-99 Problems.mp3  <br/> Britney Spears - Toxic.mp3  <br/> 03 - Axion.mp3  <br/> 07 - Ultra Thizz.flac  <br/> Britney - Baby one more time.flac  <br/> 03 - Surph.flac  <br/>02 - Breakbeat Malaria.mp3  <br/> end | 01-Can&#39;t Knock The Hustle.mp3  <br/>02 - Breakbeat Malaria.mp3 <br/>03 - Axion.mp3 <br/>03 - Surph.flac <br/>07 - Ultra Thizz.flac <br/>09-99 Problems.mp3 <br/>12 - The Messenger.mp3 |
| -  <br/>02 - Guillotine.mp3 <br/>Death Grips - Takyon (Death Yon).mp3  <br/> 03. Started From The Bottom.mp3 <br/>Tuscan\_Leather\_V0.mp3 <br/>10. Big Shots.mp3 <br/>11 - Void (Internal Theory).mp3 <br/>01. Jynweythek.flac <br/>end | 01. Jynweythek.flac <br/>03. Started From The Bottom.mp3 <br/>10. Big Shots.mp3 <br/>Tuscan\_Leather\_V0.mp3 |

### Hints

- You can check if a string contains another string by using the **string.Contains(str)** method.

## 3.Equal Sum After Extraction

You will be given **two**** integer ****lists** on the first **two lines** (space-separated). **Remove** the elements in the **first list** from the elements in the **second list**. If an element from the first list occurs **more than once** in the second list, **remove all occurrences**.

After you remove the elements, check the **sum** of both lists. If the sum of both of them is **equal** , print &quot; **Yes. Sum: {sum}**&quot;. If not print the **absolute** difference between the two lists in the format &quot; **No. Diff: {sum}**&quot;.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 3 4 5 <br/>5 3 2 7 4 1 8 | Yes. Sum: 15 | first list: 1 2 3 4 5 <br/>second list: 5 3 2 7 4 1 8 <br/> <br/>elements to remove: 532 7 41 8 <br/>resulting list: 7 8 <br/> <br/>list1 sum: 1 + 2 + 3 + 4 + 5 = 15 <br/>list2 sum: 7 + 8 = 15 <br/> <br/>list1 sum == list2 sum -> Equal sum |
| 3 4 4 6 7 <br/>20 2 2 | Yes. Sum: 24 | no list1 elements present in list2 -> no removal <br/> <br/>list1 sum = 3 + 4 = 4 + 6 + 7 = 24 <br/>list2 sum = 20 + 2 + 2 = 24 |
| 8 7 9 8 7 <br/>1 2 3 8 4 | No. Diff: 29 | elements to remove: 1 2 3 8 4 <br/> <br/>list1 sum = 8 + 7 + 9 + 8 + 7 = 39 <br/>list2 sum = 1 + 2 + 3 + 4 = 10  <br/> <br/>list1 sum != list2 sum -> Diff: 39 - 10 = 29 |

## 4.Flip List Sides

You will receive an integer list on the first line of the input (space-separated). Leave the first, middle and last elements as they are. For every other element, **exchange** it with its **opposite indexed element** (**list[1]****list[length-2]** and so on…). After that, print the list on the console (space-separated).

_Note: If the list has an even number of elements, as there is no middle element,_ **flip** _all the elements_ **except** _for the_ **first** _and_ **last** _ones._

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 6 7 8 9 10 11 | 1 10 9 8 7 6 5 4 3 2 11 |
| 2 3 4 1 | 2 4 3 1 |
| 12 88 9 7 7623 84 2 1 8 97 | 12 8 1 2 84 7623 7 9 88 97 |

##5.\* Tear List in Half

You will receive a list of **integers** on the **first** input line (space-separated). Your task is to separate the list into **two** parts and perform the following operations:

### Constraints

The count of the input list elements will **always** be **even** and the elements will always be **between 10 and 99**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 11 22 33 451412 | 4 11 51 22 41 33 2 |
| 82 77 12 84 92 11 | 8 82 4 9 77 2 1 12 1 |
| 11 12 13 14 15 16 17 18 | 1 11 5 1 12 6 1 13 7 1 14 8 |

### Hints

- There is a certain arithmetic progression which can help you solve this problem:
  - Simulate the _splitting list -&gt; splitting numbers into digits -&gt; inserting to the left and right of the element_ action several times and pay attention to the indices you are inserting the numbers into.
  - Do this several times and you will find the progression by yourself.
  - It is the key to seeing at which index you need to insert the elements each time and it works no matter how many elements the list has as long as you follow it.

## 6.\* Stuck Zipper

You will be given **two** lists of **integers** on the first and second line of the input respectively (space-separated). We want to **zip** these two lists together like a **zipper** , but **one or several** of the elements in **either** of the lists are **too large** to allow that to happen. Being larger, they have **more digits** than the element with the smallest amount of digits in the two lists.

Your task is to find any elements which have **more digits** than the element with the least amount of digits in the list ( **if such exist** ) and **remove** them, then **zip** the lists together as shown in the example.

After you stack the lists, **print** the resulting list on the console (one line, space-separated).

### Constraints

The integers in both of the lists will always be in the range [1…1000000]

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 2 4 4 3 9 <br/> 4 1 3 2 7 | 4 2 1 4 3 4 2 3 7 9 | Nothing to remove – just zip the lists. <br/>Insert list1[0] into list2 at index 1, <br/>list1[1] into list2 at index 3, <br/>list1[2] into list2 at index 5, etc... |
| 2 12 4 3 9 <br/>22 1 3 88 7 | 1 2 3 4 7 3 9 | We find any elements which have more than **1 digits** in both lists. We then zip the two lists like so: <br/> <br/>Insert list1[0] into list2 at index 1, <br/>list1[1] into list2 at index 3, <br/>list1[2] into list2 at index 5, etc... |
| -156 91287223 -938 -923 <br/>-918 22282 -848 98127 | -918 -156 -848 -938 -923 | We find any elements which have more than **3 digits** and **remove** them. We then zip the two lists. |
| 81728 73234 89 9912 <br/> 2 5379 -5 92348 | 2 -5 | Find elements which have more than **1 digit** and **remove** them.Since we have nothing to zip (first list is empty), we just print what&#39;s left. |