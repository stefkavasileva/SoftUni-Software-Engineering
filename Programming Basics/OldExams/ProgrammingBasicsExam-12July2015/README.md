# <p align="center"> Programming Basics Exam - 12 July 2015 <p>

# Problem 1 – Four Factors

Little Spiridon is a big NBA fan. However, since he&#39;s very good with math and not very athletic, he doesn&#39;t dream of becoming an NBA superstar, but an NBA analyst instead. Spiro just finished reading the book &quot;Basketball on Paper&quot; by Dean Oliver and is now looking to understand how the Four Factors of wining basketball games work. Will you help little Spiridon - the NBA fan, become big Spiridon – the NBA analyst?

According to Dean Oliver, the four factors of wining basketball games, are Shooting, Turnovers, Rebounding and Free Throws. Each factor can be applied to both the team&#39;s offense, and defense, which basically gives us eight factors, but we will be focusing on the Offense part only, for now.

The Shooting Factor is measured using **Effective Field Goal Percentage (eFG%)**. The formula, by which the eFG% is calculated, is **(Field Goals (FG) + 0.5 \* 3-Point Field Goals (3P)) / Field Goals Attempted (FGA)**.

The Turnover Factor is measured using **Turnover Percentage (TOV%)**. The formula for the offensive TOV% is **Turnovers (TOV) / (FGA + 0.44 \* Free Throw Attempts (FTA) + TOV)**.

The Rebounding Factor for offense is measured in **Offensive Rebounding Percentage (ORB%)** and the formula for it is **Offensive Rebounds (ORB) / (ORB + Opponent Defensive Rebounds (Opp DRB))**.

The Free Throw factor, or the **Free Throw Percentage (FT%)**, is by far the easiest to calculate and the formula for it is **Free Throws (FT) / FGA**.

Your job is to write a program, which takes certain input parameters, calculates the four offensive factors, **rounded to the third digit after the decimal sign** , and then prints them on the console. Each factor should **always be a positive number**.

**Input**

The input data should be read from the console. It consists of **eight** input values, each at a separate line:

1. **FG** – Field Goals
2. **FGA** – Field Goal Attempts
3. **3P** – 3-Point Field Goals
4. **TOV** – Turnovers
5. **ORB** – Offensive Rebounds
6. **Opp DRB** – Opponent Defensive Rebounds
7. **FT** – Free Throws
8. **FTA** – Free Throw Attempts

 The input data will always be valid and in the format described. There is no need to check it explicitly.

#### **Output**

The output should be printed on the console and it should consist of **four** strings, each printed on a separate line in the following format:

- **eFG%** {factor result}
- **TOV%** {factor result}
- **ORB%** {factor result}
- **FT%** {factor result}

Look at the examples below, to get a better understanding of how the output should be structured.

#### **Constraints**

- All input parameters will be valid integers, in the range [1 ... 3,000,000,000].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

1. **Examples**

|
1. **Input**
 |
1. **Output**
 |
1. **Comments**
 |
| --- | --- | --- |
|
1. 3351
2. 7018
3. 796
4. 1125
5. 967
6. 2550
7. 1556
8. 2080
 |
1. eFG% 0.534
2. TOV% 0.124
3. ORB% 0.275
4. FT% 0.222
 |
1. eFG% = (3351 + 0.5 \* 796) / 7018 = 0.534
2. TOV% = 1125 / (7018 + 0.44 \* 2080 + 1125) = 0.124
3. ORB% = 967 / (967 + 2550) = 0.275
4. FT% = 1556 / 7018 = 0.222
 |

|**Input**|**Output**|**Comments**|
|---|---|---|
|3351  <br/> 7018  <br/> 796 <br/> 1125 <br/> 967 <br/> 2550 <br/> 1556 <br/> 2080|eFG% 0.534  <br/> TOV% 0.124 <br/> ORB% 0.275 <br/> FT% 0.222|eFG% = (3351 + 0.5 * 796) / 7018 = 0.534 <br/> TOV% = 1125 / (7018 + 0.44 * 2080 + 1125) = 0.124 <br/> ORB% = 967 / (967 + 2550) = 0.275 <br/> FT% = 1556 / 7018 = 0.222|

|**Input**|**Output**|**Input**|**Output**|
|---|---|---|---|
|3643 <br/> 7168 <br/> 138 <br/> 1088 <br/> 1173 <br/> 2171 <br/> 1587 <br/> 2132|eFG% 0.518 <br/> TOV% 0.118 <br/> ORB% 0.351 <br/> FT% 0.221|2193 <br/> 5293 <br/> 263 <br/> 957 <br/> 677 <br/> 2193 <br/> 1090 <br/> 1462|eFG% 0.439 <br/> TOV% 0.139 <br/> ORB% 0.236 <br/> FT% 0.206|

# Problem 2 – Detective Boev

Detective Boev is very good with decrypting messages.  One day he got a message sent by general Ivanov. Knowing the decrypting algorithm he asked his secret agent, who is learning C# in SoftUni, to write a console application for decrypting general&#39;s messages. Help him.

You will be given an **encrypted message** and a **secret word****.**

You need to take the secret word and sum all of it&#39;s symbols ASCII code. After that you must sum all digits until the result is only one digit.
For example if the word is **code** (c + o + d + e =&gt; 99 + 111 + 100 + 101 =&gt; 411 =&gt; 4 + 1 +1 =&gt; **6** ). The **mask** is **6**.

You must decrypt all symbols in the message. Loop over the message and check if the ASCII code of the symbol can be **devided by the mask** without reminder. If so, **add the mask** to the simbol&#39;s ASCII code. Otherwise, **subtract** it. Finally you must **reverse** the message and print the result on the console.

**Input**

The input data should be read from the console. The input will contain exactly two lines.

- The first line will hold the **secret word.**
- The second line will hold the **encrypted message.**

 The input data will always be valid and in the format described. There is no need to check it explicitly.

**Output**

The output data must be printed on the console.

On the only output line you must print the decrypted message.

**Constraints**

- The **message** and the **secret word** will contain only characters from the ASCII table.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

**Examples**

| **Input** | **Output** | **Mask** |
| --- | --- | --- |
| C# <br/> \|wfvohyfqX#hodzwclV | Software University | C# =&gt; 67 + 35 =&gt; 102 =&gt; 1 + 0 + 2 = 3 |

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| abc <br/> ;7\*8&amp;yioyg&lt;&amp;mtossglmulV | Programming Basics 2015 | 0.5 <br/> dofe | bira |

## Problem 3 – Summertime for Programmers

Dimitrichko has a dream – to become the best programmer ever. He is studying at SoftUni, investing all of his free time doing homework and watching videos. He enjoys drinking beer, but he doesn&#39;t have time for this. Your task is to draw him one and make him happy. Beware that he may get tipsy very easy. Fill exactly half of the bottle with beer.

You are given an integer number **N** (always **odd** ). The **width** of the **bottom** of the bottle should be 2 \* **N.** The **width** of the **top** of the bottle should be **N + 1.** The **height** of the bottle should be **3 \* N + 1.** Check the examples below to understand your task better.

### Input

The input number **N** should be read from the console. It will be **odd** number in the range **[3..59]**.
The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Use the &quot; **\***&quot; to draw the bottle and fill it with &quot;.&quot; and &quot;@&quot;. Follow the examples below.

### Constraints

- **N** will always be a positive **odd** number in the range [**3** … **59].**
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

###  Examples

#### Input: 3

```
 ****
 *  *
 *  *
*....*
*....*
*....*
*@@@@*
*@@@@*
*@@@@*
******
```

#### Input: 5

```
  ******
  *    *
  *    *
  *    *
 *      *
*........*
*........*
*........*
*........*
*........*
*@@@@@@@@*
*@@@@@@@@*
*@@@@@@@@*
*@@@@@@@@*
*@@@@@@@@*
**********
```

#### input: 7

```
   ********
   *      *
   *      *
   *      *
   *      *
  *        *
 *          *
*............*
*............*
*............*
*............*
*............*
*............*
*............*
*@@@@@@@@@@@@*
*@@@@@@@@@@@@*
*@@@@@@@@@@@@*
*@@@@@@@@@@@@*
*@@@@@@@@@@@@*
*@@@@@@@@@@@@*
*@@@@@@@@@@@@*
**************
```

## Problem 4 – Light the Torches

Father Haralambi is an Orthodox priest, who is serving in the small Elin Pelinian monastery. During the day, Father Haralambi mostly prays and, since he&#39;s a casual fisherman, on Sundays, he goes to the river near the monastery and tries to catch his own dinner. In the evenings, it&#39;s Father Haralambi&#39;s duty, to go down to the unusually large monastery basement and light the torches in each room. He is a good Orthodox priest and as such he is not fully sober in the evenings, thus he sometimes is not able to light all the torches. Every morning, after the morning prayer, the father counts the rooms that are dark and using a certain formula that he created, calculates the number of prays that he has to say during the day, in order to make up for the rooms that he wasn&#39;t able to reach. Your job is to create a program, which will monitor Father Haralambi&#39;s movements in the basement and automate the calculation process, thus allowing him to focus on praying, rather than lose precious time doing math.

The monastery&#39;s basement **is linear** and there is **only one single door** connecting two adjacent rooms. The only entrance to the basement, is in the room that&#39;s **in the middle of the basement** – the rooms on the left from the entrance will always be equal to the number of rooms on the right from the entrance. **The total number of rooms will be an odd number N**.

You will receive a **string of characters** , which will tell you which rooms are currently lit and which rooms are dark. The string can have **a length less than or equal** to the **number** of rooms. It will contain only **two types of characters, &#39;L&#39; for light** and **&#39;D&#39; for dark** and each character will represent the state of **a single room**.

Your first task is to go through all the rooms, starting from the **leftmost room** (room 0), and **update** the state of each room, using the **characters** in the string **from left to right**. If you reach the end of the string before you reach the end of the basement, **go back** at the beginning of the string **and continue**.

After the rooms&#39; state has been updated, Father Haralambi will enter the basement **from the only entrance** and you are to begin monitoring his movements. The movements will be represented as a **series of commands** , each provided **on a separate line**. The possible commands are **RIGHT X, LEFT X and END** , with **X** being **the number of rooms** that the priest passes through and **LEFT/RIGHT** being the **direction** that he&#39;s walking in.

For example, if the priest is currently in **room 2** and the command **RIGHT 3** is received that will mean that the priest will end up in **room 6** – he passes through 3 rooms and ends up in the next one. Respectfully, if he is currently in **room 5** and you receive the command **LEFT 3** , the priest will wind up in room 1. When the priest **stops walking** , he will **update** the **state** of the current room. If the room is dark, then he will light it up and if the room is already lit, he will stumble upon the torch and the room will become dark. The priest **updates only** the rooms that he **ends up in** and **not** the ones that **he passes through,** while trying to get there. Also, don&#39;t forget that the priest is not quite sober, so he may try to go to **rooms that do not exist**. For example, if he is in **room 0** , he does a **RIGHT 6** movement, but the basement has **only 5** total rooms, then he will **end up** in the last room on the right, which will be **room 4**. If the priest **does not change** rooms, after you receive a command, then the **state** of the current room **is not changed.**

When you receive the **END command,** that means the priest has fallen asleep and you should start calculating his prays for the next day.

Once the priest has fallen asleep, go through the entire basement and **count the rooms that are still dark**. The total number of prays that Father Haralambi has to say, when he wakes up, is equal to the **ASCII code** of the character **&#39;D&#39; multiplied** bythe **number** of **dark** rooms.

**Input**

The input data should be read from the console.

- On the **first line** you will receive an **ODD number N** , specifying the **total number of rooms in the basement**.
- On the **second line** , you will receive a **string** , containing a **series of &#39;L&#39; and &#39;D&#39; characters**.
- On the **next lines** , you will receive a **series of commands** in the described formats. **The input ends when the END command is received.**

 The input data will always be valid and in the format described. There is no need to check it explicitly.

**Output**

The output should be printed on the console and should consist of a **single number**. The number is the **total number of prays**.

**Constraints**

- The number N will be a valid ODD integer in the range [1 ... 99].
- The string has length less than or equal to N and will NOT contain any white spaces.
- Each command will be provided on a separate line in the format: RIGHT {X} / LEFT {X} / END
- The number X will always be a valid integer in the range [0 ... 100].
- The number of commands will be in the range [1 ... 202].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

#### Example

|**Input**|**Output**|
|---|---|
|5 <br/> LD <br/> LEFT 0 <br/> LEFT 20 <br/> RIGHT 2 <br/> LEFT 2 <br/> END| 0 |![Not fount](/Programming%20Basics/OldExams/images/22.PNG) |


