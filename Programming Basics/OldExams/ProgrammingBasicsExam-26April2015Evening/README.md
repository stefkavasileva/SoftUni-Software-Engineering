# <p align="center"> Programming Basics Exam - 26 April 2015 Evening <p>

## **Problem 1 – Compound interest**

You really want a new TV, however you are a little short on money right now. You have a couple of options. You can **get a loan from a bank** or **get a loan from a friend**. Since you want to become the best programmer who ever lived, you decided to make a program to help you out.

Bank loans have **interest rate** and a **term (number of years** you have until you are required to pay the money back). Assume the bank loan will be for more than one year and the interest will be accrued on a yearly basis. Use this formula to calculate the amount of money you will have to pay back - &#39; **FV = PV \* (1 + i)n-th** &#39;. Where &#39; **FV&#39;**(future value)**is the money owed at the end of the period **. &#39;** PV&#39;** (present value)is the money you want to withdraw today **, &#39;** i&#39; **is the interest rate and &#39;n&#39; is the term of the loan.** Your friend is a really nice dude and he will loan you the money, however he wants a percentage of the money in return.

You will be given the price of the TV, the term and yearly interest rate for the loan from the bank, and the percentage your friend will ask for.

Your task is to write a program that calculates **the best (cheapest) option to buy the TV**. If the options are the same, choose your friend&#39;s offer - you are a nice guy after all. Check the example to get a better understanding of the task.

#### **Input**

The input data should be read from the console. It consists of four input values, each at a separate line:

- The number **p** – **price** of **the TV**.
- The number **n** – number of **years you have until you must pay the bank back (term)**.
- The number **i** – the yearly interest rate for the bank&#39;s loan.
- The number **f** – interest rate for your friend&#39;s loan.

The input data will always be valid and in the format described. There is no need to check it explicitly.

#### **Output**

- The output data must be printed on the console.
- On the only output line you must print **the best loan price to the second digit after the decimal mark and the lender separated by a single space.**

**Constraints**

- The number **y is** an integer in the range [0 ... 2 147 483 647].
- The numbers **p, i, f are** floating-point numbers in the range [0 … 7.9 x 10-28].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

#### **Examples**

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 2600 <br/> 2 <br/> 0.07 <br/> 0.4   | 2976.74 Bank | 2600 leva is needed. <br/> Bank loan = 2600 \* (1 + 0.07) **2** = 2600 \* 1.07 **2** = 2600 \* 1.1449 = 2976.74. <br/>  Friend loan = 2600 \* (1 + 0.4) = 2600 \* 1.4 = 3640. 2976.74 &lt; 3640 |

## **Problem 2 – Petar&#39;s Game**

Petar likes to play with numbers. He is very good with **strings** too. One day he decided to invent a new game of **summing numbers.** He will get one number and will try to divide it by 5 **, if the number can be divided without remainder** (for example 15 can be divided by 5 without remainder, but 17 divided by 5 is 3 with remainder 2) Petar will **add this number to the sum.** However **if the number cannot be divided without remainder, only the remainder will be added to the sum.** After he is done with the numbers **,** Petar likes to **replace some of the sum&#39;s digits with strings**. If the sum is **odd** he will replace **the last digit and all others that are the same as it** with a given string. If the sum is **even** he will do the same, but with the first digit. For example, if the sum is 2434, and the string is &quot;a&quot; - the result will be a434.

**You will be given a start number, an end number and a string.** You have to check all numbers between the start number and the end number (without the end number), do Petar&#39;s algorithm and finally replace the digits with the string as described above.

##### **Input**

The input data should be read from the console. It consists of three lines:

- The first line will hold the starting number;
- The second  line will hold the end number;
- The third like will hold the replacement string

The input data will always be valid and in the format described. There is no need to check it explicitly.

#### **Output**

- The output data must be printed on the console.
- On the only output line you must print the result of the game.

#### **Constraints**

- Start number and end number will be integers in the range [0 … 18 446 744 073 709 551 615].
- The string will contain letters and numbers.
- Allowed memory: 16 MB.

**Examples**

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 10 <br/> 14 <br/> a | a6 | 10 + 1 + 2 + 3 = 16. 16 is even 1 will be replaced.  <br/>  Result is a6 |

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 10 <br/> 99 <br/> as | asas2as  | 234 <br/> 3547 <br/> SadPanda | 12SadPanda969SadPanda |

## **Problem 3 - Sunlight**

Sandy is a little girl who spends her free time playing with her friends. Unfortunately, Sandy broke her wristwatch a week ago. Now she is trying a new trick using the sunlight to guess the time. But this trick is useful only when the sky isn&#39;t cloudy. Your task is to help Sandy by writing a program which shows how bright the sun is at the moment.

You are given an integer number **N** (always **odd** ), corresponding to the **width and height** of the sun and the **length** of the **horizontal and vertical** sunbeams. The **diagonal** sunbeams have length equal to **N – 1.**

### Input

The input data should be read from the console.

- On the only input line you will be given an integer **N** - the **size** of the sun.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Use the &quot; **\*** &quot; (asterisk) to mark the sun and the sunbeams and &quot; **.** &quot; (dot) for the rest. Follow the examples below.

### Constraints

- **N** will always be a positive **odd** number in the range [**3** … **33].**
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

#### Input: 3

```
....*....
.*..*..*.
..*.*.*..
...***...
*********
...***...
..*.*.*..
.*..*..*.
....*....
```

#### Input: 5

```
 .......*.......
 .*.....*.....*.
 ..*....*....*..
 ...*...*...*...
 ....*..*..*....
 .....*****.....
 .....*****.....
 ***************
 .....*****.....
 .....*****.....
 ....*..*..*....
 ...*...*...*...
 ..*....*....*..
 .*.....*.....*.
 .......*.......
```

## Problem 4 – Encrypt the Messages

You are working for a company which is very concerned about its information and communication. For this reason, they have invented an internal approach to communication between different departments – they are communicating to each other via **messages, which are reversed (written backwards) and then encrypted**. Your task is to write a program, which **encrypts** all messages **in a specific communication,** prints them at the console as well as the total number of messages that have been sent.

**At the beginning** of a communication, you will receive either the keyword &quot; **START**&quot; (upper case) or &quot; **start**&quot; (lower case), which indicates that you will **start receiving reversed and encrypted messages**. At the end of the communication, you will receive either the keyword &quot; **END**&quot; (upper case) or &quot; **end**&quot; (lower case), which indicates that the communication is over and you need to **show the encrypted messages&#39; content and total count**. Any **non-empty string** between the &quot;start&quot; and &quot;end&quot; keywords is considered a message. If **no messages have been sent** between the &quot; **start**&quot; and the &quot; **end**&quot; keywords, you should print on the console: **&quot;No messages sent.&quot;**

All messages are case-sensitive and consist of **letters** , **digits,** as well as **some special characters** – &#39;&#39;, &#39; **,** &#39;, &#39;.&#39;, &#39; **?** &#39; and &#39; **!** &#39;. Letters **from A to M** are **converted** to letters **from N to Z** (A => N; B => O; … M => Z) and letters **from N to Z** are **converted** to letters **from A to M** (N => A; O => B; … Z => M). The **converted** letter should keep the **case** of the **original** letter. The **special characters** are converted in the following way: &#39;&#39; (space) is converted to a **plus sign** ( **&#39; +&#39;** ), &#39; **,** &#39; is converted to **&#39;%&#39;** , &#39; **.** &#39; is converted to **&#39;&amp;&#39;** , &#39; **?** &#39; is converted to **&#39;#&#39;** and &#39; **!** &#39; is converted to **&#39;$&#39;**. **Digits** (0-9) are **not converted** and stay the same.

### Input

The input data should be read from the console. The input will contain a random number of lines. The line that holds the **keyword &quot;START&quot; or &quot;start&quot;** will always be before the line that holds the **keyword &quot;END&quot; or &quot;end&quot;**. The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

- On the **first line** print the total number of messages that have been sent in format: &quot; **Total number of messages: N**&quot; – where N is the number of encrypted and sent messages.
- On the next N lines print the encrypted messages.
- If **no messages have been sent** between the &quot; **start**&quot; and the &quot; **end**&quot; keywords, you should **print on the console** nly one line holding: &quot; **No messages sent.** &quot;

### Constraints

- The **number of messages** between the &quot; **start**&quot; and the &quot; **end**&quot; keywords will be between 0 and 100.
- The **length of each message** will be between 1 and 1000 symbols.
- Each unencrypted message will contain only Latin letters, digits and the special symbols described above.
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

## Examples

| **Input** | **Output** |
| --- | --- | 
| START <br/> Hello!!! <br/> END | Total number of messages: 1 <br/> $$$byyrU |

| **Input** | **Output** |
| --- | --- |
| START <br/> abcdefg <br/> meSSage1 <br/> end | Total number of messages: 2 <br/> tsrqpon <br/> 1rtnFFrz  |
| **Input** | **Output** |
| start <br/>  <br/>  END | No messages sent. |

| **Input** |
| --- |
| Normal communication message. <br/> START <br/>  <br/>  Please, try to encrypt the following message! <br/>  <br/>  <br/>   end |
| **Output** |
| Total number of messages: 1 <br/> $rtnffrz+tavjbyybs+rug+gclepar+bg+leg+%rfnryC |
