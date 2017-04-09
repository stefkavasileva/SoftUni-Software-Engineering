# <p align="center"> Git, GitHub, Debugging, Searching - Lab <p>

## 01.**Debug the Code:** __Holidays between Two Dates__

You are assigned to **find and fix the bugs** in an existing piece of code, using the Visual Studio **debugger**. You should

trace the program execution to find the lines of code that produce incorrect or unexpected results.

You are given a program (existing source code) that aims to count the non-working days between two dates given

in format **day.month.year** (e.g. between __1.05.2015__ and __15.05.2015__ there are **5** non-working days – Saturday and

Sunday).
You can **find the broken code** in the judge system: https://judge.softuni.bg/Contests/204/Git-GitHub-Debugging-Searching-Lab. 

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|1.05.2016 <br/> 15.05.2016 |5| There are 5 non-working days (Saturday / Sunday) in this period: <br/> 1-May- 2016, 7-May- 2016, 8-May- 2016, 14-May- 2016, 15-May- 2016|
|1.5.2016 <br/> 2.5.2016 |1| Only 1 non-working day in the specified period: 1.05.2016 (Sunday)|
|15.5.2020 <br/> 10.5.2020 |0| The second date is before the first. No dates in the range.|
|22.2.2020 <br/> 1.3.2020 |4|Two Saturdays and Sundays: <br/> 22.02.2020 and 23.02.2020 <br/> 29.02.2020 and 1.03.2020 |

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/debugging1.png)

## 02.**Search in Google:** __Double Palindromes__

You are assigned to **write a program** that prints the **first 129** numbers that are **palindromes** and their **binary** representation is also a **palindrome**.