#<p align="center"> Exam - 12 June 2016 <p>

## 01.Numbers
####**Problem Description**
Write a program to **read a sequence of integers** and find and print the **top 5** numbers that are **greater than the average** value in the sequence, sorted in descending order.

####Input

Read from the console a single line holding space separated number.

####Output

Print the above described numbers on a single line, space separated. If less than **5 numbers** hold the above mentioned property, print **less than 5** numbers. Print **“No” if no numbers** hold the above property.

####Constrains

All input numbers are integers in range [-1 000 000 … 1 000 000]. The count of numbers is in range [1…10 000].

## 02.SoftUni Coffee Orders
#### Problem Description
We are placing **N** orders at a time. You need to calculate the price after the discount based on the following formula:
**((daysInMonth * capsulesCount) * pricePerCapsule)**
*Hint – The **DateTime** class may come in handy to calculate the days in month.

####Input / Constraints

- On the first line you will receive integer **N – the count** of orders the shop will receive.
- For each order you will receive the following information:
Price per capsule - **floating-point number** in range [0…79,228,162,514,264,337,593,543,950,335].
Order **date** - in the following format **{d/M/yyyy}**, e.g. 25/11/2016, 7/03/2016, 1/1/2020.
Capsules **count** - integer in range [0…2,147,483,647].
The input will be in the described format, there is no need to check it explicitly.

####Output

The output should consist of **N + 1** lines. For each order you must print a single line in the following format:
- “The price for the coffee is: **${price}**”
On the last line you need to print the total price in the following format:
- “Total: ${**totalPrice**}”
The **price must be rounded** to 2 decimal places. 

## 03.Football Standings
####Problem Description
**You will be given** information about **results of football matches**. Create a standings table by points. For **win the team gets 3 points, for loss – 0** and for **draw – 1**. Also find the **top 3 teams** with most **scored goals in descending order**. If two or more teams are with **same goals scored** or **same points** order them by **name in ascending** order.
The name of each team is **encrypted.** You **must decrypt it** before proceeding with calculating statistics. You will be given some string **key** and the **team name will be placed between that key** in reversed order.
- **For example: the key: “???”;**
**String to decrypt: “kfle???airagluB???gertIt%%” -> “airagluB” -> “Bulgaria”**
Also you **should ignore **the letter **casing** in the team names. For example:
**buLgariA = BulGAria = bulGARIA = BULGARIA**

####Input / Constrains
- On the first line of input you will get the **key** that will be used for decryption
- On the next lines until you receive **“final”** you will get lines in format:
**{encrypted teamA} {encrypted teamB} {teamA score}:{teamB score}**
- Team **scores** will be **integer** numbers in the range [0...231]

####Output
- Print the standings table ordered descending by points in format:
**League standings:**
**{place}. {TEAM NAME} {points}**
**...**

Where **place** is a number in range **[1… number of teams]**.
- Then you should print the **top 3** team ordered by goals in **descending order** in format:
Top 3 scored goals:
**- {TEAM NAME} -> {goals}**
**- {TEAM NAME} -> {goals}**
**- {TEAM NAME} -> {goals}**

- **All team’s names should be uppercase.**

## 04.Trifon's Quest
#### Problem Description
**Our hero Trifon** was sent on a quest. You are given **his health** and the **map** (as a **rectangle matrix**) where he will travel. Trifon **moves one cell at a time** and the quests **advances with 1 turn** (first operate with health points then increase the turns). Print the outcome of the quest if it is **successful or not**. A quest is successful if Trifon **goes thru all cells on the map and has health above 0**.
There are different **obstacles** on his way.
- **Fight (F)** – the hero **loses {current number of turns} / 2 of his health points**
- **Heal (H)** – the hero **restores {current number of turns} / 3 of his health points**
- **Trap (T)** – the hero must wait **2 turns** (the quest will finish 2 turns later)
- **Empty cell (E)** – nothing happens here just game **advances with 1 turn**.
* NOTE: The **division of the turns** must be **integer division. For example:** 5 / 2 = 2.
The hero **always starts** his journey in the **top left corner** (the cell with coordinates [0,0]). 

####Input / Constrains

- On the **first line** you will receive the **staring health points**. Integer numbers in range [0… 231]
- On the **second line** – dimensions of the map in format: **“{Rows} {Cols}”**
- On the **next {Rows} lines** -> the **map** for the journey. Map will **contain** only the symbols: **F, H, T, E**

####Output
- In case the player **successfully** finishes the game print:
**Quest completed!**
**Health: {Hero’s current health}**
**Turns: {Total number of turns for the quest}**

- In case the player **did not succeed** in completing the quest print:
**Died at: [{row}, {col}]**
Where **row** and **col** are the coordinates of the **cell** where the **health** of the hero **becomes ≤ 0**.
