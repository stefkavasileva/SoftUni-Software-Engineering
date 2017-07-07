# <p align="center"> Exercises:  Inheritance </p>

This document defines the exercises for [&quot;C# OOP Basics&quot; course @ Software University](https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017). Please submit your solutions (source code) of all below described problems in [Judge](https://judge.softuni.bg/Contests/Practice/Index/239#0).

## Problem 1.Person

You are asked to model an application for storing data about people. You should be able to have a person and a child. The child is derived of the person. Your task is to model the application. The only constraints are:

- **--** People should **not** be able to have **negative age**
- **--** Children should **not** be able to have age **more than 15**.

-  **Person**– represents the base class by which all others are implemented

- **Child**- represents a class which is derived by the Person.

### Note

Your class&#39;s names **MUST** be the same as the names shown above!!!

``` csharp

staticvoid Main(){
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());

    try    {
    Child child = newChild(name, age);
    Console.WriteLine(child);    
    }    
    catch (ArgumentException ae)    
    {        
        Console.WriteLine(ae.Message);    
    }
} 

```
Create a new empty class and name it **Person**. Set its access modifier to **public** so it can be instantiated from any project. Every person has a name, and age.

``` csharp

publicclassPerson
{
    // 1. Add Fields   
    // 2. Add Constructor   
    // 3. Add Properties   
    // 4. Add Methods
} |

```
### Step 2 – Define the fields

Define a **field** for each property the class should have (e.g. **Name** , **Age** )

### Step 3 - Define the Properties of a Person

Define the **Name** and **Age** properties of a Person. Ensure that they can only be **changed by the class itself or its descendants** (pick the most appropriate access modifier).

``` csharp

public virtual string Name
{    
    get
    {        
        //TODO    
    }    
    set    
    {        
        //TODO    
    }
}

public virtual int Age
{    
    get    
    {        
    //TODO    
    }    
    set    
    {        
    //TODO    
    }
} 

``` 
### Step 4 - Define a Constructor

Define a constructor that accepts **name and age**.

``` csharp

public Person(string name, int age)
{    
    this.Name = name;    
    this.Age = age;
} 

```
### Step 5 - Perform Validations

After you have created a **field** for each property (e.g. **Name** and **Age** ). Next step is to **perform validations** for each one. The **getter should return the corresponding field&#39;s value** and the **setter should validate** the input data before setting it. Do this for each property.

``` csharp

public virtual int Age
{    
    get    
    {         
        return this.age;    
    }    
    set    
    {        
        if (value &lt; 0)        
        {            
            thrownewArgumentException("Age must be positive!");
        }        
        
        //TODO set field age with value   
    }
} 

```
### Constraints

- If the age of a person is negative – exception&#39;s message is: **&quot;Age must be positive!&quot;**
- If the age of a child is bigger than 15 – exception&#39;s message is: **&quot;** **Child's age must be less than 15!&quot;**
- If the name of a child or a person is no longer than 3 symbols – exception&#39;s message is: **&quot;** **Name&#39;s length should not be less than 3 symbols!** **&quot;**

### Step 6 - Override ToString()

As you probably already know, all classes in C# inherit the **Object** class and therefore have all its **public** members (ToString(), Equals() and GetHashCode()**methods).**ToString()** serves to return information about an instance as string. Let&#39;s **override** (change) its behavior for our **Person** class.

``` csharp

public override string ToString()
{    
    StringBuilder stringBuilder = newStringBuilder();
    stringBuilder.Append(String.Format("Name: {0}, Age: {1}";,
        this.Name,                         
        this.Age));    
        
   return stringBuilder.ToString();
} 

```
And voila! If everything is correct, we can now create **Person objects** and display information about them.

### Step 7 – Create a Child

Create a **Child** class that inherits **Person** and has the same constructor definition. However, do not copy the code from the Person class - **reuse the Person class&#39;s constructor**.

``` csharp

public Child(string name, int age)    
    : base(name, age)
{

} 

```
There is **no need** to rewrite the Name and Age properties since **Child** inherits **Person** and by default has them.

### Step 8 – Validate the Child&#39;s setter

``` csharp

public override int Age
{    
    get    
    {        
        return base.Age;    
    }    
    set    
    {        
        //TODO validate childs age       
      base.Age = value;    
    }
} 

```
## Problem 2.Book Shop

You are working in a library. And you are pissed of writing descriptions for books by hand, so you wish to use the computer to speed up the process. The task is simple - your program should have two classes – one for the ordinary books – **Book** , and another for the special ones – **GoldenEditionBook**. So let&#39;s get started! We need two classes:

- **Book**- represents a book that holds **title**, **author** and **price**. A book should offer **information** about itself in the format shown in the output below.
- **GoldenEditionBook**- represents a special book holds the same properties as any **Book**, but its **price** is always **30% higher**.

### Constraints

- If the author&#39;s second name is starting with a digit– exception&#39;s message is: **&quot;** **Author not valid!** **&quot;**
- If the title&#39;s length is less than 3 symbols – exception&#39;s message is: **&quot;** **Title not valid!&quot;**
- If the price is zero or it is negative – exception&#39;s message is: **&quot;** **Price not valid!** **&quot;**
- Price must be formatted to **one** symbol after the decimal separator

``` csharp

staticvoid Main()
{    
    try    
    {        
        string author = Console.ReadLine();
        string title = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());
        
        Book book = newBook(author, title, price);
        GoldenEditionBook goldenEditionBook = newGoldenEditionBook(author, title, price);
        Console.WriteLine(book);
        Console.WriteLine(goldenEditionBook);
    }
    catch (ArgumentException ae)    
    {        
        Console.WriteLine(ae.Message);    
    }
} 

```
### Example

| **Input** | **Output** |
| --- | --- |
| Ivo 4ndonov <br/> Under Cover <br/> 9999999999999999999 | Author not valid! |

### Step 1 - Create a Book Class

Create a new empty class and name it **Book**. Set its access modifier to **public** so it can be instantiated from any project.

``` csharp

publicclassBook
{    
    //1. Add Fields    
    //2. Add Constructors    
    //3. Add Properties    
    //4. Add Methods
} 

```
### Step 2 - Define the Properties of a Book

Define the **Title** , **Author** and **Price** properties of a Book. Ensure that they can only be **changed by the class itself or its descendants** (pick the most appropriate access modifier).

### Step 3 - Define a Constructor

Define a constructor that accepts **author, title** and **price** arguments.

``` csharp 

public Book(string title, string author, decimal price)
{            
    this.title = title;            
    this.author = author;            
    this.price = price;        
} 

```
### Step 4 - Perform Validations

Create a **field** for each property ( **Price** , **Title** and **Author** ) and **perform validations** for each one. The **getter should return the corresponding field** and the **setter should validate** the input data before setting it. Do this for every property.

``` csharp 

public string Author
{    
    get    
    {        
        return this.author;    
    }
    set    
    {        
        //TODO validate value        
        
        this.author = value;   
    }
}

public string Title
{    
    get    
    {  
        return this.title;    
    } 
    set    
    {       
        //TODO validate value  
        this.title = value;   
    }
}

public virtualdecimal Price
{    
    get    
    {        
        return this.price;    
    }    
    set    
    {        
        //TODO validate value        
        this.price = value;    
    }
} 

```
### Step 5 - Override ToString()

We already mentioned that all classes in C# inherit the **System.Object** class and therefore have all its **public** members. Let&#39;s **override** (change)  the **ToString()** method&#39;s behavior again acordingly our **Book** class&#39;s data.

``` csharp

public override string ToString() 
{            
    var sb = newStringBuilder();
    sb.Append("Type: ")
    .AppendLine(this.GetType().Name)
    .Append("Title: ")
    .AppendLine(this.Title)
    .Append("Author: ")
    .AppendLine(this.Author)
    .Append("Price: ")
    .Append("{this.Price:f1}") 
    .AppendLine();
    
    return sb.ToString();        
} 

```
And voila! If everything is correct, we can now create **Book objects** and display information about them.

### Step 6 – Create a GoldenEditionBook

Create a **GoldenEditionBook** class that inherits **Book** and has the same constructor definition. However, do not copy the code from the Book class - **reuse the Book class constructor**.

``` csharp

public GoldenEditionBook(string author, string title, decimal price)     
    : base(author, title, price)

{

} 

```
There is **no need** to rewrite the Price, Title and Author properties since **GoldenEditionBook** inherits **Book** and by default has them.

### Step 7 - Override the Price Property

Golden edition books should return a **30%** higher **price** than the original price. In order for the getter to return a different value, we need to override the Price property.

Back to the **GoldenEditionBook** class, let&#39;s override the Price property and change the getter body

``` csharp

public override decimal Price
{
    get    
    {        
        returnbase.Price \* 1.3;    
    }
} 

```
## Problem 3.Mankind

Your task is to model an application. It is very simple. The mandatory models of our application are 3:  Human, Worker and Student.

The parent class – Human should have **first name** and **last name**. Every student has a **faculty number**. Every worker has a **week salary** and **work hours per day**. It should be able to calculate the money he earns by hour. You can see the constraints below.

### Input

On the first input line you will be given info about a single student - a name and faculty number.

On the second input line you will be given info about a single worker - first name, last name, salary and working hours.

### Output

You should first print the info about the student following a single blank line and the info about the worker in the given formats:

- Print the student info in the following format:

**First Name: {student&#39;s first name}**

**Last Name: {student&#39;s last name}**

**Faculty number: {student&#39;s faculty number}**

- Print the worker info in the following format:

**First Name: {worker&#39;s first name}**

**Last Name: {worker&#39;s second name}**

**Week Salary: {worker&#39;s salary}**

**Hours per day: {worker&#39;s working hours}**

**Salary per hour: {worker&#39;s salary per hour}**

Print exactly two digits after every double value&#39;s decimal separator (e.g. 10.00). Consider the workweek from Monday to Friday. A faculty number should be consisted only of digits and letters.

### Constraints

| **Parameter** | **Constraint** | **Exception Message** |
| --- | --- | --- |
| Human first name | Should start with a capital letter | &quot;Expected upper case letter! Argument: firstName&quot; |
| Human first name | Should be more than 3 symbols | &quot;Expected length at least 4 symbols! Argument: firstName&quot; |
| Human last name | Should start with a capital letter | &quot;Expected upper case letter! Argument: lastName&quot; |
| Human last name | Should be more than 2 symbols | &quot;Expected length at least 3 symbols! Argument: lastName &quot; |
| Faculty number | Should be in range [5..10] symbols | &quot;Invalid faculty number!&quot; |
| Week salary | Should be more than 10 | &quot;Expected value mismatch! Argument: weekSalary&quot; |
| Working hours | Should be in the range [1..12] | &quot;Expected value mismatch! Argument: workHoursPerDay&quot; |

### Example

| **Input** | **Output** |
| --- | --- |
| Ivan Ivanov 08Pesho Kirov 1590 10 | Invalid faculty number! |
| Stefo Mk321 0812111Ivcho Ivancov 1590 10 | First Name: StefoLast Name: Mk321Faculty number: 0812111First Name: IvchoLast Name: IvancovWeek Salary: 1590.00Hours per day: 10.00Salary per hour: 31.80 |

## Problem 4.Online Radio Database

Create an online radio station database. It should keep information about all added songs. On the first line you are going to get the number of songs you are going to try to add. On the next lines you will get the songs to be added in the format **&lt;artist name&gt;;&lt;song name&gt;;&lt;minutes:seconds&gt;**. To be valid, every song should have an artist name, a song name and length.

Design a custom exception hierarchy for invalid songs:

- InvalidSongException
  - InvalidArtistNameException
  - InvalidSongNameException
  - InvalidSongLengthException
    - InvalidSongMinutesException
    - InvalidSongSecondsException

### Validation

- Artist name should be between 3 and 20 symbols.
- Song name should be between 3 and 30 symbols.
- Song length should be between 0 second and 14 minutes and 59 seconds.
- Song minutes should be between 0 and 14.
- Song seconds should be between 0 and 59.

### Exception Messages

| **Exception** | **Message** |
| --- | --- |
| InvalidSongException | &quot;Invalid song.&quot; |
| InvalidArtistNameException | &quot;Artist name should be between 3 and 20 symbols.&quot; |
| InvalidSongNameException | &quot;Song name should be between 3 and 30 symbols.&quot; |
| InvalidSongLengthException | &quot;Invalid song length.&quot; |
| InvalidSongMinutesException | &quot;Song minutes should be between 0 and 14.&quot; |
| InvalidSongSecondsException | &quot;Song seconds should be between 0 and 59.&quot; |

**Note** : Check validity in the order artist name -&gt; song name -&gt; song length

### Output

If the song is added, print &quot; **Song added.** &quot;. If you **can&#39;t add a song** , print an **appropriate exception message**. On the last two lines print the **number of songs added** and the **total length of the playlist** in format **{Playlist length: 0h 7m 47s}.**

### Examples

| **Exception** | **Message** |
| --- | --- |
| 3 <br/> ABBA;Mamma Mia;3:35 <br/> Nasko Mentata;Shopskata salata;4:123 <br/> Nasko Mentata;Shopskata salata;4:12 | Song added. <br/> Song seconds should be between 0 and 59.Song added. <br/> Songs added: 2 <br/> Playlist length: 0h 7m 47s |
| 5 <br/> Nasko Mentata;Shopskata salata;14:59 <br/> Nasko Mentata;Shopskata salata;14:59 <br/> Nasko Mentata;Shopskata salata;14:59 <br/> Nasko Mentata;Shopskata salata;14:59 <br/> Nasko Mentata;Shopskata salata;0:5 | Song added. <br/> Song added. <br/> Song added. <br/> Song added. <br/> Song added. <br/> Songs added: 5 <br/> Playlist length: 1h 0m 1s |

## Problem 5.\*Mordor&#39;s Cruelty Plan

Gandalf the Gray is a great wizard but he also loves to eat and the food makes him loose his capability of fighting the dark. The Mordor&#39;s orcs have asked you to design them a program which is calculating the Gandalf&#39;s mood. So they could predict the battles between them and try to beat The Gray Wizard.  When Gandalf is hungry he gets angry and he could not fight well. Because the orcs have a spy, he has told them the foods that Gandalf is eating and the result on his mood after he has eaten some food. So here is the list:

- **Cram** : 2 points of happiness;
- **Lembas** : 3 points of happiness;
- **Apple** : 1 point of happiness;
- **Melon** : 1 point of happiness;
- **HoneyCake** : 5 points of happiness;
- **Mushrooms** : -10 points of happiness;
- **Everything else** : -1 point of happiness;

Gandalf moods are:

- **Angry** - below -5 points of happiness;
- **Sad** - from -5 to 0 points of happiness;
- **Happy** - from 1 to 15 points of happiness;
- **JavaScript** - when happiness points are more than 15;

The task is simple. Model an application which is calculating the happiness points, Gandalf has after eating all the food passed in the input. After you are done, print on the first line – total happiness points Gandalf had collected. On the second line – print the **Mood&#39;s** name which is corresponding to the points.

### Input

The input comes from the console. It will hold a single line: all the Gandalf`s foods he has eaten separated by a whitespace.

### Output

Print on the console Gandalf`s happiness points and the **Mood&#39;s** name which is corresponding to the points.

### Constraints

- **** The characters in the input string will be no more than: **1000.**
- **** The food count would be in the range **[1…100]**.
- **** Time limit: 0.3 sec. Memory limit: 16 MB.

### Note

Try to implement a factory pattern. You should have two factory classes – **FoodFactory** and **MoodFactory**. And their task is to produce objects (e.g. **FoodFactory** , produces – **Food** and the **MoodFactory** - **Mood** ). Try to implement abstract classes (e.g. classes which can&#39;t be instantiated directly)

### Examples

| **Input** | **Output** |
| --- | --- |
| Cram melon honeyCake Cake | 7Happy |
| gosho, pesho, meze, Melon, HoneyCake@; | -5Sad |

## Problem 6.\*Animals

Create a hierarchy of **Animals**. Your task is simple: there should be a base class which all others derive from. Your program should have 3 different animals – **Dog** , **Frog** and **Cat**. Let&#39;s go deeper in the hierarchy and create two additional classes – **Kitten** and **Tomcat**. **Kittens are female and Tomcats are male!** We are ready now, but the task is not complete. Along with the animals, there should be also a class which classifies its derived classes as sound producible. You may guess that all animals are sound producible. The only one mandatory functionality of all sound producible objects is to **ProduceSound()**. For instance, the dog should bark.

Your task is to model the hierarchy and test its functionality. Create an animal of all kinds and make them produce sound.

On the console, you will be given some lines of code. Each two lines of code, represents animals and their names, age and gender. On the first line there will be the kind of animal, you should instantiate. And on the next line, you will be given the name, the age and the gender. Stop the process of gathering input, when the command **&quot;Beast!&quot;** is given.

### Output

- On the console, print for each animal you&#39;ve instantiated, its info on three lines. On the first line, print:
{ **Kind of animal** }
- On the second line print it&#39;s { **name** } { **age** } { **gender** }
- On the third line print the sounds it produces: {**ProduceSound()**}

### Constraints

- **** Each **Animal** should have **name** , **age** and **gender**
- **** All properties&#39; values should **not be blank** (e.g. name, age and so on…)
- **** If you enter invalid input for one of the properties&#39; values, throw exception with message: **&quot;Invalid input!&quot;**
- **** Each animal should have a functionality to **ProduceSound()**
- **** Here is example of what each kind of animal should produce when, **ProduceSound()** is called
  - **Dog: &quot;BauBau&quot;**
  - **Cat: &quot;MiauMiau&quot;**
  - **Frog: &quot;Frogggg&quot;**
  - **Kittens: &quot;Miau&quot;**
  - **Tomcat: &quot;Give me one million b\*\*\*h&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| Cat <br/> Macka 12 Female <br/> Dog <br/> Sharo 132 Male <br/> Beast! | Cat <br/>  Macka 12 Female <br/> MiauMiau <br/> Dog <br/>  Sharo 132 Male <br/> BauBau |
| Frog <br/> Sashky 12 Male <br/> Beast! | Frog <br/> Sashky 12 Male <br/> Frogggg |
| Frog <br/> Invalidcho -2 Male <br/> Frog <br/> Validcho 2 Male <br/> Beast! | Invalid input! <rb/> Frog <br/> Validcho 2 Male <br/> Frogggg |