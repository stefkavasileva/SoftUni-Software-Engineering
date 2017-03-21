# <p align="center"> Objects and Classes - Lab <p>

## 01.Day of Week
You are given a **date** in format **day-month-year**. Calculate and print the **day of week** in **English**.

####Hints

- **Read the date as string** from the Console.
- Use the method **DateTime.ParseExact(string date, format, provider)** to convert the input string to object of type **DateTime**. Use format **“d-M-yyyy”** and **CultureInfo.InvariantCulture**.
Alternatively split the input by **“-“** and you will get the day, month and year as numbers. Now you can create new DateTime(year, month, day).
- The newly created **DateTime** object has property DayOfWeek.

## 02.Randomize Words
You are given a **list of words in one line. Randomize their order** and print each word at a separate line.

####Hints

- **Split** the input string by (space) and create an **array of words**.
- Create a random number generator – an object **rnd** of type **Random**.
- In a **for-loop exchange each number** at positions 0, 1, … **words.Length-1** by a number at **random position**. To generate a random number in range use **rnd.Next(minValue, maxValue)**. Note that by definition **minValue** is **inclusive**, but **maxValue** is **exclusive**.
- Print each word in the array on new line.

## 03.Big Factorial
Calculate and print **n!** (n factorial) for very big integer n (e.g. 1000).

####Hints
- Use the class **BigInteger** from the built-in **.NET library** System.Numerics.dll.

## 04.Distance Between Points
Write a method to calculate the distance between two points **p1 {x1, y1}** and **p2 {x2, y2}**. Write a program to read **two points** (given as two integers) and print the **Euclidean distance** between them.

####Hints
- Create a **class Point** holding properties **X** and **Y**.
- Write a method **CalcDistance(Point p1, Point p2)** that returns the distance between the given points – a **double** number.
- Use formula to calculate the distance between two points. 

## 05.Closest Two Points
Write a program to read **n** points and find the **closest two** of them.

####Input

The **input** holds the number of points **n** and **n** lines, each holding a point {**X** and **Y** coordinate}.

####Output

- The **output** holds the shortest distance and the closest two points.
- If several pairs of points are equally close, print **the first** of them (from top to bottom). 

####Hints
- Use the **class Point** you created in the previous task.
- Create an array **Point[] points** that will keep all points.
- Create a method **Point[] FindClosestPoints(Point[] points)** that will check distance **between every two pairs** from the array of points and returns the two closest points in a new array.
- Print the **closest distance** and the **coordinates** of the two closest points.

## 06.Rectangle Position
Write a program to **read two rectangles** {left, top, width, height} and print whether the first is inside the second.
The input is given as two lines, each holding a rectangle, described by 4 integers: **left, top, width** and **height**.

####Hints
- Create a class **Rectangle** holding properties **Top, Left, Width** and **Height**.
- Define calculated properties **Right** and **Bottom**.
- Define a method **bool IsInside(Rectangle r)**. A rectangle **r1** is inside another rectangle **r2** when:
**r1.Left ≥ r2.Left**
**r1.Right ≤ r2.Right**
**r1.Top ≤ r2.Top**
**r1.Bottom ≤ r2.Bottom**
- Create a method to **read** a **Rectangle**.
- Combine all methods into a single program.

## 07.Sales Report
Write a class **Sale** holding the following data: **town, product, price, quantity**. Read a **list of sales** and calculate and print the **total sales by town** as shown in the output. Order **alphabetically** the towns in the output.

####Hints

- Define the class **Sale** holding properties **Town, Product, Price** and **Quantity**.
- Create a method **ReadSale()** that reads a sale data line from the console and returns **Sale** object. It could split the input line by space and parse the price and quantity.
- To read the input, first read an integer n, then n times read a sale.
- **Approach I – LINQ**
Using **LINQ** select the **distinct town names** from the array of sales and sort them.
For **each town** in a loop use a LINQ query to calculate the **total sales** (aggregate the sum of **price * quantity** for all sales by the current town).
- **Approach II – Dictionary {town -> sales}**
Define a dictionary **SortedDictionary<string, decimal> salesByTown* to hold the total sales for each town.
Pass through all the sales from the input in a loop and for each sale, add its **price * quantity** to the salesByTown for the current town. If the town is missing in the dictionary, first create it.
Finally print the dictionary.
- The second approach is faster, because it scans the array of sales only once.
