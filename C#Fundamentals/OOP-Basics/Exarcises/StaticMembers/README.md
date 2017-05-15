# <p align="center"> Exercise – Static Members </p>

This document defines the **exercise assignments** for the [&quot;C# OOP Basics&quot; course @ Software University](https://softuni.bg/csharp-basics-oop). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/#!/List/ByCategory/43/CSharp-OOP-Basics-Exercises).

## Problem 1. Students

Define class **Student**. Add **string field** for a student&#39;s **name** that you are going to receive as a console input. Then add a **static Integer field** to **keep track of how many students&#39; instances are created**. Initialize the static field with **0 (zero)** and **increment in the constructor**. When you receive command **&quot;End&quot;** stop reading more students names and print their total count on the console.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- | 
| Atanas <br/> Atanas <br/> End | 2 |  Minka <br/> End | 1 |

## Problem 2. Unique Student Names

Define class **Student** containing a single **field – name**.  Now Define class **StudentGroup** with **HashSet&lt;String&gt;** field that will keep all unique students. You are going to receive user input containing student&#39;s names as single parameter on the line until you receive command **&quot;End&quot;**. Create new instances of Students class and **keep track of all unique names** using static counter within the **StudentGroup** class. Then print the **count of unique names**.

### Examples

| **Input** | **Output** | **Input** | **Output** |   **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | 
| Atanas <br/> Atanas <br/> End | 1 |  Minka <br/> End | 1 | Minka <br/> Minka <br/> Atanas <br/> Nasko <br/> End | 3 |

## Problem 3. Temperature Converter

Create a program that **converts temperature**** from Celsius to Fahrenheit and vice versa **. Use** static methods **. The input data will be in format:** {temperature} {unit} **. Temperatures will be in** integer **number and units will be one of these two values:** Celsius / Fahrenheit ****.** Output value must be **double value** following of empty space and **the converted unit**. You are going to receive input, until you receive command **&quot;End&quot;.** The output must be formatted **2 digits after floating point.**

### Examples

| **Input** | **Output** |
| --- | --- |
| 24 Celsius  <br/> 101 Fahrenheit <br/> End | 75.20 Fahrenheit <br/> 38.33 Celsius |

## Problem 4. Beer Counter

Define class **BeerCounter** holding static field **beerInStock** that shows how many beers you bought and static field **beersDrankCount** that shows how many beers you have drunk. Manipulate the static fields through static methods **BuyBeer(int bottlesCount)** and **DrinkBeer(int bottlesCount)**. On every input line you will get pair of beers you **bought** and beers you **drank** , until you receive command **&quot;End&quot;.**

- **BuyBeer** – add beers to the beers in stock
- **DrinkBeer** – add beers to the drunk beers counter and subtract beers in stock

After that print **beersInStock** and **beersDrankCount** on the same line separated by 1 space.

### Examples

| **Input** | **Output** |
| --- | --- |
| 50 4 <br/> 99 10End | 0 59 |

## Problem 5. Animal Clinic

Define two classes: **Animal** ( **name** , **breed** ) and **AnimalClinic** (static field **patientId** , static field **healedAnimalsCount** and static field **rehabilitedAnimalsCount** ). You will be given animal data (name and breed) and information whether the animal should be healed or rehabilitated. **Keep track** on the **rehabilitated animals,** on the **healed animals** and **overall patients**. If the animal has been **healed** , you need to **print on the console** the following message:

```
Patient {patientID} [{name} ({breed})] has been healed!
```

Otherwise print:

```
Patient {patientID} [{name} ({breed})] has been rehabilitated!
```
You will receive information about animals until you receive command **&quot;End&quot;.**

After you receive command **&quot;End&quot;** print total healed animals and total rehabilitated animals in format:

```
Total healed animals: {count}

Total rehabilitated animals: {count}
```
After that you will receive one of the following commands **heal** or **rehabilitate** and you must **print all** the names and breed of the **healed** or **rehabilitated** animals in format **{name} {breed}** each animal on new line.

### Examples

| **Input** | **Output** |
| --- | --- |
| Toshko Terrier heal <br/> End <br/> heal | Patient 1: [Toshko(Terrier)] has been healed! <br/> Total healed animals: 1 <br/> Total rehabilitated animals: 0 <br/> Toshko Terrier |
| **Input** | **Output** |
| Toshko Terrier rehabilitate <br/> Toshko Terrier rehabilitate <br/> End <br/> rehabilitate | Patient 1: [Toshko(Terrier)] has been rehabilitated! <br/> Patient 2: [Toshko(Terrier)] has been rehabilitated! <br/> Total healed animals: 0 <br/> Total rehabilitated animals: 2 <br/> Toshko Terrier <br/> Toshko Terrier |
| **Input** | **Output** |
| Toshko Terrier heal <br/> Goshko Bulldog rehabilitate <br/> End <br/> rehabilitate | Patient 1: [Toshko (Terrier)] has been healed! <br/> Patient 2: [Goshko (Bulldog)] has been rehabilitated! <br/> Total healed animals: 1 <br/> Total rehabilitated animals: 1 <br/> Goshko Bulldog |

## Problem 6. Planck Constant

Create class **Calculation**. Define static constant with value **6.62606896e-34** (Planck constant) and **3.14159** (Pi). Add **static method** that returns reduced Planck constant by the formula:

**\{Planck constant} / (2 \* \{Pi constant})**

Print the result of the method on a **single line on the console**. **Do not format** in any way the **result.**

## Problem 7. Basic Math

Define **MathUtil** class that supports **basic** mathematical operations:

- **Sum &lt;first number&gt; &lt;second number&gt;**
- **Subtract &lt;first number&gt; &lt;second number&gt;**
- **Multiply &lt;first number&gt; &lt;second number&gt;**
- **Divide &lt;dividend&gt; &lt;divisor&gt;**
- **Percentage &lt;total number&gt; &lt;percent of that number&gt;**

Use **static methods** and make sure that the application will work with **floating point numbers**.

Read from the console until you receive command **&quot;End&quot;.** Results must be formatted with **2 digits after the floating point.**

### Examples

| **Input** | **Output** |
| --- | --- |
| Sum 5 5 <br/> Multiply 5.5 11 <br/> Percentage 1500 99 <br/> Divide 12.24 2 <br/> Subtract 10.6 0.6 <br/> End | 10.00 <br/> 60.50 <br/> 1485.00 <br/> 6.12 <br/> 10.00 |

## Problem 8. Shapes Volume

Define class **TriangularPrism** that has **base side** , **height** from base side and **length**. Define class **Cube** that has **side** **length** and class **Cylinder** that has **radius** and **height**. Define class **VolumeCalculator** that holds **static methods** for calculating the volume of these three figures. The input will be read from the console until command **&quot;End&quot;** is received and will be in some of these formats:

- **TriangularPrism &lt;base side&gt; &lt;height&gt; &lt;length&gt;**
- **Cube &lt;side length&gt;**
- **Cylinder &lt;radius&gt; &lt;height&gt;**

The volume in the **output** must be **rounded 3 digits after** the floating point.

### Examples

| **Input** | **Output** |
| --- | --- |
| Cube 5 <br/> Cylinder 5 11.4 <br/> TrianglePrism 1 2 3 <br/> End | 125.000 <br/> 895.354 <br/> 3.000 |