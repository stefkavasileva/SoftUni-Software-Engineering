# <p align="center"> Exercises: Reflection </p>

This document defines the exercises for [&quot;C# OOP Advanced&quot; course @ Software University](https://softuni.bg/trainings/1637/c-sharp-oop-advanced-july-2017). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/263/Reflection-Exercise).

## Problem 1.Harvesting Fields

You are given a **RichSoilLand** class with lots of fields (look at the provided skeleton). Like a good farmer as what you are, you must harvest them. Harvesting means that you must print each field in a certain format (see output).

### Input

You will receive a maximum of 100 lines with one of the following commands:

- **private -** print all private fields
- **protected** - print all protected fields
- **public** - print all public fields
- **all** - print ALL declared fields
- **HARVEST** - end the input

### Output

For each command, you must print the fields that have the given access modifier as described in the input section. The format in which the fields should be printed is:

**&quot;&lt;access modifier&gt; &lt;field type&gt; &lt;field name&gt;&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| protected <br/> HARVEST | protected String testString <br/> protected Double aDouble <br/> protected Byte testByte <br/> protected StringBuilder aBuffer <br/> protected BigInteger testBigNumber <br/> protected Single testFloat <br/> protected Object testPredicate <br/> protected Object fatherMotherObject <br/> protected String moarString <br/> protected Exception inheritableException <br/> protected Stream moarStreamz |
| private <br/> public <br/> private <br/> HARVEST | private Int32 testInt <br/> private Int64 testLong <br/> private Calendar aCalendar <br/> private Char testChar <br/> private BigInteger testBigInt <br/> private Thread aThread <br/> private Object aPredicate <br/> private Object hiddenObject <br/> private String anotherString <br/> private Exception internalException <br/> private Stream secretStream <br/> public Double testDouble <br/> public String aString <br/> public StringBuilder aBuilder <br/> public Int16 testShort <br/> public Byte aByte <br/> public Single aFloat <br/> public Thread testThread <br/> public Object anObject <br/> public Int32 anotherIntBitesTheDust <br/> public Exception justException <br/> public Stream aStream <br/> private Int32 testInt <br/> private Int64 testLong <br/> private Calendar aCalendar <br/> private Char testChar <br/> private BigInteger testBigInt <br/> private Thread aThread <br/> private Object aPredicate <br/> private Object hiddenObject <br/> private String anotherString <br/> private Exception internalException <br/> private Stream secretStream |

## Problem 2.Black Box Integer

You are helping a buddy of yours who is still in the OOP Basics course - his name is Peshoslav (not to be mistaken with real people or trainers). He is rather slow and made a class with all private members. Your tasks are to instantiate an object from his class (always with start value 0) and then invoke the different methods it has. Your restriction is to not change anything in the class itself (consider it a black box). You can look at his class but don&#39;t touch anything! The class itself is called **BlackBoxInt** it is a wrapper for the **int** primitive.

The methods this class has are:

- Add(int)
- Subtract(int)
- Multiply(int)
- Divide(int)
- LeftShift(int)
- RightShift(int)

### Input

The input will consist of lines in the form:

**&lt;method name&gt;\_&lt;value&gt;**

For instance: **Add\_115**

Input will always be valid and in the format described, so there is no need to check it explicitly. You stop receiving input when you encounter the command &quot; **END**&quot;.

### Output

Each command (except the **END** one) should print the current value of **innerValue** of the BlackBoxInt object you instantiated. Don&#39;t cheat by overriding ToString() in the class - you must get the value from the **private** field.

### Examples

| **Input** | **Output** |
| --- | --- |
| Add\_999999 <br/> Subtract\_19 <br/> Divide\_4 <br/> Multiply\_2 <br/> RightShift\_1 <br/> LeftShift\_3 <br/> END | 999999 <br/> 999980 <br/> 249995 <br/> 499990 <br/> 249995 <br/> 1999960 |

## Problem 3.BarracksWars - A New Factory

You are given a small console based project called Barracks (the code for it is included in the provided skeleton).

The general functionalities of the project are adding new units to its repository and printing a report with statistics about the units currently in the repository. First let&#39;s go over the original task before the project was created:

### Input

The input consists of commands each on a separate line. Commands that execute the functionality are:

- **add** &lt; **Archer** / **Swordsman** / **Pikeman/{…}** &gt; - adds a unit to the repository.
- **report** - prints a lexicological ordered statistic about the units in the repository.
- **fight** - ends the input.

### Output

Each command except **fight** should print output on the console.

- **add** should print: &quot;&lt; **Archer** / **Swordsman** / **Pikeman** / **{…}&gt; added!**&quot;
- **report** should print all the info in the repository in the format: &quot;&lt; **UnitType** &gt; **-&gt;** &lt; **UnitQuantity** &gt;&quot;, sorted by UnitType

### Constraints

- Input will consist of no more than **1000** lines
- **report** command will never be given before any valid add command was provided

### Your task

1) You have to **study the code of the project and figure out how it works**. However, there are parts of it that are not implemented (left with TODOs). You must implement the functionality of the **CreateUnit** method in the **UnitFactory** class so that it creates a unit based on the unit type received as parameter. Implement it in such a way that whenever you add a new unit it will be creatable without the need to change anything in the **UnitFactory** class (_psst - use reflection_). You can use the approach called **Simple Factory**.

2) Add two new unit classes (there will be tests that require them) - **Horseman** with 50 health and 10 attack and **Gunner** with 20 health and 20 attack.

If you complete everything correctly for this problem, you should add code only inside the **Factories** and **Units** folders.

### Examples

| **Input** | **Output** |
| --- | --- |
| add Swordsman <br/> add Archer <br/> add Pikemanreport <br/> add Pikeman <br/> add Pikeman <br/> report <br/> fight | Swordsman added! <br/> Archer added! <br/> Pikeman added <br/> !Archer -&gt; 1 <br/> Pikeman -&gt; 1 <br/> Swordsman -&gt; 1 <br/> Pikeman added! <br/> Pikeman added! <br/> Archer -&gt; 1 <br/> Pikeman -&gt; 3 <br/> Swordsman -&gt; 1 |
| add Pikeman <br/> add Pikeman <br/> add Gunner <br/> add Horseman <br/> add Archera <br/> dd Gunner <br/> add Gunner <br/> add Horsemanreportfight | Pikeman added! <br/> Pikeman added! <br/> Gunner added <br/> !Horseman added! <br/> Archer added! <br/> Gunner added! <br/> Gunner added! <br/> Horseman added! <br/> Archer -&gt; 1 <br/> Gunner -&gt; 3 <br/> Horseman -&gt; 2 <br/> Pikeman -&gt; 2 |

## Problem 4.BarracksWars - The Commands Strike Back

As you might have noticed commands in the project from Problem 3 are implemented via a switch case with method calls in the **Engine** class. Although this approach works it is flawed when you add a new command because you have to add a new case for it. In some projects, you might not have access to the engine and this would not work. Imagine this project will be outsourced and the outsourcing firm will not have access to the engine. Make it so whenever they want to add a new command they won&#39;t have to change anything in the **Engine.**

To do so employ the design pattern called [**Command Pattern**](https://en.wikipedia.org/wiki/Command_pattern). We&#39;ve done this in the **BashSoft**** Lab **and you can look there for tips too. Use the provided** Executable **interface as a frame for the command classes. Put the new command classes in the provided** commands **package inside** core**. You can also make a Command Interpreter to decouple that functionality from the Engine.Here is how thebase (abstract) command should look like:

```csharp
public abstract class Command : IExecutable
{
    private string[] data;

    protected Command(string[] data)
    {
        this.Data = data;
    }

    protected string[] Data
    {
        get { return this.data; }
        set { this.data = value; }
    }

    public abstract string Execute();
}
```
Notice how all commands that extend this one will have both a Repository and a **UnitFactory** although not all of them need these. Leave it like this for this problem, because for the reflection to work we need all constructors to accept the same parameters. We will see how to go around this issue in problem 5.

Once you&#39;ve implemented the pattern add a new command. It will have the following syntax:

- **retire** &lt; **UnitType** &gt; - All it has to do is remove a unit of the provided type from the repository.
  - If there are no such units currently in the repository print: &quot; **No such units in repository.**&quot;
  - If there is such a unit currently in the repository, print: &quot; **&lt;UnitType&gt; retired!**&quot;

To implement this command, you will also have to implement a corresponding method in the **UnitRepository**.

If you do everything correctly for this problem, you should write/refactor code only in the **Core** and **Data** packages.

### Examples

| **Input** | **Output** |
| --- | --- |
|retire Archer <br/> add Pikeman <br/> add Pikeman <br/> add Gunner <br/> add Horseman <br/> add Archer <br/> add Gunner <br/> add Gunner <br/> add Horseman <br/> report <br/> retire Gunner <br/> retire Archer <br/> report <br/> retire Swordsman <br/> retire Archer <br/> fight| No such units in repository. <br/> Pikeman added! <br/> Pikeman added! <br/> Gunner added! <br/> Horseman added! <br/> Archer added! <br/> Gunner added! <br/> Gunner added! <br/> Horseman added! <br/> Archer -> 1 <br/> Gunner -> 3 <br/> Horseman -> 2 <br/> Pikeman -> 2 <br/> Gunner retired! <br/> Archer retired! <br/> Archer -> 0 <br/> Gunner -> 2 <br/> Horseman -> 2 <br/> Pikeman -> 2 <br/> No such units in repository. <br/> No such units in repository.|

## Problem 5.\* BarracksWars - Return of the Dependencies

In the final part of this epic problem trilogy we will resolve the issue where all Commands received all utility classes as parameters in their constructors. We can accomplish this by using an approach called **dependency injection container**. This approach is used in many frameworks.

We will do a little twist on that approach. Remove all fields from the abstract command except the **data.** Instead put whatever fields each command needs in the concrete class. Create an attribute called **Inject** and make it so it can be used only on fields. Put the attribute over the fields we need to set trough reflection. Once you&#39;ve prepared all of this, write the necessary reflection code in the **Command Interpreter** (which you should have refactored out from the engine in problem 4).

You can use the same example as in Problem 4 to check if you completed the task correctly.

