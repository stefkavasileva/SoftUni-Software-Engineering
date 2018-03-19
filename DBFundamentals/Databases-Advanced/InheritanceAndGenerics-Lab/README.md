# <p align="center"> Inheritance - Lab</p>

![Not fount](/DBFundamentals/Databases-Advanced/images/21.png)

Problems for exercises and homework for the [&quot;CSharp DB Advanced&quot; course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

## Part I: Inheritance

## 1.Single Inheritance

Create two classes named **Animal** and **Dog**.

**Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**

**Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**

**Dog** should inherit from **Animal**.

![Not fount](/DBFundamentals/Databases-Advanced/images/22.png)

### Hints

Use the **: operator** to build a hierarchy

### Solution

![Not fount](/DBFundamentals/Databases-Advanced/images/23.png)

![Not fount](/DBFundamentals/Databases-Advanced/images/24.png)


## 2.Multiple Inheritance

Create three classes named **Animal** , **Dog** and **Puppy**.

**Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**

**Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**

**Puppy** with a single public method **Weep()** that prints: **&quot;**** weeping… ****&quot;**

**Dog** should inherit from **Animal**. **Puppy** should inherit from **Dog**.

 ![Not fount](/DBFundamentals/Databases-Advanced/images/25.png)

### Solution

Add a new class **Puppy** to your project from task 1:

![Not fount](/DBFundamentals/Databases-Advanced/images/26.png)

## 3.Hierarchical Inheritance

Create three classes named **Animal** , **Dog** and **Cat**.

**Animal** with a single public method **Eat()** that prints: **&quot;eating…&quot;**

**Dog** with a single public method **Bark()** that prints: **&quot;barking…&quot;**

**Cat** with a single public method **Meow()** that prints: **&quot;meowing…&quot;**

**Dog** and **Cat** should inherit from **Animal**.

![Not fount](/DBFundamentals/Databases-Advanced/images/27.png)

### Solution

Add a new class **Cat** to your existing project that inherits the **Animal** class:

 ![Not fount](/DBFundamentals/Databases-Advanced/images/28.png)

## 4.Random List

Create a **RandomList** class that has all the functionality of **List&lt;string&gt;**.

Add additional function that **returns** and **removes** a random element from the list.

- Public method: **RandomString(): string       **

Create a class **RandomList** , derived from **List&lt;string&gt;** :

![Not fount](/DBFundamentals/Databases-Advanced/images/29.png)

Create a **Random** object as a property, a **constructor** that calls the **base** one and initialises the **Random** object:

![Not fount](/DBFundamentals/Databases-Advanced/images/30.png)

And then create the **RandomString()** method:

![Not fount](/DBFundamentals/Databases-Advanced/images/31.png)

## 5.Storage Box

Create a generic class Box that can be initialized with **any** type and **store** values. **Override** the **ToString()** method to print the values stored, separated by a **comma** and a **space** (&quot;,&quot;).

The Box class should have:

- Private field: **data** : **generic array** that stores the inserted elements
- Private field: **count: intger** , holding the count of elements in the Box
- A constructor and the necessary getters and setters
- Public method: **Add(): void** – adds an element to the Box after checking if there is space left in the array. If it&#39;s full, it must copy the data to a new array which is twice the size of the previous one.
- Public method: **Remove(): generic** – removes and returns the last added element from the Box
- Public override of **ToString()**

**You should be able to use the class like this:**

```csharp
public static void Main()
{
    var box = new Box<int>();
    for (int i = 0; i < 11; i++)
    {
        box.Add(i);
    }
    System.Console.WriteLine(box);
}
```

### **Solution**

Create the **fields** and **properties** we will need. Validate **count** in the **setter** , so it can never be more than the **Length** of the **data array**.

![Not fount](/DBFundamentals/Databases-Advanced/images/32.png)

Create a **constructor** that gives the **Box** an empty **data**** array** with a size of 4 and a Count of 0.

![Not fount](/DBFundamentals/Databases-Advanced/images/33.png)

Next, create the **Add()** and **Remove()** methods:

![Not fount](/DBFundamentals/Databases-Advanced/images/34.png)

![Not fount](/DBFundamentals/Databases-Advanced/images/35.png)

Last, override the **ToString()** method:

![Not fount](/DBFundamentals/Databases-Advanced/images/36.png)
