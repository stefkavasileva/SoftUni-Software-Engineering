#<p align="center"> Dictionaries, Lambda and LINQ - Lab <p>

## 01.Count Real Numbers
Read a **list of real numbers** and **print them in ascending order** along with their **number of occurrences**.

####Hints

- Use **SortedDictionary<double, int>** named **counts**.
- Pass through each input number **num** and increase **counts[num]** (when **num** exists in the dictionary) or assign **counts[num] = 1** (when **num** does not exist in the dictionary).
- Pass through all numbers **num** in the dictionary **(counts.Keys)** and print the number **num** and its count of occurrences **counts[num]**.

## 02. Odd Occurrences
Write a program that extracts from a given sequence of words all elements that present in it **odd number of times** (case-insensitive).
- Words are given in a single line, space separated.
- Print the result elements in lowercase, in their order of appearance.

####Hints

- Use a **dictionary (string -> int)** to count the occurrences of each word (just like in the previous problem).
- Pass through all **key-value pairs** in the dictionary and append to the results list all **keys** that have **odd value**.
- Print the results list.

## 03.Sum, Min, Max, Average
Write a program to read n integers and print their *sum, min, max, first, last** and **average** values.

####Hints

- Include the **“System.Linq”** namespace to enable aggregate functions.
- Read the input array **nums[]**.
- Use **nums.Min()**, **nums.Max()**, etc.

## 04.Largest 3 Numbers
Read a **list of real numbers** and **print largest 3 of them**. If less than 3 numbers exit, print all of them.

####Hints
You can use LINQ query like this: **nums.OrderByDescending(x => x).Take(3)**.

## 05.Short Words Sorted
Read a **text**, extract its **words**, find all **short words** (less than 5 characters) and print them **alphabetically**, in **lowercase**.

- Use the following separators: **. , : ; ( ) [ ] " ' \ / ! ?** (space).
- Use case-insensitive matching.
- Remove duplicated words.

####Hints
- To extract the words from the input text, **split** by the specified separators.
- Use a **LINQ** expression:
Filter by word length: **Where(…)**
Order by word: **OrderBy(…)**
Use **distinct** to avoid repeated words: **Distinct()**.

## 06.Fold and Sum
Read an array of **4*k integers, fold** it like shown below, and **print the sum** of the upper and lower rows (**2*k integers**).

####Hints

Use a LINQ expression:

- Row 1, left part: take the **first k** numbers and **reverse**.
- Row 1, right part: **reverse** and take the **first k** numbers.
- **Concatenate** the **left** and the **right** part of row 1.
- Row 2: skip the **first k** numbers and take the next **2*k** numbers.
- Sum the arrays **row1** and **row2: var sum = row1.Select((x, index) => x + row2[index])**.
