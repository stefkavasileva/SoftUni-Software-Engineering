#<p align="center"> Exercises: PHP Syntax, Basic Web <p>

Problems for exercises and homework for the [&quot;Software Technologies&quot; course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here [https://judge.softuni.bg/Contests/236/PHP-First-Steps-Exercises](https://judge.softuni.bg/Contests/236/PHP-First-Steps-Exercises).

# Part I: Simple operations with PHP

## 1.Multiply a Number by 2

You are given a number **num**. Write a PHP script that **multiplies** the **number by 2** and prints the result. The input comes as a parameter named **num**.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 2 | 4 |
|num | 3|6|

You will be given a HTML form that submits the input data:

```HTML
<form>
	N: <input type="text" name="num" />
	   <input type="submit" />
</form>
```
The name of the input parameter will be exactly as shown above – **num**.

Print the output in the HTML document, just after the HTML form.

### Hints

- In case the form was submitted and the input parameter **num** exists, take its value as integer using the function **intval(string)**.

```PHP 
 <?php
 if(isset($_GET['num'])) {
	$n = inval($_GET['num']));
}
?>
```
- Then, just print the results: **echo $n \* 2**.

 ```PHP 
 <?php
 if(isset($_GET['num'])) {
	$n = inval($_GET['num']));
	echo $n * 2;
}
?>
```

## 2.Multiply Two Numbers

You are given a number **num1** and a number **num2**. Write a PHP script that multiplies **num1 \* num2** and prints the result. The input comes as parameters named **num1** and **num2**. Print the output in the HTML page.

### Examples

**Parameters names**
num1
num2

| **Input** | **Output** |  
| --- | --- |--- | --- |
| 2 </br> 3 | 6 |
| 13 </br>  13| 169 |


### Hints

- This time the form which will be given to use will have 2 input elements, with names **num1** and **num2**![](data:image/*;base64,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)

```HTML
<form>
	N: <input type="text" name="num1" />
	M: <input type="text" name="num2" />
	   <input type="submit" />
</form>
```

- We must check both elements, if they have values before we perform any action

 ```PHP 
 <?php
 if(isset($_GET['num1']) && isset($_GET['num2'] ) {
  ..
  }
  ?>
 ```
- When we have checked both elements we get them both and extract their values into variables and we perform the specified action:

 ```PHP 
 <?php
 if(isset($_GET['num1']) && isset($_GET['num2'] ) {
	$n = inval($_GET['num1']));
	$m = inval($_GET['num2']));
  }
  ?> 
  ```
## 3.Multiply / Divide Numbers

You are given a number **num1** and a number **num2**. Write a PHP script that:

- Multiplies **num1**** \ *****num2** if **num2** is greater than or equal to **num1**.
- Divides **num1**** / ****num2** if **num1** is greater than **num2**.

The input comes as parameters named **num1** and **num2**. Print the output in the HTML page.

### Examples

| **Input** | **Output** |  
| --- | --- |
| 2 </br> 3 | 6 |  
| 13 <br> 13 | 169 | 
|3 </br> 2| 1.5 |


## 4.Product of 3 Numbers

You are given a number **num1** , **num2** and **num3**. Write a PHP script that finds if **num1 \* num2 \* num3** (the product) is **negative** or **positive**. Try to do this **WITHOUT** multiplying the 3 numbers.

The input comes as parameters named **num1** , **num2** and **num3**.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| 2 <br/> 3 </br> -1| Negative | 
| 5 </br> 4 </br> 3 | Positive |
| -3 </br> -4 </br> 5 | Positive |

### Hints

- Count the **negative numbers**. If they are odd number, the result will be negative, otherwise positive.
- Special case: one of the numbers is 0 the product is positive.

## 5.Numbers from 1 to N

You are given a number **num**. Write a PHP script that loops through all of the numbers from **1** to **num** and prints them. The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 5 | 1 2 3 4 5 |  
|num | 2 | 1 2 |

## 6.Numbers from N to 1

You are given a number **num**. Write a PHP script that loops through all of the numbers from **num** to **1** and prints them. The input comes as a parameter named **num**.The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 5 | 5 4 3 2 1 |  
|num | 2 | 2 1|

## 7.Even Numbers from 1 to N

You are given a number **num**. Write a PHP script that loops through all of the numbers from **1** to **num** and prints only the even ones. The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples
| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 5 |  2 4 |  
|num | 2 | 2 |

## 8.Odd Numbers from N to 1

You are given a number **num**. Write a PHP script that loops through all of the numbers from **num** to **1** and prints only the odd ones. The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 5 | 5 3 1 |  
|num | 2 | 1  |

## 9.N Factorial

You are given a number **num**. Write a PHP script that prints **factorial** of **num**. Factorial is calculated by multiplying all numbers to the given number. Factorial (N) = 1 \* 2 \* 3… \* **num**. The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** |
| --- | --- | --- |
| num | 5 | 120 |  
|num | 3 | 6 |

## 10.Not Divisor Numbers

You are given a number **num**. Write a PHP script that prints all the numbers from **num** to **1**** , **which are not divisors of** num ****.** The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 10 | 9 8 7 6 4 3 |  
|num | 12 | 11 10 9 8 7 5 |

## 11.FibonacciSequence

You are given a number **num**. Write a PHP script that prints **num** numbers from The Fibonacci sequence, each on a new line, starting from 1. In the Fibonacci sequence, every number is formed from the sum of the previous 2. The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 5 | 1 1 2 3 5 |  
|num | 10 | 1 1 2 3 5 8 13 21 34 55 |

## 12.Tribonacci Sequence

In the **&quot;Tribonacci&quot; sequence** , every number is formed by the **sum of the previous 3**.

You are given a number **num**. Write a PHP script that prints **num** numbers from the Tribonacci sequence, each on a new line, starting from 1. The input comes as a parameter named **num**.The value **num** will always be positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 4 | 1 1 2 4|  
|num | 8 | 1 1 2 4 7 13 24 44 |

## 13.Prime Numbers from N to 1

You are given a number **num**. Write a PHP script that printsonly the **prime** numbers from **num to 1**. A prime number is a number that can be divided only by 1 and itself. **1 is not a prime number.** The input comes as a parameter named **num**. The parameter **num** will hold a positive integer.

### Examples

| **Parameter name** | **Input** | **Output** |  
| --- | --- | --- | 
| num | 10 | 7 5 3 |  
|num | 20 | 19 17 13 11 7 5 3|

# Part 2: Manipulating HTML with PHP

## 14.HTML Buttons

You are given a number **num**. Write a PHP script that **generates HTML &lt;button&gt; elements.** The buttons must hold a number from **1** to **num** as their caption. The input comes as a parameter named **num** , holding a positive integer.

There is no indentation on the elements.

### Examples

| **Parameter name** | **Input** | **Output** | 
| --- | --- | ---|
| num | 3 |  &lt;button&gt;1&lt;/button&gt; </br>&lt;button&gt;1&lt;/button&gt; </br>&lt;button&gt;1&lt;/button&gt; |
| num | 5 | &lt;button&gt;1&lt;/button&gt; </br>&lt;button&gt;1&lt;/button&gt; </br>&lt;button&gt;1&lt;/button&gt; </br>&lt;button&gt;1&lt;/button&gt; </br>&lt;button&gt;1&lt;/button&gt; 
| num | 1 | &lt;button&gt;1&lt;/button&gt; |

## 15.Sub-Lists

You are given a number **num1** and a number **num2**. Write a PHP script that generates a list with **num1** elements, and each of those elements has a sub-list with **num2** elements. Each of the Lists has a caption &quot; **List #**&quot; where #is the current number from **1** to **num1****. **And each of the elements of those lists has a caption &quot;** Element #.# **&quot; where the first # is the current list number and the second** # **is the current element from** 1 **to** num2 **. The input comes as a parameters named** num1 **and** num2**, holding positive integers.

There is **indentation** on the elements. Each nested element is **tabbed**** once right** from its parent.

## 16.Draw an &quot;S&quot; with Buttons

Write a PHP script that draws 5 x 9 **&lt;button&gt;** elements with **0** and **1** in them. The **1** s should form a figure **&quot;S&quot;**. Make the **1** s&#39; background color – **blue**. There is no indentation on the elements.

## 17.RGB Table

Write a PHP script that draws a table with 3 columns, with captions – **Red** , **Green** and **Blue** , and 5 rows, each having as **background**** 1 **of** 5 **shades of those colors. Increase the color index by** 51** for each row. For example, for the Red Column it will be:

- RGB(51, 0, 0)
- RGB(102, 0, 0)
- RGB(153, 0, 0)
- . . .

The caption columns should **NOT** be colored. There indentation on the elements. Make the table cells in the table row **tabbed 1 times to the right**.

## 18.50 Shades of Grey

Write a PHP script that generates 5 rows of 10 **&lt;div&gt;**  **elements** , each having as background a different shade of grey – resulting in 50 shades of grey. Every row starts with a color index – a **multiple of 51**.

- First row – 0,
- Second row – 51,
- Third row – 102 …

Then you need to print **10 divs** , each increasing that index with **5.**

- First row – 0, 5, 10…
- Second row – 51, 56, 61…

The color index needs to be applied to **all**** parameters **of the** RGB function **. Example:** rgb(51, 51, 51);**
There is no indentation on the elements.