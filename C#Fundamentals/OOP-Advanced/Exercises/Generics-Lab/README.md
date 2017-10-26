# <p align="center"> Lab:  Generics </p>

Problems for exercises and homework for the [https://softuni.bg/courses/csharp-oop-advanced-high-quality-code](https://softuni.bg/courses/csharp-oop-advanced-high-quality-code)

You can check your solutions here: [https://judge.softuni.bg/Contests/Compete/Index/706#0](https://judge.softuni.bg/Contests/Compete/Index/706#0)

# Part I: Generics

## 1.Box of T

Create a class **Box&lt;&gt;** that can store anything.

It should have two public methods:

- void Add(element)
- element Remove()
- int Count { get; }

Adding should add on top of its contents. Remove should get the topmost element.

### Examples

```scharp\
public staticvoid Main(string[] args)
{
	Box<int> box = newBox<int>();    
	box.Add(1);    
	box.Add(2);    
	box.Add(3);    
	Console.WriteLine(box.Remove());
	box.Add(4);    
	box.Add(5);    
	Console.WriteLine(box.Remove());
} 
```

> ### Hints
> Use the syntax **Box&lt;T&gt;** to create a generic class

## 2.Generic Array Creator

Create a class **ArrayCreator** with a method and a single overload to it:

- static T[] create(int length, T item)

The method should return an array with the given length and every element should be set to the given default item.

### Examples

```csharp
static void Main(string[] args)
{
	string[] strings = ArrayCreator.Create(5,"Pesho");   
	int[] integers = ArrayCreator.Create(10, 33);
} 
```

# 3.Part II: Generic Constaints

## 3.Generic Scale

Create a class **Scale&lt;T&gt;** that holds two elements - left and right. The scale should receive the elements through its single constructor:

- Scale(T left, T right)

The scale should have a single method:

- T getHeavier()

The greater of the two elements is heavier. The method should return **null** if elements are equal.