#<p align="center"> Debugging - Exercises  <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/420#3).

## 1.Debugging Exercise: Tricky Strings

The goal of this exercise is to practice **debugging techniques** in scenarios where a piece of code does not work correctly. Your task is to **pinpoint the 4 bugs** and **fix them** (without rewriting the entire code).

You can download the broken solution from [here](https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code-Exercises-Broken-Solutions.zip).

### Problem Description

You are given a **delimiter**. On the next line, you will receive a number **N.** On the next **N lines** , you will receive **strings** on each line. Your task is to **print** the strings, **separated** by the **delimiter**.

Note: the delimiter and strings could be **anything** : whitespace and empty stringsare **acceptable input**!

### Examples

| **Input** | **Program Output**** (Wrong) **|** Expected Output (Correct)** |
| --- | --- | --- |
| - <br/>5<br/>I<br/>Am<br/>Five<br/>Strings<br/>Long | I-IAm-IAmFive-IAmFiveStrings-IAmFiveStringsLong-IAmFiveStringsLong- | I-Am-Five-Strings-Long |
| \_<br/>5<br/>you<br/>cannot<br/><br/> trickme | you\_youcannot\_youcannot\_youcannottrick\_youcannottrickme\_youcannottrickme\_ | you\_cannot\_\_trick\_me |
| &#39;<br/>7<br/>S<br/>o<br/>f<br/>t<br/>U<br/>n<br/>i | S&#39;So&#39;Sof&#39;Soft&#39;SoftU&#39;SoftUn&#39;SoftUni&#39;SoftUni&#39; | S&#39;o&#39;f&#39;t&#39;U&#39;n&#39;i |

### Hints

- Download the source code and get familiar with it
- Deal with poor code formatting - Remove unnecessary blank lines, indent the code properly
- Fix method parameters naming
- Give methods a proper name

## 2.Debugging Exercise: Triangle Formations

The goal of this exercise is to practice **debugging techniques** in scenarios where a piece of code does not work correctly. Your task is to **pinpoint the bugs** and **fix them** (without rewriting the entire code).

You can download the broken solution from [here](https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code-Exercises-Broken-Solutions.zip).

### Problem Description

You are given **3 integer numbers: a , b and c **, which will represent the** 3 sides of a triangle **. Your task is to check whether the triangle is** valid**.

If it is, print &quot; **Triangle is valid.**&quot;.
Otherwise print &quot; **Invalid Triangle.**&quot; and **end the program**.

If it is valid, you have to check if it is a **right triangle** (a *a + b * b == c * c)
If it is a right triangle, print &quot; **Triangle has a right angle between sides a and b**&quot;, depending on which side forms a **right angle**. If the sides **b** and **c** form a right angle, print &quot; **Triangle has a right angle between sides b and c**&quot;, and so on.
### Examples

| **Input** | **Program Output**** (Wrong) **|** Expected Output (Correct)** |
| --- | --- | --- |
| 3<br/>4<br/>5 | Invalid Triangle.<br/>Triangle has a right angle between sides a and b | Triangle is valid.<br/>Triangle has a right angle between sides a and b |
| 5<br/>5<br/>5 | Invalid Triangle.<br/>Triangle has no right angles. | Triangle is valid.<br/>Triangle has no right angles |
| 3<br/>1<br/>1 | Invalid Triangle.<br/>Triangle has no right angles. | Invalid Triangle. |

### Hints

- Download the source code and get familiar with it
- Deal with poor code formatting - Remove unnecessary blank lines, indent the code properly
- Fix method parameters naming
- Give methods a proper name
