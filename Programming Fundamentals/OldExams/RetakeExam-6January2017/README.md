# <p align="center"> Programming Fundamentals Retake Exam - 6 January 2017 <p>
 
## 01.Sino The Walker

Sino is one of those people that lives in SoftUni. He leaves every now and then, but when he leaves he always takes a different route, so he needs to know how much time it will take for him to go home. Your job is to help him with the calculations.

You will receive the **time that Sino leaves** SoftUni, the **steps taken** and **time for each step in seconds**.

You need to print the exact **time** that he will **arrive at home in the format specified**.

#### Input / Constrains

- The first line will be the time Sino leaves SoftUni in the following format: **HH:mm:ss**
- The second line will contain the **number of steps** that he needs to walk to his home. This number will be an integer in range **[0…2,147,483,647]**
- On the final line you will receive the **time in seconds** for each **step**. This number will be an integer in range **[0…2,147,483,647]**

#### Output

- Print the **time of arrival** at home in the following format:
  - **oo**** Time Arrival: {hours}:{minutes}:{seconds}**
- If hours, minutes or seconds are a single digit number, add a zero in front.
- If, for example, hours are equal to zero, print a **00** in their place. The same is true for minutes or seconds.
- Time of day starts at **00:00:00** and ends at **23:59:59**

#### Examples

| **Input** | **Output** |
| --- | --- |
| 12:30:30 <br/> 90 <br/> 1 | Time Arrival: 12:32:00 |
| 23:49:13 <br/> 5424 <br/> 2 | Time Arrival: 02:50:01 |

## 02.SoftUni Karaoke

SoftUni cultivates talent whether it&#39;s coding talent or something else and in this case, something else is singing. Since you love music you want to take part in the event but as a programmer you simply lack the &quot;something else&quot; so your job is to make the software to track participants&#39; awards.

**On the first line** , you will receive a **list with all participants that applied for performance**.

**On the second line** , you will receive **the list with all available songs**.

**On the next lines** , until the &quot; **dawn**&quot; **command** , you will get the **names of people** , **the song that they are performing** on stage and **the award they get** from the audience.

However, not every time the plan goes according to schedule. In other words, **everyone** (listed or not) **can go on stage and perform a song that is not even available** and he **still gets awards from the audience**. However, you should **record only the awards for listed participants** that **perform songs**  **available**  **in the list**. In case someone is **not listed** or sings a **song that is not available** you **should not record neither the participant, nor his award**.

When the &quot;dawn&quot; comes, you need to **print all participants** , the **count of the unique awards they received** and all unique awards. Participants should be **sorted by number of awards** in **descending order** and **then by participant name alphabetically**. Awards should be **sorted in alphabetical order**.

#### Input

- On the first line, you will receive list with all participants that applied for performance in the format: **&quot;{participant}, {participant} … {participant}&quot;**
- On the second line, you will get all available songs in the in the format: **&quot;{song}, {song} … {song}&quot;**
- On the next lines, until the **&quot;dawn&quot;** command you will receive every stage performance in the format: **&quot;{participant}, {song}, {award}&quot;**
- Performances and songs will be **separated by a comma and a single or multiple white spaces**

#### Output

- Print all participants along with the number of unique awards they won in the format:
  - **oo****&quot;{participant}: {award count} awards&quot;**
  - **oo****&quot;--{award}&quot;**
- Print participants **sorted by unique awards count in descending order**. If two participants have the same unique award count **, sort them alphabetically by name**
- Print unique **awards** for every participant **sorted alphabetically**
- If there are **no awards,** print **&quot;No awards&quot;**

#### Constrains

- The number of total participants will be in range [1 … 100]
- The number of total songs will be in range [1 … 100]
- The input will always end with the &quot;dawn&quot; command

#### Examples

| **Input** | **Output** |
| --- | --- |
| Trifon, Vankata, Gesha <br/> Dragana - Kukavice, Bon Jovi - It's my life, Lorde - Royals <br/> Gesha, Bon Jovi - It's my life, Best Rock <br/> Vankata, Dragana - Kukavice, Best Srabsko <br/> Vankata, Dragana - Kukavice, Best Srabsko <br/> Vankata, Dragana - Kukavice, Stiga Tolko Srabsko <br/> Vankata, PHP Web, Educational 101 <br/> dawn|Vankata: 2 awards <br/> --Best Srabsko <br/> --Stiga Tolko Srabsko <br/> Gesha: 1 awards <br/> --Best Rock|
|Gesha <br/> Bon Jovi - It's my life <br/> Gesha, Bon Jovi - It's my life, Best Rock <br/> Vankata, Dragana - Kukavice, Best Srabsko <br/> Vankata, Dragana - Kukavice, Stiga Tolko Srabsko <br/> Vankata, PHP Web, Educational 101 <br/> dawn|Gesha: 1 awards <br/> --Best Rock|
|Sino <br/> Vasko Naidenov - Nova Godina <br/> dawn|No awards|

## 03.Endurance Rally

The goal of the Endurance Rally is, simply, to finish the race.

You are given **the names of the participants** , **the track layout** and **the**** checkpoint** indexes.

The starting fuel of each participant is **equal to the ASCII code** of the **first character** of his name.

Track layout consists of zones represented by numbers, given on a single line separated by a single space. Every number **represents** the **fuel given** or the **fuel taken** by the current zone of the track:

- If the current zone **is a checkpoint** , the value of the zone is **added** to the driver&#39;s **fuel**.
- If the current zone **is not a checkpoint** , the value of the zone is **subtracted** from the driver&#39;s fuel.

Zones are **indexed**. Indexes are sequential and always **start from zero** (like an array).

The **checkpoints** are numbers, representing indexes that show if **a zone of the track**** is a checkpoint**. For example, you are given checkpoints 0, 3 and 5, that means that zones at index 0, 3 and 5 of the track are checkpoints and therefore provide fuel for the driver.

Given this information, you need to **check if a driver can finish** and **print the fuel that he is left with**. If a driver **can&#39;t finish** you need to **print the zone he managed to reach**.

#### **Input**

The input will be read from the console. The input consists of **exactly three lines** :

- The first line holds the drivers&#39; names separated by a space: **&quot;{driver 1} {driver 2} … {driver N}&quot;**
- On the second line is the track layout (zones) in the form of numbers separated by a space: **&quot;{zone 0} {zone 1} … {zone N}&quot;**
- On the third line are the checkpoint indexes also separated by a space: **&quot;{index 0} {index 1} … {index N}&quot;**

#### **Output**

Print all drivers **in the order of their appearance** , each on a separate line:

- If the driver finished, print his name and fuel left to the second digit after the decimal point in the format: **&quot;{driver name} - fuel left {fuel points}&quot;**
- If the driver could not finish, print: **&quot;{driver name} - reached {zone index}&quot;**

#### **Constrains**

- Drivers count will be in the range [0 … 200]
- Zone fuel will be a floating-point number

### **Examples**

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| Garry Clark <br/> 69 1 15 5 <br/> 1 2|Garry - fuel left 13.00 <br/> Clark - reached 0|Zones 1 and 2 -> checkpoints. <br/>  <br/> Garry ('G' = 71)  <br/> -> 71 - 69 + 1 + 15 - 5 = 13.00 <br/> Garry finished with 13 fuel  <br/>  <br/> Clark ('C' = 67) <br/> -> 67 - 69 = -2  <br/> Clark reached 0|

| **Input** | **Output** |
|---|---|
|Garry Clark Larry <br/> 4 5 12 0 8 7 13 22 5.5 26 <br/> 0 3 5 8|Garry - fuel left 1.50 <br/> Clark - reached 9 <br/> Larry - fuel left 6.50|
|Garry <br/> -29 -5.0 -5.0 <br/> 1 2|Garry - fuel left 90.00|

## 04. Winning Ticket

Lottery is exciting. What is not, is checking a million tickets for winnings only by hand. So, you are given the task to create a program which automatically checks if a ticket is a winner.

You are given a **collection of tickets separated by commas and spaces**. You need to check every one of them if it has a winning combination of symbols.

**A valid ticket should have exactly 20 characters**. The winning symbols are &#39; **@**&#39;, &#39; **#**&#39;, &#39; **$**&#39; and &#39; **^**&#39;. But in order for a ticket to be a winner the symbol should uninterruptedly repeat for at least **6 times** in both the **tickets left half** and the **tickets right half**.

For example, a valid winning ticket should be something like this:

&quot; **Cash$$$$$$Ca$$$$$$sh**&quot;

The left half &quot; **Cash$$$$$$**&quot; contains &quot; **$$$$$$**&quot;, which is also contained in the tickets right half &quot; **Ca$$$$$$sh**&quot;. A winning ticket should contain symbols repeating up to 10 times in both halves, which is considered a Jackpot (for example: &quot; **$$$$$$$$$$$$$$$$$$$$**&quot;).

#### **Input**

The input will be read from the console. The input consists of a **single line** containing all tickets **separated by commas and one or more white spaces** in the format:

- **&quot;{ticket}, {ticket}, … {ticket}&quot;**

#### **Output**

Print the result for every ticket in the order of their appearance, each on a separate line in the format:

- **Invalid ticket - &quot;invalid ticket&quot;**
- **No match - &quot;ticket &quot;{ticket}&quot; - no match&quot;**
- **Match with length 6 to 9 - &quot;ticket &quot;{ticket}&quot; - {match length}{match symbol}&quot;**
- **Match with length 10 - &quot;ticket &quot;{ticket}&quot; - {match length}{match symbol} Jackpot!&quot;**

#### **Constrains**

- Number of tickets will be in range [0 … 100]

#### **Examples**

| **Input** | **Output** |
| --- | --- |
| Cash$$$$$$Ca$$$$$$sh | ticket &quot;Cash$$$$$$Ca$$$$$$sh&quot; - 6$ |
| $$$$$$$$$$$$$$$$$$$$   ,   aabb  ,     th@@@@@@eemo@@@@@@ey |ticket "$$$$$$$$$$$$$$$$$$$$" - 10$ Jackpot! <br/> invalid ticket <br/> ticket "th@@@@@@eemo@@@@@@ey" - 6@|
| validticketnomatch:( | ticket &quot;validticketnomatch:(&quot; - no match |