# <p align="center"> Exam - June 2016 <p>

## 01.Sweet Dessert

#### **Problem Description**

Ivancho and his girlfriend are **throwing a party**. She plans **to cook her favorite dessert**. She asks Ivancho to **buy** the needed products. The **number of desserts** depends on **how many people will be coming**. She can prepare the dessert in **portions of 6**. If there are **5 guests** coming, she will still **cook 6 portions, 10 guests – cook 12**. The products for the dessert are bananas, eggs and **berries**. For a set of 6 she needs **2 bananas, 4 eggs and 0.2 kilos berries**.
You will be given **the amount of money Ivancho has**, the **number of guests** and the **prices of the products**. You have to help Ivancho calculate if the cash he has is enough to buy all of the products, or how much more money he needs.

#### Input

The input data should be read from the console. It will consist of **exactly 5 lines**:
- The amount of cash Ivancho has – floating-point number in range [0.00…1,000,000,000.00]
- The number of guests – integer in range [0…1,000,000,000]
- The price of bananas for a single unit – floating-point number in range [0.00…1,000.00]
- The price of eggs for a single unit – floating-point number in range [0.00…1,000.00]
- The price of berries for a kilo – floating-point number in range [0.00…1,000.00]
The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

The output should be printed on the console.
- **If the calculated price of the products is less or equal to the money Ivancho has:**
-- “Ivancho has enough money - it would cost {**the cost of the products**}lv.”
- **If the calculated price of the products is more than the money Ivancho has**:
--  “Ivancho will have to withdraw money - he will need {**neededMoney**}lv more.”
- **All prices** must be **rounded to two digits after the decimal point**.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
|10 <br/> 12 <br/> 0.35 <br/> 0.20 <br/> 4.50|Ivancho has enough money - it would cost 4.80lv.|For 12 guests – 2 sets of 6 portions <br/> Needed product: <br/> 2*(2 bananas), 2*(4 eggs), 2*(0.2 kilos berries)  <br/> 2*(2*0.35) + 2*(4*0.20) + 2*(0.2*4.50) = 4.80 <br/> 4.80 <= 10 – the money will be enough.|
|20 <br/> 33 <br/> 0.60 <br/> 0.50 <br/> 10|Ivancho will have to withdraw money - he will need 11.20lv more.|For 33 guests – 6 sets of 6 portions <br/> Needed product: <br/> 6*(2 bananas), 6*(4 eggs), 6*(0.2 kilos berries)  <br/> 6*(2*0.60) + 6*(4*0.50) + 6*(0.2*10.00) = 31.20 <br/> 31.20 > 20 – need 11.20 lv. more.|

#### Solution 
1.First, we need to read from the console 5 lines of input and parse them to the appropriate data type.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam6.PNG)

2.Calculate the Number of Portions
To calculate the number of portions we need to divide the number of guests to 6 and round up to the nearest integer.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam7.PNG)

3.	Calculate the Needed Money
To calculate needed money for the desserts with the formula 
Needed money for 1 product = number of portions * quantity needed * price of the product
We calculate that for all the 3 products and add their values.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam8.PNG)

4.	Make a Decision
If the needed money is less or equal to the money Ivancho has we print that Ivancho has enough money otherwise we print the amount of money Ivancho need to buy products for the desert. Rounded 2 digits after the floating point.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam9.PNG)

## 02.Array Modifier

#### Problem Description

You are given **an array with integers**. Write a program to **modify the elements** after **receive the commands “swap”**, **“multiply”** or **“decrease”**.
- **“swap {index1} {index2}”** take **two elements** and **swap their places**.
- **“multiply {index1} {index2}”** take **element at the 1st index** and **multiply it with element at 2nd index**. Save the product at the 1st index.
- **“decrease” decreases all elements** in the array **with 1**.

#### Input

On the **first input line** you will be given **the initial array values** separated by a single space.
On the **next lines** you will receive commands **until** you receive the **command “end”**. The **commands are** as follow: 
- **“swap {index1} {index2}”**
- **“multiply {index1} {index2}”**
- **“decrease”**

#### Output

**The output** should be printed on the console and consist **element of the modified array – separated by “, “(comma and single space)**.

#### Constraints

- Commands will be: **“swap”, “multiply”, “decrease”** and **“end”**
- **Elements** of the array will be **integer numbers** in the range [-231...231]
- **Count of the array elements** will be in the range **[2...100]**
- **Indexes will be always in the range of the array**

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
|23 -2 321 87 42 90 -123 <br/> swap 1 3 <br/> swap 3 6 <br/> swap 1 0 <br/> multiply 1 2 <br/> multiply 2 1 <br/> decrease <br/> end|86, 7382, 2369942, -124, 41, 89, -3|23 -2 321 87 42 90 -123 – initial values <br/> swap 1(-2) and 3(87) ▼ <br/> 23 87 321 -2 42 90 -123 <br/> swap 3(-2) and 6(-123) ▼ <br/> 23 87 321 -123 42 90 -2 <br/> swap 1(87) and 0(23) ▼ <br/> 87 23 321 -123 42 90 -2 <br/> multiply 1(23) 2(321) = 7383 ▼ <br/> 87 7383 321 -123 42 290 -2 <br/> multiply 2(321) 1(7383) = 2369943 ▼ <br/> 87 7383 2369943 -123 42 90 -2 <br/> decrease – all - 1 ▼ <br/> 86 7383 2369942 -124 41 89 -3|

#### Solution

1.	Read Input
We receive the integer numbers in a single line separated by space. So we need to split that line by space and to parse every number. Since we are going to multiply integers we can easily overflow it so we will use long data type.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam10.PNG)

2.	Command Execution Loop
Now we need to read and execute the commands on the next lines until we receive “end” as command

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam11.PNG)

Hint

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam12.PNG)

3.	Helper Methods
We could define 3 methods to make the code more readable. And every method executes the appropriate command from the input. The methods receive as parameters the sequence and the parameters from the received command

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam13.PNG)

4.	Print Result
Finally we need to print the final state of the sequence separated by a comma and space.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam14.PNG)

## 03.Target Multiplier

#### Problem Description

Write a program which reads from the console **dimensions of a matrix** and **matrix elements values**. Get a **targeted cell** and **multiply its value** with the **sum of all neighboring cells**. The **neighboring cells** must **change their values too**. **Each one** should be **the product** of **its initial value** and the **initial value of the targeted cell**. Then **print on the console updated matrix**. 
#### Input
The input data should be read from the console:
- The **first line** holds the number of **rows – R** and **columns – C**, separated by space.
- The **next R lines** hold the **matrix values**. Each line holds **C integers**, separated by space.
- The **last line** holds **the position** (targeted **row** and targeted **col**) **of the targeted cell**, separated by space
The **input data will always be valid** and in the format described. **There is no need to check it explicitly**.

#### Output

The output should be printed on the console. The elements of each row should be separated by space.

#### Constraints

- The **dimensions** of the matrix **(R and C)** will be a **positive integer** numbers in the range **[3...20]**.
- The **values of the cells** will be an **integer numbers** in range **[-16,300... 16,300]**.
- The **targeted row** will be an integer number in the range **[1...R-2]**.
- The **targeted column** will be an integer number in the range **[1...C-2]**.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
|5 5 <br/> 10 12 14 16 17 <br/> 10 12 14 16 17 <br/> 10 12 14 16 17 <br/> 10 12 14 16 17 <br/> 10 12 14 16 17 <br/> 2 2|10 12 14 16 17 <br/> 10 168 196 224 17 <br/> 10 168 1568 224 17 <br/> 10 168 196 224 17 <br/> 10 12 14 16 17|Targeted cell is [2,2] = 14 <br/>  <br/> The sum all neighboring cells is: <br/> 12 + 14 + 16 + 12 + 16 + 12 + 14 + 16 = 112 <br/> The targeted cell new value = 14 * 112 = 1568 <br/>  <br/> Neighboring cells new values: <br/> [1,1]=12*14=168; [1,2]=14*14=196; [1,3]=16*14=224; <br/> [2,1]=12*14=168; [2,3]=14*14=224; <br/> [3,1]=12*14=168; [3,2]=14*14=196; [3,3]=16*14=224|

| **Input** | **Output** | 
| --- | --- | 
|6 4 <br/> 0 105 420 480 <br/> 1 143 624 744 <br/> 2 182 628 488 <br/> 3 226 326 538 <br/> 4 263 376 406 <br/> 5 -1 -2 -3 <br/> 4 2|0 105 420 480 <br/> 1 143 624 744 <br/> 2 182 628 488 <br/> 3 84976 122576 202288 <br/> 4 98888 659128 152656 <br/> 5 -376 -752 -1128|

Solution
1.	Read Input
First of all we need to read the input. On the first line we receive the dimensions of the matrix

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam15.PNG)


Now we need to define a structure that will hold our array and fill it with values.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam16.PNG)

Last thing that left to read from the input is the location of the target cell.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam17.PNG)

2.	Calculate Sum of Neighbor Cells
We need set start and end indexes for the rows and cols for target cell neighbors

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam18.PNG)

No we should find the sum of the neighbors of the target cell.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam19.PNG)

3.	Change Value of Target Cell and Its Neighbors
Now we need to keep the original value of the target cell

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam20.PNG)

4.	Print Result
Finally, we print the matrix.

![Not fount](/Programmin%20Fundamentals/OldExams/images/exam21.PNG)

## 04.Population Aggregation

#### Problem Description

Write a program that receives as input information about **country, city** and its **population** and prints an **aggregated statistic**. There are **2 types of input lines**
- **{Country}\{city}\{population}**
- **{city}\{Country}\{population}**
The **country name always starts with a capital letter** and the **city name always starts with a lowercase letter**. The country name and the city name are both polluted with **prohibited symbols (@, #, $, & and digits from 0 to 9)**. Your task is to **clear all prohibited symbols** and print **aggregated data about** the all the **countries ordered alphabetically** in format:
- **{Country} -> {number of cities}**
And **top 3 cities with biggest population** ordered in **descending order by population** in format:
- **{city} -> {population}**
In case of **repeating towns**, count the last seen population for each town (ignore the others).
**Count all towns** in each country. In case of repeating towns for certain country, **count the duplicated towns**.

#### Input

- The input data should be read from the console.
- It consists of a variable number of lines and ends when the command **"stop"** is received.
- The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

- The output should be printed on the console.
- Print the aggregated data for each country and city in the described format.

#### Constraints

- The name of the city, country and the population will be separated from each other by a **back slash ('\')**.
- The **number of input lines** will be in the range [2 … 50].
- The **population count** of each city will be an integer in the range [0 … 263 − 1].
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

#### Examples

| **Input** | **Output** | 
| --- | --- | 
|Bulgaria\sofia\123000 <br/> burgas\Bulgaria\4456576 <br/> stop|Bulgaria -> 2 <br/> burgas -> 4456576 <br/> sofia -> 123000|
|Bulgaria\sofia\100 <br/> sofia\Bulgaria\200 <br/> stop|Bulgaria -> 2 <br/> sofia -> 200|
|G$er&m@an@y\berlin\1234333 <br/> pa$r###is\F&r&a&n&c&e\30000000 <br/> Bulg@aria\varn@a@#$#\32145535 <br/> Bulgaria\pom$#or$ie\3131231 <br/> l$#ond$32on\U$#434565K43\98686644 <br/> ham$#bu4300r43g\Ger$man2@y\1324 <br/> stop|



