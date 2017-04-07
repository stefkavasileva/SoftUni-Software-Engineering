# <p align="center"> Data Type And Variables <p>

## 01. **Centuries to Minutes**

#### **Problem Description**

Write program to enter an integer number of **centuries** and convert it to **years, days, hours** and **minutes**.

#### Examples

|**Input**|**Output**|
|---|---|
|1	|1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes|
|5	|5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes|

> #### Hints
> - Use appropriate data type to fit the result after each data conversion.
> - Assume that a year has 365.2422 days at average (the Tropical year).

#### Solution
You might help yourself with the code below:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/dataType1.png)

## 02. **Circle Area (12 Digits Precision)**

#### Problem Description

Write program to enter a radius r (real number) and **print the area** of the circle with exactly **12 digits** after the decimal point. Use data type of **enough precision** to hold the results.

#### Examples

|**Input**|**Output**|
|---|---|
|2.5	| 19.634954084936|
|1.2	|4.523893421169|

> #### Hints
> - You might use the data type double. It has precision of 15-16 digits.

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/dataType2.png)

## 03.Exact Sum of Real Numbers

#### Problem Description

Write program to enter n numbers and calculate and print their **exact sum** (without rounding).

#### Examples

|**Input**|**Output**|
|---|---|
|3 <br/> 1000000000000000000 </br> 5 </br> 10|1000000000000000015|
|2 <br/> 0.00000000003 <br/> 333333333333.3	|333333333333.30000000003|


> #### Hints
> - If you use types like **float** or **double**, the result will lose some of its precision. Also it might be printed in scientific notation.
> - You might use the **decimal** data type which holds real numbers with high precision with less loss.
> - Note that **decimal** numbers sometimes hold the unneeded zeroes after the decimal point, so **0m** is different than **0.0m** and **0.00000m**.

## 04.Elevator 
#### Problem Description

Calculate how many courses will be needed to **elevate n persons** by using an elevator of **capacity of p persons**. The input holds two lines: the **number of people** n and the **capacity p** of the elevator.

#### Examples

|**Input**|**Output**| **Comments**|
|---|---|---|
|17 </br> 3	|6 |	5 courses * 3 people <br/> + 1 course * 2 persons|
|4 </br> 5	|1 |	All the persons fit inside in the elevator. <br/> Only one course is needed.|
|10 <br/> 5 |2|	2 courses * 5 people |

> #### Hints
> - You should **divide n by p**. This gives you the number of full courses (e.g. 17 / 3 = 5).
> - If **n** does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).
> - Another approach is to round up **n / p** to the nearest integer (ceiling), e.g. 17/3 = 5.67  rounds up to 6.
> - Sample code for the round-up calculation:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/dataType3.png)

## 05.Special Numbers
#### Problem Description

A **number** is special when its **sum of digits is 5, 7 or 11**.
Write a program to read an integer **n** and for all numbers in the range **1…n** to print the number and if it is special or not **(True / False)**.

#### Examples

|**Input**|**Output**|
|---|---|
|15| 1 -> False <br/> 2 -> False <br/> 3 -> False <br/> 4 -> False <br/> 5 -> True <br/> 6 -> False <br/> 7 -> True <br/> 8 -> False <br/> 9 -> False <br/> 10 -> False <br/> 11 -> False <br/> 12 -> False <br/> 13 -> False <br/> 14 -> True <br/> 15 -> False|

> #### Hints
> - To calculate the sum of digits of given number **num**, you might repeat the following: sum the last digit **(num % 10)** and remove it **(sum = sum / 10)** until num reaches **0**.

## 06.Triples of Latin Letters
#### Problem Description

Write a program to read an integer **n** and print all **triples** of the first **n small Latin letters**, ordered alphabetically.

#### Examples

|**Input**|**Output**|
|---|---|
|3|aaa <br/> aab <br/> aac <br/> aba <br/> abb <br/> abc <br/> aca <br/> acb <br/> acc <br/> baa <br/> bab <br/> bac <br/> bba <br/> bbb <br/> bbc <br/> bca <br/> bcb <br/> bcc <br/> caa <br/> cab <br/> cac <br/> cba <br/> cbb <br/> cbc <br/> cca <br/> ccb <br/> ccc|

#### Hints
- Perform 3 nested loops from **0** to **n-1**. For each number num print its corresponding Latin letter as follows.

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/dataType4.png)

## 07.Greeting

#### Problem Description

Write a program that enters **first name, last name** and **age** and prints "Hello, <first name> <last name>. You are <age> years old.". Use **interpolated** strings.

#### Examples

|**Input**|**Output**|
|---|---|
|Svetlin <br/> Nakov <br/> 25 |Hello, Svetlin Nakov. You are 25 years old.|

> #### Hint

> - You might use the following code:

![Not fount](/Programmin%20Fundamentals/Homeworks%20and%20Labs/images/dataType5.png)

