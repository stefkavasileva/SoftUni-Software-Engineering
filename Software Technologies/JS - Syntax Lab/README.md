# <p align="center"> JavaScript Syntax and Basic Web  <p>

Problems for exercises and homework for the [&quot;Software Technologies&quot; course @ SoftUni](https://softuni.bg/courses/software-technologies).

You can submit your solutions here [https://judge.softuni.bg/Contests/223/](https://judge.softuni.bg/Contests/223/).

## 01.Sum Numbers with HTML and JS

Create an HTML form holding two text fields and a result field and write a JavaScript function to **sum** them.

### Examples

| **Input** | **Output** | 
| --- | --- | 
| 1 2 | 3 |   
| 5 5 | 10 |
| 10 15 | 25 |
| 1 5 | 6 |

### Step by Step

1.Create WebStorm Project

Open WebStorm and click Create New Project:
Give the folder a meaningful name, such as &quot;JS Syntax Lab&quot;:

2.Create a New HTML File

**Right click** the folder in the **Project view** , which just appeared (if you can&#39;t see the project view, go to **View-&gt;Tool Windows -&gt; Project** to open it), hover over the &quot; **New**&quot; menu, and click &quot; **HTML File**&quot;:

Give the HTML file a meaningful name:
After you create the file, it should look something like this:

3.Create the Form

```HTML
<form>
    <label for="num1"> First Number</label>
    <input type="text" id ="num1">
    <label for="num2">Second Number</label>
    <input type="text" id="num2">
    <input type="button" onclick="sumNumbers()" value="Calculate">
</form>
```
After you create the file, it&#39;s time to make the form. Create a **&lt;form&gt;** tag with some **&lt;input&gt;** fields inside:
The input fields are as follows:

- A **text** input field, called **num1**
- A **text** input field, called **num2**
- A **button** input, which calls the &quot;**sumNumbers()**&quot; function upon being clicked, and has the text &quot;Calculate&quot; inside it.

Apart from the form, we&#39;ve also created a **div** , which will hold the **result** of the calculation.

When we&#39;re done writing the code, our little html page should look something like this:

4.Write the JavaScript Code

```JavaScript
 function sumNumbers() {
        let num1 =document.getElementById('num1').value;
        let num2 =document.getElementById('num2').value;

        let sum =Number(num1)+ Number(num2);

        document.getElementById('result').innerHTML = sum;
    }
```
5.Open the HTML Page
Looks like it works!

## 2.Calculate Expression

Write a JavaScript program to print the value of the following expression:

- **((30 + 25) \* 1/3 \* (35 - 14 - 12))**
 **# 2**

### Examples

| **Input** | **Output** |
| --- | --- |
| _(no input)_ | 27225 |

### Hints

- This exercise has a **Judge**** contest ****entry** , so you need to create a **JavaScript**** function **, in order for the judge system to** accept **it as** valid **, and submit** only** that function, like so:

```JavaScript
function solve () {
    let result='';	//TODO...
    result*=result;
    console.log(result);
}

```
- You can solve this problem by either using the **Math.pow()** method or by multiplying the result by **itself**.

## 3.Sum Two Numbers

Write a JavaScript program to sum **two numbers** , which are received as a **string array**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| [&#39;10&#39;, &#39;20&#39;] | 30 |   | [&#39;66&#39;, &#39;4&#39;] | 70 |

### Hints

- The first and second numbers will be elements in the first parameter of the function, like so:

```JavaScript
 function sum(nums){
 
 }
```
 In this case, the two numbers would be **nums[0]** and **nums[1]**.
- Since the input is received as a **string array** , you&#39;re going to have to do some conversion, in order to be able to sum them.

## 4.Three Integers Sum

Write a JavaScript program, which receives **three numbers** , as a **string array**. Your task is to check whether there exists a number in the sequence, which is equal to the **sum** of the other two. If they are, print the numbers and their sum in the following format: &quot; **`${num1} + ${num2} = ${sum}`**&quot;. If there&#39;s no such element, print &quot; **No**&quot;.

### Examples

| **Input** | **Output** |  
| --- | --- |
| 8 15 7 | 7 + 8 = 15 |  
| -5 -3 -2 | -3 + -2 = -5 |   
| 3 8 12 | No |

## 5.Symmetric Numbers

Write a JavaScript program, which receives **a number**  **n** , as a **string array** with a single element, and print all symmetrical numbers in the range **[1…n]**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 100 | 1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99 |
| 750 | 1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99 101 111 121 131 141 151 161 171 181 191 202 212 222 232 242 252 262 272 282 292 303 313 323 333 343 353 363 373 383 393 404 414 424 434 444 454 464 474 484 494 505 515 525 535 545 555 565 575 585 595 606 616 626 636 646 656 666 676 686 696 707 717 727 737 747 |

## 6.Sums by Town

You are given a sequence of **JSON**** strings **holding** town **+** income **. Write a JS function to** sum **and print the** incomes **for** each town **. Towns can appear** multiple times **. In the output,** order **the towns by** name**.

### Examples

| **Input** | **Output** |
| --- | --- |
| {&quot;town&quot;:&quot;Sofia&quot;,&quot;income&quot;:200}<br/>{&quot;town&quot;:&quot;Varna&quot;,&quot;income&quot;:120} <br/>  {&quot;town&quot;:&quot;Pleven&quot;,&quot;income&quot;:60} <br/>{&quot;town&quot;:&quot;Varna&quot;,&quot;income&quot;:70} | Pleven -&gt; 60 <br/>Sofia -&gt; 200<br/>Varna -&gt; 190 |

## 7.Largest 3 Numbers

Write a program to read an **array** of **numbers** and find and print the **largest 3** of them, sorted in **descending order**.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| 10 30 15 20 50 5 | 50<br/>30<br/>20 |  
 | 20 30 | 30<br/>20 |  
 | 10 5 20 3 20 | 20<br/>20<br/>10 |

## 8.Extract Capital-Case Words

Write a **JavaScript** function to **extract** from array of strings all **capital-case** words. All **non-letter chars** are considered **separators**.

### Examples

| **Input** | **Output** |
| --- | --- |
| We start by HTML, CSS, JavaScript, JSON and REST.<br/>Later we touch some PHP, MySQL and SQL.<br/> Later we play with C#, EF, SQL Server and ASP.NET MVC.<br/> Finally, we touch some Java, Hibernate and Spring.MVC. | HTML, CSS, JSON, REST, PHP, SQL, C, EF, SQL, ASP, NET, MVC, MVC |