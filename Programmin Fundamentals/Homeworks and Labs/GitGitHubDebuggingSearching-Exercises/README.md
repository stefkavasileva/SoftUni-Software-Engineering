# <p align="center"> Git, GitHub, Debugging, Searching - Exersices <p>

## 01. **Instruction Set**

#### Problem Description**

Write an **instruction interpreter** that executes an arbitrary number of **instructions.** The program should **parse the
 instructions, execute** them and **print the result.** The following instruction set should be supported:

- **INC &lt;operand1&gt;** – increments the operand by 1

- **DEC &lt;operand1&gt;** – decrements the operand by 1

+ **ADD &lt;operand1&gt; &lt;operand2&gt;** – performs addition on the two operands

- **MLA &lt;operand1&gt; &lt;operand2&gt;**– performs multiplication on the two operands

- **END** – end of input

#### Output

The result of each instruction should be printed on a separate line on the console.

#### Constraints
- The operands will be valid integers in the range [−2 147 483 648 … 2 147 483 647].

#### Tests

|**Input**|**Program Output**|**Expected Output**|
|---|---|---|
|INC 0 <br/>  END|0 <br/> 0 <br/> … (infinite)|1|
|ADD 1323134 421315521 <br/> END|422638655 <br/> 422638655 <br/> … (infinite)|422638655|
|DEC 57314183 <br/> END|57314183 <br/> 57314183 <br/> … (infinite)|57314182|
|MLA 252621 324532 <br/>  END|379219748 <br/> 379219748 <br/> … (infinite)|81983598372|

## 02. **Be Positive**

#### Problem Description

A program is designed to take some **sequences of numbers** from the console, to **process them** as described below

and **print** each obtained sequence.

#### Input

- On the first line of input you are given a count **N – the number of sequences.**

- On each of **the next N lines** you will receive some **numbers surrounded by whitespaces**.

#### Processing Logic

You need to check each number, if it’s **positive** – print it on the console; if it’s **negative**, add to its value the value of

the next number and only print the result if it’s not negative. You only perform the addition once, e.g. if you have

the sequence: -3, 1, 3, the algorithm is as follows:

- -3 is negative =&gt; add to it the next number (1) =&gt; -3 + 1 = -2 still negative =&gt; do not print anything (and don’t

keep adding numbers, you stop here).

- The next number we consider is 3 which is positive =&gt; print it.

If no numbers can be obtained in this manner for the given sequence, print **“(empty)”.**

#### Tests

|**Input**|**Expected Output**|**Comments**|
|---|---|---|
|3 <br> 3 -4 5 2 123 <br> -1 -1 3 4 <br> -2 1|3 1 2 123 <br/> 3 4 <br/> (empty)|(3) (-4 + 5 = 1 &gt; 0) (2) (123) <br/> (-1 + (-1) &lt; 0) (3) (4) <br/> (-2 + 1 &lt; 0)|

## 03. Sequence of Commands

#### Problem Description

You are given a program that reads a **n numbers** and a **sequence of commands** to be executed over these numbers.

#### Input

- The first line holds an integer n – the count of numbers.

- The second line holds n numbers – integers separated by space.

- Each of the next few lines hold commands in format: “[action] [i-th element] [value]”.

- The commands sequence end with a command “stop”.

#### Commands

Commands are given in format **“[action] [i-th element] [value]”.** Elements are indexed from 1 to n.

The **action** can be **“multiply”, “add”, “subtract”, “rshift” or “lshift”.**

- The actions **“multiply”, “add”** and **“subtract”** have parameters. The first parameter is the **index** of the

element that needs to be changed (in range **[1...n]**). The second parameter is the value with which we

manipulate the element.

- The command **“lshift”** moves the first element last. E.g. **“lshift”** over {1, 2, 3} will produce {2, 3, 1}.

- The command **“rshift”** moves the last element first. E.g. **“rshift”** over {1, 2, 3} will produce {3, 1, 2}.

#### Output

Print the values of the **n elements** after the execution of each command (except the last **“stop”** command).
#### Constraints

- The **number n** will be an integer in the range [1 … 15].

- Each **element of the array** will be an integer in the range [0 … 2 63 -1].

- The **number i** and the **number of commands** will be integers in the range [1 … 10].

- The **number value** will be an integer in the range [-100 … 100]. If the command is **“rshift”** or **“lshift”** there

are no parameters.

#### Tests

|**Input**|**Program Output**|**Expected Output**|
|---|---|---|
|5 <br/> 3 0 9 333 11 <br/> add 2 2 <br/> subtract 1 1 <br/> multiply 3 3 <br/> rshift <br/> stop|3 0 9 333 11 <br/> 3 0 9 333 11|3 2 9 333 11 <br/> 2 2 9 333 11 <br/> 2 2 27 333 11 <br/> 11 2 2 27 333|

## 04. Substring 
#### Problem Description

You are given a **text** and a number **count**. Your program should search through the text for the letter **&#39;p&#39;** (ASCII code

**112**) and print **&#39;p&#39;** along with **count** letters to its right.

For example, we are given the text **&quot;phahah put&quot;** and **count = 3**. We find a match of **&#39;p&#39;** in the first letter so we print

it and the 3 letters to its right. The result is &quot;phah&quot;. We continue and find another match of &#39;p&#39;, but there aren&#39;t 3

letters to its right, so we print only **&quot;put&quot;**.

Each match should be printed on a separate line. If there are no matches of **&#39;p&#39;** in the text, we print **&quot;no&quot;**.

#### Input

- The first line holds the **text** to be processed (string).

- The second line holds the **number count**.

#### Output

For each match, print the **matched substring** at separate line. Print **&quot;no&quot;** if there are no matches.

#### Constraints

- The number **count** will be in the range [0 ... 100].

#### Tests

|**Input**|**Program Output**|**Expected Output**|
|---|---|---|
|phahah put <br/> 3| no |phah <br/> put|
|No match <br/> 5| no |phah <br/> no|
|preparation <br/> 5| no |phah <br/> prepa|
|preparation <br/> 0| no |phah <br/> p <br/> p|
