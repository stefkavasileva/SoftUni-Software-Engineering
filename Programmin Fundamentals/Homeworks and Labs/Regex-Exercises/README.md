# <p align="center"> Regex - Exercises <p>

## 01.Extract emails
Write a program to **extract all email addresses from a given text**. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format **<user>@<host>**, where: 
- **<user>** is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: **"stephan"**, **"mike03"**, **"s.johnson"**, **"st_steward"**, **"softuni-bulgaria"**, **"12345"**. Examples of invalid users: **''--123"**, **"....."**, **"nakov_-"**, **"_steve"**, **".info"**. 
- **<host>** is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: **"softuni.bg"**, **"software-university.com"**, **"intoprogramming.info"**, **"mail.softuni.org"**. Examples of invalid hosts: **"helloworld"**, **".unknown.soft."**, **"invalid-host-"**, **"invalid-"**. 
- Examples of **valid emails:** info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
- Examples of **invalid emails:** --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.

#### Examples

| **Input**| **Output**|
|---|---|
|Please contact us at: support@github.com.	|support@github.com|
|Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.|s.miller@mit.edu <br/> j.hopking@york.ac.uk|
|Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.|steve.parker@softuni.de|

## 02.Extract sentences by keyword
Write a program that **extracts from a text all sentences that contain a particular word** (case-sensitive).
- Assume that the **sentences** are separated from each other by the character **"."** or **"!"** or **"?"**.
- The **words** are separated one from another by a **non-letter** character.
- Notе that appearance as **substring** is different than appearance as **word**. The sentence “I am a fan of Motorhead” does not contain the word **“to”**. It contains the substring **“to”** which is not what we need.
- Print the result **sentence text** without the separators between the sentences ("." or "!" or "?").

#### Examples
| **Input** |
|---|
|to |Welcome to SoftUni! You will learn programming, algorithms, problem solving and software technologies. You need to allocate for study 20-30 hours weekly. Good luck! I am fan of Motorhead. To be or not to be - that is the question. TO DO OR NOT?|

|**Output**|
|---|
|Welcome to SoftUni <br/> You need to allocate for study 20-30 hours weekly <br/> To be or not to be - that is the question|

## 03.*Valid Usernames
**This problem is from the Java Basics Exam (21 September 2014 Evening)**.
You are part of the back-end development team of the next Facebook. You are given **a line of usernames**, between one of the following symbols: **space, “/”, “\”, “(“, “)”**. First you have to export all **valid** usernames. A valid username **starts with a letter** and can contain **only letters, digits and “_”**. It cannot be **less than 3 or more than 25 symbols** long. Your task is to **sum** the length of **every 2 consecutive** valid usernames and print on the console the 2 valid usernames with **biggest sum** of their **lengths**, each on a separate line. 

#### Input

The input comes from the console. One line will hold all the data. It will hold **usernames**, divided by the symbols: **space, “/”, “\”, “(“, “)”**. 
The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

Print at the console the 2 **consecutive valid usernames** with the **biggest sum** of their lengths each on a separate line. If there are **2 or more couples** of usernames with the same sum of their lengths, print he **left most**.

#### Constraints

- The input line will hold characters in the range [0 … 9999].
- The usernames should **start with a letter** and can contain **only letters, digits and “_”**.
- The username cannot be **less than 3 or more than 25 symbols** long.
- Time limit: 0.5 sec. Memory limit: 16 MB.

#### Examples

| **Input**| **Output**|
|---|---|
|ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref	|wfsdg <br/> ds2c_vbg
|min23/ace hahah21 (    sasa  )  att3454/a/a2/abc|  hahah21 <br/> sasa|
|chico/ gosho \ sapunerka (3sas) mazut  lelQ_Van4e|mazut <br/> lelQ_Van4e|

## 04.*Query Mess
**This problem is originally from the JavaScript Basics Exam (22 November 2014).** 
**Ivancho** participates in a team **project** with colleagues at **SoftUni**.  They have to develop an **application**, but something mysterious happened – at the last moment all team members… disappeared!  And guess what? He is left **alone** to finish the project.  All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that! Can you help him?

#### Input

The input comes from the console on a variable number of lines and ends when the keyword "END" is received.  
For each row of the input, the query string contains pairs field=value. Within each pair, the field name and value are separated by an equals sign, '='. The series of pairs are separated by an ampersand, '&'. The question mark is used as a separator and is not part of the query string. A URL query string may contain another URL as value. The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

**For each input line, print** on the console a line containing the **processed string as follows:**
**key=[value]nextkey=[another  value]** … etc. 
**Multiple whitespace** characters should be reduced to one inside value/key names, but there shouldn’t be any whitespaces before/after extracted **keys** and **values**. If a key **already exists**, the value is added with comma and space after other values of the existing key in the current string.

#### Constraints
- _SPACE_ is encoded as '+' or "%20". Letters (A-Z and a-z), numbers (0-9), the characters '*', '-', '.', '_' and _other non-special symbols_ are left as-is.
- Allowed working time: 0.1 seconds. Allowed memory: 16 MB.

#### Examples

| **Input**| **Output**|
|---|---|
|login=student&password=student <br/> END|login=[student]password=[student]|
|field=value1&field=value2&field=value3 <br/> http://example.com/over/there?name=ferret <br/> END|field=[value1, value2, value3] <br/> name=[ferret]|
|foo=%20foo&value=+val&foo+=5+%20+203 <br/> foo=poo%20&value=valley&dog=wow+ <br/> url=https://softuni.bg/trainings/coursesinstances/details/1070 <br/> https://softuni.bg/trainings.asp?trainer=nakov&course=oop&course=php <br/> END |foo=[foo, 5 203]value=[val] <br/> foo=[poo]value=[valley]dog=[wow] <br/> url=[https://softuni.bg/trainings/coursesinstances/details/1070] <br/> trainer=[nakov]course=[oop, php]|

## 05.*Use Your Chains, Buddy
**This problem is from the JavaScript Basics Exam (9 January 2015).** 
You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut. You need to get there by car. But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted…
As input you will receive **an HTML document** as a **single string**. You need to get the text from **all the <p> tags** and replace all characters which are **not small letters and numbers** with a space " ". After that you must decrypt the text – all letters **from a to m** are converted to letters **from n to z** (a -> n; b -> o; … m -> z). The letters **from n to z** are **converted** to letters **from a to m** (n -> a; o -> b; … z -> m). All **multiple** spaces should then be replaced by only **one space**.
For example, if we have **"<div>Santa</div><p>znahny # grkg ()&^^^&12</p>"** we extract **"znahny # grkg ()&^^^&12"**. Every **character** that is **not a small letter or a number** is replaced with a space **("znahny grkg       12")**. We convert each small letter as described above **("znahny grkg       12" -> "manual text       12") and replace all multiple spaces with only **one space ("manual text 12")**. Finally, we concatenate the decrypted text from all **<p></p>** tags (in this case, it's only one). And there you go – you have the manual ready to read!

#### Input
The input is read from the console and consists of just one line – the **string** with the **HTML document**.
The input data will always be valid and in the format described. There is no need to check it explicitly.

#### Output

**Print** on a single line the decrypted text of the manual. See the given **examples** below.

#### Constraints
- Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

#### Examples

| **Input**| 
|---|
|<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>|

|**Output**|
|---|
|manual text 12|

| **Input**| 
|---|
|<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>|

|**Output**|
|---|
|when driving in wet slippery snowy conditions snow dchains are absolutely essential for safe handling although snow chains may look intimidating the basic idea is really simple fit them over your tires drive forward slowly and tighten them up in cold wet conditions this is easier said than done but if you put on your tires|
