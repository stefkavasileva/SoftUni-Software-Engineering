# <p align="center"> Programming Basics Exam - 17 January 2016 <p>

## **Problem 1 – Cake Tycoon**

Young Ivancho really likes cakes, in fact he likes them so much he decided to open his own cake factory and since Ivancho&#39;s father is a big mafia boss, he apparently can do that. However there is one problem, Ivancho really hates math, so he asked his father to get him a programmer who will make a program which would calculate his expenses for him. Unluckily for you, you are that programmer, needless to say Ivancho&#39;s father made you an offer you can&#39;t refuse, so you better make sure the program works.

Since Ivancho is very whimsical he decides the **kilograms of flour needed to make a cake** and the **number of cakes** he wants,every day **.** First thing Ivancho needs for his cakes is flour, however it turns out there is only one provider of flour in the city and he can only deliver a specific amount of **kilograms of flour** per day, luckily though he&#39;s a friend of Ivancho&#39;s father so Ivancho **doesn&#39;t have to pay for the flour**. The second thing Ivancho likes the most after cakes is truffles, so Ivancho decided he wants all his cakes to have truffles in them, as much truffles as he can buy, which he will then **divide evenly amongst all cakes he can make that day** , but since truffles are so rare the **amount of truffles** availableand the **price for a truffle** changes each day. Lastly Ivancho has to make a profit, so he decided that the price at which he will sell one cake will be equal to the price of the ingredients for one cake **increased by 25%.**

Your task is to write a program to **calculate** the amount of cakes that Ivancho can make that day and the price for one cake. You&#39;ll be given some **numbers**. The **number of cakes** Ivancho wants that day, the **kilograms of flour needed to make one cake** , the **kilograms of flour** which the provider can give you, the **amount of truffles** you can buy and the **price for each truffle**. If Ivancho has enough flour to make the amount of cakes he wants, he will make **exactly that amount** , the leftover flour will be **discarded** and you should print on the console &quot; **All products available, price of a cake: {price of one cake}**&quot;. Alternatively if there is not enough flour you should **round down** the **number of cakes that can be produced** to a whole number (since Ivancho only wants whole cakes) and print them on the console in the format &quot;C **an make only {number of cakes that can be produced} cakes, need {kilograms of flour needed} kg more flour&quot;** where **kilograms of flour needed** is thedifference between the kilograms of flour required to make the amount of cakes Ivancho wanted and the kilograms of flour available.

### Input

The input data should be read from the console. It consists of five input values, each at a separate line:

• The number **n** – amount of cakes Ivancho wants.

• The number **c** – kilograms of flour needed to make one cake.

• The number **f** – kilograms of flour available.

• The number **t** – amount of truffles available.

• The number **p** – price of one truffle.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console.

- **If there isn&#39;t enough flour to make the amount of cakes Ivancho wants print on the console:**
  - &quot;Can make only {number of cakes that can be produced} cakes, need {kilograms of flour needed} kg more flour&quot;
- **If there is enough flour:**
  - &quot;All products available, price of a cake: {price of one cake}&quot;
- The number of cakes that can be produced must be a whole number; the price of the cake and the kilograms of flour needed must be rounded to two digits after the decimal point.

### Constraints

- The number **n** will be a valid integer in the range [**1 … 18 446 744 073 709 551 615]**
- The number **c** will be a floating-point numbers **in the range [0 … 7.9 x 10 28].**
- The numbers **f, t** and **p** will be valid integers **in the range [0 ... 4 294 967 295]**.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 123 <br/> 1.2 <br/> 150 <br/> 15 <br/> 2000 | All products available, price of a cake: 304.88 | Kilograms -&gt; 150 / 1.2 kg/cake = **125 cakes** 125 &gt; 123 =&gt;Truffles cost = 15(truffles) \* 2000(truffle price) = **30000** <br/>  Cake price = ( **30000** / **123) \* 1.25** = **304.88**   |
| **Input** | **Output** | **Comments** |
| 20000 <br/> 0.54321 <br/> 1000 <br/> 2436 <br/> 57732 | Can make only 1840 cakes, need 9864.20 kg more flour | Kilograms -&gt; 1000 / 0.54321 kg/cake = **1840.9086 cakes** 1840 **&lt;** 20000 **=&gt;** 1840 <br/>  Since the cakes are less than the required amount we round the number down and get **1840 cakes** <br/> Total flour required for all cakes = 20000 \* 0.54321 kg/cake =** 10864.2 kg  <br/> **Kilograms needed = 10864.2 – 1000 =** 9864.20 kg |

| **Input** | **Output** |
| --- | --- |
| 4455 <br/> 1.223446335689 <br/> 5654 <br/> 445999 <br/> 5778829 | All products available, price of a cake: 723162725.92  |

## **Problem 2 – Beer Stock**

Students in SoftUni really like drinking beers, so the Game Bar has to always be stocked with beer and with all the students that will be celebrating passing the Programming Basics Exam a lot of beer is going to be needed today.  Normally Stamat would be keeping track of the stock, however he was at a party last night and got wasted, since he&#39;s too drunk to go and count the beers he asked you to write him a program to do it instead.

Before the exam starts the students who will want a beer will tell you, so on the first line you&#39;ll get the **amount of reserved beers,** then the shipments will start coming in. Each shipment will be in the format &quot; **{amount} {type}&quot;** , where **type** is the type of package received – either **beers** , **sixpacks** or **cases** and **amount** is the **amount received,** each **sixpack** holds exactly **6 beers** and each **case** holds exactly **24 beers.** However since the world isn&#39;t perfect in **every 100 beers exactly the 100-th** **is always broken** so it gets **discarded.** On the last line you&#39;ll receive the text &quot; **Exam Over** &quot;, at that point you have to calculate all the beers received and if they are **more or equal** to the **amount of reserved beers** print &quot; **Cheers! Beer left: \{amount of cases left} cases, \{amount of sixpacks left} sixpacks and \{amount of beers left} beers.** &quot; or if they are **less** print&quot; **Not enough beer. Beer needed: \{amount of cases needed} cases, \{amount of sixpacks needed} sixpacks and \{amount of beers needed} beers.** &quot; Where **{amount of cases left/needed}** , **{amount of sixpacks left/needed}** and **{amount of beers left/needed}** represent respectively the amount of beer left/needed, represented so that **the most amount of cases are used, after which the most amount of sixpacks are used** (see the Examples to get a better idea).
### Input

The input data should be read from the console.

- On the **first line** you&#39;ll receive the **amount of reserved beers.**
- On **each of the next lines** you will be given a string representing a shipment in the format
&quot; **{amount} {type}&quot;\*** , until you receive the command &quot; **Exam Over**&quot;.
- The names will always be given in plural regardless of amount &quot; **beers**&quot;, &quot; **sixpacks**&quot;, &quot; **cases**&quot;.
- The amount and the type will be separated by exactly **one space** , there will be no leading or trailing spaces in the input.

The input data will always be valid and in the format described. There is no need to check it explicitly.

**\*HINT:** Use string.Split() to separate {amount} from {type}.

### Output

The output should be printed on the console.

- **If the amount of beer is more or equal to the amount of reserved beer:**
  - &quot;Cheers! Beer left: {amount of cases left} cases, {amount of sixpacks left} sixpacks and {amount of beers left} beers.&quot;
- **If the amount of beer is less than the amount of reserved beer:**
  - &quot;Not enough beer. Beer needed: {amount of cases needed} cases, {amount of sixpacks needed} sixpacks and {amount of beers needed} beers.&quot;
- The names must always be printed in in plural regardless of amount &quot; **beers**&quot;, &quot; **sixpacks**&quot;, &quot; **cases**&quot;.

### Constraints

- The input lines will be in the range: **[1… 100].**
- The **amount of reserved beer** , and the **amount** in a shipment will be valid integers **in the range
[0... 2,147,483,647]**.
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
|197 <br/> 1 beers <br/> 2 cases <br/> 7 sixpacks <br/> 3 beers <br/> Exam Over|Not enough beer. Beer needed: 4 cases, 1 sixpacks and 1 beers.|Amount of beers we have -> 2(cases) * 24 + 7(sixpacks) * 6 + 1 + 3 = 94 beers <br/> Since 94 is less than 197 (the reserved beer), we need 197-94 = 103 more beers <br/> 103 / 24 = 4 cases + 7 beers left <br/> 7 / 6 = 1 sixpack + 1 beer left <br/> So in the end we need 4 cases, 1 sixpack and 1 beer.|
| **Input** | **Output** | **Comments** |
|23 <br/> 11 beers <br/> 3 beers <br/> 8 cases <br/> Exam Over|Cheers! Beer left: 7 cases, 2 sixpacks and 1 beers.|Amount of beers we have -> 11 + 3 + 8(cases) * 24 = 206 beers <br/> However since every 100th beer is always broken we actually have 206 – (206 / 100) = 206 – 2 = 204 beers <br/> Since 204 is more than 23 (the reserved beer), we have 204-23 = 181 beers left <br/> 181 / 24 = 7 cases + 13 beers left <br/> 13 / 6 = 2 sixpack + 1 beer left <br/> So in the end we have 7 cases, 2 sixpacks and 1 beers left.|

## **Problem 3 – Illuminati Lock**

Hello 008, you have been tasked with assisting 007 on a top secret mission to bring down a Global Illuminati Conspiracy. You&#39;re standing in front of the final lock to the Illuminati Secret Meeting. It is a very special lock which asks you to input a specific symbol. 007 quickly guesses that the symbol has to be the Illuminati symbol, luckily for you 007 is really good at drawing triangles, what he isn&#39;t good at however is drawing eyes so he asks for your help.

You are given an integer number **N** (always odd) – the **height** of the eye is **N+1** , while the **width** is **3 \* N**

### Input

The input data should be read from the console.

- On the only input line you will be given the number **N**.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output should be printed on the console. Use the &quot; **#** &quot; (number sign) for the eye and &quot; **.** &quot; (dot) for the rest. Follow the examples below.

### Constraints

- **N** will always be a positive **odd** number in the range [**5** … **59].**
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

#### Input: 5

```
.....#####.....
...###...###...
.##..#...#..##.
.##..#...#..##.
...###...###...
.....#####.....
```

#### Input: 9

```
.........#########.........
.......###.......###.......
.....##..#.......#..##.....
...##....#.......#....##...
.##......#.......#......##.
.##......#.......#......##.
...##....#.......#....##...
.....##..#.......#..##.....
.......###.......###.......
.........#########.........
```

## **Problem 4 – Master Herbalist**

Penka is a young and aspiring herbalist, every day she gets up early and goes collecting herbs in the mountains, however the mountains are big and she only has a limited amount of time for gathering each day. At the end of the day she sells the tinctures she prepares with the herbs at the market, she repeats this process until the end of the season at which point she has to calculate the average money she made per day. Since Penka is too busy gathering herbs and doesn&#39;t want to lose time calculating she asked you to make a program which would do the calculations for her.

You will receive input from the console, on the first line you will receive a number representing Penka&#39;s **daily expenses**. On each of the next lines you will receive input in the format &quot; **\{hours} \{path} \{price}** &quot; until you receive the command &quot; **Season Over** &quot;. The **hours** in the format represents the hours Penka has for gathering herbs that day, **path** will be a string containing only capital letters representing the path through the mountains she will take and **price** represents the money she gets **for each herb sold that day** (assume Penka always sells all the herbs she gathers on the same day). Penka will traverse the **path** linearly from left to right **and each letter represents a location in the mountain which Penka will search for herbs, if the letter is &quot;** H **&quot; it means Penka found** 1 herb **, any other letter means she found** nothing **. Regardless if she finds or doesn&#39;t find anything a location will** take exactly 1 hour **to get searched. If Penka has more hours for gathering that the length of the path,** she will start again from the beginning and all the herbs will have regrown. **Upon receiving the command &quot;** Season Over **&quot; you have to calculate Penka&#39;s** average earnings **per day of the season, the average being the** total amount of money **Penka made that seasons** divided by the ****number of days** that season ( **number of days** being the number of input lines excluding the first and the last line (the line with her **daily expenses** and the line with &quot; **Season Over**&quot; respectively)). If Penka&#39;s **average earnings** per day are **more or equal to her daily expenses** print on the console &quot; **Times are good. Extra money per day: {extra money}.**&quot;where **extra money** is the difference between her **average earning** per day and her **daily expenses.** Alternatively if her **average earnings are less than her daily expenses** print &quot; **We are in the red. Money needed: {money needed}.**&quot; where **money needed** is difference between her **total expenses** (her **daily expenses** multiplied by the **number of days** in the season) and the **total amount of money** she made that season. For more details see the examples below.

### Input

The input data should be read from the console.The input will contain a random number of lines. On the first input line you will receive a number representing Penka&#39;s **daily expenses**. Each of the next lines will contain information in the following format &quot; **\{hours} \{path} \{price}** &quot;\*. The last line of the input will always be &quot; **Season Over**&quot; – signaling the end of the input.

The input data will always be valid and in the format described. There is no need to check it explicitly.

**\*HINT:** Use string.Split() to separate {hours}, {path} and {price}.

### Output

### The output should consist of only one line:

- **If Penka&#39;s average earnings are more or equal than her daily expenses print:**
  - &quot;Times are good. Extra money per day: {extra money}.&quot;
- **Alternatively if her daily expenses are more than her average earnings print:**
  - &quot;We are in the red. Money needed: {money needed}.&quot;
- The **extra money** must be rounded to two digits after the decimal point; the **money needed** must be a whole number.

### Constraints

- The **number of input lines** will be between **[3…100].**
- The elements in the input lines will be separated by a **single space** ,there will be no leading or trailing spaces.
- The **daily expenses** will be a valid integer between **[1...1000].**
- The **hours** will be between **[1…20].**
- The **path** will be a valid string containing **only capital letters** with a length between **[1…20]**.
- The **price** will be a valid integer between **[1…1000]**.
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
|250 <br/> 5 MMZHQQQQ 37 <br/> 11 ZZHHHQ 80 <br/> Season Over|Times are good. Extra money per day: 8.50.|1st day: 5 hours -> We can traverse only the first 5 letters “MMZHQ”. The string contains only 1 H thus we get only 1 herb. <br/> Money gained on day 1 => 1 * 37 = 37 <br/> 2nd day: 11 hours -> We can traverse 11 letters, but path contains only 6 so we loop back from the beginning and we get “ZZHHHQZZHHH” as the letters we traversed we have 6 H so we get 6 herbs. <br/> Money gained on day 2 => 6 * 80 = 480 <br/> Total money made = 37 + 480 = 517 <br/> Average earnings per day => 517 / 2 = 258.50 <br/> 258.50 is more than 250 so we calculate the difference 258.50 – 250 = 8.50|

| **Input** | **Output** |
|---|---|
|477 <br/> 9 QQQQQQQ 999 <br/> 2 HH 15 <br/> 6 HKKKKKKK 5 <br/> Season Over|We are in the red. Money needed: 1396.|
|133 <br/> 12 QQHWWHEEH 50 <br/> 6 HAHA 33 <br/> Season Over|Times are good. Extra money per day: 16.50.|





