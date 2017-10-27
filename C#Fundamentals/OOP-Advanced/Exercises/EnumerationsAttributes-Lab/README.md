# <p align="center"> Lab:   Enumerations and Attributes </p>


Problems for exercises and homework for the
<https://softuni.bg/courses/csharp-oop-advanced-high-quality-code>.

You can check your solutions here:
[https://judge.softuni.bg/Contests/Practice/Index/708\#0](https://judge.softuni.bg/Contests/Practice/Index/708).

Part I: Enumerations
====================

Weekdays
--------

Create **Enum** Weekday with the days from **Monday** through
**Sunday**.

Create a class **WeeklyCalendar** that should have at least the methods:

-   <span id="OLE_LINK3" class="anchor"><span id="OLE_LINK4"
    class="anchor"></span></span>void AddEntry(string weekday,
    string notes)

-   IEnumerable&lt;WeeklyEntry&gt; WeeklySchedule

Create a class **WeeklyEntry** which should have constructor:

-   <span id="OLE_LINK5" class="anchor"><span id="OLE_LINK6"
    class="anchor"></span></span>WeeklyEntry(string weekday,
    string notes)

-   Implement IComparable&lt;WeeklyEntry&gt; - Entries have to be
    compare first by their week day and then by note

Override **ToString()** of **WeeklyEntry** – <span id="OLE_LINK7"
class="anchor"><span id="OLE_LINK8"
class="anchor"></span></span>"{weekday} - {notes}" (e.g. "Monday -
sport", "Sunday - sleep")

### Examples

```csharp
WeeklyCalendar calendar = new WeeklyCalendar();                    
calendar.AddEntry("Monday", "Internal meeting");                    
calendar.AddEntry("Tuesday", "Create presentation");                
calendar.AddEntry("Tuesday", "Create lab and exercise");            
calendar.AddEntry("Thursday", "Enum Lecture");                      
calendar.AddEntry("Monday", "Second internal meeting");             

var ordered = calendar.WeeklySchedule.OrderBy(n =&gt; n).ToList();  

foreach (var weeklyEntry in ordered)                                                                                                   
{                                                                   
	Console.WriteLine(weeklyEntry);                                                                                                        
}                                                              
```
### Hints

Create the **WeeklyCalendar**:

<img src="./media/image1.png" width="368" height="190" />

Create **WeeklyEntry** and think about a solution to compare entries:

<img src="./media/image2.png" width="482" height="347" />

Coffee Machine
--------------

Create a class **CoffeeMachine**, with methods:

-   <span id="OLE_LINK9" class="anchor"><span id="OLE_LINK10"
    class="anchor"></span></span>void BuyCoffee(string size,
    string type)

-   void InsertCoin(string coin)

-   IEnumerable&lt;**CoffeeType**&gt; CoffeesSold { get; }

Create **enum CoffeeType** - Espresso, Latte, Irish

Create **enum Coin** - 1, 2, 5, 10, 20, 50 (constants should be named
One, Two, Five, etc.)

Create **enum CoffeePrice** - Small (50 c), Normal (100 c), Double (200
c)

**CoffeeMachine** should **clear all coins after each successful coffee
sold**.

When you receive "End" command, print all sold coffees.

### Examples

```csharp
CoffeeMachine machine = new CoffeeMachine();       
string input;                                       

while ((input = Console.ReadLine()) != "End")       
{                                                   
	string\[\] inputArgs = input.Split();               
	if (inputArgs.Length == 1)                                                                              
	{                                                   
		machine.InsertCoin(inputArgs\[0\]);                 
	}                                                   
    else                                                
    {                                                   
		machine.BuyCoffee(inputArgs\[0\], inputArgs\[1\]);  
	}                                                   
}                                                   
                                                     
foreach (var coffeeType in machine.CoffeesSold)     
{                                                   
	Console.WriteLine(coffeeType);                                                                          
}                                                   
```

| **Input**      | **Output**                              |
|----------------|-----------------------------------------|
| Ten <br/> Twenty <br/> Twenty <br/> Small Espresso <br/> End | Espresso|                                |
| Ten <br/> Twenty <br/> Small Espresso <br/> Twenty <br/> Small Espresso <br/> End | Espresso <br/> //Comment: first try - not enough coins  |

Part II: Attributes
===================

Create Attribute
----------------

Create attribute **SoftUni** with a **string** element called **name**,
that**: **

-   Can be used over classes and methods

-   Allow multiple attributes of same type



Coding Tracker
--------------

Create a class **Tracker** with a method:

-   static void printMethodsByAuthor()

