# <p align="center"> Programming Basics Exam - 26 April 2015 Morning <p>

# Problem 1 – Book Problem

Stefan is a keen reader. He wants to read a programming book and wants to know exactly when he will finish it.

**Every day** in a given month **he reads up some pages**. Some days he goes campingand on these dayshe **doesn&#39;t read**.

You will be given **the book&#39;s page count, the number of camping days in a month** and **number of pages which Stefan reads in a normal day,** each on a separate line. Assume **each month has 30 days** and **each year has 12 months**. Calculate how many years and months Stefan will need in order to read the book and print the result on the console in format **&quot;X years Y months&quot;. If Stefan never reads the book, print &quot;never&quot;.**

**Note** that if, for example, Stefan needs 3.1 months, you need to **round that up** – so you have to print &quot;0 years 4 months&quot;.

### Input

The input will be read from the console. It consists of exactly **three lines** :

- On the **first line** you will be given an integer – **the number of pages of the book**.
- On the **second line** you will be given the **number of camping days in a month**.
- On the **third line** you will be given the **number of pages which Stefan reads every normal day**.

The input will always be valid and in the format described, there is no need to check it explicitly.

### Output

The output should be printed on the console.

- On the only output line **print the number of years and months** Stefan will need to read the book in **format &quot;X years Y months&quot;**.
- If Stefan cannot read the book, you should print **&quot;never&quot;**.

### Constraints

- The number of **pages** f the book will be an integer in the range [1 … 2 000 000 000].
- The number of **camping days** will be an integer in the range [0 … 30].
- The **number of pages Stefan reads** in a normal day will be an integer in the range [0 … 100].
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 250000 <br/> 5 <br/> 10 | 83 years 4 months | There are 30 days in a month =&gt; 5 camping days and 25 normal days. <br/>  On a normal day he reads 10 =&gt; 25\*10 = 250 pages.  <br/> On a camping day he doesn&#39;t read.250000/250 = 1000 – he needs exactly 1000 months. <br/>  This is 83 years and 4 months. |

| **Input** | **Output** |
| --- | --- |
| 25 <br/> 30 <br/> 100 | never |
| **Input** | **Output** |
| 24 <br/> 0 <br/> 1 | 0 years 1 months |

## Problem 2 – Chessboard Game

Goshko is a keen chess player. One day he was bored with his work and decided to take a break and create a game using the chessboard. He takes a string, e.g. &quot;Software University\_2345&quot;, converts its symbols to numbers through **their ASCII codes** and fills a chessboard with them. He takes the values of **capital and small letters and digits** only. The value of **any other symbol** is **zero**. He fills the board&#39;s squares with the numbers, from left to right and from top to bottom (see the example below). **The size of the chessboard is n\*n (e.g. n = 5) and it always starts with a black square**. **N** will always be an **odd number**.

| S | o | f | t | w |   | 83 | 111 | 102 | 116 | 119 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| a | r | e |   | U |   | 97 | 114 | 101 | 0 | 85 |
| n | i | v | e | r |   | 110 | 105 | 118 | 101 | 114 |
| s | i | t | y | \_ |   | 115 | 105 | 116 | 121 | 0 |
| 2 | 3 | 4 | 5 |   |   | 50 | 51 | 52 | 53 | 0 |

**White Team** Score = 83 &#39;S&#39; + 111 &#39;o&#39; + 116 &#39;t&#39; + 97 &#39;a&#39; + 101 &#39;e&#39; + 105 &#39;i&#39; + 101 &#39;e&#39;+ 115 &#39;s&#39; + 116 &#39;t&#39; + 51 &#39;3&#39; + 53 &#39;5&#39; = 1049
 <br/> **Black Team** Score = 102 &#39;f&#39; + 119 &#39;w&#39; + 114 &#39;r&#39; + 85 &#39;U&#39; + 110 &#39;n&#39; + 118 &#39;v&#39; + 114 &#39;r&#39;+ 105 &#39;i&#39; + 121 &#39;y&#39; + 50 &#39;2&#39; + 52 &#39;4&#39; = 1090.

### Input

The input data should be read from the console.

- The **first line** holds the **size n** of the chessboard.
- The **second line** holds the input string.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console.

- The first output line holds the **winning team** in format: &quot;The winner is: **{name}** team&quot;.
- The second line holds the difference between the scores of the winning and the losing team.
- In case the score is **equal** , print &quot;Equal result: **\{points}** &quot;. Do not print the difference in this case!

### Constraints

- The number **n** will be an **odd** **integer** in the range [1 … 9].
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| 5 <br/> Software University\_2345 | The winner is: black team <br/> 41 |
| **Input** | **Output** |
| 3 <br/> aa | Equal result: 97 |

## Problem 3 – King of Thieves

Once upon a time there was a kingdom and everyone in the kingdom was a thief. Izzy wanted to become the King of Thieves and so started stealing only **perfect gems** from other thieves. Help Izzy by showing him what a perfect gem with given parameters should look like.

### Input

The input data should be read from the console.

- The first line will hold the **size** of the gem – **n**.
- The second line will hold the **type** of the gem – a symbol: e.g. &#39; **\*** &#39;.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. It should consist of &#39; **n**&#39; lines, holding the gem.

### Constraints

- The number **n** **will be a positive odd integer between 3 and 59**, inclusive.
- The type of the gem will be a symbol from the standard ASCII table.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

### Examples

#### Input: <br/>  5 <br/> \*

```
--*--
-***-
*****
-***-
--*--
```

#### Input: <br/> 7 <br/> \@

```
---@---
--@@@--
-@@@@@-
@@@@@@@
-@@@@@-
--@@@--
---@---
```

#### Input: <br/> 13 <br/> \a

```
------a------
-----aaa-----
----aaaaa----
---aaaaaaa---
--aaaaaaaaa--
-aaaaaaaaaaa-
aaaaaaaaaaaaa
-aaaaaaaaaaa-
--aaaaaaaaa--
---aaaaaaa---
----aaaaa----
-----aaa-----
------a------
```

## Problem 4 – Decrypt the Messages

You are working for a company which is very concerned about its information and communication. For this reason, they have invented an internal approach to communication between different departments – they are communicating to each other via **messages, which are reversed (written backwards) and then encrypted**. In order to be read and understood, each message has to be decrypted. Your task is to write a program, which **receives all encrypted messages** in a specific communication, **decrypts them** and **prints all decrypted messages at the console as well as the total number of messages** that have been received.

**At the beginning** of a communication, you will receive either the keyword &quot; **START**&quot; (upper case) or &quot; **start**&quot; (lower case), which indicates that you will **start receiving reversed and encrypted messages**. At the end of the communication, you will receive either the keyword &quot; **END**&quot; (upper case) or &quot; **end**&quot; (lower case), which indicates that the communication is over and you need to **show the decrypted messages&#39; content and total count**. Any **non-empty string** between the &quot;start&quot; and &quot;end&quot; keywords is considered a message. If **no messages have been received** between the &quot; **start**&quot; and the &quot; **end**&quot; keywords, you should print on the console: **&quot;No message received.&quot;**

All messages are case-sensitive and consist of **letters** , **digits,** as well as **some special characters** – &#39; **+** &#39;, &#39; **%** &#39;, &#39; **&amp;** &#39;, &#39; **#** &#39; and &#39; **\$** &#39; . Letters **from A to M** are **converted** to letters **from N to Z** (A => N; B => O; … M => Z) and letters **from N to Z** are **converted** to letters **from A to M** (N => A; O => B; … Z => M). The **converted** letter should keep the **case** of the **original** letter. The **special characters** are converted in the following way: &#39; **+** &#39; is converted to a **single space** ( **&#39;  &#39;** ), &#39; **%** &#39; is converted to a **comma** ( **&#39;,&#39;** ), &#39; **&amp;** &#39; is converted to a **dot** ( **&#39;.&#39;** ), &#39; **#** &#39; is converted to a **question mark** ( **&#39;?&#39;** ) and &#39; **$**&#39; is converted to an **exclamation mark** ( **&#39;!&#39;** ). The **digits** (0-9) are **not converted** and stay the same.

For example, you receive the following message – &quot; **\$1+rtnffrz+greprF** &quot; and you start decrypting it. Convert the 1st character &#39; **$** &#39; to &#39; **!** &#39;, then the 2nd character – &#39; **1**&#39; stays the same, then covert the 3rd character – &#39; **+** &#39; to single space &#39; &#39;, &#39; **r** &#39; => &#39; **e** &#39;, &#39; **t** &#39; => &#39; **g** &#39;, &#39; **n** &#39; => &#39; **a** &#39;, &#39; **f** &#39; => &#39; **s** &#39;, &#39; **f** &#39; => &#39; **s** &#39;, &#39; **r** &#39; => &#39; **e** &#39; , &#39; **z** &#39; => &#39; **m** &#39;, &#39; **+** &#39; => &#39; &#39;, &#39; **g** &#39; => &#39; **t** &#39;, &#39; **r** &#39; => &#39; **e** &#39; , &#39; **e** &#39; => &#39; **r** &#39; , &#39; **p** &#39; => &#39; **c** &#39; , &#39; **r** &#39; => &#39; **e** &#39; , &#39; **F** &#39;  &#39; **S** &#39;. After decrypting all letters, the message is: &quot; **!1 egassem terceS&quot;** and when you reverse it, you get the original message: &quot; **Secret message 1!** &quot;

### Input

The input data should be read from the console. The input will contain a random number of lines. The line that holds the **keyword &quot;START&quot; or &quot;start&quot;** will always be before the line that holds the **keyword &quot;END&quot; or &quot;end&quot;**. The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

- On the **first line** print the total number of messages that have been received in format: &quot; **Total number of messages: N**&quot; – where N is the number of received and decrypted messages.
- On the next N lines print the decrypted messages.
- If **no messages have been received** between the &quot; **start**&quot; and the &quot; **end**&quot; keywords, you should **print on the console** nly one line holding: &quot; **No message received.** &quot;

### Constraints

- The **number of messages** between the &quot; **start**&quot; and the &quot; **end**&quot; keywords will be between 0 and 100.
- The **length of each message** will be between 1 and 1000 symbols.
- Each encrypted message will contain only Latin letters, digits and the special symbols described above.
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

## Examples

| **Input** | **Comments** | **Output** |
| --- | --- | --- |
| START <br/> $$$byyrU <br/> END | We start conversion from the 1st character: <br/> $ => !, $ => !, $ => !, b => o, y => l, y => l, r => e, U => H and reverse the newly received string <br/>  &quot;!!!olleH&quot; to the original message &quot;Hello!!!&quot; | Total number of messages: 1 <br/> Hello!!! |
| **Input** | **Comments** | **Output** |
| start <br/> tsrqpon<br/> 1rtnFFrz<br/> end | We start conversion from the 1 st character: <br/>  t => g, s => f, r => e, q => d, p => c, o => b, n => a and reverse the newly received string  <br/> &quot;gfedcba&quot; to the original message &quot;abcdefg&quot;.<br/> Then we do the same for the second message. | Total number of messages: 2<br/> abcdefg<br/> meSSage1 |
| **Input** | **Comments** | **Output** |
| start <br/> <br/>   END | There is no message received. | No message received. |

| **Input** |
| --- |
| Normal communication message.<br/> START<br/> <br/>  $rtnffrz+tavjbyybs+rug+gclepar+bg+leg+%rfnryC <br/> <br/>  end |
| **Output** |
| Total number of messages: 1<br/> Please, try to encrypt the following message! |


