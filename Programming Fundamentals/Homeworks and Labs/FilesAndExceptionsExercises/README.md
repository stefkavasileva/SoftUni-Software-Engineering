# <p align="center"> Files And Exceptions - Exercises <p>

## 01.Most Frequent Number

Write a program that finds the **most frequent number** in a given sequence of numbers.

- Numbers will be in the range [0…65535].

- In case of multiple numbers with the same maximal frequency, print the leftmost of them.

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|4 1 1 4 2 3 4 4 1 2 4 9 3	|4|	The number 4 is the most frequent (occurs 5 times)|
|2 2 2 2 1 2 2 2	|2|	The number 2 is the most frequent (occurs 7 times)|
|7 7 7 0 2 2 2 0 10 10 10	|7|	The numbers 2, 7 and 10 have the same maximal frequence (each occurs 3 times). The leftmost of them is 7.|

## 02.Index of Letters
Write a program that creates an array containing all letters from the alphabet (a-z). Read a lowercase word from the console and print the **index of each of its letters in the letters array**.

#### Examples

|**Input**|**Output**|
|---|---|
|abcz	|a -> 0 <br/> b -> 1 <br/> c -> 2 <br/> z -> 25|
|softuni	|s -> 18 <br/> o -> 14 <br/> f -> 5 <br/> t -> 19 <br/> u -> 20 <br/> n -> 13 <br/> i -> 8|

## 03.Equal Sums
Write a program that determines if there **exists an element in the array** such that the **sum of the elements on its left** is **equal** to the **sum of the elements on its right**. If there are **no elements to the left / right**, their sum is considered to be 0. Print the index that satisfies the required condition or **“no”** if there is no such index.

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|1 2 3 3	|2|	At a[2] -> left sum = 3, right sum = 3 <br/> a[0] + a[1] = a[3]|
|1 2	|no|	At a[0] -> left sum = 0, right sum = 2 <br/> At a[1] -> left sum = 1, right sum = 0 <br/> No such index exists|
|1	|0|	At a[0] -> left sum = 0, right sum = 0|
|1 2 3	|no|	No such index exists|
|10 5 5 99 3 4 2 5 1 1 4	|3|	At a[3] -> left sum = 20, right sum = 20 <br/> a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]|

## 05.A Miner Task
You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity. Your task is to collect the resources and print them each on a new line. 
**Print the resources and their quantities in format:**
**{resource} –> {quantity}**
The quantities inputs will be in the range [1 … 2 000 000 000]

#### Examples

|**Input**|**Output**|
|---|---|
|Gold <br/> 155 <br/> Silver <br/> 10 <br/> Copper <br/> 17 <br/> stop|Gold -> 155 <br/> Silver -> 10 <br/> Copper -> 17|

## 06.Fix Emails
You are given a sequence of strings, each on a new line, **until you receive the “stop” command**. The first string is the **name** of a person. On the second line you will receive their **email**. Your task is to **collect** their **names** and **emails**, and **remove** emails whose domain **ends with "us"** or **"uk"** (case insensitive). Print:
**{name} – > {email}** 

#### Examples

|**Input**|**Output**|
|---|---|
|Ivan <br/> ivanivan@abv.bg <br/> Petar Ivanov <br/> petartudjarov@abv.bg <br/> Mike Tyson <br/> myke@gmail.us <br/> stop|Ivan -> ivanivan@abv.bg <br/> Petar Ivanov -> petartudjarov@abv.bg|

## 07.Advertisement Message
Write a program that **generate random fake advertisement message** to extol some product. The messages must consist of 4 parts: laudatory **phrase + event + author + city**. Use the following predefined parts:
- **Phrases** – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
- **Events** – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
- **Author** – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
- **Cities** – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
The format of the output message is: **{phrase} {event} {author} – {city}**.
As an input you take the **number of messages** to be generated. Print each random message at a separate line.

#### Examples

|**Input**|**Output**|
|---|---|
|3|Such a great product. Now I feel good. Elena – Ruse <br/> Excelent product. Makes miracles. I am happy of the results! Katya – Varna <br/> Best product of its category. That makes miracles. Eva - Sofia|

> #### Hints
> - Hold the **phrases, events, authors** and **towns** in 4 arrays of strings.
> - Create **Random** object and **generate 4 random numbers** each in its range:
> phraseIndex -> [0, phrases.Length)
> eventIndex -> [0, events.Length)
> authorIndex -> [0, authors.Length)
> townIndex -> [0, towns.Length)
> - Get one **random element** from each of the four arrays and **compose a message** in the required format.

## 08.Average Grades
Define a class **Student**, which holds the following information about students: **name, list of grades** and **average grade** (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.
Read a **list of students** and print the students that have **average grade ≥ 5.00** ordered **by name** (ascending), then by **average grade** (descending). Print the student name and the calculated average grade.

#### Examples

|**Input**|**Output**|
|---|---|
|3 <br/> Ivan 3 <br/> Todor 5 5 6 <br/> Diana 6 5.50|Diana -> 5.75 <br/> Todor -> 5.33|
|6 <br/> Petar 3 5 4 3 2 5 6 2 6 <br/> Mitko 6 6 5 6 5 6 <br/> Gosho 6 6 6 6 6 6 <br/> Ani 6 5 6 5 6 5 6 5 <br/> Iva 4 5 4 3 4 5 2 2 4 <br/> Ani 5.50 5.25 6.00|Ani -> 5.58 <br/> Ani -> 5.50 <br/> Gosho -> 6.00 <br/> Mitko -> 5.67|

> #### Hints
> - Create class **Student** with properties **Name (string), Grades (double[])**, and property **AverageGrade** (calculated by LINQ as **Grades.Average()**, read-only).
> - Make a **list of students** and **filter with LINQ** all students that has average **grade >= 5.00**.
> - Print the filtered students **ordered by name** in ascending order, then by **average grade** in descending order.

## 09.Book Library 
To model a **book library**, define classes to hold a **book** and a **library**. The library must have a **name** and a **list of books**. The books must contain the **title, author, publisher, release date, ISBN-number** and **price**. 
Read a **list of books**, add them to the library and print the **total sum of prices by author**, ordered **descending by price** and **then by author’s name lexicographically**.
Books in the input will be in format **{title} {author} {publisher} {release date} {ISBN} {price}**.

#### Examples

|**Input**|**Output**|
|---|---|
|5 <br/> LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00 <br/> Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25 <br/> HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50 <br/> HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00 <br/> AC OBowden PenguinBooks 20.11.2009 0395082555 14.00|Tolkien -> 40.25 <br/> JKRowling -> 35.50 <br/> OBowden -> 14.00|

> #### Hints
> - Create classes **Book** and **Library** with all the mentioned above properties. 
![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/files1.png)
> - **Create** an object of type **Library**.
> - **Read the input** and create a **Book** object for each book in the input.
> - Create a **LINQ** query that will **sum the prices by author, order the results** as requested.
> - **Print** the results.

## 10.Book Library Modification
Use the classes from the previous problem and make a program that **read a list of books** and **print all titles released after given date** ordered **by date** and then **by title lexicographically**. The date is given if format **“day-month-year”** at the last line in the input.

#### Examples

|**Input**|**Output**|
|---|---|
|5 <br/> LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00 <br/> Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25 <br/> HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50 <br/> HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00 <br/> AC OBowden PenguinBooks 20.11.2009 0395082555 14.00 <br/> 30.07.1954|HP1 -> 26.06.1997 <br/> HP7 -> 21.07.2007 <br/> AC -> 20.11.2009|