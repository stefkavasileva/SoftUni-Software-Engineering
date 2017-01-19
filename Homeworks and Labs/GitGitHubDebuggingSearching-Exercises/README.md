#<p align="center"> Git, GitHub, Debugging, Searching - Exersices <p>

## 01. **Instruction Set**

###**Problem Description**

Write an **instruction interpreter** that executes an arbitrary number of **instructions.** The program should **parse the
 instructions, execute** them and **print the result.** The following instruction set should be supported:

⋅⋅* **INC &lt;operand1&gt;** – increments the operand by 1

⋅⋅* **DEC &lt;operand1&gt;** – decrements the operand by 1

⋅⋅* **ADD &lt;operand1&gt; &lt;operand2&gt;** – performs addition on the two operands

⋅⋅* **MLA &lt;operand1&gt; &lt;operand2&gt; **– performs multiplication on the two operands

⋅⋅* **END** – end of input

##Output

The result of each instruction should be printed on a separate line on the console.

##Constraints

 The operands will be valid **integers** in the range **[−2 147 483 648 … 2 147 483 647]**.
---

## 02. **Be Positive**

###Problem Description

A program is designed to take some **sequences of numbers** from the console, to **process them** as described below

and **print** each obtained sequence.

###Input

..* On the first line of input you are given a count **N – the number of sequences.**

..*On each of **the next N lines** you will receive some **numbers surrounded by whitespaces**.

###Processing Logic

You need to check each number, if it’s **positive** – print it on the console; if it’s **negative**, add to its value the value of

the next number and only print the result if it’s not negative. You only perform the addition once, e.g. if you have

the sequence: -3, 1, 3, the algorithm is as follows:

..* -3 is negative =&gt; add to it the next number (1) =&gt; -3 + 1 = -2 still negative =&gt; do not print anything (and don’t

keep adding numbers, you stop here).

..* The next number we consider is 3 which is positive =&gt; print it.

If no numbers can be obtained in this manner for the given sequence, print **“(empty)”.**