#<p align="center"> Exercises: Methods  <p>

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions [here] (https://judge.softuni.bg/Contests/Practice/Index/418#0).

## 1.Hello, Name!

Write a **method** that receives a name as **parameter** and prints on the console. &quot;Hello, &lt;name&gt;!&quot;

### Examples

| **Input** | **Output** |
| --- | --- |
| Peter | Hello, Peter! |

1. 2.Min Method

Create a **GetMin(int a, int b)**method, that returns the **smaller** of two numbers. Write a program that reads three numbers from the console and prints the **smallest** of them. Use the **GetMin(…)** method you just created.

### Examples

| **Input** | **Output** |  
| --- | --- |
| 1<br/>2<br/>3 | 1 |   
| -100<br/>-101<br/>-102 | -102 |

1. 3.String Repeater

Write a **RepeatString(str, count)**method that receives a **string** and an **integer**** N **as** parameters **and returns the string,** repeated ****N** times. After that, print the result on the console.

```C#
static string RepeatString(string str, int count)
{
    string repeatedString = string.Empty;
    
    for (int i = 0; i < count; i++)
    {
        // TODO
    }

    return repeatedString;
}
```

### Examples

| **Input** | **Output** |   
| --- | --- | 
| str <br/>2 | strstr |
| roki<br/>6 | rokirokirokirokirokiroki |

## 4.Nth Digit

Write a **method** FindNthDigit(number, index) that receives a **number** and an **index N** as **parameters** and returns the **Nth digit** of the number (counted from **right to left** , starting from **1** ). After that, **print** the result on the console.

```C#
static int FindNthDigit(long number, int index)
{
    //…
}

```

### Examples

| **Input** | **Output** | 
| --- | --- | 
| 83746 <br/>2 | 4 |
| 93847837 <br/> 6 | 8 | 
|2435 <br/> 4 | 2 |

### Hints

- Use a **while** loop to perform the algorithm until the given number becomes **0**.
- On every iteration of the **while** loop, check if the **current index** of the number equals the **index** you are looking for. If it is, return the number at that index ( **number % 10** ). If it&#39;s not the correct index, **remove** the last digit from the number ( **number / 10** ).
- Keep track of which **digit** you are checking by **index** ( **right to left** , starting from **1** ). When you **find** the digit, **return** that **index**.

## 5.Integer to Base

Write a **method**** IntegerToBase(number, toBase) **that receives a** number **and a** base **as** parameters **and returns the number,** converted **to that** number base. **After that,** print** the result on the console.

The **number** will **always** be in **base 10** and the **base** parameter will **always** be **between 2 and 10**.

```C#
static string IntegerToBase(long number, int toBase)
{
    //…
}
```
### Examples

| **Input** | **Output** | 
| --- | --- |
| 3 <br/> 2 | 11 | 
|4 <br/> 4 | 10 |
| 9<br/> 7 | 12 |

### Hints

- Declare a variable where the **result** will be stored.
- Perform the calculations, needed to convert the number:
  - Take the **remainder** of the **number** , divided by the **base.**
  - Add the **remainder** to the **front** of the result string.
  - Divide the **number** by the **base**
  - The above algorithm should run **until** the number is **0**

## 6.Notifications

Write 2 methods:

```C#
static string ShowSuccess(string operation, string message)
{
    //…
}

```
which prints a message in the following format:

Successfully executed {operation}.
==============================
Message: {message}. 

and

```C#
static string ShowError(string operation, int code)
{
    //…
}
```

which prints a message in the following format:

Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.


The **reason** is determined by the **code** :

- If the code is **positive** , the reason is &quot; **Invalid Client Data**&quot;
- If the code is **negative** , the reason is &quot; **Internal System Failure**&quot;

Then, create a program which accepts an integer **N**.

On the next **N** lines, the user receives a **result** – &quot; **success**&quot; or &quot; **error**&quot;. If the current operation is **success** , it should prompt the user for an **operation** and a **message**. If the operation is **error** , it should prompt the user for an **operation** and a **code**.

If neither &quot; **success**&quot;, nor &quot; **error**&quot; is given, **nothing** should be printed and the program should **continue**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 <br/> success <br/>User registration<br/>User registered successfully<br/>error<br/>connecting to server <br/>-403 | Successfully executed User registration.<br/>==============================<br/>Message: User registered successfully.<br/>Error: Failed to execute connecting to server.<br/>==============================<br/>Error Code: -403.<br/>Reason: Internal System Failure. |
| 3<br/>success<br/>Database query<br/>Updated 2 rows<br/>warning<br/>error<br/>credit card purchase<br/>2 | Successfully executed Database query.<br/>==============================<br/>Message: Updated 2 rows.<br/>Error: Failed to execute credit card purchase.<br/>==============================<br/>Error Code: 2.<br/>Reason: Invalid Client Data. |

## 7.\* Numbers to Words

Write a method **Letterize(number)** which accepts a number and prints it as **words** , according to these conditions:

- If the number is more than 999 you should print – &quot;too large&quot;
- If the number is less than -999 you should print – &quot;too small&quot;
- If the number is negative, you should print &quot;minus&quot; before it.
- If the number does **not** have 3 digits, **do not** print it

The program should accept an integer **N.** On the next **N lines,** you should accept **numbers** and print them as **words**.

### Examples

| **Input** | **Output** | 
| --- | --- | 
| 3<br/>999<br/>-420<br/>1020 | nine-hundred and ninety nineminus four-hundred and twentytoo large |
| 2<br/>15<br/>350 | three-hundred and fifty |
| 4<br/>311<br/>418<br/>519<br/>-9945 | three-hundred and elevenfour-hundred and eighteenfive-hundred and nineteentoo small | 
|2<br/>500<br/>123 | five-hundredone-hundred and twenty three |

### Hints

- The first set of special cases comes when a number&#39;s right on the **hundreds** (i.e. 100, 200, 300, etc.). Print them like this: &quot; **ne-hundred**&quot;, &quot; **two-hundred**&quot;, &quot; **three-hundred**&quot;.
- The second set of special cases comes when a number&#39;s last 2 digits are **less than 10** (i.e. 101, 305, 609, etc.). Print them like this: &quot; **ne-hundred and one**&quot;, &quot; **three-hundred and five**&quot;, &quot; **six-hundred and nine**&quot;
- The third set of special cases comes when a number is in the **teens** (i.e. **111, 814, 919** ). Print them like this: &quot; **ne-hundred and eleven**&quot;, &quot; **eight-hundred and fourteen**&quot;, &quot; **nine-hundred and nineteen**&quot;

## 8.\* String Encryption

Write a method **Encrypt(char letter)** which encrypts the letter in the following way:

- Take the first and the last digit of its **ASCII** code and append them together in a string.
- Append at the **start** of the resulting string the **character corresponding to** :
  - the **ASCII code** of the letter **+** the **last digit** of the **ASCII code** of the letter
- Then append at the **end** of the resulting string the **character corresponding to** :
  - the **ASCII code** of the letter **-** the **first digit** of the **ASCII code** of the letter
- The method should return the encrypted string.

Example

- j -&gt; p16i
  - **j**&#39;s ASCII code is **106**  **** First digit – **1** , last digit – **6**
  - Append the first and last digit **16**
  - Append the character, resulting from the ASCII code + last digit to the **start** 106 + 6 112 **p**
  - Append the character, resulting from the ASCII code - first digit to the **end** 106 - 1 105 **i**
  - End result **p16i**

Assume that the input for this method will **always** be valid.

The main program should read an input from the user - an integer **N**.

On the next **N lines,** you will receive **characters**. **Encrypt** them and **append** them to an **encrypted string**.

In the end, what you should have is a long **encrypted string** of characters like this:

- S, o, f, t, U, n, i V83Kp11nh12ez16sZ85Mn10mn15h

Your task is to **print** the **encrypted string.**

### Examples

| **Input** | **Output** |
| --- | --- |
| 7<br/>S<br/>o<br/>f<br/>t<br/>U<br/>n<br/>i | V83Kp11nh12ez16sZ85Mn10mn15h |
| 7<br/>B<br/>i<br/>r<br/>a<br/>H<br/>a<br/>x | J72Ah97Xl99Zr17jH66&lt;n15hv14qh97X |

###  Hints

- Start with an empty **result** string – use **string.Empty**.
- Loop **n** times and each time **append** the **encrypted character** to the **result** string.
- To get the **first** and **last** digits of the **ASCII** code, use the same algorithm as the one you&#39;d use to solve the **Integer to Base** problem.