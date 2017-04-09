# <p align="center"> Files And Exceptions - Lab <p>

## 01.Odd Lines
Write a program that reads a text file and writes its every **odd** line in another file. Line numbers starts from 0. 

#### Examples

|**Input.txt**|**Output.txt**|
|---|---|
|Two households, both alike in dignity, <br/> In fair Verona, where we lay our scene, <br/> From ancient grudge break to new mutiny, <br/> Where civil blood makes civil hands unclean. <br/> From forth the fatal loins of these two foes <br/> A pair of star-cross'd lovers take their life; <br/> Whose misadventured piteous overthrows <br/> Do with their death bury their parents' strife.|In fair Verona, where we lay our scene, <br/> Where civil blood makes civil hands unclean. <br/> A pair of star-cross’d lovers take their life; <br/> Do with their death bury their parents’ strife|

## 02.Line Numbers
Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. 

#### Examples

|**Input.txt**|**Output.txt**|
|---|---|
|Two households, both alike in dignity, <br/> In fair Verona, where we lay our scene, <br/> From ancient grudge break to new mutiny, <br/> Where civil blood makes civil hands unclean. <br/> From forth the fatal loins of these two foes <br/> A pair of star-cross'd lovers take their life; <br/> Whose misadventured piteous overthrows <br/> Do with their death bury their parents' strife.|1.	Two households, both alike in dignity, <br/> 2.	In fair Verona, where we lay our scene, <br/> 3.	From ancient grudge break to new mutiny, <br/> 4.	Where civil blood makes civil hands unclean. <br/> 5.	From forth the fatal loins of these two foes <br/> 6.	A pair of star-cross'd lovers take their life; <br/> 7.	Whose misadventured piteous overthrows <br/> 8.	Do with their death bury their parents' strife.|

## 03.Word Count
Write a program that reads a list of words from the file **words.txt** and finds how many times each of the words is contained in another file **text.txt**. Matching should be **case-insensitive**.
The result should be written to another text file. Sort the words by frequency in descending order. 
#### Examples

|**words.txt**|**Input.txt**|**Output.txt**|
|---|---|---|
|quick is fault|-I was quick to judge him, but it wasn't his fault. <br> -Is this some kind of joke?! Is it? <br> -Quick, hide here…It is safer.|is - 3 <br/> quick - 2 <br/> fault - 1|

## 04.Merge Files
Write a program that **reads** the contents of **two** text **files** and **merges them** together into a third one.

#### Examples

|**Input1.txt**|**Input2.txt**|**Output.txt**|
|---|---|---|
|1 <br/> 3 <br/> 5 |2 <br/> 4 <br/> 6	|1 <br/> 2 <br/> 3 <br/> 4 <br/> 5 <br/> 6|

## 05.Folder Size
You are given a folder named “TestFolder”. Get the size of all files in the folder, which are **NOT directories**. The result should be written to another text file in **Megabytes**.

#### Example

|**Output.txt**|
|---|
|5.16173839569092|