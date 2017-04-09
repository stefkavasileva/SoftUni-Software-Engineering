# <p align="center"> Methods and Debugging - Lab <p>

## 01.Blank Receipt
Create a method that prints a blank cash receipt. The method should invoke three other methods: one for printing the header, one for the body and one for the footer of the receipt. 

```
The header should contain the following text:	
CASH RECEIPT
------------------------------
```

```
The body should contain the following text:
Charged to____________________
Received by___________________
```

```
And the text for the footer:
------------------------------
© SoftUni
```

#### Examples 
|**Output**|
|---|
|CASH RECEIPT <br/> ------------------------------ <br/> Charged to____________________ <br/> Received by___________________<br/> ------------------------------ <br/> © SoftUni|

> #### Hints
> 1.	First create a method with no parameters for printing the header starting with static void. Give it a meaningful name like "PrintReceiptHeader" and write the code that it will execute:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods1.png)

> 2.	Do the same for printing the receipt body and footer.
> 3.	Create a method that will call all three methods in the necessary order. Again, give it a meaningful and descriptive name like "PrintReceipt" and write the code:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods2.png)

> 4.	For printing "©" use Unicode "\u00A9"
> 5.	Call (invoke) the PrintReceipt method from the main.

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods3.png)

## 02.	Sign of Integer Number
Create a method that prints the sign of an integer number n.

#### Examples 

|**Input**|**Output**|
|---|---|
|2	|The number 2 is positive.|
|-5	|The number -5 is negative.|
|0	|The number 0 is zero.|

> #### Hints
> 1.	Create a method with a descriptive name like "PrintSign" which should receive one parameter of type int.

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods4.png)

> 2.	Implement the body of the method by handling different cases: 
> a.	If the number is greater than zero
> b.	If the number is less than zero
> c.	And if the number is equal to zero
> 3.	Call (invoke) the newly created method from the main. 

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods5.png)

##03.Printing Triangle
Create a method for printing triangles as shown below: n=3

#### Examples 

|**Input**|**Output**|
|---|---|
|3|1 <br/> 1 2 <br/> 1 2 3 <br/> 1 2 <br/> 1|
|4|1 <br/> 1 2 <br/> 1 2 3  <br/> 1 2 3 4 <br/> 1 2 3 <br/> 1 2 <br/> 1|

> #### Hints
> 1.	After you read the input
> 2.	Start by creating a method for printing a single line from a given start to a given end. Choose a meaningful name for it, describing its purpose:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods6.png)

> 3.	Think how you can use it to solve the problem
> 4.	After you spent some time thinking, you should have come to the conclusion that you will need two loops
> 5.	In the first loop you can print the first half of the triangle without the middle line:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods7.png)

> 6.	Next, print the middle line:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods8.png)

> 7.	Lastly, print the rest of the triangle:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods9.png)

## 04.Draw a Filled Square
Draw at the console a filled square of size n like in the example: n=4

#### Examples 

|**Input**|**Output**|
|---|---|
|4| -------- <br/> -\\/\\/\\/- <br/> -\\/\\/\\/- <br/> --------|

> #### Hints

> 1.	Read the input
> 2.	Create a method which will print the top and the bottom rows (they are the same). Don’t forget to give it a descriptive name and to give it as a parameter some length
> a.	Instead of loop you can use the "new string" command which creates a new string consisting of a character repeated some given times:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods10.png)

> 3.	Create the method which will print the middle rows. Well, of course, you should probably name it "PrintMiddleRow" 

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods11.png)

> 4.	Use the methods that you've just created to draw a square

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods12.png)

## 05.Calculate Triangle Area
Create a method that calculates and returns the area of a triangle by given base and height

#### Examples 

|**Input**|**Output**|
|---|---|
|3 <br/> 4|6|

> #### Hints
> 1.	After reading the input
> 2.	Create a method, but this time instead of typing "static void" before its name, type "static double" as this will make it to return a value of type double:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods13.png)

> 3.	Invoke the method in the main and save the return value in a new variable:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods14.png)

## 06.Math Power
Create a method that calculates and returns the value of a number raised to a given power

#### Examples 

|**Input**|**Output**|
|---|---|
|2 <br/> 8| 256|
|3 <br/> 4|81|

> #### Hints
> 1.	As usual, read the input
> 2.	Create a method which will have two parameters - the number and the power, and will return a result of type double:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods15.png)

> 3.	Print the result

## 07.Greater of Two Values
You are given two values of the same type as input. The values can be of type int, char of string. Create a method GetMax() that returns the greater of the two value

#### Examples 

|**Input**|**Output**|
|---|---|
| int <br/> 2 <br/> 16 |16|
|char <br/>  a <br/> z |z|
|string <br/> Ivan <br/> Todor | Todor|

> #### Hints
> 1.	For this method you need to create three methods with the same name and different signatures
> 2.	Create a method which will compare integers:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods16.png)

> 3.	Create a second method with the same name which will compare characters. Follow the logic of the previous method:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods17.png)

> 4.	Lastly you need to create a method to compare strings. This is a bit different as strings don't allow to be compared with the operators > and < 
 
![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods18.png)

> You need to use the method "CompareTo()", which returns an integer value (greater than zero if the compared object is greater, less than zero if the compared object is lesser and zero if the two objects are equal.
> 5.	The last step is to read the input, use appropriate variables and call the GetMax() from your Main(): 
 
![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods19.png)

## 08.Multiply Evens by Odds
Create a program that reads an integer number and multiplies the sum of all its even digits by the sum of all its odd digits.

#### Examples 

|**Input**|**Output**|**Comments**|
|---|---|---|
|12345	|54|	12345 has 2 even digits - 2 and 4. Even digits has sum of 6. <br/> Also it has 3 odd digits - 1, 3 and 5. Odd digits has sum of 9. <br/> Multiply 6 by 9 and you get 54.|
|-12345	|54|

> Hints
> 1.	Create a method with a name describing its purpose (like GetMultipleOfEvensAndOdds). The method should have a single integer parameter and an integer return value. Also the method will call two other methods:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods20.png)

> 2.	Create two other methods each of which will sum either even or odd digits
> 3.	Implement the logic for summing odd digits:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/methods21.png)

> 4.	Do the same for the method that will sum even digits
> 5.	As you test your solution you may notice that it doesn't work for negative numbers. Following the program execution line by line, find and fix the bug (hint: you can use Math.Abs())

## 09.Debug the Code: Holidays Between Two Dates
You are assigned to find and fix the bugs in an existing piece of code, using the Visual Studio debugger. You should trace the program execution to find the lines of code that produce incorrect or unexpected results.
You are given a program (existing source code) that aims to count the non-working days between two dates given in format day.month.year (e.g. between 1.05.2015 and 15.05.2015 there are 5 non-working days – Saturday and Sunday).

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|1.05.2016 <br/> 15.05.2016 |5| There are 5 non-working days (Saturday / Sunday) in this period: <br/> 1-May- 2016, 7-May- 2016, 8-May- 2016, 14-May- 2016, 15-May- 2016|
|1.5.2016 <br/> 2.5.2016 |1| Only 1 non-working day in the specified period: 1.05.2016 (Sunday)|
|15.5.2020 <br/> 10.5.2020 |0| The second date is before the first. No dates in the range.|
|22.2.2020 <br/> 1.3.2020 |4|Two Saturdays and Sundays: <br/> 22.02.2020 and 23.02.2020 <br/> 29.02.2020 and 1.03.2020 |

#### Code

```csharp
using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.m.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.m.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday &&
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}

```

> #### Hints
> There are 4 mistakes in the code. You’ve got to use the debugger to find them and fix them. After you do that, submit your fixed code in the judge contest: https://judge.softuni.bg/Contests/Practice/Index/304#8

## 10.Price Change Alert
You are assigned to rework a given piece of code which is working without bugs but is not properly formatted. 
The given program tracks stock prices and gives updates about the significance in each price change. Based on the significance, there are four kind of changes: no change at all (price is equal to the previous), minor (difference is below the significance threshold), price up and price down. 

#### Input
- On the first line you are given N - the number of prices
- On the second line you are given the significance threshold
- On the next N lines, you are given prices
#### Output
- Don’t print anything for the first price
- If there is no difference from the previous price the output message is: "NO CHANGE: {current price}"
- In case of minor change: "MINOR CHANGE: {last price} to {current price} ({difference}%)"
- In case of major change: "PRICE UP: {last price} to {current price} ({difference}%)" or "PRICE DOWN: {last price} to {current price} ({difference}%)"
The percentage should be rounded to the second digit after the decimal point.

#### Examples

|**Input**|**Output**|
|---|---|
|3 <br/> 0.1 <br/> 10 <br/> 11 <br/> 12|PRICE UP: 10 to 11 (10.00%) <br/> MINOR CHANGE: 11 to 12 (9.09%)|
|3 <br/> 0.1 <br/> 10 <br/> 10 <br/> 12|NO CHANGE: 10 <br/> PRICE UP: 10 to 12 (20.00%)|

> Hints
> 1.	Download the source code and get familiar with it
> 2.	Deal with poor code formatting - Remove unnecessary blank lines, indent the code properly
> 3.	Fix method parameters naming
> 4.	Give methods a proper name



