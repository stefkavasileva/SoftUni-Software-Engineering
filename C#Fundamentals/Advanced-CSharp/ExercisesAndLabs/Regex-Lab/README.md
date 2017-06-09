# <p align="center"> Lab: Regular Expressions </p>

Problems for exercises and homework for the   [&quot;C# Advanced&quot; course @ SoftUni&quot;.](https://softuni.bg/courses/csharp-advanced)

Submit your solutions in the SoftUni judge system at [https://judge.softuni.bg/Contests/596/Regular-Expressions-Lab](https://judge.softuni.bg/Contests/596/Regular-Expressions-Lab).

# Part I: Basic Regex

## 1.Match Count

Find the **count of occurrences** of a word in a given text using regex.

The **word** to search for is given on the **first line**.

The **text** to search in is given on the **second line**.

### Examples

| **Input** | **Output** |
| --- | --- |
| regex <br/> A regular expression, regex or regexp (sometimes called a rational expression) is, in theoretical computer science and formal language theory, a sequence of characters that define a search pattern. | 2 |
| re <br/> A regular expression, regex or regexp (sometimes called a rational expression) is, in theoretical computer science and formal language theory, a sequence of characters that define a search pattern. | 6 |

> ### Hints
> - Read the input

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/14.PNG)

> - Create Regex object with the provided pattern


![Not fount](/C%23Fundamentals/Advanced-CSharp/images/15.PNG)

> - Count the occurrences

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/16.PNG)

> - Finally, print the result

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/17.PNG)

## 2.Vowel Count

Find the **count** of **all vowels** in a given **text** using a regex.

The vowels that you should be looking for are **upper** and **lower** **a** **,** **e** **,** **i** **,** **o** **,** **u** and **y**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Abraham Lincoln | Vowels: 5 |
| In 1519 Leonardo da Vinci died at theageof 67. | Vowels: 15 |
| n vwls. | Vowels: 0 |

### Hints

>- Read the input

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/18.PNG)

>- Create **Regex** object with the pattern that finds all vowels

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/19.PNG)

> - Count the occurrences
> - Finally, print the result

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/20.PNG)

## 3.Non-Digit Count

Find the count of all **non-digit characters** in a given text using regex.

### Examples

| **Input** | **Output** |
| --- | --- |
| Abraham Lincoln | Non-digits: 15 |
| In 1519 Leonardo da Vinci died at the age of 67. | Non-digits: 42 |
| 0 | Non-digits: 0 |

### Hints

> - Read the input
> - Create Regex object that matches all non-digit characters

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/21.PNG)

> - Count the occurrences and print the result

## 4.Extract Integer Numbers

Extract all **integer numbers** from a given **text** using regex.

Ignore number signs or decimal separators (See the examples below).

If there are **no numbers** , don&#39;t print anything.

### Examples

| **Input** | **Output** |
| --- | --- |
| In 1519 Leonardo da Vinci died at the age of 67. | 1519 <br/> 67 |
| Decimals: 7.22, 3.14. Negative -25. | 7 <br/> 22 <br/> 3 <br/> 14 <br/> 25 |
| No integers. | _(no output)_ |

## 5.Extract Tags

Extract all **tags** from a given HTML using regex.

Read lines until you get the **&quot;END&quot;** command.

If there are **no tags** , don&#39;t print anything.

### Examples

| **Input** | **Output** |
| --- | --- |
| &lt;!DOCTYPE html&gt;<br/> &lt;html lang=&quot;en&quot;&gt; <br/> &lt;head&gt; <br/> &nbsp;&nbsp;&nbsp;&nbsp;&lt;meta charset=&quot;UTF-8&quot;&gt;  &nbsp;&nbsp;&nbsp;&nbsp;    &lt;title&gt;Title&lt;/title&gt; <br/> &lt;/head&gt; <br/> &lt;/html&gt; <br/> END | &lt;!DOCTYPE html&gt; <br/> &lt;html lang=&quot;en&quot;&gt; <br/> &lt;head&gt; <br/> &lt;meta charset=&quot;UTF-8&quot;&gt; <br/> &lt;title&gt; <br/> &lt;/title&gt; <br/> &lt;/head&gt; <br/> &lt;/html&gt; |
| No tags. <br/> END | _(no output)_ |

# Part II: Regex Constructs

## 6.Valid Usernames

**Scan** through the lines for **valid usernames**.

A valid username:

- Has **length** between 3 and 16 characters
- **Contains** only letters, numbers, hyphens and underscores
- Has **no redundant symbols** before, after or in between

Read lines until you get the **&quot;END&quot;** command.

### Examples

| **Input** | **Output** |
| --- | --- |
| sh <br/> too\_long\_username <br/> !lleg@l ch@rs <br/> jeff\_butt <br/> END | invalid <br/> invalid <br/> invalid <br/>valid |
| END | _(no output)_ |

> ### Hints
> - Use character classes **[]**, quantifiers **{}** and anchors **^$**

## 7.Valid Time

Scan through the lines for valid times.

A **valid time** :

- Is **in the interval** 00:00:00 AM to 11:59:59 PM
- Has **no redundant symbols** before, after or in between

Read lines until you get the **&quot;END&quot;** command.

### Examples

| **Input** | **Output** |
| --- | --- |
| 11:33:24 AM <br/> 33:12:11 PM <br/> inv 23:52:34 AM <br/> 00:13:23     PM <br/> 9:3:12 АМ <rb/> END | valid <br/> invalid <br/> invalid <br/> invalid <br/> invalid |
| END | _(no output)_ |

## 8.Extract Quotations

**Extract** all **quotations** from a given text. The text will be on a single line.

A **valid quotation** should:

- Start and end with either single quotes ( **valid: &#39;quotation&#39;** ) or double quotes ( **valid: &quot;quotation&quot;** )
- Not have mixed quotes ( **invalid: &#39;quotation&quot;** )

**Skip nested** quotations.

### Examples

| **Input** | **Output** |
| --- | --- |
| &lt;a href=&#39;/&#39; id=&quot;home&quot;&gt;Home&lt;/a&gt;&lt;a class=&quot;selected&quot;&lt;/a&gt;&lt;a href = &#39;/forum&#39;&gt; | / <br/> home <br/> selected <br/> /forum |
| &lt;a href=&#39;/&#39; id=&#39;home&quot;&gt; | / |
| Skip &quot;nested &#39;quotes&#39;&quot; | nested &#39;quotes&#39; |
| No quotes. | _(no output)_ |