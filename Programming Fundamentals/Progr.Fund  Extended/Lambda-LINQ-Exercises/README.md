# <p align="center"> Lambda and LINQ - Exercises <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions here: [https://judge.softuni.bg/Contests/435](https://judge.softuni.bg/Contests/435).

## Registered Users

You will be given several usernames and dates of registry, in the following format:

\{username} -&gt; \{date}

The **username** will be a **string** and the **date** will be a valid date in format &quot; **dd/MM/yyyy**&quot;.

You must read input lines until you receive the command &quot; **end**&quot;.

You need to store every user, with his date of registry. Then you must print the **LAST 5** registered names, or in other words the **OLDEST** registered users, in **order of registry** – from the **latest registered,** to the **oldest registered**.

If there are **LESS** than **5** people, print **them** in the **order** , **specified above**.
if any entries have the **SAME date** , print the **LAST** entered one, **FIRST** , and then the other (in **input** ).

#### Examples

| **Input** | **Output** |
| --- | --- |
| John27 -&gt; 12/02/2004 <br/> 7H3D347H -&gt; 15/09/2015 <br/> Bojo96 -&gt; 15/09/2015 <br/> Sanity -&gt; 04/05/2015 <br/> Innos -&gt; 04/05/2015 <br/> Nakov -&gt; 01/01/2013 <br/> Danny -&gt; 04/04/2016 <br/> Yori -&gt; 29/02/2016 <br/> end | Bojo96 <br/> Innos <br/> Sanity <br/> Nakov <br/> John27 |
| Danny -&gt; 04/04/2016 <br/> Innos -&gt; 04/05/2015 <br/> Sanity -&gt; 04/05/2015 <br/> Nakov -&gt; 01/01/2013 <br/> end | Danny <br/> Sanity <br/> Innos <br/> Nakov  |

> #### Hints
> - Use the **ParseExact()** method. The method **accepts** a **string** (the **input data** ), a **date format** , and **CultureInfo**.
> - For **CultureInfo** , use **InvariantCulture**.

## 2.Default Values

You will be given several key-value pairs in the following format: **{key} -&gt; {value}**

Your task is to store all those pairs, until you receive the command &quot; **end**&quot;. When you receive the ending command, you must read **one last line** , containing the **default value**. Then you must change all values, which are equal to &quot; **null**&quot; with the **given default value**.

At the **end** you must print **all key-value pairs** , which have **NOT** been **replaced** with the **default value** , in **descending** order, by their **value&#39;s length**.

**After** them, you must print **all key-value** pairs which **HAVE been replaced** with the **default value** , in **order of input**.

Each key-value pair, must be printed in the following format:<br/>  **\{key} &lt;-&gt; \{value}**

**All variables in the program logic are**  **strings**.

**Note**: If you receive the  **same key twice**  or **more times**, you should  **update**  its value  **everytime**.

#### Examples

| **Input** | **Output** |
| --- | --- |
| What -&gt; null  <br/> How -&gt; null <br/> To -&gt; Do <br/> This -&gt; null <br/> Correctly -&gt; null <br/> end <br/> welp | To &lt;-&gt; Do <br/> What &lt;-&gt; welp <br/> How &lt;-&gt; welp <br/> This &lt;-&gt; welp <br/> Correctly &lt;-&gt; welp  |
| This -&gt; Input <br/> Will -&gt; Be <br/> Sorted -&gt; null <br/> By -&gt; Descending <br/> Order -&gt; null <br/> end <br/> sortorder | By &lt;-&gt; Descending <br/> This &lt;-&gt; Input <br/> Will &lt;-&gt; Be <br/> Sorted &lt;-&gt; sortorder <br/> Order &lt;-&gt; sortorder |

## 3.Flatten Dictionary

You will be given several input lines containing info about a **key** , an **inner key** and **inner value** , **separated** by a **SPACE**.

Your task is to store every inner key and inner value, in every key&#39;s value. Check the Examples for more info.

If you receive the command &quot; **flatten** **\{key} **&quot;, you must** flatten **all the** inner ****keys** and **inner**** values **at the** given key **, or in other words,** CONCATENATE** them.

When you receive the command &quot; **end**&quot; the **input ends**. You must print all **keys** and their **inner-keys** and **inner-values**. **Flattened**** inner keys **and** inner values **, must be printed** AFTER all else.

The **keys** must be printed in **descending order** of their **length**.

All **inner-keys** must be printed in **ascending order** of their **length**.

Flattened Values must be printed in **order of input**.

The format of printing is:                                                                  Flattened values should be printed like this

{key}                                        {key}

1. {innerKey} – {innerValue}                 . . .

2. {innerKey} – {innerValue}                 x. {flattenedValue}

3. {innerKey} – {innerValue}                 (x+1). {innerKey} – {innerValue}

. . .                                        . . .

If you receive an **inner** key **that already** exists **,** replace **its value with the** new given one.

#### Examples

| **Input** | **Output** |
| --- | --- |
| Cars Opel Astra <br/> Cars Opel Vectra <br/> Laptops Lenovo T500 <br/> Cars BMW X6 <br/> Laptops Acer Aspire <br/> Cars Audi Q7 <br/> end | Laptops <br/> 1. Acer - Aspire <br/> 2. Lenovo - T500 <br/> Cars <br/> 1. BMW - X6 <br/> 2. Opel - Vectra <br/> 3. Audi - Q7 |
| TV Samsung Home <br/> TV Sony Office <br/> TV Samsung Office <br/> Default Get Set <br/> Default Set Get <br/> flatten TV <br/> TV Lenovo General <br/> TV Samsung Home <br/> end | Default <br/> 1. Get - Set <br/> 2. Set - Get <br/> TV <br/> 1. Lenovo - General <br/> 2. Samsung - Home <br/> 3. SamsungOffice <br/> 4. SonyOffice |

## 4.CottageScraper \*

You&#39;re a carpenter at the local woodworking shop. Your client wants you to build a wooden skyscraper/cottage. A **CottageScraper** , he calls it. But in order to accomplish this task, he needs the trees to be **taller** than a **certain height**. The problem is that he **doesn&#39;t know** what type of tree he&#39;ll use yet, and doesn&#39;t know **how tall** he wants to make the CottageScraper yet. You&#39;ve obviously got nothing better to do, so you go to work chopping down logs until he calls you with the details.

Write a program which receives tree **types** and their **lengths** in the format &quot; **{type} -&gt; {height}**&quot;. When you receive the command &quot; **chop**** chop**&quot;, it&#39;s time to get paid.

On the next line, you will receive the **type**** of tree **that needs to be used to build the** CottageScraper **. On the final input line, you will receive the** minimum length per tree **, needed to accomplish the task. Filter the trees based on type and minimum length, making sure that you&#39;ll only use the trees of the specified** type **and** minimum length**.

After which, calculate the **total price** of the **CottageScraper** , which includes the price of all the trees you collected up to that point. The price is calculated as being the **average** meters of **all**** logs **you collected, per** meter **of log,** rounded to the second decimal place**.

You&#39;re going to charge the client **100%** of the **price per log** for logs you&#39;ll use in the skyscraper, and **25%** of the price per log for logs you **won&#39;t** use for the **CottageScraper**. Both of the fees are **rounded to the second decimal place**.

After you make the calculations, **print** them on the console. On the first line of the console, print &quot; **Price per meter: $\{pricePerMeter:F2}** &quot;. On the second, print &quot; **Used logs price: ${usedLogsPrice:F2}** &quot;. On the third line, print &quot; **Unused logs price: $\{unusedLogsPrice:F2}** &quot;.

On the final line of the output, print &quot; **CottageScraper subtotal: ${subTotal:F2}** &quot;.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| Maple -&gt; 20 <br/> Oak -&gt; 12 <br/> Poplar -&gt; 25 <br/> Maple -&gt; 33 <br/> Poplar -&gt; 11 <br/> Poplar -&gt; 30 <br/> chop chop <br/> Poplar <br/> 12 | Price per meter: $21.83 <br/> Used logs price: $1200.65 <br/> Unused logs price: $414.77 <br/> CottageScraper subtotal: $1615.42 | Needed type: PoplarNeeded height: at least 12m Price per meter == (sum of all logs) / (count) == 21.83 <br/>  Used logs (taller than 12m): Poplar -&gt; 25, 30 Used logs price: (25 + 30) \* 21.83 = **$1200.65**   <br/> Unused logs: Maple -&gt; 20, 33; Oak -&gt; 12; Poplar -&gt; 11 <br/> Unused logs price: (20 + 33 + 12 + 11) \* 21.83 \* 0.25 = **$414.77**  <br/>  Used + unused logs price: 1200.65 + 414.77 = **$1615.42** |
| Cherry -&gt; 918O <br/> ak -&gt; 112 <br/> Maple -&gt; 1423 <br/> Maple -&gt; 9118 <br/> Poplar -&gt; 122O <br/> ak -&gt; 232 <br/> chop chop <br/> Maple <br/> 250 | Price per meter: $1987.50 <br/> Used logs price: $20950237.50 <br/> Unused logs price: $687675.00 <br/> CottageScraper subtotal: $21637912.50 | Needed type: MapleNeeded height: at least 250m  <br/> Price per meter = 918 + 112 + 1423 + 9118 + 122 + 232 / 6 = **$1987.50**   <br/> Used logs (taller than 250m): Maple -&gt; 1423, 9118  <br/> Used logs price: (1423 + 9118) \* 1987.50 = **$20950237.50**  <br/>  Unused logs: Cherry -&gt; 918, Oak -&gt; 112, 232, Poplar -&gt; 122 <br/>  Unused logs price: (918+ 112+ 232+ 122) \* $1987.50 \* 0.25 = **$687675.00**  <br/>  Used + unused logs price: **$21637912.50** |
| Apple -&gt; 218 <br/> Pear -&gt; 112 <br/> Apple -&gt; 123 <br/> Apple -&gt; 118 <br/> Pear -&gt; 122 <br/> Cherry -&gt; 232 <br/> chop chop <br/> Apple <br/> 120 | Price per log: $154.00 <br/> Used logs price: $52514.00 <br/> Unused logs price: $22484.00 <br/> CottageScraper subtotal: $74998.00 |   |

> #### Hints
> - In order to flatten the dictionary&#39;s values (in order to calculate the price per log), you can use the LINQ **.SelectMany()** method.
> - The unused logs include not only the logs from different types than needed, but also the logs whose height was **lower** than the minimum height.