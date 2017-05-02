# Упражнения: Първи стъпки в коденето

Задачи за упражнение в клас и за домашно към курса [„Основи на програмирането&quot; @ СофтУни](https://softuni.bg/courses/programming-basics).

## 1.Конзолна програмка &quot;Hello C#&quot;

Напишете **конзолна**  **C#**  **програма** , която отпечатва текста &quot; **Hello C#** &quot;.

1. Стартирайте Visual Studio.
2. Създайте нов конзолен проект: [File] [New] [Project].

![Not fount](/Programming%20Basics/Exercises/images/35.PNG=50x50)

3. Изберете от диалоговия прозорец [Visual C#] [Windows] [Console Application]и дайте подходящо име на проекта, например &quot; **HelloCSharp**&quot;:

![Not fount](/Programming%20Basics/Exercises/images/36.PNG)

4. Намерете секцията **Main(string[] args)**. В нея се пише програмен код (команди) на езика C#.
5. Придвижете курсора между отварящата и затварящата скоба **{ }**.
6. Натиснете **[Enter]**след отварящата скоба **{**.

![Not fount](/Programming%20Basics/Exercises/images/37.PNG)

7. Напишете следния програмен код (команда за печатане на текста **&quot;**** Hello C#&quot;**):

``` Console.WriteLine("Hello C#"); ```

Кодът на програмата се пише отместен навътре с една табулацияспрямо отварящата скоба **{**.

![Not fount](/Programming%20Basics/Exercises/images/38.PNG)

8. **Стартирайте** програмата с натискане на **[Ctrl+F5]**. Трябва да получите следния резултат:

![Not fount](/Programming%20Basics/Exercises/images/39.PNG)
 
9. **Тествайте** решението на тази задача в онлайн judge системата на СофтУни. За целта първо отворете [https://judge.softuni.bg/Contests/Practice/Index/150#0](https://judge.softuni.bg/Contests/Practice/Index/150#0). Влезте с вашия потребител в СофтУни. Ще се появи прозорец за изпращане на решения за задача &quot; **Hello CSharp**&quot;. Копирайте сорс кода от Visual Studio и го поставете в полето за изпращане на решения:

![Not fount](/Programming%20Basics/Exercises/images/40.PNG)

10. **Изпратете решението** за оценяване с бутона [**Submit**]. Ще получите резултата след няколко секунди в таблицата с изпратени решения в judge системата:

![Not fount](/Programming%20Basics/Exercises/images/41.PNG)

## 2.Конзолна програма &quot;Expression&quot;

Напишете **конзолна**  **C#**  **програма** , която пресмята и отпечатва стойността на следния **числен израз** :

``` (3522 + 52353) \* 23 - (2336 \* 501 + 23432 - 6743) \* 3 ```

Забележка: не е разрешено да се пресметне стойността предварително (например с Windows Calculator).

1. Направете нов C# конзолен проект с име &quot; **Expression**&quot;.
2. Намерете метода &quot; **static void Main(string[] args)** &quot; и влезте в неговото тяло между **{** и **}**.
3. Сега трябва да напишете кода, който да изчисли горния числен израз и да отпечата на конзолата стойността му. Подайте горния числен израз в скобите на командата **Console.WriteLine()**:

![Not fount](/Programming%20Basics/Exercises/images/42.PNG)
 
4. Стартирайте програмата с [Ctrl+F5] и проверете дали вашият резултат прилича на нашия:

![Not fount](/Programming%20Basics/Exercises/images/43.PNG)

5. Тествайте вашата програма в judge системата: [https://judge.softuni.bg/Contests/Practice/Index/150#1](https://judge.softuni.bg/Contests/Practice/Index/150#1).

![Not fount](/Programming%20Basics/Exercises/images/44.PNG)

## 3.Числата от 1 до 20

Напишете C# конзолна програма, която отпечатва числата от 1 до 20 на отделни редове на конзолата.

1. Създайте конзолно C# приложение с име &quot; **Nums1To20**&quot;:

![Not fount](/Programming%20Basics/Exercises/images/45.PNG)
 
2. Напишете 20 команди **Console.WriteLine()**, една след друга, за да отпечатате числата от 1 до 20.

![Not fount](/Programming%20Basics/Exercises/images/46.PNG)
 
3. **Тествайте** вашето решение на задачата в judge системата: [https://judge.softuni.bg/Contests/Practice/Index/150#2](https://judge.softuni.bg/Contests/Practice/Index/150#2)
4. Можете ли да напишете програмата по **по-умен начин** , така че да не повтаряте 20 пъти една и съща команда? Потърсете в Интернет информация за „ [**for loop C#**](https://www.google.com/search?q=for+loop+C%23)&quot;.

## 4.Триъгълник от 55 звездички

Напишете C# конзолна програма, която отпечатва **триъгълник от 55 звездички** , разположени на 10 реда:

```
*
**
***
****
*****
******
*******
********
*********
**********
```

1. Създайте ново конзолно C# приложение с име &quot; **TriangleOf55Stars**&quot;.
2. Напишете код, който печата триъгълника от звездички, например чрез 10 команди, подобни на **Console.WriteLine(&quot;\*&quot;)**.
3. **Тествайте** кода си в judge системата: [https://judge.softuni.bg/Contests/Practice/Index/150#3](https://judge.softuni.bg/Contests/Practice/Index/150#3).
4. Опитайте да подобрите решението си, така че да няма много повтарящи се команди. Може ли това да стане с **for**  **цикъл**?

## 5.Лице на правоъгълник

Напишете C# програма, която прочита от конзолата две числа **a** и **b** , пресмята и отпечатва **лицето на правоъгълник** със страни **a** и **b**. Примерен вход и изход:

| **a** | **b** | **area** |
| --- | --- | --- |
| 2 | 7 | 14 |
| 7 | 8 | 56 |
| 12 | 5 | 60 |

1. Направете конзолна C# програма. За да прочетете двете числа, използвайте следния код:

```csharp
static void Main(string[] args)
{
    var a = decimal.Parse(Console.ReadLine());
    var b = decimal.Parse(Console.ReadLine());
            
    // TODO: calculate the area and print it
}
```

2. Допишете програмата по-горе, за да пресмята лицето на правоъгълника и да го проверява.
3. Тествайте решението си в judge системата: [https://judge.softuni.bg/Contests/Practice/Index/150#4](https://judge.softuni.bg/Contests/Practice/Index/150#4).

## 6.\* Квадрат от звездички

Напишете C# конзолна програма, която прочита от конзолата цяло положително число **N** и отпечатва на конзолата **квадрат от**  **N**  **звездички** , като в примерите по-долу:

| **вход** | **изход** |
| --- | --- |
| 3 | *** <br/>  * * <br/> *** |

1. Направете конзолна C# програма. За да прочетете числото **N** (2 ≤ N ≤100), използвайте следния код:

```csharp
static void Main(string[] args)
{
    var n = int.Parse(Console.ReadLine());
            
    // TODO: print the rectangle
}
```

2. Допишете програмата по-горе, за да отпечатва квадрат, съставен от звездички. Може да се наложи да използвате **for-** **цикли**. Потърсете информация в Интернет.
3. Тествайте решението си в judge системата: [https://judge.softuni.bg/Contests/Practice/Index/150#5](https://judge.softuni.bg/Contests/Practice/Index/150#5).