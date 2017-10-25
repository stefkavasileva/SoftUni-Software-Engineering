# <p align="center"> Lab: Polymorphism </p>

Problems for exercises and homework for the [&quot;C# OOP Basics&quot; course @ SoftUni](https://softuni.bg/courses/csharp-oop-basics)&quot;.

You can check your solutions here: [https://judge.softuni.bg/Contests/Compete/Index/680#0](https://judge.softuni.bg/Contests/Compete/Index/680%230).

## 1.MathOperation

Create a class **MathOperations** , which should have 3 times method **Add().** Method **Add()** have to be invoked with:

- Add(int, int): **int**
- Add(double, double, double): **double**
- Add(decimal, decimal, decimal): **decimal**

You should be able to use the class like this:

```csharp
 public static void Main()
 {
	MathOperations mo = newMathOperations();
	Console.WriteLine(mo.Add(2, 3));
	Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
	Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
} 
 ```
### Examples

| **Input** | **Output** |
| --- | --- |
|   | 5119.9 |

### Solution

Created MathOperation class should look like this:

```csharp
public int Add (int a,int b)
{
	return a + b;
}

public double Add (double a,double b, double c)
{
	return a + b + c;
}

public decimal Add (decimal a,decimal b, decimal c)
{
	return a + b + c;
}

```
## 2.Animals

Create a class Animal, which hold two fields:

- name: string
- favouriteFood: string

Animal have one virtual method **ExplainMyself()****: string**
You should add two new classes **Cat** and **Dog.** There override ExplainMyself() method by adding concrete animal sound on new line. (Look at examples below)

You should be able to use the class like this:

```csharp
Animal cat = newCat("Pesho", "Whiskas");
Animal dog = newDog("Gosho", "Meat");
Console.WriteLine(cat.ExplainMyself());
Console.WriteLine(dog.ExplainMyself()); 
```

### Examples

| **Input** | **Output** |
| --- | --- |
|   | I am Pesho and my fovourite food is WhiskasMEEOWI am Gosho and my fovourite food is MeatDJAAF |

## 3.Shapes

Create class hierarchy, starting with **abstract** class Shape:

- **Abstract methods:**
  - **calculatePerimeter(): doulbe**
  - **calculateArea****(): double**
- **Virtual methods**
  - **Draw(): string**

Extend Shape class with two children:

- **Rectangle**
- **Circle**

Each of them need to have:

- **Fields:**
  - **height and width for Rectangle**
  - **radius for Circle**
- **Encapsulation for this fields**
- **Public constructor**
- **Concrete methods for calculations (perimeter and area)**
- **Override methods for drawing**