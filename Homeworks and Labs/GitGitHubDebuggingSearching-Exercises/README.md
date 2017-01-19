#<p align="center"> Git, GitHub, Debugging, Searching - Exersices <p>

## 01. **Instruction Set**

####**Problem Description**

Write an **instruction interpreter** that executes an arbitrary number of **instructions.** The program should **parse the
 instructions, execute** them and **print the result.** The following instruction set should be supported:

- **INC &lt;operand1&gt;** – increments the operand by 1

- **DEC &lt;operand1&gt;** – decrements the operand by 1

+ **ADD &lt;operand1&gt; &lt;operand2&gt;** – performs addition on the two operands

- **MLA &lt;operand1&gt; &lt;operand2&gt;**– performs multiplication on the two operands

- **END** – end of input

####Output

The result of each instruction should be printed on a separate line on the console.

####Constraints

## 02. **Be Positive**

####Problem Description

A program is designed to take some **sequences of numbers** from the console, to **process them** as described below

and **print** each obtained sequence.

####Input

- On the first line of input you are given a count **N – the number of sequences.**

- On each of **the next N lines** you will receive some **numbers surrounded by whitespaces**.

####Processing Logic

You need to check each number, if it’s **positive** – print it on the console; if it’s **negative**, add to its value the value of

the next number and only print the result if it’s not negative. You only perform the addition once, e.g. if you have

the sequence: -3, 1, 3, the algorithm is as follows:

- -3 is negative =&gt; add to it the next number (1) =&gt; -3 + 1 = -2 still negative =&gt; do not print anything (and don’t

keep adding numbers, you stop here).

- The next number we consider is 3 which is positive =&gt; print it.

If no numbers can be obtained in this manner for the given sequence, print **“(empty)”.**

## 03. Sequence of Commands

####Problem Description

You are given a program that reads a **n numbers** and a **sequence of commands** to be executed over these numbers.

####Input

- The first line holds an integer n – the count of numbers.

- The second line holds n numbers – integers separated by space.

- Each of the next few lines hold commands in format: “[action] [i-th element] [value]”.

- The commands sequence end with a command “stop”.

####Commands

Commands are given in format **“[action] [i-th element] [value]”.** Elements are indexed from 1 to n.

The **action** can be **“multiply”, “add”, “subtract”, “rshift” or “lshift”.**

- The actions **“multiply”, “add”** and **“subtract”** have parameters. The first parameter is the **index** of the

element that needs to be changed (in range **[1...n]**). The second parameter is the value with which we

manipulate the element.

- The command **“lshift”** moves the first element last. E.g. **“lshift”** over {1, 2, 3} will produce {2, 3, 1}.

- The command **“rshift”** moves the last element first. E.g. **“rshift”** over {1, 2, 3} will produce {3, 1, 2}.

####Output

Print the values of the **n elements** after the execution of each command (except the last **“stop”** command).
####Constraints

- The **number n** will be an integer in the range [1 … 15].

- Each **element of the array** will be an integer in the range [0 … 2 63 -1].

- The **number i** and the **number of commands** will be integers in the range [1 … 10].

- The **number value** will be an integer in the range [-100 … 100]. If the command is **“rshift”** or **“lshift”** there

are no parameters.