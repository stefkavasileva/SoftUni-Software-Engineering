#<p align="center"> Arrays - Exercises <p>

## 01.Largest Common End
Read **two arrays of words** and find the length of the **largest common end** (left or right).

####Hints

- Scan the arrays from left to right until the end of the shorter is reached and count the equal elements.
- Scan the arrays form right to left until the start of the shorter is reached.
- Keep the start position and the length of the longest equal start / end.

## 02.Rotate and Sum
To “**rotate an array on the right**” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
Write a program to read an array of **n integers** (space separated on a single line) and an integer **k**, rotate the array right **k times** and sum the obtained arrays **after each rotation**.

####Hints

- After r rotations the element at position **i** goes to position **(i + r) % n**.
- The **sum[]** array can be calculated by two nested loops: for **r = 1 … k; for i = 0 … n-1**.

## 03.Fold and Sum 
Read an array of **4*k** integers, fold it, and print the sum of the upper and lower two rows (each holding **2 * k** integers).

####Hints
- Create the **first row** after folding: the first k numbers reversed, followed by the last k numbers reversed.
- Create the **second row** after folding: the middle **2*k** numbers.
- Sum the first and the second rows.

## 04.Sieve of Eratosthenes
Write a program to find **all prime numbers in range [1…n]**. Implement the algorithm called “Sieve of Eratosthenes”: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes. Steps in the “Sieve of Eratosthenes” algorithm:
1.	Assign **primes[0…n] = true**
2.	Assign **primes[0] = primes[1] = false**
3.	Find the smallest **p**, which holds **primes[p] = true**
- Print **p** (it is prime)
- Assign **primes[2*p] = primes[3*p] = primes[4*p] = … = false**
4.	Repeat for the next smallest **p < n**.

## 05.Compare Char Arrays
**Compare two char arrays lexicographically** (letter by letter).
Print the them in alphabetical order, each on **separate line**

####Hints
- Compare the first letter of arr1[] and arr2[], if equal, compare the next letter, etc.
- If all letters are equal, the smaller array is the shorter.
- If all letters are equal and the array lengths are the same, the arrays are equal.

## 06.Max Sequence of Equal Elements
Write a program that finds the **longest sequence of equal elements** in an array of integers. If several longest sequences exist, print the leftmost one.

####Hints
- Start with the sequence that consists of the first element: **start=0, len=1.**
- Scan the elements from left to right, starting at the second element: **pos=1…n-1**.
At each step compare the current element with the element on the left.
Same value -> you have found a sequence longer by one -> l**en++**.
Different value -> start a new sequence from the current element: **start=pos, len=1**.
After each step remember the sequence it is found to be longest at the moment: **bestStart=start, bestLen=len**.
- Finally, print the longest sequence by using **bestStart** and **bestLen**.

## 07.Max Sequence of Increasing Elements
Write a program that finds the **longest increasing subsequence** in an array of integers. The longest increasing subsequence is a **portion of the array** (subsequence) that is strongly increasing and has the **longest possible length**. If several such subsequences exist, find the left most of them.

####Hints

- Use the same algorithm like in the previous problem (Max Sequence of Equal Elements).

##08.Most Frequent Number

Write a program that finds the **most frequent number** in a given sequence of numbers.

- Numbers will be in the range [0…65535].

- In case of multiple numbers with the same maximal frequency, print the leftmost of them.

##09.Index of Letters
Write a program that creates an array containing all letters from the alphabet (a-z). Read a lowercase word from the console and print the **index of each of its letters in the letters array**.

##10.Pairs by Difference
Write a program that **count the number of pairs** in given array **which difference is equal to given number**.

####Input

- The **first line** holds the **sequence of numbers**.
- The **second line** holds the **difference**.

##11.Equal Sums
Write a program that determines if there **exists an element in the array** such that the **sum of the elements on its left** is **equal** to the **sum of the elements on its right**. If there are **no elements to the left / right**, their sum is considered to be 0. Print the index that satisfies the required condition or **“no”** if there is no such index.
