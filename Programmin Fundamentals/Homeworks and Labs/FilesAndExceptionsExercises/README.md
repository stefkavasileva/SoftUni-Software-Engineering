#<p align="center"> Files And Exceptions - Exercises <p>

##01.Most Frequent Number

Write a program that finds the **most frequent number** in a given sequence of numbers.

- Numbers will be in the range [0…65535].

- In case of multiple numbers with the same maximal frequency, print the leftmost of them.

##02.Index of Letters
Write a program that creates an array containing all letters from the alphabet (a-z). Read a lowercase word from the console and print the **index of each of its letters in the letters array**.

##03.Equal Sums
Write a program that determines if there **exists an element in the array** such that the **sum of the elements on its left** is **equal** to the **sum of the elements on its right**. If there are **no elements to the left / right**, their sum is considered to be 0. Print the index that satisfies the required condition or **“no”** if there is no such index.

## 04.A Miner Task
You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity. Your task is to collect the resources and print them each on a new line. 
**Print the resources and their quantities in format:**
**{resource} –> {quantity}**
The quantities inputs will be in the range [1 … 2 000 000 000]

## 05.Fix Emails
You are given a sequence of strings, each on a new line, **until you receive the “stop” command**. The first string is the **name** of a person. On the second line you will receive their **email**. Your task is to **collect** their **names** and **emails**, and **remove** emails whose domain **ends with "us"** or **"uk"** (case insensitive). Print:
**{name} – > {email}** 

## 06.Advertisement Message
Write a program that **generate random fake advertisement message** to extol some product. The messages must consist of 4 parts: laudatory **phrase + event + author + city**. Use the following predefined parts:
- **Phrases** – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
- **Events** – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
- **Author** – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
- **Cities** – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
The format of the output message is: **{phrase} {event} {author} – {city}**.
As an input you take the **number of messages** to be generated. Print each random message at a separate line.

####Hints

- Hold the **phrases, events, authors** and **towns** in 4 arrays of strings.
- Create **Random** object and **generate 4 random numbers** each in its range:
phraseIndex -> [0, phrases.Length)
eventIndex -> [0, events.Length)
authorIndex -> [0, authors.Length)
townIndex -> [0, towns.Length)
- Get one **random element** from each of the four arrays and **compose a message** in the required format.

## 06.Average Grades
Define a class **Student**, which holds the following information about students: **name, list of grades** and **average grade** (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.
Read a **list of students** and print the students that have **average grade ≥ 5.00** ordered **by name** (ascending), then by **average grade** (descending). Print the student name and the calculated average grade.

####Hints

- Create class **Student** with properties **Name (string), Grades (double[])**, and property **AverageGrade** (calculated by LINQ as **Grades.Average()**, read-only).
- Make a **list of students** and **filter with LINQ** all students that has average **grade >= 5.00**.
- Print the filtered students **ordered by name** in ascending order, then by **average grade** in descending order.

## 07.Book Library 
To model a **book library**, define classes to hold a **book** and a **library**. The library must have a **name** and a **list of books**. The books must contain the **title, author, publisher, release date, ISBN-number** and **price**. 
Read a **list of books**, add them to the library and print the **total sum of prices by author**, ordered **descending by price** and **then by author’s name lexicographically**.
Books in the input will be in format **{title} {author} {publisher} {release date} {ISBN} {price}**.

####Hints
- Create classes **Book** and **Library** with all the mentioned above properties. 
- **Create** an object of type **Library**.
- **Read the input** and create a **Book** object for each book in the input.
- Create a **LINQ** query that will **sum the prices by author, order the results** as requested.
- **Print** the results.

## 08.Book Library Modification
Use the classes from the previous problem and make a program that **read a list of books** and **print all titles released after given date** ordered **by date** and then **by title lexicographically**. The date is given if format **“day-month-year”** at the last line in the input.
