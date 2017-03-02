#<p align="center"> Lists - More Exercises   <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/425#4).

## 1.Distinct List

You will be given a list of **integers** on the **first line** of the input (space-separated). **Remove** all **repeating elements** from the list.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 3 4 | 1 2 3 4 | No repeating elements |
| 7 8 9 7 2 3 4 1 2 | 7 8 9 2 3 4 1 | 7 and 2 are already present in the list -> remove them |
| 20 8 12 13 4 48 5 | 20 8 12 13 4 5 | 4 and 8 are already present in the list -> remove them |

## 2.Integer Insertion

You will receive a list of **integers** on the same line (separated by **one** space). On the next lines, you will start receiving a list of **strings** , until you receive the string &quot; **end**&quot;. Your task is to insert each string ( **converted** to integer) at a specific index in the list. The index is determined by the **first digit** of the **number**.

Example: 514 -> first digit – 5 -> insert 514 at the **5**

# th
 index of the list.

After you insert all the elements, print the list, separated by single spaces.

_The input will_ **always** _be valid and you don&#39;t need to explicitly check if you&#39;re inserting an element into a valid index._

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4 5 6 7 8 9 <br/> 25<br/>716<br/>2772<br/>1982<br/>8534<br/>2<br/>end | 1 1982 2 2 2772 25 3 4 5 8534 6 716 7 8 9 |
| 3 12 66 243 8766<br/>12<br/>33<br/>56<br/>end | 3 12 12 33 66 56 243 8766 |
| 9 9 9 9 9 9 9 9 9 9<br/>9<br/>9<br/>9<br/>9<br/>9<br/>end | 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 |

## 3.Camel&#39;s Back

The city is breaking down on a camel back. You will receive a sequence of **N**** integers**, (space-separated), which will represent the**buildings **in the city.  You will then receive an integer** M **, indicating the camel back&#39;s** size**.

The camel back is a **linear structure** standing **below** the city, in such a way that it has an **equal amount** of buildings to its **left** and **right**. The idea is, if every round – **one** building falls from the **left**** side **of the city, and** one **from the** right side **, how many** rounds** will it take for the city to stop breaking down?

As output you must print how many rounds it took before the city stopped breaking down as &quot; **{rounds} rounds**&quot;. On the next line, print what&#39;s left of the city (space-separated). Format: &quot;**remaining: {buildings (space-separated)}**&quot;

If no buildings have fallen, print &quot;**already stable: {buildings (space-separated)}**&quot;

Example: city with **9 elements** ; Camel back size: **5**

### Constraints

**N** and **M** will always be **odd** numbers. [1-1000] and **M** will always be **smaller or equal** to **N**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 12 45 61 34 21 345 62 11 94<br/>5 | 2 rounds<br/>remaining: 61 34 21 345 62 |
| 9 8 7 8 2<br/>5 | already stable: 9 8 7 8 2 |
| 8 7 8 1 2 3 8 7 2 44 3 212 11<br/>5 | 4 round<br/>sremaining: 2 3 8 7 2 |

## 4.Ununion Lists

You will be given a sequence of integers, separated by a space. This is the **primal list**. Then you will receive an **integer N**. On the next **N lines** , you will receive sequences of integers. Your task is to add all elements that the primal list **does not** contain from the **current sequence** to the **primal list** and then **remove** from the primal list, all elements which **are** contained in the current sequence of integers. If there are several occurrences, remove **all** occurrences you find.

After you are done receiving lists and manipulating the primal list, **sort** the primal list and **print** it.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 2 3 4 5<br/>3<br/>3 4 5 20 1<br/>16 2 1<br/>14 | 1 14 16 20 | Key:  -> remove from primal list <br/> -> add to primal <br/><br/>list Primal: 1 2 3 4 5<br/>List 1: 345201<br/>Primal after List 1: 2 20<br/>List 2: 1621<br/>Primal after List 2: 20 16 1<br/>List 3: 14<br/>Primal after List 3: 20 16 1 14<br/>Sorted primal list: 1 14 16 20 |
| 3 3 4 5 18 20<br/>2<br/>1 2 3<br/>18 20 | 1 2 4 5 | Primal: 3 3 4 5 18 20<br/>List 1: 123<br/>Primal after List 1: 4 5 18 20 1 2<br/>List 2: 1820<br/>Primal after List 2: 4 5 1 2<br/>Sorted primal list: 1 2 4 5 |
| 99 88 77 99 66 55<br/>5<br/>99<br/>88<br/>77<br/>66<br/>14 11 12 13 55 | 11 12 13 14 | Primal: 99 88 77 99 66 55<br/>List 1: 99<br/>Primal after List 1: 88 77 66 55<br/>List 2: 88<br/>Primal after List 2: 77 66 55<br/>List 3: 77<br/>Primal after List 3: 66 55<br/>List 4: 66<br/>Primal after List 4: 55<br/>List 5: 1411121355<br/>Primal after List 5: 14 11 12 13 <br/><br/> Sorted primal list: 11 12 13 14 |

## 5.\* Note Statistics

In music, certain frequencies correspond to certain musical notes (example: A -&gt; 440hz, C# -&gt; 554.37hz).

You will be given frequencies as **real numbers** on the first line of the input (space-separated). Your task is to **convert** the numbers to their **musical note representation** , then **separate** them into **naturals** (C, B, F and etc.) and **sharp** notes (C#, F#, A#, etc.). After that, print both lists in the console in the format described in the examples. After you print them, **sum** each list&#39;s frequencies and **print** it on the console, rounded to the second decimal place.

### Constraints

The frequencies in the input will be constrained to this chart:

| **Note** | **Frequency** |
| --- | --- |
| C | 261.63hz |
| C# | 277.18hz |
| D | 293.66hz |
| D# | 311.13hz |
| E | 329.63hz |
| F | 349.23hz |
| F# | 369.99hz |
| G | 392.00hz |
| G# | 415.30hz |
| A | 440.00hz |
| A# | 466.16hz |
| B | 493.88hz |

### Examples

| **Input** | **Output** |
| --- | --- |
| 293.66 311.13 293.66 311.13 349.23 349.23 | Notes: D D# D D# F F <br/>Naturals: D, D, F, F<br/>Sharps: D#, D#<br/>Naturals sum: 1285.78<br/>Sharps sum: 622.26 |
| 329.63 329.63 329.63 261.63 329.63 392.0 | Notes: E E E C E G<br/>Naturals: E, E, E, C, E, G<br/>Sharps: Naturals sum: 1972.15<br/>Sharps sum: 0 |
| 392.0 440.0 349.23 392.0 466.16 440.0 349.23 392.0 | Notes: G A F G A# A F G<br/>Naturals: G, A, F, G, A, F, G<br/>Sharps: A#<br/>Naturals sum: 2754.46<br/>Sharps sum: 466.16 |

_Bonus: you can feed the list of frequencies into_ **_Console.Beep(freq, duration)_** _to hear the tests_ 
