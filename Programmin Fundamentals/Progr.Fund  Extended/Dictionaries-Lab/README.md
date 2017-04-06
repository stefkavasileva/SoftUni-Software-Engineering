# 1.Lab: Dictionaries

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions here: [https://judge.softuni.bg/Contests/174/Dictionaries-Lambda-and-LINQ-Lab](https://judge.softuni.bg/Contests/174/Dictionaries-Lambda-and-LINQ-Lab).

# 01.Count Real Numbers

Read a **list of real numbers** and **print them in ascending order** along with their **number of occurrences**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 8 2.5 2.5 8 2.5 | 2.5 -&gt; 3 times<br/>8 -&gt; 2 times |
|1.5 5 1.5 3 | 1.5 -&gt; 2 times<br/>3 -&gt; 1 times<br/>5 -&gt; 1 times |
|-2 0.33 0.33 2 | -2 -&gt; 1 times<br/>0.33 -&gt; 2 times<br/>2 &gt; 1 times |

>### Hints
>
>- Use **SortedDictionary&lt;double,**** int&gt; **named** counts**.
>- Pass through each input number **num** and increase **counts[num]** (when **num** exists in the dictionary) or assign **counts[num]** = **1** (when **num** does not exist in the dictionary).
>- Pass through all numbers **num** in the dictionary ( **counts.Keys** ) and print the number **num** and its count of occurrences **counts[num]**.

# 02.Odd Occurrences

Write a program that extracts from a given sequence of words all elements that present in it **odd number of times** (case-insensitive).

- Words are given in a single line, space separated.
- Print the result elements in lowercase, in their order of appearance.

### Examples

| **Input** | **Output** |
| --- | --- |
| Java C# PHP PHP JAVA C java | java, c#, c |
| 3 5 5 hi pi HO Hi 5 ho 3 hi pi | 5, hi |
| a a A SQL xx a xx a A a XX c | a, SQL, xx, c |

>### Hints
>
>- Use a **dictionary** ( **string**** int**) to count**the occurrences of each word (just like in the previous problem)**.
>- Pass through all **key-value pairs** in the dictionary and append to the results list all **keys** that have **odd value**.
>- Print the results list.