#<p align="center"> Lab: Data Types: Text and Other Types, Variables <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/171/Data-Types-and-Variables-Lab).

# I.Text and Other Types

##1.Special Numbers

A **number** is **special** when its **sum of digits is 5, 7 or 11**.

Write a program to read an integer **n** and for all numbers in the range **1…n** to print the number and if it is specialor not ( **True** / **False** ).

### Examples

| **Input** | **Output** |
| --- | --- |
| 15 | 1 -&gt; False
	|2 -&gt; False
	|3 -&gt; False
	|4 -&gt; False
	|5 -&gt; True
	|6 -&gt; False
	|7 -&gt; True
	|8 -&gt; False
	|9 -&gt; False
	|10 -&gt; False
	|11 -&gt; False
	|12 -&gt; False
	|13 -&gt; False
	|14 -&gt; True
	|15 -&gt; False |

### Hints

To calculate the sum of digits of given number **num** , you might repeat the following: sum the last digit ( **num**** % ****10** ) and remove it ( **sum**** = ****sum**** / ****10** ) until **num** reaches **0**.

##2.Triples of Latin Letters

Write a program to read an integer **n** and print all **triples** of the first **n small Latin letters** , ordered alphabetically:

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 | aaa
	| aab
	|aac
	|aba
	|abb
	|abc
	|aca
	|acb
	|acc
	|baa
	|bab
	|bac
	|bba
	|bbb
	|bbc
	|bca
	|bcb
	|bcc
	|caa
	|cab
	|cac
	|cba
	|cbb
	|cbc
	|cca
	|ccb
	|ccc |

### Hints

Perform 3 nested loops from **0** to **n-1**. For each number **num** print its corresponding Latin letter as follows:

```C#
char letter = (char)('a' + num);
```

##3.Greeting

Write a program that enters **first name** , **last name** and **age** and prints &quot; **Hello, &lt;first name&gt; &lt;last name&gt;. You are &lt;age&gt; years old.**&quot;. Use interpolated strings.

### Examples

| **Input** | **Output** |
| --- | --- |
| Svetlin|Hello, Svetlin Nakov. You are 25 years old. 
Nakov| |
25 | | 

### Hints

You might use the following code:

```C#
Console.WriteLine($"Hello, {firstName} {lastName}. \r\nYou are {age} years old.");
```

# II.Variables

##4.Refactor Volume of Pyramid

You are given a **working code** that finds the **volume of a pyramid**. However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that **have multiple purpose**.

### Code

```C#
double dul, sh, V = 0;
Console.Write("Length: ");
dul = double.Parse(Console.ReadLine());
Console.Write("Width: ");
sh = double.Parse(Console.ReadLine());
Console.Write("Heigth: ");
V = double.Parse(Console.ReadLine());
V = (dul + sh + V) / 3;
Console.WriteLine("Pyramid Volume: {0:F2}", V);
```
### Hints

- **Reduce the span** of the variables by declaring them in the moment they receive a value, not before
- Rename your variables to **represent their** real **purpose** (example: &quot;dul&quot; should become length, etc.)
- Search for variables that have multiple purpose. If you find any, **introduce a new variable**.

##5.Refactor Special Numbers

You are given a **working code** that is a solution to **Problem 5. Special Numbers**. However, the variables are **improperly named, declared before** they are needed and some of them are used for multiple things. Without using your previous solution, **modify the code** so that it is **easy to read and understand**.

### Code
```C#
int kolkko = int.Parse(Console.ReadLine());
int obshto = 0; int takova = 0; bool toe = false;
for (int ch = 1; ch <= kolkko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        obshto += ch % 10;
        ch = ch / 10;
    }
    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
    Console.WriteLine($"{takova} -> {toe}");
    obshto = 0;
    ch = takova;
}
```
### Hints

- Reduce the span of the variables by declaring them in the moment they receive a value, not before
- Rename your variables to represent their real purpose (example: &quot;dul&quot; should become length, etc.)
- Search for variables that have multiple purpose. If you find any, introduce a new variable