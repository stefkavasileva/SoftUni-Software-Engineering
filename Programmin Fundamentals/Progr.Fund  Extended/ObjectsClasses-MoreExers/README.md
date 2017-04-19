# <p align="center"> More Exercises: Objects and Simple Classes <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions here: [https://judge.softuni.bg/Contests/439](https://judge.softuni.bg/Contests/439).

## 1.Exercises

Exercises are fun … Especially when they represent a problem from your exercises.

Implement a **class Exercise** , which has a **Topic** ( **string** ), a **CourseName** ( **string** ), a **JudgeContestLink** ( **string** ), and a **Problems** ( **collection** of **strings** ).

You will receive several input lines containing information about a single exercise in the following format:

\{topic} -&gt; \{courseName} -&gt; \{judgeContestLink} -&gt; \{problem1}, \{problem2}. . .

You need to store every exercise in a **Collection** of **Exercises**. When you receive the command &quot; **go go go**&quot;, you end the input sequence.

You must print every exercise, in the following format:

&quot;Exercises: \{topic}

 Problems for exercises and homework for the &quot;\{courseName}&quot; course @ SoftUni.

 Check your solutions here: \{judgeContestLink}.

 1. \{problem1}

 2. \{problem2}

 . . .&quot;

#### Examples

| **Input** | **Output** |
| --- | --- |
| ObjectsAndSimpleClasses -> ProgrammingFundamentalsExtended -> https://judge.softuni.bg/Contests/439 -> Exercises, OptimizedBankingSystem, Animals, Websites, Boxes, BoxIntersection, Messages <br/> go go go | Exercises: ObjectsAndSimpleClasses <br/> Problems for exercises and homework for the "ProgrammingFundamentalsExtended" course @ SoftUni. <br/> Check your solutions here: https://judge.softuni.bg/Contests/439 <br/> 1. Exercises <br/> 2. OptimizedBankingSystem <br/> 3. Animals <br/> 4. Websites <br/> 5. Boxes <br/> 6. BoxIntersection <br/> 7. Messages|

## 2.Optimized Banking System

Remember the Ordered Banking System problem? Well, now you have to optimize it with classes.

Create a **class**** BankAccount **which has a** Name**(**string**),**Bank**(**string**) and**Balance**(**decimal**).

You will receive several input lines, containing information in the following way:

**\{bank} \| \{accountName} \| \{accountBalance}**

You need to store every given Account. When you receive the command &quot; **end**&quot; you must **stop** the input sequence.

Then you must print all **Accounts** , **ordered** by their **balance** , in **descending order** , and then by **length** of the **bank name** , in **ascending order**.

The accounts must be printed in the following way &quot;**\{accountName} -&gt; \{balance} (\{bank})** &quot;.

**Note** : **Numbers** must be printed, **exactly** as they are **entered**. No **formatting** is **required**.

#### Examples

| **Input** | **Output** |
| --- | --- |
| DSK \| Ivan \| 504.403DSK \| Pesho \| 2000.4031 <br/> DSK \| Aleksander \| 20000.0001 <br/> Piraeus \| Ivan \| 504.403 <br/> Piraeus \| Aleksander \| 20000.0001 <br/> end | Aleksander -&gt; 20000.0001 (DSK) <br/> Aleksander -&gt; 20000.0001 (Piraeus) <br/> Pesho -&gt; 2000.4031 (DSK) <br/> Ivan -&gt; 504.403 (DSK) <br/> Ivan -&gt; 504.403 (Piraeus)  |

## 3.Animals \*

You have been given the task to create classes for several sophisticated animals.

Create a **class Dog** which has a **Name** ( **string** ), **Age** ( **int** ) and **NumberOfLegs** ( **int** ).

Create a **class Cat** which has a **Name** ( **string** ), **Age** ( **int** ) and **IntelligenceQuotient** ( **int** ).

Create a **class Snake** which has a **Name** ( **string** ), **Age** ( **int** ) and **CrueltyCoefficient** ( **int** ).

Create a **method** in **each class** which is called **public** **void ProduceSound()**. The method should print on the console a string depending on the class:

- If it&#39;s a **Dog** , you should print &quot; **I&#39;m a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.** &quot;
- It it&#39;s a **Cat** , you should print &quot; **I&#39;m an Aristocat, and I will now produce an aristocratic sound! Myau Myau.** &quot;
- If it&#39;s a **Snake** , you should print &quot; **I&#39;m a Sophistisnake, and I will now produce a sophisticated sound! Honey, I&#39;m home.** &quot;

Now for the real deal. You will receive several input commands, which will register animals or make them produce sounds, until you receive the command &quot; **I&#39;m your Huckleberry**&quot;.

The commands will be in the following format:

**\{class} \{name} \{age} \{parameter}**

The **class** will be either &quot; **Dog**&quot;, &quot; **Cat**&quot; or &quot; **Snake**&quot;. The **name** will be a simple **string** , which can contain **any** ASCII character BUT **space**. The **age** will be an **integer**. The **parameter** , will be an **integer**. **Depending** on the **class** it would either be **number of legs** , **IQ** , or **cruelty coefficient**.

Register each animal, and keep them in **collections** , by your **choice** , so that you can **ACCESS THEM BY NAME**. You will most likely need 3 collections, to store the different animals inside them.

Between the register commands you might receive a command in the following format:

**talk \{name}**

You must then make the **animal** with the **given name** , **produce a sound**.

When you receive the ending command, you should print every animal in the following format:

- If it&#39;s a **Dog** , you should print &quot; **Dog: {name}, Age: {age}, Number Of Legs: {numberOfLegs}** &quot;
- It it&#39;s a **Cat** , you should print &quot; **Cat: {name}, Age: {age}, IQ: {intelligenceQontient}** &quot;
- If it&#39;s a **Snake** , you should print &quot; **Snake: {name}, Age: {age},**  **Cruelty**** : {crueltyCoefficient}** &quot;

Print first the **Dogs** , then the **Cats** , and lastly – **The Snakes**.

#### Constraints

- You can assume that there will be **no duplicate** names ( **even** in **different animals** ).
- All input data will be **valid**. There will be **no invalid** input lines.
- The **name** in the **talk** command, will **always** be **existent**.

#### Examples

| **Input** | **Output** |
| --- | --- |
| Dog Sharo 3 4 <br/> Cat Garfield 5 200 <br/> Snake Alex 25 1000 <br/> talk Sharotalk Garfield <br/> talk Alex <br/> I&#39;m your Huckleberry | I&#39;m a Distinguishedog, and I will now produce a distinguished sound! Bau Bau. <br/> I&#39;m an Aristocat, and I will now produce an aristocratic sound! Myau Myau. <br/> I&#39;m a Sophistisnake, and I will now produce a sophisticated sound! Honey, I&#39;m home. <br/> Dog: Sharo, Age: 3, Number Of Legs: 4 <br/> Cat: Garfield, Age: 5, IQ: 200 <br/> Snake: Alex, Age: 25, Cruelty: 1000 |
| Dog Bau 5 10 <br/> Cat Myau 5 100 <br/> Dog Georgi 20 1000 <br/> Cat Bojo 4 20 <br/> talk Bojo <br/> I&#39;m your Huckleberry | I&#39;m an Aristocat, and I will now produce an aristocratic sound! Myau Myau. <br/> Dog: Bau, Age: 5, Number Of Legs: 10 <br/> Dog: Georgi, Age: 20, Number Of Legs: 1000 <br/> Cat: Myau, Age: 5, IQ: 100 <br/> Cat: Bojo, Age: 4, IQ: 20 |

## 4.Websites

You have been tasked to create an ordered database of websites. For the task you will need to create a **class** **Website **, which will have a** Host **, a** Domain **and** Queries**.

The **Host** and the **Domain** are simple **strings**.
The **Queries** , is **Collections** of **strings**.

You will be given several input lines in the following format:

**\{host} \| \{domain} \| \{query1,query2. . .}**

Note: There will **always** be a **host** and a **domain** , but there **might** **NOT **be** ANY** **queries**.

The input sequence ends, when you receive the command &quot; **end**&quot;. Then you must print **all websites** in the following format:

https://www.{host}.{domain}/query?=[{query1]&amp;[{query2}]&amp;[query3]. . .

In case there are **NO** **queries**, just print:

https://www.{host}.{domain}

#### Examples

| **Input** | **Output** |
| --- | --- |
| softuni \| bg \| user,course,homework <br/> judge.softuni \| bg \| contest,bg <br/> google \| bg \| search,query <br/> zamunda \| net <br/> end |https://www.softuni.bg/query?=[user]&[course]&[homework] <br/> https://www.judge.softuni.bg/query?=[contest]&[bg] <br/> https://www.google.bg/query?=[search]&[query] <br/> https://www.zamunda.net|

## 5.Boxes

Create a **class Box** , which will represent a **rectangular** box **. The Box should have** UpperLeft(**Point**),**UpperRight**(**Point**),**BottomLeft**(**Point**),**BottomRight**(**Point**).

Create, or use from the Lab, the **class Point** which has **X** ( **int** ) and **Y** ( **int** ) – coordinates in **2D space**. Move the **CalculateDistance()** method in the **Point class** , exactly as it is. Then use &quot;**Point.CalculateDistance(point1, point2)**&quot; signature, to **use** the **method**.

Create **2 methods** in the **Box class** :
**public static int CalculatePerimeter(int width, int height)**
**public static int CalculateArea(int width, int height)**.

Make them **return** an **integer** , representing the **perimeter** and **area** of the **box**.

The formulas are respectively – ( **2 \* Width + 2 \* Height** ) and ( **Width \* Height** ).

The **Width** is the **distance**** between **the** UpperLeft **and the** UpperRight **Points, and** ALSO **– the** Bottomleft **and the** BottomRight** Points.

The **Height** is the **distance**** between **the** UpperLeft **and the** BottomLeft **Points, and** ALSO **– the** UpperRight **and the** BottomRight** Points.

You will receive several input lines in the following format:

**\{X1}:\{Y1} \| \{X2}:\{Y2} \| \{X3}:\{Y3} \| \{X4}:\{Y4}**

Those will be the coordinates to **UpperLeft** , **UpperRight** , **BottomLeft** and **BottomRight** ( **IN THE SAME ORDER** ).

When you receive the command &quot; **end**&quot;. You must print **all Boxes** in the following format:

&quot; **Box: \{width}, \{height}**

 **Perimeter: \{perimeter}**

 **Area: \{area}** &quot;

#### Examples

| **Input** | **Output** |
| --- | --- |
| 0:2 \| 2:2 \| 0:0 \| 2:0 <br/> -3:0 \| 0:0 \| -3:-3 \| 0:-3 <br/> -2:2 \| 2:2 \| -2:-2 \| 2:-2 <br/> end | Box: 2, 2 <br/> Perimeter: 8 <br/> Area: 4 <br/> Box: 3, 3 <br/> Perimeter: 12 <br/> Area: 9 <br/> Box: 4, 4 <br/> Perimeter: 16 <br/> Area: 16 |

## 6.Messages \*

Create a **class** **User **, which has a** Username**(**string**), and**ReceivedMessages**(**Collection **of** Messages)**.
Create a **class** **Message **, which has a** Content**(**string**) and a**Sender**(**User**).

You will have to store a messaging history for every user. The input consists of 2 commands:

**“register \{username}”** <br/>
**“\{senderUsername} send \{recipientUsername} \{content}”**

The **register command** , registers a **user** with the **given username**.

The **send command** , sends a **message** , from the **given sender** , to the **given recipient** , with the **given content**. That means that you must **add** the **message** to the **recipient&#39;s ReceivedMessages**.
If **even one** of the **given names** does **NOT** exist, **ignore** the command.

When you receive the command &quot; **exit**&quot; you must end the input sequence. After that you will receive **2 usernames** , **separated** by a **space**.

You must **print all messages** , sent, **between the two users** , corresponding to **the given usernames**. The messages should be printed in a specified way. You should print **first** a **message**** SENT **from the** first user **,** then **a** message ****SENT** from the **second user** , then a **message** from **the first user** , and **so**** on **. If one of the** collections **of** messages **has** more ****elements** than the **other** , just print the **remaining elements** from it.

The first user&#39;s messages must be printed in the following way:

**&quot; \{firstUser}: \{content}&quot;**

The second user&#39;s message must be printed in the following way:

**&quot;\{content} :\{secondUser}&quot;**

When you print the whole output, it should look like this:

**\{firstUser}: {content1}**
**\{content1} :{secondUser}**                      
**\{firstUser}: {content2}**                   
**\{content2} :{secondUser}**
**. . .**

In case there are **NO** messages **between** the two users, print &quot; **No messages**&quot;.

#### Examples

| **Input** | **Output** |
| --- | --- |
| register Ivan <br/> register Pesho <br/> Ivan send Pesho pesho <br/> Ivan send Pesho pesho\_tam\_li\_si? <br/> Pesho send Ivan kaji\_vanka <br/> Pesho send Ivan tuk\_sum <br/> Pesho send Ivan chakai\_che\_bachkam <br/> Ivan send Pesho kvo\_stava <br/> Ivan send Pesho kak\_si <br/> Ivan send Pesho deka\_izbega\_be? <br/> Ivan send Pesho pecaaa!!! <br/> exit <br/> Ivan Pesho | Ivan: pesho <br/> kaji\_vanka :Pesho <br/> Ivan: pesho\_tam\_li\_si? <br/> tuk\_sum :Pesho <br/> Ivan: kvo\_stava <br/> chakai\_che\_bachkam :Pesho <br/> Ivan: kak\_si <br/> Ivan: deka\_izbega\_be? <br/> Ivan: pecaaa!!! |
| register John <br/> John send Harry harry\_you\_there? <br/> register Harry <br/> John send Harry harry? <br/> register Donald <br/> Harry send John yeah\_sorry\_was\_out... <br/> Harry send John wassup? <br/> Donald send John Yo\_John? <br/> Donald send Jonh You\_there? <br/> John send Harry thank\_god!! <br/> John send Harry I\_need\_you! <br/> exit <br/> John Harry | John: harry? <br/> yeah\_sorry\_was\_out... :Harry <br/> John: thank\_god!! <br/> wassup? :Harry <br/> John: I\_need\_you! |