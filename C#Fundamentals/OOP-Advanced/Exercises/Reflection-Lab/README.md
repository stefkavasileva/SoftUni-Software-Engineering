# <p align="center"> Lab: Reflection </p>

Problems for exercises and homework for the [&quot;CSharp OOP Advanced&quot; course @ SoftUni.](https://softuni.bg/trainings/1637/c-sharp-oop-advanced-july-2017)

You can check your solutions here: [https://judge.softuni.bg/Contests/710/Reflection-Lab](https://judge.softuni.bg/Contests/710/Reflection-Lab)

##  1.Stealer

Add the Hacker class from the box below to your project.

```csharp
public class Hacker
{
    public string username = "securityGod82";
    private string password = "mySuperSecretPassw0rd";

    public string Password
    {
        get => this.password;
        set => this.password = value;
    }

    private int Id { get; set; }

    public double BankAccountBalance { get; private set; }

    public void DownloadAllBankAccountsInTheWorld()
    {        
    }
}
```
There is one really nasty hacker but not so wise though. He is trying to steal a big amount of money and transfer it to his own account. The police is after him but they need a proffessional… Correct - this is you!

        You have the information that this hacker is keeping some of his info in private fields. Create a new class named **Spy** and add inside a method called - **StealFieldInfo** which receives:

- stirng - name of the class to investigate
- array of string - names of the filds to investigate

After finding the fields you must print on the console:

&quot;Class under investigation: **{nameOfTheClass}**&quot;

On the next lines print info about each field in the current format:

&quot; **{filedName}** = **{fieldValue}**&quot;

Use **StringBuilder** to concatenate the answer **. Don&#39;t change anything in &quot;Hacker&quot; class!**

In your main Method you should be able to check your program with the current piece of code.

```csharp
public static Main()
{
	Spy spy = new Spy();
	string result = spy.StealFieldInfo("Hacker", "username", "password");
	Console.WriteLine(result);
}
```
### Example

| **Output** |
| --- |
| Class under investigation: Hacker <br/> username = securityGod82 <br/> password = mySuperSecretPassw0rd |

### Solution

```csharp
 public string StealFieldInfo(string className, params string[] fieldsName)
    {
        var classType = Type.GetType(className);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic |
                                         BindingFlags.Public);

        var classInstance = Activator.CreateInstance(classType, new object[] { });
        var sb = new StringBuilder();

        sb.AppendLine($"Class under investigation: {className}");
        foreach (var field in fields.Where(f => fieldsName.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }
```
## 2.High Quality Mistakes

You are already expert of **High Quality Code** , so you know what kind of **access modifiers** must be set to members of class. You should have noticed our hacker is not familiar with these concepts.

Create a method inside your Spy class called - **AnalyzeAcessModifiers**** ( ****stirng className**** ) **. Check all** fields and methods access modifiers **. Print on console all** mistakes** in format:

- Fields
  - **oo**** {fieldName} must be private!**
- Getters
  - **oo**** {methodName} have to be public!**
- Setters
  - **oo**** {methodName} have to be private!**

Use **StringBuilder** to concatenate the answer **. Don&#39;t change anything in &quot;Hacker&quot; class!**

In your main Method you should be able to check your program with the current piece of code.

``csharp
var result = spy.AnalyzeAcessModifiers("Hacker");
Console.WriteLine(result);
```
### Example

| **Output** |
| --- |
| username must be private! <br/> get\_Id have to be public! <br/> set\_Password have to be private! |

### Solution

```csharp
 public string AnalyzeAcessModifiers(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        foreach (var fieldInfo in fields)
        {
            sb.AppendLine($"{fieldInfo.Name} must be private!");
        }

        var propsGet = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var property in propsGet.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{property.Name} have to be public!");
        }

        var propsSet = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        foreach (var property in propsSet.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{property.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
```
## 3.Mission Private Impossible

It&#39;s time to see what this hacker you are dealing with aims to do.  Create a method inside your Spy class called - **RevealPrivateMethods**** ( ****stirng className**** )**. Print all private methods in the following format:

All Private Methods of Class: **{className}**

Base Class: **{baseClassName}**

On the next lines print found method&#39;s names each on new line

Use **StringBuilder** to concatenate the answer **. Don&#39;t change anything in &quot;Hacker&quot; class!**

In your main Method you should be able to check your program with the current piece of code.

```csharp
var result = spy.RevealPrivateMethods("Hacker");
Console.WriteLine(result);
```
### Example

| **Output** |
| --- |
| All Private Methods of Class: Hacker <br/> Base Class: Object <br/> get\_Id <br/> set\_Id <br/> set\_BankAccountBalance <br/> Finalize <br/> MemberwiseClone |

### Solution

```csharp
 public string RevealPrivateMethods(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in methods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }
```
## 4.Collector

Using reflection to get all &quot;Hacker&quot; methods. Then prepare algorithm that will recognize, which methods are getters and setters.

Print to console each getter on new line in format:

**{name} will return {Return Type}**

Then print all setters in format:

**{name} will set field of {Parameter Type}**

Use **StringBuilder** to concatenate the answer **. Don&#39;t change anything in &quot;Hacker&quot; class!**

In your main Method you should be able to check your program with the current piece of code.

```csharp
var result = spy.CollectGettersAndSetters("Hacker");
Console.WriteLine(result);
```
### Example

| **Output** |
| --- |
| get\_Password will return System.String <br/> get\_Id will return System.Int32 <br/> get\_BankAccountBalance will return System.Double <br/> set\_Password will set field of System.String <br/> set\_Id will set field of System.Int32 <br/> set\_BankAccountBalance will set field of System.Double |

### Solution

```csharp
public string CollectGettersAndSetters(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var methodInfo in methods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{methodInfo.Name} will return {methodInfo.ReturnType}");
        }

        foreach (var methodInfo in methods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{methodInfo.Name} will set field of {methodInfo.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
```
