# <p align="center"> Exercises: C# OOP Introduction </p>
## ExercisesC# OOP Introduction

This document defines the **exercise assignments** for the [&quot;CSharp DB Advanced&quot; course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

## Part I.Defining Classes – Methods and Constructors

### Problem 1.Oldest Family Member

Create class **Person** with properties **Name** and **Age**. Create a class **Family**. The class should have **list of people** , method for **adding** members (**void AddMember(Person member)**) and a method **returning** the **oldest** family **member** (**Person GetOldestMember())**. Write a program that reads name and age for **N** people and **add them to the family**. Then **print** the **name** and **age** of the oldest member.

Your methods should have the **same exact** names as shown above!

### Note

Add the following code to your main method before your code and submit it to Judge.

```csharp
MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
if(oldestMemberMethod == null || addMemberMethod == null)
{
   throw new Exception();
}
```

If you defined the class correctly, the test should pass.

### Examples

| **Input** | **Output** |  **Input** | **Output** |
| --- | --- | --- | --- |
| 3 <br/> Pesho 3 <br/> Gosho 4 <br/> Annie 5 | Annie 5 | 5 <br/> Steve 10 <br/> Christopher 15 <br/> Annie 4 <br/> Ivan 35 <br/> Maria 34 | Ivan 35 |

### Problem 2.Date Modifier

Create a class **DateModifier** , which stores the difference of the days between two Dates. It should have a method, which takes **two string parameters**** representing a date **as strings and** calculates the** difference in the days between them.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1992 05 31 <br/> 2016 06 17 | 8783 |
| 2016 05 31 <br/> 2016 04 19 | 42 |

### Problem 3.Raw Data

You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a class **Car** that holds information about **model, engine, cargo** and a **collection of exactly 4 tires**. The engine, cargo and tire **should be separate classes**. Create a constructor that receives all information about the **car** , creates, and initializes its inner components (engine, cargo and tires).

On the first line of input, you will receive a number **N** - the amount of cars you have. On each of the next **N** lines, you will receive information about a car in the format &quot; **&lt;Model&gt; &lt;EngineSpeed&gt; &lt;EnginePower&gt; &lt;CargoWeight&gt; &lt;CargoType&gt; &lt;Tire1Pressure&gt; &lt;Tire1Age&gt; &lt;Tire2Pressure&gt; &lt;Tire2Age&gt; &lt;Tire3Pressure&gt; &lt;Tire3Age&gt; &lt;Tire4Pressure&gt; &lt;Tire4Age&gt;&quot;** where the speed, power, weight and tire age are **integers** , tire pressure is a **double.**

After the **N** lines you will receive a single line with one of 2 commands &quot; **fragile**&quot; or &quot; **flammable**&quot; , if the command is &quot; **fragile**&quot; print all cars whose **Cargo Type is &quot;fragile&quot;** with a tire whose **pressure is**   **&lt; 1** , if the command is &quot; **flammable**&quot; print all cars whose **Cargo Type is &quot;flamable&quot;** and have **Engine Power &gt; 250**. The cars should be printed in order of appearing in the input.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 <br/> ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4 <br/> Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1 <br/> fragile | Citroen2CV |
| 4 <br/> ChevroletExpress 215 255 1200 flammable 2.5 1 2.4 2 2.7 1 2.8 1 <br/> ChevroletAstro 210 230 1000 flammable 2 1 1.9 2 1.7 3 2.1 1 <br/> DaciaDokker 230 275 1400 flammable 2.2 1 2.3 1 2.4 1 2 1 <br/> Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2 <br/> flammable | ChevroletExpress <br/> DaciaDokker |

## Part II.Encapsulation and Validation

### Problem 4.Animal Farm

You should be familiar with encapsulation already. For this problem, you&#39;ll be working with the **Animal Farm project**. It contains a class **Chicken**. Chicken contains several fields, a constructor, several properties and several methods. Your task is to encapsulate or hide anything that is not intended to be viewed or modified from outside of the class.

#### Step 1. Encapsulate Fields

Fields should be **private**. Leaving fields open for modification from outside the class is potentially dangerous. Make all fields in the Chicken class private.

In case the value inside a field is needed elsewhere, use **getters** to reveal it.

#### Step 2. Ensure Classes Have a Correct State

Having **getters and setters** is useless if you don&#39;t actually use them. The Chicken constructor modifies the fields directly which is wrong when there are suitable setters available. Modify the constructor to fix this issue.

#### Step 3. Validate Data Properly

Validate the chicken&#39;s **name** (it cannot be null, empty or whitespace). In case of **invalid name** , print exception message – &quot;Name cannot be empty.&quot;.

Validate the **age** properly, minimum and maximum age are provided, make use of them. In case of **invalid age** , print exception message &quot;Age should be between 0 and 15.&quot;

Don&#39;t forget to handle properly the possibly thrown exceptions.

#### Step 4. Hide Internal Logic

If a method is intended to be used only by descendant classes or internally to perform some action, there is no point in keeping them **public**. The **CalculateProductPerDay()** method is used by the **ProductPerDay()** public getter. This means the method can be safely hidden inside the Chicken class by declaring it **private**.

#### Step 5. Submit Code to Judge

Submit your code as a zip file in Judge. Zip everything except the bin and obj folders within the project and submit the single zip file in judge.

### Examples

| **Input** | **Output** |
| --- | --- |
| Mara <br/> 10 | Chicken Mara (age 10) can produce 1 eggs per day. |
| Mara <br/> 17 | Age should be between 0 and 15. |

### Problem 5.Football Team Generator

A football team has variable **number of players** , a **name** and a **rating**. A player has a **name** and **stats**** , **which are the basis for his skill level. The stats a player has are** endurance **,** sprint **,** dribble **,** passing **and** shooting **. Each stat can be an** integer** in the range [0..100]. The overall skill level of a player is calculated as the average of his stats. Only the name of a player and his stats should be visible to the entire outside world. Everything else should be hidden.

A team should expose a name, a rating (calculated by the average skill level of all players in the team and rounded to the integer part only) and methods for adding and removing players.

Your task is to model the team and the players following the proper principles of Encapsulation. Expose only the properties that needs to be visible and validate data appropriately.

Your application will receive commands until the &quot;END&quot; command is given. The command can be one of the following:

- **&quot;Team;&lt;TeamName&gt;&quot;** – add a new team;
- **&quot;Add;&lt;TeamName&gt;;&lt;PlayerName&gt;;&lt;Endurance&gt;;&lt;Sprint&gt;;&lt;Dribble&gt;;&lt;Passing&gt;;&lt;Shooting&gt;&quot;** – add a new player to the team;
- **&quot;Remove;&lt;TeamName&gt;;&lt;PlayerName&gt;&quot;** –remove the player from the team;
- **&quot;Rating;&lt;TeamName&gt;&quot;** – print the team rating, rounded to an integer.

#### Data Validation

- A name cannot be null, empty or white space. If not, print &quot;A name should not be empty.&quot;.
- Stats should be in the range 0..100. If not, print &quot;[Stat name] should be between 0 and 100.&quot;.
- If you receive a command to remove a missing player, print &quot;Player [Player name] is not in [Team name] team.&quot;.
- If you receive a command for a missing team, print &quot;Team [team name] does not exist.&quot;

#### Examples

| **Input** | **Output** |
| --- | --- |
|Team;Arsenal<br/> Add;Arsenal;Kieran_Gibbs;75;85;84;92;67<br/> Add;Arsenal;Aaron_Ramsey;95;82;82;89;68<br/> Remove;Arsenal;Aaron_Ramsey<br/> Rating;Arsenal<br/> END |Arsenal – 81 |
|Team;Arsenal<br/> Add;Arsenal;Kieran_Gibbs;75;85;84;92;67<br/> Add;Arsenal;Aaron_Ramsey;195;82;82;89;68<br/> Remove;Arsenal;Aaron_Ramsey<br/> Rating;Arsenal<br/> END |Endurance should be between 0 and 100.<br/> Player Aaron_Ramsey is not in Arsenal team.<br/> Arsenal - 81|
|Team;Arsenal<br/> Rating;Arsenal<br/> END|Arsenal – 0 | 

### Problem 6.Online Radio Database

Create an online radio station database. It should keep information about all added songs. On the first line you are going to get the number of songs you are going to try to add. On the next lines you will get the songs to be added in the format **&lt;artist name&gt;;&lt;song name&gt;;&lt;minutes:seconds&gt;**. To be valid, every song should have an artist name, a song name and length.

Design a custom exception hierarchy for invalid songs:

- InvalidSongException
  - **oo** InvalidArtistNameException
  - **oo** InvalidSongNameException
  - **oo** InvalidSongLengthException
    - InvalidSongMinutesException
    - InvalidSongSecondsException

#### Validation

- Artist name should be between 3 and 20 symbols.
- Song name should be between 3 and 30 symbols.
- Song length should be valid numbers in format &quot;m:s&quot;.
- Song minutes should be between 0 and 14.
- Song seconds should be between 0 and 59.

#### Exception Messages

| **Exception** | **Message** |
| --- | --- |
| InvalidSongException | &quot;Invalid song.&quot; |
| InvalidArtistNameException | &quot;Artist name should be between 3 and 20 symbols.&quot; |
| InvalidSongNameException | &quot;Song name should be between 3 and 30 symbols.&quot; |
| InvalidSongLengthException | &quot;Invalid song length.&quot; |
| InvalidSongMinutesException | &quot;Song minutes should be between 0 and 14.&quot; |
| InvalidSongSecondsException | &quot;Song seconds should be between 0 and 59.&quot; |

**Note** : Check validity in the order artist name -&gt; song name -&gt; song length

#### Output

If the song is added, print &quot; **Song added.**&quot;. If you **can&#39;t add a song** , print an **appropriate exception message**. On the last two lines print the **number of songs added** (&quot; **Songs added: &lt;SongCount&gt;**&quot;) and the **total length of the playlist** in format &quot; **Playlist length: &lt;Hours&gt;h &lt;Minutes&gt;m &lt;Seconds&gt;s**&quot; **.**

### Examples

| **Exception** | **Message** |
| --- | --- |
|3<br/> ABBA;Mamma Mia;3:35<br/> Nasko Mentata;Shopskata salata;4:123<br/> Nasko Mentata;Shopskata salata;4:12|Song added.<br/> Song seconds should be between 0 and 59.<br/> Song added.<br/> Songs added: 2<br/> Playlist length: 0h 7m 47s|
|5<br/> Nasko Mentata;Shopskata salata;14:59<br/> Nasko Mentata;Shopskata salata;14:59<br/> Nasko Mentata;Shopskata salata;14:59<br/> Nasko Mentata;Shopskata salata;14:59<br/> Nasko Mentata;Shopskata salata;0:5 |Song added.<br/> Song added.<br/> Song added.<br/> Song added.<br/> Song added.<br/> Songs added: 5<br/> Playlist length: 1h 0m 1s|

## Part III.Inheritance

### Problem 7.Animals

Create a hierarchy of **Animals**. Your program should have 3 different animals – **Dog** , **Frog** and **Cat**. Deeper in the hierarchy you should have two additional classes – **Kitten** and **Tomcat**. **Kittens are female and Tomcats are male!**

All types of animals should be able to produce some kind of sound (**ProduceSound()**). For example, the dog should be able to bark.

Your task is to model the hierarchy and test its functionality. Create an animal of each kind and make them all produce sound.

You will be given some lines of input. Each two lines will represent an animal. On the first line will be the type of animal and on the second – the name, the age and the gender. When the command &quot; **Beast!**&quot; is given, stop the input and print all the animals in the format shown below.

### Output

- Print the information for each animal on three lines. On the first line, print: &quot;&lt; **AnimalType** &gt;&quot;
- On the second line print: &quot;&lt; **Name** &gt; &lt; **Age** &gt; &lt; **Gender** &gt;&quot;
- On the third line print the sounds it produces: &quot;&lt;**ProduceSound()**&gt;&quot;

### Constraints

-  Each **Animal** should have a **name** , an **age** and a **gender**
- ** All **input values should** not be blank** (e.g. name, age and so on…)
-  If you receive an input for the **gender** of a **Tomcat** or a **Kitten** , ignore it but **create** the animal
-  If the input is invalid for one of the properties, throw an exception with message: &quot;I **nvalid input!**&quot;
-  Each animal should have the functionality to **ProduceSound()**
-  Here is the type of sound each animal should produce:
  - **oo**** Dog: &quot;Woof!&quot;**
  - **oo**** Cat: &quot;Meow meow&quot;**
  - **oo**** Frog: &quot;Ribbit&quot;**
  - **oo**** Kittens: &quot;Meow&quot;**
  - **oo**** Tomcat: &quot;MEOW&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| Cat <br/> Tom 12 Male <br/> Dog <br/> Sharo 132 Male <br/> Beast! | Cat  <br/> Tom 12 Male <br/> Meow meow <br/> Dog Sharo 132 Male <br/> Woof! |
| Frog <br/> Kermit 12 Male <br/> Beast! | Frog <br/>  Kermit 12 Male <br/> Ribbit |
| Frog <br/> Sashko -2 Male <br/> Frog <br/> Sashko 2 Male <br/> Beast! | Invalid input! <br/> Frog <br/> Sashko 2 Male <br/> Ribbit |

**Bonus** Create an interface **ISoundProducable** and implement it in the **Animal** class.