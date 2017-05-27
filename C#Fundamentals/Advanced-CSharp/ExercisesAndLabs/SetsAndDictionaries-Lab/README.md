# <p align="center"> Lab: Sets And Dictionaries </p>

Problems for exercises and homework for the [&quot;C# Advanced&quot; course @ SoftUni](https://softuni.bg/trainings/1633/csharp-advanced-may-2017).

You can check your solutions here: [https://judge.softuni.bg/Contests/589/Sets-and-Dictionaries-Lab](https://judge.softuni.bg/Contests/589/Sets-and-Dictionaries-Lab)

# I.Sets

## 1.Parking Lot

Write program that:

- Record **car number** for every car that enter in **parking lot**
- Remove **car number** when the car go out
- Input will be string in format **[direction, carNumber]**
- input end with string **&quot;**END**&quot;**

Print the output with all car numbers which are in parking lot

#### Examples

| **Input** | **Output** |
| --- | --- |
| IN, CA2844AA <br/> IN, CA1234TA <br/> OUT, CA2844AA <br/> IN, CA9999TT <br/> IN, CA2866HI <br/> OUT, CA1234TA <br/> IN, CA2844AA <br/> OUT, CA2866HI <br/> IN, CA9876HH <br/> IN, CA2822UU <br/> END | CA2822UU <br/> CA2844AA <br/> CA9876HH <br/> CA9999TT |
| IN, CA2844AA <br/> IN, CA1234TA <br/> OUT, CA2844AA <br/> OUT, CA1234TA <br/> END | Parking Lot is Empty |

> #### Hints
> - Car numbers are **unique**
> - For print, first ask if set is empty

#### Solution

You might help yourself with the code below:

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/2.PNG)

## 2. SoftUni Party

There is a party in SoftUni. Many guests are invited and they are two type VIP and regular. When guest come check if he/she exist in any of two reservation lists

All reservation numbers will be with 8 chars

All VIP numbers start with digit

There will be 2 command lines. First is &quot;PARTY&quot; - party is on and guests start coming. Second is &quot;END&quot; – then party is over and no more guest will come

Output have to all guest, who didn&#39;t come to the party (VIP must be first)

#### Examples

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 7IK9Yo0h <br/> 9NoBUajQ <br/> Ce8vwPmE <br/> SVQXQCbc <br/> tSzE5t0p <br/> PARTY <br/> 9NoBUajQ <br/> Ce8vwPmE <br/> SVQXQCbc <br/> END|2 <br/> 7IK9Yo0h <br/> tSzE5t0p|m8rfQBvl <br/> fc1oZCE0 <br/> UgffRkOn <br/> 7ugX7bm0 <br/> 9CQBGUeJ <br/> 2FQZT3uC <br/> dziNz78I <br/> mdSGyQCJ <br/> LjcVpmDL <br/> fPXNHpm1 <br/> HTTbwRmM <br/> B5yTkMQi <br/> 8N0FThqG <br/> xys2FYzn <br/> MDzcM9ZK <br/> PARTY <br/> 2FQZT3uC <br/> dziNz78I <br/> mdSGyQCJ <br/> LjcVpmDL <br/> fPXNHpm1 <br/> HTTbwRmM <br/> B5yTkMQi <br/> 8N0FThqG <br/> m8rfQBvl <br/> fc1oZCE0 <br/> UgffRkOn <br/> 7ugX7bm0 <br/> 9CQBGUeJ <br/> END|2 <br/> MDzcM9ZK <br/> xys2FYzn|

#### Hints

- All string starts with digit are alphabetical before string starts with letter

# II. Dictionaries

## 3. Count Same Values in Array

Write a program that counts in a given array of double values the number of occurrences of each value.

#### Examples

| **Input** | **Output** |
| --- | --- |
| -2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3  | -5,5 – 1 times <br/> -2,5 – 3 times <br/> 3 – 4 times <br/> 4 – 2 times |
| 2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3  | 2 - 3 times <br/> 3 - 7 times <br/> 4 - 6 times <br/> 5 - 4 times |

> #### Hints
> - Use SortedDictionary() for correct result, because you can&#39;t be sure what kind of hash algorithm is used in Judge.

## 4.Academy Graduation

Write a program that:

- Read from console **number** of student for a track
- Read on **pair of rows** :
  - First line is **name** of student
  - Second line is his **score** for different number of courses
- Print on console &quot; **{name}** is graduated with **{average scores)** &quot;

#### Examples

| **Input** | **Output** |
| --- | --- |
| 3 <br/> Gosho <br/> 3.75 5 <br/> Mara4.25 6 <br/> Pesho<br/> 6 4.5 | Gosho is graduated with 4.375 <br/> Mara is graduated with 5.125 <br/> Pesho is graduated with 5.25 |
| 5 <br/> Gruio <br/> 4.36 5.50 3.30 5.63 2.57 5.75 2.81 4.89 <br/> Trendafilka<br/> 3.10 5.35 3.30 3.35 5.64 4.99 2.75 4.68<br/>  Mite<br/> 3.45 3.23 3.03 5.42 5.46 4.15 2.26 5.95 <br/>  Roza <br/>  2.08 3.48 3.36 2.73 2.96 4.54 3.70 3.85 <br/> Ganio <br/> 4.75 4.92 3.78 4.79 4.82 4.75 2.81 2.13 | Ganio is graduated with 4.09375 <br/> Gruio is graduated with 4.35125 <br/> Mite is graduated with 4.11875 <br/> Roza is graduated with 3.3375 <br/> Trendafilka is graduated with 4.145 |

> #### Hints
> - Think about **proper type** of dictionary
> - **Value** can be **array**