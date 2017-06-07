# <p align="center"> Lab: Manual String Processing </p>

# Lab: Manual String Processing

Problems for exercises and homework for the [&quot;C# Advanced&quot; course @ SoftUni&quot;.](https://softuni.bg/trainings/1633/csharp-advanced-may-2017)

Submit your solutions in the SoftUni judge system at [https://judge.softuni.bg/Contests/595/Manual-String-Processing-Lab](https://judge.softuni.bg/Contests/595/Manual-String-Processing-Lab).

## 1.Students Results

Write a program that reads number **N** from the console. After that read **N** lines with students with their results in format **{name} - {firstResult}, {secondResult}, {thirdResult}**

Print **table** on console. Each row must contain:

- **CAdv** - first result, align right with **precision of 2**
- **COOP** - second result, align right with **precision of 2**
- **AdvOOP** - third result, align right with **precision of 2**
- **Average** – average result with **precision of 4**
- Columns must be **separated** with **&quot;|&quot;**
- Don&#39;t forget **heading row**

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 <br/> Gosho - 3.33333, 4.4444, 5.555 |&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\|&nbsp;&nbsp;&nbsp;CAdv\|&nbsp;&nbsp;&nbsp;COOP\|&nbsp;AdvOOP\|Average\| <br/> &nbsp;Gosho&nbsp;&nbsp;&nbsp;&nbsp;\|&nbsp;&nbsp;&nbsp;3,33\|&nbsp;&nbsp;&nbsp;4,44\|&nbsp;&nbsp;&nbsp;5,56\|&nbsp;4,4442\| |
| 2 <br/> Mara - 5, 4, 3 <br/> Gosho - 3, 4, 5 |&nbsp;Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\|&nbsp;&nbsp;&nbsp;CAdv\|&nbsp;&nbsp;&nbsp;COOP\|&nbsp;AdvOOP\|Average\| <br/>&nbsp;Mara&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\|&nbsp;&nbsp;&nbsp;5,00\|&nbsp;&nbsp;&nbsp;4,00\|&nbsp;&nbsp;&nbsp;3,00\|&nbsp;4,0000\|<br/>&nbsp; Gosho&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\|&nbsp;&nbsp;&nbsp;3,00\|&nbsp;&nbsp;&nbsp;4,00\|&nbsp;&nbsp;&nbsp;5,00\|&nbsp;4,0000\| |

### Hints

It is up to you what type of data structures you will use to solve this problem

First row is **easy** , but long.

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/12.PNG)

Data rows are something terrible:

![Not fount](/C%23Fundamentals/Advanced-CSharp/images/13.PNG)

## 2.Parse URLs

Write a program that parses an URL address given in the format: **[protocol]://[server]/[resource]** and extracts from it the **[protocol]**, **[server]** and **[resource]** elements.

URL is invalid if:

- The protocol separator ( **://** ) or the resource separator is missing ( **/** )
- Contains second time the protocol separator **://**

### Examples

| **Input** | **Output** |
| --- | --- |
| [https://softuni.bg/courses/csharp-advanced](https://softuni.bg/courses/csharp-advanced) | Protocol = https <br/> Server = softuni.bg <br/> Resources = courses/csharp-advance |
| https://www.google.bg/search?q=google&amp;oq=goo&amp;aqs=chrome.0.0j69i60l2://j0j69i57j69i65.2112j0j7&amp;sourceid=chrome&amp;ie=UTF-8 | Invalid URL |

### Hints

In URL standard you can read that **&quot;://&quot;** is used to show where protocol name end. If you have this second time **&quot;://&quot;,** itwill be **invalid** URL

Server name ends with **&quot;/&quot;** , but it is **not** part of **resourses**.

Resources use same symbol **&quot;/&quot;** to show when we go deeper in **folders tree** , so be careful.

Think for proper operations over input:

- .Split()
- .Substring()
- .IndexOf()

## 3.Parse Tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags &lt; **upcase** &gt; and &lt;/ **upcase** &gt; to upper-case.

The tags cannot be nested.

### Examples

| **Input** | **Output** |
| --- | --- |
| We are living in a &lt;upcase&gt;yellow submarine&lt;/upcase&gt;. We don&#39;t have &lt;upcase&gt;anything&lt;/upcase&gt; else. | We are living in a YELLOW SUBMARINE. We don&#39;t have ANYTHING else. |
| &lt;upcase&gt;StringBuilder&lt;/upcase&gt; is &lt;upcase&gt;awesome&lt;/upcase&gt; | STRINGBUILDER is AWESOME |

> ### Hints
> Be careful with **replacing**** tags **with** empty** strings.
> After replacing tag with empty string, **indexes** in string are **not** the **same**.

## 4.Special Words

Read a string containing a **list of special word** s and a **text** containing some of these words.

Write a program **count special words** in textand **print** their count.

A word separator can be **( ) [] &lt; &gt; , - ! ?** **and space (&#39; &#39;)**

### Examples

| **Input** | **Output** |
| --- | --- |
| .NET Microsoft runs framework <br/> .NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. | .NET – 1 <br/> Microsoft – 2 <br/> runs – 1 <br/> framework - 1 |
| .NET Microsoft run <br/> .NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. | .NET - 1 <br/> Microsoft - 2 <br/> run - 0 |

## 5.Concatenate Strings

Write a program that read number **N** on first line. And on next **N** lines read single words and concatenate them like single line **text** with **&quot; &quot; separator** after each word.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 <br/> StringBuilder <br/> is <br/> awesome | StringBuilder is awesome |


> ### Hints
> Here we are not only look for **correct** results, but for **time** too.