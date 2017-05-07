# <p align="center"> BashSoft - Labs </p>

## _<p align = "center">  BashSoft piece: Stacks and Queues </p>_

### Part I: Creating the base functionality needed

#### Problem 1.Create a Visual Studio Project

Our first task is to **create** a **project** called **BashSoft** , which we will extend until the end of the course so you might want to **save** it **somewhere, where you can** easily **find** it and where you can be **sure** you **won&#39;t delete** it. You can call the class with the **Main()** method, **Launcher** , because from it we will only call the specific functions we want to execute, but our execution logic will be in other classes.

Once you have created the project, you have to add a class that we will call **IOManager** and it will give us the functionality for traversing the folders and other behaviors.

In the next menu you have to choose to create a new class with the name &quot; **IOManager**&quot;

Next the only things we have to **change** over the **generated class** is **to** add it &quot; **public static**&quot; before the keyword **class**. The keyword &quot; **public**&quot; means we can **use** our class **everywhere** in our project. Sometimes we will leave some methods **private** , because we may want to **hide** some of the **functionality** of our class, in front of the other world. The other keyword &quot; **static**&quot; means that we can do &quot; **general/global**&quot; stuff with it. Example: &quot; **Math**&quot;, &quot; **Console**&quot;.

The **opposite** of **static** we can say are classes like &quot; **Stack** , **List** , **StringBuilder** &quot;  for which we have to say &quot; **new List&lt;T&gt;&quot;** in order to create a new list. The static **classes** do not need to be created like we **don&#39;t say &quot;new Math&quot;**, instead we **just use Math.Sqrt()**.

So now your class should look something like this: 

```csharp
public static class IOManager
{
}
```

#### Problem 2.Create a flexible interface for output to the user

So now that we have our first class we are going to have to implement some functionality that this class should have. But before that, first we have to decide **how** are we going **to** communicate with the user efficiently and if this is something that we have to use in many places, how can we change it or replace it easily using doing only a few changes in one place. The solution behind such a problem give us one of the [**Design Patterns**](https://en.wikipedia.org/wiki/Software_design_pattern) which are a topic of the**next course **, but the main idea of this one is that we can** hide **some** functionality**(The writing to the console, which can easily be changed for writing in a file),**by using **a** class **that only gives us** base functionality** for communication with a user.

Our new class can be called **OutputWriter** and you should make it following the steps above as described for the **IOManager**. The **new class** again has to be **public** and **static** and after you&#39;ve created it, it should look something like this:

```csharp
public static class OutputWriter
{
}
```

So now we can add a few methods that we will use throughout our whole app that write to the currently set output.

- The first method gives us the ability to **write a message.**
- The second method to implement is a method for **writing a message on a new line**.
- The third method is to **write a new empty line**.
- The fourth method is to **write a different kind of message** which is an **error/exception**.

The class with the three methods inside it should look something like this:

```csharp
public static class OutputWriter
{
    public static void WriteMessage(string message)
    {
    }

    public static void WriteMessageOnNewLine(string message)
    {
    }

    public static void WriteEmptyLine()
    {
    }

    public static void DisplayException(string message)
    {
    }
 
```

The implementation of the first three methods is pretty common. The **first** one only **writes the message on the console** , and the **second** one **writes the message** and goes to the **next line after that**. The **third** only **writes an empty line on the console**. The **fourth** method however has some small specifics. The specifics are that we need to **get** the **current**** foreground color**(font color),**save it **,** change the foreground color to red **,** write the given message **and finally** change **the** foreground color ****to** the **one**** before**. Here is how this has to look in code:

```csharp
ConsoleColor currentColor = Console.ForegroundColor;
Console.ForegroundColor = Console.Red;
Console.WriteLie(message);
Console.ForegroundColor = currentColor;
```

Now that we are ready with the user output. It&#39;s time to implement the traversal of the folders and in the future, **if** we want to **change** the **output destination** , we **only** need to **change** it here in the **class** we **just made** , and not everywhere where we&#39;ve written **Console.WriteLine()**.

### Part II:  Implementing the traversal alorithm

#### Problem 3.Traversing the folder of the project

Our next task is to learn how to **traverse folders** in order to be able to do all kinds of operations with files that are stored on the hard drive. This is our first small step into the big picture.

We will **traverse the folder** of the project **using**** queue**with a technique called [**BFS**](https://en.wikipedia.org/wiki/Breadth-first_search). [Here](https://upload.wikimedia.org/wikipedia/commons/5/5d/Breadth-First-Search-Algorithm.gif) is a animation that can probably help you understand how **BFS** works, however this is not the main point, so you may just use it, without going into too much depth about how it works.

Shortly we will create a method **TraverseFolder (string path)**. How does it traverse a folder? **First** it **enqueues** the **folder** that we **pass as parameter** in the method signature. After that it **dequeues** every ****folder** in the queue one at a time **until** the **queue** becomes **empty** , **while**** at the sam **e time** enqueues **all** of its **subfolders** at the end of the queue.

For our purposes we will **use** the static class **DirectoryInfo** , which **will** give **us all the** information **we need** for **the** directories we work with, don&#39;t worry you&#39;ll get familiar with it in a few lectures. Here is the initialization of the method with the queue. We **enqueue** the **root** **folder** we wanted to traverse first and also **create** a **variable** for **the** indentation **of the first path, so it can be later** used **for** displaying **the** levels **of depth** we&#39;ve entered while traversing.

```csharp
public static void TraverseDirectory(string path)
{
    OutputWriter.WriteEmptyLine();
    int initialIdentation = path.Split('\\').Length();
    Queue<string> subFolders = new Queue<string>();
    subFolders.Enqueue(path);
}
```

Next we need to make sure we will **traverse** all **of the** subfolders **that we have** in **the** queue **so we will traverse** while **the** queue **is** not empty(that is why we push **the** initial **element** in the queue).

**For each iteration** of **the** while **loop** we want to **dequeue** a **folder** that we are going to traverse and to **print** its **path** , but in order to know how many level in depth we have entered, we are going to **use** another ****indentation**** variable **and** take ****the delta between the two**.

```csharp
while(subFolders.Count() != 0) 
{
    //TODO : Dequeue the folder at the start of the queue
    //TODO: Print the folder path
    //TODO: Add all it's subfolders to the end of the queue 
}
```

Also **for each folder** we need to **iterate** all **its** subfolders **and** add ****them**** to **the end of the** queue. We can do this with a simple foreach loop:

```csharp
string currentPath = subFolders.Dequeue();
int identation = currentPath.Split('\\').Length - initialIdentation;

//TODO: Print the folder path

forech (string directoryPath in Directory.GetDirectories(currentPath))
{
    //TODO: Add all it's subfolders ot the end of the queue
}
```
You can **print** the **full name** of the **directory** with the following line of code:

```csharp
OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string ('-', identation), currentPath));
```
Now if you filled your TODOs properly when you run your code you should get some output like this if we call the method through the **Main()**

```csharp
static void Main()
{
    IOManager.TraverseDirectory(@"E:\Test\TestFolder\NestedFolderTest")
}
```
 You are now ready with your first tool for the wanted bash. Soon you will be able to easily change your position in the file system and do different operations with other files.

 ## _<p align = "center">  BashSoft piece: Sets-And-Dictionaries </p>_

#### Problem 1.Creating a set of error messages to display if a function produces such an error:

Since we are making a **fairly** big **project** , we will have **different** constant ****messages** to display **in** the whole **project** to the user, so a **good**** idea **would be to** extract ****all** these **messages**** in ****one**** place **and be able to** change **what you want** from ****1**** place **only. So now we are going to** create **such a** class **, where to** save **such** messages **that are** used ****often**.
The **class** should be **named**** ExceptionMessages **and is** public **and** static **. The only things we are going to** put **in this class are** public ****const**** strings ****with** a given **name**** and **it&#39;s corresponding** message:

```csharp
public static class ExceptionMessages
{
    public const string ExampleExeptionMessage = "Example message!";
}
```

So from now on, every time we have to add a message you should follow the format described above.

#### Problem 2.Creating a data structure for the Bashsoft

Our next task is to **create** a fast and **efficient data structure** that we can **use** in out command interpreter **to store*** data **, easily** make changes **,** find **wanted** information **or** generate **some** statistics from the data.

**First** thing you have to do is to **open** your **project** from the previous assignment and **set** up a class in which you will store your data. You have to create a new class , following the steps from the previous piece of the story. This class will be called &quot; **StudentsRepository** &quot; and has to be **static** and **public**. By now you should be somewhere around here:

```csharp
public static class StudentRepository
{
}
```

Now it is time to decide what **data structure** to define for our application in order to be able to make **fast operations** and have easy access to your data. Since we have to save different courses, the students in those courses have **unique** usernames and list of grades, we can save them in two nested dictionaries with one additional list. See below:

```csharp
public static bool isDataInitialized = false;
private static Dictionary<string,Dictionary<string,List<int>>> studentsByCourse;
```
We will also **add** a **public** boolean flag **for** whether **the** data structure **we want to have** has been initialized . You may have noticed but we&#39;ve put **private** in front of our **data structure** and that is because we do not want **everybody** outside of this class **to see** our data structure and **change** it, **so** by making it **private** we can **only see** it in the **current** **class** and we will make some of the data searching and filtration throughout public methods that give to the other world the basic operations needed over the **SoftUni** system&#39;s data.

#### Problem 3.Initializing and saving our data

In order to complete our task, we need to **initialize** our **data structure** and **fill it** , so we will **make a new method** that **initializes** the **data structure,** if it is not initialized yet **,** reads the data , if it is, we display a new **message** called **DataAlreadyInitialisedException** that we need to **add** first in the **ExceptionMessages** **class**. It&#39;s message should be: Data is already initialized!The implementation of the method for the initialization should look like this:

```csharp

    public static void InitializeData()
    {
        if (!isDataInitialized)
        {
            OutputWriter.WriteMessageOnNewLine("Reading data...");
            studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            ReadData();
        }
        else
        {
            OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
        }
    }
```

Now it&#39;s time to **fill** the **private ReadData** method (the data will always be valid). It is **private** because we **do not want** to be reachable out of our class.

All we are going to do, is to **read from the console until an empty line is read**. The data you need to read is in the **data.txt** file given with the current document. We also need to **extract** the **information** we need **from** the **input** and **save** it **in** our **data structure.**

```csharp
private static void ReadData()
    {
        var input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            var tokens = input.Split();
            var course = tokens[0];
            var student = tokens[1];
            var mark = int.Parse(tokens[2]);

            //TODO: Add the course and student if they don't exist
            //TODO: Add the mark
           
        }
    }
```
Now we need to **check** if **our course and student** exists **in our data.** If **we** don&#39;t do this **we are sure to get an** exception **. So** if **the** course ****doesn&#39;t exist** we must **initialize the inner**** dictionary **holding the students for the given course. Also** if **the** student **doesn&#39;t** exist we have to **initialize the inner list** with grades. Finally we **add** the mark.

```csharp
 if (!studentsByCourse.ContainsKey(course))
            {
                studentsByCourse.Add(course, new Dictionary<string, List<int>>());
            }

            if (!studentsByCourse[course].ContainsKey(student))
            {
                studentsByCourse[course].Add(student, new List<int>());
            }

            studentsByCourse[course][student].Add(mark);

            input = Console.ReadLine();
```

Finally **after** the **while** loop **we need to** set the isDataInitialized to true and print&quot; **Data read**! &quot; on a new line!

```csharp
 isDataInitialized = true;
 OutputWriter.WriteMessageOnNewLine("Data read");
```
#### Problem 4.Making security checks available before retrieving data from the data structure

Since we are going to make queries to the data structure in this BashSoft piece and also in some others along the track of the course, so it would be a good idea to make a method for the security checks in order to retrieve some data for a given course or for a given student in some course. This way we will save our selves the writing of the checks each time and invoke the methods where such a check is needed. 

So the **first** method **will be** called **IsQueryForCoursePossible** and the **second** will be **called** **IsQueryForStudentPossibl** е. **Both** should be **private** and **static** and as you might guess their **return** type is **bool**. The **first** one take **one** parameter(**the course name**) and the **second** one takes two **parameters** ( **the course name** ) ( **the user name of the student** ). Their definition should look like the following:

```csharp
private static bool IsQueryForCoursePossible(string courseName)
private static bool IsQueryForStudentPossible(string courseName, string studentUserName)
```

Since the **second** method **will have to do half of the checks for the course that are done in the first method we** will ****reuse** the **first**** one and for this reason we are starting with it&#39;s implementation.

First thing we need to **check** in order to search for the given course name, is **whether** the **data**** structure ****is** actually **initialized**. **If** it **hasn&#39;t** been **initialized** we **create** a **new**** message ****in** the **ExceptionsMessages** that is **called**** DataNotInitializedExceptionMessage** and it&#39;s message is : &quot;The data structure must be initialised first in order to make any operations with it.&quot; :

```csharp
private static bool IsQueryForCoursePossible(string courseName)
    {
        if (isDataInitialized)
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayExceotion(ExceptionMessages.DataNotInitializedExceptionMessage);
        }

        return false;
    }
```

 We are now **returning** true ****if** the **data**** structure **has been** initialized **, but we** haven&#39;t ****checked**** whether **the** given ****courseName exists** as a key in the data structure.
So now we have to **add** this **check**** in **the** body ****of** the **if** and **if** the **data**** structure ****contains** the **key** , we **return**** true **while in the** other ****case** we **display** an **exception** that we&#39;ll need to add in the **ExceptionsMessages** called **InexistingCourseInDataBase**** with **the following** message: &quot;The course you are trying to get does not exist in the data base!&quot;

```csharp
 if (studentsByCourse.ContainsKey(courseName))
 {
    return true;
 }
 else
 {
    OutputWriter.DisplayExceotion(ExceptionMessages.InexistingCourseInDataBase);
 }
```

Now that we’ve implemented the first method for the checks, it’s time for it’s **sidekick**. As we’ve said we will reuse the check from the first **method** and also add a check for whether the **given student user name exists** in the data structure of the university. If it is present, **we return true**, if it is not we display an **exception that we’ll need to add** in the ExceptionsMessages called **InexistingStudentInDataBase** with the following message: **“The user name for the student you are trying to get does not exist!” and finally we return false** : 

```csharp
private static bool IsQueryForStudentPossible(string courseName, string studentUserName)
    {
        if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayExceotion(ExceptionMessages.InexistingStudentInDataBase);
        }

        return false;
    }
```

#### Problem 5.Displaying a student entry:

**Before** we continue with the **reading** of the **data** , there is just one last thing we might **add** in order to make our life easier. Since now we have **two** methods **that are going** to ****display**** student **somehow and we might have more things that need to display student after a filter or a sorting for example, by implementing such a method** we ****do**** not ****need**** to write formatting strings in every method **that displays students on the output writer.The given** method **will be** called ****DisplayStudent**** receiving a **KeyValuePair** of string **(user name)** and value:**List&lt;int&gt;** (scores on tasks). A good place to put the print ****student**** method **may be the Student repository, but maybe an even better place is** in **the** output **writer** since it implements the logic for how thing are displayed on the standard output. The implementation of the method should be as follows:

```csharp
public static void PrintStudent(KeyValuePair<string,List<int>> student)
{
    OutputWriter.WriteMessageOnNewLine(string.Format($"{student.Key} - {string.Join(", ", student.Value)}"));
}  
```

#### 6.Reading information from our data

The most basic operations for extracting information will be to **get all students from a given course** and **get all the scores on the tasks**. We need **define two methods**. Let&#39;s start with the **first** one **. It should be** public ****static** with **return** type **void**. It&#39;s **parameters** are the **course**** name **and the** user ****name**** of **the** student **. So** if **the** query ****for** the **given**** student **is** possible **, we need to** print the him on the output and so we give a new student to the **Output** **writer** in order to be printed:

```csharp
public static void GetStudentScoresFromCourse(string courseName, string username)
{
   if (IsQueryForStudentPossible(courseName, username))
   {
      OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
   }
}
```

The other method is analogical. It **gets all students from a given course**** if **the** query **for course is** possible.
**First** we **write** the **course** name **followed by two dots and after that we** foreach **the** collection **with** students **from the given course and** print **all** of the **students**

```csharp
public static void GetAllStudentsFromCourse(string courseName)
{
   if (IsQueryForCoursePossible(courseName))
   {
     OutputWriter.WriteMessageOnNewLine($"{courseName}:");
     foreach (var studentMarksEntry in studentsByCourse[courseName])
     {
        OutputWriter.PrintStudent(studentMarksEntry);
     }
  }
}
```

#### Problem 7.Test your code

If you put the given input and **get all the students from the Unity course** ( query should look like this): 

```csharp
StudentsRepository.InitializeData();
StudentsRepository.GetAllStudentsFromCourse("Unity");
```
Now we want to test the functionality for **getting student&#39;s grades from a given course**. The request should look something like this:

```csharp
StudentsRepository.InitializeData();
StudentsRepository.GetStudentScoresFromCourse("Unity","Ivan");
```

Now we are ready with the current piece and now we can easily keep track of the courses and students inside them and if needed, view some data that we might want. Soon we will **learn** how to make **filters** and **sort** our data so that it is in a more accurate format and moreover we will go into depth about the constraints for the possible course names, user names and scores on a given task.