# <p align="center"> Lab: Interfaces And Abstraction </p>

Problems for exercises and homework for the [https://softuni.bg/courses/csharp-oop-advanced-high-quality-code](https://softuni.bg/courses/csharp-oop-advanced-high-quality-code)

You can check your solutions here: [https://judge.softuni.bg/Contests/Compete/Index/705#1](https://judge.softuni.bg/Contests/Compete/Index/705#1)

## 01.Shapes

Build hierarchy of interfaces and classes:

| &lt;&lt;inteface&gt;&gt;&lt;&lt;Drawable&gt;&gt; |
| --- |
| **+Draw()** |

| Rectangle |
| --- |
| **-width: Integer**  <br/> **-height: Integer** |

| **Circle** |
| --- |
| **-radius: Integer** |

You should be able to use the class like this:

``` csharp
var radius = int.Parse(Console.ReadLine());
IDrawable circle = newCircle(radius);

var width = int.Parse(Console.ReadLine());
var height = int.Parse(Console.ReadLine());

IDrawable rect = newRectangle(width, height); 

circle.Draw();
rect.Draw(); 
```
## 02.Cars

Build hierarchy of interfaces and classes:

| &lt;&lt;IElectricCar&gt;&gt; |
| --- |
| **+Battery: int** |

| &lt;&lt;ICar&gt;&gt; |
| --- |
| **+Model:  string** <br/>  **+Color:  string** <br/> **+Start(): string** <br/> **+Stop(): string** |



| Tesla |
| --- |
| **+ToString(): string** |

| Audi |
| --- |
| **+ToString(): string** |

Your hierarchy have to be used with this code

```csharp
ICar seat = newSeat("Leon&quot", "Grey");
ICar tesla = newTesla("Model 3, Red, 2);

Console.WriteLine(seat.ToString())
;Console.WriteLine(tesla.ToString()); 
```
### Examples

| **Input** | **Output** |
| --- | --- |
|   | Grey Seat Leon <br/> Engine start <br/> Breaaak! <br/> Red Tesla Model 3 with 2 Batteries <br/> Engine start <br/> Breaaak! |
