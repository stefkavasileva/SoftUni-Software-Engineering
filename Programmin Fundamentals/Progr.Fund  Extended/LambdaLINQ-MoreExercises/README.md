# <p align="center"> Lambda and LINQ - More Exercises <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions here: [https://judge.softuni.bg/Contests/436](https://judge.softuni.bg/Contests/436).

## 1.Lambada Expressions

IT Researchers at the MIT (Massachusetts Institute of Technology) have discovered that, at certain (room) temperatures, the lambda expressions in their code are acting strange. In particular, a dancing behavior has been observed in them. The specialists choose to call this phenomenon – The Lambada expressions.

You will be given several input lines in the following format: <br/>

**\{selector} =&gt; \{selectorObject}.\{property}**

All elements of the input are **strings**. You need to store every **lambada expression** , as it is **given**.

In some rare cases you will receive the input &quot; **dance**&quot;, which indicates that the lambada expressions are starting to dance. When that happens, you must **COPY** the **selectorObject**  **ONCE** with a dot(&quot;.&quot;) between **it., so that it becomes &quot;** {selectorObject}.{selectorObject}&quot;

in **every** lambada expression&#39;s **condition**.
In other words, if you have &quot; **x =&gt; x.Value**&quot;, and you say &quot; **dance**&quot;, you should get &quot; **x =&gt; x.x.Value**&quot;.

Check the examples for more info.

If you meet a **selectorObject** which already, you must **replace** its **property** with the **given new one**.

When you receive the command &quot; **lambada**&quot; you must end the input sequence. When that happens, you must print all **lambada expressions**.

#### Examples

| **Input** | **Output** |
| --- | --- |
| x =&gt; x.Key <br/> object =&gt; object.Property <br/> entry =&gt; entry.Name <br/> lambada | x =&gt; x.Key <br/> object =&gt; object.Property <br/> entry =&gt; entry.Name |
| x =&gt; x.Key <br/> x =&gt; x.Value <br/> x =&gt; x.Name <br/> dance <br/> dance <br/> dance <br/> lambada | x =&gt; x.x.x.x.Name |

## 2.Ordered Banking System

You have been given the task to write software for banking – in particular, an optimized program, which stores only the bank account&#39;s name, the bank account&#39;s balance and the bank it is stored at.

You will be given several input lines in the following format:

{bank} -&gt; {account} -&gt; {balance}

The **bank** and the **account** are **strings** , and the **balance** is a **VARIABLE TYPE** which is **SUITABLE** for storing **MONEY**.

You should store every bank, each of its accounts, and their balances.

If you are given a **bank** which **already exists** , you must **ADD** the **new account** to it.
If **EVEN** the **account** which **already exists** , you must **INCREASE** the **old balance** , with the new **given one**.

When you receive the command &quot; **end**&quot;, you must end the input sequence. Then you must print the data in a specified ordered format.

You must print each bank&#39;s accounts and balances, ordering the **BANKS** by the **sum** of **all account balances** , in **descending order**. If **2 banks** have the **same sum** , you should print the **one** with the **highest maximum balance** in its **accounts** , **first**.

The **bank&#39;s accounts** must be ordered in **descending order** , by **their balance**.

The balances, must be printed, as they are given. &quot; **500**&quot; = &quot; **500**&quot; … &quot; **500.00**&quot; = &quot; **500.00**&quot;.

#### Examples

| **Input** | **Output** |
| --- | --- |
| RaifaizenBank -&gt; Toshko -&gt; 200.4456 <br/> DSK -&gt; Toshko -&gt; 500.00 <br/> PIB -&gt; Ivan -&gt; 400.521 <br/> Piraeus -&gt; Ivan -&gt; 212.345 <br/> end | Toshko -&gt; 500.00 (DSK) <br/> Ivan -&gt; 400.521 (PIB) <br/> Ivan -&gt; 212.345 (Piraeus) <br/> Toshko -&gt; 200.4456 (RaifaizenBank) |
| DSK -&gt; Tesla -&gt; 2015125.45623 <br/> DSK -&gt; Tesla -&gt; 2000000 <br/> DSK -&gt; Microsoft -&gt; 400000 <br/> DSK -&gt; Apple -&gt; 200000 <br/> DSK -&gt; Microsoft -&gt; 350000 <br/> DSK -&gt; Apple -&gt; 550000 <br/> end | Tesla -&gt; 4015125.45623 (DSK) <br/> Microsoft -&gt; 750000 (DSK) <br/> Apple -&gt; 750000 (DSK) |

## 3.LINQuistics

LINQ is the greatest .NET component of all time. You can do almost anything with it. That&#39;s why you have been tasked to do almost everything you can with it.

You will be given several input lines containing information about collections, and LINQ methods that have been called on them, in the following format:

**\{collection}.\{method1}().\{method2}(). . .**

The **count** of **methods** , may **vary**. Your task is to store every collection and the methods that have been executed on them. If the collection already exists, you must **ADD** the new methods to it. **Duplicate** methods should be **REMOVED**.

If you are given a **collection name ONLY** , you must print the **methods** that have been executed on the collection, in **descending order** by their **length**. If **2 methods** have the **same length** , **order** them in **descending order** , by the **count** of **unique symbols** they have in **their names**. The methods must be printed – **each** on a **new line** , with an **asterisk** (&quot;\*&quot;) and a **space** (&quot;&quot;) **prefix**.
If the collection name does **NOT** exist, you should **IGNORE** that line of input.

If you are given a **digit** ONLY **, you must take the collection, with the most methods, and print the** first N methods **, with the** LOWEST ****length** ( **N** being the **digit**** given **from the** input). If there are**less **than** N **methods you must print** all **of them, in the** same order**.

**NOTE** : When printing, you must print **only** the **method name** , without its brackets.

The input sequence ends when you receive the command &quot; **exit**&quot;. After the ending command, you will receive one last line in the following format:
{method} {selection}

You must **take all** collections, which **CONTAIN** the **given method** , and print them. The selection will either be &quot; **collection**&quot; or &quot; **all**&quot;.
If you have &quot;collection&quot;, you must print only the collections&#39; names in the final output.
If you have &quot;all&quot;, you must print the collections and their methods in the following format:

&quot;\{collection} <br/> 
 \* \{method1} <br/> 
 \* \{method2} <br/> 
 . . .&quot;

The collections, must be printed in **descending order** , by the **count of methods**. If **2 collections** have the **same**** count **, print the** one **with the** higher ****MINIMAL method length** , first. The **methods** must be printed in **descending order** by their **length**.

#### Examples

| **Input** | **Output** |
| --- | --- |
| participants.Max().Reverse().ThenBy() <br/> participants.OrderBy.Select() <br/> participants <br/> participants.ToDictionary()collection.Max() <br/> collection.Break()exit <br/> Max all | \* OrderBy <br/> \* Reverse <br/> \* ThenBy <br/> \* Select <br/> \* Max <br/> participants <br/> \* ToDictionary <br/> \* Reverse <br/> \* OrderBy <br/> \* ThenBy <br/> \* Select <br/> \* Max <br/> collection <br/> \* Break<br/> \* Max |
| elements.Sort() <br/> elements.OrderBy() <br/> bound <br/> elements.Reverse().Select().ThenBy() <br/> keys.Reverse().OrderByDescending()<br/> keys.Reverse().ThenByDescending() <br/> 3 <br/> keys.Reverse().OrderBy().ThenBy() <br/> values.ToString().ToString().ThenBy() <br/> exit <br/> Reverse collection | \* Sort <br/> \* Select <br/> \* ThenBy <br/> keys <br/> elements |