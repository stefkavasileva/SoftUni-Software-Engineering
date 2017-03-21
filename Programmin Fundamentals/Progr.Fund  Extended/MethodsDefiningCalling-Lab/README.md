# <p align="center">Lab: Methods - Defining and Calling Methods <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/417#0).

# I.Declaring and Invoking Methods

## 1.Blank Receipt

### Hints

First create a method with no parameters for printing the header starting with **static void**. Give it a **meaningful name** like &quot; **PrintReceiptHeader**&quot; and write the code that it will execute:

```C#
static void PrintReceiptHeader ()
{
	Console.WriteLine("CASH RECEIPT");
	Console.WriteLine("------------------------------");
}
```

Do the same for printing the receipt body and footer.

Create a **method that will call all three methods** in the necessary order. Again, give it a **meaningful and descriptive name** like &quot; **PrintReceipt**&quot; and write the code:

```C#
static void PrintReceiptHeader ()
{
	Console.WriteLine("CASH RECEIPT");
	Console.WriteLine("------------------------------");
}
```

For printing **&quot;©&quot;** use Unicode **&quot;\u00A9&quot;**

**Call** (invoke) the **PrintReceipt** method from the **Main** method.

```C#
static void Main (string [] args)
{
	PrintReceipt();
}
```

## 2.Sign of Integer Number

Create a method that prints the sign of an integer number n.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 | The number 2 is positive. |
| -5 | The number -5 is negative. |
| 0 | The number 0 is zero. |

### Hints

Create a method with a **descriptive name** like &quot; **PrintSign**&quot; which should receive **one parameter** of type **int**.

```C#
static void PrintSign(int number)
{

}
```

Implement the body of the method by handling different cases:
  1. If the number is greater than zero
  2. If the number is less than zero
  3. And if the number is equal to zero

Call (invoke) the newly created method from the main.

```C#
static void Main (string [] args)
{
	int n = int.Parse(Console.ReadLine());
	PrintSign(n);
}
```
 
##3.Printing Triangle

Create a method for printing triangles as shown below:

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 | 1<br/>1 2<br/>1 2 3<br/>1 2<br/>1 |
| 4 | 1<br/>1 2<br/>1 2 3 <br/>1 2 3 4<br/>1 2 3<br/>1 2<br/>1 |

### Hints

After you read the input

Start by creating a method **for printing a single line** from a **given start** to a **given end**. Choose a **meaningful name** for it, describing its purpose:

```C#
static void PrintLine(int start, int end)
{
	for(int i = start; i <= end; i++)
	{
		Console.Write(i + " ");
	}
	Console.WriteLine();
}
```

Think how you can use it to solve the problem

After you spent some time thinking, you should have come to the conclusion that you will need two loops

In the first loop you can print the first half of the triangle without the middle line:

```C#
for(int i = 0; i < n; i++)
{
	Console.Write(1 + i);
}
```	

Next, print the middle line:

```C#
PrintLine(1, n);
```

Lastly, print the rest of the triangle:

```C#
for(int i = n-1; i >= 0; i++)
{
	Console.Write(1 + i);
}
```	

## 4.Draw a Filled Square

Draw at the console a filled square of size n like in the example:

### Examples

| **Input** | **Output** |
| --- | --- |
| 4 | --------<br/> -\/\/\/-<br/> -\/\/\/- <br/> -------- |

### Hints

Read the input

Create a method which will print the top and the bottom rows (they are the same). Don&#39;t forget to give it a descriptive name and to give it as a parameter some length
- Instead of loop you can use the &quot;new string&quot; command which creates a new string consisting of a character repeated some given times:

```C#
static void PrintHeaderRow(int n)
{
	Console.WriteLine(new string('-', 2 * n));
}
```	
Create the method which will print the middle rows. Well, of course, you should probably name it &quot; **PrintMiddleRow**&quot;

```C#
static void PrintMiddleRow(int n)
{
	Console.Write('-');
	for(int i = 1; i < n; i++)
	{
		Console.Write("\\/");
	}
	
	Console.WriteLine('-');
}
```	

Use the methods that you&#39;ve just created to draw a square

 ```C#
 static void Main()
 {
	int n = int.Parse(Console.ReadLine());
	PrintHeaderRow(n);
	// TODO: Draw the rest of the square
 }
 ```

# II.Returning Values and Overloading

##5.Calculate Triangle Area

Create a method that calculates and **returns** the [area](http://www.mathopenref.com/trianglearea.html) of a triangle by given base and height:

### Examples

| **Input** | **Output** |
| --- | --- |
| 3<br/>4 | 6 |

### Hints

After reading the input

Create a method, but this time **instead** of typing **&quot;static void&quot;** before its name, type **&quot;static double&quot;** as this will make it to **return a value of type double** :

```C#
static double GetTriangleAre(double width, double height)
{
	return width * height / 2;
}
```

**Invoke** the method in the main and **save the return value in a new variable** :

 ```C#
 static void Main()
 {
	double width = double.Parse(Console.ReadLine());
	double height = double.Parse(Console.ReadLine());
	double area = GetTriangleAre(width, height);
	Console.WriteLine(area);
 }
 ```

## 6.Math Power

Create a method that calculates and returns the value of a number raised to a given power:

### Examples

| **Input** | **Output** |
| --- | --- |
| 2<br/>8 | 256 |
| 3<br/>4 | 81 |

### Hints

As usual, read the input

Create a method which will have two parameters - the number and the power, and will return a result of type double:

```C#
static double RaiseToPower(double number, int power)
{
	double result = 0d;
	
	// TODO: Calculate result (use a loop, or Path.Pow())
	
	return result;
}
```

Print the result

## 7.Greater of Two Values

You are given two values of the same type as input. The values can be of type int, char of string. Create a method **GetMax()** that returns the greater of the two values:

### Examples

| **Input** | **Output** |
| --- | --- |
| int<br/> 2 <br/> 16 | 16 |
| char<br/> a<br/> z | z |
| string<br/>Ivan<br/> Todor | Todor |

### Hints

For this method you need to create three methods with the same name and different signatures

Create a method which will compare integers:

```C#
static int GetMax(int first, int second)
{
	if(first >= second)
	{
		// TODO: return value
	}
	
	// TODO: handle other cases
}
```

Create a second method with the same name which will compare characters. Follow the logic of the previous method:

 ```C#
static char GetMax(char first, char second)
{
	// TODO: create logic
}
```

Lastly you need to create a method to compare strings. This is a bit different as strings don&#39;t allow to be compared with the operators &gt; and &lt;

 ```C#
static string GetMax(string first, string second)
{
	if(first.CompareTo(second) >= 0)
	{
		// TODO: return value
	}
	
	// TODO: return value
}
```
You need to use the method &quot;**CompareTo()**&quot;, which returns an integer value (greater than zero if the compared object is greater, less than zero if the compared object is lesser and zero if the two objects are equal.

The last step is to read the input, use appropriate variables and call the **GetMax()** from your **Main()**:

```C#
var type = Console.ReadLine();
if(type == "int")
{
	int first = int.Parse(Console.ReadLine());
	int second = int.Parse(Console.ReadLine());
	int max = GetMax(first, second);
	Console.WriteLine(max);
}
else if (type == "char")
{
	// TODO: call GetMax with char arguments
}
else if (type == "string")
{
	// TODO: call GetMax with string arguments
}
```