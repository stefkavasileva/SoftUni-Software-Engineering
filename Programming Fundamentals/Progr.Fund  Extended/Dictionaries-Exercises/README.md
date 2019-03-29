# <p align="center"> Exercises: Dictionaries
</p>

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions [here:](https://judge.softuni.bg/Contests/431/Dictionaries-Exercises)

# 1.Letter Repetition

You will be given a **single string** , containing **random ASCII character**. Your task is to **print every character** , and how **many times** it has been used in the **string**.

### Examples

| **Input** | **Output** |
| --- | --- |
| aaabbaaabbbccc | a -&gt; 6<br/>b -&gt; 5<br/>c -&gt; 3 |
| The quick brown fox jumps over the lazy dog | T -&gt; 1<br/>h -&gt; 2<br/>e -&gt; 3<br/>  -&gt; 8<br/>q -&gt; 1<br/>u -&gt; 2<br/>i -&gt; 1<br/>c -&gt; 1<br/>k -&gt; 1<br/>b -&gt; 1<br/>r -&gt; 2<br/>o -&gt; 4<br/>w -&gt; 1<br/>n -&gt; 1<br/>f -&gt; 1<br/>x -&gt; 1<br/>j -&gt; 1<br/>m -&gt; 1<br/>p -&gt; 1<br/>s -&gt; 1<br/>v -&gt; 1<br/>t -&gt; 1<br/>l -&gt; 1<br/>a -&gt; 1<br/>z -&gt; 1<br/>y -&gt; 1<br/>d -&gt; 1<br/>g -&gt; 1 |

# 2.Dict-Ref

You have been tasked to create a referenced dictionary, or in other words a dictionary, which knows how to reference itself.

You will be given several input lines, in one of the following formats:

- **\{name} = \{value}**
- **\{name} = \{secondName}**

The **names** will always be **strings** , and the **values** will always be **integers**.

In case you are given a **name** and a **value** , you must store the **given name** and its **value**. If the name already **EXISTS** , you must **CHANGE** its **value** with the **given one**.

In case you are given a **name** and a **second name** , you must **store** the **given name** with the **same value** as the **value** of the **second name**. If the given **second name**** DOES NOT **exist, you must** IGNORE** that input.

When you receive the command &quot; **end**&quot;, you must print **all**** entries **with their** value **, by** order **of** input**, in the following format:

**\{entry} === \{value}**

### Examples

| **Input** | **Output** |
| --- | --- |
| Cash = 500<br/>Johny = 5<br/>Cash = 200<br/>Johnny = 200<br/>Car = 150P<br/>lane = 2000000<br/>end | Cash === 200<br/>Johny === 5<br/>Johnny === 200<br/>Car === 150<br/>Plane === 2000000 |
| Entry1 = 10000<br/>Entry2 = 12345<br/>Entry3 = 10101<br/>Entry4 = Entry1<br/>Entry2 = Entry3<br/>Entry3 = Entry4<br/>end | Entry1 === 10000<br/>Entry2 === 10101<br/>Entry3 === 10000<br/>Entry4 === 10000  |

# 3.Mixed Phones

You will be given several phone entries, in the form of strings in format:

{firstElement} : {secondElement}

The first element is usually the person&#39;s name, and the second one – his phone number. The phone number consists ONLY of digits, while the person&#39;s name can consist of any ASCII characters.

Sometimes the phone operator gets distracted by the Minesweeper she plays all day, and gives you first the phone, and then the name. **e.g. : 0888888888 : Pesho**. You must store them correctly, even in those cases.

When you receive the command &quot; **Over**&quot;, you are to **print all names** you&#39;ve stored with their phones. The names must be printed in **alphabetical order**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 14284124 : Alex<br/>Gosho : 088423123<br/>Ivan : 412048192<br/>123123123 : Nanyo <br/>Pesho : 150925812<br/>Over | Alex -&gt; 14284124<br/>Gosho -&gt; 88423123<br/>Ivan -&gt; 412048192<br/>Nanyo -&gt; 123123123<br/>Pesho -&gt; 150925812 |
| Ivan : 13213456<br/>GeorgeThe2nd : 131313<br/>Johnny : 5556322312<br/>Donald : 3212<br/>Over | Donald -&gt; 3212<br/>GeorgeThe2nd -&gt; 131313<br/>Ivan -&gt; 13213456<br/>Johnny -&gt; 5556322312 |

# 4.Exam Shopping

A supermarket has **products** which have **quantities**. Your task is to stock the shop before **Exam Sunday**. Until you receive the command &quot; **shopping time**&quot;, **add** the various **products** to the shop&#39;s **inventory** , keeping track of their **quantity** (for inventory purposes). When you receive the aforementioned command, the students start pouring in before the exam and **buy** various **products**.

The format for **stocking** a product is: &quot; **stock {product} {quantity}**&quot;.

The format for **buying** a product is: &quot; **buy {product} {quantity}**&quot;.

If a student **tries** to buy a product, which **doesn&#39;t exist** , print &quot; **{product} doesn&#39;t exist**&quot;. If it does exist, but it&#39;s **out of stock** , print &quot; **{product} out of stock**&quot;. If a student tries buying **more** than the quantity of that product, sell them **all**** the ****quantity** of the product (the product is left out of stock, **don&#39;t** print anything).

When you receive the command &quot; **exam time**&quot;, your task is to **print** the **remaining** inventory in the following format: &quot; **{product} -&gt; {quantity}**&quot;. If a product is out of stock, **do not** print it.

### Examples

| **Input** | **Output** |
| --- | --- |
| stock Boca\_Cola 10<br/>stock Boca\_Cola 10<br/>stock Kay&#39;s 3<br/>stock Kay&#39;s 2<br/>shopping time<br/>buy Boca\_Cola 5<br/>buy Kay&#39;s 5<br/>exam time | Boca\_Cola -&gt; 15  |
| stock Lobster\_Energy 20<br/>stock Loreni 30<br/>stock Loreni 30<br/>stock Lobster\_Energy 10<br/>shopping time<br/>exam time | Lobster\_Energy -&gt; 30Loreni -&gt; 60 |
| stock Boca\_Cola 16<br/>stock Kay&#39;s\_Chips 33<br/>stock Lobster\_Energy 60<br/>stock Boca\_Cola 4<br/>stock Loreni 15<br/>stock Loreni 15<br/>stock Loreni 15<br/>stock Loreni 15<br/>shopping time<br/>buy Boca\_Bola 2<br/>buy Lobster\_Energy 20<br/>buy Boca\_Cola 1<br/>buy Boba\_Bola 12<br/>exam time | Boca\_Bola doesn&#39;t exist<br/>Boba\_Bola doesn&#39;t exist<br/>Boca\_Cola -&gt; 19<br/>Kay&#39;s\_Chips -&gt; 33<br/>Lobster\_Energy -&gt; 40<br/>Loreni -&gt; 60 |

# 5.User Logins

Write a program that receives a **list** of **username-password pairs** in the format &quot; **{username} -&gt; {password}**&quot;. If there&#39;s already a user with that username, **replace their password**. After you receive the command &quot; **login**&quot;, **login requests** start coming in, using the **same format**. Your task is to print the status of user login, using different messages as per the conditions below:

- If the password matches with the user&#39;s password, print &quot; **{username}: logged in successfully**&quot;.
- If the user doesn&#39;t exist, or the password doesn&#39;t match the user, print &quot; **{username}: login failed**&quot;.

When you receive the command &quot; **end**&quot;, print the **count** of **unsuccessful** login attempts, using the format &quot; **unsuccessful login attempts: {count}**&quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| ivan\_ivanov -&gt; java123<br/>pesh0 -&gt; qwerty<br/>stamat4e -&gt; 111111<br/>princess\_penka -&gt; MyPrince<br/> **login**<br/> pesh0 -&gt; qwertt<br/>ivan\_ivanov -&gt; java123<br/>stamat4e -&gt; 111112<br/>princess\_penka -&gt; MyPrinceend | pesh0: login failed<br/>ivan\_ivanov: logged in successfully<br/>stamat4e: login failed<br/>princess\_penka: logged in successfully<br/>unsuccessful login attempts: 2 |
| johnny\_bravo05 -&gt; woahMama <br/>**login**<br/> johnny\_bravo06 -&gt; woahMama<br/>johnny\_bravo05 -&gt; woahmama<br/>johnny\_bravo05 -&gt; WoahMama<br/>johnny\_bravo05 -&gt; wohMama<br/>johnny\_bravo05 -&gt; woahMama<br/>end | johnny\_bravo06: login failed<br/>johnny\_bravo05: login failed<br/>johnny\_bravo05: login failed<br/>johnny\_bravo05: login failed<br/>johnny\_bravo05: logged in successfully<br/>unsuccessful login attempts: 4 |
| walter\_white58 -&gt; iamthedanger<br/>krazy\_8 -&gt; ese<br/>jesseABQ -&gt; bword<br/> **login** <br/>krazy\_8 -&gt; ese<br/>krazy\_8 -&gt; ese<br/>jesse -&gt; bword<br/>jesseabq -&gt; bword<br/>walter\_white58 -&gt; IAmTheDanger<br/>walter\_white58 -&gt; iamthedanger<br/>end | krazy\_8: logged in successfully<br/>krazy\_8: logged in successfully<br/>jesse: login failed<br/>jesseabq: login failed<br/>walter\_white58: login failed<br/>walter\_white58: logged in successfully<br/>unsuccessful login attempts: 3 |

> ### Hints

> - **Parse the commands** by splitting by space. The first element is the username, while the third element is the password.
> - Store the **user entries** in **Dictionary&lt;string, string&gt;** with key **{username}** and value **{password}**.

# 6.Filter Base

You have been tasked to sort out a database full of information about employees. You will be given several input lines containing information in one of the following formats:

- **\{name}** -&gt; **\{age}**
- **\{name}** -&gt; **\{salary}**
- **\{name}** -&gt; **\{position}**

As you see you have 2 parameters. There can be only 3 cases of input:
If the second parameter is an **integer** , you must store it as **name** and **age**.

If the second parameter is a **floating-point number** , you must store it as **name** and **salary**.

If the second parameter is a **string** , you must store it as **name** and **position**.

You must read input lines, then parse and store the information from them, **until** you receive the command
&quot; **filter base**&quot;. When you receive that command, the **input sequence** of **employee information** should **end**.

On the last line of input you will receive a string, which can either be &quot; **Age**&quot;, &quot; **Salary**&quot; or &quot; **Position**&quot;. Depending on the case, you must **print all entries** which **have been stored** as **name** and **age** , **name** and **salary** , or **name** and **position**.

In case, the given last line is &quot; **Age**&quot;, you must print every employee, stored with its **age** in the following format:

Name: **\{name1}**<br/>
Age: **\{age1}**<br/>
\====================<br/>
Name: **{name2}**<br/>
. . .

In case, the given last line is &quot; **Salary**&quot;, you must print every employee, stored with its **salary** in the following format:

Name: **\{name1}** <br/>
Salary: **\{salary1}**
\====================<br/>
Name: **\{name2}**<br/>
. . .

**NOTE:** The **Salary** must be **formatted** to **2 digits** after the decimal point.

In case, the given last line is &quot; **Position**&quot;, you must print every employee, stored with its **position** in the following format:

Name: **\{name1}**<br/>
Position: **\{position1}**<br/>
\====================<br/>
Name: **\{name2}**<br/>
\. . .

**NOTE:** Every entry is **separated** with the **other** , with a **string** of **20 character****&#39;=**&#39;.

There is **NO** particular order of printing – the data must be printed in **order** of **input**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Isacc -&gt; 34<br/>Peter -&gt; CEO<br/>Isacc -&gt; 4500.054321<br/>George -&gt; Cleaner<br/>John -&gt; Security<br/>Nina -&gt; Secretary<br/>filter base<br/>Position | Name: Peter<br/>Position: CEO<br/>\====================<br/>Name: George<br/>Position: Cleaner<br/>==================== <br/>Name: John<br/>Position: Security<br/>==================== <br/> Name: NinaPosition: Secretary <br/>==================== |
| Ivan -&gt; Chistach<br/>Pesho -&gt; Ohrana<br/>Pesho -&gt; 1323.0456<br/>Ivan -&gt; 732.404<br/>Georgi -&gt; 21<br/>Georgi -&gt; 21.02<br/>filter base<br/>Salary | Name: Pesho<br/>Salary: 1323.05<br/> \====================<br/>Name: Ivan<br/>Salary: 732.40<br/>====================<br/> Name: Georgi<br/>Salary: 21.02<br/> ==================== |

> ### Hints:

> Use **int.TryParse()** and **double.TryParse()** to find out in **which case** are you and where to **store** the **data**.