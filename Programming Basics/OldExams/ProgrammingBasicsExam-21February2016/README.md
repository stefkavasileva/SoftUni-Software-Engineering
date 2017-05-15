# <p align="center">Programming Basics Exam - 21 February 2016 <p>

## Problem 1.Problem 1 – Hungry Garfield

You know that Garfield is a very lazy cartoon cat that is always hungry and, just like you and me, likes Italian food very much. His favorite dishes are pizza, lasagna and sandwiches. John is a talented cartoonist and sometimes he goes on a business trip here and there and Garfield has to stay home alone and take care of himself. Every time John is away for a long time he gives Garfield some money to make sure he is well fed. Garfield is a very smart cat, he can talk, he can buy pizza himself, but he doesn&#39;t care about calculations, because cats don&#39;t care about anything else but food and a good nap. He asks you to make a simple program that calculates whether the money John gave him would be enough to eat all the pizzas, lasagnas and sandwiches he wants.

You are given the **sum** of money **(in dollars)** that John gives the **prices** of pizza, lasagna and sandwiches in leva **. Then you will be given the quantity of pizza, lasagna and sandwiches he would like to eat in order to be well fed**. You have to convert all the money to dollars. If the money he wants to spend is equal or less than the money John gave him, he will be satisfied, otherwise he will be hungry and angry at John.

##### Input

The input data should be read from the console.

- On the first line you will receive **money** -the money John gave to Garfield in dollars.
- On the second line you will receive the dollar exchange **rate.**
- On the third line will receive **pizzaPrice** -the price of pizza in leva.
- On the fourth line you will receive **lasagnaPrice** - the price of lasagna in leva.
- On the fifth line you will receive **sandwichPrice** - the price of sandwiches in leva.
- On the sixth line you will receive the **pizzaQuantity** – the quantity of pizza Garfield wants to eat.
- On the seventh line you will receive the **lasagnaQuantity** – the quantity of lasagna Garfield wants to eat.
- On the eighth line you will receive the **sandwi** **chQuantity** – the quantity of sandwiches Garfield wants to eat.

The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

The output data should be printed on the console.

If the money John gave Garfield is more or equal to buy all the food he wants, print:

**Garfield is well fed, John is awesome. Money left: ${the money that has left}.**

If the money John gave Garfield is not enough, print:

**Garfield is hungry. John is a badass. Money needed: ${the money that is needed}.**

Moneyshould be always positive and formatted with two digits after the decimal point.

#### Constraints

- The money John gave and the dollar rate will be a floating point number in the range [1 - 2-32].
- The prices of pizza, lasagna and sandwiches will be floating point numbers in the range [0 - 2-32].
- The quantity of pizza, lasagna and sandwiches will be integers in the range [0 - 2-32].
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

#### Examples

| **Input** | **Comments** | **Output** |
| --- | --- | --- |
| 50 <br/> 1.55 <br/> 5 <br/> 4 <br/> 3 <br/> 5 <br/> 5 <br/> 1 | The money Garfiel needs is 5/1.55 \* 5 + 4/1.55 \* 5 + 3/1.55 \*1 =  30.97.30.97 is less than 50, so the money John gave him is enough. | Garfield is well fed, John is awesome. Money left: $19.03. |

| **Input** | **Output** |
| --- | --- |
| 100 <br/> 1.55 <br/> 10 <br/> 15 <br/> 3 <br/> 5 <br/> 8 <br/> 2 | Garfield is hungry. John is a badass. Money needed: $13.55. |

## **Problem 2 – Encoded Answers**

Prof. Petrov is teaching Public Finance in the Faculty of Economics and Business Administration. At the end of the term he grades his students based on a **test** which he strictly prepares. However, last year some of the students sneaked into his room and stole the **answer key** to the test. This year he had decided to be more careful about keeping the answer key **secret,** so he asks you to help him **encode the answers** , so that even if students find it again, they will not be able to read it.

Your task is to write a **program** , which gets as **input** the **number of the questions** in the test and then on a **separate line for each question** is given **a number**. Since each question has **4 possible answers** , there are **4 types of numbers** which will be given. If the given number is **divisible by 4** (that means the reminder of the **division equals 0** ), the answer to that question is **&#39;a&#39;**. If the **reminder** of the division of the number by **4 equals 1** , the answer is **&#39;b&#39;** ; if it **equals 2** , the answer is **&#39;c&#39;** ; and if it **equals** **3**, the answer is **&#39;d&#39;** . At the end, the program should **print on the console** **all the answers in letter format in a single line.** After that, in the **next 4 lines** , it should print the **number of answers of each type – a, b, c, and d.**

#### **Input**

- On the first line you will receive the number **N** – the number of questions in the test.
- On the next **N** lines you will receive valid integer numbers in range 0 to 4,294,967,295

#### **Output**

- On the first line, display all the answers in format a, b, c or d.
- On the next 4 lines – on each line print the type of answer (a, b, c or d) and how many answers of this type are there in the test.
**Example: &quot;Answer A: 15&quot;**

#### **Constraints**

- **N** is an integer in range [1 … 30]
- The **numbers for answers** will be in range [0…4,294,967,295]
- Allowed memory: 16 MB
- Allowed time: 0.1s

#### Examples

| **Input** | **Output** | **Comments** | **Input** | **Output** |
| --- | --- | --- | --- | 
| 10 <br/> 2 <br/> 3 <br/> 4 <br/> 5 <br/> 6 <br/> 7 <br/> 8 <br/> 9 <br/> 10 <br/> 11 | c d a b c d a b c d <br/> Answer A: 2 <br/> Answer B: 2 <br/> Answer C: 3 <br/> Answer D: 3 | 5 <br/> 56 <br/> 654 <br/> 236 <br/> 56997 <br/> 4555 | a c a b d <br/> Answer A: 2 <br/> Answer B: 1 <br/> Answer C: 1 <br/> Answer D: 1 |

## Problem 3 – Fallen In Love

Ivancho is a student in high school. One of his classmates is his best friend Mariyka. They have known each other since they were born and it was when they were in first grade that Ivancho realized he was in love with Mariyka. Now that he is already a grown up man, he decides he can hide his feelings no more. Mariyka&#39;s birthday is coming and Ivancho wants to impress her. He knows that recently Mariyka has started a Programming Basics course in SoftUni, so he decides to surprise her with a &quot;virtual present&quot;. He asked you as Mariyka&#39;s classmate in SoftUni to write him a program, which prints a flower on the console.

#### Input

The input data should be read from the console.

- On the only input line you will be given the **number** **N**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

- The output should be printed on the console. Use the **&quot;#&quot; (number sign)** for the flower and **&quot;~&quot; sign for the leaves** , and **&quot;.&quot; dot for background**. Follow the examples below.

#### Constraints

- **N** will always be a positive number in the range [**1 … 18].**
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

#### Examples

##### Input: 5

```
##..........##..........##
#~#........#..#........#~#
#~~#......#....#......#~~#
#~~~#....#......#....#~~~#
#~~~~#..#........#..#~~~~#
.#~~~~~#..........#~~~~~#.
...#~~~~#........#~~~~#...
.....#~~~#......#~~~#.....
.......#~~#....#~~#.......
.........#~#..#~#.........
...........####...........
............##............
............##............
............##............
............##............
............##............

```

##### Input: 3

```
##......##......##
#~#....#..#....#~#
#~~#..#....#..#~~#
.#~~~#......#~~~#.
...#~~#....#~~#...
.....#~#..#~#.....
.......####.......
........##........
........##........
........##........

```
## Problem 4 – Passion Days

Lina is passionate about shopping. When she has some cash she runs to the mall and spends as much as she can on clothes, bags and shoes. Most of all she loves winter sales. You are challenged to analyze her strange behavior and calculate the purchases Lina makes when she enters the mall as well as the money she has when the shopping is over.

**On the first line you will receive the money Lina has before entering the mall**. Then, when you receive the **command &quot;mall.Enter&quot;** Lina enters the mall and starts shopping **until you**  **receive the** **command &quot;mall.Exit&quot;**. When Lina starts shopping, on each line you will start receiving strings representing the actions she performs. Every character in the **string represents a purchase or any other action.**

The string can contain any character from the ASCII table, assume that the ASCII code of the character is related to the price she pays for each item. If the character is an **uppercase letter** , Lina gets a 50% discount, that means that you have to **subtract 50% of character&#39;s ASCII code from the money she has** , if it is **a lowercase, she gets 70% discount, so subtract 30% of the ASCII value of the letter** , if it is &#39; **%** &#39; Lina **makes a purchase that halves the money she has** , if it is &#39; **\*** &#39; **she only withdraws money** from her debit card and thus **adds 10 leva to the money she has** for shopping and **doesn&#39;t make a purchase** , if it is any other ASCII character, she doesn&#39;t get a discount, so simply subtract character&#39;s ASCII code from the money.

If the price is higher than the money she currently has she doesn&#39;t make a purchase. Money cannot be less than 0.

Shopping is over when you receive the command &quot;mall.Exit&quot;. When the shopping is over you should print on the console the number of purchases she has made and the money she has. See the examples for more clarity.

#### Input

The input data should be read from the console. On the first line you will receive the money Lina has before the shopping starts. **She will always receive only one command &quot;mall.Enter&quot; and only one command &quot;mall.Exit&quot;**. When you receive the command &quot;mall.Enter&quot; on every line you will start receiving strings containing information about the purchases/actions Lina plans to make, until you receive the command &quot;mall.Exit&quot;.

#### Output

The output data should be printed on the console.

When the shopping ends you should print on the console the outputs depending on the number of purchases. If she didn&#39;t make any purchases print:

**&quot;No purchases. Money left: {money} lv.&quot;**

If she has made at least one purchase, print:

&quot; **\{number of purchases} purchases. Money left: {money} lv.** &quot;

Money should be formatted to the second digit after the decimal point.

#### Constraints

- Money is a floating-point number in the range [0 - 7.9 x 10- 28].
- The number of strings between the enter and exit command will be in the range [1 - 20];
- The number of characters in the string representing the actions are in the range [1 - 20];
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

#### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 110 <br/> mall.Enter <br/> d <br/> mall.Exit  | 1 purchases. Money left: 80.00 lv.  |  &#39;d&#39;has ASCII code 100. It is lowercase, so Lina gets 70% discount of the price,   100 – 70% = 30.  <br/> 110 – 30 = 80 lv. |

| **Input** | **Output** |
|---|---|
| 110 <br/> mall.Enter <br/> % <br/> mall.Exit | 1 purchases. Money left: 55.00 lv.  |
| **Input** | **Output** |
| 100 <br/> mall.Enter <br/> Ab <br/> \*\* <br/> mall.Exit | 2 purchases. Money left: 58.10 lv. |

