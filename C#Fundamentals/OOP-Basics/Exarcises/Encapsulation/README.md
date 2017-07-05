# <p align="center"> Exercises:  Encapsulation </p>

This document defines the **exercise assignments** for the [&quot;CSharp OOP Basics&quot; course @ Software University](https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/232/Encapsulation-Exercise).

## Problem 1.Class Box

You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: [http://www.mathwords.com/r/rectangular\_parallelepiped.htm](http://www.mathwords.com/r/rectangular_parallelepiped.htm)).

On the first three lines you will get the length, width and height. On the next three lines print the surface area, lateral surface area and the volume of the box:

### Note

Add the following code **at the start** of your main method and submit it to Judge.

``` csharp

staticvoid Main(string[] args)
{    
    Type boxType = typeof(Box);
    FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
    Console.WriteLine(fields.Count());
} 

```

If you defined the class correctly, the test should pass.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 <br> 3 <br/> 4 | 3  <br> Surface Area – 52.00 <br> Lateral Surface Area – 40.00vVolume – 24.00 |
| 1.3 <br> 1 <br> 6 | 3 <br> Surface Area - 30.20 <br> Lateral Surface Area - 27.60 <br> Volume - 7.80 |

## Problem 2.Class Box Data Validation

A box&#39;s side should not be zero or a negative number. Expand your class from the previous problem by adding data validation for each parameter given to the constructor. Make a private setter that performs data validation internally.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2  <br> -3 <br> 4 | 3 <br> Width cannot be zero or negative. |

## Problem 3.Animal Farm

You should be familiar with encapsulation already. For this problem, you&#39;ll be working with the **Animal Farm project**. It contains a class Chicken. Chicken contains several fields, a constructor, several properties and several methods. Your task is to encapsulate or hide anything that is not intended to be viewed or modified from outside the class.

### Step 1. Encapsulate Fields

Fields should be **private**. Leaving fields open for modification from outside the class is potentially dangerous. Make all fields in the Chicken class private.

In case the value inside a field is needed elsewhere, use **getters** to reveal it.

### Step 2. Ensure Classes Have a Correct State

Having **getters and setters** is useless if you don&#39;t actually use them. The Chicken constructor modifies the fields directly which is wrong when there are suitable setters available. Modify the constructor to fix this issue.

### Step 3. Validate Data Properly

Validate the chicken&#39;s **name** (it cannot be null, empty or whitespace). In case of **invalid name** , print exception message &quot;Name cannot be empty.&quot;

Validate the **age** properly, minimum and maximum age are provided, make use of them. In case of **invalid age** , print exception message &quot;Age should be between 0 and 15.&quot;

Don&#39;t forget to handle properly the possibly thrown exceptions.

### Step 4. Hide Internal Logic

If a method is intended to be used only by descendant classes or internally to perform some action, there is no point in keeping them **public**. The **CalculateProductPerDay()** method is used by the **productPerDay()** public getter. This means the method can safely be hidden inside the Chicken class by declaring it **private**.

### Step 5. Submit Code to Judge

Submit your code as a zip file in Judge. Zip everything except the bin and obj folders within the project and submit the single zip file in judge.

### Examples

| **Input** | **Output** |
| --- | --- |
| Mara <br> 10 | Chicken Mara (age 10) can produce 1 eggs per day. |
| Mara <br> 17 | Age should be between 0 and 15. |

## Problem 4.Shopping Spree

Create two classes: **class Person** and class **Product**. Each person should have a **name** , **money** and a **bag** of products **. Each product should have** name **and** cost **. Name cannot be an** empty string **. Money cannot be a** negative number.

Create a program in which **each command** corresponds to a **person buying a product**. If the person can **afford** a product **add** it to his bag. If a person **doesn&#39;t have enough** money, print an **appropriate** **message** (&quot;[Person name] can&#39;t afford [Product name]&quot;).

On the **first two lines** you are given **all people** and **all products**. After all purchases print **every person** in the order of **appearance** and **all products** that he has **bought** also in order of **appearance**. If **nothing is bought** , print the name of the person followed by &quot; **Nothing bought**&quot;.

In case of **invalid input** (negative money exception message: &quot; **Money cannot be negative**&quot;) or empty name (empty name exception message: &quot; **Name cannot be empty**&quot;) **break** the program with an appropriate message. See the examples below:

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho=11;Gosho=4 <br> Bread=10;Milk=2; <br> Pesho Bread <br> Gosho Milk <br> Gosho Milk <br> Pesho Milk <br> END | Pesho bought Bread <br> Gosho bought Milk <br> Gosho bought Milk <br> Pesho can&#39;t afford Milk <br> Pesho - Bread <br> Gosho - Milk, Milk |
| Mimi=0 <br> Kafence=2 <br>  <br> Mimi KafenceEND | Mimi can&#39;t afford Kafence <br> Mimi – Nothing bought |
| Jeko=-3 <br> Chushki=1; <br> Jeko Chushki <br> END | Money cannot be negative |

## Problem 5.Pizza Calories

A Pizza is made of dough and different toppings. You should model a **class Pizza** which should have a **name** , **dough** and **toppings** as fields. Every type of **ingredient** should have its **own class**. Every ingredient has different properties: the **dough** can be white or wholegrain and in addition it can be crispy, chewy or homemade. The **toppings** can be of type meat, veggies, cheese or sauce. **Every ingredient** should have a **weight** in grams and a method for **calculating** its calories according its type. Calories per gram are calculated through **modifiers**. Every ingredient has 2 calories per gram as a **base** and a **modifier** that **gives** the **exact** calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough weighting 100 grams will have 100 \* 1.5 \* 1.1 = 330.00 total calories.

**Your job** is to model the classes in such a way that they are **properly encapsulated** and to provide a public method for every pizza that **calculates its calories according to the ingredients it has**.

### Step 1. Create a Dough Class

The base ingredient of a Pizza is the dough. First you need to create a class for it. It has a **flour type** which can be **white** or **wholegrain**. In addition, it has a **baking technique** which can be **crispy** , **chewy** or **homemade**. A dough should have a **weight** in grams. The calories per gram of a dough are calculated depending on the flour type and the baking technique. Every dough has 2 calories per gram as a base and a modifier that gives the exact calories. For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1, which means that a white chewy dough weighting 100 grams will have (2 \* 100) \* 1.5 \* 1.1 = 330.00 total calories. You are given the modifiers below:

Modifiers:

- White – 1.5;
- Wholegrain – 1.0;
- Crispy – 0.9;
- Chewy – 1.1;
- Homemade – 1.0;

Everything that the class should expose is a getter for the calories per gram. Your task is to create the class with a proper constructor, fields, getters and setters. Make sure you use the proper access modifiers.

### Step 2. Validate Data for the Dough Class

Change the internal logic of the Dough class by adding a data validation in the setters.

Make sure that if invalid flour type or an invalid baking technique is given a proper exception is thrown with the message &quot;Invalid type of dough.&quot;.

The allowed weight of a dough is in the range [1..200] grams. If it is outside of this range throw an exception with the message &quot;Dough weight should be in the range [1..200].&quot;.

### Exception Messages

- &quot;Invalid type of dough.&quot;
- &quot;Dough weight should be in the range [1..200].&quot;

Make a test in your main method that reads Doughs and prints their calories until an &quot;END&quot; command is read.

### Examples

| **Input** | **Output** |
| --- | --- |
| Dough White Chewy 100 <br> END | 330.00 |
| Dough Tip500 Chewy 100 <br> END | Invalid type of dough. |
| Dough White Chewy 240 <br> END | Dough weight should be in the range [1..200]. |

### Step 3. Create a Topping Class

Next you need to create a **Topping class**. It can be of four different types – **meat** , **veggies** , **cheese** or a **sauce**. A topping has a **weight** in grams. The calories per gram of a topping are calculated depending on its type. The **base calories** per gram are **2**. Every different type of topping has a modifier. For example, meat has a modifier of 1.5, so a meat topping will have 1.5 calories per gram (1 \* 1.5). Everything that the class should expose is a getter for calories per gram. You are given the modifiers below:

Modifiers:

- Meat – 1.2;
- Veggies – 0.8;
- Cheese – 1.1;
- Sauce – 0.9;

Your task is to create the class with a proper constructor, fields, getters and setters. Make sure you use the proper access modifiers.

### Step 4. Validate Data for the Topping Class

Change the internal logic of the Topping class by adding a data validation in the setter.

Make sure the topping is one of the provided types, otherwise throw a proper exception with the message &quot;Cannot place [name of invalid argument] on top of your pizza.&quot;.

The allowed weight of a topping is in the range [1..50] grams. If it is outside of this range throw an exception with the message &quot;[Topping type name] weight should be in the range [1..50].&quot;.

### Exception Messages

- &quot;Cannot place [name of invalid argument] on top of your pizza.&quot;
- &quot;[Topping type name] weight should be in the range [1..50].&quot;

Make a test in your main method that reads a single dough and a topping after that and prints their calories.

### Examples

| **Input** | **Output** |
| --- | --- |
| Dough White Chewy 100 <br> Topping meat 30 <br> END | 330.0072.00 |
| Dough White chewy 100 <br> Topping Krenvirshi 500 <br> END | 330.00 <br> Cannot place Krenvirshi on top of your pizza. |
| Dough White Chewy 100 <br> Topping Meat 500 <br> END | 330.00 <br> Meat weight should be in the range [1..50]. |

### Step 5. Create a Pizza Class!

A Pizza should have a **name** , some **toppings** and a **dough**. Make use of the two classes you&#39;ve made earlier. Also a pizza should have **public getters** for its **name** , **number of toppings** and the **total calories**. The **total calories** are **calculated by summing the calories of all the ingredients a pizza has**. Create the class using a proper constructor, expose a method for adding a topping, a public setter for the dough and a getter method for the total calories.

The input for a pizza consists of several lines. On the first line is the **pizza name** and the **number of toppings it has**. On the second line you will get input for the **dough**. On the next lines, you will receive every topping the pizza has. **The number of lines for the toppings** will correspond to the number of toppings declared on the first line.

If creation of the pizza was **successful** print on a single line the name of the pizza and the **total calories** it has.

### Step 6. Validate Data for the Pizza Class

The **name** of the pizza should **not** be an **empty string**. Also it should **not be longer than 15 symbols**. If it doesn&#39;t fit this throw and **exception** with the message &quot;Pizza name should be between 1 and 15 symbols.&quot;

The **number of toppings** should be in range [0...10]. If not, throw an **exception** with the message &quot;Number of toppings should be in range [0..10].&quot;

Your task is to print the name of the pizza and the total calories it has according to the examples below.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pizza Meatless 2 <br> Dough Wholegrain Crispy 100 <br> Topping Veggies 50 <br> Topping Cheese 50 <br> END | Meatless – 370.00 Calories. |
| Pizza Meatfull 5 <br> Dough White cheWy 200 <br> Topping Meat 50 <br> Topping Cheese 50 <br> Topping meat 20 <br> Topping sauce 10 <br> Topping Meat 30END | Meatfull – 1028.00 Calories. |
| Pizza Bulgarian 20 <br> Dough Tip500 Balgarsko 100 <br> Topping Sirene 50 <br> Topping Cheese 50 <br> Topping Krenvirsh 20 <br> Topping Meat 10 <br> END | Number of toppings should be in range [0..10]. |
| Pizza Bulgarian 2 <br> Dough Tip500 Balgarsko 100 <br> Topping Sirene 50 <br> Topping Cheese 50 <br> Topping Krenvirsh 20 <br> Topping Meat 10 <br> END | Invalid type of dough. |
| Pizza Bulgarian 2 <br> Dough White Chewy 100 <br> Topping Sirene 50 <br> Topping Cheese 50 <br> Topping Krenvirsh 20 <br> Topping Meat 10 <br> END | Cannot place Sirene on top of your pizza. |

## Problem 6.\*\*Football Team Generator

A football team has variable **number of players** , a **name** and a **rating**. A player has a **name** and **stats** which are the basis for his skill level. The stats a player has are **endurance** , **sprint** , **dribble** , **passing** and **shooting**. Each stat can be in the range [0..100]. The overall skill level of a player is calculated as the average of his stats. Only the name of a player and his stats should be visible to all of the outside world. Everything else should be hidden.

A team should expose a name, a rating (calculated by the average skill level of all players in the team and rounded to the integer part only) and methods for adding and removing players.

Your task is to model the team and the players following the proper principles of Encapsulation. Expose only the properties that needs to be visible and validate data appropriately.

### Data Validation

- A name cannot be null, empty or white space. If not, print &quot;A name should not be empty. &quot;
- Stats should be in the range 0..100. If not, print &quot;[Stat name] should be between 0 and 100. &quot;
- If you receive a command to remove a missing player, print &quot;Player [Player name] is not in [Team name] team. &quot;
- If you receive a command to add a player to a missing team, print &quot;Team [team name] does not exist.&quot;
- If you receive a command to show stats for a missing team, print &quot;Team [team name] does not exist.&quot;

### Examples

| **Input** | **Output** |
| --- | --- |
| Team;Arsenal <br> Add;Arsenal;Kieran\_Gibbs;75;85;84;92;67 <br> Add;Arsenal;Aaron\_Ramsey;95;82;82;89;68  <br> Remove;Arsenal;Aaron\_Ramsey  <br> Rating;Arsenal <br> END | Arsenal – 81 |
| Team;Arsenal <br> Add;Arsenal;Kieran\_Gibbs;75;85;84;92;67 <br> Add;Arsenal;Aaron\_Ramsey;195;82;82;89;68  <br> Remove;Arsenal;Aaron\_Ramsey  <br> Rating;Arsenal <br> END | Endurance should be between 0 and 100. <br> Player Aaron\_Ramsey is not in Arsenal team. <br> Arsenal - 81 |
| Team;Arsenal <br> Rating;Arsenal <br> END | Arsenal – 0 |