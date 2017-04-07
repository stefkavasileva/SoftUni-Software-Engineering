# <p align="center"> Lab: Advanced Collections <p>
 

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions [here:](https://judge.softuni.bg/Contests/432/Advanced-Collectons-Lab)


# I.Multi-Dictionaries, Nested Dictionaries

# 1.Average Student Grades

Write a program, which reads the **name** of a student and their **grades** and **adds** them to the **student record** , then **prints** **grades** along with their **average grade**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 7 <br/> Ivancho 5.20 <br/> Mariika 5.50 <br/> Ivancho 3.20 <br/> Mariika 2.50 <br/> Stamat 2.00 <br/> Mariika 3.46 <br/> Stamat 3.00 | Ivancho -&gt; 5.20 3.20 (avg: 4.20) <br/> Mariika -&gt; 5.50 2.50 3.46 (avg: 3.82) <br/> Stamat -&gt; 2.00 3.00 (avg: 2.50) |
| 4 <br/> Vladimir 4.50 <br/> Petko 3.00 <br/> Vladimir 5.00 <br/> Petko 3.66 <br/> Ivan 4.33 | Vladimir -&gt; 4.50 5.00 (avg: 4.75) <br/> Petko -&gt; 3.00 3.66 (avg: 3.33) |
| 5 <br/> Gosho 6.00 <br/> Gosho 5.50 <br/> Gosho 6.00 <br/> Ivan 4.40 <br/> Petko 3.30 <br/> Petko 4.50 | Gosho -&gt; 6.00 5.50 6.00 (avg: 5.83) <br/> Ivan -&gt; 4.40 (avg: 4.40) <br/> Petko -&gt; 3.30 (avg: 3.30) |

> ### Hints

> - Use a **dictionary** ( **string**** List&lt;double&gt;**)
> - Check if the name exists before adding the grade. If it doesn&#39;t, add it to the dictionary.
> - Pass through all **key-value pairs** in the dictionary and print the results. You can use the **.Average()** method to quickly calculate the average value from a list.

# 2.Cities by Continent and Country

Write a program to read **continents** , **countries** and their **cities** , put them in a **nested dictionary** and **print** them.

### Examples

| **Input** | **Output** |
| --- | --- |
| 9 <br/> Europe Bulgaria Sofia <br/> Asia China Beijing <br/> Asia Japan Tokyo <br/> Europe Poland Warsaw <br/> Europe Germany Berlin <br/> Europe Poland Poznan <br/> Europe Bulgaria Plovdiv <br/> Africa Nigeria Abuja <br/> Asia China Shanghai | Europe:  <br/> &nbsp;&nbsp;&nbsp;&nbsp; Bulgaria -&gt; Sofia, Plovdiv <br/>  &nbsp;&nbsp;&nbsp;&nbsp; Poland -&gt; Warsaw, Poznan <br/> &nbsp;&nbsp;&nbsp;&nbsp; Germany -&gt; Berlin <br/> Asia: <br/> &nbsp;&nbsp;&nbsp;&nbsp; China -&gt; Beijing, Shanghai <br/> &nbsp;&nbsp;&nbsp;&nbsp; Japan -&gt; Tokyo <br/> Africa: <br/> &nbsp;&nbsp;&nbsp;&nbsp;  Nigeria -&gt; Abuja |
| 3 <br/> Europe Germany Berlin <br/> Europe Bulgaria Varna <br/> Africa Egypt Cairo | Europe: <br/> &nbsp;&nbsp;&nbsp;&nbsp; Germany -&gt; Berlin <br/> &nbsp;&nbsp;&nbsp;&nbsp;  Bulgaria -&gt; Varna <br/> Africa:<br/> &nbsp;&nbsp;&nbsp;&nbsp;  Egypt -&gt; Cairo |
| 8 <br/> Africa Somalia Mogadishu <br/> Asia India Mumbai <br/> Asia India Delhi <br/> Europe France Paris <br/> Asia India Nagpur <br/> Europe Germany Hamburg <br/> Europe Poland Gdansk <br/> Europe Germany Danzig | Africa: <br/> &nbsp;&nbsp;&nbsp;&nbsp;  Somalia -&gt; Mogadishu <br/> Asia: <br/> &nbsp;&nbsp;&nbsp;&nbsp;  India -&gt; Mumbai, Delhi, Nagpur <br/> Europe: <br/> &nbsp;&nbsp;&nbsp;&nbsp; France -&gt; Paris <br/> &nbsp;&nbsp;&nbsp;&nbsp; Germany -&gt; Hamburg, Danzig <br/> &nbsp;&nbsp;&nbsp;&nbsp;  Poland -&gt; Gdansk |

> ### Hints
> 
> - Use a **nested** **dictionary** (**string** (**Dictionary** **List&lt;string&gt;** **)**)
> - Check if the continent exists before adding the country. If it doesn&#39;t, add it to the dictionary.
> - Check if the country exists, before adding the city. If it doesn&#39;t, add it to the dictionary.
> - Pass through all **key-value pairs** in the dictionary and the values&#39; key-value pairs and print the results.


# II.Sets

# 3.Record Unique Names

Write a program, which will take a list of **names** and print **only** the **unique** names in the list.

### Examples

| **Input** | **Output** |   
| --- | --- | 
| 8 <br/> Ivan <br/> Pesho <br/> Ivan <br/> Stamat <br/> Pesho <br/> Alice <br/> Peter <br/> Pesho | Ivan <br/> Pesho <br/> Stamat <br/> Alice <br/> Peter | 
| 7 <br/> Lyle <br/> Bruce <br/> Alice <br/> Easton <br/> Shawn <br/> Alice <br/> Shawn <br/> Peter | Lyle <br/> Bruce <br/> Alice <br/> Easton <br/> Shawn |   
| 6 <br/> Roki <br/> Roki <br/> Roki <br/> Roki <br/> Roki <br/> Roki | Roki |

> ### Hints

> You can store the names in a **HashSet&lt;string&gt;** to extract only the unique ones.

# 4.Group Continents, Countries and Cities

Write a program, which receives **continents** , **countries** and **city names** and **prints them** , grouped by continent, country and city, all in **alphabetical order**. No duplicates are allowed.

### Examples

| **Input** | **Output** |
| --- | --- |
| 9 <br/> Europe Bulgaria Sofia <br/> Asia China Beijing <br/> Europe Bulgaria Sofia <br/> Europe Poland Warsaw <br/> Europe Germany Berlin <br/> Europe Poland Poznan <br/> Europe Poland Warsaw <br/> Asia China Beijing <br/> Asia China Shanghai | Asia: <br/> &nbsp;&nbsp;&nbsp;&nbsp;    China -&gt; Beijing, Shanghai <br/> Europe: <br/> &nbsp;&nbsp;&nbsp;&nbsp;    Bulgaria -&gt; Sofia  <br/> &nbsp;&nbsp;&nbsp;&nbsp;   Germany -&gt; Berlin  <br/> &nbsp;&nbsp;&nbsp;&nbsp;   Poland -&gt; Poznan, Warsaw |
| 7 <br/> Europe Bulgaria Sofia <br/> Europe Bulgaria Sofia <br/> Europe Bulgaria Plovdiv <br/> Europe Bulgaria Sofia <br/> Asia China Beijing <br/> Asia India Mumbai <br/> Europe Turkey Istanbul | Asia: <br/> &nbsp;&nbsp;&nbsp;&nbsp;    China -&gt; Beijing  <br/> &nbsp;&nbsp;&nbsp;&nbsp;   India -&gt; Mumbai <br/> Europe: <br/> &nbsp;&nbsp;&nbsp;&nbsp;    Bulgaria -&gt; Plovdiv, Sofia  <br/> &nbsp;&nbsp;&nbsp;&nbsp;   Turkey -&gt; Istanbul |
| 10 <br/> Europe Turkey Ankara <br/> Asia China Shenyang <br/> Asia India Delhi <br/> Asia India PuneAsia Japan Yokohama <br/> Asia China Suzhou <br/> Europe Russia Moscow <br/> Europe Turkey Ankara <br/> Asia Japan Tokyo <br/> Asia India Pune  | Asia: <br/> &nbsp;&nbsp;&nbsp;&nbsp;    China -&gt; Shenyang, Suzhou <br/> &nbsp;&nbsp;&nbsp;&nbsp;    India -&gt; Delhi, Pune  <br/> &nbsp;&nbsp;&nbsp;&nbsp;   Japan -&gt; Tokyo, Yokohama <br/> Europe: <br/> &nbsp;&nbsp;&nbsp;&nbsp;    Russia -&gt; Moscow  <br/> &nbsp;&nbsp;&nbsp;&nbsp;   Turkey -&gt; Ankara |

> ### Hints

> - Since everything needs to be sorted and unique, you can use a **SortedDictionary&lt;string, SortedDictionary&lt;string, SortedSet&lt;string&gt;&gt;&gt;**. That way, since we&#39;re using **dictionaries** , we **won&#39;t have** any **duplicated** **continents** or **countries**.
> - By using a **SortedSet** to store the city names, we ensure we **won&#39;t have** any **repeating** cities. Since everything is sorted, the alphabetical order is taken care of.