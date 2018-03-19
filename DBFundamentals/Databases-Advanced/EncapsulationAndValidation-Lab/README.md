# <p align="center"> Encapsulation And Validation - Lab</p>

## Lab: Encapsulation and Validation

Problems for exercises and homework for the [&quot;CSharp DB Advanced&quot; course @ Software University](https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017).

### 1.Sort Persons by Name and Age

Create a class **Person** , which should have **private** fields for:

- firstName: string
- lastName: string
- age: int
- ToString(): string - override

You should be able to use the class like this:

```csharp
public static void Main()
{
    var lines = int.Parse(Console.ReadLine());
    var persons = new List<Person>();
    for (int i = 0; i < lines; i++)
    {
        var cmdArgs = Console.ReadLine().Split();
        var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
        persons.Add(person);
    }

    persons.OrderBy(p => p.FirstName)
           .ThenBy(p => p.Age)
           .ToList()
           .ForEach(p => Console.WriteLine(p.ToString()));
}
```

### Examples

| **Input** | **Output** |
| --- | --- |
| 5 <br/> Asen Ivanov 65 <br/>Boiko Borisov 57 <br/>Ventsislav Ivanov 27 <br/>Asen Harizanoov 44 <br/>Boiko Angelov 35 | Asen Harizanoov is a 44 years old <br/>Asen Ivanov is a 65 years old <br/>Boiko Angelov is a 35 years old <br/>Boiko Borisov is a 57 years old <br/>Ventsislav Ivanov is a 27 years old |

### Solution

Create a **new class** and ensure **proper naming**. Define the **private** fields

![Not fount](/DBFundamentals/Databases-Advanced/images/11.png)

Create a constructor for Person, which takes 3 parameters firstName, lastName, age.

![Not fount](/DBFundamentals/Databases-Advanced/images/12.png)

Create properties for these fields, which are as strictly as possible

![Not fount](/DBFundamentals/Databases-Advanced/images/13.png)

Override **ToString()** method:

![Not fount](/DBFundamentals/Databases-Advanced/images/14.png)

## 2.Salary Increase

**Refactor project from last task.**

Read person with their names, age and salary. Read percent bonus to every person salary. Persons younger than 30 get half bonus. Expand **Person** from previous task. New **fields** and **methods:**

- salary: double
- IncreaseSalary(double bonus)

You should be able to use the class like this:

```csharp
var lines = int.Parse(Console.ReadLine());
var persons = new List<Person>();
for (int i = 0; i < lines; i++)
{
    var cmdArgs = Console.ReadLine().Split();
    var person = new Person(cmdArgs[0], 
                            cmdArgs[1],
                            int.Parse(cmdArgs[2]), 
                            double.Parse(cmdArgs[3]));

    persons.Add(person);
}
var bonus = double.Parse(Console.ReadLine());

// TODO: Increase each person's salary by the bonus

persons.ForEach(p => Console.WriteLine(p.ToString()));
```

### Examples

| **Input** | **Output** |
| --- | --- |
|5<br/> Asen Ivanov 65 2200<br/> Boiko Borisov 57 3333<br/> Ventsislav Ivanov 27 600<br/> Asen Harizanoov 44 666.66<br/> Boiko Angelov 35 559.4<br/> 20|Asen Ivanov get 2640.00 leva<br/> Boiko Borisov get 3999.60 leva<br/> Ventsislav Ivanov get 660.00 leva<br/> Asen Harizanoov get 799.99 leva<br/> Boiko Angelov get 671.28 leva|

### Solution

Add new **private** field for **salary** and **refactor constructor**. Add new **method** , which will **update** salary with bonus

![Not fount](/DBFundamentals/Databases-Advanced/images/15.png)

Refactor **ToString()** method for this task.

### 3.Validation Data

Expand Person with proper validation for every field:

- **Names must be at least 3 symbols**
- **Age must not be zero or negative**
- **Salary can&#39;t be less than 460.0**

Print proper message to end user (look at example for messages).

Use **ArgumentException** with messages from example.

### Examples

| **Input** | **Output** |
| --- | --- |
|5<br/> Asen Ivanov -6 2200<br/> B Borisov 57 3333<br/> Ventsislav Ivanov 27 600<br/> Asen H 44 666.66<br/> Boiko Angelov 35 300<br/> 20|Age cannot be zero or negative integer<br/> First name cannot be less than 3 symbols<br/> Last name cannot be less than 3 symbols<br/> Salary cannot be less than 460 leva<br/> Ventsislav Ivanov get 660.0 leva|

### Solution

Add validation to all setters in Person. Validation may look like this or something similar:

![Not fount](/DBFundamentals/Databases-Advanced/images/16.png)

### 4.First and Reserve Team

Create a Team class. Add to this team all person you read. All person younger than 40 go in first team, others go in reverse team. At the end print first and reserve team sizes.

The class should have **private fields** for:

- name: string
- firstTeam: **List&lt;Person&gt;**
- reserveTeam: **List&lt;Person&gt;**

The class should have **constructors** :

- **Team(string name)**

The class should also have **public methods** for:

- **AddPlayer**** (Person person): **** void**
- **FirstTeam:**   **IReadOnlyCollection**
- **ReserveTeam:**   **IReadOnlyCollection**

You should be able to use the class like this:

![Not fount](/DBFundamentals/Databases-Advanced/images/17.png)

You should **NOT** be able to use the class like this:

![Not fount](/DBFundamentals/Databases-Advanced/images/18.png)

### Examples

| **Input** | **Output** |
| --- | --- |
| 5<br/> Asen Ivanov 20 2200<br/> Boiko Borisov 57 3333<br/> Ventsislav Ivanov 27 600<br/> Grigor Dimitrov 25 666.66<br/> Boiko Angelov 35 555|First team have 4 players <br/> Reserve team have 1 players|

### Solution

Addnew class Team. Its fields and constructor look like:

![Not fount](/DBFundamentals/Databases-Advanced/images/19.png)

Properties for FirstTeam and ReserveTeam have only getters:

![Not fount](/DBFundamentals/Databases-Advanced/images/20.png)

There will be only one method, which add players to teams:

![Not fount](/DBFundamentals/Databases-Advanced/images/21.png)
