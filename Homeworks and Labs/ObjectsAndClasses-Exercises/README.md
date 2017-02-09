#<p align="center"> Objects and Classes - Exercises <p>

## 01.Count Working Days
Write a program that reads **two dates** in format **dd-MM-yyyy** and prints the **number of working days** between these two dates **inclusive**. Non-working days are:
- All days that are **Saturday** or **Sunday**.
- All days that are **official holidays** in Bulgaria:
New Year Eve (**1 Jan**)
Liberation Day (**3 March**)
Worker’s day (**1 May**)
Saint George’s Day (**6 May**)
Saints Cyril and Methodius Day (**24 May**)
Unification Day (**6 Sept**)
Independence Day (**22 Sept**)
National Awakening Day (**1 Nov**)
Christmas (**24, 25 and 26 Dec**)
All days not mentioned above are **working** and should count.

####Hints

- Read **start date** and **end date** from Console.
- **Create** two objects of type **DateTime – startDate** and **endDate**.
- Create an **array of type DateTime** and add **all official holidays** in it.
- Loop from **startDate** to **endDate**. Add **1 day** at each iteration.
- Get the **current day** in the loop and check whether is **Saturday**, **Sunday** or it is **contained in the holidays array**. If it is not, increment the **workingDaysCounter**.

## 02.Advertisement Message
Write a program that **generate random fake advertisement message** to extol some product. The messages must consist of 4 parts: laudatory **phrase + event + author + city**. Use the following predefined parts:
- **Phrases** – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
- **Events** – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
- **Author** – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
- **Cities** – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
The format of the output message is: **{phrase} {event} {author} – {city}**.
As an input you take the **number of messages** to be generated. Print each random message at a separate line.

####Hints

- Hold the **phrases, events, authors** and **towns** in 4 arrays of strings.
- Create **Random** object and **generate 4 random numbers** each in its range:
phraseIndex -> [0, phrases.Length)
eventIndex -> [0, events.Length)
authorIndex -> [0, authors.Length)
townIndex -> [0, towns.Length)
- Get one **random element** from each of the four arrays and **compose a message** in the required format.

## 03.Intersection of Circles
Create class **Circle** with properties **Center** and **Radius**. The center is a point with coordinates **X** and **Y** (make a class **Point**). Write a method **bool Intersect(Circle c1, Circle c2)** that tells whether the two given circles **intersect or not**. Write a program that tells if two circles intersect.
The input lines will be in format: **{X} {Y} {Radius}**. Print as output **“Yes”** or **“No”**.

####Hints

- Calculate **d = distance between the circle centers**.
- If the **d ≤ r1 + r2** (the sum of radiuses) -> the circles **intersect** (or one of the circles is inside the other or the circles have one common point when **d = r1 + r2**).
- If the **d > r1 + r2** -> the circles do **not intersect** (they have not common shared point).

## 04.Average Grades
Define a class **Student**, which holds the following information about students: **name, list of grades** and **average grade** (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.
Read a **list of students** and print the students that have **average grade ≥ 5.00** ordered **by name** (ascending), then by **average grade** (descending). Print the student name and the calculated average grade.

####Hints

- Create class **Student** with properties **Name (string), Grades (double[])**, and property **AverageGrade** (calculated by LINQ as **Grades.Average()**, read-only).
- Make a **list of students** and **filter with LINQ** all students that has average **grade >= 5.00**.
- Print the filtered students **ordered by name** in ascending order, then by **average grade** in descending order.

## 05.Book Library 
To model a **book library**, define classes to hold a **book** and a **library**. The library must have a **name** and a **list of books**. The books must contain the **title, author, publisher, release date, ISBN-number** and **price**. 
Read a **list of books**, add them to the library and print the **total sum of prices by author**, ordered **descending by price** and **then by author’s name lexicographically**.
Books in the input will be in format **{title} {author} {publisher} {release date} {ISBN} {price}**.

####Hints
- Create classes **Book** and **Library** with all the mentioned above properties. 
- **Create** an object of type **Library**.
- **Read the input** and create a **Book** object for each book in the input.
- Create a **LINQ** query that will **sum the prices by author, order the results** as requested.
- **Print** the results.

## 06.Book Library Modification
Use the classes from the previous problem and make a program that **read a list of books** and **print all titles released after given date** ordered **by date** and then **by title lexicographically**. The date is given if format **“day-month-year”** at the last line in the input.

## 07.Andrey and billiard
Andrey is the guy who gives us food and drinks at the game bar. He likes to play **billiard**. Since you are nice guy you want to help him play more of his favorite game. You decide to create a program which will help him to take orders faster and generate billing information. 
First you will receive an integer - the **amount** of entities with prices (separated by "-"). Then you will receive a **list** of **client**. For every consumer you will receive **what** to buy and **how much**. When you receive a command: "end of clients" you should display information about every **client** described below. After that say how much total money were **spent** while Andrey was playing billiard.

####Constraints

- If an entity is added more than once you should **override** the previous price.
- If buyer tries to buy an entity that is not existing - you should **ignore** that line.
- Buyers should be **ordered** by name ascending. 
- All floating point digits must be rounded to **2 digits** after decimal separator.
- In the end of **every** buyer his bill should be **summed**.
- Quantity is an integer. Price – floating point.

####Hints

- **Create** a Dictionary<**string, decimal**> as our **shop** that will contain the **price** for every **entity** in it.
- Create class **Customer**. Every customer should have **name, Dictionary<string, int>** for every bought product with **quantity** (something like a **ShopList**) and Bill property.
- Save all customers that their wanted item is **actually in the shop** into a **list**. For every customer go through his “shop list” and **add “price*quantity”** to his Bill.
- For printing every customer you can iterate through every object.
- **Print** result.

##08.Mentor group
You are mentor of a group. You have done your job well and now you have to generate a report about your group's activity. You will be given usernames and dates **("dd/MM/yyyy")**, dates **(if any)** are separated with comma, until you receive command **"end of dates"**. After that you will receive user and some comment (separated with dash). You can add comment for every user who is **in** your group (if **not** ignore the line). Adding comment/date to same user more than once should **append** to that user the comment/date. Upon receiving command **"end of comments"** you should generate report in format:
{user} -
Comments:
- {firstComment} …
Dates attended:
-- {firstDate}
-- {secondDate}
Users should be printed ordered by name (ascending). For every user dates should be sorted again in ascending order. Input will be valid for in the format described - you should **not check** it explicitly!

####Hints
- **Create** a class **Student** with List<**string**> for comments and List<**DateTime**> for attendency dates and a name.
- You can save all students into a **list** or you can save every student in a **dictionary** where the **key** will be the student’s **name** and the **value** will be the **student object** itself.

##09.Teamwork projects
It's time for teamwork projects and you are responsible for making the teams. First you will receive an integer - the **count** of the teams you will have to **register**. You will be given a **user** and a **team** (separated with "-").  The user is the **creator** of that team. For every newly created team you should **print** a message: "Team {team Name} has been created by {user}!". Next you will receive user with team (separated with "->") which means that the user wants to **join** that **team**. Upon receiving command: "end of assignment" you should print every team **ordered** by members count (descending) and then by **name** (ascending). For each team you have to print it's members **sorted** by name (ascending). However there are several **rules**:
- If user tries to **create** a team more than once a message should be displayed: 
_"Team {teamName} was already created!"_
- Creator of a team cannot **create** another team - message should be thrown: 
_"{user} cannot create another team!"_
- If user tries to **join** currently non-existing team a message should be displayed: 
_"Team {teamName} does not exist!"_
- Member of a team cannot **join** another team - message should be thrown:
_"Member {user} cannot join team {team Name}!"_
- In the **end** (_after teams' report_) teams with **zero** members (with **only a creator**) should **disband**.  Every team to disband should be printed ordered by **name** (ascending) in this format:

####Hints
- **Create** a class **Team** with name, List<**string**> for members and again name but his time for the creator.
- Based on this you can have a List<Team> where you can safely **check** for every condition described above.
- **After** populating the teams you can **filter** them into two **separate** collections (one for the teams with only a creator in it and another for the rest)

##10.** Student Groups
At the Software University we often organize programming courses for beginners in different towns. We usually run a **registration form** and after the registration finishes, we distribute the **students** into **study groups**. Groups have different sizes in each town.
You are given a report holding the **registrations for each town** and the **lab capacity** (seats count) for each town. It comes in the following format:
- **Town name => X** seats (where **X** is the capacity of the training lab in this town).
**Student name | student email | registration date** (in format day-month-year). The month name is given as 3 letters in English, e.g. “May”, “Aug” or “Nov”.
- The next student come after the first, etc.
- Then the next town and its students come, etc.
- The input ends by a line holding **“End”**.
Your task is to **create** and **print the study groups** for each town as follows:
- For **each town** create and print one or several **study groups* (depends of the number or registered students and the capacity of the lab in this town).
- For each town **order the students** by registration date (ascending), then by name (ascending) then by email (ascending), then fill them into groups. If the students are less or equal to the lab capacity, create only one group. When the students are more than the lab capacity, distribute them in multiple groups.
- Print all **groups ordered by town** (ascending) in the following format:
- **Created G groups and T towns:**
- **Town1 => email1, email2, …**
- **Town1 => email1, email2, …**
- **…**
- **Town2 => email1, email2, …**
- **…**

#####Hints
Create the **classes** to hold the **students, towns** and **groups**.

