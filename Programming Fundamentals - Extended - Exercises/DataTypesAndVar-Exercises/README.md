#<p align="center"> Data Type And Variables - Exercises <p>

## 01.Practice Integer Numbers

####**Problem Description**
Create a new C# project and create a program that **assigns integer values** to **variables**. Be sure that each **value** is stored in the **correct variable type** (try to find the most suitable variable type in order to save memory). Finally, you need to **print** all variables to the console.

## 02. Practice Floating Points

####Problem Description

Create a new C# project and create a program that **assigns floating point values** to **variables**. Be sure that each **value** is stored in the **correct variable type** (try to find the most suitable variable type in order to save memory). Finally, you need to **print** all variables to the console.

####Hints
- Just like at the previous problem, declare several variables of appropriate **floating-point data type**, assign the above listed values and **print** them.

## 03.Practice Characters and Strings

####Problem Description

Create a new C# project and create a program that **assigns character** and **string values to variables**. Be sure that each **value** is stored in the **correct variable**. Finally, you need to **print** all variables to the console.

####Hints
- Like at the previous problem, declare variables of type **char** or **sting**, assign the above values and **print** them.

## 04.Variable in Hexadecimal Format 
####Problem Description
Write a program that reads a number in **hexadecimal format (0x##)** convert it to **decimal format** and prints it.
####Hints
- Use Convert.ToInt32(string, 16)

## 05.Boolean Variable
#### Problem Description
Write a program that reads a **string**, converts it to **Boolean** variable and prints **“Yes”** if the variable is **true** and **“No”** if the variable is **false**.

####Hints
- Use Convert.ToBoolean(string).

## 06.Strings and Objects
#### Problem Description
Declare two **string variables** and assign them with **“Hello”** and **“World”**. Declare an **object** variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third **string** variable and initialize it with the value of the object variable (you should perform type **casting**).

## 07.Exchange Variable Values
#### Problem Description
Declare two integer variables **a** and **b** and assign them with 5 and 10 and after that **exchange their values** by using some programming logic. Print the variable values before and after the exchange.
####Hints
- You may use a **temporary variable** to remember the old value of **a**, then assign the value of **b** to **a**, then assign the value of the temporary variable to **b**.

## 08.Employee Data
#### Problem Description
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
- First name
- Last name
- Age (0...100)
- Gender (**m** or **f**)
- Personal ID number (e.g. 8306112507)
- Unique employee number (27560000…27569999)
Declare the **variables** needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. **Print** the data at the console.

## 09.Reverse Characters
#### Problem Description
Write a program to ask the user for **3 letters** and print them in **reversed order**.

## 10.Centuries to Nanoseconds
#### Problem Description
Write program to enter an integer number of **centuries** and convert it to **years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds**.
####Hints
- Use an appropriate data type for every data conversion. Beware of **overflows**!

## 11. Convert Speed Units
#### Problem Description
Create a program to ask the user for a **distance (in meters)** and the time taken (as three numbers: hours, minutes, seconds), and **print the speed**, in meters per second, kilometers per hour and miles per hour.
Assume 1 mile = 1609 meters.
####Input
- On first line you receive – distance in meters
- On second – hours
- On third – minutes
- On fourth – seconds
####Output
Every number in the output should be precise up to 6 digits after the floating point
- On first line – speed in meters per second (m/s)
- On second line – speed in kilometers per hour (km/h)
- On third line – speed in miles per hour (mph)

## 12.Rectangle Properties
#### Problem Description
Create a program to calculate rectangle’s **perimeter, area** and **diagonal** by given its **width** and **height**.
####Hints
- Use **Math.Sqrt()** to calculate square root for calculating the diagonal (c2 = a2 + b2). See http://www.mathopenref.com/rectanglediagonals.html.

## 13.Vowel or Digit
#### Problem Description
Create a program to check if given symbol is **digit, vowel** or any other **symbol**.

## 14.Integer to Hex and Binary
#### Problem Description
Create a program to convert a **decimal number** to **hexadecimal** and **binary** number and print it.
####Hints
- Use Convert.ToString(number, base) and string.ToUpper().

## 15.Fast Prime Checker - Refactor
#### Problem Description
You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} is prime -> {True or False}". The code however, is not very well written. Your job is to modify it in a way that is **easy to read and understand.**

## 16.* Comparing Floats
#### Problem Description
Write a program that **safely compares floating-point numbers (double)** with precision **eps = 0.000001**. Note that we cannot directly compare two floating-point numbers **a** and **b** by **a==b** because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant **eps**.

## 17.Print Part of the ASCII Table 
#### Problem Description
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that **prints part of the ASCII table** of characters at the console.  On the first line of input you will receive **the char index you should start with** and on the **second line - the index of the last character** you should print.

## 18.* Different Integers Size
#### Problem Description
Given an input integer, you must **determine which primitive data types** are capable of properly storing that input.
####Input
- You receive **N** – integer which can be arbitrarily large or small
####Output
You must determine if the given primitives are capable of storing it. If yes, then print:
- {N} can fit in:
- * dataType
If there is more than one appropriate data type, print each one on its own line and order them by size
**(sbyte < byte < short < ushort < int < uint < long).**
If the number cannot be stored in one of the four aforementioned primitives, print the line: 
- {N} can't fit in any type
####Hints
- Use the **try … catch** construction.

## 19.* Thea the Photographer
**This problem is from the Programming Fundamentals Retake Exam (11 September 2016).**
Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.
She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.
Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.
You will receive the amount of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.

####Input
- On the first line you will receive an integer **N** – the amount of pictures Thea had taken.
- On the second line you will receive an integer **FT** – the amount of time (filter time) in seconds that Thea will require to filter every single picture.
- On the third line you will receive an integer **FF** – the filter factor or the percentage of the total pictures that are considered “good” to be uploaded.
- On the fourth line you will receive an integer **UT** – the amount of time needed for every filtered picture to be uploaded to her storage.
- The input will be in the described format, there is no need to check it explicitly.
####Output
Print the amount of time Thea will need in order to have her pictures ready to be sent to her client in given format:
- **d:HH:mm:ss** 
- **d** - days needed – starting from 0.
- **HH** –  hours needed – from 00 to 24.
- **mm** – minutes needed – from 00 to 59.
- **ss** – minutes needed – from 00 to 59.
####Constrains
- The amount of total pictures Thea will have taken is range [0 … 1 000 000]
- The seconds for both filtering and uploading will be in range [0 … 100 000]
- The filter factor will be an integer number between [0 … 100].
