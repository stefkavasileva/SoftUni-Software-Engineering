# <p align="center"> Strings and Text Processing - Lab <p>

## 01.Reverse string
Write a program that reads a string from the console, reverses it and prints the result back at the console.

#### Examples

|**Input**|**Output**|
|---|---|
|sample	|elpmas|
|24tvcoi92	|29iocvt42|

## 02.Count substring occurrences
Write a program to **find how many times a given string appears in a given text as substring**. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the **character casing. Overlapping** between occurrences is **allowed**. 

#### Examples

|**Input**|**Output**|
|---|---|
|Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell. <br/> wel|4|
|aaaaaa <br/> aa|5|
|ababa caba <br/> aba|3|
|Welcome to SoftUni <br/> Java|0|

## 03.Text filter
Write a program that takes a **text** and a **string of banned words**. All words included in the ban list should be replaced with **asterisks "*"**, equal to the word's length. The entries in the ban list will be separated by a **comma** and **space** ", ".
The ban list should be entered on the first input line and the text on the second input line.

#### Examples

|**Input**|**Output**|
|---|---|
|Linux, Windows <br/> It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client|It is not \*\*\*\*\*, it is GNU/\*\*\*\*\*. \*\*\*\*\* is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client|

## 04.Palindromes
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only **unique** palindromes, **sorted** lexicographically.

#### Examples

|**Input**|**Output**|
|---|---|
|Hi,exe? ABBA! Hog fully a string. Bob	|a, ABBA, exe|
