# <p align="center"> Exercises: Regular Expressions </p>

This document defines the **exercise assignments** for the [&quot;CSharp Advanced&quot; course @ Software University](file:///h). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/).

## Problem 1.Match Full Name

Write a regular expression to match a valid full name. A valid full name consists of **two words** , each word **starts** with a **capital letter** and contains **only lowercase letters afterwards** ; each word should be **at least two letters long** ; the two words should be **separated by a single space**.

To help you out, we&#39;ve outlined several steps:

- Use an online regex tester like [https://regex101.com/](https://regex101.com/)
- Check out how to use **character sets** (denoted with square brackets - &quot;[]&quot;)
- Specify that you want two words with a space between them (the **space character &#39; &#39;** , and not any whitespace symbol)
- For each word, specify that it should begin with an uppercase letter using a **character set**. The desired characters are in a range – **from &#39;A&#39; to &#39;Z&#39;**.
- For each word, specify that what follows the first letter are only **lowercase letters** , one or more – use another character set and the correct **quantifier**.
- To prevent capturing of letters across new lines, put &quot;\b&quot; at the beginning and at the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).

In order to check your regex, use these values for reference (paste all of them in the Test String field):

### Examples

| **Match ALL of these** | **Match NONE of these** |
| --- | --- |
| Ivan Ivanov | ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan        Ivanov |

| **Input** | **Output** |
| --- | --- |
| ivan ivanov <br/> Ivan Ivanov <br/> end | Ivan Ivanov |

## Problem 2.Match Phone Number

Write a regular expression to match a valid phone number from Sofia. A valid number will start with &quot;+359&quot; followed by the area code (2) and then the number itself, consisting of 7 digits (separated in two group of 3 and 4 digits respectively). The different parts of the number are separated by **either a space or a hyphen** (&#39;-&#39;). Refer to the examples to get the idea.

- Use quantifiers to match a specific number of digits
- Use a capturing group to make sure the delimiter is **only one of the allowed characters** **(space or hyphen)** and not a combination of both. Use the group number to achieve this
- Add a word boundary at the end of the match to avoid partial matches (the last example on the right-hand side)
- Ensure that before the &#39;+&#39; sign there is either a space or the beginning of the string

### Examples

| **Match ALL of these** | **Match NONE of these** |
| --- | --- |
| +359 2 222 2222 <br/> +359-2-222-2222 | 359-2-222-2222, +359/2/222/2222, +359-2 222 2222+359 2-222-2222, +359-2-222-222, +359-2-222-22222 |

| **Input** | **Output** |
| --- | --- |
| +359 2 222 2222+ <br/> 3591345123 <br/> end | +359 2 222 2222  |
| +359 2 234 5678+ <br/> 359-2-234-5678 <br/> +359-2 234-5678 <br/> end | +359 2 234 5678 <br/> +359-2-234-5678 |

## Problem 3.Series of Letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

### Examples

| **Input** | **Output** |
| --- | --- |
| aaaaabbbbbcdddeeeedssaa | abcdedsa |

## Problem 4.Replace &lt;a&gt; tag

Write a programthat replaces in a HTML document given as string **all the tags &lt;a href=…&gt;…&lt;/a&gt;** with corresponding **tags [URL href=…&gt;…[/URL]**.Read an input, until you receive **&quot;end&quot; command**. Print the result on the console.

### Examples

| **Input** | **Output** |
| --- | --- |
| &lt;ul&gt; &lt;li&gt; &lt;a href= **&quot;http://softuni.bg&quot;** &gt;SoftUni&lt;/a&gt; &lt;/li&gt; &lt;/ul&gt; **end** | &lt;ul&gt; &lt;li&gt;  [URL href= **http://softuni.bg** &gt;SoftUni[/URL] &lt;/li&gt;&lt;/ul&gt; |

**Note** : The input may be read on a single line (unlike the example above) or from a file. Remove all new lines if you choose the first approach.

## Problem 5.Extract Emails

Write a program to **extract all email addresses from a given text**. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format **&lt;user&gt;@&lt;host&gt;** , where:

- **&lt;user&gt;** is a sequence of letters and digits, where &#39; **.** &#39;, &#39; **-** &#39; and &#39; **\_** &#39; can appear between them. Examples of valid users: &quot; **stephan**&quot;, &quot; **mike03**&quot;, &quot; **s.johnson**&quot;, &quot; **st\_steward**&quot;, &quot; **softuni-bulgaria**&quot;, &quot; **12345**&quot;. Examples of invalid users: &#39;&#39; **--123** &quot;, &quot;.....&quot;, &quot; **nakov\_-**&quot;, &quot; **\_steve**&quot;, &quot; **.info**&quot;.
- **&lt;host&gt;** is a sequence of at least two words, separated by dots &#39; **.** &#39;. Each word is sequence of letters and can have hyphens &#39; **-**&#39; between the letters. Examples of hosts: &quot; **softuni.bg**&quot;, &quot; **software-university.com**&quot;, &quot; **intoprogramming.info**&quot;, &quot; **mail.softuni.org**&quot;. Examples of invalid hosts: &quot; **helloworld**&quot;, &quot; **.unknown.soft.**&quot;, &quot; **invalid-host-**&quot;, &quot; **invalid-**&quot;.
- Examples of **valid emails** : info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, [info-bg@software-university.software.academy](mailto:info-bg@software-university.software.academy).
- Examples of **invalid emails** : [--123@gmail.com](mailto:--123@gmail.com), …@mail.bg, [.info@info.info](mailto:.info@info.info), [\_steve@yahoo.cn](mailto:_steve@yahoo.cn), mike@helloworld, [mike@.unknown.soft](mailto:mike@.unknown.soft)., [johnson@invalid-](mailto:s.johnson@invalid-).

### Examples

| **Input** | **Output** |
| --- | --- |
| Please contact us at: support@github.com. | _support@github.com_ |
| Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information. | _s.miller@mit.edu__j.hopking@york.ac.uk_ |
| Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de. | _steve.parker@softuni.de_ |

## Problem 6.Sentence Extractor

Write a program that reads a **keyword** and some **text** from the console and prints **all sentences from the text, containing that word**. A sentence is any sequence of words ending with &#39; **.&#39;** , &#39; **!&#39;** or &#39; **?&#39;**.

### Examples

| **Input** | **Output** |
| --- | --- |
| is <br/> This **is** my cat! And this **is** my dog. We happily live in Paris – the most beautiful city in the world! Isn&#39;t it great? Well it is :) | This is my cat!<br/>  And this is my dog. |

## Problem 7.\* Valid Usernames

**This problem is from the Java Basics Exam (21 September 2014 Evening). You may check your solution** [**here**](https://judge.softuni.bg/Contests/Practice/Index/34#2) **.**

You are part of the back-end development team of the next Facebook. You are given **a line of usernames** , between one of the following symbols**: space, &quot;/&quot;, &quot;\&quot;, &quot;(&quot;, &quot;)&quot;.** First you have to export all **valid** usernames. A valid username **starts with a letter** and can contain **only letters, digits and &quot;\_&quot;**. It cannot be **less than 3 or more than 25 symbols** long. Your task is to **sum** the length of **every**** 2 consecutive ****valid** usernames and print on the console the 2 valid usernames with **biggest**** sum **of their** lengths,** each on a separate line.

### Input

The input comes from the console. One line will hold all the data. It will hold **usernames,** divided by the symbols: **space, &quot;/&quot;, &quot;\&quot;, &quot;(&quot;, &quot;)&quot;.**

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

Print at the console the 2 **consecutive**** valid usernames **with the** biggest ****sum** of their lengths each on a separate line. If there are **2 or more couples** of usernames with the same sum of their lengths, print he **left most**.

### Constraints

- The input line will hold characters in the range [0 … 9999].
- The usernames should **start with a letter** and can contain **only letters, digits and &quot;\_&quot;**.
- The username cannot be **less than 3 or**** more than 25 symbols** long.
- Time limit: 0.5 sec. Memory limit: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| ds3bhj y1ter/wfsdg 1nh\_jgf ds2c\_vbg\4htref | wfsdgds2c\_vbg |

| **Input** | **Output** |
| --- | --- |
| min23/ace hahah21 (    sasa  )  att3454/a/a2/abc | hahah21sasa |

| **Input** | **Output** |
| --- | --- |
| chico/ gosho \ sapunerka (3sas) mazut  lelQ\_Van4e | mazutlelQ\_Van4e |

## Problem 8.\*\* Extract Hyperlinks

**This problem is originally from the JavaScript Basics Exam (27 July 2014). You may check your solution** [**here**](https://judge.softuni.bg/Contests/Practice/Index/84#2) **.**

Write a program to **extract all hyperlinks** ( **&lt;href=…&gt;** ) from a given text. The text comes from the console on a variable number of lines and ends with the command &quot;END&quot;. Print at the console the **href** values in the text.

The input text is **standard HTML code**. It may hold many tags and can be formatted in many different forms (with or without whitespace). The **&lt;a&gt;** elements may have many attributes, not only **href**. You should extract only the values of the **href** attributes of all **&lt;a&gt;** elements.

### Input

The input data comes from the console. It ends when the &quot;END&quot; command is received.

### Output

Print at the console the **href** values in the text, each at a separate line, in the order they come from the input.

### Constraints

- The input will be **well formed HTML fragment** (all tags and attributes will be correctly closed).
- Attribute values will never hold tags and hyperlinks, e.g. &quot; **&lt;img alt=&#39;&lt;a href=&quot;hello&quot;&gt;&#39; /&gt;**&quot; is invalid.
- Commented links are also extracted.
- The number of input lines will be in the range [1 ... 100].
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| &lt;a href=&quot;http://softuni.bg&quot; class=&quot;new&quot;&gt;&lt;/a&gt; <br/> END | http://softuni.bg |
| &lt;p&gt;This text has no links&lt;/p&gt; <br/> END |   |

## Problem 9.\* Query Mess

**This problem is originally from the JavaScript Basics Exam (22 November 2014). You may check your solution** [**here**](https://judge.softuni.bg/Contests/Practice/Index/84#3) **.**

**Ivancho** participates in a team **project** with colleagues at **SoftUni**.  They have to develop **an application** , but something _mysterious_ happened – at the last moment all team members… disappeared!  And guess what? He is left **alone** to finish the project.  All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that! Can you help him?

### Input

The input comes from the console on a variable number of lines and ends when the keyword &quot;END&quot; is received.

For each row of the input, the query string contains pairs field=value. Within each pair, the field name and value are separated by an equals sign, &#39;=&#39;. The series of pairs are separated by an ampersand, &#39;&amp;&#39;. The question mark is used as a separator and is not part of the query string. A URL query string may contain another URL as value. The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

**For each input line, print** on the console a line containing the **processed string as follows** :  key=[value]nextkey=[another  value] … etc.

**Multiple whitespace** characters should be reduced to one inside value/key names, but there shouldn&#39;t be any whitespaces before/after extracted **keys** and **values**. If a key **already exists** , the value is added with comma and space after other values of the existing key in the current string.  See the **examples** below.

### Constraints

- SPACE is encoded as &#39;+&#39; or &quot;%20&quot;.Letters (A-Z and a-z), numbers (0-9), the characters &#39;\*&#39;, &#39;-&#39;, &#39;.&#39;, &#39;\_&#39; and _other non-special symbols_ are left as-is.
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| login=student&amp;password=student <br/> END | login=[student]password=[student] |
| **Input** |
| field=value1&amp;field=value2&amp;field=value3 <br/> http://example.com/over/there?name=ferret <br/> END |
| **Output** |
| field=[value1, value2, value3]name=[ferret] |

## Problem 10.\* Use Your Chains, Buddy

**This problem is from the JavaScript Basics Exam (9 January 2015). You may check your solution** [**here**](https://judge.softuni.bg/Contests/Practice/Index/56#2) **.**

You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut. You need to get there by car. But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted…

As input you will receive **an HTML document** as a **single string**. You need to get the text from **all the &lt;p&gt; tags** and replace all characters which are **not small letters and numbers** with a space **&quot; &quot;**. After that you must decrypt the text – all letters **from a to m** are **converted** to letters **from n to z** (a ? n; b ? o; … m ? z). The letters **from n to z** are **converted** to letters **from a to m** (n ? a; o ? b; … z ? m). All **multiple** spaces should then be replaced by only **one space**.

For example, if we have **&quot;&lt;div&gt;Santa&lt;/div&gt;&lt;p&gt;znahny # grkg ()&amp;^^^&amp;12&lt;/p&gt;&quot;** we extract **&quot;znahny # grkg ()&amp;^^^&amp;12&quot;**. Every **character** that is **not a small letter or a number** is replaced with aspace ( **&quot;znahny grkg       12&quot;** ). We convert each small letter as described above ( **&quot;znahny grkg       12&quot;**  **?**  **&quot;manual text       12&quot;** ) and replace all multiple spaces with only **one space** ( **&quot;manual text 12&quot;** ). Finally, we concatenate the decrypted text from all **&lt;p&gt;&lt;/p&gt;** tags (in this case, it&#39;s only one). And there you go – you have the manual ready to read!

### Input

The input is read from the console and consists of just one line – the **string** with the **HTML document**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

**Print** on a single line the decrypted text of the manual. See the given **examples** below.

### Constraints

- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

### Examples

| **Input** |
| --- |
| &lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;hello&lt;/h1&gt;&lt;p&gt; **znahny!@#%&amp;&amp;&amp;&amp;\*\*\*\*** &lt;/p&gt;&lt;div&gt;&lt;button&gt;dsad&lt;/button&gt;&lt;/div&gt;&lt;p&gt;**grkg^^^^%%%)))([]12**&lt;/p&gt;&lt;/body&gt;&lt;/html&gt; |
| **Output** |
| manual text 12 |
|   |
| **Input** |
| &lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;Intro&lt;/h1&gt;&lt;ul&gt;&lt;li&gt;Item01&lt;/li&gt;&lt;li&gt;Item02&lt;/li&gt;&lt;li&gt;Item03&lt;/li&gt;&lt;/ul&gt;&lt;p&gt; **jura qevivat va jrg fyvccrel fabjl** &lt;/p&gt;&lt;div&gt;&lt;button&gt;Click me, baby!&lt;/button&gt;&lt;/div&gt;&lt;p&gt; **pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx** &lt;/p&gt;&lt;span&gt;This manual is false, do not trust it! The illuminati wrote it down to trick you!&lt;/span&gt;&lt;p&gt; **vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg** &lt;/p&gt;&lt;p&gt; **pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf** &lt;/p&gt;&lt;/body&gt; |
| **Output** |
| when driving in wet slippery snowy conditions snow dchains are absolutely essential for safe handling although snow chains may look intimidating the basic idea is really simple fit them over your tires drive forward slowly and tighten them up in cold wet conditions this is easier said than done but if you put on your tires |

## Problem 11. \*\* Semantic HTML

**This problem is originally from the PHP Basics Exam (31 August 2014). You may check your solution** [**here**](https://judge.softuni.bg/Contests/Practice/Index/84#4) **.**

You are given an **HTML code** , written in the old **non-semantic** style using tags like **&lt;div id=&quot;header&quot;&gt;** , **&lt;div class=&quot;section&quot;&gt;** , etc. Your task is to write a program that **converts this HTML to semantic HTML** by changing tags like **&lt;div id=&quot;header&quot;&gt;** to their semantic equivalent like **&lt;header&gt;**.

The non-semantic tags that should be converted are **always &lt;div&gt;** s and have either **id** or **class** with one of the following values: &quot; **main**&quot;, &quot; **header**&quot;, &quot; **nav**&quot;, &quot; **article**&quot;, &quot; **section**&quot;, &quot; **aside**&quot; or &quot; **footer**&quot;. Their corresponding closing tags are always followed by a comment like **&lt;!-- header --&gt;** , **&lt;!-- nav --&gt;** , etc. staying at the same line, after the tag.

### Input

The input will be read from the console. It will contain a variable number of lines and will end with the keyword &quot; **END**&quot;.

### Output

The output is the semantic version of the input HTML. In all converted tags you should **replace multiple spaces** (like **&lt;header style=&quot;color:red&quot;&gt;**) with a single space and remove excessive spaces at the end (like**&lt;footer &gt;** ). 

### Constraints

- Each line from the input holds either an HTML **opening tag** or an HTML **closing tag** or HTML **text content**.
- There will be no tags that span several lines and no lines that hold multiple tags.
- Attributes values will always be enclosed in double quotes **&quot;**.
- Tags will never have **id** and **class** at the same time.
- The HTML will be **valid**. Opening and closing tags will match correctly.
- **Whitespace** may occur between attribute names, values and around comments (see the examples).
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| &lt;div id=&quot;header&quot;&gt; <br/> &lt;/div&gt; &lt;!-- header --&gt; <br/> END | &lt;header&gt;&lt;/header&gt; |
  