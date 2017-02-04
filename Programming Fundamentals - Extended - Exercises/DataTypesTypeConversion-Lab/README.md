#<p align="center"> Data Types: Numeral Types and Type Conversion - Lab <p>

## 01.Time Since Birthday
Write program to enter an integer number of **years** and convert it to **days, hours** and **minutes**.

####Hints

- Use appropriate data type to fit the result after each data conversion.
- Assume that every year has 365 days

## 02.Circle Perimeter (12 Digits Precision)
Write program to enter a radius **r** (real number) and **print the perimeter** of a circle with exactly **12 digits** after the decimal point. Use data type of **enough precision** to hold the results.

##03.Exact Product of Real Numbers
Write program to enter **n** numbers and calculate and print their **exact product** (without rounding).

####Hints

- If you use types like **float** or **double**, the result will lose some of its precision. Also it might be printed in scientific notation.
- You might use the **decimal** data type which holds real numbers with high precision with less loss.
- Note that **decimal** numbers sometimes hold the unneeded zeroes after the decimal point, so **0m** is different than **0.0m** and **0.00000m**.

##04.Transport
Calculate how many courses will be needed to **transport n persons** by using 3 vehicles of **capacity 4, 8 and 12** respectively. The input holds one line: the **number of people n**. The vehicles **can** travel at the same time.

####Hints

- You should **divide n by the sum of all the cars’ capacity**. This gives you the number of full courses (e.g. 25 / 24 = 1.04).
- If n does not divide without a remainder, you will need one additional partially full course (e.g. 25 % 24 = 1).
- Another approach is to round up **n / (4+8+12)** to the nearest integer (ceiling), e.g. 25/24 = 1.04  rounds up to 2.
