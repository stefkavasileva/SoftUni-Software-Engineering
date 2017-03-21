# <p align="center"> Lists - Exercises <p>

## 01.Max Sequence of Equal Elements
Read a **list of integers** and find the **longest sequence of equal elements**. If several exist, print the **leftmost**.

#####Hints

- Scan positions **p** from left to right and keep the **start** and **length** of the current sequence of equal numbers ending at p.
- Keep also the currently best (longest) sequence (**bestStart + bestLength**) and update it after each step

## 02.** Longest Increasing Subsequence (LIS)
Read a **list of integers** and find the **longest increasing subsequence (LIS)**. If several such exist, print the **leftmost**.

####Hints

- Assume we have n numbers in an array **nums[0…n-1]**.
- Let **len[p]** holds the length of the longest increasing subsequence (LIS) ending at position **p**.
- In a for loop, we calculate shall **len[p]** for **p = 0 … n-1** as follows:
Let **left** is the leftmost position on the left of **p (left < p)**, such that **len[left]** is the maximal possible.
Then, **len[p] = 1 + len[left]**. If **left** does not exist, **len[p] = 1**.
Also save **prev[p] = left** (we hold if **prev[]** the previous position, used to obtain the best length for position **p**).
- Once the values for **len[0…n-1]** are calculated, restore the LIS starting from position **p** such that **len[p]** is maximal and go back and back through **p = prev[p]**.

##03.*Array Manipulator
Write a program that r**eads an array of integers** from the console and **set of commands** and **executes them over the array**. The commands are as follows:
- **add <index> <element>** – adds element at the specified index (elements right from this position inclusively are shifted to the right).
- **addMany <index> <element 1> <element 2> … <element n>** – adds a set of elements at the specified index.
- **contains <element>** – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found.
- **remove <index>** – removes the element at the specified index.
- **shift <positions> – shifts every element** of the array the number of positions **to the left** (with rotation).
For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
- **sumPairs** – sums the elements in the array by pairs (first + second, third + fourth, …).
For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
- **print** – stop receiving more commands and print the last state of the array.

##04.Sum Reversed Numbers
Write a program that reads sequence of numbers, reverses their digits, and prints their sum.

##05.Bomb Numbers
Write a program that **reads sequence of numbers** and **special bomb number** with a certain **power**. Your task is to **detonate every occurrence of the special bomb number** and according to its power **his neighbors from left and right**. Detonations are performed from left to right and all detonated numbers disappear. Finally print the **sum of the remaining elements** in the sequence.
