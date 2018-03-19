# <p align="center"> Exercises: Introduction to DB Apps </p>

This document defines the **exercise assignments** for the [&quot;Databases Advanced – EF Core&quot; course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

## 1.Initial Setup

Write a program that connects to your **localhost** server. Create **new database** called **MinionsDB** where we will keep information about our minions and villains.

For each **minion** we should keep information about its **name** , **age** and **town**.  Each **town** has information about the **country** where it&#39;s located. **Villains** have **name** and **evilness factor** ( **super good** , **good** , **bad** , **evil** , **super evil**). Each **minion can** serve **several** villains and each **villain** can **have** **several** **minions** **serving** **him**. Fill all tables with at least 5 records each.

In the end you shoud have the following tables:

- Countries
- Towns
- Minions
- EvilnessFactors
- Villains
- MinionsVillains

![Not fount](/DBFundamentals/Databases-Advanced/images/37.png)

## 2.Villain Names

Write a program that prints on the console **all villains&#39; names** and their **number of minions** of those who have more than 3 minions **ordered descending** by number of minions.

### Example

| **Output** |
| --- |
| Gru - 6 <br/> Victor - 4 <br/> Jilly – 4 |

## 3.Minion Names

Write a program that prints on the console **all minion names** and age for a given **villain id** , ordered by **name** **alphabetically.**

If there is no villain with the given ID, print &quot;No villain with ID &lt; **VillainId** &gt; exists in the database.&quot;.
If the selected villain has no minions, print &quot;(no minions)&quot; on the second row.

### Example

| **Input** | **Output** |  **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | 
| 1 | Villain: Gru <br/> 1. Bob 13 <br/>2. Kevin 14 <br/>3. Steward 19 | 3 | Villain: Victor <br/>1. Bob 13 <br/>2. Simon 22 |  2 | Villain: Victor Jr.(no minions) |

| **Input** | **Output** |
| --- | --- |
| 10 | No villain with ID 10 exists in the database. |

## 4.Add Minion

Write a program that **reads** **information** about a minion and its villain and **adds it to the database**. In case the town of the minion is not in the database, **insert** it as well. In case the villain is not present in the database, add him too with a default **evilness factor** of &quot;evil&quot;. Finally set the new minion to be a servant of the villain. Print appropriate messages after each operation.

### Input

The input comes in two lines:

- On the first line, you will receive the **minion**** information **in the format &quot;Minion: &lt;** Name **&gt; &lt;** Age **&gt; &lt;** TownName**&gt;&quot;

- On the second – the **villain** **information** in the format **&quot;Villain: &lt Name&gt;&quot;**

### Output

After completing an operation, you must print one of the following messages:

- After adding a new **town** to the database: &quot;Town &lt; **TownName** &gt; was added to the database.&quot;
- After adding a new **villain** to the database: &quot;Villain &lt; **VillainName** &gt; was added to the database.&quot;
- Finally, after successfully adding the **minion** to the database and making it a **servant** of a villain: &quot;Successfully added &lt; **MinionName** &gt; to be minion of &lt; **VillainName** &gt;.&quot;

**\*Bonus task:** Make sure all operations are executed successfully. In case of an error do not change the database.

### Example

| **Input** | **Output** |
| --- | --- |
| Minion: Bob 14 Berlin <br/>Villain: Gru | Successfully added Robert to be minion of Gru. |
| Minion: Cathleen 20 Liverpool <br/>Villain: Gru | Town Liverpool was added to the database. <br/>Successfully added Cathleen to be minion of Gru. |
| Minion: Mars 23 Sofia <br/>Villain: Poppy | Villain Poppy was added to the database. <br/>Successfully added Mars to be minion of Poppy. |
| Minion: Carry 20 Eindhoven <br/>Villain: Jimmy | Town Eindhoven was added to the database.Villain Jimmy was added to the database. <br/>Successfully added Carry to be minion of Jimmy. |

## 5.Change Town Names Casing

Write a program that **changes all town names to uppercase** for a given country.

You will receive one line of input with the **name** of the country.

**Print the** **number of towns that were changed** in the format &quot;&lt; **ChangedTownsCount** &gt; town names were affected.&quot;. On a second line, **print** the **names that were changed**, separated with a comma and a space.

If **no** **towns** were affected (the country does not exist in the database or has no cities connected to it),**print **&quot;** No town names were affected.**&quot;.

### Example

| **Input** | **Output** |
| --- | --- |
| Bulgaria | 3 town names were affected. [SOFIA, VARNA, BURGAS] |
| Germany | No town names were affected. |

## 6.\*Remove Villain

Write a program that receives the **ID** of a villain, **deletes him from the database** and **releases his minions** from serving to him. Print on **two** **lines** the name of the deleted villain in format &quot;&lt;**Name** &gt; **was deleted**.&quot; and the number of minions released in format &quot;&lt; **MinionCount** &gt; **minions were released**.&quot;. Make sure all operations go as planned, otherwise do not make any changes in the database.

If there is no villain in the database with the given ID, print &quot; **No such villain was found**.&quot;.

### Example

| **Input** | **Output** |
| --- | --- |
| 1 | Gru was deleted. <br/>6 minions were released. |
| 3 | Victor was deleted. <br/>0 minions were released. |
| 101 | No such villain was found. |

## 7.Print All Minion Names

Write a program that **prints all minion names** from the minions table **in the following order:** first record, last record, first + 1, last - 1, first + 2, last - 2 … first + n, last - n.

| 1 | 10 | 2 | 9 | 3 | 8 | 4 | 7 | 5 | 6 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |

### Example

| **Original Order** | **Output** |
| --- | --- |
| Bob <br/>Kevin <br/>Steward <br/>Jimmy <br/>Vicky <br/>Becky <br/>Jully | Bob <br/>Jully <br/>Kevin <br/>Becky <br/>Steward <br/>Vicky <br/>Jimmy |

## 8.Increase Minion Age

Read from the console minion IDs separated by space. **Increment the age** of those minions **by 1** and make their **names title case**. Finally, **print the name and the age of all minions** in the database, each on a new row in format **&quot;&lt;Name&gt; &lt;Age&gt;**&quot;.

### Example

| **Minions** |
| --- |
| **Id** | **Name** | **Age** |
| 1 | bob | 14 |
| 2 | stuart | 22 |
| 3 | kevin | 13 |
| 4 | jimmy | 49 |
| 5 | vicky jackson | 26 |

| **Input** | **Output** |   **Input** | **Output** |
| --- | --- | --- | --- | 
| 2 1 4 | Bob 15 <br/>Stuart 23 <br/>kevin 13 <br/>Jimmy 50 <br/>vicky jackson 26 | 5 | bob 14 <br/>stuart 22 <br/>kevin 13 <br/>jimmy 49 <br/>Vicky Jackson 27 |

## 9.Increase Age Stored Procedure

Create stored procedure **usp\_GetOlder** ( **directly in the database** using **Management Studio** or any other similar tool) that receives **MinionId** and **increases that minion&#39;s age by 1**. Write a program that **uses that stored procedure to increase the age** of a minion whose id will be given as input from the console. After that **print the name and the age** of that minion.

### Example

| **Minions** |
| --- |
| **Id** | **Name** | **Age** |
| 1 | bob | 14 |
| 2 | steward | 22 |
| 3 | kevin | 13 |
| 4 | jimmy | 49 |
| 5 | vicky jackson | 26 |

| **Input** | **Output** |
| --- | --- |
| 1 | bob – 15 years old |
| 3 | kevin – 14 years old |
| 5 | vicky jackson – 27 years old |
