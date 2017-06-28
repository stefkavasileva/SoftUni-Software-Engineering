# <p align="center">Exercises:  Defining Classes </p>

This document defines the **exercise assignments** for the [&quot;CSharp OOP Basics&quot; course @ Software University](https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/).

## Problem 1.Define a class Person

Define a class **Person** with **public** fields for **name** and **age**.

#### Note

Add the following code to your main method and submit it to Judge.

```csharp
static void Main(string[] args)
{
    Type personType = typeof (Person);
    FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);    
    Console.WriteLine(fields.Length);
}

```

If you defined the class correctly, the test should pass.

### Bonus\*

Try to create a few objects of type Person:

| **Name** | **Age** |
| --- | --- |
| Pesho | 20 |
| Gosho | 18 |
| Stamat | 43 |

Use both the inline initialization and the default constructor. Your fields should be **public** , otherwise you won&#39;t see them.

## Problem 2.Creating Constructors

Add 3 constructors to the **Person** class from the last task, use constructor chaining to reuse code:

1. The first should take no arguments and produce a person with name &quot; **No name**&quot; and age = **1**.
2. The second should accept only an integer number for the age and produce a person with name &quot; **No name**&quot; and age equal to the passed parameter.
3. The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.

Add the following code to your main method and submit it to Judge.

```csharp
Type personType = typeof(Person);
ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
bool swapped = false;
if (nameAgeCtor == null)
{
    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
    swapped = true;
}

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) :(Person)nameAgeCtor.Invoke(new object[] { name, age });

Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

```

If you defined the constructors correctly, the test should pass.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho <br/> 20 | No name 1 <br/> No name 20 <br/> Pesho 20 |
| Gosho <br/> 18 | No name 1 <br/> No name 18 <br/> Gosho 18 |
| Stamat <br/> 43| No name 1 <br/> No name 43 <br/> Stamat 43 |

## Problem 3.Opinion Poll

Using the Person class, write a program that reads from the console **N** lines of personal information and then prints all people whose **age** is **more than 30** years, **sorted in alphabetical order**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 <br/> Pesho 12 <br/> Stamat 31 <br/> Ivan 48 | Ivan - 48 <br/> Stamat - 31 |
| 5 <br/> Nikolai 33 <br/> Yordan 88 <br/> Tosho 22 <br/> Lyubo 44 <br/> Stanislav 11 | Lyubo - 44 <br/> Nikolai - 33 <br/> Yordan - 88 |

## Problem 4.Company Roster

Define a class **Employee** that holds the following information: **name, salary, position, department, email** and **age**. The **name, salary** , **position** and **department** are **mandatory** while the rest are **optional**.

Your task is to write a program which takes **N** lines of employees from the console and calculates the department with the highest average salary and prints for each employee in that department his **name, salary, email and age** – **sorted by salary in descending order**. If an employee **doesn&#39;t have** an **email** – in place of that field you should print &quot; **n/a**&quot; instead, if he doesn&#39;t have an **age** – print &quot; **-1**&quot; instead. The **salary** should be printed to **two decimal places** after the seperator.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4 <br/> Pesho 120.00 Dev Development pesho@abv.bg 28 <br/> Toncho 333.33 Manager Marketing 33 <br/> Ivan 840.20 ProjectLeader Development ivan@ivan.com <br/> Gosho 0.20 Freeloader Nowhere 18 | Highest Average Salary: Development <br/> Ivan 840.20 ivan@ivan.com -1 <br/> Pesho 120.00 pesho@abv.bg 28 |
| 6 <br/> Stanimir 496.37 Temp Coding stancho@yahoo.com <br/> Yovcho 610.13 Manager Sales <br/> Toshko 609.99 Manager Sales toshko@abv.bg 44 <br/> Venci 0.02 Director BeerDrinking beer@beer.br 23 <br/> Andrei 700.00 Director CodingPopeye 13.3333 Sailor SpinachGroup popeye@pop.ey | Highest Average Salary: Sales <br/> Yovcho 610.13 n/a -1 <br/> Toshko 609.99 toshko@abv.bg 44 |

## Problem 5.\*Speed Racing

Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class **Car** that keeps track of a car&#39;s **Model, fuel amount, fuel cost for 1 kilometer** and **distance traveled**. A Car&#39;s Model is **unique** - there will never be 2 cars with the same model.

On the first line of the input you will receive a number **N** – the number of cars you need to track, on each of the next **N** lines you will receive information for a car in the following format &quot;&lt; **Model&gt; &lt;FuelAmount&gt; &lt;FuelCostFor1km&gt;** &quot;, all **cars start at 0 kilometers traveled**.

After the **N** lines until the command &quot; **End**&quot; is received, you will receive a commands in the following format &quot; **Drive &lt;CarModel&gt;  &lt;amountOfKm&gt;** &quot;, implement a method in the **Car** class to calculate whether or not a car can move that distance, if it can the car&#39;s **fuel amount** should be **reduced** by the amount of used fuel and its **distance traveled** should be increased by the amount of kilometers traveled, otherwise the car should not move (Its fuel amount and distance traveled should stay the same) and you should print on the console &quot; **Insufficient fuel for the drive**&quot;. After the &quot; **End**&quot; command is received, print each car and its current fuel amount and distance traveled in the format &quot; **&lt;Model&gt; &lt;fuelAmount&gt;  &lt;distanceTraveled&gt;** &quot;, where the fuel amount should be printed to **two decimal places** after the separator.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 <br/> AudiA4 23 0.3B <br/> MW-M2 45 0.42 <br/> Drive BMW-M2 56 <br/> Drive AudiA4 5 <br/> Drive AudiA4 13 <br/> End | AudiA4 17.60 18 <br/> BMW-M2 21.48 56 |
| 3 <br/> AudiA4 18 0.34 <br/> BMW-M2 33 0.41 <br/> Ferrari-488Spider 50 0.47 <br/> Drive Ferrari-488 <br/> Spider 97 <br/> Drive Ferrari-488 <br/> Spider 35 <br/> Drive AudiA4 85 <br/> Drive AudiA4 50 <br/> End | Insufficient fuel for the drive <br/> Insufficient fuel for the drive <br/> AudiA4 1.00 50 <br/> BMW-M2 33.00 0 <br/> Ferrari-488 <br/> Spider 4.41 97 |

## Problem 6.\*Raw Data

You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a class **Car** that holds information about **model, engine, cargo** and a **collection of exactly 4 tires**. The engine, cargo and tire **should be separate classes** , create a constructor that receives all information about the Car and creates and initializes its inner components (engine, cargo and tires).

On the first line of input you will receive a number **N** - the amount of cars you have, on each of the next **N** lines you will receive information about a car in the format &quot; **&lt;Model&gt; &lt;EngineSpeed&gt; &lt;EnginePower&gt; &lt;CargoWeight&gt; &lt;CargoType&gt; &lt;Tire1Pressure&gt; &lt;Tire1Age&gt; &lt;Tire2Pressure&gt; &lt;Tire2Age&gt; &lt;Tire3Pressure&gt; &lt;Tire3Age&gt; &lt;Tire4Pressure&gt; &lt;Tire4Age&gt;&quot;** where the speed, power, weight and tire age are **integers** , tire pressure is a **double.**

After the **N** lines you will receive a single line with one of 2 commands &quot; **fragile**&quot; or &quot; **flamable**&quot; , if the command is &quot; **fragile**&quot; print all cars whose **Cargo Type is &quot;fragile&quot;** with a tire whose **pressure is**   **&lt; 1** , if the command is &quot; **flamable**&quot; print all cars whose **Cargo Type is &quot;flamable&quot;** and have **Engine Power &gt; 250**. The cars should be printed in order of appearing in the input.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 <br/> ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4 <br/> Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1 <br/> fragile | Citroen2CV |
| 4 <br/> ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1 <br/> ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1 <br/> DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1 <br/> Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2 <br/> flamable | ChevroletExpress <br/> DaciaDokker |

## Problem 7.Car Salesman

Define two classes **Car** and **Engine.** A **Car** has a **model, engine, weight** and **color**. An Engine has **model** , **power, displacement** and **efficiency**. A Car&#39;s **weight** and **color** and its Engine&#39;s **displacements** and **efficiency** are **optional**.

On the first line you will read a number **N** which will specify how many lines of engines you will receive, on each of the next **N** lines you will receive information about an **Engine** in the following format &quot;&lt; **Model&gt; &lt;Power&gt; &lt;Displacement&gt; &lt;Efficiency&gt;** &quot;. After the lines with engines, on the next line you will receive a number **M** – specifying the number of Cars that will follow, on each of the next **M** lines information about a **Car** will follow in the following format &quot;&lt; **Model&gt; &lt;Engine&gt; &lt;Weight&gt; &lt;Color&gt;** &quot;, where the engine in the format will be the **model of an existing**** Engine **. When creating the object for a** Car **, you should keep a** reference to the real engine **in it, instead of just the engine&#39;s model, note that the optional properties** might be missing from the formats.

Your task is to print each car (in the order you received them) and its information in the format defined bellow, if any of the optional fields has not been given print &quot; **n/a**&quot; in its place instead:

```
<CarModel>:
  <EngineModel>:
    Power: <EnginePower>
    Displacement: <EngineDisplacement>
    Efficiency: <EngineEfficiency>
  Weight: <CarWeight&gt>
  Color: <CarColor&gt>
```
### Bonus\*

Override the classes&#39;s ToString() methods to have a reusable way of displaying the objects.

### Examples

| **Input** | **Output** |
| --- | --- |
|2 <br/> V8-101 220 50 <br/> V4-33 140 28 B <br/> 3 <br/> FordFocus V4-33 1300 Silver <br/> FordMustang V8-101 <br/> VolkswagenGolf V4-33 Orange |FordFocus: <br/> &nbsp;&nbsp;V4-33: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 140 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: 28 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: B <br/> &nbsp;&nbsp;Weight: 1300 <br/> &nbsp;&nbsp;Color: Silver <br/> FordMustang: <br/> &nbsp;&nbsp;V8-101: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 220 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: 50 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: n/a <br/> &nbsp;&nbsp;Weight: n/a <br/> &nbsp;&nbsp;Color: n/a <br/> VolkswagenGolf: <br/> &nbsp;&nbsp;V4-33: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 140 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: 28 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: B <br/> &nbsp;&nbsp;Weight: n/a <br/> &nbsp;&nbsp;Color: Orange|
|4 <br/> DSL-10 280 B <br/> V7-55 200 35 <br/> DSL-13 305 55 A+ <br/> V7-54 190 30 D <br/> 4 <br/> FordMondeo DSL-13 Purple <br/> VolkswagenPolo V7-54 1200 Yellow <br/> VolkswagenPassat DSL-10 1375 Blue <br/> FordFusion DSL-13|FordMondeo: <br/> &nbsp;&nbsp;DSL-13: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 305 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: 55 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: A+ <br/> &nbsp;&nbsp;Weight: n/a <br/> &nbsp;&nbsp;Color: Purple <br/> VolkswagenPolo: <br/> &nbsp;&nbsp;V7-54: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 190 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: 30 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: D <br/> &nbsp;&nbsp;Weight: 1200 <br/> &nbsp;&nbsp;Color: Yellow <br/> VolkswagenPassat: <br/> &nbsp;&nbsp;DSL-10: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 280 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: n/a <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: B <br/> &nbsp;&nbsp;Weight: 1375 <br/> &nbsp;&nbsp;Color: Blue <br/> FordFusion: <br/> &nbsp;&nbsp;DSL-13: <br/> &nbsp;&nbsp;&nbsp;&nbsp;Power: 305 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Displacement: 55 <br/> &nbsp;&nbsp;&nbsp;&nbsp;Efficiency: A+ <br/> &nbsp;&nbsp;Weight: n/a <br/> &nbsp;&nbsp;Color: n/a|

## Problem 8.Pokemon Trainer

You wanna be the very best pokemon trainer, like no one ever was, so you set out to catch pokemon. Define a class **Trainer** and a class **Pokemon**. Trainers have a **name** , **number of badges** and a **collection of pokemon** , **Pokemon** have a **name** , an **element** and **health** , all values are **mandatory**. Every Trainer **starts with 0 badges**.

From the console you will receive an unknown number of lines until you receive the command &quot; **Tournament**&quot;, each line will carry information about a pokemon and the trainer who caught it in the format &quot;&lt; **TrainerName&gt; &lt;PokemonName&gt; &lt;PokemonElement&gt; &lt;PokemonHealth&gt;&quot;** where **TrainerName** is the name of the Trainer who caught the pokemon, names are **unique** there cannot be 2 trainers with the same name. After receiving the command &quot; **Tournament**&quot; an unknown number of lines containing one of three elements &quot; **Fire**&quot;, &quot; **Water**&quot;, &quot; **Electricity**&quot; will follow until the command &quot; **End**&quot; is received. For every command you must check if a trainer has atleast 1 pokemon with the given element, if he does he receives 1 badge, otherwise all his pokemon **lose 10 health** , if a pokemon falls **to 0 or less health he dies** and must be deleted from the trainer&#39;s collection. After the command &quot; **End**&quot; is received you should print all trainers **sorted by the amount of badges they have in descending order** (if two trainers have the same amount of badges they should be sorted by order of appearance in the input)in the format &quot;&lt; **TrainerName&gt; &lt;Badges&gt; &lt;NumberOfPokemon&gt;** &quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Charizard Fire 100 <br/> Gosho Squirtle Water 38 <br/> Pesho Pikachu Electricity 10 <br/> Tournament <br/> FireElectricity <br/> End | Pesho 2 2 <br/> Gosho 0 1 |
| Stamat Blastoise Water 18 <br/> Nasko Pikachu Electricity 22 <br/> Jicata Kadabra Psychic 90 <br/> Tournament <br/> FireElectricity <br/> Fire <br/> End | Nasko 1 1 <br/> Stamat 0 0 <br/> Jicata 0 1 |

## Problem 9.Google

Google is always watching you, so it should come as no surprise that they know everything about you (even your pokemon collection), since you&#39;re really good at writing classes Google asked you to design a Class that can hold all the information they need for people.

From the console you will receive an unkown amount of lines until the command &quot; **End**&quot; is read, on each of those lines there will be information about a person in one of the following formats:

- &quot; **&lt;Name&gt; company &lt;companyName&gt; &lt;department&gt; &lt;salary&gt;** &quot;
- &quot; **&lt;Name&gt; pokemon &lt;pokemonName&gt; &lt;pokemonType&gt;&quot;**
- &quot; **&lt;Name&gt; parents &lt;parentName&gt; &lt;parentBirthday&gt;** &quot;
- &quot; **&lt;Name&gt; children &lt;childName&gt; &lt;childBirthday&gt;** &quot;
- &quot; **&lt;Name&gt; car &lt;carModel&gt; &lt;carSpeed&gt;** &quot;

You should structure all information about a person in a class with nested subclasses. People&#39;s names are **unique** - there won&#39;t be 2 people with the same name, a person can also have **only 1** company and car **, but can have** multiple **parents, chidlren** and **pokemon**. After the command &quot; **End**&quot; is received on the next line you will receive a single name, you should print all information about that person. Note that information can change during the input, for instance if we receive multiple lines which specify a person&#39;s company, only the **last one** should be the one remembered. The salary must be formated to **two decimal places** after the seperator.

### Examples

| **Input** | **Output** |
| --- | --- |
|PeshoPeshev company PeshInc Management 1000.00 <br/> TonchoTonchev car Trabant 30 <br/> PeshoPeshev pokemon Pikachu Electricity <br/> PeshoPeshev parents PoshoPeshev 22/02/1920 <br/> TonchoTonchev pokemon Electrode Electricity <br/> End <br/> TonchoTonchev|TonchoTonchev <br/> Company: <br/> Car: <br/> Trabant 30 <br/> Pokemon: <br/> Electrode Electricity <br/> Parents: <br/> Children:|
|JelioJelev pokemon Onyx Rock <br/> JelioJelev parents JeleJelev 13/03/1933 <br/> GoshoGoshev pokemon Moltres Fire <br/> JelioJelev company JeleInc Jelior 777.77 <br/> JelioJelev children PudingJelev 01/01/2001 <br/> StamatStamatov pokemon Blastoise Water <br/> JelioJelev car AudiA4 180 <br/> JelioJelev pokemon Charizard Fire <br/> End <br/> JelioJelev|JelioJelev <br/> Company: <br/> JeleInc Jelior 777.77 <br/> Car: <br/> AudiA4 180 <br/> Pokemon: <br/> Onyx Rock <br/> Charizard Fire <br/> Parents: <br/> JeleJelev 13/03/1933 <br/> Children: <br/> PudingJelev 01/01/2001|

### Bonus\*

Override the ToString() method in the classes to standardize the displaying of objects.

## Problem 10.\*\*\*Family Tree

You want to build your family tree, so you went to ask your grandmother, sadly your grandmother keeps remembering information about your predecessors in pieces, so it falls to you to group the information and build the family tree.

On the first line of the input you will receive either a name or a birthdate in the format &quot;&lt; **FirstName&gt; &lt;LastName&gt;&quot;** or **&quot;day/month/year**&quot; – your task is to find the person&#39;s information in the family tree. On the next lines until the command &quot; **End**&quot; is received you will receive information about your predecessors that you will use to build the family tree.

The information will be in one of the following formats:

- &quot; **FirstName LastName - FirstName LastName**&quot;
- &quot; **FirstName LastName - day/month/year**&quot;
- &quot; **day/month/year - FirstName LastName**&quot;
- &quot; **day/month/year - day/month/year**&quot;
- &quot; **FirstName LastName day/month/year**&quot;

The first 4 formats reveal a family tie – **the person on the left is parent to the person on the right** (as you can see the format does not need to contain names, for example the 4-th format means the person born on the left date is parent to the person born on the right date). The last format ties different information together – i.e. **the person with that name was born on that date**. **Names** and **birthdates** are **unique** – there won&#39;t be 2 people with the same name or birthdate, there will **always** be enough entries to construct the family tree (all people&#39;s names and birthdates are known and they have atleast one connection to another person in the tree).

After the command &quot; **End**&quot; is received you should print all information about the person whose name or birthdate you received on the first line – his **name, birthday, parents and children** (check the examples for the format). The people in the parents and childrens lists should be ordered by their first appearance in the input (regardless if they appeared as a birthdate or a name, for example in the first input Stamat is before Penka because he first appeared in the second line, while she appears in the third.).

### Examples

| **Input** | **Output** |
| --- | --- |
|Pesho Peshev <br/> 11/11/1951 - 23/5/1980 <br/> Penka Pesheva - 23/5/1980 <br/> Penka Pesheva 9/2/1953 <br/> Pesho Peshev - Gancho Peshev <br/> Gancho Peshev 1/1/2005 <br/> Stamat Peshev 11/11/1951 <br/> Pesho Peshev 23/5/1980 <br/> End|Pesho Peshev 23/5/1980 <br/> Parents: <br/> Stamat Peshev 11/11/1951 <br/> Penka Pesheva 9/2/1953 <br/> Children: <br/> Gancho Peshev 1/1/2005|
|13/12/1993 <br/> 25/3/1934 - 4/4/1961 <br/> Poncho Tonchev 25/3/1934 <br/> 4/4/1961 - Moncho Tonchev <br/> Toncho Tonchev - Lomcho Tonchev <br/> Moncho Tonchev 13/12/1993 <br/> Lomcho Tonchev 7/7/1995 <br/> Toncho Tonchev 4/4/1961 <br/> End|Moncho Tonchev 13/12/1993 <br/> Parents: <br/> Toncho Tonchev 4/4/1961 <br/> Children:|

## Problem 11.\*\*Cat Lady

Ginka has many cats in her house of various breeds, since some breeds have specific characteristics, Ginka needs some way to catalogue the cats, help her by creating a class hierarchy with all her breeds of cats so that she can easily check on their characteristics. Ginka has 3 specific breeds of cats &quot;Siamese&quot;, &quot;Cymric&quot; and the very famous bulgarian breed &quot;Street Extraordinaire&quot;,  each breed has a specific characteristic about which information should be kept. For the Siamese cats their ear size should be kept, for Cymric cats - the length of their fur in centimeters and for the Street Extraordinaire the decibels of their meowing during the night.

From the console you will receive lines of cat information until the command &quot; **End**&quot; is received, the information will come in one of the following formats:

- &quot; **Siamese &lt;name&gt; &lt;earSize&gt;&quot;**
- &quot; **Cymric &lt;name&gt; &lt;furLength&gt;&quot;**
- &quot; **StreetExtraordinaire &lt;name&gt; &lt;decibelsOfMeows&gt;&quot;**

On the last line after the &quot; **End**&quot; command you will receive the name of a cat, you should print that cat&#39;s information in the same format in which you received it (with **fur size** being formated to **two decimal places** after the separator). Ear size and decibels will always be **positive integer** numbers, cat names are **unique**.

### Example

| **Input** | **Output** |
| --- | --- |
| StreetExtraordinaire Maca 85 <br/> Siamese Sim 4 <br/> Cymric Tom 2.80 <br/> End <br/> Tom | Cymric Top 2.80 |
| StreetExtraordinaire Koti 80 <br/> StreetExtraordinaire Maca 100 <br/> Cymric Tim 3.10 <br/> End <br/> Maca | StreetExtraordinaire Maca 100 |

### Hint

Use class inheritance to represent the cat hierarchy and override the ToString() methods of concrete breeds to allow for easy printing of the cat, regardless what breed it is.