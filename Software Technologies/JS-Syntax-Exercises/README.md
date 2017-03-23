# <p align="center"> Exercises: JavaScript Syntax and Basic Web  <p>

Problems for exercises and homework for the [&quot;Software Technologies&quot; course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here [https://judge.softuni.bg/Contests/224/](https://judge.softuni.bg/Contests/224/).

## 1.Multiply a Number by 2

You are given a number **N**. Create a JS function that **multiplies** the **number by 2** and prints the result. The input comes as array of strings.

### Examples

| **Input** | **Output** | 
| --- | --- |
| 2 | 4 |  
 | 3 | 6 |
| 30 | 60 |
| 13 | 26 |

### Hints

- Note that the **input comes as array of strings** , so you should take the first element and parse it to number.
- Print the output to the console.

A sample solution might look like this:

```JavaScript
	function multiplyNumber(nums){
		let num = Number(nums[0]);
		return num * 2;
	}
```
Note that a simpler solution could also work, but is not recommended because it relies on automatic type conversion form array of strings to a number:

```JavaScript
	function multiplyNumber(nums){		
		return num * 2;
	}
```

## 2.Multiply Two Numbers

You are given a number **X** and a number **Y**. Create a JS function that multiplies **X \* Y** and prints the result. The input comes as array of strings.

### Examples

| **Input** | **Output** |  
| --- | --- |
| 2 <br/> 3 | 6 | 
| 13 <br/> 13 | 169 |
| 1 <br/> 2 | 2 |
| 0 <br/> 50 | 0 |

## 3.Multiply / Divide a Number by a Given Second Number

You are given a number **N** and a number **X**. Create a JS function that:

- Multiplies **N**** \ *****X** if **X** is greater than or equal to **N**
- Divides **N**** / ****X** if **N** is greater than **X**

The input comes as array of strings.

### Examples

| **Input** | **Output** |  
| --- | --- | 
| 2 <br/> 3 | 6 |   
| 13 <br/> 13 | 169 |
| 3 <br/> 2 | 1.5 |
|144 <br/ 12 | 12 |

## 4.Product of 3 Numbers

You are given a number **X** , **Y** and **Z**. Create a JS function that finds if **X** \* **Y** \* **Z** (the product) is negative or positive. Try to do this **WITHOUT** multiplying the 3 numbers.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| 2 <br/> 3 <br/> -1 | Negative |  
| 5 <br/> 4 <br/> 3 | Positive |
| -3 <br/> -4 <br/> 5 | Positive |

### Hint

- Count the **negative numbers**. If they are odd number, the result will be negative, otherwise positive.
- Special case: one of the numbers is 0 the product is positive.

## 5.Print Numbers from 1 to N

You are given a number **N**. Create a JS function that loops through all of the numbers from **1 to N** and prints them. **N** will always be positive.

### Examples

| **Input** | **Output** |  
| --- | --- | 
| 5 | 1 <br/> 2 <br/> 3 <br/> 4 <br/> 5 |   
| 2 | 1 <br/> 2 |

## 6.Print Numbers from N to 1

You are given a number **N**. Create a JS function that loops through all of the numbers from **N to 1** and prints them. **N** will always be positive.

### Examples

| **Input** | **Output** |   
| --- | --- |
| 5 | 5 <br/> 4 <br/> 3 <br/> 2 <br/> 1 |   
| 2 | 2 <br/> 1 |

## 7.Print Lines

You will be, continuously, given input lines, until you receive the command &quot; **Stop**&quot;. Print each of those lines at the moment you read them, until you reach the ending command. Do **NOT** print the ending command.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| Line 1 <br/> Line 2 <br/> Line 3 <br/> Stop | Line 1 <br/> Line 2 <br/> Line 3 |  
 | 3 <br/> 6 <br/> 5 <br/> 4 <br/> Stop <br/> 10 <br/> 12 | 3 <br/> 6 <br/> 5 <br/> 4 |

## 8.Print Numbers in Reversed Order

You will be given a few numbers as input. You need to print them in backward order, each on a new line.

### Examples

| **Input** | **Output** |  
| --- | --- | 
| 10 <br/> 15 <br/> 20 | 20 <br/> 15 <br/> 10 |  
| 5 <br/> 5.5 <br/> 24 <br/> -3 | -3 <br/> 24 <br/> 5.5 <br/> 5 |
| 20 <br/> 1 <br/> 20 <br/> 1 <br/> 20 | 20 <br/> 1 <br/> 20 <br/> 1 <br/> 20 |

## 9.Set Values to Indexes in an Array

You will be given **N** –an integer specifying the length of an array. Then you will start receiving an index and a value. For each received line you must set the value at the given index to the given value. When you&#39;ve processed all input data, print the array&#39;s elements each on a new line.

### Examples

| **Input** | **Output** | 
| --- | --- | 
| 3 <br/> 0 - 5 <br/> 1 - 6 <br/> 2 - 7 | 5 <br/> 6 <br/> 7 |   
| 2 <br/> 0 - 5 <br/> 0 - 6 <br/> 0 - 7 | 7 <br/> 0 | 
|5 <br/> 0 - 3 <br/> 3 - -1 <br/> 4 - 2 | 3 <br/> 0 <br/> 0 <br/> -1 <br/> 2 |

## 10.Add / Remove Elements

You will be given a sequence of **commands** (pairs of elements separated by a space): **command** and **argument**. You start by an empty array.

- The command &quot; **add number**&quot; appends the **number** to the array.
- The command &quot; **remove index**&quot;removes the element at the specified **index**. If the index is nonexistent, ignore that input line. When an element is deleted, all elements on the right from it, go one position left.

When you process all input data, **print the array&#39;s elements** each on a separate line.

### Examples

| **Input** | **Output** | 
| --- | --- | 
| add 3 <br/> add 5 <br/> add 7 | 3 <br/> 5 <br/> 7  |   
| add 3 <br/> add 5 <br/> remove 1 <br/> add 2 | 3 <br/> 2 |
| add 3 <br/> add 5 <br/> remove 2 <br/> remove 0 <br/> add 7 | 5 <br/> 7 |

## 11.Working with Key-Value Pairs

You will be given input lines, each holding **two elements** separated by a space. The first is the **key** and the second is the **value**. Your task is to store the value for each key. If a key already exists, you need to **replace** the old value with the new one. At the last line of input you will receive a **key**. You must print the **value** corresponding to that **key**. If there is no such, just print &quot; **None**&quot;.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| key value <br/> key eulav <br/> test tset <br/> key | eulav |   
| 3 test <br/> 3 test1 <br/> 4 test2 <br/> 4 test3 <br/> 4 test5 <br/> 4 | test5 | 
|3 bla <br/> 3 alb <br/> 2 | None |

## 12.Multiple Values for a Key

You will be given input lines, each holding **two elements** separated by a space: **key** and **value**. You need to store the given values to the given keys. At the last line of the input you will receive a **key**. You must **print all the values** corresponding to that key. If there are no such, just print &quot; **None**&quot;.

### Examples

| **Input** | **Output** | 
| --- | --- | --- | --- | --- | --- | --- | --- |
| key value <br/> key eulav <br/> test tset <br/> key | value <br/> eulav |   
| 3 test <br/> 3 test1 <br/> 4 test2 <br/> 4 test3 <br/> 4 test5 <br/> 4 | test2 <br/> test3 <br/> test5 |
| 3 bla <br/> 3 alb <br/> 2 | None |

## 13.Storing Objects

You will be given input lines, each holding information about a **student** : **name** , **age** and **grade**. The data come in the format like at the examples below.

Extract that information from the input lines into **JS objects**.

Print the objects in the order of appearance, in format like at the examples below.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho -&gt; 13 -&gt; 6.00 <br/> Ivan -&gt; 12 -&gt; 5.57 <br/> Toni -&gt; 13 -&gt; 4.90 | Name: Pesho <br/> Age: 13 <br/> Grade: 6.00 <br/> Name: Ivan <br/> Age: 12 <br/> Grade: 5.57 <br/> Name: Toni <br/> Age: 13 <br/> Grade: 4.90 |

## 14.Parse JSON Objects

You will be given input lines ( **text** ) holding object data in **JSON format**. Use the **JSON.parse(str)** function to parse the data into **JavaScript objects** , and then print them as shown in the examples.

### Examples

| **Input** | **Output** |
| --- | --- |
| {&quot;name&quot;:&quot;Gosho&quot;,&quot;age&quot;:10,&quot;date&quot;:&quot;19/06/2005&quot;} <br/> {&quot;name&quot;:&quot;Tosho&quot;,&quot;age&quot;:11,&quot;date&quot;:&quot;04/04/2005&quot;} | Name: Gosho <br/> Age: 10 <br/> Date: 19/06/2005 <br/> Name: Tosho <br/> Age: 11 <br/> Date: 04/04/2005 |

## 15.Turn Object into JSON String

You will be given input lines holding information about an object in format **key -&gt; value**. Create a **JS object** and save these keys and values in it. After you&#39;ve processed all of the input data, print the **JSON** version of the object. Use the **JSON.stringify(obj)** function.

### Examples

| **Input** | **Output** |
| --- | --- |
| name -&gt; Angel <br/> surname -&gt; Georgiev <br/> age -&gt; 20 <br/> grade -&gt; 6.00 <br/> date -&gt; 23/05/1995 <br/> town -&gt; Sofia | {&quot;name&quot;:&quot;Angel&quot;,&quot;surname&quot;:&quot;Georgiev&quot;,&quot;age&quot;:20,&quot;grade&quot;:6,&quot;date&quot;:&quot;19/05/1995&quot;,&quot;town&quot;:&quot;Sofia&quot;} |